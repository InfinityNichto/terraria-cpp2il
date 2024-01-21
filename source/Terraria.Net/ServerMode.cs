using System;
using Cpp2IlInjected;

namespace Terraria.Net;

[Cpp2IlInjected.Token(Token = "0x20004A1")]
[Flags]
public enum ServerMode : byte
{
	[Cpp2IlInjected.Token(Token = "0x400655A")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x400655B")]
	Lobby = 1,
	[Cpp2IlInjected.Token(Token = "0x400655C")]
	FriendsCanJoin = 2,
	[Cpp2IlInjected.Token(Token = "0x400655D")]
	FriendsOfFriends = 4
}
