using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006D7 RID: 1751
	[global::Cpp2ILInjected.Token(Token = "0x2000ABB")]
	public class UIImageFramed : UIElement, IColorable
	{
		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x0600449B RID: 17563 RVA: 0x0002E472 File Offset: 0x0002C672
		// (set) Token: 0x0600449C RID: 17564 RVA: 0x0002E475 File Offset: 0x0002C675
		[global::Cpp2ILInjected.Token(Token = "0x170008C5")]
		public Color Color
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60050ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x92A128", Offset = "0x92A128", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60050EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x92A130", Offset = "0x92A130", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600449D RID: 17565 RVA: 0x0002E478 File Offset: 0x0002C678
		[global::Cpp2ILInjected.Token(Token = "0x60050EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x92A138", Offset = "0x92A138", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public UIImageFramed(Asset<Texture2D> texture, Rectangle frame)
		{
			throw null;
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x0002E47B File Offset: 0x0002C67B
		[global::Cpp2ILInjected.Token(Token = "0x60050F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x92A21C", Offset = "0x92A21C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public void SetImage(Asset<Texture2D> texture, Rectangle frame)
		{
			throw null;
		}

		// Token: 0x0600449F RID: 17567 RVA: 0x0002E47E File Offset: 0x0002C67E
		[global::Cpp2ILInjected.Token(Token = "0x60050F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x92A268", Offset = "0x92A268", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementListItem), Member = "UpdateIconFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIImageFramed), Member = "SetFrame", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public void SetFrame(Rectangle frame)
		{
			throw null;
		}

		// Token: 0x060044A0 RID: 17568 RVA: 0x0002E481 File Offset: 0x0002C681
		[global::Cpp2ILInjected.Token(Token = "0x60050F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x92A2B0", Offset = "0x92A2B0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeItemsInfiniteFilteringOptions), Member = "UpdateVisuals", MemberParameters = new object[]
		{
			typeof(UIImageFramed),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "UpdateVisualFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "OffsetSize", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImageFramed), Member = "SetFrame", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetFrame(int frameCountHorizontal, int frameCountVertical, int frameX, int frameY, int sizeOffsetX, int sizeOffsetY)
		{
			throw null;
		}

		// Token: 0x060044A1 RID: 17569 RVA: 0x0002E484 File Offset: 0x0002C684
		[global::Cpp2ILInjected.Token(Token = "0x60050F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x92A37C", Offset = "0x92A37C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x04007066 RID: 28774
		[global::Cpp2ILInjected.Token(Token = "0x40089AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private Asset<Texture2D> _texture;

		// Token: 0x04007067 RID: 28775
		[global::Cpp2ILInjected.Token(Token = "0x40089AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private Rectangle _frame;

		// Token: 0x04007068 RID: 28776
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40089AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private Color <Color>k__BackingField;
	}
}
