# Cybersecurity Awareness Chatbot for South African Citizens

A console-based chatbot application designed to educate South African citizens on cybersecurity topics through conversational interaction.

## Project Overview

This project addresses the rising cyber threats in South Africa by providing an interactive educational tool that simulates real-life cybersecurity scenarios and offers practical guidance.

### Part 1: Basic Chatbot Interaction with Voice Greeting, Image

This initial implementation includes:
- Voice greeting on application launch
- ASCII art logo display
- Personalized user interaction
- Basic cybersecurity response system
- Input validation
- Enhanced console UI with colors and typing effects
- Proper code structure with separate classes

## Features

### 1. Voice Greeting
- Plays a recorded WAV file greeting when the application starts
- Uses System.Media.SoundPlayer for audio playback
- Graceful fallback if audio file is missing

### 2. ASCII Art Display
- Displays a cybersecurity-themed logo on startup
- Visual header with decorative borders

### 3. User Interaction
- Asks for user's name and personalizes responses
- Tracks session duration and interaction count
- Typing effect for conversational feel

### 4. Cybersecurity Topics
The chatbot can respond to queries about:
- **Password Safety**: Strong password creation, 2FA, password managers
- **Phishing Detection**: Email verification, suspicious links, reporting
- **Safe Browsing**: HTTPS, public Wi-Fi risks, VPN usage
- **Malware Protection**: Antivirus, software updates, safe downloads
- **Social Engineering**: Identity verification, suspicious requests
- **Two-Factor Authentication**: 2FA setup, authenticator apps

### 5. Input Validation
- Handles empty or invalid inputs gracefully
- Provides helpful error messages
- Default fallback responses for unrecognized queries

### 6. Enhanced Console UI
- Colored text for different speakers
- Visual dividers and borders
- Typing animation effect
- Structured section headers

## Project Structure

```
CyberSecurity ChatBot/
├── CyberSecurity ChatBot/
│   ├── Program.cs              # Main entry point
│   ├── Chatbot.cs              # Response logic and cybersecurity content
│   ├── ConsoleHelper.cs        # UI helpers (colors, typing, audio)
│   ├── UserSession.cs          # User session management with automatic properties
│   ├── greeting.txt            # Instructions for creating greeting.wav
│   └── CyberSecurity ChatBot.csproj
├── .github/
│   └── workflows/
│       └── ci.yml             # GitHub Actions CI workflow
└── README.md
```

## Prerequisites

- .NET 8.0 SDK or later
- Windows OS (for System.Media.SoundPlayer compatibility)
- Optional: Audio recording software for greeting.wav

## Installation

1. Clone the repository:
```bash
git clone <your-repository-url>
cd CyberSecurity ChatBot
```

2. Restore dependencies:
```bash
dotnet restore
```

3. Build the project:
```bash
dotnet build
```

## Running the Application

1. Navigate to the project directory:
```bash
cd "CyberSecurity ChatBot"
```

2. Run the application:
```bash
dotnet run
```

3. (Optional) Add a voice greeting:
   - Record a WAV file with your greeting message
   - Name it `greeting.wav`
   - Place it in the `bin/Debug/net8.0/` folder

## Usage

1. The application will start with a voice greeting (if available) and ASCII art logo
2. Enter your name when prompted
3. Ask questions about cybersecurity topics:
   - "Tell me about password safety"
   - "How do I detect phishing emails?"
   - "What is safe browsing?"
   - "Help" (to see all available topics)
4. Type `exit` to quit the application

## Code Structure and Design

### Automatic Properties
The `UserSession` class uses C# automatic properties for clean, concise code:
```csharp
public string UserName { get; set; } = string.Empty;
public DateTime SessionStartTime { get; set; } = DateTime.Now;
public int InteractionCount { get; set; } = 0;
```

### String Manipulation
The chatbot uses string manipulation techniques:
- `ToLower()` for case-insensitive matching
- `Contains()` for keyword detection
- `string.IsNullOrWhiteSpace()` for input validation

### Separation of Concerns
- `Program.cs`: Application flow and orchestration
- `Chatbot.cs`: Business logic and response generation
- `ConsoleHelper.cs`: UI utilities and multimedia handling
- `UserSession.cs`: Session state management

## References

### Academic Sources
- Pieterse, H. (2021). "The Cyber Threat Landscape in South Africa: A 10-Year Review". *The African Journal of Information and Communication*, 28(28). https://doi.org/10.23962/10539/32213

### Government Guidelines
- South African Department of Cybersecurity Guidelines
- South African Banking Risk Information Centre (SABRIC)

### International Standards
- NIST Cybersecurity Framework (SP 800-53)
- NIST Digital Identity Guidelines (SP 800-63B)

### Security Organizations
- Kaspersky Lab South Africa Security Reports

## GitHub Actions CI

This project uses GitHub Actions for continuous integration:

![CI Workflow Status](https://github.com/<your-username>/<your-repo>/actions/workflows/ci.yml/badge.svg)

### CI Workflow Features
- Builds the project on Windows
- Runs on every push and pull request
- Verifies code compiles successfully
- Checks for syntax errors

To view the CI workflow status, visit the Actions tab in your GitHub repository.

## Submission Requirements

### GitHub Repository
- Minimum of 6 meaningful commits with descriptive messages
- CI workflow operational with green checkmark
- Complete project folder with all source code
- README.md with CI workflow screenshot

### Video Presentation
- 8-10 minute unlisted YouTube video
- Voice-over explaining code structure, logic, and techniques
- Demonstration of the running application
- No AI voices allowed

## Future Enhancements (Part 2 & 3)

- GUI implementation using WPF or Win Forms
- Interactive elements (games or task lists)
- Advanced cybersecurity scenarios
- Integration with external security APIs

## License

This project is developed for educational purposes as part of the Cybersecurity Awareness campaign.

## Author

Developed for the South African Department of Cybersecurity Awareness Campaign.

## Acknowledgments

- The Independent Institute of Education (Pty) Ltd 2026
- South African Department of Cybersecurity
