/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
/*
void PalindromicNumber(int num)
{
    if(num >= 10000 && num <100000)
    {
        int fifth = num % 10;
        int first = num / 10000;   

            if(fifth == first)
            {
                num = num / 10;
                int second = (num / 100) % 10;
                int fourth = num % 10;
                if(second  == fourth)
                    Console.WriteLine("палиндром");
            }
            else 
            Console.WriteLine("Не является палиндромом");
            
    }
    else
    Console.WriteLine("Некорректное число!");
}
 
Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());

PalindromicNumber(num);*/

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
/*
double FindWay (double x1 , double y1, double z1, double x2, double y2, double z2)
{
return Math.Sqrt (Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)+ Math.Pow(z2-z1,2)) ;                   //квадратный корень(квадрат)
}
Console.WriteLine("Введите x1:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y1:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите z1:");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите x2:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y2:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите z2:");
double z2 = Convert.ToDouble(Console.ReadLine());

double findWay = FindWay (x1,y1,z1,x2,y2,z2);
Console.WriteLine($"Way = {findWay}");*/

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
/*
void QardN (int num)
{
    int step = 1;
    while (step <= num)
    {
     
    Console.Write (step*step*step + " , ");
    step ++;
    }
}
Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

QardN(num);*/