using System.Text.Json.Serialization;

namespace TerraDesafio.Models{

    public class WebHookModel{
        public class Config
        {
            [JsonPropertyName("content_type")]
            public string? ContentType { get; set; }

            [JsonPropertyName("insecure_ssl")]
            public string? InsecureSsl { get; set; }

            [JsonPropertyName("url")]
            public string? Url { get; set; }
        }

        public class LastResponse
        {
            [JsonPropertyName("code")]
            public object? Code { get; set; }

            [JsonPropertyName("status")]
            public string? Status { get; set; }

            [JsonPropertyName("message")]
            public object? Message { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("type")]
            public string? Type { get; set; }

            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("name")]
            public string? Name { get; set; }

            [JsonPropertyName("active")]
            public bool Active { get; set; }

            [JsonPropertyName("events")]
            public List<string>? Events { get; set; }

            [JsonPropertyName("config")]
            public Config? Config { get; set; }

            [JsonPropertyName("updated_at")]
            public DateTime UpdatedAt { get; set; }

            [JsonPropertyName("created_at")]
            public DateTime CreatedAt { get; set; }

            [JsonPropertyName("url")]
            public string? Url { get; set; }

            [JsonPropertyName("test_url")]
            public string? TestUrl { get; set; }

            [JsonPropertyName("ping_url")]
            public string? PingUrl { get; set; }

            [JsonPropertyName("deliveries_url")]
            public string? DeliveriesUrl { get; set; }

            [JsonPropertyName("last_response")]
            public LastResponse? LastResponse { get; set; }
        }
    }
}
