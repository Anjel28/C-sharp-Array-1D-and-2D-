using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
/*class Program
{

  public static void Main(String[] args)
  {
    /* Console.WriteLine("Hello C#");
     bool a = true; 
   Console.WriteLine(a);*/



/*Console.WriteLine("VALUE TYPE:");
  Console.WriteLine("__________________________");
  Console.WriteLine("Integers:");
  byte a = 12;
  Console.WriteLine("byte\tA  = {0}\t{1}\t{2}\t{3}", a, typeof(byte), byte.MaxValue, byte.MinValue);
  sbyte b = 12;
  Console.WriteLine("sbyte\tB  = {0}\t{1}\t{2}\t{3}", b, typeof(sbyte), sbyte.MaxValue, sbyte.MinValue);
  short c = 12;
  Console.WriteLine("short\tC  = {0}\t{1}\t{2}\t{3}", c, typeof(short), short.MaxValue, short.MinValue);
  ushort d = 12;
  Console.WriteLine("ushort\tD  = {0}\t{1}\t{2}\t{3}", d, typeof(ushort), ushort.MaxValue, ushort.MinValue);
  int e = 12;
  Console.WriteLine("int\tE = {0}\t{1}\t{2}\t{3}", e, typeof(int), int.MaxValue, int.MinValue);
  int f = 12;
  Console.WriteLine("uint\tF = {0}\t{1}\t{2}\t{3}", f, typeof(uint), uint.MaxValue, uint.MinValue);
  int g = 12;
  Console.WriteLine("long\tG = {0}\t{1}\t{2}\t{3}", g, typeof(long), long.MaxValue, long.MinValue);
  int h = 12;
  Console.WriteLine("ulong\tH = {0}\t{1}\t{2}\t{3}", h, typeof(ulong), ulong.MaxValue, ulong.MinValue);



  Console.WriteLine("\nFloating Point:");
  float i = 123.34f;
    Console.WriteLine ("float\tI = {0}\t{1}\t{2}\t{3}", i, typeof(float), float.MaxValue, float.MinValue);
  double j = 123.34;
  Console.WriteLine("double\tJ = {0}\t{1}\t{2}\t{3}", j, typeof(double), double.MaxValue, double.MinValue);
  decimal k= 123.34m;
 Console.WriteLine ("decimal\tK = {0}\t{1}\t{2}\t{3}", k, typeof(decimal), decimal.MaxValue, decimal.MinValue);


  Console.WriteLine("\nText:");
  char l = 'f';
  Console.WriteLine("char\tL = {0}\t{1}\t{2}\t{3}", l, typeof(char));


  Console.WriteLine("\nBoolean:");
bool m = true;
  Console.WriteLine("bool\tM = {0}\t{1}", m, typeof(bool));*/


