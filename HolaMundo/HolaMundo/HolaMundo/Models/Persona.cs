using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace HolaMundo.Models
{
    public class Persona
    {

        public string nombre { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string identidad { get; set; }
        public double estaturaMts { get; set; }


        public int calcularEdad() {

            DateTime hoy = DateTime.Now;
            int anios = hoy.Year - fechaNacimiento.Year;

            if (hoy.Month < fechaNacimiento.Month) {
                anios = anios - 1;
            }

            return anios;
        }

        public override string ToString()
        {
            return $"Hola mi nombre es: {nombre} mi edad : {calcularEdad()} y mi estatura en metros son {estaturaMts}   ";
        }


    }
}
