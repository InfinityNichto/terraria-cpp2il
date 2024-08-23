using System;
using Cpp2ILInjected;

namespace Terraria.Net
{
	// Token: 0x0200049E RID: 1182
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20006AB")]
	public enum ServerMode : byte
	{
		// Token: 0x04006559 RID: 25945
		[global::Cpp2ILInjected.Token(Token = "0x400795B")]
		None = 0,
		// Token: 0x0400655A RID: 25946
		[global::Cpp2ILInjected.Token(Token = "0x400795C")]
		Lobby = 1,
		// Token: 0x0400655B RID: 25947
		[global::Cpp2ILInjected.Token(Token = "0x400795D")]
		FriendsCanJoin = 2,
		// Token: 0x0400655C RID: 25948
		[global::Cpp2ILInjected.Token(Token = "0x400795E")]
		FriendsOfFriends = 4
	}
}
