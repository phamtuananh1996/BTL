using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DAN
{
    public partial class Fr_trang_chu : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public Fr_trang_chu()
        {
            InitializeComponent();
        }

        private void metroTabItem2_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void applicationButton1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar2_ItemClick(object sender, EventArgs e)
        {

        }

        private void buttonItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {

        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            tabControl1.Tabs.Remove(tabItem2);
            tabControl1.Tabs.Remove(tabItem3);
            tabControl1.Tabs.Remove(tabItem4);
            tabControl1.Tabs.Remove(tabItem5);
            tabControl1.Tabs.Remove(tabItem6);
            tabControl1.Tabs.Remove(tabItem7);
        }
        private void btnqlnd_Click(object sender, EventArgs e)
        {


            if (tabControl1.Tabs.Contains(tabItem2))
                tabControl1.SelectedTab = tabItem2;
            else
            {
                tabControl1.Tabs.Add(tabItem2);
                tabControl1.SelectedTab = tabItem2;
            }
            
        }

        private void tabControl1_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            tabControl1.Tabs.Remove(tabControl1.SelectedTab);
        }

        private void qatCustomizeItem2_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {

        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnpq_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void radialMenu1_ItemClick(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void rbtab_Click(object sender, EventArgs e)
        {

        }

     
       

       
    }
}