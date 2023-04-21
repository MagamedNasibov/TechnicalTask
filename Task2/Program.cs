Console.Write("Enter a decimal number: ");
int decimalNumber = int.Parse(Console.ReadLine());

int quotient = decimalNumber;
string binaryNumber = "";

while (quotient > 0)
{
    int remainder = quotient % 2;
    quotient = quotient / 2;
    binaryNumber = remainder.ToString() + binaryNumber;
}

Console.WriteLine("Binary representation: {0}", binaryNumber);