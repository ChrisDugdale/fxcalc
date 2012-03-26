using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FXCalculator
{
    //ide test
    public static class Calculate
    {
        /// <summary>
        /// Received a level object containing the given levels from the form. calculates the levels for the other fields from the current quote and the entered levels.
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public static Level CalculateLevels(Level level)
        {
            
                Level calculatedlevels = new Level();

                //calculate buy levels based on Order level
                calculatedlevels.BuyOrderLevel = Convert.ToDouble(level.BuyPrice + (level.BuyOrderLevel / 10000));
                calculatedlevels.BuyStopLoss = (calculatedlevels.BuyOrderLevel - (level.BuyStopLoss / 10000));
                calculatedlevels.BuyTakeProfit = (calculatedlevels.BuyOrderLevel + (level.BuyTakeProfit / 10000));

                //calculate sell levels based on order level.
                calculatedlevels.SellOrderLevel = Convert.ToDouble(level.SellPrice - (level.SellOrderLevel / 10000));
                calculatedlevels.SellStopLoss = (calculatedlevels.SellOrderLevel + (level.SellStopLoss / 10000));
                calculatedlevels.SellTakeProfit = (calculatedlevels.SellOrderLevel - (level.SellTakeProfit / 10000));

                return calculatedlevels;
        }
    }
}
