using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExameIParcialNegocios
{
    public class Empleado
    {
        public String nombreEmpleado { get; set; }
        public String identidad { get; set; }
        public int horasTrabajadas { get; set; }
        public double PagoNHT { get; set; }
        public int horasExtra { get; set; }
        public double PagoHET { get; set; }

        public double sueldoSinDeducciones;
        public double sueldoPorHorasExtras;
        public double IHSS;
        public double RAP;
        public double Total;


        public double calculoSueldoSinDeducciones() {
            sueldoSinDeducciones = horasTrabajadas * PagoNHT;
            return sueldoSinDeducciones;
        }

        public double calculoSueldoPorHorasExtras()
        {
            sueldoPorHorasExtras = calculoSueldoSinDeducciones() + (horasExtra * PagoHET);
            return sueldoPorHorasExtras;
        }
        
        public double calculoIHSS()
        {
            IHSS = calculoSueldoPorHorasExtras() * 0.04;
            return IHSS;
        }

        public double calculoRAP()
        {
            RAP = calculoSueldoPorHorasExtras() * 0.035;
            return RAP;
        }

        public double calculoSueldoTotal()
        {
            Total = (calculoSueldoPorHorasExtras()) - (calculoRAP() + calculoIHSS());
            return Total;
        }

    }
}
