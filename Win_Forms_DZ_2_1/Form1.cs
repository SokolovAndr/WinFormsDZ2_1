namespace Win_Forms_DZ_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int counterLBC = 0;
        private int counterMBC = 0;
        private int counterRBC = 0;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                counterLBC++;
                MessageBox.Show("Left Button Click" + $"{counterLBC}");
            }
            if (e.Button == MouseButtons.Middle)
            {
                counterMBC++;
                MessageBox.Show("Middle Button Click " + $"{counterMBC}");
            }
            if (e.Button == MouseButtons.Right)
            {
                counterRBC++;
                MessageBox.Show("Right Button Click " + $"{counterRBC}");
            }
            Text = $"LBC: {counterLBC.ToString()} MBC: {counterMBC.ToString()} RBC: {counterRBC.ToString()}";
        }
    }
}