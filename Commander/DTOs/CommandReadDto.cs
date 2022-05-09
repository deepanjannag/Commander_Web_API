namespace Commander.DTOs
{
    public class CommandReadDto
    {
        public int CommandId { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }

        //Removed the below property from Model to demonstrate AutoMapper DTO
        //public string Platform { get; set; }
    }
}
