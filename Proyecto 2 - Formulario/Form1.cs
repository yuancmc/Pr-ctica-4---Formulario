using DocumentFormat.OpenXml.Bibliography;
using System;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_2___Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
