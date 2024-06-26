using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnableField();
            EnableButtons();
            btnDelete.Enabled = false;
            btnNew.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CleanField();
            DisableField();
            DisableButtons();
            btnNew.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CleanField();
            DisableField();
            DisableButtons();
            btnNew.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            CleanField();
            DisableField();
            DisableButtons();
            btnNew.Enabled = true;
        }
        private void DisableButtons()
        {
            btnNew.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnCancel.Enabled = false;
        }
        private void EnableButtons()
        {
            btnNew.Enabled = true;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
        }
        private void DisableField()
        {
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtCpf.Enabled = false;
            txtTel.Enabled = false;
        }
        private void EnableField()
        {
            txtName.Enabled = true;
            txtName.Focus();
            txtAddress.Enabled = true;
            txtCpf.Enabled = true;
            txtTel.Enabled = true;
        }
        private void CleanField()
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtTel.Text = string.Empty;
        }
    }
}
