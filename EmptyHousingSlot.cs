using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000156")]
public class EmptyHousingSlot
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000D0C")]
	public Color BackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000D0D")]
	public Color ItemColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000D0E")]
	public Texture_Layout HeadTexture;

	[Cpp2IlInjected.Token(Token = "0x6000B16")]
	[Cpp2IlInjected.Address(RVA = "0x20D1CD8", Offset = "0x20D1CD8", VA = "0x20D1CD8")]
	public EmptyHousingSlot()
	{
	}
}
