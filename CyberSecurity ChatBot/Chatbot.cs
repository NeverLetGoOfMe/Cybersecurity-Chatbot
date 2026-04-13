namespace CyberBot
{
    /// <summary>
    /// Handles all chatbot responses for cybersecurity topics.
    /// References:
    /// - South African Cyber Threat Landscape: Pieterse, H. (2021). "The Cyber Threat Landscape in South Africa: A 10-Year Review"
    /// - NIST Cybersecurity Framework
    /// - South African Department of Cybersecurity Guidelines
    /// </summary>
    public class Chatbot
    {
        /// <summary>Returns a reply based on the user's input (Requirement 4).</summary>
        /// <param name="input">User's message.</param>
        /// <returns>Chatbot's response.</returns>
        public string GetResponse(string input)
        {
            // Input validation (Requirement 5)
            if (string.IsNullOrWhiteSpace(input))
                return "I didn't hear anything. Please type a message.";

            string lower = input.ToLower();

            // Small talk / purpose
            if (lower.Contains("how are you"))
                return "I'm a bot, so I don't have feelings, but thanks for asking! 😊";
            if (lower.Contains("your purpose") || lower.Contains("what can i ask"))
                return "You can ask me about password safety, phishing emails, safe browsing, or just say 'help'.";
            if (lower.Contains("help"))
                return GetHelpMessage();

            // Cybersecurity topics (Requirement 4)
            // Reference: South African Cybersecurity Awareness Campaign Guidelines
            if (lower.Contains("password"))
                return GetPasswordAdvice();
            if (lower.Contains("phish"))
                return GetPhishingAdvice();
            if (lower.Contains("brows") || lower.Contains("safe browsing"))
                return GetBrowsingAdvice();
            if (lower.Contains("malware") || lower.Contains("virus"))
                return GetMalwareAdvice();
            if (lower.Contains("social engineer") || lower.Contains("social media"))
                return GetSocialEngineeringAdvice();
            if (lower.Contains("two factor") || lower.Contains("2fa"))
                return GetTwoFactorAdvice();

            // Fallback for unrecognised input (Requirement 5)
            return "I didn't quite understand that. Could you rephrase? Try asking about passwords, phishing, or safe browsing.";
        }

        /// <summary>Provides password safety advice.</summary>
        private string GetPasswordAdvice()
        {
            return "🔐 Password Safety Tips:\n" +
                   "- Use at least 12 characters with a mix of letters, numbers, and symbols\n" +
                   "- Never reuse passwords across different accounts\n" +
                   "- Enable Two-Factor Authentication (2FA) wherever possible\n" +
                   "- Consider using a reputable password manager\n" +
                   "- Never share your passwords via email or SMS\n\n" +
                   "Reference: NIST Digital Identity Guidelines (SP 800-63B)";
        }

        /// <summary>Provides phishing detection advice.</summary>
        private string GetPhishingAdvice()
        {
            return "🎣 Phishing Detection Tips:\n" +
                   "- Always verify the sender's email address carefully\n" +
                   "- Be suspicious of urgent requests or threats\n" +
                   "- Hover over links before clicking to see the actual URL\n" +
                   "- Never enter credentials on unexpected login pages\n" +
                   "- South African banks will never ask for PINs via email\n" +
                   "- Report phishing to your bank and the South African Police Service\n\n" +
                   "Reference: South African Banking Risk Information Centre (SABRIC)";
        }

        /// <summary>Provides safe browsing advice.</summary>
        private string GetBrowsingAdvice()
        {
            return "🌐 Safe Browsing Tips:\n" +
                   "- Look for 'https://' and the padlock icon in your browser\n" +
                   "- Avoid using public Wi-Fi for banking or sensitive transactions\n" +
                   "- Keep your browser and antivirus software updated\n" +
                   "- Use a VPN when accessing sensitive information on public networks\n" +
                   "- Be cautious of pop-up ads and suspicious downloads\n\n" +
                   "Reference: South African Department of Cybersecurity Guidelines";
        }

        /// <summary>Provides malware protection advice.</summary>
        private string GetMalwareAdvice()
        {
            return "🦠 Malware Protection Tips:\n" +
                   "- Install reputable antivirus software and keep it updated\n" +
                   "- Only download software from official sources\n" +
                   "- Don't open email attachments from unknown senders\n" +
                   "- Regularly scan your system for threats\n" +
                   "- Keep your operating system and applications patched\n\n" +
                   "Reference: Kaspersky Lab South Africa Security Reports";
        }

        /// <summary>Provides social engineering awareness advice.</summary>
        private string GetSocialEngineeringAdvice()
        {
            return "👤 Social Engineering Awareness:\n" +
                   "- Be skeptical of unexpected requests for personal information\n" +
                   "- Verify the identity of anyone asking for sensitive data\n" +
                   "- Don't share travel plans or personal details on social media\n" +
                   "- Be cautious of 'too good to be true' offers\n" +
                   "- Report suspicious social engineering attempts to your employer\n\n" +
                   "Reference: South African Cyber Threat Landscape (Pieterse, 2021)";
        }

        /// <summary>Provides Two-Factor Authentication advice.</summary>
        private string GetTwoFactorAdvice()
        {
            return "🔑 Two-Factor Authentication (2FA):\n" +
                   "- 2FA adds an extra layer of security to your accounts\n" +
                   "- Enable 2FA on email, banking, and social media accounts\n" +
                   "- Use authenticator apps instead of SMS when possible\n" +
                   "- Keep backup codes in a secure location\n" +
                   "- South African banks strongly recommend 2FA for all accounts\n\n" +
                   "Reference: NIST Digital Identity Guidelines (SP 800-63B)";
        }

        /// <summary>Returns a help message with available topics.</summary>
        private string GetHelpMessage()
        {
            return "📚 Topics I can help you with:\n" +
                   "- Password safety\n" +
                   "- Phishing detection\n" +
                   "- Safe browsing\n" +
                   "- Malware protection\n" +
                   "- Social engineering\n" +
                   "- Two-factor authentication (2FA)\n\n" +
                   "Just type any of these topics to learn more!";
        }
    }
}
