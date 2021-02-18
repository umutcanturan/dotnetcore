using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCore.Common.Helpers
{
	public class AuthHelper
	{
		public static string Authenticate(string userId)
		{
			List<Claim> claims = new List<Claim>();
			claims.Add(new Claim(ClaimTypes.Role, "User", ClaimValueTypes.String, string.Empty));
			claims.Add(new Claim(ClaimTypes.Name, userId, ClaimValueTypes.Integer, string.Empty));
			claims.Add(new Claim(ClaimTypes.Email, userId, ClaimValueTypes.Integer, string.Empty));

			var identity = new ClaimsIdentity(claims, "sampleAuth");
			var principal = new ClaimsPrincipal(identity);

			claims.Add(new Claim(JwtRegisteredClaimNames.Sub, userId));
			claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString
				()));


			var token = new JwtSecurityToken
			(
				issuer: "dotnetapp",
				audience: "dotnetapp",
				claims: claims,
				expires: DateTime.UtcNow.AddDays(60),
				notBefore: DateTime.UtcNow,
				signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("{{THIS IS USED TO SIGN AND VERIFY JWT TOKENS, REPLACE IT WITH YOUR OWN SECRET, IT CAN BE ANY STRING}}")),
						SecurityAlgorithms.HmacSha256)
			);
			return new JwtSecurityTokenHandler().WriteToken(token);
		}



		public static DateTime GetExpireDate()
		{
			return DateTime.Now.AddDays(7);
		}

		public static bool IsEmail(string key)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(key);
				return addr.Address == key;
			}
			catch
			{
				return false;
			}
		}

	}
}
