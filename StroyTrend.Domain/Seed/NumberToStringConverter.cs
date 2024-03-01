using System.Text.Json;
using System.Text.Json.Serialization;

namespace StroyTrend.Domain.Seed;

public class NumberToStringConverter : JsonConverter<string>
{
    public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Number)
        {
            using (var document = JsonDocument.ParseValue(ref reader))
            {
                return document.RootElement.GetRawText();
            }
        }

        if (reader.TokenType == JsonTokenType.String)
        {
            return reader.GetString();
        }

        throw new InvalidOperationException("The JSON value is not a number or a string.");
    }

    public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value);
    }
}