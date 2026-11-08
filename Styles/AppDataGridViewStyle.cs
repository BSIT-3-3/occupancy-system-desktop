using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace OccupancyMonitor.Styles
{
    public static class AppDataGridViewStyle
    {
        private static readonly Color HeaderBack = Color.FromArgb(39, 60, 78);
        private static readonly Color HeaderText = Color.White;
        private static readonly Color BodyText = Color.FromArgb(38, 50, 61);
        private static readonly Color AlternateBack = Color.FromArgb(245, 248, 250);
        private static readonly Color SelectedBack = Color.FromArgb(216, 233, 244);
        private static readonly Color HoverBack = Color.FromArgb(234, 242, 247);
        private static readonly Color GridLine = Color.FromArgb(220, 228, 234);
        private static readonly Font BodyFont = new Font("Segoe UI", 9F, FontStyle.Regular);
        private static readonly Font HeaderFont = new Font("Segoe UI", 9F, FontStyle.Bold);

        public static void Apply(DataGridView grid)
        {
            if (grid == null) throw new ArgumentNullException(nameof(grid));

            grid.EnableHeadersVisualStyles = false;
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.GridColor = GridLine;
            grid.ColumnHeadersHeight = 40;
            grid.RowTemplate.Height = 38;

            grid.DefaultCellStyle.Font = BodyFont;
            grid.DefaultCellStyle.ForeColor = BodyText;
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.SelectionBackColor = SelectedBack;
            grid.DefaultCellStyle.SelectionForeColor = BodyText;
            grid.DefaultCellStyle.Padding = new Padding(8, 3, 8, 3);

            grid.RowsDefaultCellStyle.BackColor = Color.White;
            grid.RowsDefaultCellStyle.ForeColor = BodyText;
            grid.RowsDefaultCellStyle.SelectionBackColor = SelectedBack;
            grid.RowsDefaultCellStyle.SelectionForeColor = BodyText;
            grid.AlternatingRowsDefaultCellStyle.BackColor = AlternateBack;
            grid.AlternatingRowsDefaultCellStyle.ForeColor = BodyText;
            grid.AlternatingRowsDefaultCellStyle.SelectionBackColor = SelectedBack;
            grid.AlternatingRowsDefaultCellStyle.SelectionForeColor = BodyText;

            grid.ColumnHeadersDefaultCellStyle.BackColor = HeaderBack;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = HeaderText;
            grid.ColumnHeadersDefaultCellStyle.Font = HeaderFont;
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
            grid.RowHeadersDefaultCellStyle.BackColor = HeaderBack;
            grid.RowHeadersDefaultCellStyle.ForeColor = HeaderText;
            grid.RowHeadersDefaultCellStyle.SelectionBackColor = HeaderBack;

            var kryptonGrid = grid as KryptonDataGridView;
            if (kryptonGrid != null)
            {
                ApplyKryptonPalette(kryptonGrid);
            }
        }

        private static void ApplyKryptonPalette(KryptonDataGridView grid)
        {
            grid.StateCommon.Background.Color1 = Color.White;
            grid.StateCommon.Background.Color2 = Color.White;
            grid.StateCommon.Background.ColorStyle = PaletteColorStyle.Solid;

            grid.StateCommon.HeaderColumn.BackStyle = PaletteBackStyle.GridHeaderColumnList;
            grid.StateCommon.HeaderColumn.Back.Color1 = HeaderBack;
            grid.StateCommon.HeaderColumn.Back.Color2 = HeaderBack;
            grid.StateCommon.HeaderColumn.Back.ColorStyle = PaletteColorStyle.Solid;
            grid.StateCommon.HeaderColumn.Content.Font = HeaderFont;
            grid.StateCommon.HeaderColumn.Content.Color1 = HeaderText;
            grid.StateCommon.HeaderColumn.Content.Padding = new Padding(8, 0, 8, 0);

            grid.StateCommon.HeaderRow.BackStyle = PaletteBackStyle.GridHeaderRowList;
            grid.StateCommon.HeaderRow.Back.Color1 = HeaderBack;
            grid.StateCommon.HeaderRow.Back.Color2 = HeaderBack;
            grid.StateCommon.HeaderRow.Back.ColorStyle = PaletteColorStyle.Solid;
            grid.StateCommon.HeaderRow.Content.Font = HeaderFont;
            grid.StateCommon.HeaderRow.Content.Color1 = HeaderText;

            grid.StateCommon.DataCell.BackStyle = PaletteBackStyle.GridDataCellList;
            grid.StateCommon.DataCell.Content.Font = BodyFont;
            grid.StateCommon.DataCell.Content.Color1 = BodyText;
            grid.StateCommon.DataCell.Border.Draw = InheritBool.True;
            grid.StateCommon.DataCell.Border.DrawBorders = PaletteDrawBorders.Bottom;
            grid.StateCommon.DataCell.Border.Color1 = GridLine;

            grid.StateNormal.DataCell.Content.Color1 = BodyText;

            grid.StateSelected.DataCell.Back.Color1 = SelectedBack;
            grid.StateSelected.DataCell.Back.Color2 = SelectedBack;
            grid.StateSelected.DataCell.Back.ColorStyle = PaletteColorStyle.Solid;
            grid.StateSelected.DataCell.Content.Color1 = BodyText;

            grid.StateTracking.HeaderColumn.Back.Color1 = HoverBack;
            grid.StateTracking.HeaderColumn.Back.Color2 = HoverBack;
            grid.StateTracking.HeaderColumn.Back.ColorStyle = PaletteColorStyle.Solid;
            grid.StateTracking.HeaderColumn.Content.Color1 = BodyText;
            grid.StateTracking.HeaderRow.Back.Color1 = HoverBack;
            grid.StateTracking.HeaderRow.Back.Color2 = HoverBack;
            grid.StateTracking.HeaderRow.Back.ColorStyle = PaletteColorStyle.Solid;
            grid.StateTracking.HeaderRow.Content.Color1 = BodyText;
        }
    }
}
