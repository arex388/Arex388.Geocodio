namespace Arex388.Geocodio {
	public abstract class ResponseBase {
		public virtual bool Success { get; }
		public string Error { get; set; }

		public static T Invalid<T>()
			where T : ResponseBase, new() => new T {
				Error = "The request is invalid."
			};
	}
}