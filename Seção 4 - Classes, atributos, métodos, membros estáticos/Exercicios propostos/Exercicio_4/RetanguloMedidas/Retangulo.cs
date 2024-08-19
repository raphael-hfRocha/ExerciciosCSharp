using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetanguloMedidas;
public class Retangulo
{
    public double Largura;
    public double Altura;

    public double Perimetro()
    {
        return (Largura * 2) + (Altura * 2);
    }

    public double Area()
    {
        return Largura * Altura;
    }

    public double Diagonal()
    {
        return Math.Sqrt((Math.Pow(Largura, 2) + Math.Pow(Altura, 2)));
    }
     
    public override string ToString()
    {
        return $"Perimetro: {Perimetro():F2} \nArea: {Area():F2} \nDiagonal: {Diagonal():F2}";
    }
}
