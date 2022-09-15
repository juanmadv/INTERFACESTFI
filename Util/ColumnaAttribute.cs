using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    

        [System.AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
        public sealed class ColumnaAttribute : Attribute
        {
            // See the attribute guidelines at 
            //  http://go.microsoft.com/fwlink/?LinkId=85236
             string positionalString;

            // This is a positional argument
            public ColumnaAttribute(string positionalString)
            {

            this.positionalString = positionalString;
                // TODO: Implement code here

                
            }

            public string PositionalString
            {
                get { return positionalString; }
            }

            // This is a named argument
            public int NamedInt { get; set; }
        }


    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class MyAttribute : Attribute
    {
        // See the attribute guidelines at 
        //  http://go.microsoft.com/fwlink/?LinkId=85236
        readonly string positionalString;

        // This is a positional argument
        public MyAttribute(string positionalString)
        {
            this.positionalString = positionalString;

            // TODO: Implement code here

            //throw new NotImplementedException();
        }

        public string PositionalString
        {
            get { return positionalString; }
        }

        // This is a named argument
        public int NamedInt { get; set; }
    }
    }

