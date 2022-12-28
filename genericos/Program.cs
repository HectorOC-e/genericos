using System;
namespace genericos
{
    internal class Program
    {
        static void Main()
        {
            //AlmacenObjetos<Empleado> archivos = new AlmacenObjetos<Empleado>(4);
            //AlmacenObjetos<string> archivos = new AlmacenObjetos<string>(4);
            AlmacenObjetos<DateTime> archivos = new AlmacenObjetos<DateTime>(4);

            archivos.Agregar(new DateTime(2022,12,3));
            archivos.Agregar(new DateTime(2022,10,2));
            archivos.Agregar(new DateTime(2022,11,4));
            archivos.Agregar(new DateTime(2022,8,6));

            //archivos.Agregar("Juan");
            //archivos.Agregar("Antonio");
            //archivos.Agregar("Elena");
            //archivos.Agregar("Sandra");

            //archivos.Agregar(new Empleado(2500));
            //archivos.Agregar(new Empleado(1500));
            //archivos.Agregar(new Empleado(3500));
            //archivos.Agregar(new Empleado(4500));

            //Empleado salarioEmpleado = archivos.GetDatosElementos(3);

            //Console.WriteLine(salarioEmpleado.GetSalario());

            //string nombrePersona = archivos.GetDatosElementos(3);
            //Console.WriteLine(nombrePersona);
            
            DateTime nombrePersona = archivos.GetDatosElementos(3);
            Console.WriteLine(nombrePersona);
        }
    }

    class AlmacenObjetos<T>
    {
        private T [] datosElementos;
        private int i = 0;
        public AlmacenObjetos(int z) => datosElementos = new T[z];

        public void Agregar(T obj)
        {
            datosElementos[i] = obj;
            i++;
        }

        public T GetDatosElementos(int i) => datosElementos[i];

    }

    class Empleado
    {
        private double salario;

        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario() => salario;
    }
}
