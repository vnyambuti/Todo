using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Contracts
{
   public class UpdateTodoCategoryRequest
    {
        public required string Title { get; set; }

        public string? Description { get; set; }
    }
}
