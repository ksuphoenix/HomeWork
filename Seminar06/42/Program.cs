// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.



int number = int.Parse(Console.ReadLine());
Console.WriteLine(GetBinary(number));

string GetBinary(int number)
{
int ost = number/2;
string NUM = Convert.ToString(number%2);
while (ost>0)
{
    NUM = (ost%2) + NUM;
    ost = ost / 2;
}
return(NUM);
}