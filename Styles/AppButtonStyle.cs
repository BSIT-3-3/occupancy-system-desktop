using System;
using System.Drawing;
using System.Windows.Forms;

namespace OccupancyMonitor.Styles
{
    public static class AppButtonStyle
    {
        private static readonly Font ButtonFont = new Font("Segoe UI", 9F, FontStyle.Bold);

        public static void Apply(Button button, AppButtonType type = AppButtonType.Secondary)
        {
            if (button == null) throw new ArgumentNullException(nameof(button));

            Color back;
            Color foreground;
            Color border;
            Color hover;
            Color pressed;
            GetColors(type, out back, out foreground, out border, out hover, out pressed);

            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = type == AppButtonType.Secondary ? 1 : 0;
            button.FlatAppearance.BorderColor = border;
            button.FlatAppearance.MouseOverBackColor = hover;
            button.FlatAppearance.MouseDownBackColor = pressed;
            button.BackColor = back;
            button.ForeColor = foreground;
            button.Font = ButtonFont;
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;
        }

        private static void GetColors(
            AppButtonType type,
            out Color back,
            out Color foreground,
            out Color border,
            out Color hover,
            out Color pressed)
        {
            switch (type)
            {
                case AppButtonType.Primary:
                    back = Color.FromArgb(45, 96, 126);
                    foreground = Color.White;
                    border = Color.FromArgb(45, 96, 126);
                    hover = Color.FromArgb(37, 79, 104);
                    pressed = Color.FromArgb(29, 63, 83);
                    break;
                case AppButtonType.Danger:
                    back = Color.FromArgb(164, 63, 70);
                    foreground = Color.White;
                    border = Color.FromArgb(164, 63, 70);
                    hover = Color.FromArgb(143, 49, 57);
                    pressed = Color.FromArgb(119, 40, 47);
                    break;
                default:
                    back = Color.FromArgb(240, 244, 247);
                    foreground = Color.FromArgb(43, 58, 71);
                    border = Color.FromArgb(190, 202, 212);
                    hover = Color.FromArgb(225, 233, 239);
                    pressed = Color.FromArgb(210, 222, 231);
                    break;
            }
        }
    }
}
