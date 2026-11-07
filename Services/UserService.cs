using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using OccupancyMonitor.Models;

namespace OccupancyMonitor.Services
{
    public class UserService
    {
        private readonly ApiClient _apiClient;

        public UserService(ApiClient apiClient)
        {
            _apiClient = apiClient ?? throw new ArgumentNullException(nameof(apiClient));
        }

        public async Task<List<User>> GetUsersAsync(string accessToken)
        {
            var users = await _apiClient.GetAsync<List<User>>("users", accessToken);
            return users ?? new List<User>();
        }

        public async Task<List<UserProfile>> GetProfilesAsync(string accessToken)
        {
            var profiles = await _apiClient.GetAsync<List<UserProfile>>("user_profiles", accessToken);
            return profiles ?? new List<UserProfile>();
        }

        public async Task<List<UserRole>> GetRolesAsync(string accessToken)
        {
            var roles = await _apiClient.GetAsync<List<UserRole>>("roles", accessToken);
            return roles ?? new List<UserRole>();
        }

        public async Task<User> CreateUserAsync(
            User user, UserProfile profile, string password, string accessToken)
        {
            var request = new CreateUserRequest
            {
                username = user.username,
                password = password,
                full_name = user.full_name,
                role_id = user.role_id,
                status = user.status
            };

            var createdUser = await _apiClient.PostAsync<CreateUserRequest, User>(
                "users", request, accessToken);

            if (createdUser == null || createdUser.user_id <= 0)
            {
                var users = await GetUsersAsync(accessToken);
                createdUser = users.FirstOrDefault(
                    item => string.Equals(item.username, user.username, System.StringComparison.OrdinalIgnoreCase));
            }

            if (createdUser == null || createdUser.user_id <= 0)
            {
                throw new InvalidOperationException(
                    "The API created the user but did not return a user ID, so the profile could not be saved.");
            }

            var profileRequest = ToProfileRequest(createdUser.user_id, profile);
            try
            {
                await _apiClient.PostAsync<UserProfileRequest, UserProfile>(
                    "user_profiles", profileRequest, accessToken);
            }
            catch (System.Exception profileError)
            {
                try
                {
                    await _apiClient.DeleteAsync<object>("users/" + createdUser.user_id, accessToken);
                }
                catch (System.Exception cleanupError)
                {
                    throw new InvalidOperationException(
                        "The user was created but its profile failed, and the account cleanup also failed.",
                        new System.AggregateException(profileError, cleanupError));
                }

                throw;
            }

            return createdUser;
        }

        public async Task UpdateUserAsync(
            User user, UserProfile profile, string password, bool profileExists, string accessToken)
        {
            var userRequest = new UpdateUserRequest
            {
                username = user.username,
                password = password,
                full_name = user.full_name,
                role_id = user.role_id,
                status = user.status
            };

            await _apiClient.PutAsync<UpdateUserRequest, User>(
                "users/" + user.user_id, userRequest, accessToken);
            try
            {
                var profileRequest = ToProfileRequest(user.user_id, profile);
                if (profileExists)
                {
                    await _apiClient.PutAsync<UserProfileRequest, UserProfile>(
                        "user_profiles/" + user.user_id, profileRequest, accessToken);
                }
                else
                {
                    await _apiClient.PostAsync<UserProfileRequest, UserProfile>(
                        "user_profiles", profileRequest, accessToken);
                }
            }
            catch (System.Exception profileError)
            {
                throw new InvalidOperationException(
                    "Account information was updated, but profile details could not be saved. Reload the user before retrying.",
                    profileError);
            }
        }

        public Task<object> DeleteUserAsync(int userId, string accessToken)
        {
            return _apiClient.DeleteAsync<object>("users/" + userId, accessToken);
        }

        private static UserProfileRequest ToProfileRequest(int userId, UserProfile profile)
        {
            return new UserProfileRequest
            {
                user_id = userId,
                first_name = profile.first_name,
                middle_name = profile.middle_name,
                last_name = profile.last_name,
                contact_number = profile.contact_number
            };
        }
    }
}
