public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "What is something you changed your mind about today?",
            "What acts of service did you give today?",
            "What do you appreciate most about yourself?",
            "How did you build your testimony today?",
            "What promptings did you get from the spirit today?"
        };
        // get randome index "X"
        return "X";
    }
}