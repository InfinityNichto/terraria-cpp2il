using System;
using Cpp2IlInjected;

namespace Terraria.Social.Base;

[Cpp2IlInjected.Token(Token = "0x2000396")]
public class RichPresenceState : IEquatable<RichPresenceState>
{
	[Cpp2IlInjected.Token(Token = "0x20008E2")]
	public enum GameModeState
	{
		[Cpp2IlInjected.Token(Token = "0x400811C")]
		InMainMenu,
		[Cpp2IlInjected.Token(Token = "0x400811D")]
		CreatingPlayer,
		[Cpp2IlInjected.Token(Token = "0x400811E")]
		CreatingWorld,
		[Cpp2IlInjected.Token(Token = "0x400811F")]
		PlayingSingle,
		[Cpp2IlInjected.Token(Token = "0x4008120")]
		PlayingMulti
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40031D5")]
	public GameModeState GameMode;

	[Cpp2IlInjected.Token(Token = "0x6002DCD")]
	[Cpp2IlInjected.Address(RVA = "0x14DFCB0", Offset = "0x14DFCB0", VA = "0x14DFCB0", Slot = "4")]
	public bool Equals(RichPresenceState other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002DCE")]
	[Cpp2IlInjected.Address(RVA = "0x14DFCC8", Offset = "0x14DFCC8", VA = "0x14DFCC8")]
	public static RichPresenceState GetCurrentState()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002DCF")]
	[Cpp2IlInjected.Address(RVA = "0x14DFDB0", Offset = "0x14DFDB0", VA = "0x14DFDB0")]
	public RichPresenceState()
	{
	}
}
