using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    class GenericCrud
    {
        //public static string ObtenerCampos(IRepository irepo)
        //{

        //    string campos = string.Empty;

        //    //List<String> camposobj = irepo.GetCampos();
        //    camposobj.ForEach(x => campos += x );
        //    return campos;

        //}

       public int Insert(IRepository irepo)
        {
            

            return Acceso.ExecuteNonQuery(InsertSentence(irepo), irepo.Estructura.parametros);

        }

        public int GetNextId(IRepository irepo)
        {
           return  int.Parse(Acceso.ExecuteEscalar("SP_NEXTID", new SqlParameter("@Tabla", irepo.Estructura.Tabla)).ToString());

        }



        #region Generar Sentencias
        private string InsertSentence(IRepository objeto)
        {
            string Sentencia = "INSERT INTO " + objeto.Estructura.Tabla + Campos(objeto) +" Values (";


            //Parametrice(objeto).Estructura.parametros.ForEach(x => Sentencia += "@" + x.ParameterName + ",");
            objeto.Estructura.parametros.ForEach(x => Sentencia += "@" + x.ParameterName + ",");
            Sentencia = Sentencia.Remove(Sentencia.Length - 1, 1);
            Sentencia += ");";
            return Sentencia;
        }

        private IRepository  Parametrice(IRepository objeto)
        {            
                objeto.Estructura.parametros.AddRange(new ReflexAdapter().GetParams(objeto.Estructura.persistible));
            return objeto;
        }

        private string Campos(IRepository pobjeto)
        {
            string campos = " ";
            new ReflexAdapter().GetFields(pobjeto.Estructura.persistible).ForEach(x => campos += x + ",");
            campos = campos.Remove(campos.Length - 1, 1);
            campos = campos.Insert(0, "(");
            campos = campos.Insert(campos.Length, ")");
            return campos;
        }

        #endregion


    }
}
