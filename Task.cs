namespace WPF_intro
{
    internal class Task
    {
        private string Name { get; set; }
        private string Priority { get; set; }

        public Task(string name, string priority)
        {
            Name = name;
            Priority = priority;
        }

        public string DisplayData()
        {
            return $"Task name: {Name}, Priority: {Priority}";
        }



    }
}
