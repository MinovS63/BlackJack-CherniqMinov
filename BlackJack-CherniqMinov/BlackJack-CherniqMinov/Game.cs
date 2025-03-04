using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace BlackJack_CherniqMinov
{
    public partial class Game : Form
    {
        string[] arr = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        int plCard1, plCard2, plCard3, dlCard1, dlCard2, dlCard3 = 0;
        int betSum;
        public int balance;
        bool plCard3played = false;
        Random random = new Random();
        int cardValue;
        public int cardValueGetter()
        {
            cardValue = random.Next(0, 13);
            var card = arr[cardValue];
            if (card == "J" || card == "Q" || card == "K")
            {
                return 10;
            }
            else if (card == "A")
            {
                return 11;
            }
            else
            {
                return int.Parse(card);
            }
        }
        public Game(int depositSum)
        {
            InitializeComponent();
            balance = depositSum;
            picChip5.Visible = false;
            picChip10.Visible = false;
            picChip50.Visible = false;
            picChip100.Visible = false;
            picChip1000.Visible = false;
            lblGameBalance.Text = $"BALANCE: {depositSum}lv";
            plCard1 = cardValueGetter();
            string plCard1Pic = $"{arr[cardValue]}";
            plCard2 = cardValueGetter();
            string plCard2Pic = $"{arr[cardValue]}";
            plCard3 = cardValueGetter();
            string plCard3Pic = $"{arr[cardValue]}";
            dlCard1 = cardValueGetter();
            string dlCard1Pic = $"{arr[cardValue]}";
            dlCard2 = cardValueGetter();
            string dlCard2Pic = $"{arr[cardValue]}";
            dlCard3 = cardValueGetter();
            string dlCard3Pic = $"{arr[cardValue]}";

            string basePath = @"cards\";
            playerCard1.BackgroundImage = Image.FromFile($"{basePath}{plCard1Pic}.png");
            playerCard1.BackgroundImageLayout = ImageLayout.Stretch;

            playerCard2.BackgroundImage = Image.FromFile($"{basePath}{plCard2Pic}.png");
            playerCard2.BackgroundImageLayout = ImageLayout.Stretch;

            playerCard3.BackgroundImage = Image.FromFile($"{basePath}{plCard3Pic}.png");
            playerCard3.BackgroundImageLayout = ImageLayout.Stretch;

            dealerCard1.BackgroundImage = Image.FromFile($"{basePath}{dlCard1Pic}.png");
            dealerCard1.BackgroundImageLayout = ImageLayout.Stretch;

            dealerCard2.BackgroundImage = Image.FromFile($"{basePath}{dlCard2Pic}.png");
            dealerCard2.BackgroundImageLayout = ImageLayout.Stretch;

            dealerCard3.BackgroundImage = Image.FromFile($"{basePath}{dlCard3Pic}.png");
            dealerCard3.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            picChip5.Visible = true;
            picChip10.Visible = true;
            picChip50.Visible = true;
            picChip100.Visible = true;
            picChip1000.Visible = true;
        }
        private void picChip5_Click(object sender, EventArgs e) => Bets(5);
        private void picChip10_Click(object sender, EventArgs e) => Bets(10);
        private void picChip50_Click(object sender, EventArgs e) => Bets(50);
        private void picChip100_Click(object sender, EventArgs e) => Bets(100);
        private void picChip1000_Click(object sender, EventArgs e) => Bets(1000);

        private void Bets(int bet)
        {
            if (bet > balance)
            {
                MessageBox.Show("You don't have enough money for that bet.. you need to deposit more.");
            }
            else
            {
                betSum += bet;
                balance -= bet;
                MessageBox.Show("Succesful bet!");
                lblGameBalance.Text = $"BALANCE: {balance}lv";
                lblBetAmount.Visible = true;
                lblBetAmount.Text = $"YOUR BET: {betSum}lv";
            }
        }

        private void btnPlayRound_Click(object sender, EventArgs e)
        {
            btnPlayRound.Visible = false;
            lblBetAmount.Visible = true;
            btnBet.Visible = true;
            btnStartGame.Visible = true;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if (betSum == 0)
            {
                MessageBox.Show("You need to place a bet first!");
            }
            else
            {
                btnBet.Visible = false;
                btnStartGame.Visible = false;
                btnHit.Visible = true;
                btnStand.Visible = true;
                lblBetAmount.Visible = true;
                lblGameBalance.Visible = true;
                lblCards.Visible = true;
                lblDealerCards.Visible = true;
                playerCard1.Visible = true;
                playerCard2.Visible = true;
                playerCard3.Visible = true;
                dealerCard1.Visible = true;
                dealerCard2.Visible = true;
                dealerCard3.Visible = true;
                plCard3FaceDown.Visible = true;
                dlCard2FaceDown.Visible = true;
                dlCard3FaceDown.Visible = true;
                picChip5.Visible = false;
                picChip10.Visible = false;
                picChip50.Visible = false;
                picChip100.Visible = false;
                picChip1000.Visible = false;
            }

            if (plCard1 + plCard2 == 21)
            {
                MessageBox.Show("Blackjack! You win!");
                balance += betSum * 2;
                lblGameBalance.Text = $"BALANCE: {balance}lv";
                Refresh();
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            plCard3FaceDown.Visible = false;
            if (plCard1 + plCard2 + plCard3 > 21)
            {
                LossOver21();
            }
            else
            {
                plCard3played = true;
                DealerTurn();
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            DealerTurn();
        }

        private void DealerTurn()
        {
            if (plCard3played == true)
            {
                if (plCard1 + plCard2 + plCard3 < dlCard1)
                {
                    Loss();
                }
                else
                {
                    dlCard2FaceDown.Visible = false;
                    if (plCard1 + plCard2 + plCard3 < dlCard1 + dlCard2)
                    {
                        Loss();
                    }
                    else
                    {
                        dlCard3FaceDown.Visible = false;
                        if (dlCard1 + dlCard2 + dlCard3 > 21)
                        {
                            Win();
                        }
                        else if (plCard1 + plCard2 + plCard3 < dlCard1 + dlCard2 + dlCard3)
                        {
                            Loss();
                        }
                        else if (plCard1 + plCard2 + plCard3 > dlCard1 + dlCard2 + dlCard3)
                        {
                            Win();
                        }
                        else
                        {
                            Draw();
                        }
                    }
                }
            }
            else
            {
                if (plCard1 + plCard2 < dlCard1)
                {
                    Loss();
                }
                else
                {
                    dlCard2FaceDown.Visible = false;
                    dealerCard2.Visible = true;
                    if (plCard1 + plCard2 < dlCard1 + dlCard2)
                    {
                        Loss();
                    }
                    else
                    {
                        dlCard3FaceDown.Visible = false;
                        if (dlCard1 + dlCard2 + dlCard3 > 21)
                        {
                            Win();
                        }
                        else if (plCard1 + plCard2 < dlCard1 + dlCard2 + dlCard3)
                        {
                            Loss();
                        }
                        else if (plCard1 + plCard2 > dlCard1 + dlCard2 + dlCard3)
                        {
                            Win();
                        }
                        else
                        {
                            Draw();
                        }
                    }
                }
            }
        }
        private void Win()
        {
            balance += betSum*2;
            MessageBox.Show("You win!");
            Refresh();
        }

        private void Loss()
        {
            balance -= betSum - betSum;
            MessageBox.Show("Dealer wins!");
            Refresh();
        }
        
        private void LossOver21()
        {
            balance -= betSum - betSum;
            MessageBox.Show("Your sum exceeded over 21! Dealer wins!");
            Refresh();
        }

        private void Draw()
        {
            balance += betSum;
            MessageBox.Show("Draw!");
            Refresh();
        }

        private void Refresh()
        {
            Game game = new Game(balance);
            this.Hide();
            game.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            BlackJack_CherniqMinov.Main.depositSum = balance;
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            Tutorial tutorial = new Tutorial();
            tutorial.Show();
        }
    }
}