//Arithmetic Operator
//{addition}
/* int sum = 5 + 3;
 Console.WriteLine($"5+3 = {sum}");

 //{subtraction}
 int difference = 10 - 4;
 Console.WriteLine($"10-4 = {difference}");

 //{multiplication}
 int product = 6 * 7;
 Console.WriteLine($"6*7 = {product}");

 //{division}
 int quotient = 15 / 3;
 double preciseQuotient = 15.0 / 4.0;
 Console.WriteLine($"15.0/4.0 = {preciseQuotient}");
 Console.WriteLine($"15.0/3.0 = {quotient}");

 //{modulus}
 int remainder = 17 % 5;
 Console.WriteLine($"17%5 ={remainder}");

 //{increment}
 int count = 5;
 count++;
 Console.WriteLine($"After increment:{count}");
 int preIncrement = ++count;
 Console.WriteLine($"After pre-Increment: count={count}, preIncrement{preIncrement}");

 //{decrement}
 int value = 8;
 value++;
 Console.WriteLine($"After decrement:{value}");
 int preDecrement = ++value;
 Console.WriteLine($"After pre-Decrement: value={value}, preDecrement{preDecrement}");

 //{combined all operators}
 int x = 10;
 x += 5;
 x -= 3;
 x *= 2;
 x /= 4;
 x %= 5;
 Console.WriteLine($"Final x value : {x}");

 //{Assignment operator}

 //simple Assigment
 int a = 10;
 string name = "john";
 Console.WriteLine($" a = {a},name = {name}");

 //addtion assignment
 int b = 5;
 b += 3;
 Console.WriteLine($"b = {b}");

 //subtraction assignmenmt
 int c = 10;
 c -= 4;
 Console.WriteLine($"c = {c}");

 //multiply assignment
 int d = 3;
 d *= 5;
 Console.WriteLine($"d = {d}");

 //division operator
 int e = 20;
 e /= 4;
 Console.WriteLine($"e = {e}");

 //modulus operator
 int f = 17;
 f %= 5;
 Console.WriteLine($"f = {f}");

 //bitwise AND and asignment
 int g = 6;
 g &= 3;
 Console.WriteLine($"g = {g}");

 //OR assignment
 int h = 6;
 h |= 3;
 Console.WriteLine($"h = {h}");

 //NOT assignment
 int i = 6;
 i = ~3;
 Console.WriteLine($"i = {i}");

 //left shift assignment
 int j = 4;
 j <<= 1;
 Console.WriteLine($"j = {j}");

 //Right shift assignment
 int k = 8;
 k >>= 1;
 Console.WriteLine($"k = {k}");

 //{Comparision operator}

 int l = 10;
 int m = 5;

 Console.WriteLine($"l = {l}, m = {m}");
 Console.WriteLine();

 //equal to
 int n = 11;
 int o = 4;
 Console.WriteLine($"n == o: {n == o}");
 Console.WriteLine($"11 == 11: {11 == 11}");

 //not equal to
 Console.WriteLine($"n != o: {n != o}");
 Console.WriteLine($"11 != 11: {11 != 11}");

 //greater than
 Console.WriteLine($"n > o: {n > o}");
 Console.WriteLine($"11 > 11: {11 > 11}");

 //Less than
 Console.WriteLine($"n < o: {n < o}");
 Console.WriteLine($"11 < 11: {11 < 11}");

 //greater than or equal to
 Console.WriteLine($"n >= o: {n >= o}");
 Console.WriteLine($"11 >= 11: {11 >= 11}");
 Console.WriteLine($"4 >= 11: {4 >= 11}");

 //less than or equal to
 Console.WriteLine($"n <= o: {n <= o}");
 Console.WriteLine($"11 <= 11: {11 <= 11}");
 Console.WriteLine($"4 <= 11: {4 <= 11}");

 //string comparision
 string s1 = "hello";
 string s2 = "world";
 Console.WriteLine($"\nString comparison:");
 Console.WriteLine($"\"hello\" == \"hello\": {"hello" == "hello"}");
 Console.WriteLine($"s1 == s2: {s1 == s2}");

 //{logical operators}

 //logical AND
 bool p = true;
 bool q = false;
 Console.WriteLine(p && q);

 //logical OR
 Console.WriteLine(p || q);

 //logical NOT
 Console.WriteLine(!p);

 //BitWise Operators

 int r = 5;
 int s = 3;
 //bitwise AND
 int result = r & s;
 Console.WriteLine(result);

 //bitwise OR
 int t = 5;
 int u = 3;
 Console.WriteLine($"t | s: {t | u}");

 //bitwise XOR
 Console.WriteLine($"t ^ u: {t ^ u}");

 //bitwise NOT
 Console.WriteLine($"~t: {~t}");

 //leftshift
 Console.WriteLine($"t << 1: {t << 1}");

 //rightshift
 Console.WriteLine($"t >> 1 : {t >> 1}");

 //condtional operators
 int age = 20;
 string status = age >= 18 ? "Adult" : "Minor";
 Console.WriteLine(status);

 //null
 int? length = name?.Length;
 Console.WriteLine(length);

 //sizeof operator
 int size = sizeof(int);
 Console.WriteLine(size);

 //typeof operator
 Type type = typeof(string);
 Console.WriteLine(type);

 //name of operator
 string methodName = nameof(Console.WriteLine);
 Console.WriteLine(methodName);


 //Ternary Operator
 int number = 10;
 string isNumber10 = number == 10 ? "true" : "False";
 Console.WriteLine("Number == 10 is {0}, isNumber10");*/

