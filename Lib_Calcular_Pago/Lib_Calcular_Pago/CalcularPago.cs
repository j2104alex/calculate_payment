using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Calcular_Pago
{
    public class CalcularPago
    {
        #region atributos
        private string nombre;
        private string cedula;
        private double sueldoBasico;
        private int diasLaborados;
        private double basico;
        private double auxilioTransporte;
        private double totalDevengado;
        private string error;
        #endregion

        #region metodos publicos
        public CalcularPago()
        {
            nombre = "";
            cedula = "";
            sueldoBasico = 0;
            diasLaborados= 0;
            basico = 0;
            auxilioTransporte = 0;
            totalDevengado = 0;
            error = "";
        }
        public bool calcularBasico()
        {
            if (!validarSalario() || !validarDias())
            {
                return false;
            }
            try
            {
            basico = (sueldoBasico * diasLaborados)/30;
            return true;
            } catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public bool calcularAuxilioTransporte()
        {
            double valorAuxilioTransporte = 117172;
            if (!validarAccesoAuxilio())
            {
                return false;
            }
            auxilioTransporte = (valorAuxilioTransporte * diasLaborados)/30;
            return true;
        }
        public bool calcularDevengado()
        {
            totalDevengado = basico + auxilioTransporte;
            return true;
        }
        
        #endregion

        #region metodos privados
        private bool validarDias()
        {
            if (diasLaborados <= 0 || diasLaborados > 31)
            {
                error = "El número de días laborado no es válido";
                return false;
            }
            return true;
        }
        private bool validarSalario()
        {
            if (sueldoBasico <= 0)
            {
                error = "El sueldo básico ingresado no es válido";
                return false;
            }
            return true;
        }

        private bool validarAccesoAuxilio()
        {
            double SMLMV = 1000000;
            if (sueldoBasico > (SMLMV * 2))
                {
                return false;
            }
            return true;
        }
        #endregion

        #region propiedades
        public string SetNombre
        {
            set { nombre = value; }
        }
        public string SetCedula
        {
            set { cedula = value; }
        }
        public double SetSueldoBasico
        {
            set { sueldoBasico = value; }
        }
        public int SetDiasLaborados
        {
            set { diasLaborados = value; }
        }
        public double GetBasico
        {
            get { return basico; }
        }
        public double GetAuxilioTransporte
        {
            get { return auxilioTransporte; }
        }
        public double GetDevengado
        {
            get { return totalDevengado; }
        }
        public string GetError
        {
            get { return error; }
        }
        #endregion
    }
}
