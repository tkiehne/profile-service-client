﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using PProfileAPIClient.Converters;

namespace PProfileAPIClient.Objects
{
  public class Pet
  {
    [JsonProperty(PropertyName = "ID")]
    public int? Id { get; set; }
    [JsonProperty(PropertyName = "UserID")]
    public int? UserId { get; set; }
    public string Name { get; set; }
    [JsonProperty(PropertyName = "SourceID")]
    public int SourceId { get; set; }
    [Required]
    [JsonProperty(PropertyName = "PetTypeID")]
    public int? PetTypeId { get; set; }
    [JsonProperty(PropertyName = "BreedID")]
    public int? BreedId { get; set; }
    [JsonProperty(PropertyName = "FoodID")]
    public int? FoodId { get; set; }
    [JsonProperty(PropertyName = "DryFoodID")]
    public int? DryFoodId { get; set; }
    [JsonProperty(PropertyName = "WetFoodID")]
    public int? WetFoodId { get; set; }
    public string WetFoodFrequency { get; set; }
    public string DryFoodFrequency { get; set; }
    [JsonConverter(typeof(MonthDayYearDateConverter))]
    public DateTime? DateOfBirth { get; set; }
    [JsonConverter(typeof(MonthDayYearDateConverter))]
    public DateTime? DateOfAdoption { get; set; }
    public DateTime? Created { get; set; }
    public DateTime? Updated { get; set; }

    // TODO: PetPhotos
  }
}
