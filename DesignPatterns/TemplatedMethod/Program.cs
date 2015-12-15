using System;

namespace TemplatedMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MessagesSearcher searcher = new UselessMessagesSearcher(DateTime.Today, "Sally");
            searcher.Search();
            searcher = new ImportantMessagesSearcher(DateTime.Today, "Killer");
            searcher.Search();
        }
    }
}
