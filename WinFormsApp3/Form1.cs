using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_inputdata_Click(object sender, EventArgs e)
        {

        }

        private void btn_proses_Click(object sender, EventArgs e)
        {
            if (textBoxdata.Text.Substring(0, 5).ToLower() == "isi: ") 
            {
                lbl_empty.Text = textBoxdata.Text.Substring(5);
            }
            else if (textBoxdata.Text.ToLower() == "warna: merah")
            {
                lbl_empty.ForeColor = Color.Red;
            }
            else if (textBoxdata.Text.ToLower() == "warna: default")
            {
                lbl_empty.ForeColor = Color.Black;
            }
            else if (textBoxdata.Text.ToLower() == "warna: biru")
            {
                lbl_empty.ForeColor = Color.Blue;
            }
            else if (textBoxdata.Text.ToLower() == "warna: hijau")
            {
                lbl_empty.ForeColor = Color.Green;
            }
            else if (textBoxdata.Text.ToLower() == "warna: kuning")
            {
                lbl_empty.ForeColor = Color.Yellow;
            }
            else if (textBoxdata.Text.ToLower() == "restart")
            {
                lbl_empty.Text = "[EMPTY]";
                lbl_empty.ForeColor = Color.Black;
            }
            else if (textBoxdata.Text.ToLower() == "kecilkan")
            {
                
            }
            else if (textBoxdata.Text.ToLower() == "shown")
            {
                lbl_empty.Visible = true;
            }
            else if (textBoxdata.Text.ToLower() == "hide ")
            {
                lbl_empty.Visible = false;
            }
            else
            {
                lbl_empty.Text = "Syntax error";
            }
        }
    }
}
