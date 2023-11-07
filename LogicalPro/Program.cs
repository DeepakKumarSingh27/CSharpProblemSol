using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Programm Number ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Friends friends = new Friends();
                    friends.Name();
                    break;
                    case 2:
                        TwoNumberSumOrDiff tw = new TwoNumberSumOrDiff();
                    tw.sqrt1();
                    break;
                    case 3:
                        VisitePlace vs = new VisitePlace();
                    vs.display();
                    break;
                    case 4:
                        PrintTenTimes ps = new PrintTenTimes();
                    ps.display();
                    break;
                    //case 5:
                    //    CommandLineArgs cm = new CommandLineArgs();
                    //cm.CommandLineArgs();
                    //break;
                    case 6:
                      RandomNumber rm = new RandomNumber();
                    rm.Random();
                    break;
                    case 7:
                       CircleDiamater cd = new CircleDiamater();
                    cd.diamater();
                    break;
                    case 8:
                        NextDay nx = new NextDay();
                    nx.Next();
                    break;
                    case 9:
                    ClalculateExTime ex = new ClalculateExTime();
                    ex.calTime();
                    break;
                    case 10:
                    CalculateMultipleNum ml = new CalculateMultipleNum();
                    ml.cal();
                    break;
                    case 11:
                    Factorial fc = new Factorial();
                    fc.fact();
                    break;
                    case 12:
                    OneToTenWithOutLoop lp = new OneToTenWithOutLoop();
                    lp.print1(1);
                    break;
                    case 13:
                      QuadraticEqn qn = new QuadraticEqn();
                        qn.root();
                        break;
                    case 14:

                    ChecksPresents ck = new ChecksPresents();
                    ck.present();
                    break;
                    default: Console.WriteLine("Case Don't matched: ");
                    break;
                   
            }
            Console.ReadLine();
        }
    }
}
