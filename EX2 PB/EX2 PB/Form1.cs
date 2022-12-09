namespace EX2_PB
{
    public partial class Form1 : Form
    {
        string[,] Quest = new string[5, 4];
        string[,] Ans = new string[5, 2];
        int i = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Quest[0, 0]="In_________India Won cricket world cup?";
            Quest[0, 1]="1973";
            Quest[0, 2]="1983";
            Quest[0, 3]="1987";
            Quest[1, 0]="Scanner is a ______device";
            Quest[1, 1]="Input";
            Quest[1, 2]="Output";
            Quest[1, 3]="I/O";
            Quest[2, 0]="Which One of the following is a browser";
            Quest[2, 1]="Visual Basic";
            Quest[2, 2]="Java";
            Quest[2, 3]="Google Chorme";
            Quest[3, 0]="______Was not a chief Minister";
            Quest[3, 1]="Kamarajar";
            Quest[3, 2]="Sivaji";
            Quest[3, 3]="MGR";
            Quest[4, 0]="Tsunami hit India on_______";
            Quest[4, 1]="24-12-2006";
            Quest[4, 2]="26-12-2004";
            Quest[4, 3]="27-09-2001";
            Ans[0, 0]="1983";
            Ans[1, 0]="Input";
            Ans[2, 0]="Google chorme";
            Ans[3, 0]="Sivaji";
            Ans[4, 0]="27-09-2001";
            timer1.Enabled=true;
            button1.Enabled=false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i=i+1;
            if (i==5)
            {
                timer1.Enabled=false;
                button1.Enabled=true;
            }
            else
            {
                radioButton1.Checked=false;
                radioButton2.Checked=false;
                radioButton3.Checked=false;
                textBox1.Text=Quest[i, 0];
                radioButton1.Text=Quest[i, 1];
                radioButton2.Text=Quest[i, 2];
                radioButton3.Text=Quest[i, 3];
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Ans[i, 1]=radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Ans[i, 1]=radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Ans[i, 1]=radioButton3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int j = 0; j<=4; j++)
            {
                if (Ans[j, 0]==Ans[j, 1])
                {
                    count+=1;
                }
            }
            MessageBox.Show("PVS have Scored");
            MessageBox.Show( +count+ " Marks");
        }
    }
}