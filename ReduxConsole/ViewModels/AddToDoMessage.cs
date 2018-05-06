namespace ReduxConsole
{
    public class AddToDoMessage : IStoreMessage
    {
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
