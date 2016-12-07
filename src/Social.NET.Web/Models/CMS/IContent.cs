using System;
using System.Collections.Generic;

namespace Social.NET.Web.Models.CMS
{
	/// <summary>
	/// Интерфейс общего класса.
	/// </summary>
	public interface IContent
	{
		/// <summary>
		/// Идентификатор.
		/// </summary>
		int Id { get; set; }

		/// <summary>
		/// Роли которым разрешен доступ.
		/// </summary>
		//string[] Roles { get; set; }

		/// <summary>
		/// Дата создания.
		/// </summary>
		DateTime Created { get; set; }

		/// <summary>
		/// Дата последнего изменения.
		/// </summary>
		DateTime Changed { get; set; }

		/// <summary>
		/// Собственник.
		/// </summary>
		string Owner { get; set; }

		/// <summary>
		/// Версия объекта.
		/// </summary>
		byte[] Version { get; set; }
	}
}