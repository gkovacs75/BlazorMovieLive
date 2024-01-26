using System.Text.Json.Serialization;

namespace BlazorMovieLive.Models
{
    public class PopularMoviePagedResponse
    {
        [JsonPropertyName("page")]
        public int page { get; set; }
        [JsonPropertyName("results")]
        public IEnumerable<PopularMovie> results { get; set; } = [];
        [JsonPropertyName("total_pages")]
        public int total_pages { get; set; }
        [JsonPropertyName("total_results")]
        public int total_results { get; set; }
    }
}
