using Newtonsoft.Json.Converters;

namespace PProfileAPIClient.Converters
{
  public class MonthDayYearDateConverter : IsoDateTimeConverter
  {
    public MonthDayYearDateConverter()
    {
      DateTimeFormat = "yyyy-MM-dd";
    }
  }
}
