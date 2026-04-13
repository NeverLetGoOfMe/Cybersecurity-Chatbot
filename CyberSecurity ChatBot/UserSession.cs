namespace CyberBot
{
    /// <summary>
    /// Represents a user session with automatic properties (Requirement: Use automatic properties).
    /// Reference: C# Automatic Properties Documentation
    /// </summary>
    public class UserSession
    {
        /// <summary>Gets or sets the user's name.</summary>
        public string UserName { get; set; } = string.Empty;

        /// <summary>Gets or sets the session start time.</summary>
        public DateTime SessionStartTime { get; set; } = DateTime.Now;

        /// <summary>Gets or sets the number of interactions in this session.</summary>
        public int InteractionCount { get; set; } = 0;

        /// <summary>Gets or sets whether the user has been greeted.</summary>
        public bool IsGreeted { get; set; } = false;

        /// <summary>Increments the interaction counter.</summary>
        public void IncrementInteraction()
        {
            InteractionCount++;
        }

        /// <summary>Returns the session duration.</summary>
        public TimeSpan GetSessionDuration()
        {
            return DateTime.Now - SessionStartTime;
        }
    }
}
