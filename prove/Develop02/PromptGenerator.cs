public class PromptGenerator
{
    public List<string> _prompts;
    public Random _rng = new ();

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What is something you changed your mind about today?",
            "What acts of service did you give today?",
            "What do you appreciate most about yourself?",
            "How did you build your testimony today?",
            "What promptings did you get from the spirit today?"
        };
    }
    public string GetRandomPrompt()
    {
        int prompt = _rng.Next(_prompts.Count);
        return _prompts[prompt];
    }
}