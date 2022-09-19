using System;
using System.Data;
using System.Text;

namespace DAL
{
    public  class DigitoVerificador
    {

        /// <summary>
        /// Método que calcula el DVH por un string entero
        /// </summary>
        /// <param name="pcadena"></param>
        /// <returns></returns>
        public static int CalcDVHColumn(string pcadena)
        {            
            
            int loop = 1;
            int resultado = 0;
            byte[] b = Encoding.ASCII.GetBytes(pcadena);
           
            foreach (var item in b)
            {
                resultado += item; // * loop;       //Multiplicar por posicion         
                loop++;
            }
            Console.WriteLine(String.Format("Parcial de cadena:\n {0} Resultado de esta cadena \n: {1} ", pcadena, resultado.ToString()));
            return resultado;
            
        }
    
        public static int CalcDVHRow(DataRow pdr)
        {
            int acumulado = 0;
            int digActual = 0;
            string cadena = string.Empty;
            //se valida si tiene datos el dvh y se pisa ya habiendolo acumulado para comparar
            if (int.TryParse(pdr["DVH"].ToString(), out digActual))
                pdr["DVH"] = 0;
            
            Console.WriteLine("OBTUVE EL DVH: \n :" + digActual); 
            
            for (int i = 0; i < pdr.ItemArray.Length; i++)
            {                   
                 cadena += pdr[i].ToString();                                 
            }
            cadena = cadena.Remove(cadena.Length - 1);
            acumulado = CalcDVHColumn(cadena);
            if(acumulado != digActual)
            {
                Console.WriteLine("ERROR DE DVH en ID: \n" + pdr[0].ToString() );
            }

            Console.WriteLine("Cadena:\n" + cadena + " \n Resultado Row \n" +  acumulado.ToString());
            return acumulado;

        }


        public static int CalcDVHTable(DataTable pdt)
        {
            int acumulado = 0;
            foreach (DataRow item in pdt.Rows)
            {
                acumulado += CalcDVHRow(item);
            }
            Console.WriteLine("TOTAL TABLA:     \n " + acumulado);
            return acumulado;
        }


        internal static int Prueba(IRepository ptable)
        {
            int acumulado = 0;

            try
            {
               DataTable dt = Acceso.ExecuteReader(String.Format("select * from {};" ,ptable.Estructura.Tabla));
                DataTable dt2 = dt.Copy();

                //limpio digitos ya calculados para verificar
                ClearDVH(dt2);
                
                if (dt.Rows.Count>0)
                    acumulado = CalcDVHTable(dt);
            }
            catch (Exception ERROR)
            {
                Console.WriteLine(ERROR.Message + ERROR.StackTrace);
            }
            return 0;
        }


        private static void ClearDVH(DataTable mdt)
        {
            foreach (DataRow item in mdt.Rows)
            {
                item["DVH"] = "";
            }

        }
        

}
}
