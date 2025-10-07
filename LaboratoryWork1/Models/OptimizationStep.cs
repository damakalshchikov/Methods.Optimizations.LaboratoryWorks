namespace LaboratoryWork1.Models;

// Шаг алгоритма оптимизации
public class OptimizationStep
{
    public int Iteration { get; set; }
    public double A { get; set; }
    public double B { get; set; }
    public double Xc { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }
    public double FXc { get; set; }
    public double FY { get; set; }
    public double FZ { get; set; }
    public double IntervalLength { get; set; }
}
