using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public class clsCommanStyls
    {
        public static void StyleDataGridView( DataGridView dgv)
        {
        //    DataGridView dgv = new DataGridView();
            // التنسيقات الأساسية للجدول
            //  dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //  dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(98, 73, 146);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(61, 145, 255);
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // تنسيق رأس الجدول
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 96, 144);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;

            // تنسيق الخلايا
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.DefaultCellStyle.Padding = new Padding(5);
            dgv.RowTemplate.Height = 35;

            // إخفاء عمود اختيار الصفوف
            dgv.RowHeadersVisible = false;

            // إضافة التأثيرات عند المرور بالماوس
            dgv.CellMouseEnter += (s, e) => {
                if (e.RowIndex >= 0)
                    dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(220, 230, 241);
                
                
            };

            dgv.CellMouseLeave += (s, e) => {
                if (e.RowIndex >= 0)
                {
                    if (e.RowIndex % 2 == 0)
                        dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    else
                        dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
                }
            };

            // تنسيق الأعمدة
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // إضافة تأثير الظل
            dgv.Paint += (s, e) => {
                using (var pen = new Pen(Color.FromArgb(220, 220, 220)))
                {
                    var bounds = new Rectangle(0, 0, dgv.Width - 1, dgv.Height - 1);
                    e.Graphics.DrawRectangle(pen, bounds);
                }
            };
        //dgv1 = dgv;
        }

    }
}
