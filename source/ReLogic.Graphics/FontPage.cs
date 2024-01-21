using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Graphics;

[Cpp2IlInjected.Token(Token = "0x200073A")]
internal sealed class FontPage
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400734D")]
	public readonly Texture2D Texture;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400734E")]
	public readonly List<Rectangle> Glyphs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400734F")]
	public readonly List<Rectangle> Padding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4007350")]
	public readonly List<char> Characters;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007351")]
	public readonly List<Vector3> Kerning;

	[Cpp2IlInjected.Token(Token = "0x6004740")]
	[Cpp2IlInjected.Address(RVA = "0x10C1458", Offset = "0x10C1458", VA = "0x10C1458")]
	public FontPage(Texture2D texture, List<Rectangle> glyphs, List<Rectangle> padding, List<char> characters, List<Vector3> kerning)
	{
	}
}
