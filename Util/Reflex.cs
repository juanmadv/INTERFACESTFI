using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public  class Reflex
    {

        private Reflex() { }

        private static Reflex instance;

        public static Reflex GetInstance()
        {
            if (instance == null)
            {
                instance = new Reflex();
            }
            return instance;
        }

        //static  cadena = string.Empty;
        /// <summary>
        /// Metodo para obtener ToString() concatenando todos los campos.
        /// </summary>
        /// <param name="po"></param>
        /// <returns></returns>
        public  string GetString(Object po)
        {
            string cadena = string.Empty;
            try
            {
                po.GetType().GetProperties().Where(x => x.GetCustomAttributes(typeof(ColumnaAttribute)).Any()).ToList().ForEach(z => cadena += z.GetValue(po));

            }
            catch (Exception ex)
            {
                throw ex;
            }                                 

            #region Busqueda con foreach
            /*
            foreach (PropertyInfo propertyInfo in po.GetType().GetProperties())
            {                
                if (propertyInfo.GetCustomAttributes(typeof(ColumnaAttribute)).Any())
                {
                    cadena += propertyInfo.GetValue(po);
                }
                foreach (Attribute ob in propertyInfo.GetCustomAttributes())                
                {
                    
                    if (ob is ColumnaAttribute)
                    {
                        Console.WriteLine("NOMBRE DE PROPERTYINFO: " + propertyInfo.Name + "  VALOR     :" + propertyInfo.GetValue(po));
                        
                    }
                    else
                        Console.WriteLine("nose que es esto..." + ob.ToString());
                }
            }*/

            #endregion
            

            return cadena;

        }

        public  List<PropertyInfo> GetAllPropertys(object po)
        {
            return  po.GetType().GetProperties().Where(x => x.GetCustomAttributes(typeof(ColumnaAttribute)).Any()).ToList();
        }


           
            public  List<string> GetFields(Object po)
        {
            List<string> mlista = new List<string>();           
            try
            {
                po.GetType().GetProperties().Where(x => x.GetCustomAttributes(typeof(ColumnaAttribute)).Any()).ToList().ForEach(z => mlista.Add(z.Name));
            }
            catch (Exception ex)
            {
                throw ex;
            }                                             

            return mlista;

        }
           


    }
}
