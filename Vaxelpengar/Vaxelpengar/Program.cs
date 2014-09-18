using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = true;
            uint belopp = 0;
            //uint change = 0;
           // uint fiveHundred= 500, oneHundred= 100, fiftyKr= 50, twentyKr= 20, tenKr= 10, fiveKr = 5, oneKr = 1;
            uint total = 0;
            //string totalText;
            string beloppText;
            double roundingOffAmount=0d;
            double subtotal = 0d;
       
            uint vaxelKr = 0;
            do
            {
                try
                {
                    //int result = 0;
                    valid = false;
                    Console.Title = "Växelpengar - nivå A";
                    Console.Write("Ange totalsumma   : ");
                    subtotal = double.Parse(Console.ReadLine());
                    if (subtotal < 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nTotalsumman är för liten. Köpet kunde inte genomföras.");
                        Console.ResetColor();
                        return;
                    }
                    else
                    {
                        break;
                    }

                }

                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Erhållet belopp felaktig.");
                    Console.ResetColor();

                }
            } while (!valid);

            total = (uint)Math.Round(subtotal);
            roundingOffAmount = total - subtotal;
            do
            {
                try
                {
                    valid = false;
                    Console.Write("Ange erhållet belopp :  ");
                    beloppText = Console.ReadLine();
                    belopp = uint.Parse(beloppText);


                    if (total > belopp)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erhållet belopp är för litet. Köpet kunde int genomföras");
                        Console.ResetColor();
                        return;   
                    }

                    else
                    {
                        break;
                    }
                } //end of try

          catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Erhållet belopp felaktig.");
                    Console.ResetColor();

                }
    } while (!valid);

            vaxelKr = (belopp - total);

            Console.WriteLine();
            Console.WriteLine("KVITTO");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Totalt         : {0:0} \tkr", subtotal);
            Console.WriteLine("öresavrunding  : {0:f2} \tkr", roundingOffAmount);
            Console.WriteLine("Att betala     : {0:0} \tkr", subtotal - roundingOffAmount);
            Console.WriteLine("Kontant        : {0:0} \tkr ", belopp);
            Console.WriteLine("Tillbaka       : {0:0} \tkr", vaxelKr);
            Console.WriteLine("-------------------------------");

                if (vaxelKr >= 500)
                {
                    Console.WriteLine("500-belopp\t: {0}", (vaxelKr / 500));
                    //fiveHundred = vaxelKr / 500;
                    vaxelKr = vaxelKr % 500;
                }
                if (vaxelKr >= 100)
                {
                    Console.WriteLine("100-belopp\t: {0} ", (vaxelKr / 100));
                    //oneHundred = change / 100;
                    vaxelKr = vaxelKr % 100;
                }
                 if (vaxelKr >= 50)
                {
                    Console.WriteLine("50-belopp\t: {0}", (vaxelKr / 50));
                   // fiftyKr = change / 50;
                    vaxelKr = vaxelKr % 50;
                }
                if (vaxelKr >= 20)
                {
                    Console.WriteLine("20-belopp\t: {0}", (vaxelKr / 20));
                    //twentyKr = change / 20;
                    vaxelKr = vaxelKr % 20;
                }
                if (vaxelKr >= 10)
                {
                    Console.WriteLine("10-kronor\t: {0}", (vaxelKr / 10));
                   // tenKr = change / 10;
                    vaxelKr = vaxelKr % 10;
                }
                if (vaxelKr >= 5)
                {
                    Console.WriteLine("5-kronor\t: {0}", (vaxelKr / 5));
                   // fiveKr = change / 5;
                    vaxelKr = vaxelKr % 5;
                }
                if (vaxelKr >= 1)
                {
                    Console.WriteLine("1-kronor\t: {0} ", (vaxelKr / 1));
                    //oneKr = change / 1;
                    vaxelKr = vaxelKr % 1;
                }          
          
        }
    }
}
