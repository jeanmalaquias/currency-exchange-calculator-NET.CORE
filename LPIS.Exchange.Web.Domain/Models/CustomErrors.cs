using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LPIS.Exchange.Web.Domain.Models
{
    public class ErrorResponseException : Exception
    {
        private readonly string message = string.Empty;
        public ErrorResponseException()
        {
        }

        public ErrorResponseException(string message)
        {
            this.message = message;
        }

        public ErrorResponseException(ErrorResponse error)
        {
            string content = (error.ValidationErrors != null) ? string.Join(".", error.ValidationErrors.Select(e => e.Description)) : null;
            if (content == null)
            {
                message = $"{error.Detail}";
            }
            else
            {
                message = $"{content}";
            }
        }

        public override string Message => message;
    }

    public class ErrorResponse
    {
        public IList<CustomError> ValidationErrors { get; set; }
        public string Detail { get; set; }
        public int Status { get; set; }
        public string Title { get; set; }
    }

    public class CustomError
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
