using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_Calcular_Pago;
using System.Linq.Expressions;

namespace App_calcular_pago
{
    public partial class lblNombre: UserControl
    {
        public lblNombre()
        {
            InitializeComponent();
        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularPago objcalcularPago = new CalcularPago();

            string nombre, cedula;
            double sueldoBasico;
            int diasLaborados;


            try{
            nombre=txtNombre.Text;
            cedula=txtCedula.Text;
            sueldoBasico = Convert.ToDouble(txtSueldoBasico.Text);
            diasLaborados = Convert.ToInt32(txtDiasLaborados.Text);

                objcalcularPago.SetDiasLaborados = diasLaborados;
                objcalcularPago.SetSueldoBasico = sueldoBasico;



            if (objcalcularPago.calcularBasico())
                {
                txtBasico.Text = objcalcularPago.GetBasico.ToString();
                }
            else
                {
                MessageBox.Show(objcalcularPago.GetError);
                }

            if (objcalcularPago.calcularAuxilioTransporte())
                
                txtAuxilioTransporte.Text = objcalcularPago.GetAuxilioTransporte.ToString(); 
                
             else
                
                txtAuxilioTransporte.Text = "0";

             if (objcalcularPago.calcularDevengado())
                {
                txtTotalDevengado.Text = objcalcularPago.GetDevengado.ToString();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }
        }
    }
