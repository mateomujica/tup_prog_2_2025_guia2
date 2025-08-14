using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EJ1.Models
{
    internal class Servicio
    {
        static int contador = 0; 
        Persona[] personas = new Persona[100];

        public bool AgregarPersona (Persona nueva)
        {

            Persona existe = VerPersonaPorDNI(nueva.DNI);
            if (existe == null)
            {
                personas[contador] = nueva;
                contador++;
                return true;
            }
            return false;

        }

        public int VerCantidadPersonas()
        {
            return contador; 
        }

        public Persona VerPersona (int n)
        {
            return personas[n];
        }

        public Persona VerPersonaPorDNI(int dni)
        {
         
            int indice = Buscar(dni);
            if (indice > -1)
            {
                return personas[indice];
            }
            else
            {
                return null; 
            }
            
           
            
        }


        public void EliminarPersona(Persona persona)
        {

            int idx = Buscar(persona.DNI);

            if (idx>0)
            {
                personas
            }
               

            
        }

        public int Buscar(int dni)
        {
            int indice = -1;
            int i = 0;

            while (indice == -1 && i < contador)
            {
                if (personas[i].DNI == dni)
                {
                    indice = i;
                }
                i++;

            }
            return indice;
        }
                
    }
}
