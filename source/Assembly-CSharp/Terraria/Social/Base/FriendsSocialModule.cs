using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.Social.Base
{
	// Token: 0x0200038F RID: 911
	[global::Cpp2ILInjected.Token(Token = "0x200052A")]
	public abstract class FriendsSocialModule : ISocialModule
	{
		// Token: 0x06002D77 RID: 11639
		[global::Cpp2ILInjected.Token(Token = "0x60031D0")]
		public abstract string GetUsername();

		// Token: 0x06002D78 RID: 11640
		[global::Cpp2ILInjected.Token(Token = "0x60031D1")]
		public abstract void OpenJoinInterface();

		// Token: 0x06002D79 RID: 11641
		[global::Cpp2ILInjected.Token(Token = "0x60031D2")]
		public abstract void Initialize();

		// Token: 0x06002D7A RID: 11642
		[global::Cpp2ILInjected.Token(Token = "0x60031D3")]
		public abstract void Shutdown();

		// Token: 0x06002D7B RID: 11643 RVA: 0x0002A23C File Offset: 0x0002843C
		[global::Cpp2ILInjected.Token(Token = "0x60031D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x132ADC8", Offset = "0x132ADC8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected FriendsSocialModule()
		{
			throw null;
		}
	}
}
