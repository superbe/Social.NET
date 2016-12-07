namespace Social.NET.Core
{
	/// <summary>
	/// Ключевые слова.
	/// </summary>
	public class Tag : EntityInfo
	{
		///// <summary>
		///// Идентификатор.
		///// </summary>
		////[Key]
		////[HiddenInput]
		////[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		//public int Id { get; set; }

		/// <summary>
		/// Лексическая единица.
		/// </summary>
		//[DisplayName("Тег")]
		public string Word { get; set; }
	}
}