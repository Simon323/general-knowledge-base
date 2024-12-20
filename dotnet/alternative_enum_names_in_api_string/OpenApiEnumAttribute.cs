 [AttributeUsage(AttributeTargets.Property)]
 public class OpenApiEnumAttribute : Attribute
 {
     public OpenApiEnumAttribute(params string[] enumOptions)
     {
         EnumOptions = enumOptions;
     }

     public OpenApiEnumAttribute(Type enoom)
     {
         if (!enoom.IsEnum)
         {
             throw new ArgumentException("Type not an enum", nameof(enoom));
         }

         var result = new List<string>();

         var classAttr = enoom.GetCustomAttributes(typeof(DataContractAttribute), false).FirstOrDefault();
         if (classAttr is not null)
         {
             foreach (var member in enoom.GetMembers())
             {
                 var memberAttr = member.GetCustomAttributes(typeof(EnumMemberAttribute), false).FirstOrDefault();
                 if (memberAttr != null)
                 {
                     var attr = (EnumMemberAttribute)memberAttr;
                     result.Add(attr.Value);
                 }
             }
         }

         EnumOptions = result.ToArray();
     }

     /// <summary>
     /// Options for values that the property can have
     /// </summary>
     public string[] EnumOptions { get; }
 }