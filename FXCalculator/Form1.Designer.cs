namespace FXCalculator
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBuyProfit = new System.Windows.Forms.TextBox();
            this.textSellProfit = new System.Windows.Forms.TextBox();
            this.textBuyStop = new System.Windows.Forms.TextBox();
            this.textSellStop = new System.Windows.Forms.TextBox();
            this.textBuyOrder = new System.Windows.Forms.TextBox();
            this.textSellOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBuyProfit = new System.Windows.Forms.Label();
            this.labelBuyStop = new System.Windows.Forms.Label();
            this.labelBuyOrder = new System.Windows.Forms.Label();
            this.labelSellProfit = new System.Windows.Forms.Label();
            this.labelSellStop = new System.Windows.Forms.Label();
            this.labelSellOrder = new System.Windows.Forms.Label();
            this.textBuyPrice = new System.Windows.Forms.TextBox();
            this.textSellPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkAbout = new System.Windows.Forms.LinkLabel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(58, 4);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(276, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Spread Betting Forex Calculator";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBuyProfit
            // 
            this.textBuyProfit.Location = new System.Drawing.Point(119, 61);
            this.textBuyProfit.Name = "textBuyProfit";
            this.textBuyProfit.Size = new System.Drawing.Size(25, 20);
            this.textBuyProfit.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBuyProfit, "Set this to how far into profit you want your trade to go before it is closed aut" +
                    "omatically");
            // 
            // textSellProfit
            // 
            this.textSellProfit.Location = new System.Drawing.Point(256, 61);
            this.textSellProfit.Name = "textSellProfit";
            this.textSellProfit.Size = new System.Drawing.Size(25, 20);
            this.textSellProfit.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textSellProfit, "Set this to how far into profit you want your trade to go before it is closed aut" +
                    "omatically");
            // 
            // textBuyStop
            // 
            this.textBuyStop.Location = new System.Drawing.Point(119, 87);
            this.textBuyStop.Name = "textBuyStop";
            this.textBuyStop.Size = new System.Drawing.Size(25, 20);
            this.textBuyStop.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBuyStop, "Set this to how far into loss you want your trade to go before it is closed autom" +
                    "atically");
            // 
            // textSellStop
            // 
            this.textSellStop.Location = new System.Drawing.Point(256, 87);
            this.textSellStop.Name = "textSellStop";
            this.textSellStop.Size = new System.Drawing.Size(25, 20);
            this.textSellStop.TabIndex = 6;
            this.toolTip1.SetToolTip(this.textSellStop, "Set this to how far into loss you want your trade to go before it is closed autom" +
                    "atically");
            // 
            // textBuyOrder
            // 
            this.textBuyOrder.Location = new System.Drawing.Point(119, 113);
            this.textBuyOrder.Name = "textBuyOrder";
            this.textBuyOrder.Size = new System.Drawing.Size(25, 20);
            this.textBuyOrder.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBuyOrder, "Set this to how far above the current price you want your trade to open");
            // 
            // textSellOrder
            // 
            this.textSellOrder.Location = new System.Drawing.Point(256, 113);
            this.textSellOrder.Name = "textSellOrder";
            this.textSellOrder.Size = new System.Drawing.Size(25, 20);
            this.textSellOrder.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textSellOrder, "Set this to how far below the current price you want your trade to open");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Profit Level";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label1, "This is the level that you want the trade to be closed at, if it is in profit");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Stop Loss";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label2, "This is the level that you want the trade to be closed at, if it is in loss");
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Order Level";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label3, "This is the level that you want the trade to open at");
            // 
            // labelBuyProfit
            // 
            this.labelBuyProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuyProfit.Location = new System.Drawing.Point(47, 61);
            this.labelBuyProfit.Name = "labelBuyProfit";
            this.labelBuyProfit.Size = new System.Drawing.Size(66, 18);
            this.labelBuyProfit.TabIndex = 10;
            this.labelBuyProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBuyStop
            // 
            this.labelBuyStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuyStop.Location = new System.Drawing.Point(47, 87);
            this.labelBuyStop.Name = "labelBuyStop";
            this.labelBuyStop.Size = new System.Drawing.Size(66, 18);
            this.labelBuyStop.TabIndex = 11;
            this.labelBuyStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBuyOrder
            // 
            this.labelBuyOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuyOrder.Location = new System.Drawing.Point(47, 113);
            this.labelBuyOrder.Name = "labelBuyOrder";
            this.labelBuyOrder.Size = new System.Drawing.Size(66, 18);
            this.labelBuyOrder.TabIndex = 12;
            this.labelBuyOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSellProfit
            // 
            this.labelSellProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSellProfit.Location = new System.Drawing.Point(287, 61);
            this.labelSellProfit.Name = "labelSellProfit";
            this.labelSellProfit.Size = new System.Drawing.Size(63, 18);
            this.labelSellProfit.TabIndex = 13;
            this.labelSellProfit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSellStop
            // 
            this.labelSellStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSellStop.Location = new System.Drawing.Point(287, 87);
            this.labelSellStop.Name = "labelSellStop";
            this.labelSellStop.Size = new System.Drawing.Size(63, 18);
            this.labelSellStop.TabIndex = 14;
            this.labelSellStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSellOrder
            // 
            this.labelSellOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSellOrder.Location = new System.Drawing.Point(287, 113);
            this.labelSellOrder.Name = "labelSellOrder";
            this.labelSellOrder.Size = new System.Drawing.Size(63, 18);
            this.labelSellOrder.TabIndex = 15;
            this.labelSellOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBuyPrice
            // 
            this.textBuyPrice.Location = new System.Drawing.Point(44, 167);
            this.textBuyPrice.Name = "textBuyPrice";
            this.textBuyPrice.Size = new System.Drawing.Size(100, 20);
            this.textBuyPrice.TabIndex = 4;
            // 
            // textSellPrice
            // 
            this.textSellPrice.Location = new System.Drawing.Point(253, 167);
            this.textSellPrice.Name = "textSellPrice";
            this.textSellPrice.Size = new System.Drawing.Size(100, 20);
            this.textSellPrice.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Current Level";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label4, "This is the current level of the currencies");
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 33);
            this.label5.TabIndex = 19;
            this.label5.Text = "BUY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "SELL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(153, 201);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(97, 34);
            this.buttonCalculate.TabIndex = 21;
            this.buttonCalculate.Text = "Calculate!";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelMessage.Location = new System.Drawing.Point(-1, 238);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(401, 18);
            this.labelMessage.TabIndex = 22;
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(44, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 23;
            this.label7.Text = "GBP/USD";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label7, "The buy price of the Great British Pound against the Dollar");
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(250, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 28);
            this.label8.TabIndex = 24;
            this.label8.Text = "EUR/USD";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label8, "The sell price of the Euro against the Dollar");
            // 
            // linkAbout
            // 
            this.linkAbout.AutoSize = true;
            this.linkAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAbout.Location = new System.Drawing.Point(354, 226);
            this.linkAbout.Name = "linkAbout";
            this.linkAbout.Size = new System.Drawing.Size(35, 13);
            this.linkAbout.TabIndex = 25;
            this.linkAbout.TabStop = true;
            this.linkAbout.Text = "About";
            this.linkAbout.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAbout_LinkClicked);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(411, 269);
            this.shapeContainer1.TabIndex = 30;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 309;
            this.lineShape2.X2 = 304;
            this.lineShape2.Y1 = 136;
            this.lineShape2.Y2 = 160;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 91;
            this.lineShape1.X2 = 86;
            this.lineShape1.Y1 = 137;
            this.lineShape1.Y2 = 161;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::FXCalculator.Properties.Resources.UpArrow;
            this.pictureBox6.Location = new System.Drawing.Point(3, 61);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(63, 70);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 32;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Image = global::FXCalculator.Properties.Resources.money_dollar;
            this.pictureBox3.Location = new System.Drawing.Point(92, 137);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Image = global::FXCalculator.Properties.Resources.money_pound;
            this.pictureBox4.Location = new System.Drawing.Point(62, 137);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = global::FXCalculator.Properties.Resources.money_dollar;
            this.pictureBox2.Location = new System.Drawing.Point(310, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::FXCalculator.Properties.Resources.money_euro;
            this.pictureBox1.Location = new System.Drawing.Point(280, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FXCalculator.Properties.Resources.DownArrow;
            this.pictureBox5.Location = new System.Drawing.Point(338, 61);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(63, 70);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 269);
            this.Controls.Add(this.linkAbout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSellPrice);
            this.Controls.Add(this.textBuyPrice);
            this.Controls.Add(this.labelSellOrder);
            this.Controls.Add(this.labelSellStop);
            this.Controls.Add(this.labelSellProfit);
            this.Controls.Add(this.labelBuyOrder);
            this.Controls.Add(this.labelBuyStop);
            this.Controls.Add(this.labelBuyProfit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSellOrder);
            this.Controls.Add(this.textBuyOrder);
            this.Controls.Add(this.textSellStop);
            this.Controls.Add(this.textBuyStop);
            this.Controls.Add(this.textSellProfit);
            this.Controls.Add(this.textBuyProfit);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(417, 297);
            this.MinimumSize = new System.Drawing.Size(417, 297);
            this.Name = "MainForm";
            this.Text = "Spread Betting Forex Calculator";
            this.toolTip1.SetToolTip(this, "Spread Betting Forex Calculator");
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textSellProfit;
        private System.Windows.Forms.TextBox textBuyStop;
        private System.Windows.Forms.TextBox textSellStop;
        private System.Windows.Forms.TextBox textBuyOrder;
        private System.Windows.Forms.TextBox textSellOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBuyProfit;
        private System.Windows.Forms.Label labelBuyStop;
        private System.Windows.Forms.Label labelBuyOrder;
        private System.Windows.Forms.Label labelSellProfit;
        private System.Windows.Forms.Label labelSellStop;
        private System.Windows.Forms.Label labelSellOrder;
        private System.Windows.Forms.TextBox textBuyPrice;
        private System.Windows.Forms.TextBox textSellPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCalculate;
        internal System.Windows.Forms.TextBox textBuyProfit;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

