//using Social.NET.Core;
using Social.NET.Web.Models.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social.NET.Web.Models.CMS
{
	/// <summary>
	/// Раздел классификатора.
	/// </summary>
	public class MenuItem : EntityInfo
	{
		private string _code;

		/// <summary>
		/// Родительский раздел классификатора.
		/// </summary>
		public int? ParentId { get; set; }
		[ForeignKey("ParentId")]
		public virtual MenuItem Parent { get; set; }

		/// <summary>
		/// Дочерние узлы раздела классификатора.
		/// </summary>
		public virtual List<MenuItem> Childs { get; set; }

		/// <summary>
		/// Наименование раздела классификатора.
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// URL страницы.
		/// </summary>
		public string PageURL { get; set; }

		/// <summary>
		/// Id страницы.
		/// </summary>
		public string PageId { get; set; }

		/// <summary>
		/// Конструктор.
		/// </summary>
		public MenuItem()
		{
			Childs = new List<MenuItem>();
			//CreationTime = LastWriteTime = LastAccessTime = DateTime.Now;
		}

		public override IEntitySystemInfo Duplicate()
		{
			throw new NotImplementedException();
		}

		public override IEntitySystemInfo Duplicate(string user)
		{
			throw new NotImplementedException();
		}
	}
}