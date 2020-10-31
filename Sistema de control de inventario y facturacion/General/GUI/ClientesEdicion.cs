using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class ClientesEdicion : Form
    {
        public ClientesEdicion()
        {
            InitializeComponent();
        }

        private void ClientesEdicion_Load(object sender, EventArgs e)
        {
            cbbTipoPersona.SelectedIndex = 0;
        }

        private void ClientesEdicion_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Esta seguro que desea salir? los cambios no se aplicarán","Advertencia",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cbbTipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTipoPersona.SelectedIndex == 0)
            {
                errorCliente.SetError(cbbTipoPersona,"Debe seleccionar una opcion valida");
            } else if(cbbTipoPersona.SelectedIndex == 1){
                //es Una persona natural
                lblNombre.Text = "Nombres";
                txbNRC.Enabled = false;
                txbCategoria.Enabled = false;
                txbGiro.Enabled = false;
                txbNombres.Enabled = true;
                txbApellidos.Enabled = true;
                txbDUI.Enabled = true;
                txbNIT.Enabled = true;
                txbDireccion.Enabled = true;
                errorCliente.Clear();
            }
            else if (cbbTipoPersona.SelectedIndex == 2)
            {
                // persona juridica
                lblNombre.Text = "Nombre de la Empresa";
                txbNRC.Enabled = true;
                txbCategoria.Enabled = true;
                txbGiro.Enabled = true;
                txbNombres.Enabled = true;
                txbApellidos.Enabled = false;
                txbDUI.Enabled = false;
                txbNIT.Enabled = true;
                txbDireccion.Enabled = true;
                errorCliente.Clear();
            }

            setDefault();
        }

        private void setDefault()
        {
            txbNombres.Text = "";
            txbApellidos.Text = "";
            txbDUI.Text = "";
            txbNIT.Text = "";
            txbNRC.Text = "";
            txbCategoria.Text = "";
            txbDireccion.Text = "";
            txbGiro.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {

            }
        }

        private bool validarCampos()
        {
            bool validado = true;
            if (cbbTipoPersona.SelectedIndex == 0)
            {
                validado = false;
            }
            //validar el tipo de persona que es
            if(cbbTipoPersona.SelectedIndex == 1){
                //validar cada campo si esta habilitado y si tiene valores
                if (txbNombres.Text.Equals(""))
                {
                    errorCliente.SetError(txbNombres, "Este campo es requerido");
                    validado = false;
                }
                else { errorCliente.Clear(); }
                if (txbApellidos.Text.Equals(""))
                {
                    errorCliente.SetError(txbApellidos, "Este campo es requerido");
                    validado = false;
                }
                else { errorCliente.Clear(); }

                //------------------------------------------------------------------------------------------------verificar valores del DUI
                if (txbDUI.Text.Equals(""))
                {
                    errorCliente.SetError(txbDUI, "Este campo es requerido");
                    validado = false;
                }
                else
                {
                    //deben de tener 10 digitos (adentro debe de verificar si lleva guion en la posicion 8)
                    char[] numeros = txbDUI.Text.ToCharArray();
                    int[] numASCII = new int[txbDUI.Text.Length];
                    if (txbDUI.Text.Length == 10)
                    {
                        errorCliente.Clear();
                        for (int i = 0; i < numeros.Length; i++)
                        {
                            numASCII[i] = (int)numeros[i];
                            if (i != 8)
                            {
                                //verificar que sea numero
                                //en ASCII 48 representa 0 y 57 representa 9, con lo cual si no es un numero no tendria que estar dentro de este rango
                                if ((numASCII[i] < 48) || (numASCII[i] > 57))
                                {
                                    errorCliente.SetError(txbDUI, "uno o mas de los valores ingresados no son numeros");
                                    validado = false;
                                }
                            }
                            else
                            {
                                if (!numeros[i].ToString().Equals("-"))
                                {
                                    errorCliente.SetError(txbDUI, "formato no aceptado");
                                    validado = false;
                                }
                                else { errorCliente.Clear();}
                            }
                        }       
                    }        
                    else
                    {
                        errorCliente.SetError(txbDUI, "Este campo requiere 10 digitos");
                        validado = false;
                    }
                }
                //----------------------------------------------------------------------------- Aqui termina la verificacion del DUI
            }else if (cbbTipoPersona.SelectedIndex == 2){
                if (txbNombres.Text.Equals(""))
                {
                    errorCliente.SetError(txbNombres, "Este campo es requerido");
                    validado = false;
                }
                if (txbGiro.Text.Equals(""))
                {
                    errorCliente.SetError(txbGiro, "Este campo es requerido");
                    validado = false;
                }
                if (txbDireccion.Text.Equals(""))
                {
                    errorCliente.SetError(txbDireccion, "Este campo es requerido");
                    validado = false;
                }
                if (txbNIT.Text.Equals(""))
                {
                    errorCliente.SetError(txbNIT, "Este campo es requerido");
                    validado = false;
                }
                if (txbCategoria.Text.Equals(""))
                {
                    errorCliente.SetError(txbCategoria, "Este campo es requerido");
                    validado = false;
                }

                //---------------------------------------------- para el NRC
                if (txbNRC.Text.Length > 0)
                {
                    char[] numeros = txbNIT.Text.ToCharArray();
                    int[] numASCII = new int[txbNIT.Text.Length];
                    if (txbDUI.Text.Length == 8)
                    {
                        errorCliente.Clear();
                        for (int i = 0; i < numeros.Length; i++)
                        {
                            numASCII[i] = (int)numeros[i];
                            if (i != 6)
                            {
                                //verificar que sea numero
                                //en ASCII 48 representa 0 y 57 representa 9, con lo cual si no es un numero no tendria que estar dentro de este rango
                                if (!(numASCII[i] >= 48) || !(numASCII[i] <= 57))
                                {
                                    errorCliente.SetError(txbNRC, "uno o mas de los valores ingresados no son numeros");
                                    validado = false;
                                }
                            }else{
                                if (!numeros[i].ToString().Equals("-"))
                                {
                                    errorCliente.SetError(txbNRC, "formato no permitido");
                                    validado = false;
                                }
                                else { errorCliente.Clear(); }
                            }
                        }
                    }else{
                        errorCliente.SetError(txbNRC, "Este campo requiere 17 digitos");
                        validado = false;
                    }
                }else{
                    errorCliente.SetError(txbNRC, "Este campo es requerido");
                    validado = false;
                }
                //---------------------------------------------- terminar el NRC
            }
            //-------------------------------------------------------------Verificar valores del NIT
            if (txbNIT.Text.Length > 0)
            {
                char[] numeros = txbNIT.Text.ToCharArray();
                int[] numASCII = new int[txbNIT.Text.Length];
                if (txbDUI.Text.Length == 17)
                {
                    errorCliente.Clear();
                    for (int i = 0; i < numeros.Length; i++)
                    {
                        numASCII[i] = (int)numeros[i];
                        if ((i != 4) && (i != 11) && (i != 15))
                        {
                            //verificar que sea numero
                            //en ASCII 48 representa 0 y 57 representa 9, con lo cual si no es un numero no tendria que estar dentro de este rango
                            if (!(numASCII[i] >= 48) || !(numASCII[i] <= 57))
                            {
                                errorCliente.SetError(txbNIT, "uno o mas de los valores ingresados no son numeros");
                                validado = false;
                            }
                        }
                        else
                        {
                            if (!numeros[i].ToString().Equals("-"))
                            {
                                errorCliente.SetError(txbNIT, "formato no permitido");
                                validado = false;
                            }
                            else { errorCliente.Clear(); }
                        }
                    }
                }
                else
                {
                    errorCliente.SetError(txbNIT, "Este campo requiere 17 digitos");
                    validado = false;
                }
            }
            //------------------------------------------------------------Termina verificacion del NIT
            return validado;
        }

        private void txbDUI_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