//If STATEMENT (EXMPLE)
/*int number = 10;
if (number > 5)
{
  Console.WriteLine("The number is greater than 5");
}*/
//positive and even
/*Console.Write("Enter an integer:");

int number = 11;

if (number > 0)
{
  if (number % 2 == 0)
  {
    Console.WriteLine(" Even");
  }
  else
  {
    Console.WriteLine("Odd");
  }
  if (number < 0)
  {
    Console.WriteLine("Positive");
  }
  else
  {
    Console.WriteLine("Negative");
  }
}
else
{
  Console.WriteLine("Zero");
}
//Age
Console.WriteLine("Enter your age");
int age = 21;

if (age >= 18)
{
  Console.WriteLine("You are in adult");
}
else
{
  Console.WriteLine("You are not in adult ");
}
//grade print
int score = 85;
if (score >= 90)
{
  Console.WriteLine("Grade: A");
}
if (score >= 80)
{
  Console.WriteLine("Grade: b");
}
else
{
  Console.WriteLine("Fail");
}
//if else statement
//{1}
int tempreture = 30;
if (tempreture > 30)
{
  Console.WriteLine("It's hot outside!");
}
else
{
  Console.WriteLine("It's hot outside");
}
//2
int marks = 40;
if (marks >= 70)
{
  Console.WriteLine("You passed!");
}
else
{
  Console.WriteLine("You failed");
}
//if else if statement {1}
int num = 85;

if (num >= 90)
{
  Console.WriteLine("Grade A");
}
else if (num >= 80)
{
  Console.WriteLine("Grade B");
}
else if (num >= 70)
{
  Console.WriteLine("Grade C");
}
else if (num >= 60)
{
  Console.WriteLine("Grade D");
}
else
{
  Console.WriteLine("Fail");
}
//2 tempreture check
double temp = 23.5;
if (temp > 30.0)
{
  Console.WriteLine("It is hot outside");
}
else if (temp > 20.0)
{
  Console.WriteLine("It is warm outside");
}
else if (temp > 10.0)
{
  Console.WriteLine("It cool outside");
}
else
{
  Console.WriteLine("It =cold outside");
}
//3 example
string username = "admin";
string password = "secret123";

if (username == "admin" && password == "sercret123")
{
  Console.WriteLine("login successful! Welcome Admin.");
}
else if (username == "user" && password == "pass123")
{
  Console.WriteLine("login successfull! Welcome User");
}
else if (username == "guest" && password == "guest123")
{
  Console.WriteLine("login successful! Welcome Guest");
}
else
{
  Console.WriteLine("Invalid credentials. Access defined");
}*/
//SWITCH CASE STATEMENT EXAMPLE
/*Console.WriteLine("Enter the day number (1-7):");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thrusday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("saturday");
    break;
  case 7:
    Console.WriteLine("sunday");
    break;
  default:
    Console.WriteLine("Invalid day number: Please enter a number between 1 and 7");
    break;

}
Console.WriteLine("Enter the grade: ");
int student = Convert.ToInt32(Console.ReadLine());

switch (student)
{
  case 1:
    Console.WriteLine("Grade A");
    break;
  case 2:
    Console.WriteLine("Grade B");
    break;
  case 3:
    Console.WriteLine("Grade C");
    break;
  case 4:
    Console.WriteLine("Fail");
    break;
  default:
    Console.WriteLine(" Enter the Grade");
    break;

}

Console.WriteLine("Enter the divisible by 5 ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
  case 1:
    Console.WriteLine("45 is divisible by 5");
    break;
  case 2:
    Console.WriteLine("35 is divisible by 5");
    break;
  default:
    Console.WriteLine("divisiblity number 5");
    break;

}


  Console.WriteLine("Enter a grade (A, B, C, D, or F):");
char grade = Convert.ToChar(Console.ReadLine().ToUpper());
    string message;

    switch (grade)
    {
        case 'A':
            message = "Excellent!";
            break;
        case 'B':
            message = "Good job!";
            break;
        case 'C':
            message = "Satisfactory";
            break;
        case 'D':
            message = "Needs improvement";
            break;
        case 'F':
            message = "Failed";
            break;
        default:
            message = "Invalid grade";
            break;
    }

    Console.WriteLine(message);*/
