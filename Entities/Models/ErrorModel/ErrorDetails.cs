﻿using System.Text.Json;

namespace Entities.Models.ErrorModel
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public String? Message { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
