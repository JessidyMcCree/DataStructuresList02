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
long SuperFactorial(int n)
{
    long result = 1;
    for (int j = 1; j <= n; j++)
    {
        long factorial = 1;
        for (int i = 1; i <= j; i++)
        {
            factorial *= i;
        }
        result *= factorial;
    }
    return result;
}
Console.WriteLine(SuperFactorial(4));  // Output: 288 (1! * 2! * 3! * 4! = 1 * 2 * 6 * 24)
//7
int TetanacciSequence(int n)
{
    if (n < 4) return n == 3 ? 1 : 0;
    
    int[] sequence = new int[n + 1];
    sequence[0] = 0;
    sequence[1] = 0;
    sequence[2] = 0;
    sequence[3] = 1;
    
    for (int i = 4; i <= n; i++)
    {
        sequence[i] = sequence[i - 1] + sequence[i - 2] + sequence[i - 3] + sequence[i - 4];
    }
    
    return sequence[n];
}

Console.WriteLine(TetanacciSequence(4)); // Output: 1
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
int PellNumbers(int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    
    int[] pell = new int[n + 1];
    pell[0] = 0;
    pell[1] = 1;
    
    for (int i = 2; i <= n; i++)
    {
        pell[i] = 2 * pell[i - 1] + pell[i - 2];
    }
    
    return pell[n];
}
Console.WriteLine(PellNumbers(7));// Output: 169 (P(7) in the sequence: 0,1,2,5,12,29,70,169...)
