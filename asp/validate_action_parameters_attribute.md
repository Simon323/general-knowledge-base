# Validate Action Parameters Attribute

Below is an example controller action parameter validator.

```csharp
public class ValidateActionParametersAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var descriptor = context.ActionDescriptor as ControllerActionDescriptor;

        if (descriptor != null)
        {
            var parameters = descriptor.MethodInfo.GetParameters();

            foreach (var parameter in parameters)
            {
                var argument = context.ActionArguments[parameter.Name];

                EvaluateValidationAttributes(parameter, argument, context.ModelState);
            }
        }

        base.OnActionExecuting(context);
    }

    private void EvaluateValidationAttributes(ParameterInfo parameter, object argument, ModelStateDictionary modelState)
    {
        var validationAttributes = parameter.CustomAttributes;

        foreach (var attributeData in validationAttributes)
        {
            var attributeInstance = CustomAttributeExtensions.GetCustomAttribute(parameter, attributeData.AttributeType);

            var validationAttribute = attributeInstance as ValidationAttribute;

            if (validationAttribute != null)
            {
                var isValid = validationAttribute.IsValid(argument);
                if (!isValid)
                {
                    modelState.AddModelError(parameter.Name, validationAttribute.FormatErrorMessage(parameter.Name));
                }
            }
        }
    }
}
```