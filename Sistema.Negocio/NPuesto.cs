using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NPuesto
    {
        public static DataTable Listar()
        {
            DPuesto Datos = new DPuesto();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor)
        {
            DPuesto Datos = new DPuesto();
            return Datos.Buscar(Valor);
        }

        public static string Insertar(string Nombre)
        {
            DPuesto Datos = new DPuesto();

            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La puesto ya existe";
            }
            else
            {
                Puesto Obj = new Puesto();
                Obj.nombre = Nombre;
                return Datos.Insertar(Obj);
            }
        }

        
        public static string Actualizar(int Id, string Nombre)
        {
            DPuesto Datos = new DPuesto();

            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "La puesto ya existe";
            }
            else
            {
                Puesto Obj = new Puesto();
                Obj.idpuesto = Id;
                Obj.nombre = Nombre;
                return Datos.Actualizar(Obj);
            }
        }

        public static string Eliminar(int Id)
        {
            DPuesto Datos = new DPuesto();
            return Datos.Eliminar(Id);
        }


    }
}
