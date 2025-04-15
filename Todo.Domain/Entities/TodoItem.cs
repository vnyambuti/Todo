


namespace Todo.Domain.Entities
{
   public class TodoItem
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsDone { get; set; }

        public int? categoryId { get; set; }

        public Category? Category { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }


    }
}
