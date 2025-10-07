namespace LaboratoryWork1.Models;

// Результат оптимизации
public class OptimizationResult
{
    public double OptimalX { get; set; }
    public double OptimalValue { get; set; }
    public double FinalIntervalStart { get; set; }
    public double FinalIntervalEnd { get; set; }
    public List<OptimizationStep> Steps { get; set; } = new();
}
