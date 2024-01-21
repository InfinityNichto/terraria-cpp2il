using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat;

[Cpp2IlInjected.Token(Token = "0x20006F1")]
public class GlyphTagHandler : ITagHandler
{
	[Cpp2IlInjected.Token(Token = "0x2000ABE")]
	private class GlyphSnippet : TextSnippet
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008F49")]
		private int _glyphIndex;

		[Cpp2IlInjected.Token(Token = "0x60052CC")]
		[Cpp2IlInjected.Address(RVA = "0x1182B60", Offset = "0x1182B60", VA = "0x1182B60")]
		public GlyphSnippet(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60052CD")]
		[Cpp2IlInjected.Address(RVA = "0x1183744", Offset = "0x1183744", VA = "0x1183744", Slot = "8")]
		public override bool UniqueDraw(bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, [Optional] Vector2 position, [Optional] Color color, float scale = 1f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60052CE")]
		[Cpp2IlInjected.Address(RVA = "0x1183B50", Offset = "0x1183B50", VA = "0x1183B50", Slot = "10")]
		public override float GetStringLength(SpriteFont font)
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40070E3")]
	private const int GlyphsPerLine = 25;

	[Cpp2IlInjected.Token(Token = "0x40070E4")]
	private const int MaxGlyphs = 26;

	[Cpp2IlInjected.Token(Token = "0x40070E5")]
	public static float GlyphsScale;

	[Cpp2IlInjected.Token(Token = "0x40070E6")]
	private static Dictionary<string, int> GlyphIndexes;

	[Cpp2IlInjected.Token(Token = "0x600457C")]
	[Cpp2IlInjected.Address(RVA = "0x1182A44", Offset = "0x1182A44", VA = "0x1182A44", Slot = "4")]
	TextSnippet ITagHandler.Parse(string text, Color baseColor, string options)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600457D")]
	[Cpp2IlInjected.Address(RVA = "0x1182C04", Offset = "0x1182C04", VA = "0x1182C04")]
	public static string GenerateTag(int index)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600457E")]
	[Cpp2IlInjected.Address(RVA = "0x1182D88", Offset = "0x1182D88", VA = "0x1182D88")]
	public static string GenerateTag(string keyname)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600457F")]
	[Cpp2IlInjected.Address(RVA = "0x1182E6C", Offset = "0x1182E6C", VA = "0x1182E6C")]
	public GlyphTagHandler()
	{
	}
}
