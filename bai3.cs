using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    internal class bai3
    {
        public static void Bai3()
        {
            
        List<float> ldata = new List<float>() { 10, 9, 8, 7.5f, 2, 1.4f };

            
            userData student = new userData("2026", "Nguyen Tran Hao");

            
            student.Scores.AddRange(ldata);

            
            student.DisplayInfo();

            Console.ReadLine();
        }
        public class userData
        {
            public string ID;
            public string userName;
            public List<float> Scores;

            // Constructor
            public userData(string id, string name)
            {
                ID = id;
                userName = name;
                Scores = new List<float>();
            }

            // Phương thức hiển thị thông tin
            public void DisplayInfo()
            {
                Console.WriteLine("ID: " + ID);
                Console.WriteLine("Name: " + userName);
                Console.WriteLine("Scores: " + string.Join(", ", Scores));
            }
        }

    }
}
