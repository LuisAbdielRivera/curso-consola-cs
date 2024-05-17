using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Direccion Persona1;

            Persona1.codPostal = 12150;
            Persona1.municipio = "Xicotepec";
            Persona1.calle = "Florida";
        }
        struct Direccion
        {
            public int codPostal; 
            public string calle;
            public string municipio;
            
            public string getDireccion() 
            {
                return calle + codPostal + municipio;
            }
        }
    }
}