using System.Data;

namespace data_grid_student
{
    public partial class Form1 : Form
    {
        DataTable Stu_db = new DataTable("My college students");
        int index;
        string value = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_load(object sender, EventArgs e)
        {
            Stu_db.Columns.Add("ID", Type.GetType("System.Int32"));
            Stu_db.Columns.Add("NAME", Type.GetType("System.String"));
            Stu_db.Columns.Add("PH_NO", Type.GetType("System.String"));
            Stu_db.Columns.Add("SEX", Type.GetType("System.String"));
            dataGridView1.DataSource = Stu_db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                value = radioButton1.Text;
            else
                value = radioButton2.Text;
            Stu_db.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, value);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            radioButton2.Checked = false;
            radioButton1.Checked = false;






        }

        private void data_GridView1_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            if (value == "MALE")
            {
                radioButton1.Checked = true;

            }
            else
            {
                radioButton2.Checked = true;
            }
           
            




        }
        private void data_grid_view_click(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}