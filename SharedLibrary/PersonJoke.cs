namespace SharedLibrary
{
    public class PersonJoke
    {
        public int ID { get; set; }
        public string JokeText { get; set; }
        public Person Person { get; set; }
        public override string ToString()
        {
            return $"id: {ID}; jokeText: {JokeText}; Person: {Person}";
        }
    }
}
