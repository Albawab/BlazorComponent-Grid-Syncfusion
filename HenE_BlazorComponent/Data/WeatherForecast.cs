// <copyright file="WeatherForecast.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;

namespace HenE_BlazorComponent.Data
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(this.TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
