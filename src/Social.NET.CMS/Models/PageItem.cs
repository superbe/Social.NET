namespace Social.NET.CMS
{
	/// <summary>
	/// Шаблонное текстовое содержание страницы.
	/// </summary>
	public class PageItem : Content
	{
		/// <summary>
		/// Содержание шаблонного блока.
		/// </summary>
		public string Context { get; set; }

		/// <summary>
		/// Ключ области содержания в шаблоне.
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// Страница.
		/// </summary>
		public virtual Page Page { get; set; }
	}
}