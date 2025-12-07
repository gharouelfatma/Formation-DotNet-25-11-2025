using System;
using Microsoft.AspNetCore.Identity;

namespace Formatin_ECommercie_11_2025.Core.Entities.Identity
{
	public class ApplicationUser : IdentityUser 
	{
		public int ZipCode{ get; set; }
        public string Adress { get; set; }
    }
}

