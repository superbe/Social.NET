//using System.Collections.Generic;

namespace Social.NET.CMS
{
	/// <summary>
	/// Страница.
	/// </summary>
	public class Page : Content
	{
		/// <summary>
		/// Наименование страницы в адресной строке.
		/// </summary>
		//[DisplayName("Наименование в адресной строке")]
		public string Name { get; set; }

		/// <summary>
		/// Титла страницы.
		/// </summary>
		//[DisplayName("Титла")]
		public string Title { get; set; }

		/// <summary>
		/// Описание страницы.
		/// </summary>
		//[DisplayName("Описание")]
		public string Description { get; set; }

		/// <summary>
		/// Скрипт.
		/// </summary>
		public string Script { get; set; }

		/// <summary>
		/// Ссылки на внешние скрипты.
		/// </summary>
		//public string[] Scripts { get; set; }

		/// <summary>
		/// Стиль.
		/// </summary>
		public string Style { get; set; }

		/// <summary>
		/// Ссылки на внешние стили.
		/// </summary>
		//public string[] Styles { get; set; }

		/// <summary>
		/// Шаблон страницы.
		/// </summary>
		public virtual Template Template { get; set; }

		/// <summary>
		/// Текстовое содержание блоков шаблона.
		/// </summary>
		public virtual PageItem[] PageItems { get; set; }

		/// <summary>
		/// Текст страницы.
		/// </summary>
		//[DisplayName("Текст")]
		public string Text { get; set; }
	}
}