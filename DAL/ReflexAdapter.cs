using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

using System.Data.SqlClient;

namespace DAL
{
     class ReflexAdapter 
    {
        private Reflex _reflex = Reflex.GetInstance();

        internal List<SqlParameter> GetParams(object po)
        {
            List<SqlParameter> mparametros = new List<SqlParameter>();

            _reflex.GetAllPropertys(po).ForEach(z => mparametros.Add(new SqlParameter(z.Name, z.GetValue(po))));


            return mparametros;
        }

        internal List<string> GetFields(object po) => _reflex.GetFields(po);
        

    }

    
}
