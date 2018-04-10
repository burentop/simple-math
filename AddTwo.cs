using System;

class AddTwo
{
  static void Main()
  {
    Console.WriteLine("Enter your first number: ");
    var stringNum1 = Console.ReadLine();
    Console.WriteLine("Enter your second number: ");
    var stringNum2 = Console.ReadLine();

    var intNum1 = int.Parse(stringNum1);
    var intNum2 = int.Parse(stringNum2);

    var outputStringNum = (intNum1 + intNum2).ToString();
    Console.WriteLine(stringNum1 + " + " + stringNum2 + " = " + outputStringNum);
  }
  
}
