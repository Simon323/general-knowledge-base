public class ApiModel 
{
  private Color color { get; set; }

  [Required]
  [OpenApiEnum(typeof(Color))]
  [JsonPropertyName("Color")]
  public string ColorString 
  {
    get { return this.color.ToString(); }

    set
    {
        Type enoom = typeof(Color);
        var classAttr = enoom.GetCustomAttributes(typeof(DataContractAttribute), false).FirstOrDefault();
        if (classAttr is not null)
        {
          foreach (var member in enoom.GetMembers())
          {
            var memberAttr = member.GetCustomAttributes(typeof(EnumMemberAttribute), false).FirstOrDefault();
            if (memberAttr != null)
            {
              var attr = (EnumMemberAttribute)memberAttr;
              if (attr != null && attr.Value == value)
              {
                if (member is FieldInfo fieldInfo)
                {
                    var val = fieldInfo.GetValue(null).ToString();
                    this.tst = Enum.TryParse(val.ToString(), true, out Color g) ? g : Color._25500;
                }
              }
            }
          }
        }
    }
  }
}