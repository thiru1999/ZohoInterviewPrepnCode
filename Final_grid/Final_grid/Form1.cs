using System.Data;

namespace Final_grid
{
    public partial class Form1 : Form
    {
        DataTable stu_db = new DataTable("My College_Db");
        int index;
        string value = "";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stu_db.Columns.Add("ID", Type.GetType("System.Int32"));
            stu_db.Columns.Add("NAME", Type.GetType("System.String"));
            stu_db.Columns.Add("PH_NO", Type.GetType("System.String"));
            stu_db.Columns.Add("SEX", Type.GetType("System.String"));
            dataGridView1.DataSource = stu_db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                value = radioButton1.Text;
            else
                value = radioButton2.Text;

            stu_db.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow Data = dataGridView1.Rows[index];
            Data.Cells[0].Value = textBox1.Text;
            Data.Cells[1].Value = textBox2.Text;
            Data.Cells[2].Value = textBox3.Text;
            if (radioButton1.Checked)
            {
                Data.Cells[3].Value = "MALE";
            }
            else
            {
                Data.Cells[3].Value = "FEMALE";
            }
        }

        private void Final_Grid_Cell_click(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            if (value=="MALE")
            {
                radioButton1.Checked = true;

            }
            else
            {
                radioButton2.Checked = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Empty;
            textBox1.Text = String.Empty;
            textBox3.Text = String.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }
    }
}