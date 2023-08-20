using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Circle : Figure
    {
        #region Constructor

        public Circle(Parameters parameters) : base(parameters)
        {
        }

        #endregion

        #region Methods

        public override double? ReturnS()
        {
            if (Parameters != null && Parameters?.R != null)
                return Math.PI * Math.Pow(Parameters.R.Value, 2);
            return null;
        }

        #endregion
    }
}
