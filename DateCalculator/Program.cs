Console.WriteLine("Insert the start number");
var startnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert the end number");
var endnumber = Convert.ToInt32(Console.ReadLine());

var startTime = DateTime.Now;

var loss = startnumber - endnumber;
var days = loss / 0.5;

var resultdate = startTime.AddDays(days);
Console.WriteLine(resultdate.ToString());

/*
* startnumber - endnumber = loss
* loss / 0.5 = days
* startdate + days = result
*/

/* Sources
* 
* https://learn.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-console?view=vs-2022#add-code-to-create-a-calculator
* https://www.tutorialsteacher.com/csharp/csharp-datetime
* https://dd.countit.at/tutorials/csharp/datum-und-zeit
* https://learn.microsoft.com/en-us/dotnet/standard/base-types/parsing-datetime#parse
* https://www.w3schools.com/cs/cs_type_casting.php
* 
*/