//LOOPS { for loop } -{1}
/*for (int i = 1; i >= 5; i++)
{
  Console.WriteLine($"Current number: {i}");
}*/
//{2} natural number
/*Console.WriteLine("Enter the upper limit (N):");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Natural numbers from 1 to {0}:", n);

for (int i = 1; i <= n; i++)
{
  Console.WriteLine(i);
}*/
//Even number
/* Console.WriteLine("Enter the number upper limit:");
 int limit = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("even number from 1 to {0}:", limit);

 for (int i = 1; i <= limit; i++)
 {
   Console.WriteLine(i);
 }  */

//sum natural number
/*    Console.Write("Enter a positive number");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    for (int i = 1; i <= n; i++)
    {
      sum = i + 1;
      Console.WriteLine($"sum of first natural number is: {sum}");
    }*/
//ASCII charcter
/*Console.WriteLine("ASCII Characters (0-127):");
Console.WriteLine("\tChar");
for (int i = 0; i <= 127; i++)
{
 if (i < 32 || i == 127)
        {
            Console.WriteLine($"{i}\t{i:X2}\t(Control Character)");
        }
        else
        {
            Console.WriteLine($"{i}\t{i:X2}\t{(char)i}");
        }


}   */

//cube of integer

/*Console.WriteLine("Display cube of integer");
Console.WriteLine("_____________");

Console.Write("Enter a positive integer");
int number;

while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
{
  Console.Write("Please enter a valid positive integer:");

}
Console.WriteLine("\nNumber\tCube");
Console.WriteLine("_______\t______");

for (int i = 1; i <= number; i++)
{
  int cube = i * i * i;
  Console.WriteLine($"{i}\t{cube}");
}*/


//while loop{example}-basic
/*int b = 1;
while (b <= 10)
{
  Console.WriteLine("Fahad Hussian");
  b++;
}*/

//user input until valid
/*string input;
bool isValid = false;

while (!isValid)
{
  Console.Write("Enter yes or no");
  input = Console.ReadLine().ToLower();
  if (input == "yes" || input == "no") {
    isValid = true;
    Console.WriteLine($"You entered: {input}");
  }
  else
{
    Console.WriteLine("Invalid input. Try again.");
}

}*/

//summing numbers
/*int sum = 0;
int number = 1;

while (number <= 10)
{
  sum = sum + number;
  number++;
}
Console.WriteLine($"Sum of numbers from 1 to 10 is: {sum}");*/

//infinite loop with break
/*while (true)
{
  Console.Write("Enter a number (0 to exist)");
  int num = Convert.ToInt32(Console.ReadLine());

  if (num == 0)
  {
    Console.WriteLine("Existing the program");
    break;
  }
  Console.WriteLine($"You entered:  {num}");
}*/

//nested while loop
/* int i = 1;
 while (i <= 3)
 {
   int j = 1;
   while (j <= 3)
   {
     Console.WriteLine($"i = {i}, j = {j}");
     j++;
   }
   i++;
 }*/
