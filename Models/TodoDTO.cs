namespace TodoAPI.Models
{
    public class TodoDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Content { get; set; } = null!;
        public bool IsComplete { get; set; }
        public TodoDTO()
        {

        }
        public TodoDTO(int id, string name, string content, bool isComplete)
        {
            Id = id;
            Name = name;
            Content = content;
            IsComplete = isComplete;
        }


    }
}
