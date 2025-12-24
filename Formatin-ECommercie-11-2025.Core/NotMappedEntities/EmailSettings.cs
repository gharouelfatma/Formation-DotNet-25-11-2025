using System;
namespace Formatin_ECommercie_11_2025.Core.NotMappedEntities
{
	public class EmailSettings
	{
		public string SmtpServer { get; set; }
		public int SmtpPort { get; set; }
		public string SmtpUserName { get; set; }
		public string SmtpPassword { get; set; }
		public string SenderName { get; set; }
		public string SenderEmail { get; set; }
		public bool EnableSsl { get; set; }
	}
}

