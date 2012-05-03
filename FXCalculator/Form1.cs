using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FXCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /*internal Levels PriceChange(bool isBuy)
        {

            //check if the text changed came from buy or sell price text box. true = buy, false = sell
            Levels level = new Levels();
            if (isBuy)
            {
                level.BuyTakeProfit = 1;
                level.BuyStopLoss = 2;
                level.BuyOrderLevel = 2;
                return level;

            }
            if (!isBuy)
            {
                level.SellTakeProfit = 1;
                level.SellStopLoss = 2;
                level.SellOrderLevel = 3;
                return level;
            }
            else throw new ArgumentOutOfRangeException();

        }
        private void textBuyPrice_TextChanged(object sender, EventArgs e)
        {
            Levels buyLevels = new Levels();
            buyLevels = (PriceChange(true));
            labelBuyProfit.Text = buyLevels.BuyTakeProfit.ToString();
            labelBuyStop.Text = buyLevels.BuyStopLoss.ToString();
            labelBuyOrder.Text = buyLevels.BuyOrderLevel.ToString();
            

        }

        private void textSellPrice_TextChanged(object sender, EventArgs e)
        {
            
            Levels sellLevels = new Levels();
            sellLevels = (PriceChange(false));
            labelSellProfit.Text = sellLevels.SellTakeProfit.ToString();
            labelSellStop.Text = sellLevels.SellStopLoss.ToString();
            labelSellOrder.Text = sellLevels.SellOrderLevel.ToString();
        }*/

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert the Text inputs into Doubles and assign to level. Requires user validation still (do this in form? Intergers only)
                Level level = new Level
                                  {
                                      BuyTakeProfit = Convert.ToDouble(textBuyProfit.Text),
                                      BuyStopLoss = Convert.ToDouble(textBuyStop.Text),
                                      BuyOrderLevel = Convert.ToDouble(textBuyOrder.Text),
                                      BuyPrice = Convert.ToDouble(textBuyPrice.Text),
                                      SellTakeProfit = Convert.ToDouble(textSellProfit.Text),
                                      SellStopLoss = Convert.ToDouble(textSellStop.Text),
                                      SellOrderLevel = Convert.ToDouble(textSellOrder.Text),
                                      SellPrice = Convert.ToDouble(textSellPrice.Text)
                                  };

                //send level with text box levels in to calculate the label levels to be added to the form
                Level calculatedLevels = Calculate.CalculateLevels(level);

                //Change label text to show the level that should be set with the order.
                labelBuyProfit.Text = String.Format("{0: 0.0000}", calculatedLevels.BuyTakeProfit);
                labelBuyStop.Text = String.Format("{0: 0.0000}", calculatedLevels.BuyStopLoss);
                labelBuyOrder.Text = String.Format("{0: 0.0000}", calculatedLevels.BuyOrderLevel);


                labelSellProfit.Text = String.Format("{0: 0.0000}", calculatedLevels.SellTakeProfit);
                labelSellStop.Text = String.Format("{0: 0.0000}", calculatedLevels.SellStopLoss);
                labelSellOrder.Text = String.Format("{0: 0.0000}", calculatedLevels.SellOrderLevel);


            }
            catch(FormatException)
            {
                labelMessage.Text = ("Please Enter valid levels into all of the text boxes");
            }

            catch (Exception Ex)
            {
                labelMessage.Text = (Ex.Message);

                
            }



        }

        private void linkAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkAbout.LinkVisited = true;
            FormAbout about = new FormAbout();
            about.Show();
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
