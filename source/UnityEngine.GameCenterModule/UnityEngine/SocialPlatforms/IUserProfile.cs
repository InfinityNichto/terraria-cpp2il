using System;
using Cpp2ILInjected;

namespace UnityEngine.SocialPlatforms
{
	[global::Cpp2ILInjected.Token(Token = "0x2000008")]
	public interface IUserProfile
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000007")]
		string userName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000E")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		string id
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000F")]
			get;
		}
	}
}
