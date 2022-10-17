using Solver;
using System.Text;

var enc65001 = Encoding.GetEncoding(65001);
System.Console.OutputEncoding = Encoding.UTF8;
System.Console.InputEncoding = enc65001;

var a = double.Parse(Console.ReadLine());
var b = double.Parse(Console.ReadLine());
var c = double.Parse(Console.ReadLine());

var res = QuadraticEquationSolver.Solve(a, b, c);


Console.WriteLine(res[0].ToString()+ " " + res[1].ToString());

//var result = QuadraticEquationSolver.Solve()

