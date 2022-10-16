

string[] FillArray(){
int r = new  Random().Next(5, 10);
Console.WriteLine(r);
string[] array = new string[r];
for (int i= 0; i<r; i++){
     int randomLenght = new  Random().Next(8);
     for (int j = 0 ; j<=randomLenght; j++ ){
          array[i] += "w";
     }
}
Console.WriteLine(String.Join(", ", array));
return array;}
FillArray();