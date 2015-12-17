namespace Command
{
    class Requirement
    {
        public string UserStory { get; private set; }

        public Requirement(string userStory)
        {
            UserStory = userStory;
        }
    }
}