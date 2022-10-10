

// while Loops

// გვ 212

/*int counter = 0;

while (counter <= 9)
{
    Console.WriteLine("Number is: " + counter);
    counter++;
}*/


// გვ 213

/*Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
int num = 1;
int sum = 1;
Console.Write("The sum 1");

while (num < n)
{
    num++;
    sum += num;
    Console.Write("+" + num);

}

Console.Write("=" + sum);*/


// გვ 214

/*Console.Write("Enter a positive number: ");
int num = int.Parse(Console.ReadLine());
int divider = 2;
int maxDivider = (int)Math.Sqrt(num);
bool prime = true;

while (prime && (divider <= maxDivider)) 
{
    if (num % divider == 0) {
        prime = false;
    }
    divider++;
}
Console.WriteLine("Prime?" + prime);*/



// გვ 215

/*Console.Write("Enter the value for n ");
int n = int.Parse(Console.ReadLine());

decimal factorial = 1;

while (true) {
    if (n <= 1) {
        break;
    }
    factorial *= n;
    n--; 
}
Console.WriteLine("n! = " + factorial);*/



// Do-Wjile Loops

/*Console.Write("Enter value for n");
int n = int.Parse(Console.ReadLine());
decimal factorial = 1;

do
{
    factorial *= n;
    n--;
}
while (n > 0);

Console.WriteLine("n! = " + factorial);*/



// გვ 220

/*
Console.Write("Enter n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Enter m: ");
int m = int.Parse(Console.ReadLine());

int product = 1;

do
{
    product *= n;
    n++;
} while (n <= m);

Console.WriteLine("product [n...m] = " + product);  */


// For Loops

/*
for (int i = 0; i < 10; i++) {
    Console.Write(i + " ");
}  */


/*
for (int i = 1, sum = 1; i < 128; i = i * 2, sum += i) {
    Console.WriteLine("i={0}, sum={1}", i, sum);
}  */

// გვ 224
/*
Console.Write("n=");
int n = int.Parse(Console.ReadLine());

Console.Write("m=");
int m = int.Parse(Console.ReadLine());

int result = 1;

for (int i = 1; i <=m; i++) {
    result *= n;

}
Console.WriteLine("n^m= " + result); */


// გვ

/*
for (int small = 1, large = 10; small < large; small++, large--) {
    Console.WriteLine(small + " " + large);
}  */


// გვ 225

/*
int n = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 1; i <=n; i += 2)
{
    if (i % 7 == 0)
    {
        continue;
    }
    sum += i;
}
Console.WriteLine("sum = " + sum);  */


// foreach loop  გვ 226

/*
int[] numbers = { 2, 3, 5, 6, 7, 8, 8 };
foreach (int i in numbers)
{
    Console.Write(" " + i);
}

Console.WriteLine();

string[] towns = { "London", "Paris", "Tbilisi", "Liverpoll" };
foreach (string m in towns)
{
    Console.Write(" " + m);
}  */



// nested loops
// გვ 228

/*
int n = int.Parse(Console.ReadLine());

for (int row =1; row<=n; row++)
{
    for (int col =1; col<=row; col++)
    {
        Console.Write(col + " ");
    }
    Console.WriteLine();
} */


// გვ 228
/*
Console.Write("Enter n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Enter m: ");
int m = int.Parse(Console.ReadLine());

for (int num = n; num <= m; num++)
{
    bool prime = true;
    int divider = 2;
    int maxDivider = (int)Math.Sqrt(num);

    while (divider <= maxDivider)
    {
        if (num % divider == 0)
        {
            prime = false;
            break;
        }
        divider++;

    }

    if (prime)
    {
        Console.WriteLine(" " + num);
    }
} */


// exercies

/*
Console.Write("Enter n: ");
int n = int.Parse(Console.ReadLine());

int num = n;

for (int i = 1; i <= num; i++) {
    Console.Write(" " + i);
}  */

/*
Console.Write("Enter n: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (i % 3 == 0 || i % 7 == 0) {
        continue;
}
Console.Write(" " + i);
}  */


