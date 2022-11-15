namespace WinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vare v = new Vare();
            v.Pris = 100;
            propertyGrid1.SelectedObject = v;
        }
    }

    public class Vare
    {

        private double pris;

        public double Pris
        {
            get { return pris; }
            set { pris = value; }
        }

        //public double PrisMedMoms()
        //{
        //    return this.Pris * 1.25;
        //}

        public double PrisMedMoms
        {
            get
            {
                return this.Pris * 1.25;
            }
        }


    }
}