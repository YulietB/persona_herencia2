using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace persona_herencia
{
    class Persona //clase padre
    {
        protected string Nombre; //atributos declaradas para ser usadas mas adelante
        protected string FechadeN;
        protected int Edad;
        protected string RangoEjecutivo;

        public string nombre //Caja de memoria y se ocupa otra nombreclatura en lugar de poner Nombre como se declara se pone nombre por qué si no nos marca error por qué está leyendo lo mismo
        {
            get { return Nombre; } //return es para regresar aquí si se ocupa la nomenclatura que ocupamos al inicio
            set { Nombre = value; } //se le otorga un valor
        }
        public string fechaden //caja de memoria
        {
            get { return FechadeN; } //return es para regresar
            set { FechadeN = value; }//se le otorga un valor (el get y set es un constructor)
        }
        public int edad
        {
            get { return Edad; }
            set { Edad = value; }
        }

        public string rangoejecutivo
        {
            get { return RangoEjecutivo; }
            set { RangoEjecutivo = value; }
        }
        //sin la clase persona_herencia no haría la función de leer lo que el el usuario ingresa, aquí solo se declara lo básico que te piden, que normalmente es nuestro nombre, edad, fecha de nacimiento y si eres empleado 


    }

    class Alumno : Persona //clase hija alumno (caja de memoria donde se le da un valor y retorna el valor)
    {
        protected int Matricula; //variable
        protected string Carrera;
        public int matricula
        {
            get { return Matricula; }
            set { Matricula = value; }
        }
        public string carrera
        {
            get { return Carrera; }
            set { Carrera = value; }
        }
        public Alumno(string Nombre, int Edad, string FechadeN, string Carrera, int Matricula)
        {
            nombre = Nombre;
            edad = Edad;
            fechaden = FechadeN;
            matricula = Matricula;
            carrera = Carrera;
        }
        public void Guardar_info()
        {
            try //excepción
            {
                string fileName =

                @"C:\\Users\\LICENCIATURAS\\Desktop\\persona_herencia - master\archivostxt\RegistroAlumnos.txt";
                //esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileName);
                //writer.writeline("este es un dato nuevo desde guardar");
                writer.WriteLine("Nombre:" + Nombre);
                writer.WriteLine("Edad:" + Edad);
                writer.WriteLine("Fecha de nacimiento:" + FechadeN);
                writer.WriteLine("Carrera:" + Carrera);
                writer.WriteLine("Matricula:" + Matricula);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar datos en el archvio: RegistroAlumnos.TXT", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    class Trabajador : Persona //clase hija que se llama empleado y solicita el sueldo que gana y se una una variable int por qué se ingresan valores numéricos 
    {
        protected float SueldoBase; //variable
        protected int DNI;
        public float sueldobase
        {
            get { return SueldoBase; }
            set { SueldoBase = value; }
        }
        public int dni
        {
            get { return DNI; }
            set { DNI = value; }
        }
        public Trabajador(string Nombre, int Edad, string FechadeN, string RangoEjecutivo, float SueldoBase, int DNI)
        {
            nombre = Nombre;
            edad = Edad;
            fechaden = FechadeN;
            rangoejecutivo = RangoEjecutivo;
            sueldobase = SueldoBase;
            dni = DNI;
            
        }
        public void Guardar_info()
        {
            try //excepción
            {
                string fileName =

                @"C:\\Users\\LICENCIATURAS\\Desktop\\persona_herencia - master\archivostxt\RegistroTrabajador.txt";
                //esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileName);
                //writer.writeline("este es un dato nuevo desde guardar");
                writer.WriteLine("Nombre:" + Nombre);
                writer.WriteLine("Edad:" + Edad);
                writer.WriteLine("Fecha de nacimiento:" + FechadeN);
                writer.WriteLine("Puesto:" + RangoEjecutivo);
                writer.WriteLine("Sueldo:" + SueldoBase);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar datos en el archvio: RegistroAlumnos.TXT", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

    class Maestro : Persona //clase Hija dónde lo que realizar es igual guardar el sueldo que el usuario este ingresando 
    {
        protected float SueldoBase;
        protected int DNI;
        public float sueldobase
        {
            get { return SueldoBase; }
            set { SueldoBase = value; }
        }
        public int dni
        {
            get { return DNI; }
            set { DNI = value; }
        }
        public Maestro(string Nombre, int Edad, string FechadeN, string RangoEjecutivo, float SueldoBase, int DNI)
        {
            nombre = Nombre;
            edad = Edad;
            fechaden = FechadeN;
            rangoejecutivo = RangoEjecutivo;
            sueldobase = SueldoBase;
            dni = DNI;

        }
        public void Guardar_info()
        {
            try //excepción
            {
                string fileName =

                @"C:\\Users\\LICENCIATURAS\\Desktop\\persona_herencia - master\archivostxt\RegistroDocente.txt";
                //esto inserta texto en un archivo existente, si el archivo no existe lo crea
                StreamWriter writer = File.AppendText(fileName);
                //writer.writeline("este es un dato nuevo desde guardar");
                writer.WriteLine("Nombre:" + Nombre);
                writer.WriteLine("Edad:" + Edad);
                writer.WriteLine("Fecha de nacimiento:" + FechadeN);
                writer.WriteLine("Puesto:" + RangoEjecutivo);
                writer.WriteLine("Sueldo:" + SueldoBase);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Error al guardar datos en el archvio: RegistroAlumnos.TXT", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        static class Program
        {
            /// <summary>
            /// Punto de entrada principal para la aplicación.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }

    }
}
