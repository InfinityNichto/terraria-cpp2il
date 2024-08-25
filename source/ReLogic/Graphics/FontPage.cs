using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B37")]
	internal sealed class FontPage
	{
		[global::Cpp2ILInjected.Token(Token = "0x60053BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x945A2C", Offset = "0x945A2C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public FontPage(Texture2D texture, List<Rectangle> glyphs, List<Rectangle> padding, List<char> characters, List<Vector3> kerning)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008CEB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Texture2D Texture;

		[global::Cpp2ILInjected.Token(Token = "0x4008CEC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly List<Rectangle> Glyphs;

		[global::Cpp2ILInjected.Token(Token = "0x4008CED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly List<Rectangle> Padding;

		[global::Cpp2ILInjected.Token(Token = "0x4008CEE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public readonly List<char> Characters;

		[global::Cpp2ILInjected.Token(Token = "0x4008CEF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public readonly List<Vector3> Kerning;
	}
}
