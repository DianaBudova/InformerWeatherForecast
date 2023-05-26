﻿using System.Text.Json.Serialization;

namespace InformerWeatherForecast.Model.WeatherApiForecast;

public class Condition
{
    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }

    [JsonPropertyName("code")]
    public int Code { get; set; }
}
