namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom= new Classroom();
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            int year = int.Parse(this.textBox2.Text);
            double  grade = double.Parse(this.textBox3.Text);

            Person persons = new Person(name, year, grade);
            this.classroom.addPerson(persons);

            labelname0.Text = this.classroom.ShowPerson();
            labelage.Text = this.classroom.ShowAllAge().ToString();
            this.classroom.SetGrade();
            this.labelmax.Text = this.classroom.ShowMaxGrade().ToString();
            this.labelmin.Text = this.classroom.ShowMinGrade().ToString();
            this.label10.Text = this.classroom.ShowMaxGradeName();
            this.label11.Text = this.classroom.ShowMinGradeName();
        }
    }
}