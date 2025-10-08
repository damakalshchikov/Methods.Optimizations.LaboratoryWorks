using LaboratoryWork1.Models;

namespace LaboratoryWork1.Core;

// Метод половинного деления для поиска минимума функции
public class BisectionMethod : IOptimizationMethod
{
    public string Name => "Метод половинного деления";

    public OptimizationResult FindMinimum(IFunction function, double a, double b, double epsilon)
    {
        var result = new OptimizationResult();
        int k = 0;

        double ak = a;
        double bk = b;
        double xc = (ak + bk) / 2;

        while (true)
        {
            // Шаг 3: Вычислить среднюю точку и длину интервала
            xc = (ak + bk) / 2;
            double intervalLength = bk - ak;
            double fXc = function.Calculate(xc);

            // Шаг 4: Вычислить точки y и z
            double y = ak + intervalLength / 4;
            double z = bk - intervalLength / 4;
            double fY = function.Calculate(y);
            double fZ = function.Calculate(z);

            // Сохранить шаг
            result.Steps.Add(new OptimizationStep
            {
                Iteration = k,
                A = ak,
                B = bk,
                Xc = xc,
                Y = y,
                Z = z,
                FXc = fXc,
                FY = fY,
                FZ = fZ,
                IntervalLength = intervalLength
            });

            // Шаги 5-6: Сравнить значения и исключить интервалы
            double akNext, bkNext, xcNext;

            if (fY < fXc)
            {
                // Шаг 5а: Исключить интервал (xc, bk]
                akNext = ak;
                bkNext = xc;
                xcNext = y;
            }
            else if (fZ < fXc)
            {
                // Шаг 6а: Исключить интервал [ak, xc)
                akNext = xc;
                bkNext = bk;
                xcNext = z;
            }
            else
            {
                // Шаг 6б: Исключить интервалы [ak, y) и (z, bk]
                akNext = y;
                bkNext = z;
                xcNext = xc;
            }

            // Шаг 7: Проверить условие окончания
            double nextIntervalLength = Math.Abs(bkNext - akNext);

            if (nextIntervalLength <= epsilon)
            {
                result.OptimalX = xcNext;
                result.OptimalValue = function.Calculate(xcNext);
                result.FinalIntervalStart = akNext;
                result.FinalIntervalEnd = bkNext;
                break;
            }

            // Перейти к следующей итерации
            ak = akNext;
            bk = bkNext;
            xc = xcNext;
            k++;
        }

        return result;
    }
}
