using System;
using Cpp2IlInjected;
using Terraria.Social.Base;

namespace Terraria.Social.Discord;

[Cpp2IlInjected.Token(Token = "0x200038D")]
public class DiscordJoinToServerRequest : UserJoinToServerRequest, IEquatable<DiscordJoinToServerRequest>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40031CE")]
	private DateTime _expirationTime;

	[Cpp2IlInjected.Token(Token = "0x6002D88")]
	[Cpp2IlInjected.Address(RVA = "0x14E36A0", Offset = "0x14E36A0", VA = "0x14E36A0")]
	public DiscordJoinToServerRequest(string userDisplayName, string fullIdentifier, int durationInSeconds = 30)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D89")]
	[Cpp2IlInjected.Address(RVA = "0x14E3788", Offset = "0x14E3788", VA = "0x14E3788", Slot = "4")]
	public override bool IsValid()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D8A")]
	[Cpp2IlInjected.Address(RVA = "0x14E383C", Offset = "0x14E383C", VA = "0x14E383C", Slot = "5")]
	public override string GetUserWrapperText()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002D8B")]
	[Cpp2IlInjected.Address(RVA = "0x14E3950", Offset = "0x14E3950", VA = "0x14E3950", Slot = "6")]
	public bool Equals(DiscordJoinToServerRequest other)
	{
		return default(bool);
	}
}
