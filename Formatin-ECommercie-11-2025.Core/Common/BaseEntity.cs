using System;
namespace Formatin_ECommercie_11_2025.Core.Common
{
	public class BaseEntity
	{
		public Guid Id { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? LastModifiedDate { get; set; }

    }
}

