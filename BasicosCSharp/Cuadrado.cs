using System;
using System.Collections.Generic;
using System.Text;

namespace BasicosCSharp
{
    public class Cuadrado
    {
        private double _lado;
        public double lado { get => _lado;

            set {if (value >= 0)
                    _lado = value;
                else
                    throw new Exception("Valor del lado incorrecto");
            }

        }

        

        public Cuadrado(double pLado)
        {
            lado = pLado;
        }

        public double getLado() {
            return this.lado;
        }
        public void setLado(double nuevoLado) {

            if (nuevoLado < 0) return;
            lado = nuevoLado;
        }
        public double perimetro()
        {
            return 4 * lado;
        }
        public double area()
        {
            return lado * lado;
        }


    }
}
