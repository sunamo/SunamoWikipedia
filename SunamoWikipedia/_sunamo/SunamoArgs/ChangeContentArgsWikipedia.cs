namespace SunamoWikipedia._sunamo.SunamoArgs;

/// <summary>
/// Arguments for changing Wikipedia content with optional transformations.
/// </summary>
internal class ChangeContentArgsWikipedia
{
    /// <summary>
    /// Gets or sets a value indicating whether null values should be removed.
    /// </summary>
    internal bool IsRemovingNull { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether empty values should be removed.
    /// </summary>
    internal bool IsRemovingEmpty { get; set; } = false;

    /// <summary>
    /// Gets or sets a value indicating whether the first and second arguments should be switched.
    /// </summary>
    internal bool IsSwitchingFirstAndSecondArg { get; set; } = false;
}
