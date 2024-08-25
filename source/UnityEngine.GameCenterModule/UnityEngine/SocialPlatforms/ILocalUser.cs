using System;
using Cpp2ILInjected;

namespace UnityEngine.SocialPlatforms
{
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	public interface ILocalUser : IUserProfile
	{
		[global::Cpp2ILInjected.Token(Token = "0x600000C")]
		void Authenticate(Action<bool> callback);

		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		bool authenticated
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000D")]
			get;
		}
	}
}
