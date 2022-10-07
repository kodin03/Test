/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами. */


void Check(string str) {
    int n = str.Length;
    string[] massive = str.Split(new char[] { ',' });
    for(int i = 0; i < massive.Length; i++) 
    {
        if (i == 0) Console.Write("[");
        if (i < massive.Length - 1) 
           if (massive[i].Length <= 3) Console.Write("\"" + massive[i] + "\", ");
        if (i == massive.Length - 1) Console.Write("\"" + massive[i] + "\"]");
    }
}

Console.WriteLine("Введите слова или символы через запятую без пробела: ");
string str = Console.ReadLine();
Check(str);