//fibonacci sequence
/*int a = 0, b = 1;
int count = 0;

Console.WriteLine("First 10 fibonacci numbers:");
while (count < 10)
{
  Console.WriteLine(a);
  int temp = a;
  a = b;
  b = temp + b;
  count++;
}*/
//factoriasl calculation
/*int n = 5;
int factorial = 1;
int current = 1;

while (current <= n)
{
  factorial *= current;
  current++;
}
Console.WriteLine($"factorial of {n} is {factorial}");*/

//do-while-true condition
/* int c = 1;
 do
 {
   Console.WriteLine("Fahad Hussian");
   c++;
 } while (c <= 10);*/

//false-condition
/* int c = 12;
 do
 {
   Console.WriteLine("Fahad Hussian");
   c++;
 } while (c <= 10);*/

//user input validation
/* string userInput;
 do
 {
   Console.Write("Enter yes to continue:");
   userInput = Console.ReadLine().ToLower();
 } while (userInput != "yes");*/

//sum of numbers until zero
/* int number;
int sum = 0;

do 
{
 Console.Write("Enter a number (0 to stop): ");
 number = int.Parse(Console.ReadLine());
 sum += number;
} while (number != 0);

Console.WriteLine($"Total sum: {sum}");*/
//PATTERN PRINTING FOR LOOP
//{1} *****
//   *****
//    *****
//    *****

/* int rows = 5;
 int starsPerRow = 5;

 for (int i = 0; i < rows; i++)
 {
     Console.WriteLine(new string('*', starsPerRow));
 }*/

//{2}*
//   **
//   ***
//   ****
//   ***** 


/*string[] patternLines = {
    "*",
    "**",
    "***",
    "****",
    "*****"
};

foreach (string line in patternLines)
{
    Console.WriteLine(line.PadLeft(10)); // Adjust padding as needed
}*/
//{3}  right triangle
/*int rows = 5;
   for (int i = 1; i <= rows; i++)
   {
       for (int j = 1; j <= i; j++)
       {
           Console.Write("* ");
       }
       Console.WriteLine();
   }*/
//{4}inverted right triangle
/*int rows = 5;
for (int i = rows; i >= 1; i--)
{
  for (int j = 1; j <= i; j++)
  {
    Console.Write("* ");
  }
  Console.WriteLine();
}*/

//{5}pyramid pattern
/*int rows = 5, k = 0;
for (int i = 1; i <= rows; i++, k = 0)
{
  for (int space = 1; space <= rows - i; space++)
  {
    Console.Write("  ");
  }
  while (k != 2 * i - 1)
  {
    Console.Write("* ");
    k++;
  }
  Console.WriteLine();
}*/
//{6} dimond pattern


/*int rows = 5, k = 0;


for (int i = 1; i <= rows; i++, k = 0)
{
  for (int space = 1; space <= rows - i; space++)
  {
    Console.Write("  ");
  }
  while (k != 2 * i - 1)
  {
    Console.Write("* ");
    k++;
  }
  Console.WriteLine();
}


for (int i = rows - 1; i >= 1; i--, k = 0)
{
  for (int space = 1; space <= rows - i; space++)
  {
    Console.Write("  ");
  }
  while (k != 2 * i - 1)
  {
    Console.Write("* ");
    k++;
  }
  Console.WriteLine();
}*/

//{7} number pyramid
/*int rows = 5, num = 1;
    for (int i = 1; i <= rows; i++)
    {
        for (int space = 1; space <= rows - i; space++)
        {
            Console.Write(" ");
        }
        for (int j = 1; j <= i; j++)
        {
            Console.Write(num + " ");
            num++;
        }
        Console.WriteLine();
    }*/
