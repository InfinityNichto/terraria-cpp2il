using System;
using Cpp2ILInjected;

namespace UnityEngine.SocialPlatforms
{
	// Token: 0x02000006 RID: 6
	[global::Cpp2ILInjected.Token(Token = "0x2000006")]
	public interface ILocalUser : IUserProfile
	{
		// Token: 0x0600000C RID: 12
		[global::Cpp2ILInjected.Token(Token = "0x600000C")]
		void Authenticate(Action<bool> callback);

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000D RID: 13
		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		bool authenticated
		{
			[global::Cpp2ILInjected.Token(Token = "0x600000D")]
			get;
		}
	}
}
