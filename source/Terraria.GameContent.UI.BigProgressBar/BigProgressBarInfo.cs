using Cpp2IlInjected;

namespace Terraria.GameContent.UI.BigProgressBar;

[Cpp2IlInjected.Token(Token = "0x20006FA")]
public struct BigProgressBarInfo
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400710B")]
	public int npcIndexToAimAt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400710C")]
	public bool validatedAtLeastOnce;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400710D")]
	public bool showText;
}
