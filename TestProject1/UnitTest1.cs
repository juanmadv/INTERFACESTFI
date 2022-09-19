
using NUnit.Framework;
using Security;
using System;
using DAL;
using BE;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        //[Test]
        
        //public void Test1()
        //{
        //    ProxyAuth gestor = new ProxyAuth();
        //    //String res = gestor.hola();
        //    //Console.WriteLine(gestor.hola());
        //    //Assert.True(res == "hola soy una prueba");

        //}

        [Test]
        public void TestAPPCONFIG()
        {
            
            //Console.WriteLine(Acceso.obtenerConexion("valor"));


        }


        [Test]
        public void TestDVHTabla()
        {
            Acceso.CrearAcceso("DESKTOP-4VCEOPG\\SQLEXPRESS", "VsUser", "VsUser1");
            int result = DigitoVerificador.CalcDVHTable(Acceso.ExecuteReader("select id,	Descripcion,	Usuario	,Criticidad	,Fecha	,IdUser,Host,	DVH	 from Bitacora"));
            Console.WriteLine("Restultado de tabla" + result);


        }
        [Test]
        public void TestInsertarBitacora()
        {
            Acceso.CrearAcceso("DESKTOP-4VCEOPG\\SQLEXPRESS", "VsUser", "VsUser1");
            BitacoraMapper bitacora = new BitacoraMapper();
            bitacora.Crear(new Bitacora(new User("maiuser", "pass"), 1, "intento de login", DateTime.Now, "DESKTOP-4VCEOPG"));


        }

    }
}