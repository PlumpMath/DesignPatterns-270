namespace Command
{
    class HeroDeveloperCommand : ICommand
    {
        public HeroDeveloperCommand(HeroDeveloper heroDeveloper, string projectName)
        {
            HeroDeveloper = heroDeveloper;
            ProjectName = projectName;
        }
        public void Execute()
        {
            // реалізація делегує роботу до потрібного отримувача
            HeroDeveloper.DoAllHardWork(ProjectName);
        }
        protected HeroDeveloper HeroDeveloper { get; set; }
        public string ProjectName { get; set; }
    }
}