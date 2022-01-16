using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class LoginDetail
{
	public string Email { get; set; }
	public string Secret { get; set; }
	
	public LoginDetail(string email, string secret)
	{
		//
		// TODO: Add constructor logic here
		//

		Email = email;
		Secret = secret;
	}
}
