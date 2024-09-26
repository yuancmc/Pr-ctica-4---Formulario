using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_2___Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        
            Nombre.TextChanged += ValidarNombres;
            Apellidos.TextChanged += ValidarApellidos;
            Edad.TextChanged += ValidarEdad;
            Estatura.TextChanged += ValidarEstatura;
            Telefono.Leave += ValidarTelefono;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ape_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            string nombres = Nombre.Text;
            string apellidos = Apellidos.Text;
            string edad = Edad.Text;
            string estatura = Estatura.Text;
            string telefono = Telefono.Text;

            string genero = "";
            if (Hom.Checked)
            {
                genero = "Hombre";
            }
            else if (Muj.Checked)
            {
                genero = "Mujer";
            }
            string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nEdad: {edad}\r\nEstatura: {estatura}\r\nTelefono: {telefono}\r\nGenero: {genero}\r\n";
            string rutaArchivo = "C:/Users/chiuy/OneDrive/Desktop/Programación_Textos.txt";
            bool archivoExiste = File.Exists (rutaArchivo);

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if (archivoExiste)
                {
                 writer.WriteLine();
                }
                 writer.WriteLine(datos);
            }
            MessageBox.Show("Datos guardados con éxito:\n\n" + datos);

        }

        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }

        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }

        private bool EsEnteroValidoDe10Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10;
        }

        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }

        private void ValidarNombres(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void ValidarApellidos(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Por favor, ingrese un apellido valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }
        private void ValidarTelefono(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Length == 10 && EsEnteroValidoDe10Digitos(textbox.Text))


            {
                textbox.BackColor = Color.LightGreen;

            }
            else
            {
                textbox.BackColor = Color.LightCoral;
                MessageBox.Show("Ingrese un telefono de 10 dígitos", "Error telefono", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void ValidarEstatura(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsDecimalValido(textbox.Text))
            {
                MessageBox.Show("Por favor, ingrese una estaura valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }
        private void ValidarEdad(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsEnteroValido(textbox.Text))
            {
                MessageBox.Show("Por favor, ingrese una edad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)

        {
            Nombre.Clear();
            Apellidos.Clear();
            Edad.Clear();
            Estatura.Clear();
            Telefono.Clear();
            Hom.Checked = false;
            Muj.Checked = false;

        }
    }
}
