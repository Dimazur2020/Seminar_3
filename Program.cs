 
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
/*
void Palindrom(int number)
{
    if((number / 10000 == number % 10) && ((number / 1000) % 10 == (number % 100) / 10))           
            Console.WriteLine("Число является палиндромом");
    
    else if((number / 10000 != number % 10) || (number / 1000) % 10 != (number % 100) / 10)
            Console.WriteLine("Число не является палиндромом"); 
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Palindrom(number);
*/
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double result = 0;
double Coordinaty(double x1, double x2, double y1, double y2, double z1, double z2)
{
result =  Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
return result = Math.Round(result, 2);
}
Console.Write("Введите координату X первой точки A: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X второй точки B: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки A: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки B: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z первой точки A: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z второй точки B: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Coordinaty(x1, x2, y1, y2, z1, z2);
Console.WriteLine($"Расстояние между двумя точками = {result}");
*/
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube){
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);
*/
//Последнее задание я не смог решить, а времени всё меньше, я списал с гит хаба, что значит выражение - int[]?