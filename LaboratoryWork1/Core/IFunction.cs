namespace LaboratoryWork1.Core;

// Интерфейс для математической функции одной переменной
public interface IFunction
{
    // Вычисляет значение функции в точке x
    double Calculate(double x);

    string Name { get; }
}
