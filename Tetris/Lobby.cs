using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            var frm = new Tetris();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Close();/*this.Show();*/};
            frm.Show();
            this.Hide();
        }

        private void Btn_credits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Coded and Testet by Florian Qengaj \n\nApplication Icon made by Freepik from www.flaticons.com is licensed by Creative Commons BY 3.0",  "Credits");
        }
    }
}
