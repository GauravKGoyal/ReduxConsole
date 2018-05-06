namespace ReduxConsole
{
    public class ToDoProp
    {
        public string Description { get; set; }
        public bool Done { get; set; }

        public override string ToString()
        {
            return $"Description : {Description}";
        }
    }
}
