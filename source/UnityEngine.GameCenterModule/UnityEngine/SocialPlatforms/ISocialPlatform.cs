using System;
using Cpp2ILInjected;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x02000005 RID: 5
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	public interface ISocialPlatform
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10
		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		ILocalUser localUser
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000A")]
			get;
		}

		// Token: 0x0600000B RID: 11
		[global::Cpp2ILInjected.Token(Token = "0x600000B")]
		void Authenticate(ILocalUser user, Action<bool> callback);
	}
}
