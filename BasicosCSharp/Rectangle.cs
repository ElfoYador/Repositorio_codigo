using System;
using System.Collections.Generic;
using System.Text;

namespace BasicosCSharp
{
   public  class Rectangle
    {
        private double _ancho;
        private double _altura;
        public double ancho
        {
            get => _ancho;
            set
            {
                if (value >= 0)
                    _ancho = value;
                else
                    throw new Exception("Valor del ancho incorrecto");
            }
        }
        public double altura
        {
            get => _altura;
            set
            {
                if (value >= 0)
                    _altura = value;
                else
                    throw new Exception("Valor del alto incorrecto");
            }
        }
        public Rectangle(double pAncho, double pAlto)
        {
            ancho = pAncho;
            altura = pAlto;
        }


        public double perimetro()
        {
            return 2 * ancho + 2 * altura;
        }
        public double area()
        {
            return ancho * altura;
        }
    }
}
