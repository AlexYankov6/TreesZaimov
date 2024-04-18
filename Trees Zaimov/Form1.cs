using MySql.Data.MySqlClient;

namespace Trees_Zaimov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=192.168.1.38;" +
                "user=PC1;" +
                "password=1111;" +
                "port=3306;" +
                "database=trees_zaimov";
            MySqlConnection connect= new MySqlConnection(connectionString);
            if (connect.State==0)
            {
                connect.Open();
            }
            MessageBox.Show("Imash vruzka s Belezireva");
            string insertQueryText = "INSERT INTO trees_zaimov.class" +
                "(`name`,`name_bg`)" +
                "VALUES" +
                "(@name,@name_bg)";
            MySqlCommand query = new MySqlCommand(insertQueryText,connect);
            query.Parameters.AddWithValue("@name",txtName.Text);
            query.Parameters.AddWithValue("@name_bg",txtNamebg.Text);
            int result=query.ExecuteNonQuery();
            if (result!=0)
            {
                MessageBox.Show($"Dobavi  {result} records");
            }
            connect.Close();
        }
    }
}
