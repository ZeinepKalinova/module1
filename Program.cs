using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Exmpl03()
        {
            Console.WriteLine("Введите свое имя: ");
            string firstname = Console.ReadLine();

            Console.WriteLine("Введите свою фамилию: ");
            string lastname = Console.ReadLine();

            Console.WriteLine("Введите свое очество: ");
            string middlename = Console.ReadLine();

            Console.WriteLine("Приветствую тебя - " + lastname + " " + firstname + " " + middlename);
        }

        static void Exmpl04()
        {
            int x = 0, y = 0, z = 0;
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();







            if (Int32.TryParse(a, out x) == false || Int32.TryParse(b, out y) == false || Int32.TryParse(c, out z) == false)
            {
                Console.WriteLine("Введите корекные число");
            }
            else
            {
                //x = Convert.ToInt32(a);
                //y = Convert.ToInt32(b);
                //z = Convert.ToInt32(c);


                Console.WriteLine("Ответ: " + (x + y + z));
            }


        }

        static void Main(string[] args)
        {
            Exmpl03();
            Exmpl04();

            Console.ReadKey();
        }
    }
}


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Exmpl03()
        {
            Console.Write("Введите год рождения: ");
            string strYear = Console.ReadLine();
            int year = 0;

            //1
            year = Convert.ToInt32(strYear);

            bool result = Int32.TryParse(strYear, out year);

            if(result == false)
            {

            }
        }

        static void Exmpl04(int x)
        {
            x = x + 1;
        }
        static void Exmpl05(User user)
        {
            user.Age = user.Age + 1;
        }
        static void Main(string[] args)
        {
            int a = 55;
            Exmpl04(a);
            Console.WriteLine("a = " + a);

            User user = new User();
            user.Age = 60;
            Exmpl05(user);
            Console.WriteLine(user.Age);

            Console.ReadKey();
        }
    }
    public class User
    {
        public int Age { get; set; }
    }

}
*/