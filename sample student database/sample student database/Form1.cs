/*namespace sample_student_database
{
    public partial class Form1 : Form
    {
        List<object> data = new List<object>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int ID = int.Parse(id.Text);
            string NAME = name.Text;
            string PHNO = phno.Text;
            
            string value = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                value = radioButton1.Text;
            else
                value = MALE.Text;
            data.Add(ID);
            data.Add(NAME);
            data.Add(PHNO);
            data.Add(value);
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(data[0] + " " + data[1] + " " + data[2] + " " + data[3]);
        }
    }
}*/


namespace sample_student_database
{
    public class student
    {
        public string Id
        {           //user define data type creation -data
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Phno
        {
            get; set;
        }
        public string sex
        {           //user define data type creation -data
            get; set;
        }

    }
    public partial class Form1 : Form
    {
        List<student> data = new List<student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student s1 = new student();

            s1.Id = id.Text;
            s1.Name = name.Text;
            s1.Phno = phno.Text;
            string value = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                value = radioButton1.Text;
            else
                value = MALE.Text;
            s1.sex = value;
            data.Add(s1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (student op in data)
            {
                MessageBox.Show($"{op.Name} {op.Id}  {op.sex}");

            }
        }
    }
}