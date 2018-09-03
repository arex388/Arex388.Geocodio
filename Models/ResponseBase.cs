namespace Arex388.Geocodio {
	public abstract class ResponseBase {
		public virtual bool Success { get; }
		public string Error { get; set; }
	}
}