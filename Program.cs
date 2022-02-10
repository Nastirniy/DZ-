Console.Write("Введите двузначное число: ");
string? vvod_chisla = Console.ReadLine();

char num1 = vvod_chisla[0];
char num2 = vvod_chisla[1];

if (num1 == num2)
    Console.WriteLine($"{num1} = {num2}");
else if (num1 > num2)
    Console.WriteLine($"{num1} > {num2}");
else
    Console.WriteLine($"{num1} < {num2}");