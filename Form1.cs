using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            if (radioalumno.Checked) // lanza un mensaje de texto si no estan completo los datos y para guardar
            {
                MessageBox.Show("Los datos han sido guardado" + "\nNombre:" + textBox1.Text + "\nFecha de nacimiento:" + textBox2.Text 
                 + "\nEdad:" + textBox3.Text + "\nMatricula: " + textBox4.Text + "\nCarrera: " + textBox5.Text, "Datos de alumno", MessageBoxButtons.OK,
                 MessageBoxIcon.Information);
                //usa los parametos del constructor
                string nombre = textBox1.Text;
                string fechaN = textBox2.Text;
                int edad = Convert.ToInt32(textBox3.Text);
                int matricula = Convert.ToInt32(textBox4.Text);
                string carrera = textBox5.Text;
                //creo un objeto alumno con los datos
                Alumno alumno = new Alumno(nombre,edad,fechaN,carrera,matricula);
                //guardo los datos en el archivo txt
                alumno.Guardar_info();
            }
            else
            {
                if (radiodocente.Checked || radioempleado.Checked)
                {
                    MessageBox.Show("Los datos han sido guardado" + "\nNombre:" + textBox1.Text + "\nFecha de nacimiento:" + textBox2.Text
                  + "\nEdad:" + textBox3.Text + "\nDNI: " + textBox4.Text + "\nPuesto: " + textBox5.Text + "nSueldo: " + textBox6, "Datos Guardados empleado", MessageBoxButtons.OK, 
                  MessageBoxIcon.Information);

                    if(radioempleado.Checked)
                    {
                        string nombre = textBox1.Text;
                        string fechaN = textBox2.Text;
                        int edad = Convert.ToInt32(textBox3.Text);
                        int DNI = Convert.ToInt32(textBox4.Text);
                        string rangoejecutivo = textBox5.Text;
                        float sueldobase = Convert.ToSingle(textBox6.Text);
                        //creo un objeto alumno con los datos
                        Trabajador trabajador = new Trabajador(nombre, edad, fechaN,DNI,rangoejecutivo,sueldobase );
                        //guardo los datos en el archivo txt
                        trabajador.Guardar_info();
                    }
                   else
                    {
                        string nombre = textBox1.Text;
                        string fechaN = textBox2.Text;
                        int edad = Convert.ToInt32(textBox3.Text);
                        int matricula = Convert.ToInt32(textBox4.Text);
                        string rangoejecutivo = textBox5.Text;
                        float sueldobase = Convert.ToSingle(textBox6.Text);
                        //creo un objeto alumno con los datos
                        Maestro maestro = new Maestro(nombre, edad, fechaN, rangoejecutivo, matricula, sueldobase);
                        //guardo los datos en el archivo txt
                        maestro.Guardar_info();
                    }

                }
                
              
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); //sirve para limpiar la pantalla de cada caja de texto
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();// se hace de tarea
            // debe de terminar la ejecucion de la interfaz
        }

        private void validar_Click(object sender, EventArgs e)
        {
            if (radioalumno.Checked)
            {
                string nombre = textBox1.Text;
                string fechaN = textBox2.Text;
                int edad = Convert.ToInt32(textBox3.Text);
                int matricula = Convert.ToInt32(textBox4.Text);
                string carrera = textBox5.Text;
                Alumno alumno = new Alumno(nombre, edad, fechaN, carrera,matricula);
            }
            else 
            {
                if (radioempleado.Checked)
                {
                    string nombre = textBox1.Text;
                    string fechaN = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                    int dni = Convert.ToInt32(textBox4.Text);
                    string rangoejecutivo = textBox5.Text;
                    float sueldobase = Convert.ToSingle(textBox6.Text);
                    Trabajador empleado = new Trabajador(nombre, edad, fechaN, rangoejecutivo, sueldobase);
                }

                else if (radiodocente.Checked)
                {
                    string nombre = textBox1.Text;
                    string fechaN = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                    int dni = Convert.ToInt32(textBox4.Text);
                    string rangoejecutivo = textBox5.Text;
                    float sueldobase = Convert.ToSingle(textBox6.Text);
                    Maestro docente = new Maestro(nombre, edad, fechaN, rangoejecutivo, sueldobase);
                }
                else
                {
                    string nombre = textBox1.Text;
                    string fechaN = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                }
            
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "D:\\proyecto_poop\\parcial2-master\\imagen\\bienvenida.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            label6.Visible = false;
            textBox6.Visible = false;
        }

        private void radioempleado_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "D:\\proyecto_poop\\parcial2-master\\imagen\\Empleado.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            label6.Visible = true;
            textBox6.Visible = true;
        }

        private void radioalumno_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "D:\\proyecto_poop\\parcial2-master\\imagen\\Alumno.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label6.Visible = false;
            textBox6.Visible = false;

        }

        private void radiodocente_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "D:\\proyecto_poop\\parcial2-master\\imagen\\Maestro.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            label6.Visible = true;
            textBox6.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string rutaImagen = "D:\\proyecto_poop\\parcial2-master\\imagen\\bienvenida.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            radioalumno.Checked = false;
            radioButton1.Checked = false;
            radiodocente.Checked = false;
            radioempleado.Checked = false;

        }
    }
}
