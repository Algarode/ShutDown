using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SluitAf
{
    public partial class Over : Form
    {
        public Over()
        {
            InitializeComponent();
        }

        private void btSluitenOver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
