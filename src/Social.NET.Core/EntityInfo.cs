using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social.NET.Core
{
	public abstract class EntityInfo : IEntitySystemInfo
	{
		public AccessType Access { get; set; }

		public DateTime CreationTime { get; set; }

		public int Id { get; set; }

		public bool IsReadOnly { get; set; }

		public DateTime LastAccessTime { get; set; }

		public string LastEditor { get; set; }

		public DateTime LastWriteTime { get; set; }

		public string Name { get; set; }

		public string Owner { get; set; }

		public ICollection<string> Roles { get; set; }

		public ICollection<string> Users { get; set; }

		public byte[] Version { get; set; }

		public EntityInfo()
		{
			Roles = new List<string>();
			Users = new List<string>();
			CreationTime = LastAccessTime = LastWriteTime = DateTime.Now;
		}
	}
}
