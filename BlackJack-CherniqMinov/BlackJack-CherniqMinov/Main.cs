namespace BlackJack_CherniqMinov
{
    public partial class Main : Form
    {
        public static int depositSum = 0;
        public Main()
        {
            InitializeComponent();
            UpdateBalanceLabel();
        }
        public void Main_Activated(object sender, EventArgs e, int newBalance)
        {
            
        }
        private void UpdateBalanceLabel()
        {
            lblBalance.Text = $"BALANCE: {depositSum}lv";
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (depositSum < 5)
            {
                MessageBox.Show("You need at least 5lv to play");
            }
            else
            {
                this.Hide();
                Game game = new Game(depositSum);
                game.Show();
            }
        }

        private void btn1_Click(object sender, EventArgs e) => depositCalculation(1);
        private void btn2_Click(object sender, EventArgs e) => depositCalculation(2);
        private void btn3_Click(object sender, EventArgs e) => depositCalculation(3);
        private void btn4_Click(object sender, EventArgs e) => depositCalculation(4);
        private void btn5_Click(object sender, EventArgs e) => depositCalculation(5);
        private void btn6_Click(object sender, EventArgs e) => depositCalculation(6);
        private void btn7_Click(object sender, EventArgs e) => depositCalculation(7);
        private void btn8_Click(object sender, EventArgs e) => depositCalculation(8);
        private void btn9_Click(object sender, EventArgs e) => depositCalculation(9);
        private void btn0_Click(object sender, EventArgs e) => depositCalculation(0);
        private void btnClear_Click(object sender, EventArgs e) => txtDeposit.Clear();
        private void depositCalculation(int num)
        {
            txtDeposit.Text += num;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                int deposit = int.Parse(txtDeposit.Text);
                depositSum += deposit;
                if (depositSum > 99999)
                {
                    depositSum -= deposit;
                    MessageBox.Show("The maximum amount you can deposit is 99999lv");
                    txtDeposit.Clear();
                }
                else
                {
                    UpdateBalanceLabel();
                    txtDeposit.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }

        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
