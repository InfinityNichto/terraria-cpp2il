using System;
using Cpp2ILInjected;

namespace UnityEngine.SocialPlatforms
{
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	public interface ISocialPlatform
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		ILocalUser localUser
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000A")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600000B")]
		void Authenticate(ILocalUser user, Action<bool> callback);
	}
}
