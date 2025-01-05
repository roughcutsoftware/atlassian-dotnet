using System;
using System.Linq;
using System.Reflection;

namespace Roughcut.Atlassian.Interfaces.Extensions
{
    public static class AttributeExtension
    {
        public static string GetAttributePropValue(this object objectToUse, string attributePropName)
        {
            // Get instance of the attribute.
            //Attribute MyAttribute = Attribute.GetCustomAttribute(t, typeof(JsonConstants));

            //
            //TypeInfo typeInfo = objectToUse..GetTypeInfo();
            Type typeInfo = objectToUse.GetType();
            var attrs = typeInfo.GetCustomAttributes();

            // get attribute value from the attribute by name
            //var attr = attrs.GetType().GetProperty("PropId").GetValue(attrs, null);

            // get attribute value from the attribute by name
            var attrValue = attrs.ToList(); //.FirstOrDefault(fd => fd.ToString() == attributePropName).ToString();
                //.GetType().GetProperty(attributePropName)!.GetValue(attrs, null);


            //if (MyAttribute == null)
            //{
            //    Console.WriteLine("The attribute was not found.");
            //}
            //else
            //{
            //    // Get the Name value.
            //    Console.WriteLine("The Name Attribute is: {0}.", MyAttribute.Name);
            //    // Get the Level value.
            //    Console.WriteLine("The Level Attribute is: {0}.", MyAttribute.Level);
            //    // Get the Reviewed value.
            //    Console.WriteLine("The Reviewed Attribute is: {0}.", MyAttribute.Reviewed);
            //}

            // return the attribute value
            return attrValue.FirstOrDefault(fd => fd.ToString() == attributePropName).ToString();
        }
    }
}
