using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ReLogic.Graphics
{
	// Token: 0x02000737 RID: 1847
	[global::Cpp2ILInjected.Token(Token = "0x2000B37")]
	internal sealed class FontPage
	{
		// Token: 0x06004701 RID: 18177 RVA: 0x0002EB0B File Offset: 0x0002CD0B
		[global::Cpp2ILInjected.Token(Token = "0x60053BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x945A2C", Offset = "0x945A2C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public FontPage(Texture2D texture, List<Rectangle> glyphs, List<Rectangle> padding, List<char> characters, List<Vector3> kerning)
		{
			throw null;
		}

		// Token: 0x0400734C RID: 29516
		[global::Cpp2ILInjected.Token(Token = "0x4008CEB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Texture2D Texture;

		// Token: 0x0400734D RID: 29517
		[global::Cpp2ILInjected.Token(Token = "0x4008CEC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly List<Rectangle> Glyphs;

		// Token: 0x0400734E RID: 29518
		[global::Cpp2ILInjected.Token(Token = "0x4008CED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public readonly List<Rectangle> Padding;

		// Token: 0x0400734F RID: 29519
		[global::Cpp2ILInjected.Token(Token = "0x4008CEE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public readonly List<char> Characters;

		// Token: 0x04007350 RID: 29520
		[global::Cpp2ILInjected.Token(Token = "0x4008CEF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public readonly List<Vector3> Kerning;
	}
}
