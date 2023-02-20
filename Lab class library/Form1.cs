using StudentClassLibrary;

namespace Lab_class_library
{
    public partial class Form1 : Form
    {
        List<Student> ListStudents = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            this.listtextBox.Text = "";
            string input_name = this.NametextBox.Text;
            string input_student_id = this.IDtextBox.Text;
            Student newstudent = new Student(input_name,input_student_id);


            this.ListStudents.Add(newstudent);
            Displaydata();
            
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string save_data = this.listtextBox.Text;
            File.WriteAllText("d:/text.CSV",save_data);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] data = File.ReadAllLines("d/text.CSV");
            //Todo
            //display data to liststudent
            for (int i = 0; 1<data.Length; i++)
            {
                string idata = data[i];
                string displaydata = idata;
                this.listtextBox.Text += idata;
            }
        }
        private void Displaydata()
        {
            for (int i = 0; i <= this.ListStudents.Count; i++)
            {
                Student currentStudent = this.ListStudents[i];
                string display = currentStudent.displayInfo();
                this.listtextBox.Text += display;
            }
        }
    }
}