//{8}floyd's triangle
/*int rows = 5, num = 1;
for (int i = 1; i <= rows; i++)
{
  for (int j = 1; j <= i; j++)
  {
    Console.Write(num + " ");
    num++;
  }
  Console.WriteLine();
}*/
//{9} pascal triangle
/*int rows = 5, coeff = 1;
    for (int i = 0; i < rows; i++)
    {
        for (int space = 1; space <= rows - i; space++)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            if (j == 0 || i == 0)
                coeff = 1;
            else
                coeff = coeff * (i - j + 1) / j;
            Console.Write(coeff + " ");
        }
        Console.WriteLine();
    }*/
//{9} square pattern

/*int size = 5;
       for (int i = 1; i <= size; i++)
       {
           for (int j = 1; j <= size; j++)
           {
               if (i == 1 || i == size || j == 1 || j == size)
                   Console.Write("* ");
               else
                   Console.Write("  ");
           }
           Console.WriteLine();
       }*/
//{10} hollow pyramid
/*int rows = 5;
for (int i = 1; i <= rows; i++)
{
  for (int space = 1; space <= rows - i; space++)
  {
    Console.Write(" ");

  }
  for (int j = 1; j <= 2 * i - 1; j++)
  {
    if (j == 1 || j == 2 * i - 1 || i == rows)
      Console.Write("*");
    else
      Console.Write(" ");
  }
  Console.WriteLine();
}*/
//{11} alphabet pattern right triangle
/*char ch = 'A';
   int rows = 5;
   for (int i = 1; i <= rows; i++)
   {
       for (int j = 1; j <= i; j++)
       {
           Console.Write(ch + " ");
           ch++;
       }
       Console.WriteLine();
   }*/
//{12} hollow diamond pattern
/*  int rows = 5;


  for (int i = 1; i <= rows; i++)
  {
      for (int j = rows; j > i; j--)
          Console.Write(" ");

      Console.Write("*");

      for (int k = 1; k < 2*(i-1); k++)
          Console.Write(" ");

      if (i == 1)
          Console.WriteLine();
      else
          Console.WriteLine("*");
  }


  for (int i = rows-1; i >= 1; i--)
  {
      for (int j = rows; j > i; j--)
          Console.Write(" ");

      Console.Write("*");

      for (int k = 1; k < 2*(i-1); k++)
          Console.Write(" ");

      if (i == 1)
          Console.WriteLine();
      else
          Console.WriteLine("*");
  }*/
//{13} binary number triangle
/*int rows = 5;
for (int i = 1; i <= rows; i++)
{
  int num = i % 2 == 0 ? 0 : 1;
  for (int j = 1; j <= i; j++)
  {
    Console.Write(num + " ");
    num = num == 0 ? 1 : 0;
  }
  Console.WriteLine();
}*/
//{14} plus pattern
/*int size = 5; 
    for (int i = 1; i <= size; i++)
    {
        for (int j = 1; j <= size; j++)
        {
            if (i == size/2 + 1 || j == size/2 + 1)
                Console.Write("* ");
            else
                Console.Write("  ");
        }
        Console.WriteLine();
    }*/
//{15} cross pattern
/*int size = 5;
for (int i = 1; i <= size; i++)
{
  for (int j = 1; j <= size; j++)
  {
    if (i == j || i + j == size + 1)
      Console.Write("* ");
    else
      Console.Write("  ");
  }
  Console.WriteLine();
}*/

//{16} hollow squarw with traiangle
/*int size = 5;
for (int i = 1; i <= size; i++)
{
  for (int j = 1; j <= size; j++)
  {
    if (i == 1 || i == size || j == 1 || j == size || i == j || i + j == size + 1)
      Console.Write("* ");
    else
      Console.Write("  ");
  }
  Console.WriteLine();
}*/
//{17} triangle of numbers (right aligned)
/*int rows = 5;
     for (int i = 1; i <= rows; i++)
     {
         for (int j = rows; j > i; j--)
             Console.Write("  ");

         for (int k = 1; k <= i; k++)
             Console.Write(k + " ");

         Console.WriteLine();
     }*/
//{18} arrow pattern

