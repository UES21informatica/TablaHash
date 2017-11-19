using System;

namespace WpfApp1
{
    class Persona : Hasheable
    {
        string apellido;
        string DNI;
        string nombre;

        public Persona(string DNI, string nombre)
        {
            this.nombre = nombre;
            this.DNI = DNI;
            
        }

        public string ToString()
        {
            return DNI;
        }

        public int Hash(int tableSize)
        {
            int aux = 0 ;
            for (int i = 0; i < DNI.Length;i++)
            {
                int digito = (int)Char.GetNumericValue(DNI[i]);
                aux += digito; ;
            }
            
            return aux % tableSize;
        }

        public string Stri()
        {
            return DNI;
        }
    }
}
