using System;
using Microsoft.AspNetCore.Mvc;
using FluentValidation.Results;

namespace Toro.API.Controllers.Base
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        private readonly ICollection<string> _errors = new List<string>();

        protected ActionResult CustomResponse(object? result = null)
        {
            if (result != null && result.GetType() == typeof(ValidationResult))
            {
                var validationResult = (ValidationResult)result;

                foreach (var error in validationResult.Errors) AddProcessingError(error.ErrorMessage);
            }

            if (ValidOperation()) return Ok(result);

            return BadRequest(new ValidationProblemDetails(new Dictionary<string, string[]>
        {
            {"Messages", _errors.ToArray()}
        }));
        }

        private bool ValidOperation()
        {
            return !_errors.Any();
        }

        private void AddProcessingError(string error)
        {
            _errors.Add(error);
        }

        private void ClearProcessingError()
        {
            _errors.Clear();
        }
    }
}

