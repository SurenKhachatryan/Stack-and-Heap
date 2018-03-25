# Stack-and-Heap

# СТЕК(Stack)

СТЕК это область памяти, с размером 1мб, где хранятся 
1) Адреса возврата из процедур ,
2) Поля Структур (исключениям ссылочных типов , стеке хранится только ссылка на объект на кучу ) 
3) Локальные переменные  (Это параметры  методов и объявленные переменные внутри метода )
4) Ссылки на объекты на кучу .

# КУЧА(Heap)

КУЧА это область памяти где хранятся  
1) Объекты классов и структур 
2) Экземпляры классов
Чем отличаются объект и экземпляр. Объект внутри себя садержает статические члены (это статические поля(Field) и методы)
и не статические методы классов и структур . Экземпляр садержает в себе только не статические  поля(Field) (Поля(Field)
это переменные,объявленные внутри класса) и не смотря на то, что поле(Field)  представляет собой  значимий тип , все 
равно его значение будет хранится в куче  . При первом создании  объекта  класса , на куче создаются экземпляры класса
и объекты класса , а при  создании объекта того же класса, во второй раз  в кучу создаются только экземпляры класса.
Это сделано для того, чтобы  не занимать много места в памяти , а экземпляры связываються с объектом с помощью  хеш кодами.
