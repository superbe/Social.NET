using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Social.NET.Web.Models.Core
{
	/// <summary>
	/// Интерфейс сущности.
	/// </summary>
	public interface IEntitySystemInfo
	{
		/// <summary>
		/// Идентификатор сущности.
		/// </summary>
		int Id { get; set; }

		/// <summary>
		/// Получает или задает атрибуты для текущей сущности.
		/// </summary>
		DateTime CreationTime { get; set; }

		/// <summary>
		/// Получает или задает время последнего доступа к текущей сущности.
		/// </summary>
		DateTime LastAccessTime { get; set; }

		/// <summary>
		/// Получает или задает время последней операции записи в текущую сущность.
		/// </summary>
		DateTime LastWriteTime { get; set; }

		/// <summary>
		/// Возвращает или задает значение, позволяющее определить, является ли текущая сущность доступной только для чтения.
		/// </summary>
		bool IsReadOnly { get; set; }

		/// <summary>
		/// Получает или задает идентификатор пользователя являющегося собственником текущей сущности.
		/// </summary>
		string Owner { get; set; }

		/// <summary>
		/// Получает или задает идентификатор последнего пользователя отредатировавшего текущую сущность.
		/// </summary>
		string LastEditor { get; set; }

		/// <summary>
		/// Версия сущности.
		/// </summary>
		byte[] Version { get; set; }

		/// <summary>
		/// Имя сущности.
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// Получает или задает идентификаторы ролей для которых доступна текущая сущность.
		/// </summary>
		List<IdentityRole> Roles { get; set; }

		/// <summary>
		/// Получает или задает идентификаторы пользователей для которых доступна текущая сущность.
		/// </summary>
		List<ApplicationUser> Users { get; set; }

		/// <summary>
		/// Получает или задает доступность текущей сущности.
		/// </summary>
		AccessType Access { get; set; }

		/// <summary>
		/// Создать дубликат текущей сущности. Первая перегрузка.
		/// </summary>
		/// <returns>Дубликат текущей сущности.</returns>
		IEntitySystemInfo Duplicate();

		/// <summary>
		/// Создать дубликат текущей сущности. Вторая перегрузка.
		/// </summary>
		/// <param name="user">Текущий пользователь.</param>
		/// <returns>Дубликат текущей сущности.</returns>
		IEntitySystemInfo Duplicate(string user);
	}
}