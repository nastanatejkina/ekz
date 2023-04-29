namespace экз
{
    public partial class Form1 : Form
    {
        private db  _recept;

        public Form1()
        {
            InitializeComponent();

            _recept = new db();
            _recept.Initialize();

            recepti.DataSource = _recept.recepts.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            recepti.DataSource = _recept.recepts.Where(u => u.nazvanieName.ToLower().Contains(textBox1.Text.ToLower())).ToList();
        }
    }
}