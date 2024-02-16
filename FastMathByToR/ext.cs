using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastMathByToR
{
    public static class ext
    {
      public static  Random random = new Random();
      public static  List<int> listNum = new List<int>() { 10, 20, 40, 50, 80, 100 };

      public static List<int> listNumPer = new List<int>() { 1, 2, 4, 5, 10, 20, 30, 40, 50, 80 };
      public static List<string> Categories = new List<string> {
    // เสื้อผ้า
    "เสื้อยืด","เสื้อเชิ้ต","กางเกงยีนส์","กางเกงขาสั้น","กางเกงขายาว","ชุดชั้นใน","เสื้อนอก","กระโปรง","ชุดว่ายน้ำ","ชุดนอน","ผ้าพันคอ",
    // รองเท้า
    "ถุงเท้า","ถุงมือ","หมวก","เข็มขัด","รองเท้า","รองเท้าแตะ","รองเท้าส้นเตี้ย","รองเท้าผ้าใบ",
    // ซักประมาณ
    "เสื้อยืด","กางเกงยีนส์","ชุดชั้นใน","ถุงเท้า","ชุดว่ายน้ำ","ชุดนอน","ผ้าพันคอ","เสื้อผ้ากลางคืน","เสื้อกันหนาว","หมวก"
        };
        public static  bool RandomBool
        {
            get
            {
                bool b = false;
                b = (RandomNumber(1, 1000) < 500);
                return b;
            }

        }
     public static   int RandomNumber(int min, int max)
        {
            int a;
            do
            {
                a = random.Next(min, max + 1);
            } while (a == 0);
            return a;
        }
    }
}
