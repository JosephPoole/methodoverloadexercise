using Methodoverloadexercise;

var a = 29;
var b = 55;

var answer = Method.Add(a, b);

var c = 32.0m;
var d = 45.0m;

var decimalAnswer = Method.Add(c, d);

var thirdAnswer = Method.Add(1, 0, true);

Console.WriteLine($"int method add: {answer} decimal method add: {decimalAnswer}");
Console.WriteLine(thirdAnswer);
		