/*int rows = 5;


for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
        Console.Write("* ");
    Console.WriteLine();
}


for (int i = rows-1; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
        Console.Write("* ");
    Console.WriteLine();
}*/
//{19} alphabet pyramid
/*int rows = 5;
char ch = 'A';
for (int i = 1; i <= rows; i++)
{
  for (int space = 1; space <= rows - i; space++)
   Console.Write(" ");

        for (int j = 1; j <= i; j++)
            Console.Write(ch++ + " ");

  Console.WriteLine();
}*/
//{20} spiral number square
/*int size = 4;
int[,] spiral = new int[size, size];
int num = 1;
    int top = 0, bottom = size - 1, left = 0, right = size - 1;
while (num <= size * size)
{

  for (int i = left; i <= right; i++)
    spiral[top, i] = num++;
  top++;
  for (int i = top; i <= bottom; i++)
    spiral[i, right] = num++;
  right--;

        for (int i = right; i >= left; i--)
    spiral[bottom, i] = num++;
  bottom--;
          for (int i = bottom; i >= top; i--)
            spiral[i, left] = num++;
        left++;
    }


for (int i = 0; i < size; i++)
{
  for (int j = 0; j < size; j++)
    Console.Write(spiral[i, j].ToString().PadLeft(2) + " ");
  Console.WriteLine();
}*/

//{21} heart pattern

/*int size = 6;
for (int i = size / 2; i <= size; i += 2)
{

  for (int j = 1; j < size - i; j += 2)
    Console.Write(" ");


  for (int j = 1; j <= i; j++)
    Console.Write("*");

  for (int j = 1; j <= size - i; j++)
    Console.Write(" ");


  for (int j = 1; j <= i; j++)
    Console.Write("*");

  Console.WriteLine();
}


for (int i = size; i >= 1; i--)
{
  for (int j = i; j < size; j++)
    Console.Write(" ");

  for (int j = 1; j <= (i * 2) - 1; j++)
    Console.Write("*");

  Console.WriteLine();
}*/

//USER-INPUT EXAMPLE

/*byte a;
short b;
//int c;
//long d;
//float e;
//double f;

a = Convert.ToByte(Console.ReadLine());
Console.WriteLine("The input value of a is: " + a);

b = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("The input value of b is: " + b);


  }
}*/

