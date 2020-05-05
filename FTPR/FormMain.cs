using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPR
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItemUpdateClientList_Click(object sender, EventArgs e)
        {

        }
    }
}
