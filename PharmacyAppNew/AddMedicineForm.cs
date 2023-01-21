using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using PharmacyAppNew.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyAppNew
{
    public partial class AddMedicineForm : Form
    {
        PharmacyContext db = new PharmacyContext();
        public AddMedicineForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void FillCategoryBox()
        {
            cmbCategory.Items.AddRange(db.Categories.Select(c=>c.Name).ToArray());
        }
        public void FillFirmBox()
        {
            cmbFirms.Items.AddRange(db.Firms.Select(a=>a.Name).ToArray());
        }

        private void AddMedicineForm_Load(object sender, EventArgs e)
        {
            dtgMedicine.DataSource = db.Medicines.ToList();
            FillCategoryBox();
            FillFirmBox();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            string name=txtMedName.Text;
            decimal price = nmInitial.Value;
            decimal cost=nmSell.Value;
            int count=(int)nmCount.Value;
            DateTime pro=dtPro.Value;
            DateTime exp = dtExpire.Value;
            bool isReceipt = ckReceipt.Checked;
            string firm=cmbFirms.Text;

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string catName=cmbCategory.Text;
            if (!cklBoxCategory.Items.Contains(catName))
            {
                cklBoxCategory.Items.Add(catName);
            }
        }

        private void cmbCategory_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string catName = cmbCategory.Text;
                bool IsCorrect = false;
                foreach(var item in cklBoxCategory.Items)
                {
                    if (item.ToString().ToLower() == catName.ToLower())
                    {
                        IsCorrect = true;
                    }
                }
                if (!IsCorrect)
                {
                    cklBoxCategory.Items.Add(catName);
                    cmbCategory.Text = "";
                }
            }
        }
    }
}
