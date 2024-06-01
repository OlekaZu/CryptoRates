namespace CryptoRates
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            mainPanel = new Panel();
            butExit = new Button();
            label2 = new Label();
            tbKucoin = new TextBox();
            tbBybit = new TextBox();
            label7 = new Label();
            tbBitget = new TextBox();
            label6 = new Label();
            tbBinance = new TextBox();
            label5 = new Label();
            cbPairs = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            labelCurrentTime = new Label();
            label1 = new Label();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(butExit);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(tbKucoin);
            mainPanel.Controls.Add(tbBybit);
            mainPanel.Controls.Add(label7);
            mainPanel.Controls.Add(tbBitget);
            mainPanel.Controls.Add(label6);
            mainPanel.Controls.Add(tbBinance);
            mainPanel.Controls.Add(label5);
            mainPanel.Controls.Add(cbPairs);
            mainPanel.Controls.Add(label4);
            mainPanel.Controls.Add(label3);
            mainPanel.Controls.Add(label8);
            mainPanel.Controls.Add(labelCurrentTime);
            mainPanel.Controls.Add(label1);
            mainPanel.Location = new Point(12, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(267, 314);
            mainPanel.TabIndex = 0;
            // 
            // butExit
            // 
            butExit.BackColor = Color.FromArgb(56, 54, 55);
            butExit.FlatStyle = FlatStyle.Flat;
            butExit.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.World, 204);
            butExit.ForeColor = Color.White;
            butExit.Location = new Point(92, 281);
            butExit.Name = "butExit";
            butExit.Size = new Size(85, 30);
            butExit.TabIndex = 4;
            butExit.Text = "Закрыть";
            butExit.UseVisualStyleBackColor = false;
            butExit.Click += butExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.World);
            label2.ForeColor = Color.FromArgb(56, 54, 55);
            label2.Location = new Point(19, 0);
            label2.Name = "label2";
            label2.Size = new Size(226, 19);
            label2.TabIndex = 3;
            label2.Text = "Актуальный курс криптовалют";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbKucoin
            // 
            tbKucoin.BorderStyle = BorderStyle.None;
            tbKucoin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbKucoin.ForeColor = Color.FromArgb(56, 54, 55);
            tbKucoin.Location = new Point(92, 193);
            tbKucoin.Name = "tbKucoin";
            tbKucoin.Size = new Size(153, 22);
            tbKucoin.TabIndex = 2;
            // 
            // tbBybit
            // 
            tbBybit.BorderStyle = BorderStyle.None;
            tbBybit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbBybit.ForeColor = Color.FromArgb(56, 54, 55);
            tbBybit.Location = new Point(92, 165);
            tbBybit.Name = "tbBybit";
            tbBybit.Size = new Size(153, 22);
            tbBybit.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.FromArgb(56, 54, 55);
            label7.ImageAlign = ContentAlignment.BottomCenter;
            label7.Location = new Point(19, 196);
            label7.Name = "label7";
            label7.Size = new Size(60, 21);
            label7.TabIndex = 0;
            label7.Text = "Kucoin";
            // 
            // tbBitget
            // 
            tbBitget.BorderStyle = BorderStyle.None;
            tbBitget.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbBitget.ForeColor = Color.FromArgb(56, 54, 55);
            tbBitget.Location = new Point(92, 137);
            tbBitget.Name = "tbBitget";
            tbBitget.Size = new Size(153, 22);
            tbBitget.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.FromArgb(56, 54, 55);
            label6.ImageAlign = ContentAlignment.BottomCenter;
            label6.Location = new Point(19, 168);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 0;
            label6.Text = "Bybit";
            // 
            // tbBinance
            // 
            tbBinance.BorderStyle = BorderStyle.None;
            tbBinance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            tbBinance.ForeColor = Color.FromArgb(56, 54, 55);
            tbBinance.Location = new Point(92, 109);
            tbBinance.Name = "tbBinance";
            tbBinance.Size = new Size(153, 22);
            tbBinance.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(56, 54, 55);
            label5.ImageAlign = ContentAlignment.BottomCenter;
            label5.Location = new Point(19, 140);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 0;
            label5.Text = "Bitget";
            // 
            // cbPairs
            // 
            cbPairs.AllowDrop = true;
            cbPairs.BackColor = SystemColors.Window;
            cbPairs.FlatStyle = FlatStyle.Flat;
            cbPairs.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cbPairs.ForeColor = Color.FromArgb(56, 54, 55);
            cbPairs.FormattingEnabled = true;
            cbPairs.Items.AddRange(new object[] { "BTCUSDT", "ETHUSDT", "SOLUSDT" });
            cbPairs.Location = new Point(19, 44);
            cbPairs.Name = "cbPairs";
            cbPairs.Size = new Size(226, 29);
            cbPairs.Sorted = true;
            cbPairs.TabIndex = 1;
            cbPairs.SelectedIndexChanged += cbPairs_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.FromArgb(56, 54, 55);
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(19, 112);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 0;
            label4.Text = "Binance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(56, 54, 55);
            label3.Location = new Point(19, 85);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Биржи:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label8.ForeColor = Color.FromArgb(56, 54, 55);
            label8.Location = new Point(19, 257);
            label8.Name = "label8";
            label8.Size = new Size(168, 15);
            label8.TabIndex = 0;
            label8.Text = "Скорость обновления - 5 сек.";
            // 
            // labelCurrentTime
            // 
            labelCurrentTime.AutoSize = true;
            labelCurrentTime.ForeColor = Color.FromArgb(56, 54, 55);
            labelCurrentTime.Location = new Point(19, 230);
            labelCurrentTime.Name = "labelCurrentTime";
            labelCurrentTime.Size = new Size(76, 15);
            labelCurrentTime.TabIndex = 0;
            labelCurrentTime.Text = "Current Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(56, 54, 55);
            label1.Location = new Point(19, 26);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Выберите пару:";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            ClientSize = new Size(284, 331);
            Controls.Add(mainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(300, 370);
            MinimumSize = new Size(300, 370);
            Name = "MainWindow";
            Text = "CryptoRates";
            Load += MainWindow_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Label label1;
        private Label label2;
        private TextBox tbBinance;
        private ComboBox cbPairs;
        private Label label3;
        private Label label4;
        private TextBox tbKucoin;
        private TextBox tbBybit;
        private Label label7;
        private TextBox tbBitget;
        private Label label6;
        private Label label5;
        private Label labelCurrentTime;
        private Button butExit;
        private Label label8;
    }
}
