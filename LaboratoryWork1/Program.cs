using LaboratoryWork1.Tasks.Task1;

namespace LaboratoryWork1;

class Program
{
    static void Main(string[] args)
    {
        var solver = new Task1Solver();
        var result = solver.Solve();
        solver.PrintResult(result);
    }
}
