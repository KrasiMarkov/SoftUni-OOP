using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string nameClassForInvestigate, params string[] namesFieldsForInvestigate)
        {
            Type classType = Type.GetType(nameClassForInvestigate);

            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Class under investigation: {nameClassForInvestigate}");

            foreach (var item in classFields.Where(f => namesFieldsForInvestigate.Contains(f.Name)))
            {
                sb.AppendLine($"{item.Name} = {item.GetValue(classInstance)}");
            }

            return sb.ToString().TrimEnd();
        }

        public string AnalyzeAcessModifiers(string nameClassForInvestigate)
        {

            Type classType = Type.GetType(nameClassForInvestigate);

            FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            MethodInfo[] classMethodsGet = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            MethodInfo[] classMethodsSet = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            StringBuilder sb = new StringBuilder();


            foreach (var item in classFields)
            {
                sb.AppendLine($"{item.Name} must be private!");
            }

            foreach (var item in classMethodsGet.Where(m => m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{item.Name} have to be public!");
            }

            foreach (var item in classMethodsSet.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{item.Name} have to be private!");
            }


            return sb.ToString().TrimEnd();


        }

        public string RevealPrivateMethods(string className)
        {

            Type typeClass = Type.GetType(className);

            MethodInfo[] privateMethods = typeClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"All Private Methods of Class: {className}");

            sb.AppendLine($"Base Class: {typeClass.BaseType.Name}");

            foreach (var item in privateMethods)
            {
                sb.AppendLine(item.Name);
            }

            return sb.ToString().TrimEnd();


        }

        public string CollectGettersAndSetters(string className)
        {
            Type typeClass = Type.GetType(className);

            MethodInfo[] myMethods = typeClass.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            StringBuilder sb = new StringBuilder();

            foreach (var item in myMethods.Where(x => x.Name.StartsWith("get")))
            {
                sb.AppendLine($"{item.Name} will return {item.ReturnType}");
            }

            foreach (var item in myMethods.Where(x => x.Name.StartsWith("set")))
            {
                sb.AppendLine($"{item.Name} will set field of {item.GetParameters().First().ParameterType}");
            }

            return sb.ToString().TrimEnd();
        }

    }
}
