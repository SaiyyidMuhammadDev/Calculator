System.Console.WriteLine("Hello!!!");
System.Console.WriteLine("Please enter first number: ");
int firstNum = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Please enter second number: ");
int secondNum = Convert.ToInt32(System.Console.ReadLine());

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
System.Console.WriteLine("Thank for using!!!");
