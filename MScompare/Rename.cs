using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MScompare
{
    public partial class Rename : Form
    {
        Main main;
        public Rename(Main parent)
        {
            InitializeComponent();
            main = parent;
        }

        private void Rename_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Enabled = true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            main.newname(rn_input.Text);
            this.Close();
        }
    }
}
