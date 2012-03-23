using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FXCalculator
{
    public class Level
    {
        private double _buyTakeProfit, _buyStopLoss, _buyOrderLevel, _sellTakeProfit, _sellStopLoss, _sellOrderLevel, _buyPrice, _sellPrice;

        public double BuyTakeProfit
        {
            get { return this._buyTakeProfit; }
            set { this._buyTakeProfit = value; }
        }

        public double BuyStopLoss
        {
            get { return this._buyStopLoss; }
            set { this._buyStopLoss = value; }
        }

        public double BuyOrderLevel
        {
            get { return this._buyOrderLevel; }
            set { this._buyOrderLevel = value; }
        }

        public double BuyPrice
        {
            get { return this._buyPrice; }
            set { this._buyPrice = value; }
        }

        public double SellTakeProfit
        {
            get { return this._sellTakeProfit; }
            set { this._sellTakeProfit = value; }
        }

        public double SellStopLoss
        {
            get { return this._sellStopLoss; }
            set { this._sellStopLoss = value; }
        }

        public double SellOrderLevel
        {
            get { return this._sellOrderLevel; }
            set { this._sellOrderLevel = value; }
        }

        public double SellPrice
        {
            get { return this._sellPrice; }
            set { this._sellPrice = value; }
        }
    }
}
