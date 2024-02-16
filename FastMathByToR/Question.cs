using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FastMathByToR
{
    public class QuestionItem {
        public QuestionItem() { Ans = 0.0;QuestionString = ""; }
        public QuestionItem(double _ans,string _strQ) {
        Ans = _ans;QuestionString = _strQ;
        }
    public double Ans { get; set; }
    public string QuestionString { get; set; }
    }
    public static class Question
    {
        public static QuestionItem GetQuestion()
        {
            QuestionItem question = new QuestionItem(); 
            int i = ext.RandomNumber(-100, 5000);
            if (i >= 0 && i <= 500){question =  GetProblems01();}
            else if (i >= 501 && i <= 1000){ question = GetProblems02();}
            else if (i >= 1001 && i <= 1500){question = GetProblems03();}
            else if (i >= 1501 && i <= 2000){question = GetProblems04();}
            else if (i >= 2001 && i <= 2500){ question = GetProblems05();}
            else if (i >= 2501 && i <= 3000){ question = GetProblems06();}
            else if (i >= 3501 && i <= 3500){question = GetProblems07();}
            else if (i >= 3501 && i <= 4000){ question = GetProblems08();}
            else if (i >= 4001 && i <= 4500){question = GetProblems09();}
            else if (i >= 4501 && i <= 5000){question = GetProblems10();}
            /* else if (i >= 5501 && i <= 6000) {question = GetProblems12();}
            else if (i >= 6001 && i <= 6500){ question = GetProblems10();}
            else if (i >= 6501 && i <= 7000){ question = GetProblems10();}
            else if (i >= 7001 && i <= 7500){ question = GetProblems10();}
            else if (i >= 7501 && i <= 8000){ question = GetProblems10();}
            else if (i >= 8001 && i <= 8500){ question = GetProblems10();}
            else if (i >= 8501 && i <= 9000){ question = GetProblems10();}
            else if (i >= 9001 && i <= 9500){ question = GetProblems10();}
            else if (i >= 9501 && i <= 10000){ question = GetProblems10();}
            else if (i >= 10001 && i <= 10500){ question = GetProblems10();}
            else if (i >= 10501 && i <= 11000){ question = GetProblems10();}
            else if (i >= 11001 && i <= 11500){question = GetProblems10();}
            else if (i >= 11501 && i <= 12000){question = GetProblems10();}
            else if (i >= 12001 && i <= 12500){question = GetProblems10();}
            else if (i >= 12501 && i <= 13000){question = GetProblems10();}
            else if (i >= 13001 && i <= 13500){question = GetProblems10();}
            else if (i >= 13501 && i <= 14000){question = GetProblems10();}
            else if (i >= 14001 && i <= 14500){question = GetProblems10();}
            else if (i >= 14501 && i <= 15000){question = GetProblems10();}
            else if (i >= 15001 && i <= 15500){question = GetProblems10();}
            else if (i >= 15501 && i <= 16000){question = GetProblems10();}
            else if (i >= 16001 && i <= 16500){question = GetProblems10();}
            else if (i >= 16501 && i <= 17000){question = GetProblems10();}
            else if (i >= 17001 && i <= 17500){question = GetProblems10();}
            else if (i >= 17501 && i <= 18000){question = GetProblems10();}
            else if (i >= 18001 && i <= 18500){question = GetProblems10();}
            else if (i >= 18501 && i <= 19000){question = GetProblems10();}
            else if (i >= 19001 && i <= 19500){question = GetProblems10();}
            else if (i >= 19501 && i <= 20000){question = GetProblems10();}
            else if (i >= 20001 && i <= 20500){question = GetProblems10();}
            else if (i >= 20501 && i <= 21000){question = GetProblems10();}
            else if (i >= 21001 && i <= 21500){question = GetProblems10();}
            else if (i >= 21501 && i <= 22000){question = GetProblems10();}
            else if (i >= 22001 && i <= 22500){question = GetProblems10();}
            else if (i >= 22501 && i <= 23000){question = GetProblems10();}
            else if (i >= 23001 && i <= 23500){question = GetProblems10();}
            else if (i >= 23501 && i <= 24000){question = GetProblems10();}
            else if (i >= 24001 && i <= 24500){question = GetProblems10();}
            else if (i >= 24501 && i <= 25000){question = GetProblems10();}
            else if (i >= 25001 && i <= 25500){question = GetProblems10();}
            else if (i >= 25501 && i <= 26000){question = GetProblems10();}
            else if (i >= 26001 && i <= 26500){question = GetProblems10();}
            else if (i >= 26501 && i <= 27000){question = GetProblems10();}
            else if (i >= 27001 && i <= 27500){question = GetProblems10();}
            else if (i >= 27501 && i <= 28000){question = GetProblems10();}
            else if (i >= 28001 && i <= 28500){question = GetProblems10();}
            else if (i >= 28501 && i <= 29000){question = GetProblems10();}
            else if (i >= 29001 && i <= 29500){question = GetProblems10();}
            else if (i >= 29501 && i <= 30000){question = GetProblems10();}
            else if (i >= 30001 && i <= 30500){question = GetProblems10();}
            else if (i >= 30501 && i <= 31000){question = GetProblems10();}
            else if (i >= 31001 && i <= 31500){question = GetProblems10();}
            else if (i >= 31501 && i <= 32000){question = GetProblems10();}
            else if (i >= 32001 && i <= 32500){question = GetProblems10();}
            else if (i >= 32501 && i <= 33000){question = GetProblems10();}
            else if (i >= 33001 && i <= 33500){question = GetProblems10();}
            else if (i >= 33501 && i <= 34000){}
            else if (i >= 34001 && i <= 34500){}
            else if (i >= 34501 && i <= 35000){}
            else if (i >= 35001 && i <= 35500){}
            else if (i >= 35501 && i <= 36000){}
            else if (i >= 36001 && i <= 36500){}
            else if (i >= 36501 && i <= 37000){}
            else if (i >= 37001 && i <= 37500){}
            else if (i >= 37501 && i <= 38000){}
            else if (i >= 38001 && i <= 38500){}
            else if (i >= 38501 && i <= 39000){}
            else if (i >= 39001 && i <= 39500){}
            else if (i >= 39501 && i <= 40000){}
            else if (i >= 40001 && i <= 40500){}
            else if (i >= 40501 && i <= 41000){}
            else if (i >= 41001 && i <= 41500){}
            else if (i >= 41501 && i <= 42000){}
            else if (i >= 42001 && i <= 42500){}
            else if (i >= 42501 && i <= 43000){}
            else if (i >= 43001 && i <= 43500){}
            else if (i >= 43501 && i <= 44000){}
            else if (i >= 44001 && i <= 44500){}
            else if (i >= 44501 && i <= 45000){}
            else if (i >= 45001 && i <= 45500){}
            else if (i >= 45501 && i <= 46000){}
            else if (i >= 46001 && i <= 46500){}
            else if (i >= 46501 && i <= 47000){}
            else if (i >= 47001 && i <= 47500){}
            else if (i >= 47501 && i <= 48000){}
            else if (i >= 48001 && i <= 48500){}
            else if (i >= 48501 && i <= 49000){}
            else if (i >= 49001 && i <= 49500){}
            else if (i >= 49501 && i <= 50000){}
            else if (i >= 50001 && i <= 50500){}
            else if (i >= 50501 && i <= 51000){}
            else if (i >= 51001 && i <= 51500){}
            else if (i >= 51501 && i <= 52000){}
            else if (i >= 52001 && i <= 52500){}
            else if (i >= 52501 && i <= 53000){}
            else if (i >= 53001 && i <= 53500){}
            else if (i >= 53501 && i <= 54000){}
            else if (i >= 54001 && i <= 54500){}
            else if (i >= 54501 && i <= 55000){}
            else if (i >= 55001 && i <= 55500){}
            else if (i >= 55501 && i <= 56000){}
            else if (i >= 56001 && i <= 56500){}
            else if (i >= 56501 && i <= 57000){}
            else if (i >= 57001 && i <= 57500){}
            else if (i >= 57501 && i <= 58000){}
            else if (i >= 58001 && i <= 58500){}
            else if (i >= 58501 && i <= 59000){}
            else if (i >= 59001 && i <= 59500){}
            else if (i >= 59501 && i <= 60000){}
            else if (i >= 60001 && i <= 60500){}
            else if (i >= 60501 && i <= 61000){}
            else if (i >= 61001 && i <= 61500){}
            else if (i >= 61501 && i <= 62000){}
            else if (i >= 62001 && i <= 62500){}
            else if (i >= 62501 && i <= 63000){}
            else if (i >= 63001 && i <= 63500){}
            else if (i >= 63501 && i <= 64000){}
            else if (i >= 64001 && i <= 64500){}
            else if (i >= 64501 && i <= 65000){}
            else if (i >= 65001 && i <= 65500){}
            else if (i >= 65501 && i <= 66000){}
            else if (i >= 66001 && i <= 66500){}
            else if (i >= 66501 && i <= 67000){}
            else if (i >= 67001 && i <= 67500){}
            else if (i >= 67501 && i <= 68000){}
            else if (i >= 68001 && i <= 68500){}
            else if (i >= 68501 && i <= 69000){}
            else if (i >= 69001 && i <= 69500){}
            else if (i >= 69501 && i <= 70000){}
            else if (i >= 70001 && i <= 70500){}
            else if (i >= 70501 && i <= 71000){}
            else if (i >= 71001 && i <= 71500){}
            else if (i >= 71501 && i <= 72000){}
            else if (i >= 72001 && i <= 72500){}
            else if (i >= 72501 && i <= 73000){}
            else if (i >= 73001 && i <= 73500){}
            else if (i >= 73501 && i <= 74000){}
            else if (i >= 74001 && i <= 74500){}
            else if (i >= 74501 && i <= 75000){}
            else if (i >= 75001 && i <= 75500){}
            else if (i >= 75501 && i <= 76000){}
            else if (i >= 76001 && i <= 76500){}
            else if (i >= 76501 && i <= 77000){}
            else if (i >= 77001 && i <= 77500){}
            else if (i >= 77501 && i <= 78000){}
            else if (i >= 78001 && i <= 78500){}
            else if (i >= 78501 && i <= 79000){}
            else if (i >= 79001 && i <= 79500){}
            else if (i >= 79501 && i <= 80000){}
            else if (i >= 80001 && i <= 80500){}
            else if (i >= 80501 && i <= 81000){}
            else if (i >= 81001 && i <= 81500){}
            else if (i >= 81501 && i <= 82000){}
            else if (i >= 82001 && i <= 82500){}
            else if (i >= 82501 && i <= 83000){}
            else if (i >= 83001 && i <= 83500){}
            else if (i >= 83501 && i <= 84000){}
            else if (i >= 84001 && i <= 84500){}
            else if (i >= 84501 && i <= 85000){}
            else if (i >= 85001 && i <= 85500){}
            else if (i >= 85501 && i <= 86000){}
            else if (i >= 86001 && i <= 86500){}
            else if (i >= 86501 && i <= 87000){}
            else if (i >= 87001 && i <= 87500){}
            else if (i >= 87501 && i <= 88000){}
            else if (i >= 88001 && i <= 88500){}
            else if (i >= 88501 && i <= 89000){}
            else if (i >= 89001 && i <= 89500){}
            else if (i >= 89501 && i <= 90000){}
            else if (i >= 90001 && i <= 90500){}
            else if (i >= 90501 && i <= 91000){}
            else if (i >= 91001 && i <= 91500){}
            else if (i >= 91501 && i <= 92000){}
            else if (i >= 92001 && i <= 92500){}
            else if (i >= 92501 && i <= 93000){}
            else if (i >= 93001 && i <= 93500){}
            else if (i >= 93501 && i <= 94000){}
            else if (i >= 94001 && i <= 94500){}
            else if (i >= 94501 && i <= 95000){}
            else if (i >= 95001 && i <= 95500){}
            else if (i >= 95501 && i <= 96000){}
            else if (i >= 96001 && i <= 96500){}
            else if (i >= 96501 && i <= 97000){}
            else if (i >= 97001 && i <= 97500){}
            else if (i >= 97501 && i <= 98000){}
            else if (i >= 98001 && i <= 98500){}
            else if (i >= 98501 && i <= 99000){}
            else if (i >= 99001 && i <= 99500){}
            else if (i >= 99501 && i <= 100000){}
            else if (i >= 100001 && i <= 100500){}
             */

            else { question = new QuestionItem(); }

            return question;
        }

        // + - บวก ลบ เลข
        private static QuestionItem GetProblems01()
        {
            QuestionItem question = new QuestionItem();
            // + - บวก ลบ เลข
            string op = ext.RandomBool ? "+" : "-";
            int a = ext.RandomNumber(-20, 20);
            int b = ext.RandomNumber(-20, 20);
            double c = (op == "+") ? a + b : a - b;
            question = new QuestionItem(c, $"{a} {op} {b}= ?" );
            return question;
        }
        //x / คูณหาร
        private static QuestionItem GetProblems02()
        {
            // x / คูณหาร
            int n = Convert.ToInt32(Math.Pow(10, ext.RandomNumber(0, 4)));
            int a = ext.RandomNumber(2, 10) * n;
            int b = ext.RandomNumber(2, 10) * n;

            string op = ext.RandomBool ? "x" : "/";
            int c = a * b;
            QuestionItem question = new QuestionItem();
            question = new QuestionItem(double.Parse((op == "x") ? c.ToString() : b.ToString())
                                   , (op == "x") ? $"{a} {op} {b}= ?" : $"{c} {op} {a}= ?");
        
        return question;
        }
        // a/b = c/d เทียบ ไตรยางค์
        private static QuestionItem GetProblems03()
        {
            // a/b = c/d เทียบ ไตรยางค์
            int n = Convert.ToInt32(Math.Pow(10, ext.RandomNumber(0, 2)));
            int a = ext.RandomNumber(2, 10) * n;
            int b = ext.RandomNumber(2, 10) * n;
            int _c = ext.RandomNumber(2, 10);
            int c = a * _c, d = b * _c;
            int ii = ext.RandomNumber(1, 2000);
            QuestionItem question = new QuestionItem();
            if (ii >= 0 && ii <= 500)
            {
                question = new QuestionItem(a,$"a/{b} = {c}/{d}  \na = ?");
            }
            else if (ii >= 501 && ii <= 1000)
            {
                question = new QuestionItem(b, $"{a}/b = {c}/{d}  \nb = ?");
            }
            else if (ii >= 1001 && ii <= 1500)
            {
                question = new QuestionItem(c, $"{a}/{b} = c/{d}  \nc = ?");
            }
            else if (ii >= 1501 && ii <= 2000)
            {
                question = new QuestionItem(d, $"{a}/{b} = {c}/d  \nd = ?");
            }
            return question;
        }
        private static QuestionItem GetProblems04()
        {
            // % คิดเปอร์เซนต์ 
            int n = Convert.ToInt32(Math.Pow(10, ext.RandomNumber(0, 2)));
            int a = ext.listNum[ext.RandomNumber(0, ext.listNum.Count - 1)] * n;
            int p = ext.listNumPer[ext.RandomNumber(0, ext.listNumPer.Count - 1)];
            int ii = ext.RandomNumber(1, 4000);
            QuestionItem question = new QuestionItem();
            if (ii > 0 && ii <= 500)
            {
                question = new QuestionItem(p , $"จำนวน {a * p / 100} ใน {a} = ? % ");
            }
            else if (ii > 500 && ii <= 1000)
            {

                question = new QuestionItem(a, $"{a * p / 100} เป็น {p}% ของจำนวนใด ? ");
            }
            else if (ii > 1000 && ii <= 1500)
            {
                question = new QuestionItem(Convert.ToDouble(p) / 100.0 * Convert.ToDouble(a)
                , $"{p}% ของ {a} = ?  ");
            }
            else if (ii > 1500 && ii <= 2000)
            {
                //ซื้อ ? มา ราคา x ลดราคา p % ราคาจริงเท่าไหร่
                question = new QuestionItem(a,
                 $"ซื้อ{ext.Categories[ext.RandomNumber(0, ext.Categories.Count - 1)]}" +
                    $"มา ราคา {a * (100 - p) / 100} บาท ร้านติดป้ายลดราคา {p}% " +
                    $"\nราคาจริงเท่าไหร่  ");
            }
            else if (ii > 2000 && ii <= 2500)
            {
                //ซื้อมา x บาท ขาย x*p บาท  ได้กำไร เท่าไหร่
                double sellingPrice = (a * (100 + p) / 100);
                question = new QuestionItem(sellingPrice - a,
                 $"ซื้อ{ext.Categories[ext.RandomNumber(0, ext.Categories.Count - 1)]}มา ราคา {a} บาท " +
                    $"\nขายไปราคา {sellingPrice}  บาท ได้กำไร เท่าไหร่  ");
            }
            else if (ii > 2500 && ii <= 3000)
            {
                //ซื้อมา x บาท ขาย x*b บาท  ได้กำไรกี่เท่า
                double b = Math.Round(ext.RandomNumber(1, 5) + ext.random.NextDouble(), 2);
                question = new QuestionItem((a * b - a) / a,
                 $"ซื้อ{ext.Categories[ext.RandomNumber(0, ext.Categories.Count - 1)]}มา ราคา {a} บาท " +
                   $"\nขายไปราคา {a * b}  บาท ได้กำไรกี่เท่า  ");
            }
            else if (ii > 3000 && ii <= 3500)
            {
                //ซื้อมา x บาท ขาย x*p บาท  ขาดทุนเท่าไหร่
                question = new QuestionItem(a - (a * (100 - p) / 100),
                 $"ซื้อ{ext.Categories[ext.RandomNumber(0, ext.Categories.Count - 1)]}มา ราคา {a * (100 - p) / 100} บาท " +
               $"\nขายไปราคา {a}  บาท ขาดทุน เท่าไหร่  ");

            }
            else if (ii > 3500 && ii <= 4000)
            {
                //ซื้อมา x บาท ต้องการขายให้ได้กำไร p % ต้องขายในราคาเท่าไหร่
                double sellingPrice = (a * (100 - p) / 100);
                question = new QuestionItem(a - sellingPrice,
                 $"ซื้อ{ext.Categories[ext.RandomNumber(0, ext.Categories.Count - 1)]}มา ราคา {a} บาท " +
                    $"\nขายไปราคา {sellingPrice}  บาท ขาดทุน เท่าไหร่  ");

            }
            return question;
        }
        private static QuestionItem GetProblems05()
        {
            // + - บวก ลบ 3 จำนวน
            int n = Convert.ToInt32(Math.Pow(10, ext.RandomNumber(0, 2)));
            int a = ext.RandomNumber(1, 10) * n;
            int b = ext.RandomNumber(1, 10) * n;
            int c = ext.RandomNumber(1, 10) * n;

            QuestionItem question = new QuestionItem();
            int ii = ext.RandomNumber(1, 2000);
            if (ii >= 0 && ii <= 500)
            {
                question = new QuestionItem(a + b + c, $"{a} + {b} + {c} = ?");

            }
            else if (ii >= 501 && ii <= 1000)
            {
                question = new QuestionItem(a + b - c, $"{a} + {b} - {c} = ?");
            }
            else if (ii >= 1001 && ii <= 1500)
            {
                question = new QuestionItem(a - b + c, $"{a} - {b} + {c} = ?");
            }
            else if (ii >= 1501 && ii <= 2000)
            {
                question = new QuestionItem(a - b - c, $"{a} - {b} - {c} = ?");
            }
            return question;
        }
        private static QuestionItem GetProblems06()
        {
            //บวก ลบ คูณ หาร ละคน
            int n = Convert.ToInt32(Math.Pow(10, ext.RandomNumber(0, 2)));
            int a = ext.RandomNumber(1, 10) * n;
            int b = ext.RandomNumber(1, 10) * n;
            int c = ext.RandomNumber(1, 10);

            QuestionItem question = new QuestionItem();
            int ii = ext.RandomNumber(1, 2000);
            if (ii >= 0 && ii <= 500)
            {
                // สุ่มค่า c ที่สามารถหาร (a + b) หรือ (a - b) ลงตัว
                do
                {
                    a = ext.RandomNumber(1, 10) * n;
                    b = ext.RandomNumber(1, 10) * n;
                    c = ext.RandomNumber(1, 10);

                } while ((a + b) % c != 0);
                //(a + b) / c
                question = new QuestionItem((a + b) / c, $"({a} + {b})/{c} = ?");

            }
            else if (ii >= 501 && ii <= 1000)
            {
                //(a + b) * c
                question = new QuestionItem((a + b) * c, $"({a} + {b})x{c} = ?");
            }
            else if (ii >= 1001 && ii <= 1500)
            {
                // สุ่มค่า c ที่สามารถหาร (a + b) หรือ (a - b) ลงตัว
                do
                {
                    a = ext.RandomNumber(1, 10) * n;
                    b = ext.RandomNumber(1, 10) * n;
                    c = ext.RandomNumber(1, 10);

                } while ((a - b) % c != 0);
                //(a - b) / c
                question = new QuestionItem((a - b) / c, $"({a} - {b})/{c} = ?");
            }
            else if (ii >= 1501 && ii <= 2000)
            {
                //(a - b) * c
                question = new QuestionItem((a - b) * c, $"({a} - {b})*{c} = ?");
            }
            return question;
        }
        private static QuestionItem GetProblems07()
        {
            //คูณ หาร ละคน จากตัวเลข 3 ตัว
            int n = Convert.ToInt32(Math.Pow(10, ext.RandomNumber(0, 2)));
            int a = ext.RandomNumber(1, 10) * n;
            int b = ext.RandomNumber(1, 10) * n;
            int c = ext.RandomNumber(1, 10) * n;

            QuestionItem question = new QuestionItem();
            int ii = ext.RandomNumber(1, 1500);
            if (ii >= 0 && ii <= 500)
            {
                question = new QuestionItem(a * b * c, $"{a}x{b}x{c} = ?");

            }
            else if (ii >= 501 && ii <= 1000)
            {
                question = new QuestionItem(a * b / c, $"{a}x{b}/{c} = ?");
            }
            else if (ii >= 1001 && ii <= 1500)
            {
                question = new QuestionItem(a / b * c, $"{a}/{b}*{c} = ?");
            }
            return question;
        }
        private static QuestionItem GetProblems08()
        {
            //บวก ลบ คูณ หาร ละคน
            int a = ext.RandomNumber(1, 10);
            int b = ext.RandomNumber(1, 10);
            int c = ext.RandomNumber(1, 10);
            QuestionItem question = new QuestionItem();
            int ii = ext.RandomNumber(1, 2000);
            if (ii >= 0 && ii <= 500)
            {
                //Ans =ab+c
                question = new QuestionItem(b, $"{a}*b + {c} = {(a * b) + c}  \nb = ?");

            }
            else if (ii >= 501 && ii <= 1000)
            {
                //Ans =ab-c
                question = new QuestionItem(b, $"{a}*b - {c} = {(a * b) - c}  \nb = ?");
            }
            else if (ii >= 1001 && ii <= 1500)
            {
                //Ans =ab-c
                question = new QuestionItem(c,$"{a}*{b} + c = {(a * b) + c}  \nc = ?");
            }
            else if (ii >= 1501 && ii <= 2000)
            {
                //Ans =ab-c
                question = new QuestionItem(c, $"{a}*{b} - c = {(a * b) - c}  \nc = ?");
            }

            return question;
        }
        private static QuestionItem GetProblems09()
        {
            int a = ext.RandomNumber(1, 10);
            int b = ext.RandomNumber(1, 10);
            int c = ext.RandomNumber(1, 10);
            int d = ext.RandomNumber(1, 10);
            int ii = ext.RandomNumber(1, 2000);

            QuestionItem question = new QuestionItem();
            if (ii >= 0 && ii <= 500)
            {
                question = new QuestionItem(a + b, $"{a} ปีที่แล้ว แดงมีอายุ {b} ปี \nปัจจุบัน แดงมีอายุเท่าไหร่ ");

            }
            else if (ii >= 501 && ii <= 1000)
            {
                question = new QuestionItem(c + b, $"อีก {a} ปี แดงจะมีอายุ {a + c + b} ปี \nปัจจุบัน แดงมีอายุเท่าไหร่ ");
            }
            else if (ii >= 1001 && ii <= 1500)
            {
                // Ans = 0.00;
                //s = "";
                question = new QuestionItem(b + d, $"{a} ปีที่แล้ว แดงมีอายุมากกว่าดำ {b} ปี อีก {c}ปี ดำจะมีอายุ {d + c}  " +
                    $"\nปัจจุบันแดงมีอายุเท่าไหร่");
            }
            else if (ii >= 1501 && ii <= 2000)
            {
                //Ans = 0.00;
                // s = "";
                // a ปีที่แล้ว แดงมีอายุเป็น b เท่า ของดำ อีก c  ปี ข้างหน้า แดงจะมีอายุเป็น d เท่า ของดำ ปัจจุบัน แดงมีอายุเท่าไหร่
                question = new QuestionItem(a + (b * c) * d, $"{a} ปีที่แล้ว แดงมีอายุเป็น {b} เท่า ของดำ " +
                    $"\nอีก {c}  ปี ข้างหน้า แดงจะมีอายุเป็น {d} เท่า ของดำ ปัจจุบัน แดงมีอายุเท่าไหร่");
            }

            return question;
        }
        private static QuestionItem GetProblems10()
        {
            int a = ext.RandomNumber(1, 10);
            int b = ext.RandomNumber(1, 10);
            int c = ext.RandomNumber(1, 10);
            int d = ext.RandomNumber(1, 10);
            int ii = ext.RandomNumber(1, 2000);

            QuestionItem question = new QuestionItem();
            if (ii >= 0 && ii <= 500)
            {
                question = new QuestionItem(a, $"a + {b} = {a + b}\na=?");
            }
            else if (ii >= 501 && ii <= 1000)
            {
                question = new QuestionItem(b, $"{a} + b = {a + b}\nb=?");
            }
            else if (ii >= 1001 && ii <= 1500)
            {
                //ให้ a, b, c, d, e และ f เป็นจำนวนจริงใดๆ ที่ a,b ไม่เป็นศูนย์บร้อมกัน และ c,d ไม่เป็นศูนย์บร้อมกัน เรียกระบบที่ประกอบด้วยสมการ
                //ax + by = c
                //cx + dy = f

                // สุ่มค่า a, b, c, d, e, f ให้เป็นจำนวนเต็ม
                a = ext.RandomNumber(-10, 10); // สุ่มค่า a ในช่วง -10 ถึง 10
                b = ext.RandomNumber(-10, 10); // สุ่มค่า b ในช่วง -10 ถึง 10
                c = ext.RandomNumber(-10, 10); // สุ่มค่า c ในช่วง -10 ถึง 10
                d = ext.RandomNumber(-10, 10); // สุ่มค่า d ในช่วง -10 ถึง 10
                int x = ext.RandomNumber(-10, 10); // สุ่มค่า e ในช่วง -10 ถึง 10
                int y = ext.RandomNumber(-10, 10); // สุ่มค่า f ในช่วง -10 ถึง 10

                // ตรวจสอบว่าหาก a*d - b*c เป็นศูนย์ ให้ทำการสุ่มใหม่
                while (a * d - b * c == 0)
                {
                    a = ext.RandomNumber(-10, 10);
                    b = ext.RandomNumber(-10, 10);
                    c = ext.RandomNumber(-10, 10);
                    d = ext.RandomNumber(-10, 10);
                    x = ext.RandomNumber(-10, 10);
                    y = ext.RandomNumber(-10, 10);
                }

                // แสดงผลลัพธ์หลังการสุ่มใหม่ (หากจำเป็น)
                if (a * d - b * c != 0)
                {
                    string s = ext.RandomBool ? "x" : "y";
                    question = new QuestionItem((s == "x") ? x : y,$"{a}x+{b}y = {a * x + b * y}\n{c}x+{d}y = {c * x + d * y}\n{s} = ?");
                }
                else
                {
                    question = new QuestionItem();
                }

            }
            else if (ii >= 1501 && ii <= 2000)
            {
                question = new QuestionItem();

            }

            return question;
        }
        /* private static QuestionItem GetProblems11() {QuestionItem question = new QuestionItem(); return question; }
         private static QuestionItem GetProblems12() {QuestionItem question = new QuestionItem(); return question; }
         private static QuestionItem GetProblems13() {QuestionItem question = new QuestionItem(); return question; }
         private static QuestionItem GetProblems14() {QuestionItem question = new QuestionItem(); return question; }
         private static QuestionItem GetProblems15() { QuestionItem question = new QuestionItem(); return question;}
         private static QuestionItem GetProblems16() {QuestionItem question = new QuestionItem(); return question; }
         private static QuestionItem GetProblems17() {QuestionItem question = new QuestionItem(); return question; }
         private static QuestionItem GetProblems18() {QuestionItem question = new QuestionItem(); return question; }
         private static QuestionItem GetProblems19() { QuestionItem question = new QuestionItem(); return question;}
         private static QuestionItem GetProblems20() {QuestionItem question = new QuestionItem(); return question; }*/
    }
}
