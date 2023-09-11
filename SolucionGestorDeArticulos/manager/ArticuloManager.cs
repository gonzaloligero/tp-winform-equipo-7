﻿//using winform_app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using System.Windows.Forms;
using dominio;

namespace manager
{
    public class ArticuloManager
    {
        private List<Articulo> lista = new List<Articulo>();
        private List<Categoria> listaCategorias = new List<Categoria>();
        private List<Marca> listaMarcas = new List<Marca>();
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
       

        public ArticuloManager()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand();
        }


        public List<Articulo> ListarArticulos()
        {
            List<Articulo> lista = new List<Articulo> ();
            AccesoDatos datos = new AccesoDatos ();

            try
            {
                datos.setearConsulta("SELECT A.Codigo, A.Nombre, A.Descripcion AS ArticuloDescripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.Precio, I.ImagenUrl FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id LEFT JOIN IMAGENES I ON A.Id = I.IdArticulo");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["ArticuloDescripcion"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];

                    
                    if (!Convert.IsDBNull(datos.Lector["Categoria"])) aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    else aux.Categoria.Descripcion = "Sin categoría";                   

                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Imagen = (string)datos.Lector["ImagenUrl"];

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


        public List<Categoria> ListarCategorias()
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM CATEGORIAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)lector["Id"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    
                    listaCategorias.Add(aux);
                }

                conexion.Close();
                return listaCategorias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Marca> ListarMarcas()
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM MARCAS";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)lector["Id"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    listaMarcas.Add(aux);
                }

                conexion.Close();
                return listaMarcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> ListarCodigoArticulo()
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, Precio, ImagenUrl FROM ARTICULOS A, MARCAS M , CATEGORIAS C, IMAGENES I WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND I.IdArticulo = A.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                
                    aux.Precio = (decimal)lector["Precio"];
                   

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> buscarArticulo(string buscar)
        {
            try
            {
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio FROM ARTICULOS WHERE Codigo LIKE @Codigo";
                comando.Parameters.AddWithValue("@Codigo", "%" + buscar + "%");
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                List<Articulo> lista = new List<Articulo>();

                while (lector.Read())
                {
                    string codigoArticulo = (string)lector["Codigo"];

                    
                    if (codigoArticulo.Contains(buscar))
                    {
                        Articulo aux = new Articulo();
                        aux.Codigo = codigoArticulo;
                        aux.Nombre = (string)lector["Nombre"];
                        aux.Descripcion = (string)lector["Descripcion"];
                        aux.Marca.Id = (int)lector["IdMarca"];
                        aux.Categoria.Id = (int)lector["IdCategoria"];
                        aux.Precio = (decimal)lector["Precio"];

                        lista.Add(aux);
                    }
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void setearConsulta(string query)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            
            try
            {
                conexion.Open();

                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre,valor);
        }

        public void agregarArticulo(dominio.Articulo nuevoArticulo)
        {

            try
            {
                setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@Precio)");
                setearParametro("@Codigo", nuevoArticulo.Codigo);
                setearParametro("@Nombre", nuevoArticulo.Nombre);
                setearParametro("@Descripcion", nuevoArticulo.Descripcion);
                setearParametro("@IdMarca", nuevoArticulo.Marca.Id);
                setearParametro("@IdCategoria", nuevoArticulo.Categoria.Id);
                setearParametro("@Precio", nuevoArticulo.Precio);
                conexion.Close();
                ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }


    }

    
}

