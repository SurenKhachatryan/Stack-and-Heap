using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Heap
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Создаем Объект на Кучу(Стек)
            Mystruct inctanse1 = new Mystruct();
            Mystruct inctanse2 = new Mystruct();

            inctanse1.field = 8;
            inctanse2.field = 9;

            inctanse1.Method(8, 5);
            inctanse2.Method(25, 35);
        }
    }
    struct Mystruct
    {
        //Поле(field)
        public int field;
        Object obj;

        public void Method(int a, int b)
        {
            Console.WriteLine($"{a} \n {b} \n  {field}");
        }
    }
}
