using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager
{
    public partial class MainForm : Form
    {
        private static MainForm inst = null;
        public MainForm ()
        {
            InitializeComponent();
        }
        public static MainForm getMainForm()
        {
            if (inst == null || inst.IsDisposed)
            {
                inst = new MainForm();
                return inst;
            }
            else
                return inst;
        }



        private void orderButton_Click(object sender, EventArgs e)
        {
            this.mainPanel.Visible = false;
            this.orderPanel.Visible = true;
        }
    }
}
