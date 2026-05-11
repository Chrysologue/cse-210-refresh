public class PromptGenerator
{
    public List<string> _prompts = [
         "What was the best part of your day today?",
        "What challenge did you face today and how did you handle it?",
        "What are three things you are grateful for today?",
        "What is one goal you want to accomplish this week?",
        "Describe a moment today that made you smile.",
        "What did you learn about yourself today?"
    ];
    public string GetRandomPrompt()
    {
        Random rand = new();

        return _prompts[rand.Next(_prompts.Count)];
    }
}