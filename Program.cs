using Informatic;

var inf = "информатика";
Console.WriteLine(inf.Substring(2, 5));
Console.WriteLine(inf.Substring(7, 3));

Console.WriteLine();
var virus = "вирус";
Console.WriteLine(virus.Replace('в', 'ф').Replace('и', 'о').Replace('р', 'к'));

Console.WriteLine();
var wrong = "рпоцессор";
var wrongChar = wrong.ToCharArray();
(wrongChar[0], wrongChar[1]) = (wrongChar[1], wrong[0]);
wrong =new  String(wrongChar);
Console.WriteLine(wrong);

Console.WriteLine();
CapitalsAndStates.WriteSomeStrings();

