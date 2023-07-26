# Validation attribute

Below is an example model validator.

```csharp
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Http;

public class GetUserDataArgs
{
    public string Signature { get; set; }

    [GuidIfSignatureNullOrEmpty(ErrorMessage = "The 'id' field is required when the 'signature' field is not provided.")]
    public string Id { get; set; }

    [GuidIfSignatureNullOrEmpty(ErrorMessage = "The 'userId' field is required when the 'signature' field is not provided."))]
    public string UserId { get; set; }
}

public class GuidIfTokenNullOrEmptyAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var userData = (GetUserDataArgs)validationContext.ObjectInstance;

        if (string.IsNullOrEmpty(userData.Signature))
        {
            if (string.IsNullOrEmpty((string)value) || !IsValidGuid((string)value))
            {
                return new ValidationResult(ErrorMessage);
            }
        }

        return ValidationResult.Success;
    }

    private bool IsValidGuid(string guidString)
    {
        return Guid.TryParse(guidString, out _);
    }
}

public class MyController : ApiController
{
    [HttpGet]
    [Route("user")]
    public IHttpActionResult GetUserData([FromUri] GetUserDataArgs data)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok("Data is valid");
    }
}

```