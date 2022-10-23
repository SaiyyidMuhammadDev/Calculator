System.Console.WriteLine("Hello!!!");

System.Console.WriteLine("Please enter first number: ");
int firstNum = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Please enter second number: ");
int secondNum = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write($"If you want use calculator, please type |1|\n If you want to take information about numbers, please type |2|:");
int desire = Convert.ToInt32(Console.ReadLine());

switch(desire)
{
   case 1:
      System.Console.WriteLine("Please choose the operation(+|-|*|/|%):");
      char operation = Convert.ToChar(Console.ReadLine());
      switch(operation)
      {
         case '+':
            System.Console.WriteLine($"{firstNum}+{secondNum}={firstNum+secondNum}");
         break;
         case '-':
            System.Console.WriteLine($"{firstNum}-{secondNum}={firstNum-secondNum}");
         break;
         case '*':
            System.Console.WriteLine($"{firstNum}*{secondNum}={firstNum*secondNum}");
         break;
         case '/':
            System.Console.WriteLine($"{firstNum}/{secondNum}={firstNum/secondNum}");
         break;
         case '%':
            System.Console.WriteLine($"{firstNum}%{secondNum}={firstNum%secondNum}");
         break;
      }
   break;
   case 2:
       string conditional =
         firstNum >= 0
            ? "First number is positive"
            : "First number is negative";
       System.Console.WriteLine(conditional);
       string conditional1 = 
         secondNum >= 0
            ? "Second number is positive"
            : "Second number is negative";
      System.Console.WriteLine(conditional1);
      if(firstNum>secondNum)
      {
         if(firstNum%2 == 0)
         {
            System.Console.WriteLine("First number is even");
            if(secondNum%2 == 0)
            {
             System.Console.WriteLine("Second number is even");
            }
            else
            {
             System.Console.WriteLine("Second number is odd");
            }
         }
         else
         {
            System.Console.WriteLine("First number is odd");
            if(secondNum%2 == 0)
            {
             System.Console.WriteLine("Second number is even");
            }
            else
            {
             System.Console.WriteLine("Second number is odd");
            }
         }
         System.Console.WriteLine($"{firstNum} bigger then {secondNum}");
      }
      else if(firstNum<secondNum)
      {
         if(firstNum%2 == 0)
         {
            System.Console.WriteLine("First number is even");
            if(secondNum%2 == 0)
            {
             System.Console.WriteLine("Second number is even");
            }
            else
            {
             System.Console.WriteLine("Second number is odd");
            }
         }
         else
         {
            System.Console.WriteLine("First number is odd");
            if(secondNum%2 == 0)
            {
             System.Console.WriteLine("Second number is even");
            }
            else
            {
             System.Console.WriteLine("Second number is odd");
            }
         }
         System.Console.WriteLine($"{firstNum} less then {secondNum}");
      }
      else
      {
         if(firstNum%2 == 0)
         {
            System.Console.WriteLine("First number is even");
            if(secondNum%2 == 0)
            {
             System.Console.WriteLine("Second number is even");
            }
            else
            {
             System.Console.WriteLine("Second number is odd");
            }
         }
         else
         {
            System.Console.WriteLine("First number is odd");
            if(secondNum%2 == 0)
            {
             System.Console.WriteLine("Second number is even");
            }
            else
            {
             System.Console.WriteLine("Second number is odd");
            }
         }
         System.Console.WriteLine($"{firstNum} equal to  {secondNum}");
      }
   break;
}
System.Console.WriteLine("Thank for using!!!");
