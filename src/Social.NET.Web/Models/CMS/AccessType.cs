namespace Social.NET.Web.Models.CMS
{
	/// <summary>
	/// Вид доступности страницы.
	/// </summary>
	public enum AccessType
	{
		/// <summary>
		/// Черновик.
		/// </summary>
		Draft,

		/// <summary>
		/// Опубликован.
		/// </summary>
		Published,

		/// <summary>
		/// В архиве.
		/// </summary>
		Archive,
	}
}