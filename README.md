# Описание алгоритма программы
Для начала необходимо попросить пользователя ввести данные с помощью команды:
```csharp
Console.WriteLine("Введите слова или символы через запятую без пробела: ");
```

Далее запишем в переменную **str** введенные данные:
```csharp
string str = Console.ReadLine();
```

Вызовем метод **Check(str)**;

Метод **void Check(string str)**:

Объявим **int** переменную **n** и присвоим ей длину введенных данных:
```csharp
int n = str.Length; 
```

Объявим массив **massive** и передадим в него обрезанные по знаку "," с помощью команды **Split** и разделенные данные:
```csharp
string[] massive = str.Split(new char[] { ',' });
```

Создадим цикл от 0 до конца массива (**massive.Length**):
```csharp
for(int i = 0; i < massive.Length; i++)
```

В теле цикла три условия:

1) Если i равно 0, то выводим первую скобку:
```csharp
if (i == 0) Console.Write("[");
```

2) Если i меньше длины массива - 1, то проверяем дополнительно каждый элемент массива на длину. Если длина меньше либо равна 3, то выводим этот элемент массивва с запятой:
```csharp
if (i < massive.Length - 1) 
    if (massive[i].Length <= 3) 
    Console.Write("\"" + massive[i] + "\", ");
``` 
3) Если длина равна последнему элементу массива, то выводим этот элемент массивва с закрытой скобкой:
```csharp
if (i == massive.Length - 1) Console.Write("\"" + massive[i] + "\"]");
```

