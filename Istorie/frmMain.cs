using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Istorie
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static Cont log = null;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(log==null)
            {
                log = new Cont();
                log.Show();
            }

        }
    }
}
