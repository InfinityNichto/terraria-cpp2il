using System;
using Cpp2ILInjected;

namespace Terraria.Net
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20006AB")]
	public enum ServerMode : byte
	{
		[global::Cpp2ILInjected.Token(Token = "0x400795B")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x400795C")]
		Lobby = 1,
		[global::Cpp2ILInjected.Token(Token = "0x400795D")]
		FriendsCanJoin = 2,
		[global::Cpp2ILInjected.Token(Token = "0x400795E")]
		FriendsOfFriends = 4
	}
}
