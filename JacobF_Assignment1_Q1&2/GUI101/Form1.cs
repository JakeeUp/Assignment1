namespace GUI101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //fahrenheit conversion
        #region Question 2
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtInput.Text, out double f))
            {
                double celsius = ConvertFtoC(f);
                lblTemp.Text = $"{celsius:0.##} C";
            }
            else
                lblTemp.Text = "INVALID!";
        }

        private double ConvertFtoC(double f)
        {
            return (5.0 / 9) * (f - 32);
        }
        #endregion



        private void btnGo_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "Go Cardials";


        }

        private void numScore_ValueChanged(object sender, EventArgs e)
        {
            prgGoal.Value = Convert.ToInt32(numScore.Value);
        }

        private void radBBQ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radCowboys_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void displayGoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error Check your stuff", "Attention!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            txtOutput.BackColor = colorDialog1.Color;
            chk_List.BackColor = colorDialog1.Color;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string loc = openFileDialog1.FileName;
            txtFileName.Text = loc;
            picLogo.ImageLocation = loc;
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        int counter = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            lblNum.Text = counter.ToString();
            progressBar1.Value = counter;
            Random random = new Random();
            int num = random.Next(1, 5);
            lblNum2.Text = num.ToString();
            if (num == 1) { lblNum.ForeColor = Color.Red; }
            else if (num == 2) { lblNum.ForeColor = Color.Blue; }
            else if (num == 3) { lblNum.ForeColor = Color.Green; }
            else if (num == 4) { lblNum.ForeColor = Color.Black; }
            else if (num == 5) { lblNum.ForeColor = Color.Orange; }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            counter = 0;
            lblNum.Text = counter.ToString(); progressBar1.Value = counter;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
           //button useless 
        }
    }
}