﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ForecastIO
{
    [DataContract]
    public class ForecastIOResponse
    {
        [DataMember]
        public decimal latitude { get; set; }
        [DataMember]
        public decimal longitude { get; set; }
        [DataMember]
        public string timezone { get; set; }
        [DataMember]
        public decimal offset { get; set; }
        [DataMember]
        public Currently currently { get; set; }
        [DataMember]
        public Minutely minutely { get; set; }
        [DataMember]
        public Hourly hourly { get; set; }
        [DataMember]
        public Daily daily { get; set; }
        [DataMember]
        public List<Alert> alerts { get; set; }
        [DataMember]
        public Flags flags { get; set; }
    }
    [DataContract]
    public class Currently
    {
        [DataMember]
        public Int64 time { get; set; }
        [DataMember]
        public string summary { get; set; }
        [DataMember]
        public string icon { get; set; }
        [DataMember]
        public decimal precipIntensity { get; set; }
        [DataMember]
        public decimal precipProbability { get; set; }
        [DataMember]
        public decimal temperature { get; set; }
        [DataMember]
        public decimal apparentTemperature { get; set; }
        [DataMember]
        public decimal dewPoint { get; set; }
        [DataMember]
        public decimal windSpeed { get; set; }
        [DataMember]
        public decimal windBearing { get; set; }
        [DataMember]
        public decimal cloudCover { get; set; }
        [DataMember]
        public decimal humidity { get; set; }
        [DataMember]
        public decimal pressure { get; set; }
        [DataMember]
        public decimal visibility { get; set; }
        [DataMember]
        public decimal ozone { get; set; }
    }
    [DataContract]
    public class MinuteForecast
    {
        [DataMember]
        public Int64 time { get; set; }
        [DataMember]
        public decimal precipIntensity { get; set; }
    }
    [DataContract]
    public class Minutely
    {
        [DataMember]
        public string summary { get; set; }
        [DataMember]
        public string icon { get; set; }
        [DataMember]
        public List<MinuteForecast> data { get; set; }
    }
    [DataContract]
    public class HourForecast
    {
        [DataMember]
        public Int64 time { get; set; }
        [DataMember]
        public string summary { get; set; }
        [DataMember]
        public string icon { get; set; }
        [DataMember]
        public decimal precipIntensity { get; set; }
        [DataMember]
        public decimal precipProbability { get; set; }
        [DataMember]
        public string precipType { get; set; }
        [DataMember]
        public decimal temperature { get; set; }
        [DataMember]
        public decimal apparentTemperature { get; set; }
        [DataMember]
        public decimal dewPoint { get; set; }
        [DataMember]
        public decimal windSpeed { get; set; }
        [DataMember]
        public decimal windBearing { get; set; }
        [DataMember]
        public decimal cloudCover { get; set; }
        [DataMember]
        public decimal humidity { get; set; }
        [DataMember]
        public decimal pressure { get; set; }
        [DataMember]
        public decimal visibility { get; set; }
        [DataMember]
        public decimal ozone { get; set; }
    }
    [DataContract]
    public class Hourly
    {
        [DataMember]
        public string summary { get; set; }
        [DataMember]
        public string icon { get; set; }
        [DataMember]
        public List<HourForecast> data { get; set; }
    }
    [DataContract]
    public class DailyForecast
    {
        [DataMember]
        public Int64 time { get; set; }
        [DataMember]
        public string summary { get; set; }
        [DataMember]
        public string icon { get; set; }
        [DataMember]
        public Int64 sunriseTime { get; set; }
        [DataMember]
        public Int64 sunsetTime { get; set; }
        [DataMember]
        public string precipType { get; set; }
        [DataMember]
        public decimal precipIntensity { get; set; }
        [DataMember]
        public decimal precipIntensityMax { get; set; }
        [DataMember]
        public decimal precipProbability { get; set; }
        [DataMember]
        public decimal temperatureMin { get; set; }
        [DataMember]
        public Int64 temperatureMinTime { get; set; }
        [DataMember]
        public decimal temperatureMax { get; set; }
        [DataMember]
        public Int64 temperatureMaxTime { get; set; }
        [DataMember]
        public decimal apparentTemperatureMin { get; set; }
        [DataMember]
        public Int64 apparentTemperatureMinTime { get; set; }
        [DataMember]
        public decimal apparentTemperatureMax { get; set; }
        [DataMember]
        public Int64 apparentTemperatureMaxTime { get; set; }
        [DataMember]
        public decimal dewPoint { get; set; }
        [DataMember]
        public decimal windSpeed { get; set; }
        [DataMember]
        public decimal windBearing { get; set; }
        [DataMember]
        public decimal cloudCover { get; set; }
        [DataMember]
        public decimal humidity { get; set; }
        [DataMember]
        public decimal pressure { get; set; }
        [DataMember]
        public decimal visibility { get; set; }
        [DataMember]
        public decimal ozone { get; set; }
    }
    [DataContract]
    public class Daily
    {
        [DataMember]
        public string summary { get; set; }
        [DataMember]
        public string icon { get; set; }
        [DataMember]
        public List<DailyForecast> data { get; set; }
    }

    [DataContract]
    public class Alert
    {
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public Int64 expires { get; set; }
        [DataMember]
        public string uri { get; set; }
        [DataMember]
        public string description { get; set; }
    }

    [DataContract]
    public class Flags
    {
        [DataMember]
        public List<string> sources { get; set; }
        [DataMember]
        public List<string> isd_stations { get; set; }
        [DataMember]
        public List<string> lamp_stations { get; set; }
        [DataMember]
        public List<string> metar_stations { get; set; }
        [DataMember]
        public List<string> darksky_stations { get; set; }
        [DataMember]
        public string units { get; set; }
    }
}
