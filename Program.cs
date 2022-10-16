

string[] FillandPrintArray()
{
     int r = new Random().Next(5, 8);
     // Console.WriteLine(r);
     string[] array1 = new string[r];
     for (int i = 0; i < r; i++)
     {
          int randomLenght = new Random().Next(8);
          for (int j = 0; j <= randomLenght; j++)
          {
               array1[i] += "o";
          }
     }
     Console.WriteLine(String.Join(", ", array1));
     return array1;
}
string[] array2 = FillandPrintArray();

string[] newArray(string[] array3)
{
     int arLength = 0;
     for (int k = 0; k < array3.Length; k++)
     {
          if (array3[k].Length < 4) arLength++;
     }
     string[] shortArray = new string[arLength];

     int numofShortAr = 0;
     for (int n = 0; n < array3.Length; n++)
     {
          if (array3[n].Length < 4)
          {
               shortArray[numofShortAr] = array3[n];
               numofShortAr++;
          }

     }
     Console.WriteLine(arLength);
     return shortArray;
}
string[] shortArr = newArray(array2);
Console.Write("[\"");
Console.Write(String.Join("\" \"", shortArr));
Console.Write("\"]");