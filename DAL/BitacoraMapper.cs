using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class BitacoraMapper : IRepository
    {
        private EstructuraMappper _datos;
        

         EstructuraMappper IRepository.Estructura
        {
            get { return _datos; }
            
        }

        private GenericCrud gc = new GenericCrud();
        private DigitoVerificador dvhCalc = new DigitoVerificador();



        public void Crear(IPersistible pbitacora)
        {
            
            try
            {
                ParamGeneral(pbitacora).CalcDVH().SqlParams().Encrypt().gc.Insert(this);
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        /// <summary>
        /// Método que parametriza la tabla, asocia el objeto a persistir, y obtiene el ID de la base.
        /// </summary>
        /// <param name="pbitacora"></param>
        /// <returns></returns>
        public BitacoraMapper ParamGeneral(IPersistible pbitacora)
        {
            _datos.Tabla = "BITACORA";
            _datos.campos = new List<string>();
            _datos.persistible = pbitacora;
            _datos.parametros = new List<SqlParameter>();
            ((Bitacora)pbitacora).Id = gc.GetNextId(this);


            return this;


        }


        private BitacoraMapper CalcDVH()
        {
           ((Bitacora)_datos.persistible).DVH = DigitoVerificador.CalcDVHColumn(_datos.persistible.ToString());

            return this;
        }

        private BitacoraMapper Encrypt()
        {


            return this;

        }

        /// <summary>
        /// Método que parametriza todos los sqlparameters
        /// </summary>
        /// <returns></returns>
        private BitacoraMapper SqlParams()
        {
            try
            {
                _datos.parametros.AddRange(new ReflexAdapter().GetParams(_datos.persistible));
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return this;
            
        }


        public  List<Bitacora> ListAll()
        {
            _datos.persistible = new Bitacora();
            _datos.Tabla = "BITACORA";

            DataTable dt = Acceso.ExecuteReader(gc.SelectSentence(this));

            List<Bitacora> mlista = new List<Bitacora>();

            foreach (DataRow item in dt.Rows)
            {
                mlista.Add(ValorizarEntidad(item));
            }


            return mlista;
        }


        private Bitacora ValorizarEntidad(DataRow dr)
        {
            Bitacora mbitacora = new Bitacora();

            mbitacora.Descripcion = dr["Descripcion"].ToString();
            mbitacora.Criticidad = int.Parse(dr["Criticidad"].ToString());
            mbitacora.Fecha = DateTime.Parse(dr["Fecha"].ToString());
            //mbitacora.IdUSer = int.Parse(dr["IdUSer"].ToString();
            mbitacora.Host = dr["Host"].ToString();
            //mbitacora.Descripcion = dr[""].ToString();
            return mbitacora;

        }
  
    }
}
