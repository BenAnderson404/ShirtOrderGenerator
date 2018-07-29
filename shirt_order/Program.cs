using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shirt_order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("How many T-shirts?");
            string quantityPre = Console.ReadLine();
            Console.Out.WriteLine("What is the cost of non-larger sizes?");
            string ppuPre = Console.ReadLine();
            Console.Out.WriteLine("What is the surcharge for larger sizes?");
            string plusChargePre = Console.ReadLine();
            Console.Out.WriteLine("What percent of the shirts should be size SMALL?");
            string smallqPre = Console.ReadLine();
            Console.Out.WriteLine("What percent of the shirts should be size MEDIUM?");
            string mediumqPre = Console.ReadLine();
            Console.Out.WriteLine("What percent of the shirts should be size LARGE?");
            string largeqPre = Console.ReadLine();
            Console.Out.WriteLine("What percent of the shirts should be size XL?");
            string xlqPre = Console.ReadLine();
            Console.Out.WriteLine("What percent of the shirts should be size XXL?");
            string xxlqPre = Console.ReadLine();
            Console.Out.WriteLine("What percent of the shirts should be size 3XL?");
            string xxxlqPre = Console.ReadLine();
            Console.Out.WriteLine("What percent of the shirts should be size 4XL?");
            string xxxxlqPre = Console.ReadLine();
            Console.Out.WriteLine("What percent of the shirts should be size 5XL?");
            string xxxxxlqPre = Console.ReadLine();
            Console.Out.WriteLine("...");
            Console.Out.WriteLine("What is the total number of Black shirts you want to order?");
            string blackPre = Console.ReadLine();
            Console.Out.WriteLine("What is the total number of Turquoise shirts you want to order?");
            string turquoisePre = Console.ReadLine();
            Console.Out.WriteLine("What is the total number of Forest Green shirts you want to order?");
            string forestPre = Console.ReadLine();
            Console.Out.WriteLine("What is the total number of Sangria shirts you want to order?");
            string sangriaPre = Console.ReadLine();
            Console.Out.WriteLine("What is the total number of Candy Pink shirts you want to order?");
            string candyPre = Console.ReadLine();
            Console.Out.WriteLine("What is the total number of Purple shirts you want to order?");
            string purplePre = Console.ReadLine();
            Console.Out.WriteLine("What is the total number of Navy shirts you want to order?");
            string navyPre = Console.ReadLine();
            Console.Out.WriteLine("What is the total number of Yellow shirts you want to order?");
            string yellowPre = Console.ReadLine();
            Console.Out.WriteLine("What is the total number of Lime Green shirts you want to order?");
            string limePre = Console.ReadLine();
            Console.Out.WriteLine("What is the total number of Lavender shirts you want to order?");
            string lavenderPre = Console.ReadLine();
            Console.Out.WriteLine("What is the total number of Orange shirts you want to order?");
            string orangePre = Console.ReadLine();
            Console.Out.WriteLine("What is the total number of Royal Blue shirts you want to order?");
            string royalPre = Console.ReadLine();
            Console.Out.WriteLine("What is the total number of Sand shirts you want to order?");
            string sandPre = Console.ReadLine();
            Console.Out.WriteLine("What is the total number of Kelly Green shirts you want to order?");
            string kellyPre = Console.ReadLine();

                       
            double quantity = Convert.ToDouble(quantityPre);
            //double budget = Convert.ToDouble(budgetPre);
            double ppu = Convert.ToDouble(ppuPre);
            double plusCharge = Convert.ToDouble(plusChargePre);
            double smallQ = Convert.ToDouble(smallqPre);
            double mediumQ = Convert.ToDouble(mediumqPre);
            double largeQ = Convert.ToDouble(largeqPre);
            double xlQ = Convert.ToDouble(xlqPre);
            double xxlQ = Convert.ToDouble(xxlqPre);
            double xxxlQ = Convert.ToDouble(xxxlqPre);
            double xxxxlQ = Convert.ToDouble(xxxxlqPre);
            double xxxxxlQ = Convert.ToDouble(xxxxxlqPre);

            double smallFinalQuantity = ((smallQ * quantity) / 100);
            double smallSum = (smallFinalQuantity * ppu);
            double mediumFinalQuantity = ((mediumQ * quantity) / 100);
            double mediumSum = (mediumFinalQuantity * ppu);
            double largeFinalQuantity = ((largeQ * quantity) / 100);
            double largeSum = (largeFinalQuantity * ppu);
            double xlFinalQuantity = ((xlQ * quantity) / 100);
            double xlSum = (xlFinalQuantity * ppu);
            double xxlFinalQuantity = ((xxlQ * quantity) / 100);
            double xxlSum = (xxlFinalQuantity * (plusCharge * ppu));
            double xxxlFinalQuantity = ((xxxlQ * quantity) / 100);
            double xxxlSum = (xxxlFinalQuantity * (plusCharge * ppu));
            double xxxxlFinalQuantity = ((xxxxlQ * quantity) / 100);
            double xxxxlSum = (xxxxlFinalQuantity * (plusCharge * ppu));
            double xxxxxlFinalQuantity = ((xxxxxlQ * quantity) / 100);
            double xxxxxlSum = (xxxxxlFinalQuantity * (plusCharge * ppu));


            double blackRaw = Convert.ToDouble(blackPre);
            double turquoiseRaw = Convert.ToDouble(turquoisePre);
            double forestRaw = Convert.ToDouble(forestPre);
            double sangriaRaw = Convert.ToDouble(sangriaPre);
            double candyRaw = Convert.ToDouble(candyPre);
            double purpleRaw = Convert.ToDouble(purplePre);
            double navyRaw = Convert.ToDouble(navyPre);
            double yellowRaw = Convert.ToDouble(yellowPre);
            double limeRaw = Convert.ToDouble(limePre);
            double lavenderRaw = Convert.ToDouble(lavenderPre);
            double orangeRaw = Convert.ToDouble(orangePre);
            double royalRaw = Convert.ToDouble(royalPre);
            double sandRaw = Convert.ToDouble(sandPre);
            double kellyRaw = Convert.ToDouble(kellyPre);

            double smallC = Convert.ToDouble(smallqPre);
            double medC = Convert.ToDouble(mediumqPre);
            double largeC = Convert.ToDouble(largeqPre);
            double xlC = Convert.ToDouble(xlqPre);
            double xxlC = Convert.ToDouble(xxlqPre);
            double xxxlC = Convert.ToDouble(xxxlqPre);
            double xxxxlC = Convert.ToDouble(xxxxlqPre);

            double blackSmall = (blackRaw * (smallC / 100));
            double blackMed = (blackRaw * (medC / 100));
            double blackLarge = (blackRaw * (largeC / 100));
            double blackXl = (blackRaw * (xlC / 100));
            double blackXxl = (blackRaw * (xxlC / 100));
            double blackXxxl = (blackRaw * (xxxlC / 100));
            double blackXxxxl = (blackRaw * (xxxxlC / 100));
            double blackTotal = (blackSmall + blackMed + blackLarge + blackXl + blackXxl + blackXxxl + blackXxxxl);

            double turquoiseSmall = (turquoiseRaw * (smallC / 100));
            double turquoiseMed = (turquoiseRaw  * (medC / 100));
            double turquoiseLarge = (turquoiseRaw * (largeC / 100));
            double turquoiseXl = (turquoiseRaw * (xlC / 100));
            double turquoiseXxl = (turquoiseRaw * (xxlC / 100));
            double turquoiseXxxl = (turquoiseRaw * (xxxlC / 100));
            double turquoiseXxxxl = (turquoiseRaw * (xxxxlC /100));
            double turquoiseTotal = (turquoiseSmall + turquoiseMed + turquoiseLarge + turquoiseXl + turquoiseXxl + turquoiseXxxl + turquoiseXxxxl);

            double forestSmall = (forestRaw * (smallC / 100));
            double forestMed = (forestRaw * (medC / 100));
            double forestLarge = (forestRaw * (largeC / 100));
            double forestXl = (forestRaw * (xlC / 100));
            double forestXxl = (forestRaw * (xxlC / 100));
            double forestXxxl = (forestRaw * (xxxlC / 100));
            double forestXxxxl = (forestRaw * (xxxxlC / 100));
            double forestTotal = (forestSmall + forestMed + forestLarge + forestXl + forestXxl + forestXxl + forestXxxl + forestXxxxl);

            double sangriaSmall = (sangriaRaw * (smallC / 100));
            double sangriaMed = (sangriaRaw * (medC / 100));
            double sangriaLarge = (sangriaRaw * (largeC / 100));
            double sangriaXl = (sangriaRaw * (xlC / 100));
            double sangriaXxl = (sangriaRaw * (xxlC / 100));
            double sangriaXxxl = (sangriaRaw * (xxxlC / 100));
            double sangriaXxxxl = (sangriaRaw * (xxxxlC / 100));
            double sangriaTotal = (sangriaSmall + sangriaMed + sangriaLarge + sangriaXl + sangriaXxl + sangriaXxxl + sangriaXxxxl);

            double candySmall = (candyRaw * (smallC / 100));
            double candyMed = (candyRaw * (medC / 100));
            double candyLarge = (candyRaw * (largeC / 100));
            double candyXl = (candyRaw * (xlC / 100));
            double candyXxl = (candyRaw * (xxlC / 100));
            double candyXxxl = (candyRaw * (xxxlC / 100));
            double candyXxxxl = (candyRaw * (xxxxlC / 100));
            double candyTotal = (candySmall + candyMed + candyLarge + candyXl + candyXxl + candyXxxl + candyXxxxl);

            double purpleSmall = (purpleRaw * (smallC / 100));
            double purpleMed = (purpleRaw * (medC / 100));
            double purpleLarge = (purpleRaw * (largeC / 100));
            double purpleXl = (purpleRaw * (xlC / 100));
            double purpleXxl = (purpleRaw * (xxlC / 100));
            double purpleXxxl = (purpleRaw * (xxxlC / 100));
            double purpleXxxxl = (purpleRaw * (xxxxlC / 100));
            double purpleTotal = (purpleSmall + purpleMed + purpleLarge + purpleXl + purpleXxl + purpleXxxl + purpleXxxxl);

            double navySmall = (navyRaw * (smallC / 100));
            double navyMed = (navyRaw * (medC / 100));
            double navyLarge = (navyRaw * (largeQ / 100));
            double navyXl = (navyRaw * (xlC / 100));
            double navyXxl = (navyRaw * (xxlC / 100));
            double navyXxxl = (navyRaw * (xxxlC / 100));
            double navyXxxxl = (navyRaw * (xxxxlC / 100));
            double navyTotal = (navySmall + navyMed + navyLarge + navyXl + navyXxl + navyXxxl + navyXxxxl);

            double yellowSmall = (yellowRaw * (smallC / 100));
            double yellowMed = (yellowRaw * (medC / 100));
            double yellowLarge = (yellowRaw * (largeC / 100));
            double yellowXl = (yellowRaw * (xlC / 100));
            double yellowXxl = (yellowRaw * (xxlC / 100));
            double yellowXxxl = (yellowRaw * (xxxlC / 100));
            double yellowXxxxl = (yellowRaw * (xxxxlC / 100));
            double yellowTotal = (yellowSmall + yellowMed + yellowLarge + yellowXl + yellowXxl + yellowXxxl + yellowXxxxl);

            double limeSmall = (limeRaw * (smallC / 100));
            double limeMed = (limeRaw * (medC / 100));
            double limeLarge = (limeRaw * (largeC / 100));
            double limeXl = (limeRaw * (xlC / 100));
            double limeXxl = (limeRaw * (xxlC / 100));
            double limeXxxl = (limeRaw * (xxxlC / 100));
            double limeXxxxl = (limeRaw * (xxxxlC / 100));
            double limeTotal = (limeSmall + limeMed + limeLarge + limeXl + limeXxl + limeXxxl + limeXxxxl);

            double lavenderSmall = (lavenderRaw * (smallC / 100));
            double lavenderMed = (lavenderRaw * (medC / 100));
            double lavenderLarge = (lavenderRaw * (largeC / 100));
            double lavenderXl = (lavenderRaw * (xlC / 100));
            double lavenderXxl = (lavenderRaw * (xxlC / 100));
            double lavenderXxxl = (lavenderRaw * (xxxlC / 100));
            double lavenderXxxxl = (lavenderRaw * (xxxxlC / 100));
            double lavenderTotal = (lavenderSmall + lavenderMed + lavenderLarge + lavenderXl + lavenderXxl + lavenderXxxl + lavenderXxxxl);

            double orangeSmall = (orangeRaw * (smallC / 100));
            double orangeMed = (orangeRaw * (medC / 100));
            double orangeLarge = (orangeRaw * (largeC / 100));
            double orangeXl = (orangeRaw * (xlC / 100));
            double orangeXxl = (orangeRaw * (xxlC / 100));
            double orangeXxxl = (orangeRaw * (xxxlC / 100));
            double orangeXxxxl = (orangeRaw * (xxxxlC / 100));
            double orangeTotal = (orangeSmall + orangeMed + orangeLarge + orangeXl + orangeXxl + orangeXxxl + orangeXxxxl);

            double royalSmall = (royalRaw * (smallC / 100));
            double royalMed = (royalRaw * (medC / 100));
            double royalLarge = (royalRaw * (largeC / 100));
            double royalXl = (royalRaw * (xlC / 100));
            double royalXxl = (royalRaw * (xxlC / 100));
            double royalXxxl = (royalRaw * (xxxlC / 100));
            double royalXxxxl = (royalRaw *(xxxxlC / 100));
            double royalTotal = (royalSmall + royalMed + royalLarge + royalXl + royalXxl + royalXxxl + royalXxxxl);

            double sandSmall = (sandRaw * (smallC / 100));
            double sandMed = (sandRaw * (medC / 100));
            double sandLarge = (sandRaw * (largeC / 100));
            double sandXl = (sandRaw * (xlC / 100));
            double sandXxl = (sandRaw * (xxlC / 100));
            double sandXxxl = (sandRaw * (xxxlC / 100));
            double sandXxxxl = (sandRaw * (xxxxlC / 100));
            double sandTotal = (sandSmall + sandMed + sandLarge + sandXl + sandXxl + sandXxxl + sandXxxxl);

            double kellySmall = (kellyRaw * (smallC / 100));
            double kellyMed = (kellyRaw * (medC / 100));
            double kellyLarge = (kellyRaw * (largeC / 100));
            double kellyXl = (kellyRaw * (xlC / 100));
            double kellyXxl = (kellyRaw * (xxlC / 100));
            double kellyXxxl = (kellyRaw * (xxxlC / 100));
            double kellyXxxxl = (kellyRaw * (xxxxlC / 100));
            double kellyTotal = (kellySmall + kellyMed + kellyLarge + kellyXl + kellyXxl + kellyXxxl + kellyXxxxl);


            double preTax = (smallSum + mediumSum + largeSum + xlSum + xxlSum + xxxlSum + xxxxlSum);
            double taxRaw = ((preTax *1.08) - preTax);
            double shipping = ((preTax + taxRaw) * 0.04);
            double finalTotal = (taxRaw + preTax + shipping);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(".");
            Console.WriteLine("..");
            Console.WriteLine("...");
            Console.WriteLine("....");
            Console.WriteLine("...");
            Console.WriteLine("..");
            Console.WriteLine(".");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("###START COPY HERE###");


            Console.WriteLine("Color = Black" +
                Environment.NewLine +
                "Small = {0}"+
                Environment.NewLine +
                "Medium = {1}"+
                Environment.NewLine +
                "Large = {2}"+
                Environment.NewLine +
                "XL = {3}"+
                Environment.NewLine +
                "XXL = {4}"+
                Environment.NewLine +
                "XXXL = {5}"+
                Environment.NewLine +
                "4XL = {6}"+
                Environment.NewLine +
                "Total shirts = {7}", blackSmall, blackMed, blackLarge, blackXl, blackXxl, blackXxxl, blackXxxxl, blackTotal);
            
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Color = Turquoise" +
                Environment.NewLine +
                "Small = {0}"+
                Environment.NewLine +
                "Medium = {1}"+
                Environment.NewLine +
                "Large = {2}"+
                Environment.NewLine +
                "XL = {3}"+
                Environment.NewLine +
                "XXL = {4}"+
                Environment.NewLine +
                "XXXL = {5}"+
                Environment.NewLine +
                "4XL = {6}"+
                Environment.NewLine +
                "Total shirts {7}", turquoiseSmall, turquoiseMed, turquoiseLarge, turquoiseXl, turquoiseXxl, turquoiseXxxl, turquoiseXxxxl, turquoiseTotal);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Color = Forest Green" +
                Environment.NewLine +
                "Small = {0}" +
                Environment.NewLine +
                "Medium = {1}" +
                Environment.NewLine +
                "Large = {2}" +
                Environment.NewLine +
                "XL = {3}" +
                Environment.NewLine +
                "XXL = {4}" +
                Environment.NewLine +
                "XXXL = {5}" +
                Environment.NewLine +
                "4XL = {6}" +
                Environment.NewLine +
                "Total shirts {7}", forestSmall, forestMed, forestLarge, forestXl, forestXxl, forestXxxl, forestXxxxl, forestTotal);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Color = Sangria" +
                Environment.NewLine +
                "Small = {0}"+
                Environment.NewLine +
                "Medium = {1}"+
                Environment.NewLine +
                "Large = {2}"+
                Environment.NewLine +
                "XL = {3}"+
                Environment.NewLine +
                "XXL = {4}"+
                Environment.NewLine +
                "XXXL = {5}"+
                Environment.NewLine +
                "4XL = {6}"+
                Environment.NewLine +
                "Total shirts {7}", sangriaSmall, sangriaMed, sangriaLarge, sangriaXl, sangriaXxl, sangriaXxxl, sangriaXxxxl, sangriaTotal);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Color = Candy Pink" +
                Environment.NewLine +
                "Small = {0}"+
                Environment.NewLine +
                "Medium = {1}"+
                Environment.NewLine +
                "Large = {2}"+
                Environment.NewLine +
                "XL = {3}"+
                Environment.NewLine +
                "XXL = {4}"+
                Environment.NewLine +
                "XXXL = {5}"+
                Environment.NewLine +
                "4XL = {6}"+
                Environment.NewLine +
                "Total shirts {7}", candySmall, candyMed, candyLarge, candyXl, candyXxl, candyXxxl, candyXxxxl, candyTotal);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Color = Purple" +
                Environment.NewLine +
                "Small = {0}"+
                Environment.NewLine +
                "Medium = {1}"+
                Environment.NewLine +
                "Large = {2}"+
                Environment.NewLine +
                "XL = {3}"+
                Environment.NewLine +
                "XXL = {4}"+
                Environment.NewLine +
                "XXXL = {5}"+
                Environment.NewLine +
                "4XL = {6}"+
                Environment.NewLine +
                "Total shirts {7}", purpleSmall, purpleMed, purpleLarge, purpleXl, purpleXxl, purpleXxxl, purpleXxxxl, purpleTotal);

            Console.WriteLine("");
            Console.WriteLine("");
            
            Console.WriteLine("Color = Navy" +
                Environment.NewLine +
                "Small = {0}"+
                Environment.NewLine +
                "Medium = {1}"+
                Environment.NewLine +
                "Large = {2}"+
                Environment.NewLine +
                "XL = {3}"+
                Environment.NewLine +
                "XXL = {4}"+
                Environment.NewLine +
                "XXXL = {5}"+
                Environment.NewLine +
                "4XL = {6}"+
                Environment.NewLine +
                "Total shirts {7}", navySmall, navyMed, navyLarge, navyXl, navyXxl, navyXxxl, navyXxxxl, navyTotal);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Color = Yellow" +   
                Environment.NewLine +
                "Small = {0}"+
                Environment.NewLine +
                "Medium = {1}"+
                Environment.NewLine +
                "Large = {2}"+
                Environment.NewLine +
                "XL = {3}"+
                Environment.NewLine +
                "XXL = {4}"+
                Environment.NewLine +
                "XXXL = {5}"+
                Environment.NewLine +
                "4XL = {6}"+
                Environment.NewLine +
                "Total shirts {7}", yellowSmall, yellowMed, yellowLarge, yellowXl, yellowXxl, yellowXxxl, yellowXxxxl, yellowTotal);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Color = Lime Green" +    
                Environment.NewLine +
                "Small = {0}"+
                Environment.NewLine +
                "Medium = {1}"+
                Environment.NewLine +
                "Large = {2}"+
                Environment.NewLine +
                "XL = {3}"+
                Environment.NewLine +
                "XXL = {4}"+
                Environment.NewLine +
                "XXXL = {5}"+
                Environment.NewLine +
                "4XL = {6}"+
                Environment.NewLine +
                "Total shirts {7}", limeSmall, limeMed, limeLarge, limeXl, limeXxl, limeXxxl, limeXxxxl, limeTotal);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Color = Lavender" +    
                Environment.NewLine +
                "Small = {0}"+
                Environment.NewLine +
                "Medium = {1}"+
                Environment.NewLine +
                "Large = {2}"+
                Environment.NewLine +
                "XL = {3}"+
                Environment.NewLine +
                "XXL = {4}"+
                Environment.NewLine +
                "XXXL = {5}"+
                Environment.NewLine +
                "4XL = {6}"+
                Environment.NewLine +
                "Total shirts {7}", lavenderSmall, lavenderMed, lavenderLarge, lavenderXl, lavenderXxl, lavenderXxxl, lavenderXxxxl, lavenderTotal);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Color = Orange" +                
                Environment.NewLine +
                "Small = {0}"+
                Environment.NewLine +
                "Medium = {1}"+
                Environment.NewLine +
                "Large = {2}"+
                Environment.NewLine +
                "XL = {3}"+
                Environment.NewLine +
                "XXL = {4}"+
                Environment.NewLine +
                "XXXL = {5}"+
                Environment.NewLine +
                "4XL = {6}"+
                Environment.NewLine +
                "Total shirts {7}", orangeSmall, orangeMed, orangeLarge, orangeXl, orangeXxl, orangeXxxl, orangeXxxxl, orangeTotal);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Color = Royal Blue" +  
                Environment.NewLine +
                "Small = {0}"+
                Environment.NewLine +
                "Medium = {1}"+
                Environment.NewLine +
                "Large = {2}"+
                Environment.NewLine +
                "XL = {3}"+
                Environment.NewLine +
                "XXL = {4}"+
                Environment.NewLine +
                "XXXL = {5}"+
                Environment.NewLine +
                "4XL = {6}"+
                Environment.NewLine +
                "Total shirts {7}", royalSmall, royalMed, royalLarge, royalXl, royalXxl, royalXxxl, royalXxxxl, royalTotal);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Color = Sand" +     
                Environment.NewLine +
                "Small = {0}"+
                Environment.NewLine +
                "Medium = {1}"+
                Environment.NewLine +
                "Large = {2}"+
                Environment.NewLine +
                "XL = {3}"+
                Environment.NewLine +
                "XXL = {4}"+
                Environment.NewLine +
                "XXXL = {5}"+
                Environment.NewLine +
                "4XL = {6}"+
                Environment.NewLine +
                "Total shirts {7}", sandSmall, sandMed, sandLarge, sandXl, sandXxl, sandXxxl, sandXxxxl, sandTotal);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Color = Kelly Green" +         
                Environment.NewLine +
                "Small = {0}"+
                Environment.NewLine +
                "Medium = {1}"+
                Environment.NewLine +
                "Large = {2}"+
                Environment.NewLine +
                "XL = {3}"+
                Environment.NewLine +
                "XXL = {4}"+
                Environment.NewLine +
                "XXXL = {5}"+
                Environment.NewLine +
                "4XL = {6}"+
                Environment.NewLine +
                "Total shirts {7}", kellySmall, kellyMed, kellyLarge, kellyXl, kellyXxl, kellyXxxl, kellyXxxxl, kellyTotal);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Total of all shirts = {0}", (blackTotal + turquoiseTotal + forestTotal + sangriaTotal + candyTotal + purpleTotal + navyTotal + 
                yellowTotal + limeTotal + lavenderTotal + orangeTotal + royalTotal + sandTotal + kellyTotal));

            Console.WriteLine("The number of size SMALL units that will be ordered is = {0}", smallFinalQuantity);
            Console.WriteLine("The cost of size SMALL units that will be ordered is = {0:C2}", smallSum);
            Console.WriteLine("The number of size MEDIUM units that will be ordered is = {0}", mediumFinalQuantity);
            Console.WriteLine("the cost of size MEDIUM units that will be ordered is = {0:C2}", mediumSum);
            Console.WriteLine("The number of size LARGE units that will be ordered is = {0}", largeFinalQuantity);
            Console.WriteLine("the cost of size LARGE units that will be ordered is = {0:C2}", largeSum);
            Console.WriteLine("the number of size XL units that will be ordered is = {0}", xlFinalQuantity);
            Console.WriteLine("The cost of size XL units that will be ordered is = {0:C2}", xlSum);
            Console.WriteLine("The number of size XXL units that will be ordered is = {0}", xxlFinalQuantity);
            Console.WriteLine("The cost of size XXL units that will be ordered is = {0:C2}", xxlSum);
            Console.WriteLine("The number of size XXXL units that will be ordered is = {0}", xxxlFinalQuantity);
            Console.WriteLine("The cost of size XXXL units tthat will be ordered is = {0:C2}", xxxlSum);
            Console.WriteLine("The number of size XXXXL units that will be ordered is = {0}", xxxxlFinalQuantity);
            Console.WriteLine("The cost of size XXXXL units that will be ordered is = {0:C2}", xxxxlSum);
            Console.WriteLine("...");
            Console.WriteLine("The combined  pre-tax total of all units is = {0:C2}", preTax);
            Console.WriteLine("...");
            Console.WriteLine("Tax on this order is = {0:C2}", taxRaw);
            Console.WriteLine("Handling for this order (which is 4% of the order after tax) is = {0:C2}", shipping);
            Console.WriteLine("...");
            Console.WriteLine("The final total for this order is = {0:C2}", finalTotal);
            Console.WriteLine("...");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            //GC.Collect();



            


        }
    }
}
