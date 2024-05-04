using System;

class PromptGenerator
{
    public List<String> _prompts = new List<String>(){
        "How are you?",
        "What was a hard thing you did today?",
        "What did you do to help someone else today?",
        "What goal are you working towards?",
        "What was your favorite event today?",
        "Have you talked with an elder of the community today to learn something?"
    };

    public string GetRandomPrompt(int index)
    {
        return _prompts.ElementAt(index);
    
    }
}