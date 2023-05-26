﻿using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.AccuWeather1Day;

public class WindGust
{
    [JsonPropertyName("Speed")]
    public Speed Speed { get; set; }

    [JsonPropertyName("Direction")]
    public Direction Direction { get; set; }
}
