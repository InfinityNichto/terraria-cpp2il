using System;
using Cpp2IlInjected;
using Terraria.Net;
using Terraria.Social.Base;

namespace Terraria.Social.Discord;

[Cpp2IlInjected.Token(Token = "0x200038E")]
public class RichPresenceSocialModule : ISocialModule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40031CF")]
	private RichPresenceState _lastState;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40031D0")]
	private Guid _uniquePartyId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40031D1")]
	private NetGroupInfo _infoAboutNetGroup;

	[Cpp2IlInjected.Token(Token = "0x6002D8C")]
	[Cpp2IlInjected.Address(RVA = "0x14E4A94", Offset = "0x14E4A94", VA = "0x14E4A94", Slot = "4")]
	public void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D8D")]
	[Cpp2IlInjected.Address(RVA = "0x14E4B78", Offset = "0x14E4B78", VA = "0x14E4B78", Slot = "5")]
	public void Shutdown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D8E")]
	[Cpp2IlInjected.Address(RVA = "0x14E4C2C", Offset = "0x14E4C2C", VA = "0x14E4C2C")]
	private void UpdatePresence()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D8F")]
	[Cpp2IlInjected.Address(RVA = "0x14E4C70", Offset = "0x14E4C70", VA = "0x14E4C70")]
	private void PublishPresence(RichPresenceState state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D90")]
	[Cpp2IlInjected.Address(RVA = "0x14E4D58", Offset = "0x14E4D58", VA = "0x14E4D58")]
	private bool ShouldAllowJoinRequests(RichPresenceState state)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002D91")]
	[Cpp2IlInjected.Address(RVA = "0x14E4D6C", Offset = "0x14E4D6C", VA = "0x14E4D6C")]
	private string GetJoinSecret()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002D92")]
	[Cpp2IlInjected.Address(RVA = "0x14E4D78", Offset = "0x14E4D78", VA = "0x14E4D78")]
	public RichPresenceSocialModule()
	{
	}
}
