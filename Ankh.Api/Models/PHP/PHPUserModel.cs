﻿using System.Text.Json.Serialization;
using Ankh.Api.Converters;
using Ankh.Api.Models.Interfaces;

namespace Ankh.Api.Models.PHP;

public sealed record PHPUserModel(
    [property: JsonPropertyName("viewer_cid")]
    long ViewerId,
    [property: JsonPropertyName("cid")]
    long UserId,
    [property: JsonPropertyName("is_buddy")]
    bool IsBuddy,
    [property: JsonPropertyName("is_friend")]
    bool IsFriend,
    [property: JsonPropertyName("is_qa")]
    bool IsQA,
    [property: JsonPropertyName("avname")]
    string Username,
    [property: JsonPropertyName("url")]
    Uri Url,
    [property: JsonPropertyName("avpic_url")]
    Uri AvatarUrl,
    [property: JsonPropertyName("registered")]
    DateTimeOffset Registered,
    [property: JsonPropertyName("last_login")]
    string LastLogin,
    [property: JsonPropertyName("interests")]
    Interests Interests,
    [property: JsonPropertyName("dating")]
    Dating Dating,
    [property: JsonPropertyName("gender")]
    string Gender,
    [property: JsonPropertyName("age")]
    string Age,
    [property: JsonPropertyName("tagline")]
    string Tagline,
    [property: JsonPropertyName("location")]
    string Location,
    [property: JsonPropertyName("country_code")]
    int CountryCode,
    [property: JsonPropertyName("location_state")]
    string LocationState,
    [property: JsonPropertyName("online")]
    bool IsOnline,
    [property: JsonPropertyName("availability")]
    string Availability,
    [property: JsonPropertyName("badge_count")]
    int BadgeCount,
    [property: JsonPropertyName("badge_level")]
    int BadgeLevel,
    [property: JsonPropertyName("badge_layout")]
    Dictionary<string, PHPBadgeModel> BadgeLayout,
    [property: JsonPropertyName("badge_area_html")]
    string BadgeAreaHtml,
    [property: JsonPropertyName("show_badgecount")]
    bool ShowBadgecount,
    [property: JsonPropertyName("show_flag_icon"),
               JsonConverter(typeof(IntToBoolConverter))]
    bool ShowFlagIcon,
    [property: JsonPropertyName("show_flag_av"),
               JsonConverter(typeof(IntToBoolConverter))]
    bool ShowFlagAv,
    [property: JsonPropertyName("show_message"),
               JsonConverter(typeof(IntToBoolConverter))]
    bool ShowMessage,
    [property: JsonPropertyName("avpic_default")]
    long AvpicDefault,
    [property: JsonPropertyName("show_block")]
    bool ShowBlock,
    [property: JsonPropertyName("welcome_moderator_score")]
    int WelcomeModeratorScore,
    [property: JsonPropertyName("is_welcome_moderator"),
               JsonConverter(typeof(IntToBoolConverter))]
    bool IsWelcomeModerator,
    [property: JsonPropertyName("public_rooms")]
    VURoomModel[] PublicRooms,
    [property: JsonPropertyName("visible_albums")]
    int VisibleAlbums
);

public record Dating(
    [property: JsonPropertyName("relationship_status")]
    string RelationshipStatus,
    [property: JsonPropertyName("orientation")]
    string Orientation,
    [property: JsonPropertyName("looking_for")]
    string LookingFor
);

public record Interests(
    [property: JsonPropertyName("full_text_string")]
    FullTextString FullTextString
);

public record FullTextString(
    [property: JsonPropertyName("tag")]
    string Tag,
    [property: JsonPropertyName("raw_tag")]
    string RawTag
);