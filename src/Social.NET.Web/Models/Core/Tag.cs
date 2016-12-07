using System;

namespace Social.NET.Web.Models.Core
{
	/// <summary>
	/// Ключевые слова.
	/// </summary>
	public class Tag : EntityInfo
	{
		/// <summary>
		/// Лексическая единица.
		/// </summary>
		//[DisplayName("Тег")]
		public string Word { get; set; }

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