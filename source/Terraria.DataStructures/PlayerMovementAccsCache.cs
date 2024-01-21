using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x200044F")]
public struct PlayerMovementAccsCache
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40063F2")]
	private bool _readyToPaste;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x40063F3")]
	private bool _mountPreventedFlight;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x40063F4")]
	private bool _mountPreventedExtraJumps;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40063F5")]
	private int rocketTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40063F6")]
	private float wingTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40063F7")]
	private int rocketDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40063F8")]
	private int rocketDelay2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40063F9")]
	private bool jumpAgainCloud;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40063FA")]
	private bool jumpAgainSandstorm;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x40063FB")]
	private bool jumpAgainBlizzard;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17")]
	[Cpp2IlInjected.Token(Token = "0x40063FC")]
	private bool jumpAgainFart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40063FD")]
	private bool jumpAgainSail;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x40063FE")]
	private bool jumpAgainUnicorn;

	[Cpp2IlInjected.Token(Token = "0x60031F9")]
	[Cpp2IlInjected.Address(RVA = "0x39D968", Offset = "0x39D968", VA = "0x39D968")]
	public void CopyFrom(Player player)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60031FA")]
	[Cpp2IlInjected.Address(RVA = "0x39D970", Offset = "0x39D970", VA = "0x39D970")]
	public void PasteInto(Player player)
	{
	}
}
