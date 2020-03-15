using System;

namespace MyProject.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public String Message { get; set; }

        public String StackTrace { get; set; }
    }
}
