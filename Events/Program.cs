using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo(54);
            Circulo c2 = new Circulo(88);

            c1.CirculoCambio += ManejadorCiruloCambio;
            c2.CirculoCambio += ManejadorCiruloCambio;

            c1.Dibujar();
            c2.Dibujar();

            c1.Actualizar(52);
            c2.Actualizar(98);
        }

        private static void ManejadorCiruloCambio(object sender, CirculoEventArgs AreaCambio)
        {
            Circulo s = (Circulo)sender;
            Console.WriteLine("Nuevo Evento. El área del cirulo ahora es {0}", AreaCambio.NuevaArea);

            s.Dibujar();
        }

    }

        public class Circulo
        {
            private double radio;
            public double Area { get; set; }
            public Circulo(double rad)
            {
                radio = rad;
                Area = 3.14 * radio * radio;
            }
            public void Actualizar(double rad)
            {
                radio = rad;
                Area = 3.14 *  radio * radio;
                OnCirculoCambio(new CirculoEventArgs(Area));
            }
            public void Dibujar()
            {
                Console.WriteLine("Dibujando un circulo");
            }

            public event EventHandler<CirculoEventArgs> CirculoCambio;
            protected void OnCirculoCambio(CirculoEventArgs AreaCambio)
            {
                EventHandler<CirculoEventArgs> Manejador = CirculoCambio;

                if(Manejador != null)
                {
                    Manejador(this, AreaCambio);
                }
            }
        }

        public class CirculoEventArgs : EventArgs
        {
            public double NuevaArea { get; set;}
            public CirculoEventArgs(double rad)
            {
                NuevaArea = rad;
            }

        }
    }
