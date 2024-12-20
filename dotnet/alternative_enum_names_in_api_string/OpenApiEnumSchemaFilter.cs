public class OpenApiEnumSchemaFilter : ISchemaFilter
{
    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
    {
        if (context.MemberInfo == null)
        {
            return;
        }
        var enumAnnotation = context.MemberInfo.GetCustomAttributes(typeof(OpenApiEnumAttribute), false)
            .Cast<OpenApiEnumAttribute>()
            .FirstOrDefault();

        if (enumAnnotation == null) return;

        schema.Enum = enumAnnotation.EnumOptions.Select(option => new OpenApiString(option))
            .Cast<IOpenApiAny>().ToList();
    }
}

services.AddSwaggerGen(options =>
{
  ...
  options.SchemaFilter<OpenApiEnumSchemaFilter>();
});