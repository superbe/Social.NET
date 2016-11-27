using System;
using System.Collections.Generic;

namespace Social.NET.CMS
{
	/// <summary>
	/// Базовый класс большинства публикуемых объектов.
	/// </summary>
	public class Content : IContent
	{
		/// <summary>
		/// Идентификатор.
		/// </summary>
		//[Key]
		//[HiddenInput]
		//[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		/// <summary>
		/// Роли которым разрешен доступ.
		/// </summary>
		//public List<Roles> Roles { get; set; }

		/// <summary>
		/// Дата создания.
		/// </summary>
		public DateTime Created { get; set; }

		/// <summary>
		/// Дата последнего изменения.
		/// </summary>
		public DateTime Changed { get; set; }

		/// <summary>
		/// Собственник.
		/// </summary>
		public string UserId { get; set; }

		//public Content()
		//{
		//	Roles = new List<string>();
		//}
	}
}