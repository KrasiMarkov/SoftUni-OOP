using System;

namespace AuthorProblem
{[Author("Krasi")]
    public class StartUp
    {
        [Author("Milko")]
        static void Main(string[] args)
        {
            
            Tracker tracker = new Tracker();
            tracker.PrintMethodsByAuthor();

        }
    }
}
