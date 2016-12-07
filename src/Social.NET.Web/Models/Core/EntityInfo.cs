using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Social.NET.Web.Models.Core
{
	public abstract class EntityInfo : IEntitySystemInfo
	{
		public AccessType Access { get; set; }

		public DateTime CreationTime { get; set; }

		[Key]
		public int Id { get; set; }

		public bool IsReadOnly { get; set; }

		public DateTime LastAccessTime { get; set; }

		public string LastEditor { get; set; }

		public DateTime LastWriteTime { get; set; }

		[Required]
		public string Name { get; set; }

		public string Owner { get; set; }

		public List<IdentityRole> Roles { get; set; }

		public List<ApplicationUser> Users { get; set; }

		public byte[] Version { get; set; }

		public EntityInfo()
		{
			//Roles = new List<StringProperty>();
			Users = new List<ApplicationUser>();
			CreationTime = LastAccessTime = LastWriteTime = DateTime.Now;
		}

		/// <summary>
		/// Создать дубликат текущей сущности. Первая перегрузка.
		/// </summary>
		/// <returns>Дубликат текущей сущности.</returns>
		public abstract IEntitySystemInfo Duplicate();

		/// <summary>
		/// Создать дубликат текущей сущности. Вторая перегрузка.
		/// </summary>
		/// <param name="user">Текущий пользователь.</param>
		/// <returns>Дубликат текущей сущности.</returns>
		public abstract IEntitySystemInfo Duplicate(string user);
	}
}