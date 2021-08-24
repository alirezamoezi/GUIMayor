using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIMayor
{
    public partial class Form1 : Form
    {
        List<Mayor> mayors = new List<Mayor>();

            
        public Form1()
        {
            InitializeComponent();
            dtgMayors.DataSource = Mayor.GetMayors();
        }
        public void GetMayors()
        {
            mayors = Mayor.GetMayors();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetMayors();
            mayors.Add(new Mayor(txtName.Text, txtStart.Text, txtEnd.Text));
            dtgMayors.DataSource = null;
            dtgMayors.DataSource = mayors;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtStart.Text = "";
            txtEnd.Text = "";
        }
    }
}
