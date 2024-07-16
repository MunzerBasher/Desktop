using System;
using System.Windows.Forms;


class clsShowForm
{

    public static void ShowForm(Form frm, Panel pnl)
    {
        frm.BackColor = pnl.BackColor;
        frm.FormBorderStyle = FormBorderStyle.None;
        frm.TopLevel = false;

        pnl.Controls.Clear();
        pnl.Controls.Add(frm);
        frm.Show();

    }


}