using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object objProperty)
        {
            if (objProperty != null)
            {
                return true;
            }

            return false;
        }
    }
}
