// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
int b=0;
int c = 1;
Console.WriteLine ("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (a<0){
    b = a*-1;
    while (c<b){
        Console.Write(c + 1 + ", ");
        c+=2;
    }
}
else{
    while (c<a){
        Console.Write(c + 1 + ", ");
        c += 2;
    }
}