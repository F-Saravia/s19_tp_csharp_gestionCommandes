namespace UrInfo
{
    public partial class Form1 : Form
    {
        private List<Employe> employeList = new List<Employe>();
        public Form1()
        {
            InitializeComponent();
            AfficheAllEmploye();


        }

        private void label1_Click(object sender, EventArgs e)
        {
            employeList.Clear();
        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            EmployeManager.updateType(tb_id.Text,tb_type.Text);
            AfficheAllEmploye();
        }
        void AfficheAllEmploye()
        {
            employeList = EmployeManager.SelectAllEmploye();
            dataGridView.DataSource = employeList;
        }

    }
}