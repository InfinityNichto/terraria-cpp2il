using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameInput;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Chat
{
	// Token: 0x020006EE RID: 1774
	[global::Cpp2ILInjected.Token(Token = "0x2000AD9")]
	public class GlyphTagHandler : ITagHandler
	{
		// Token: 0x0600453D RID: 17725 RVA: 0x0002E652 File Offset: 0x0002C852
		[global::Cpp2ILInjected.Token(Token = "0x60051A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x931DA8", Offset = "0x931DA8", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GlyphTagHandler.GlyphSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private TextSnippet Terraria.UI.Chat.ITagHandler.Parse(string text, Color baseColor, string options)
		{
			throw null;
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x0002E655 File Offset: 0x0002C855
		[global::Cpp2ILInjected.Token(Token = "0x60051A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x931F48", Offset = "0x931F48", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GlyphTagHandler), Member = "GenerateTag", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static string GenerateTag(int index)
		{
			throw null;
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x0002E658 File Offset: 0x0002C858
		[global::Cpp2ILInjected.Token(Token = "0x60051A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x931FE0", Offset = "0x931FE0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "GenerateGlyphList", MemberParameters = new object[] { typeof(List<string>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GlyphTagHandler), Member = "GenerateTag", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string GenerateTag(string keyname)
		{
			throw null;
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x0002E65B File Offset: 0x0002C85B
		[global::Cpp2ILInjected.Token(Token = "0x60051A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x932094", Offset = "0x932094", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public GlyphTagHandler()
		{
			throw null;
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x0002E65E File Offset: 0x0002C85E
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60051AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x93209C", Offset = "0x93209C", Length = "0x590")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static GlyphTagHandler()
		{
			throw null;
		}

		// Token: 0x040070E2 RID: 28898
		[global::Cpp2ILInjected.Token(Token = "0x4008A32")]
		private const int GlyphsPerLine = 25;

		// Token: 0x040070E3 RID: 28899
		[global::Cpp2ILInjected.Token(Token = "0x4008A33")]
		private const int MaxGlyphs = 26;

		// Token: 0x040070E4 RID: 28900
		[global::Cpp2ILInjected.Token(Token = "0x4008A34")]
		public static float GlyphsScale;

		// Token: 0x040070E5 RID: 28901
		[global::Cpp2ILInjected.Token(Token = "0x4008A35")]
		private static Dictionary<string, int> GlyphIndexes;

		// Token: 0x02000AC7 RID: 2759
		[global::Cpp2ILInjected.Token(Token = "0x2000ADA")]
		private class GlyphSnippet : TextSnippet
		{
			// Token: 0x06005295 RID: 21141 RVA: 0x00030905 File Offset: 0x0002EB05
			[global::Cpp2ILInjected.Token(Token = "0x60051AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x931EB4", Offset = "0x931EB4", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GlyphTagHandler), Member = "Terraria.UI.Chat.ITagHandler.Parse", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Color),
				typeof(string)
			}, ReturnType = typeof(TextSnippet))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextSnippet), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public GlyphSnippet(int index)
			{
				throw null;
			}

			// Token: 0x06005296 RID: 21142 RVA: 0x00030908 File Offset: 0x0002EB08
			[global::Cpp2ILInjected.Token(Token = "0x60051AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x93262C", Offset = "0x93262C", Length = "0x32C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(Color)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
			{
				typeof(Texture2D),
				typeof(Vector2),
				typeof(Rectangle?),
				typeof(Color),
				typeof(float),
				typeof(Vector2),
				typeof(float),
				typeof(SpriteEffects),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			public override bool UniqueDraw(bool justCheckingString, out Vector2 size, SpriteBatch spriteBatch, Vector2 position = default(Vector2), Color color = default(Color), float scale = 1f)
			{
				throw null;
			}

			// Token: 0x06005297 RID: 21143 RVA: 0x0003090B File Offset: 0x0002EB0B
			[global::Cpp2ILInjected.Token(Token = "0x60051AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x932958", Offset = "0x932958", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public override float GetStringLength(SpriteFont font)
			{
				throw null;
			}

			// Token: 0x04008F5C RID: 36700
			[global::Cpp2ILInjected.Token(Token = "0x4008A36")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
			private int _glyphIndex;
		}
	}
}
