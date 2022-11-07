namespace UpdateDGVFromOtherForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvdatos.DataSource = DB.loaddatos();
        }
        public void OnReloadData(List<user> datos)
        {
            dgvdatos.DataSource = null;
            dgvdatos.DataBindings.Clear();
            dgvdatos.Rows.Clear();
            dgvdatos.DataSource = datos;
        }
        private void btnform2_Click(object sender, EventArgs e)
        {
            //Aqui creas una instancia o mandas a llamar la nueva forma con un objeto de form
            windowtwo frm = new windowtwo(this);
            //Otra es mandarlo a llamar como un parametro de tipo form
            frm.secundary = this;
            frm.Show();

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            dgvdatos.DataSource = DB.loaddatos();
        }
    }
}