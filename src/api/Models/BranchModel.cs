using System.Text.Json.Serialization;

namespace TerraDesafio.Models{

    public class BranchModel{
        public class Commit
        {
            [JsonPropertyName("sha")]
            public string? Sha { get; set; }

            [JsonPropertyName("url")]
            public string? Url { get; set; }
        }

        public class Protection
        {
            [JsonPropertyName("required_status_checks")]
            public RequiredStatusChecks? RequiredStatusChecks { get; set; }
        }

        public class RequiredStatusChecks
        {
            [JsonPropertyName("enforcement_level")]
            public string? EnforcementLevel { get; set; }

            [JsonPropertyName("contexts")]
            public List<string>? Contexts { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("name")]
            public string? Name { get; set; }

            [JsonPropertyName("commit")]
            public Commit? Commit { get; set; }

            [JsonPropertyName("protected")]
            public bool Protected { get; set; }

            [JsonPropertyName("protection")]
            public Protection? Protection { get; set; }

            [JsonPropertyName("protection_url")]
            public string? ProtectionUrl { get; set; }
        }
    }
}
