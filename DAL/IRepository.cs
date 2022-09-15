using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
     interface IRepository
    {
        //string GetTabla();
        //string GetTablaExtendida();
        //List<String> GetCampos();
        //List<SqlParameter> parametros();
        //string GetsentenciaCompleta();
        //string GetWhere();

        EstructuraMappper Estructura {get;}
        void Crear(IPersistible persistible);
        
    }


     struct EstructuraMappper
    {
        public String Tabla;
        public String TablaExtendida;
        public List<String> campos;
        public List<SqlParameter> parametros;
        public string sentenciaCompleta;
        public string where;
        public IPersistible persistible;

    }
    
}
