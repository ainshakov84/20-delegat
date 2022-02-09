using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_delegat
{
    internal class Program
    {
   
        
            delegate double MyDelegate(int r);
            static void Main(string[] args)
            {
            int r = 3;

            MyDelegate myDelegate = D;
                            
                myDelegate(r);
                Console.ReadKey();
            myDelegate = S;
            myDelegate(r);
            Console.ReadKey();
            myDelegate = V;
            myDelegate(r);
            Console.ReadKey();
        }

            static double D(int r)
            {
                double D = 2*Math.PI*r;
                Console.WriteLine(D);
                return D;
            }
            static double S(int r)
            {
                double S = Math.PI*Math.Pow(r,2);
                Console.WriteLine(S);
                return S;
            }
        static double V (int r)
            {
                double V = 3/4 * Math.PI*Math.Pow(r,3);
                Console.WriteLine(V);
                return V;
            }
        }
    }
