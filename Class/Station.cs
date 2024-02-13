using System.Text.Json.Serialization;

namespace epita_74531_Blazor_Bikes;

public class Station
{
    
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("available_bikes")]
    public int AvailableBikes { get; set; }

    [JsonPropertyName("available_bike_stands")]
    public int AvailableBikeStands { get; set; }

    [JsonPropertyName("position")]
    public Position Position { get; set; }

}
public class Position
{
    [JsonPropertyName("lat")]
    public double Latitude { get; set; }

    [JsonPropertyName("lng")]
    public double Longitude { get; set; }
}