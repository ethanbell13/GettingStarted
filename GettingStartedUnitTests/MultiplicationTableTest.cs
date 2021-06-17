﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace GettingStartedLibrary.Tests
{
    [TestClass]
    public class MultiplicationTabletest
    {
        [TestMethod]
        public void MultiplicationTableSolutionTest()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                new MultiplicationTable().MultiplicationTableSolution();
                Assert.AreEqual(sw.ToString().Trim(), "--------------------------------------------\n| x|0| 1| 2| 3| 4| 5| 6| 7| 8|  9| 10" +
                    "| 11| 12|\r\n| 0|0| 0| 0| 0| 0| 0| 0| 0| 0|  0|  0|  0|  0|\r\n| 1|0| 1| 2| 3| 4| 5| 6| 7| 8|  9| 10| 11| 12|" +
                    "\r\n| 2|0| 2| 4| 6| 8|10|12|14|16| 18| 20| 22| 24|\r\n| 3|0| 3| 6| 9|12|15|18|21|24| 27| 30| 33| 36|\r\n| 4|0| 4| 8" +
                    "|12|16|20|24|28|32| 36| 40| 44| 48|\r\n| 5|0| 5|10|15|20|25|30|35|40| 45| 50| 55| 60|\r\n| 6|0| 6|12|18|24|30|36|42|" +
                    "48| 54| 60| 66| 72|\r\n| 7|0| 7|14|21|28|35|42|49|56| 63| 70| 77| 84|\r\n| 8|0| 8|16|24|32|40|48|56|64| 72| 80| 88" +
                    "| 96|\r\n| 9|0| 9|18|27|36|45|54|63|72| 81| 90| 99|108|\r\n|10|0|10|20|30|40|50|60|70|80| 90|100|110|120|\r\n|11|0" +
                    "|11|22|33|44|55|66|77|88| 99|110|121|132|\r\n|12|0|12|24|36|48|60|72|84|96|108|120|132|144|" +
                    "\r\n --------------------------------------------");
            }
        }
    }
}


