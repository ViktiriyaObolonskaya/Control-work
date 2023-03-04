// Написать программу, которая из имеющегося массива строк, формирует массив из строк, длина которых меньше либо равна 3 символа


string[] array = new string[4] {"hello", "2","world", ":)"};
PrintArray(array);
string[] ResultArray = Array(array);
Console.WriteLine($"->[{String.Join(" ",ResultArray)}]");

//------------Методы----------

string[]Array(string[] array)
{
   string[] resultArray = new string[array.Length];
   int resultSize = 0; 
       for(int i = 0; i < array.Length; i++){
        if(array[i].Length <= 3)
          resultArray[resultSize] = array[i];
          resultSize++;  
       }
        return resultArray;    
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
