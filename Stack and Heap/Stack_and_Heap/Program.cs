using System;

namespace Stack_and_Heap
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Создаем Объект на Кучу(Стек)
            MyStruct inctanse1 = new MyStruct();
            MyStruct inctanse2 = new MyStruct();

            inctanse1.field = 8;
            inctanse2.field = 9;

            inctanse1.Method(8, 5);
            inctanse2.Method(25, 35);
        }
    }
    struct MyStruct
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
