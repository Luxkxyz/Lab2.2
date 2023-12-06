namespace Lab2._2
{
    public partial class Form1 : Form
    {
        int arryIndex = 0;
        int Max = 0;
        int Min = 100000000;
        string[] arryID = new string[1000000];
        string[] arryName = new string[100000];
        int f = 0;
        int d = 0;
        int dplus = 0;
        int c = 0;
        int cplus = 0;
        int b = 0;
        int bplus = 0;
        int a = 0;
        int[] arryPoint = new int[100000];
        int summe = 0;
        double nll = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string inputID = TBinputID.Text;
            string inputname = TBinputName.Text;
            int inputpoint = int.Parse(TBinputPoint.Text);



            arryID[arryIndex] = inputID;
            arryName[arryIndex] = inputname;
            arryPoint[arryIndex] = inputpoint;
            arryIndex++;

            TBinputPoint.Text = inputpoint.ToString();

            if (inputpoint <= 49)
            {
                f += 1;
                F.Text = f.ToString();
            }

            if (inputpoint >= 50 && inputpoint <= 54)
            {
                d += 1;
                D.Text = d.ToString();
            }

            if (inputpoint >= 55 && inputpoint <= 59)
            {
                dplus += 1;
                Dplus.Text = dplus.ToString();
            }

            if (inputpoint >= 60 && inputpoint <= 64)
            {
                c += 1;
                C.Text = c.ToString();
            }

            if (inputpoint >= 65 && inputpoint <= 69)
            {
                cplus += 1;
                Cplus.Text = cplus.ToString();
            }

            if (inputpoint >= 70 && inputpoint <= 74)
            {
                b += 1;
                B.Text = b.ToString();
            }

            if (inputpoint >= 75 && inputpoint <= 79)
            {
                bplus += 1;
                Bplus.Text = bplus.ToString();
            }

            if (inputpoint >= 80)
            {
                a += 1;
                A.Text = a.ToString();
            }

            if (inputpoint > Max)
            {
                Max = inputpoint;
                HighID.Text = inputID;
                HighName.Text = inputname;
                Highpoint.Text = inputpoint.ToString();
                Min = Max;
            }

            if (inputpoint < Min)
            {
                Min = inputpoint;
                LowID.Text = inputID;
                LowName.Text = inputname;
                Lowpoint.Text = inputpoint.ToString();


            }
            int summe = Max + Min;
            double summe2 = summe / 2;
            string summe3 = summe2.ToString();
            average.Text = summe3;

            nll = a + bplus + b + cplus + c + dplus + d + f;


             double ax =  a*4.0 ;
             double bplusx = bplus * 3.5;
             double bx = b * 3.0;
             double cplusx = cplus * 2.5;
             double cx = c * 2.0;
             double dplusx = dplus * 1.5;
             double dx = d * 1.0;
            double Gpa = (ax + bplusx + bx + cplusx + cx + dplusx + dx) / nll;
            gpa.Text = Gpa.ToString();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void gpa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
