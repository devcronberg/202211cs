namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p1 = new Person();
            p1.Alder = 1;
            p1.Navn = "a";
            p1.ErILive = true;
            //MessageBox.Show(p1.Navn);
            propertyGrid1.SelectedObject = p1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class MinKnap : Button{
        public MinKnap()
        {
            this.BackColor = System.Drawing.Color.Green;
            this.ForeColor = System.Drawing.Color.White;
        }
    }

    public class Person
    {

        // Egenskab / Property (get/set)
        public string Navn { get; set; }
        public bool ErILive { get; set; }
        public int Alder { get; set; }

        public System.DateTime Fødselsdato
        {
            get => default;
            set
            {
            }
        }
    }
}