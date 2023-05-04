// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 5
// 78 -> 8
// 9146548 -> 1
// 3 -> нет

Console.WriteLine ("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = 10;

if (a<10){
    Console.WriteLine("нет");
}
else if (a>=10 && a<=100){
    a%=b;
    Console.WriteLine (a);
}
else if (a>100 && a<1000){
    a=a/10;
    a%=b;
    Console.WriteLine (a);
}
else if (a>=1000 && a<10000){
    a = a/100;
    a%=b;
    Console.WriteLine (a);
}
else if (a>=10000 && a<100000){
    a=a/1000;
    a%=b;
    Console.WriteLine (a);
}
else if (a>=100000 && a<1000000){
    a=a/10000;
    a%=b;
    Console.WriteLine (a);
}
else if (a>=1000000 && a<10000000){
    a=a/100000;
    a%=b;
    Console.WriteLine (a);
}
else if (a>=10000000 && a<100000000){
    a=a/1000000;
    a%=b;
    Console.WriteLine (a);
}
else if (a>=100000000 && a<1000000000){
    a=a/10000000;
    a%=b;
    Console.WriteLine (a);
}
else if (a>=1000000000 && a<=2147483647){
    a=a/100000000;
    a%=b;
    Console.WriteLine (a);
}