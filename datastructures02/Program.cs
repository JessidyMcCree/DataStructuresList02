// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//1
void PrintNumbers(int n)
{
    if (n < 0) return;
    if (n == 0)
    {
        Console.WriteLine(0);
        return;
    }
    PrintNumbers(n - 1);
    Console.WriteLine(n);
}
PrintNumbers(5);  // Prints: 0 1 2 3 4 5

//2
int ArraySum(int[] arr, int index = 0)
{
    if (index >= arr.Length) return 0;
    return arr[index] + ArraySum(arr, index + 1);
}

int[] arr = { 1, 2, 3, 4 };
Console.WriteLine(ArraySum(arr));  // Output: 10

//3
int SumToN(int n)
{
    if (n <= 0) return 0;
    if (n == 1) return 1;
    return n + SumToN(n - 1);
}

Console.WriteLine(SumToN(5));  // Output: 15

//4
string ReverseString(string s, int index = 0)
{
    if (index >= s.Length) return "";
    return ReverseString(s, index + 1) + s[index];
}

Console.WriteLine(ReverseString("hello"));  // Output: olleh
//5
long Factorial(int n)
{
    if (n <= 1) return 1;
    return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(5));  // Output: 120
//6
int i = 1, j = 1, x = 1;
void SuperFacorialRecursion(int n)
{
    if (j <= n)
    {
        if (i <= j)
        {
            x *= i;
            i++;
            SuperFacorialRecursion(n);
        }
        else
        {
            i = 1;
            j++;
            SuperFacorialRecursion(n);
        }
    }
    else
        Console.WriteLine(x);
}
SuperFacorialRecursion(4);
//7
int[] x = [0, 0, 0, 1];
int i = 0, y = 0;
void TetanacciSequence(int n)
{
    if ((i + 1) <= (n - 4))
    {
        y = x[i] + x[i + 1] + x[i + 2] + x[i + 3];
        x = x.Append(y).ToArray();
        i++;
        TetanacciSequence(n);
    }
    else
        Console.WriteLine(y);
}

TetanacciSequence(4); // Output: 4 (0-based index)
//8
long SumCubes(int n)
{
    if (n <= 0) return 0;
    if (n == 1) return 1;
    return (long)n * n * n + SumCubes(n - 1);
}
Console.WriteLine(SumCubes(3));  // Output: 36 (1+8+27)
//9
int SumDigits(int num)
{
    if (num == 0) return 0;
    return (num % 10) + SumDigits(num / 10);
}
Console.WriteLine(SumDigits(123));  // Output: 6
//10
int[] x = [0, 1];
int i = 2;
void PellNumbersRecursion(int n)
{
    if (n > 1)
    {
        if (i <= n)
        {
            x = x.Append(2 * x[i - 1] + x[i - 2]).ToArray();
            i++;
            PellNumbersRecursion(n);
        }
        else
            Console.WriteLine(x [n]);
    }
    else
        Console.WriteLine(n);
}
PellNumbersRecursion(7);// Output: 70 (P(7) in the sequence: 0,1,2,5,12,29,70,169...)
