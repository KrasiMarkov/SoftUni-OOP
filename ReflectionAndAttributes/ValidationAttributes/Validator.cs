using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;


namespace ValidationAttributes
{
    public static class Validator 
    {
        public static bool IsValid(object obj)
        {
            Type objType = obj.GetType();

            PropertyInfo[] propertyInfos = objType.GetProperties();

            foreach (var propertyInfo in propertyInfos)
            {

                List<MyValidationAttribute> allMyValidationAttributes = propertyInfo.GetCustomAttributes<MyValidationAttribute>().ToList();

                object propertyObj = propertyInfo.GetValue(obj);

                foreach (MyValidationAttribute myValidationAttribute in allMyValidationAttributes)
                {

                    bool isValid = myValidationAttribute.IsValid(propertyObj);

                    if (!isValid)
                    {
                        return false;
                    }


                }

            }

            return true;
        }

    }
}
