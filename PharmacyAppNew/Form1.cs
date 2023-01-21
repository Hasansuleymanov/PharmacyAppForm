namespace PharmacyAppNew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedicineForm admF=new AddMedicineForm();
            admF.ShowDialog();
        }
    }
}