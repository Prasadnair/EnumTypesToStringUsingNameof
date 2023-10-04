// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using EnumToStringUsingNameof;

Console.WriteLine("Convert enum to String using nameof");
var dayString = nameof(DaysofWeek.Monday);
Console.WriteLine(dayString);

Console.WriteLine("Convert String to enum using ToString()");
var day = DaysofWeek.Monday;
Console.WriteLine(day.ToString());

NameofTutorial.ConverToStringUsignNameof(DaysofWeek.Monday);
Console.ReadLine();

//Uncomment and validate the benchmark.
//var summary = BenchmarkRunner.Run<ToStringVsNameofBenchMark>();

