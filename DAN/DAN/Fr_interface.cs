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
    public partial class Fr_interface : Form
    {
     
        public Fr_interface()
        {
            InitializeComponent();
        }
       
        private void Interface_Load(object sender, EventArgs e)
        {
            progressBarX1.Maximum = 100;
            progressBarX1.Minimum = 0;
            

        }
        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBarX1.Value = i;
                label3.Text = "Loading  " + i.ToString() + "% ....";
               ++i; 
                if (i == 101)
                {
                    timer1.Enabled = false;
                    this.Hide();
                    FrDangNhap dn = new FrDangNhap();
                    dn.ShowDialog();
                    Close();

                }
               
         }

        private void metroStatusBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void labelItem1_Click(object sender, EventArgs e)
        {

        }
      
        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void circularProgress1_ValueChanged(object sender, EventArgs e)
        {

        }

           
          
        }
    }