//ARRAY {EXAMPLE}
class ArrayExample
{
  static void Main()
  {
    /*int[] numbers = { 10, 20, 30, 40, 50 };

    Console.WriteLine("Array elements:");
    for (int i = 0; i < numbers.Length; i++)
    {
      Console.WriteLine($"numbers[{i}] = {numbers[i]}");
    }

    numbers[2] = 35;

    Console.WriteLine("\nAfter modification:");

    foreach (int num in numbers)
    {
      Console.WriteLine(num);
    }

    string[] fruits = new string[3];
    fruits[0] = "Apple";
    fruits[1] = "banana";
    fruits[2] = "Cherry";

    
        Console.WriteLine("\nFruits array:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }*/

    //{1} basic array declaration
    /*int[] numbers = { 1, 2, 3, 4, 5 };

    Console.WriteLine("Array elements:");
    for (int i = 0; i < numbers.Length; i++)
    {
      Console.WriteLine($"numbers [{i}] = {numbers [i]}");
    }*/

    //boolean Array
    /* bool[] flags = { true, false, true };
     Console.WriteLine("bool flags");
     for (int i = 0; i < flags.Length; i++)
     {
       Console.WriteLine($"flags [{i}] = {flags[i]}");
     }*/

    //Array creation with Explicit size
    /*double[] temperatures = new double[3];
    temperatures[0] = 72.5;
    temperatures[1] = 68.3;
    temperatures[2] = 75.1;
    Console.WriteLine("double tempreture");
    for (int i = 0; i < temperatures.Length; i++)
    {
      Console.WriteLine($"tempreture [{i}] = {temperatures[i]}");d
    }*/

    //Acessing array elements directly
    /*char[] letters = { 'A', 'B', 'C', 'D' };
    char firstLetter = letters[0];  // 'A'
    char lastLetter = letters[letters.Length - 1];
    Console.WriteLine("char letters");
    for (int i = 0; i < letters.Length; i++)
    {
      Console.WriteLine($"letters [{i}] = {letters[i]}");
    }*/

    //examples
    /* int[] scores = { 85, 90, 78, 92, 88 };
     Console.WriteLine(scores[0]);
     Console.WriteLine(scores[2]);

     scores[1] = 95;
     for (int i = 0; i < scores.Length; i++)
     {
       Console.WriteLine($"Score {i + 1}: {scores[i]}");
     }
     foreach (int score in scores)
 {
     Console.WriteLine(score);
 }*/

    //two dimensional array
    /* int[,] matrix = new int[3, 4]
     {
       {1, 2, 3, 4 },
       {5, 6, 7, 8 },
       {9, 10, 11, 12},
     };
     Console.WriteLine("Element at [1,2: ]" + matrix[1, 2]);

     Console.WriteLine("\n Full 2D array:");
     for (int row = 0; row < matrix.GetLength(0); row++)
     {
       for (int col = 0; col < matrix.GetLength(1); col++)
       {
         Console.Write(matrix[row, col] + "\t");
       }
       Console.WriteLine();
     }
     matrix[0, 0] = 100;
     Console.WriteLine("\nModified first element:" + matrix[0, 0]);*/

    /*int[,] matrix2 = new int[2, 3]
    {
      {1, 2, 3 },
    { 4, 5, 6},
  };
    Console.WriteLine("Element at [1,2]" + matrix2[1, 2]);

    for (int row = 0; row < matrix2.GetLength(0); row++)
    {
      for (int col = 0; col < matrix2.GetLength(1); col++)
      {
        Console.Write(matrix2[row, col] + "\t");
      }
      Console.WriteLine();
    }*/
    //Accesing Element {1}
    /*int[,] numbers = {
      {10, 20, 30},
      {40, 50, 60},
    };
    Console.WriteLine("Element at [1,2]" + numbers[1, 2]);
    for (int row = 0; row < numbers.GetLength(0); row++)
    {
      for (int col = 0; col < numbers.GetLength(1); col++)
      {
        Console.Write(numbers[row, col] + "\t");
      }
      Console.WriteLine();
    }*/
    //{2}
    /*int[,] grid = new int[3, 3];

    grid[0, 0] = 1;
    grid[1, 2] = 5;
    int value = grid[2, 1];

    for (int row = 0; row < grid.GetLength(0); row++)
    {
      for (int col = 0; col < grid.GetLength(1); col++)
      {
        Console.Write(grid[row, col] + " ");
      }
      Console.WriteLine();
      }*/

    //pratical Example{1}
    /*char[,] ticTacToe = new char[3, 3];

    for (int row = 0; row < 3; row++)
    {
      for (int col = 0; col < 3; col++)
      {
        ticTacToe[row, col] = '-';
         ticTacToe[0, 0] = 'X';
    ticTacToe[1, 1] = 'O';
    ticTacToe[2, 2] = 'X';
        Console.Write(ticTacToe[row, col] + " ");
      }
      Console.WriteLine();
    }*/
    //{2} matrix multiplication
    int[,] matrixA = { { 1, 2 }, { 3, 4 } };
int[,] matrixB = { { 5, 6 }, { 7, 8 } };
int[,] result = new int[2, 2];

    for (int i = 0; i < 2; i++)
    {
      for (int j = 0; j < 2; j++)
      {
        for (int k = 0; k < 2; k++)
        {
          result[i, j] += matrixA[i, k] * matrixB[k, j];
          Console.Write(matrixA[k, j] + " ");
        }
        Console.Write(matrixB[i, j] + " ");
      }
      Console.WriteLine();
}
   
  }
}
       
   



    
    
    

      
       
    
  
         


  