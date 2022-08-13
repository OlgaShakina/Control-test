// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа.

string[] stringArray = new string [10];

   Console.WriteLine("Введите любые 10 слов через Enter:");
for (int i = 0; i < stringArray.Length; i++)
   {
      stringArray[i]= Console.ReadLine();
   }

