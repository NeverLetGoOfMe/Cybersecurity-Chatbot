// Cybersecurity Awareness Chatbot for South African Citizens
// Part 1: Basic Chatbot Interaction with Voice Greeting, Image
// References:
// - Pieterse, H. (2021). "The Cyber Threat Landscape in South Africa: A 10-Year Review"
//   The African Journal of Information and Communication, 28(28)
//   https://doi.org/10.23962/10539/32213
// - South African Department of Cybersecurity Guidelines
// - NIST Cybersecurity Framework (SP 800-53)

namespace CyberBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            // Initialize user session with automatic properties
            UserSession session = new UserSession();

            // Play voice greeting when the app starts
            ConsoleHelper.PlayVoiceGreeting();

            // Display the ASCII art logo
            ConsoleHelper.ShowAsciiArt();

            // Ask for the user's name and validate the input
            session.UserName = GetUserName();
            session.IsGreeted = true;

            // Welcome the user with a personalized message and typing effect
            ConsoleHelper.TypeLine($"\nHello {session.UserName}! I'm your Cybersecurity Awareness Bot.", 40);
            ConsoleHelper.TypeLine("Ask me about passwords, phishing, or safe browsing. Type 'exit' to quit.\n", 40);

            // Main chatbot interaction loop
            Chatbot bot = new Chatbot();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{session.UserName}: ");
                Console.ResetColor();
                string? userInput = Console.ReadLine();

                if (string.Equals(userInput, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    session.IncrementInteraction();
                    TimeSpan duration = session.GetSessionDuration();
                    ConsoleHelper.TypeLine($"\nStay safe online, {session.UserName}! Goodbye.", 40);
                    ConsoleHelper.TypeLine($"Session duration: {duration.TotalMinutes:F1} minutes", 30);
                    ConsoleHelper.TypeLine($"Total interactions: {session.InteractionCount}", 30);
                    break;
                }

                string reply = bot.GetResponse(userInput ?? "");
                session.IncrementInteraction();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("🤖 Bot: ");
                Console.ResetColor();
                ConsoleHelper.TypeLine(reply, 30);
                ConsoleHelper.ShowDivider();
            }
        }

        /// <summary>Asks for the user's name and validates the input.</summary>
        static string GetUserName()
        {
            ConsoleHelper.TypeLine("Hello! What's your name?", 40);
            string? name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Friend";
                ConsoleHelper.TypeLine("I'll call you Friend for now.", 40);
            }
            else
            {
                ConsoleHelper.TypeLine($"Nice to meet you, {name}!", 40);
            }
            return name;
        }
    }
}
