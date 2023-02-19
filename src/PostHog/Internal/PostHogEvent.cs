﻿namespace PostHog.Internal;

internal sealed class PostHogEvent
{
    public string Event { get; set; } = default!;
    public Dictionary<string, object>? Properties { get; set; }
    public string Timestamp { get; set; } = default!;
}