using LaboratoryWork1.Models;

namespace LaboratoryWork1.Core;

// Интерфейс для метода оптимизации
public interface IOptimizationMethod
{
    string Name { get; }

    // Находит минимум функции на заданном интервале
    OptimizationResult FindMinimum(IFunction function, double a, double b, double epsilon);
}
