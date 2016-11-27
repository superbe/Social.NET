namespace Social.NET.CMS
{
	/// <summary>
	/// Ключевые слова.
	/// </summary>
	public class Tag
	{
		/// <summary>
		/// Идентификатор.
		/// </summary>
		//[Key]
		//[HiddenInput]
		//[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		/// <summary>
		/// Лексическая единица.
		/// </summary>
		//[DisplayName("Тег")]
		public string Word { get; set; }
	}
}