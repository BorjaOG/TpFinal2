using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Service
{
    public class TipoNegocio
    {

        public List<Tipo> listar()
        {
            List<Tipo> lista = new List<Tipo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select Id, Descripcion From CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Tipo aux = new Tipo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
