using System;
namespace Formatin_ECommercie_11_2025.Core.NotMappedEntities
{
	public class EmailMessage
	{
		public string To { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }
		public bool IsHtml { get; set; } = true;
		public List<string> Attachments { get; set; } = new List<string>();
	}
}

