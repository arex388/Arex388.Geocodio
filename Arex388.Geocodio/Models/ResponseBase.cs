namespace Arex388.Geocodio; 

/// <summary>
/// The response base.
/// </summary>
public abstract class ResponseBase {
    /// <summary>
    /// The response error if the request failed.
    /// </summary>
    public string ResponseError { get; set; }

    /// <summary>
    /// The response JSON if debugging is enabled.
    /// </summary>
    public string ResponseJson { get; set; }

    /// <summary>
    /// The response status.
    /// </summary>
    public ResponseStatus ResponseStatus { get; set; } = ResponseStatus.Success;
}