﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace Ankh.Api.Converters;

public sealed class NullIntConverter : JsonConverter<int> {
    public override bool HandleNull
        => true;
    
    public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
        try {
            var value = reader.GetInt32();
            return value;
        }
        catch {
            return 0;
        }
    }
    
    public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options) {
        throw new NotImplementedException();
    }
}