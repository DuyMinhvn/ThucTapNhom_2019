using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_QuanLyThuVien
{
    class frmController
    {
        public static void show_panel(Panel pnl, bool state)
        {
            pnl.Visible = state;
            foreach (Control VARIABLE in pnl.Controls)
            {
                VARIABLE.Visible = state;
            }
        }
    }
}
