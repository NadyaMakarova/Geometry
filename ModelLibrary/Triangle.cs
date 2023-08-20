using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Triangle : Figure
    {
        #region Constructor

        public Triangle(Parameters parameters) : base(parameters)
        {
        }

        #endregion

        #region Methods

        public override double? ReturnS()
        {
            if (Parameters != null && Parameters?.A != null && Parameters?.B != null && Parameters?.C != null)
            {
                var p = Parameters?.A + Parameters?.B + Parameters?.C;
                return Math.Sqrt(p.Value * (p.Value - Parameters?.A.Value).Value * (p.Value - Parameters?.B.Value).Value * (p.Value - Parameters?.C.Value).Value);
            }
            return null;
        }

        public bool IsItRightTriangle()
        {
            if (Parameters != null && Parameters?.A != null && Parameters?.B != null && Parameters?.C != null)
            {
                if (Parameters?.A > Parameters?.B && Parameters?.A > Parameters?.C)
                    return Math.Pow(Parameters.A.Value, 2) == Math.Pow(Parameters.B.Value, 2) + Math.Pow(Parameters.C.Value, 2);
                if (Parameters?.B > Parameters?.A && Parameters?.B > Parameters?.C)
                    return Math.Pow(Parameters.B.Value, 2) == Math.Pow(Parameters.A.Value, 2) + Math.Pow(Parameters.C.Value, 2);
                if (Parameters?.C > Parameters?.A && Parameters?.C > Parameters?.B)
                    return Math.Pow(Parameters.C.Value, 2) == Math.Pow(Parameters.A.Value, 2) + Math.Pow(Parameters.B.Value, 2);
            }
            return false;
        }

        #endregion 
    }
}
