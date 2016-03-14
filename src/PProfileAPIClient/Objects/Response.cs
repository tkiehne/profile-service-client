﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace PProfileAPIClient.Objects
{
  /// <summary>
  ///  Base Reponse class
  /// </summary>
  public class Response
  {
    [JsonProperty(PropertyName="status")]
    public int Status { get; set; }
    /* overridden in subclasses until API author fixes their reponse formats
    [JsonProperty(PropertyName = "msg")]
    public List<string> Message { get; set; }
    [JsonProperty(PropertyName = "results")]
    public List<dynamic> Results { get; set; }
     */
  }
}
