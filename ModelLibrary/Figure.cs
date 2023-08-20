using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Figure
    {
        #region Properties

        public Parameters Parameters { get; set; }

        #endregion

        #region Constructor

        public Figure(Parameters parameters)
        {
            Parameters = parameters;
        }

        #endregion

        #region Methods

        public virtual double? ReturnS()
        {
            if (Parameters != null && Parameters?.A != null && Parameters.H != null)
                return Parameters?.A * Parameters?.H;
            return null;
        }

        #endregion
    }
}
