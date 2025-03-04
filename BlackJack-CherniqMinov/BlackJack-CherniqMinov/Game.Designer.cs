namespace BlackJack_CherniqMinov
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            lblCards = new Label();
            lblDealerCards = new Label();
            btnHit = new Button();
            btnStand = new Button();
            btnReturn = new Button();
            btnBet = new Button();
            playerCard1 = new PictureBox();
            playerCard2 = new PictureBox();
            playerCard3 = new PictureBox();
            dealerCard1 = new PictureBox();
            dealerCard2 = new PictureBox();
            dealerCard3 = new PictureBox();
            lblGameBalance = new Label();
            btnPlayRound = new Button();
            picChip5 = new PictureBox();
            picChip1000 = new PictureBox();
            picChip100 = new PictureBox();
            picChip50 = new PictureBox();
            picChip10 = new PictureBox();
            lblBetAmount = new Label();
            btnStartGame = new Button();
            plCard3FaceDown = new PictureBox();
            dlCard2FaceDown = new PictureBox();
            dlCard3FaceDown = new PictureBox();
            btnTutorial = new Button();
            ((System.ComponentModel.ISupportInitialize)playerCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChip5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChip1000).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChip100).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChip50).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChip10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plCard3FaceDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dlCard2FaceDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dlCard3FaceDown).BeginInit();
            SuspendLayout();
            // 
            // lblCards
            // 
            lblCards.AutoSize = true;
            lblCards.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold | FontStyle.Italic);
            lblCards.Location = new Point(53, 283);
            lblCards.Name = "lblCards";
            lblCards.Size = new Size(113, 23);
            lblCards.TabIndex = 0;
            lblCards.Text = "YOUR CARDS";
            lblCards.Visible = false;
            // 
            // lblDealerCards
            // 
            lblDealerCards.AutoSize = true;
            lblDealerCards.Font = new Font("Segoe UI Semibold", 12.25F, FontStyle.Bold | FontStyle.Italic);
            lblDealerCards.Location = new Point(53, 46);
            lblDealerCards.Name = "lblDealerCards";
            lblDealerCards.Size = new Size(127, 23);
            lblDealerCards.TabIndex = 1;
            lblDealerCards.Text = "DEALER CARDS";
            lblDealerCards.Visible = false;
            // 
            // btnHit
            // 
            btnHit.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic);
            btnHit.Location = new Point(53, 318);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(109, 47);
            btnHit.TabIndex = 2;
            btnHit.Text = "HIT";
            btnHit.UseVisualStyleBackColor = true;
            btnHit.Visible = false;
            btnHit.Click += btnHit_Click;
            // 
            // btnStand
            // 
            btnStand.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold | FontStyle.Italic);
            btnStand.Location = new Point(53, 391);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(109, 47);
            btnStand.TabIndex = 3;
            btnStand.Text = "STAND";
            btnStand.UseVisualStyleBackColor = true;
            btnStand.Visible = false;
            btnStand.Click += btnStand_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = SystemColors.Control;
            btnReturn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = SystemColors.ControlText;
            btnReturn.Location = new Point(730, 12);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(112, 49);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "QUIT GAME";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnBet
            // 
            btnBet.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold | FontStyle.Italic);
            btnBet.Location = new Point(669, 224);
            btnBet.Name = "btnBet";
            btnBet.Size = new Size(173, 50);
            btnBet.TabIndex = 5;
            btnBet.Text = "BET";
            btnBet.UseVisualStyleBackColor = true;
            btnBet.Visible = false;
            btnBet.Click += btnBet_Click;
            // 
            // playerCard1
            // 
            playerCard1.BorderStyle = BorderStyle.Fixed3D;
            playerCard1.Location = new Point(192, 224);
            playerCard1.Name = "playerCard1";
            playerCard1.Size = new Size(129, 156);
            playerCard1.TabIndex = 6;
            playerCard1.TabStop = false;
            playerCard1.Visible = false;
            // 
            // playerCard2
            // 
            playerCard2.BorderStyle = BorderStyle.Fixed3D;
            playerCard2.Location = new Point(339, 224);
            playerCard2.Name = "playerCard2";
            playerCard2.Size = new Size(129, 156);
            playerCard2.TabIndex = 7;
            playerCard2.TabStop = false;
            playerCard2.Visible = false;
            // 
            // playerCard3
            // 
            playerCard3.BackColor = SystemColors.Control;
            playerCard3.BorderStyle = BorderStyle.Fixed3D;
            playerCard3.Location = new Point(484, 224);
            playerCard3.Name = "playerCard3";
            playerCard3.Size = new Size(129, 156);
            playerCard3.TabIndex = 8;
            playerCard3.TabStop = false;
            playerCard3.Visible = false;
            // 
            // dealerCard1
            // 
            dealerCard1.BorderStyle = BorderStyle.Fixed3D;
            dealerCard1.Location = new Point(192, 12);
            dealerCard1.Name = "dealerCard1";
            dealerCard1.Size = new Size(129, 156);
            dealerCard1.TabIndex = 9;
            dealerCard1.TabStop = false;
            dealerCard1.Visible = false;
            // 
            // dealerCard2
            // 
            dealerCard2.BackColor = SystemColors.Control;
            dealerCard2.BorderStyle = BorderStyle.Fixed3D;
            dealerCard2.Location = new Point(339, 12);
            dealerCard2.Name = "dealerCard2";
            dealerCard2.Size = new Size(129, 156);
            dealerCard2.TabIndex = 10;
            dealerCard2.TabStop = false;
            dealerCard2.Visible = false;
            // 
            // dealerCard3
            // 
            dealerCard3.BackColor = SystemColors.Control;
            dealerCard3.BorderStyle = BorderStyle.Fixed3D;
            dealerCard3.Location = new Point(484, 12);
            dealerCard3.Name = "dealerCard3";
            dealerCard3.Size = new Size(129, 156);
            dealerCard3.TabIndex = 11;
            dealerCard3.TabStop = false;
            dealerCard3.Visible = false;
            // 
            // lblGameBalance
            // 
            lblGameBalance.AutoSize = true;
            lblGameBalance.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic);
            lblGameBalance.Location = new Point(192, 391);
            lblGameBalance.Name = "lblGameBalance";
            lblGameBalance.Size = new Size(194, 50);
            lblGameBalance.TabIndex = 20;
            lblGameBalance.Text = "BALANCE:";
            // 
            // btnPlayRound
            // 
            btnPlayRound.BackColor = Color.White;
            btnPlayRound.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            btnPlayRound.Location = new Point(669, 87);
            btnPlayRound.Name = "btnPlayRound";
            btnPlayRound.Size = new Size(173, 81);
            btnPlayRound.TabIndex = 21;
            btnPlayRound.Text = "START NEW ROUND";
            btnPlayRound.UseVisualStyleBackColor = false;
            btnPlayRound.Click += btnPlayRound_Click;
            // 
            // picChip5
            // 
            picChip5.BackColor = SystemColors.Control;
            picChip5.BackgroundImage = (Image)resources.GetObject("picChip5.BackgroundImage");
            picChip5.BackgroundImageLayout = ImageLayout.Stretch;
            picChip5.BorderStyle = BorderStyle.Fixed3D;
            picChip5.Location = new Point(696, 283);
            picChip5.Name = "picChip5";
            picChip5.Size = new Size(75, 72);
            picChip5.TabIndex = 22;
            picChip5.TabStop = false;
            picChip5.Visible = false;
            picChip5.Click += picChip5_Click;
            // 
            // picChip1000
            // 
            picChip1000.BackColor = SystemColors.Control;
            picChip1000.BackgroundImage = (Image)resources.GetObject("picChip1000.BackgroundImage");
            picChip1000.BackgroundImageLayout = ImageLayout.Stretch;
            picChip1000.BorderStyle = BorderStyle.Fixed3D;
            picChip1000.Location = new Point(730, 424);
            picChip1000.Name = "picChip1000";
            picChip1000.Size = new Size(75, 72);
            picChip1000.TabIndex = 23;
            picChip1000.TabStop = false;
            picChip1000.Visible = false;
            picChip1000.Click += picChip1000_Click;
            // 
            // picChip100
            // 
            picChip100.BackColor = SystemColors.Control;
            picChip100.BackgroundImage = (Image)resources.GetObject("picChip100.BackgroundImage");
            picChip100.BackgroundImageLayout = ImageLayout.Stretch;
            picChip100.BorderStyle = BorderStyle.Fixed3D;
            picChip100.Location = new Point(767, 352);
            picChip100.Name = "picChip100";
            picChip100.Size = new Size(75, 72);
            picChip100.TabIndex = 24;
            picChip100.TabStop = false;
            picChip100.Visible = false;
            picChip100.Click += picChip100_Click;
            // 
            // picChip50
            // 
            picChip50.BackColor = SystemColors.Control;
            picChip50.BackgroundImage = (Image)resources.GetObject("picChip50.BackgroundImage");
            picChip50.BackgroundImageLayout = ImageLayout.Stretch;
            picChip50.BorderStyle = BorderStyle.Fixed3D;
            picChip50.Location = new Point(696, 352);
            picChip50.Name = "picChip50";
            picChip50.Size = new Size(75, 72);
            picChip50.TabIndex = 25;
            picChip50.TabStop = false;
            picChip50.Visible = false;
            picChip50.Click += picChip50_Click;
            // 
            // picChip10
            // 
            picChip10.BackColor = SystemColors.Control;
            picChip10.BackgroundImage = (Image)resources.GetObject("picChip10.BackgroundImage");
            picChip10.BackgroundImageLayout = ImageLayout.Stretch;
            picChip10.BorderStyle = BorderStyle.Fixed3D;
            picChip10.Location = new Point(767, 283);
            picChip10.Name = "picChip10";
            picChip10.Size = new Size(75, 72);
            picChip10.TabIndex = 26;
            picChip10.TabStop = false;
            picChip10.Visible = false;
            picChip10.Click += picChip10_Click;
            // 
            // lblBetAmount
            // 
            lblBetAmount.AutoSize = true;
            lblBetAmount.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic);
            lblBetAmount.Location = new Point(192, 446);
            lblBetAmount.Name = "lblBetAmount";
            lblBetAmount.Size = new Size(202, 50);
            lblBetAmount.TabIndex = 27;
            lblBetAmount.Text = "YOUR BET:";
            lblBetAmount.Visible = false;
            // 
            // btnStartGame
            // 
            btnStartGame.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold | FontStyle.Italic);
            btnStartGame.Location = new Point(311, 160);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(175, 91);
            btnStartGame.TabIndex = 28;
            btnStartGame.Text = "START GAME";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Visible = false;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // plCard3FaceDown
            // 
            plCard3FaceDown.BackColor = Color.Transparent;
            plCard3FaceDown.BackgroundImage = (Image)resources.GetObject("plCard3FaceDown.BackgroundImage");
            plCard3FaceDown.BackgroundImageLayout = ImageLayout.Stretch;
            plCard3FaceDown.Location = new Point(484, 224);
            plCard3FaceDown.Name = "plCard3FaceDown";
            plCard3FaceDown.Size = new Size(129, 156);
            plCard3FaceDown.TabIndex = 29;
            plCard3FaceDown.TabStop = false;
            plCard3FaceDown.Visible = false;
            // 
            // dlCard2FaceDown
            // 
            dlCard2FaceDown.BackColor = Color.Transparent;
            dlCard2FaceDown.BackgroundImage = (Image)resources.GetObject("dlCard2FaceDown.BackgroundImage");
            dlCard2FaceDown.BackgroundImageLayout = ImageLayout.Stretch;
            dlCard2FaceDown.Location = new Point(339, 12);
            dlCard2FaceDown.Name = "dlCard2FaceDown";
            dlCard2FaceDown.Size = new Size(129, 156);
            dlCard2FaceDown.TabIndex = 30;
            dlCard2FaceDown.TabStop = false;
            dlCard2FaceDown.Visible = false;
            // 
            // dlCard3FaceDown
            // 
            dlCard3FaceDown.BackColor = Color.Transparent;
            dlCard3FaceDown.BackgroundImage = (Image)resources.GetObject("dlCard3FaceDown.BackgroundImage");
            dlCard3FaceDown.BackgroundImageLayout = ImageLayout.Stretch;
            dlCard3FaceDown.Location = new Point(484, 12);
            dlCard3FaceDown.Name = "dlCard3FaceDown";
            dlCard3FaceDown.Size = new Size(129, 156);
            dlCard3FaceDown.TabIndex = 31;
            dlCard3FaceDown.TabStop = false;
            dlCard3FaceDown.Visible = false;
            // 
            // btnTutorial
            // 
            btnTutorial.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTutorial.Location = new Point(12, 12);
            btnTutorial.Name = "btnTutorial";
            btnTutorial.Size = new Size(96, 23);
            btnTutorial.TabIndex = 32;
            btnTutorial.Text = "TUTORIAL";
            btnTutorial.UseVisualStyleBackColor = true;
            btnTutorial.Click += btnTutorial_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(862, 514);
            Controls.Add(btnTutorial);
            Controls.Add(dlCard3FaceDown);
            Controls.Add(dlCard2FaceDown);
            Controls.Add(plCard3FaceDown);
            Controls.Add(btnStartGame);
            Controls.Add(lblBetAmount);
            Controls.Add(picChip10);
            Controls.Add(picChip50);
            Controls.Add(picChip100);
            Controls.Add(picChip1000);
            Controls.Add(picChip5);
            Controls.Add(btnPlayRound);
            Controls.Add(lblGameBalance);
            Controls.Add(dealerCard3);
            Controls.Add(dealerCard2);
            Controls.Add(dealerCard1);
            Controls.Add(playerCard3);
            Controls.Add(playerCard2);
            Controls.Add(playerCard1);
            Controls.Add(btnBet);
            Controls.Add(btnReturn);
            Controls.Add(btnStand);
            Controls.Add(btnHit);
            Controls.Add(lblDealerCards);
            Controls.Add(lblCards);
            Name = "Game";
            Text = "Game";
            ((System.ComponentModel.ISupportInitialize)playerCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealerCard3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChip5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChip1000).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChip100).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChip50).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChip10).EndInit();
            ((System.ComponentModel.ISupportInitialize)plCard3FaceDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dlCard2FaceDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dlCard3FaceDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCards;
        private Label lblDealerCards;
        private Button btnHit;
        private Button btnStand;
        private Button btnReturn;
        private Button btnBet;
        private PictureBox playerCard1;
        private PictureBox playerCard2;
        private PictureBox playerCard3;
        private PictureBox dealerCard1;
        private PictureBox dealerCard2;
        private PictureBox dealerCard3;
        private Label lblGameBalance;
        private Button btnPlayRound;
        private PictureBox picChip5;
        private PictureBox picChip1000;
        private PictureBox picChip100;
        private PictureBox picChip50;
        private PictureBox picChip10;
        private Label lblBetAmount;
        private Button btnStartGame;
        private PictureBox plCard3FaceDown;
        private PictureBox dlCard2FaceDown;
        private PictureBox dlCard3FaceDown;
        private Button btnTutorial;
    }
}