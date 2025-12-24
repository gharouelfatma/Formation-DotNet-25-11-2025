using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using Formatin_ECommercie_11_2025.Core.NotMappedEntities;

namespace Formation_ECommerce_11_2025.Core.Interfaces.External
{
	public interface IEmailSender
	{
		Task SendEmailAsync(EmailMessage emailMessage);
		Task SendWelcomeEmailAsync(string email, string username);
		Task SendPasswordResetEmailAsync(string email, string resetToken, string userId);
		Task SendEmailConfirmationAsync(string email, string confirmationToken, string userId);
	}
}

