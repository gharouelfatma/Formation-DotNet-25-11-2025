using Microsoft.AspNetCore.Identity;
using Formation_ECommerce_11_2025.Core.Entities.Cart;

namespace Formation_ECommerce_11_2025.Core.Entities.Identity;

public class ApplicationUser : IdentityUser 
{
	public int ZipCode{ get; set; }
    public string Adress { get; set; }
	public ICollection<CartHeader> CartHeaders { get; set; }
    }

