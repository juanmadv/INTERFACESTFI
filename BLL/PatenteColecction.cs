using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
     class PatenteColecction : IEnumerable<Patente>
    {
        private List<Patente> _patentes = new List<Patente>();


        #region implementacion ITERATOR
        public IEnumerator<Patente> GetEnumerator()
        {
            return ((IEnumerable<Patente>)_patentes).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_patentes).GetEnumerator();
        }

        #endregion

    }
}
