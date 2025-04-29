using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Contracts
{
   public class UpdateTodoItemRequest
    {
        public required string Title { get; set; }
        public bool? IsDone { get; set; }

        public DateTime? DueDate { get; set; }

        public string? Note { get; set; }

    }
}
