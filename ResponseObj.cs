using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class parsed
{
    [JsonProperty("streetNumber")]
    public string streetNumber { get; set; }

    [JsonProperty("streetType")]
    public string streetType { get; set; }

    [JsonProperty("streetAddress")]
    public string streetAddress { get; set; }

    [JsonProperty("cityName")]
    public string cityName { get; set; }

    [JsonProperty("stateName")]
    public string stateName { get; set; }

}

public class data
{
    [JsonProperty("address")]
    public string address { get; set; }

    [JsonProperty("parsed")]
    public parsed parsed { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
