using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006E9 RID: 1769
	[global::Cpp2ILInjected.Token(Token = "0x2000AD2")]
	public class UIVerticalSeparator : UIElement
	{
		// Token: 0x0600452F RID: 17711 RVA: 0x0002E628 File Offset: 0x0002C828
		[global::Cpp2ILInjected.Token(Token = "0x6005192")]
		[global::Cpp2ILInjected.Address(RVA = "0x9301C8", Offset = "0x9301C8", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public UIVerticalSeparator()
		{
			throw null;
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x0002E62B File Offset: 0x0002C82B
		[global::Cpp2ILInjected.Token(Token = "0x6005193")]
		[global::Cpp2ILInjected.Address(RVA = "0x9303B0", Offset = "0x9303B0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x0002E62E File Offset: 0x0002C82E
		[global::Cpp2ILInjected.Token(Token = "0x6005194")]
		[global::Cpp2ILInjected.Address(RVA = "0x93042C", Offset = "0x93042C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool ContainsPoint(Vector2 point)
		{
			throw null;
		}

		// Token: 0x040070C4 RID: 28868
		[global::Cpp2ILInjected.Token(Token = "0x4008A10")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private Asset<Texture2D> _texture;

		// Token: 0x040070C5 RID: 28869
		[global::Cpp2ILInjected.Token(Token = "0x4008A11")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		public Color Color;

		// Token: 0x040070C6 RID: 28870
		[global::Cpp2ILInjected.Token(Token = "0x4008A12")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
		public int EdgeWidth;
	}
}
