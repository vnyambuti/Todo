using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities;

namespace Todo.Domain.Contracts
{
    public class TodoItemDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Note { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsDone { get; set; }

        public int? categoryId { get; set; }

      

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
