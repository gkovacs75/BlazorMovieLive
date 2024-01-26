using System.Text.Json.Serialization;

namespace BlazorMovieLive.Models
{
    public class PopularMovie
    {

        [JsonPropertyName("adult")]
        public bool adult { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string backdrop_path { get; set; }

        [JsonPropertyName("genre_ids")]
        public int[] genre_ids { get; set; } = [];

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("original_language")]
        public string original_language { get; set; } = String.Empty;

        [JsonPropertyName("original_title")]
        public string? original_title { get; set; }

        [JsonPropertyName("overview")]
        public string overview { get; set; } = String.Empty;

        [JsonPropertyName("popularity")]
        public float popularity { get; set; }

        [JsonPropertyName("poster_path")]
        public string poster_path { get; set; } = String.Empty;

        [JsonPropertyName("release_date")]
        public string release_date { get; set; } = String.Empty;

        [JsonPropertyName("title")]
        public string title { get; set; } = String.Empty;

        [JsonPropertyName("video")]
        public bool video { get; set; }

        [JsonPropertyName("vote_average")]
        public float vote_average { get; set; }

        [JsonPropertyName("vote_count")]
        public int vote_count { get; set; }
    }
}
