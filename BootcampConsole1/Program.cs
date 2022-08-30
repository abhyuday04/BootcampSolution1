using System;
using System.IO;
using BootcampClassLibrary1;

Console.WriteLine("Hello, Welcome to my Console App");
Console.ForegroundColor= ConsoleColor.Yellow;
Console.WriteLine("* * * * * * * * * * * * * * * * * * * * *");
Console.WriteLine("Press any  button to continue...");
Console.ReadLine();

//MyAmazingClass.DoSomething();

MyAmazingClass instance = new MyAmazingClass();
/*
DateTime aDate = instance.ReturnAValue();
instance.AcceptSomeInputs(50);
instance.AcceptSomeInputs(7, "Abhyuday");
*/

instance.SubmitReview(DateTime.Today, "Abhyuday Chaturvedi", 8);

instance.SubmitReview(DateTime.Today, rating: 9, reviewer: "Abhyuday Chaturvedi");

instance.SubmitReview2(DateTime.Today, rating: 5);



Console.WriteLine("Done");
Console.ReadLine();


