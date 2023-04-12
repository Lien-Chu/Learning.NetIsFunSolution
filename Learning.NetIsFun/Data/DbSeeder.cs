using Learning.NetIsFun.Constants;
using Learning.NetIsFun.Models;
using Microsoft.AspNetCore.Identity;

namespace Learning.NetIsFun.Data
{
	public class DbSeeder
	{
		public static async Task SeedDefaultData(IServiceProvider service)
		{
			var userMgr = service.GetService<UserManager<IdentityUser>>();
			var roleMgr = service.GetService<RoleManager<IdentityRole>>();

			// adding some roles to db

			await roleMgr.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
			await roleMgr.CreateAsync(new IdentityRole(Roles.User.ToString()));

			// create admin uesr
			var admin = new IdentityUser
			{
				// set admin  				
				UserName = "Admin@gmail.com",
				Email = "admin@gmail.com",
				EmailConfirmed = true
			};

			var UserInDb = await userMgr.FindByEmailAsync(admin.Email);
			if (UserInDb is null)
			{
				// set password
				await userMgr.CreateAsync(admin, "Admin@123");
				await userMgr.AddToRoleAsync(admin, Roles.Admin.ToString());
			}
		}
	}
}
