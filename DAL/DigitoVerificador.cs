using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                resultado += item * loop;       //falta multiplicar por posicion         
                loop++;
            }
            
            return resultado;
            
        }
    
        public static int CalcDVHRow(DataRow pdr)
        {
            int acumulado = 0;
            int parcial = 0;
            string cadena = string.Empty;
            
            for (int i = 0; i < pdr.ItemArray.Length; i++)
            {
                cadena += pdr[i].ToString();
                Console.WriteLine("ROW cadena:   \n" + cadena + "\n Parcial de cadena:  " + parcial.ToString() );
            }
            acumulado = CalcDVHColumn(cadena);

            Console.WriteLine("Resultado Row \n"+  acumulado.ToString());
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


        public static int prueba(string ptable)
        {
            int acumulado = 0;

            try
            {
               DataTable dt = Acceso.ExecuteReader("select * from Bitacora;");
                if (dt.Rows.Count>0)
                    acumulado = CalcDVHTable(dt);
            }
            catch (Exception ERROR)
            {
                Console.WriteLine(ERROR.Message + ERROR.StackTrace);
            }
            return 0;
        }

        

}
}
