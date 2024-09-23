namespace System.Threading;

internal static class CancellationTokenExtensions {
	public static bool IsSupportedAndCancelled(
		this CancellationToken cancellationToken) => cancellationToken is {
			CanBeCanceled: true,
			IsCancellationRequested: true
		};
}