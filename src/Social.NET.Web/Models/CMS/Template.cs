namespace Social.NET.Web.Models.CMS
{
	/// <summary>
	/// Шаблон.
	/// </summary>
	public class Template : Content
	{
		/// <summary>
		/// Содержание шаблона.
		/// </summary>
		public string Context { get; set; }

		/// <summary>
		/// Страница.
		/// </summary>
		public virtual Page Page { get; set; }
	}
}