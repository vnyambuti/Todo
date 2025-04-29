using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Contracts
{
   public class ApiResponse
    {

        public bool IsSuccess { get; set; }
        public String? Message { get; set; }

        public object? Result { get; set; }

        public int? Status { get; set; }
    }
}
