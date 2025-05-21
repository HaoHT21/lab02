using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a
            var x = 10;
            Console.WriteLine(x);

            //b
            getDetail(10);
            getDetail("Games");
            getDetail(true);
            getDetail(9.5);

            Console.ReadLine();



            //c
            
        
            userData data = new userData("2024", "Hao", 100);
            data.GetInfor();


            
        


        }
        static void getDetail(dynamic value)
        {
            Console.WriteLine(value);
        }
        





    }
}
