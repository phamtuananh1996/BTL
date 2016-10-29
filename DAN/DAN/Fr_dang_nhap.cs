using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DAN
{
    public partial class FrDangNhap : Form
    {
        public FrDangNhap()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
           


            }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void tbnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txttaikhoan_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txttaikhoan, "");
            label1.Text = "";

           
               
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtmatkhau, "");
            label1.Text = "";
           
           
            
        }

        private void txttaikhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtmatkhau.Clear();
                txtmatkhau.Focus();
            }
                
        }

        private void txtmatkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                
                btnok_Click(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;               
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblmatkhau_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txttaikhoan.Focus();
            txttaikhoan.SelectAll();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtmatkhau.Focus();
            txtmatkhau.SelectAll();
        }
    }
}
