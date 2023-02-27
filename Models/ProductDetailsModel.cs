using Microsoft.AspNetCore.Components;
using System.Text.Json.Serialization;

namespace SouthPacificSeaUrchins.Models
{
    public class ProductDetailsModel
    {
        [JsonPropertyName("productName")]
        public string Name { get; set; }
        public string Availability { get; set; }
        [JsonPropertyName("productDescription")]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
