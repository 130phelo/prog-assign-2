using System;
using System.Media;
using System.Threading;

class CybersecurityBot
{
    // Automatic property for the user's name
    public string UserName { get; set; }

    static void Main(string[] args)
    {
        CybersecurityBot bot = new CybersecurityBot();
        bot.Run();
    }

    public void Run()
    {
        // 1. Voice Greeting
        PlayVoiceGreeting("greeting.wav"); // Ensure "greeting.wav" is in the same directory as the executable

        // 2. Image Display
        DisplayAsciiArt();

        // 3. Text-Based Greeting and User Interaction
        GetUserName();
        DisplayWelcomeMessage();

        // 4 & 5. Basic Response System and Input Validation
        Chat();

        Console.WriteLine("\nThank you for chatting with the Cybersecurity Awareness Bot!");
    }

    private void PlayVoiceGreeting(string audioFilePath)
    {
        try
        {
            
           // Play and wait for completion for the greeting
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing voice greeting: {ex.Message}");
        }
    }

    private void DisplayAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
  _    _       _
 | |  | |     | |
 | |__| | __ _| |_ ___
 |  __  |/ _` | __/ _ \
 | |  | | (_| | ||  __/
 |_|  |_|\__,_|\__\___|
");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("      Cybersecurity Awareness Bot");
        Console.WriteLine("------------------------------------------");
        Console.ResetColor();
        Console.WriteLine();
    }

    private void GetUserName()
    {
        Console.Write("Please enter your name: ");
        UserName = Console.ReadLine();
        Console.WriteLine();
    }

    private void DisplayWelcomeMessage()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Hello, {UserName}! Welcome to the Cybersecurity Awareness Bot.");
        Console.WriteLine("I'm here to help you learn about staying safe online.");
        Console.ResetColor();
        Console.WriteLine("You can ask me about password safety, phishing, and safe browsing.");
        Console.WriteLine("Type 'exit' to end the chat.");
        Console.WriteLine("------------------------------------------");
    }

    private void Chat()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("> ");
            Console.ResetColor();
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                break;
            }

            string response = GetChatbotResponse(userInput);
            TypeText(response); // Using typing effect for responses
            Console.WriteLine();
        }
    }

    private string GetChatbotResponse(string query)
    {
        string lowerQuery = query.ToLower();

        if (lowerQuery.Contains("how are you"))
        {
            return "I'm functioning optimally, thank you for asking!";
        }
        else if (lowerQuery.Contains("what's your purpose"))
        {
            return "My purpose is to provide basic information and raise awareness about cybersecurity topics.";
        }
        else if (lowerQuery.Contains("what can i ask you about"))
        {
            return "You can ask me about password safety, phishing, and safe browsing practices.";
        }
        else if (lowerQuery.Contains("password safety"))
        {
            return "For strong password safety, it's recommended to use a combination of uppercase and lowercase letters, numbers, and symbols. Avoid using personal information and aim for a password that is at least 12 characters long. Consider using a password manager to generate and store complex passwords.";
        }
        else if (lowerQuery.Contains("phishing"))
        {
            return "Phishing is a type of online fraud where attackers try to trick you into revealing personal information, such as passwords or credit card details, often through deceptive emails or websites. Be cautious of unsolicited messages asking for sensitive information and always verify the sender's authenticity.";
        }
        else if (lowerQuery.Contains("safe browsing"))
        {
            return "To browse safely, ensure your browser and operating system are up to date with security patches. Be wary of suspicious links and websites, especially those that don't use HTTPS. Use a reputable antivirus and anti-malware software and avoid downloading files from untrusted sources.";
        }
        else if (string.IsNullOrWhiteSpace(query))
        {
            return "Please enter a question or type 'exit'.";
        }
        else
        {
            return "I didn't quite understand that. Could you rephrase your question?";
        }
    }

    private void TypeText(string text, int delayMs = 30)
    {
        Console.ForegroundColor = ConsoleColor.White;
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delayMs);
        }
        Console.ResetColor();
    }
}
