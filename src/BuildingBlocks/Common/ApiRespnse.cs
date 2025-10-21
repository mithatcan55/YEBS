namespace YEBS.BuildingBlocks.Common;

public record ApiResponse<T>(
bool Success,
string? Message = null,
string? TraceId = null,
T? Data = default,
Dictionary<string, string[]>? Errors = null
)
{
    public static ApiResponse<T> Ok(T datta, string? message = null, string? traceId = null) =>
        new ApiResponse<T>(true, message, traceId, datta);
    public static ApiResponse<T> Fail(string? message = null, string? traceId = null, Dictionary<string, string[]>? errors = null) =>
        new ApiResponse<T>(false, message, traceId, default, errors);
}