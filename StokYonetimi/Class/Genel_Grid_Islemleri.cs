using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokYonetimi.Class
{
    public static class Genel_Grid_Islemleri
    {
        public static void gridKeyDown(GridView grid, KeyEventArgs e)
        {
            try
            {
                if (grid.DataRowCount > 0)
                {
                    if (e.KeyCode == Keys.Space)
                    {
                        if (grid.FocusedRowHandle >= 0)
                        {
                            grid.SetFocusedRowCellValue("Sec", grid.GetFocusedRowCellValue("Sec").ToString() == "True" ? 0 : 1);
                            grid.RefreshData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void gridRowCellStyle(GridView grid, object sender, RowCellStyleEventArgs e)
        {
            try
            {
                GridView View = sender as GridView;
                if (e.RowHandle >= 0)
                {
                        e.Appearance.BackColor = Color.FromArgb(192, 192, 255);
                        //e.Appearance.FontStyleDelta = FontStyle.Bold;                                       
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int gridSeciliSayisi(GridView grid)
        {
            int say = 0;
            for (int i = 0; i <= grid.RowCount - 1; i++)
            {
                if (grid.GetRowCellValue(i, "Sec").ToString() == "True")
                    say += 1;
            }
            return say;
        }

        public static void gridTumunuSec(GridView grid)
        {
            try
            {
                for (int i = 0; i <= grid.RowCount - 1; i++)
                    grid.SetRowCellValue(i, "Sec", 1);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void gridTumunuKaldir(GridView grid)
        {
            try
            {
                for (int i = 0; i <= grid.RowCount - 1; i++)
                    grid.SetRowCellValue(i, "Sec", 0);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void gridDoubleClick(GridView grid)
        {
            try
            {
                if (grid.GetFocusedRowCellValue("Sec").ToString() == "True")
                {
                    grid.SetFocusedRowCellValue("Sec", 0);
                }
                else
                {
                    grid.SetFocusedRowCellValue("Sec", 1);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message + ex.StackTrace, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
