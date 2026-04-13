using System.Media;

namespace CyberBot
{
    /// <summary>
    /// Provides console UI helpers including colors, borders, typing effect, and ASCII art display.
    /// </summary>
    public static class ConsoleHelper
    {
        /// <summary>Displays the cybersecurity-themed ASCII art logo as a visual header.</summary>
        public static void ShowAsciiArt()
        {
            string art = @"
    ╔══════════════════════════════════════════════════════════╗
    ║                    🔒  CYBER BOT  🔒                      ║
    ║           'Your friendly cybersecurity assistant'         ║
    ╚══════════════════════════════════════════════════════════╝
";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(art);
            Console.ResetColor();
            Console.WriteLine(new string('═', 60));
        }

        /// <summary>Simulates a typing effect to create a more conversational feel.</summary>
        /// <param name="message">Text to display.</param>
        /// <param name="delayMs">Milliseconds between characters (default 30).</param>
        public static void TypeLine(string message, int delayMs = 30)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.WriteLine();
        }

        /// <summary>Plays the voice greeting from the greeting.wav audio file.</summary>
        public static void PlayVoiceGreeting()
        {
            string wavPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");
            if (File.Exists(wavPath))
            {
                try
                {
                    using (var player = new SoundPlayer(wavPath))
                    {
                        player.Load();
                        player.PlaySync();  // Wait until the sound finishes
                    }
                }
                catch (Exception ex)
                {
                    TypeLine($"⚠️ Could not play voice greeting: {ex.Message}", 40);
                }
            }
            else
            {
                TypeLine("⚠️ Voice greeting file (greeting.wav) not found. Continuing in silent mode.", 40);
            }
        }

        /// <summary>Displays a visual section divider to separate content sections.</summary>
        public static void ShowDivider()
        {
            Console.WriteLine(new string('─', 60));
        }
    }
}
