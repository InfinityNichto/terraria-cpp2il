using Cpp2IlInjected;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Bestiary;

[Cpp2IlInjected.Token(Token = "0x2000622")]
public struct EntryIconDrawSettings
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4006C4D")]
	public bool IsPortrait;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4006C4E")]
	public bool IsHovered;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4006C4F")]
	public Rectangle iconbox;
}
