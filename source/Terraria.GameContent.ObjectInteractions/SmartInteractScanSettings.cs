using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.ObjectInteractions;

[Cpp2IlInjected.Token(Token = "0x20005AB")]
public struct SmartInteractScanSettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006B43")]
	public Player player;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006B44")]
	public bool DemandOnlyZeroDistanceTargets;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4006B45")]
	public bool FullInteraction;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006B46")]
	public Vector2 mousevec;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006B47")]
	public int LX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006B48")]
	public int HX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006B49")]
	public int LY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006B4A")]
	public int HY;
}
