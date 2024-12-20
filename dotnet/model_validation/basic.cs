public class YourModel
{
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Age is required")]
    [Range(18, 100, ErrorMessage = "Age must be between 18 and 100")]
    public int Age { get; set; }
}

private static (bool IsValid, List<string> ValidationResults) DataAnnotationValidation(YourModel model)
{
    var validationResults = new List<ValidationResult>();
    var context = new ValidationContext(model);
    var result = new List<string>();

    bool isValid = Validator.TryValidateObject(model, context, validationResults, true);

    if (!isValid && validationResults is not null)
    {
        result.AddRange(validationResults.Select(x => x.ErrorMessage).ToList());
    }

    return (isValid, result);
}