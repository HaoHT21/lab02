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

            //Console.ReadLine();



            //c


            userData data = new userData("2024", "Hao", 100);
            data.GetInfor();
            //Console.ReadLine();

            //bai2a
            UserInfo userInfp = new UserInfo
            {
                id = "2024",
                name = "faker",
                isplaying = false,
                bag = new Bag
                {
                    skins = 0,
                    cups = 20
                }
            };

            Console.WriteLine("id: " + userInfp.id);
            Console.WriteLine("name: " + userInfp.name);
            Console.WriteLine("isplaying: " + userInfp.isplaying);
            Console.WriteLine("bag.skins: " + userInfp.bag.skins);
            Console.WriteLine("bag.cups: " + userInfp.bag.cups);

            //bai2b
            int y = 10;

            Action<int> AnonymousMethod = delegate (int s)
            {
                int sum = s + y;
                int sub = s - y;
                Console.WriteLine("sum: " + sum);
                Console.WriteLine("sub: " + sub);
            };

            AnonymousMethod(5);

            //bai3
            bai3.Bai3();
        }



        
        static void getDetail(dynamic value)
        {
            Console.WriteLine(value);
        }
        class Bag
        {
            public int skins;
            public int cups;
        }

        class UserInfo
        {
            public string id;
            public string name;
            public bool isplaying;
            public Bag bag;
        }
    






}
}

