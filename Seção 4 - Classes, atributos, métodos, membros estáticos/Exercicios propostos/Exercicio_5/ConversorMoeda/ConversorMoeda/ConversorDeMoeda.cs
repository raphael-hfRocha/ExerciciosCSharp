using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoeda;
public class ConversorDeMoeda
{
    public static double IOF = 6;

    public static double CalculoCompraDolar(double cotacao, double precoDolar)
    {
        double calculoIOF = (cotacao * precoDolar) * (IOF / 100);

        return (cotacao * precoDolar) + calculoIOF;
    }
}
