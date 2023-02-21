
Console.WriteLine("программа которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

void cube(int n){
for (n=n ; n > 0; n--){
   int a=n;
    a=a*a*a;    
Console.WriteLine(a);
}

}
int n = int.Parse(Console.ReadLine());
cube (n);

Console.WriteLine ("программа которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
void polindrom(int p){
    
    int a,b,d,e;
    a = p /10000;
    b=p/1000 %10;
    d =p % 1000 % 100 / 10;
    e=p % 10000 % 1000 % 100 % 10;
    if (a==e & d==b){Console.WriteLine("число является полиндромом");}
    else{Console.WriteLine("число НЕ полиндромом");}
}
int pol;
Console.WriteLine("в ведите 5-и значное число");
pol = int. Parse(Console. ReadLine());
if (pol>9999 & pol<=99999){polindrom(pol);}
else{Console.WriteLine("вы в вели не верное число");}

