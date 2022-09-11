/*
Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длинна которых меньше либо равна трём.. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами!
*/

// Задаем изначальный массив
string[] array = { "Job", "Work", "Root", "Rus", "Eng", "Engineer", "Code" };
int lengthNewArray = 0;

// Задаем размер нового массива
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        lengthNewArray++;
    }
}

// Перекладывание значений <=3 в новый массив 
string[] newArray = new string[lengthNewArray];
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[count] = array[i];
        count++;
    }
}

// Вывод нового массива на экран
Console.Write("Новый массив строк: ");
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}
