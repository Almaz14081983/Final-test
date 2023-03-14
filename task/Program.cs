//Задача: 
//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями,
//лучше обойтись исключительно массивами.


Console.Clear();

string[] existingArray = new string[9] {"14", ".", "03", ".", "23", "при", "-", "вет", "пока"};
string[] newArray = new string[existingArray.Length];

int count = 0;
for (int i = 0; i < existingArray.Length; i++)
{
if(existingArray[i].Length <= 3)
    {
    newArray[count] = existingArray[i];
    Console.Write($"{newArray[i]} ");
    count++;
    }
}

