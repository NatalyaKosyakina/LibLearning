using System.Text.Json;

namespace LibLearning
{
    public class ChatMessage
    {
        public Command Command { get; set; }
        public int? Id { get; set; }
        public string FromName { get; set; }
        public string? ToName { get; set; }
        public string Text { get; set; }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public static ChatMessage FromJson(string json)
        {
            return JsonSerializer.Deserialize<ChatMessage>(json);
        }
    }
    public enum Command
    {
        Register = 0,
        Message = 1,
        Confirmation = 2
    }
}
