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
            //Создаем Объект на Кучу(Heap)
            MyClass inctanse1 = new MyClass();
            MyClass inctanse2 = new MyClass();

            inctanse1.field = 8;
            inctanse2.field = 9;

            inctanse1.Method(8, 5);
            inctanse2.Method(25, 35);
        }
    }
}
