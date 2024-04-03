using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace CapaNegocio
{
    public class CAPA_NEGOCIO
    {

        CAPA_ENTIDAD objEntidad = new CAPA_ENTIDAD();
        //objeto para referenciar a CD
        CAPA_DATOS objData = new CAPA_DATOS();

        //metodo para mostrar todos lo datos
       public DataTable MostrarDatos()
        {
           return objData.D_listado();
        }

        //metodo para agregar los datos

        public void Agregar_Datos(CAPA_ENTIDAD Y) => objData.AgregarDatos(Y);


        //metodo para editar los datos
        public void Editar_Datos(CAPA_ENTIDAD Y) => objData.Actualizar(Y);

        //metodo para eliminar los datos
       
        public void Eliminar_Datos (CAPA_ENTIDAD Y) => objData.Borrar(Y);

        public DataTable Buscar(string Buscar)
        {
            return objData.BuscarEnAgenda(Buscar);

        }
       
    }
}
