using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006E4 RID: 1764
	[global::Cpp2ILInjected.Token(Token = "0x2000ACD")]
	public class UISlicedImage : UIElement
	{
		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060044F2 RID: 17650 RVA: 0x0002E571 File Offset: 0x0002C771
		// (set) Token: 0x060044F3 RID: 17651 RVA: 0x0002E574 File Offset: 0x0002C774
		[global::Cpp2ILInjected.Token(Token = "0x170008CE")]
		public Color Color
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005155")]
			[global::Cpp2ILInjected.Address(RVA = "0x92EDA4", Offset = "0x92EDA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6005156")]
			[global::Cpp2ILInjected.Address(RVA = "0x92EDAC", Offset = "0x92EDAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060044F4 RID: 17652 RVA: 0x0002E577 File Offset: 0x0002C777
		[global::Cpp2ILInjected.Token(Token = "0x6005157")]
		[global::Cpp2ILInjected.Address(RVA = "0x92EDB4", Offset = "0x92EDB4", Length = "0xD4")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public UISlicedImage(Asset<Texture2D> texture)
		{
			throw null;
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x0002E57A File Offset: 0x0002C77A
		[global::Cpp2ILInjected.Token(Token = "0x6005158")]
		[global::Cpp2ILInjected.Address(RVA = "0x92EE88", Offset = "0x92EE88", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetImage(Asset<Texture2D> texture)
		{
			throw null;
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x0002E57D File Offset: 0x0002C77D
		[global::Cpp2ILInjected.Token(Token = "0x6005159")]
		[global::Cpp2ILInjected.Address(RVA = "0x92EE90", Offset = "0x92EE90", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawSplicedPanel", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x0002E580 File Offset: 0x0002C780
		[global::Cpp2ILInjected.Token(Token = "0x600515A")]
		[global::Cpp2ILInjected.Address(RVA = "0x92EFA0", Offset = "0x92EFA0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetSliceDepths(int top, int bottom, int left, int right)
		{
			throw null;
		}

		// Token: 0x060044F8 RID: 17656 RVA: 0x0002E583 File Offset: 0x0002C783
		[global::Cpp2ILInjected.Token(Token = "0x600515B")]
		[global::Cpp2ILInjected.Address(RVA = "0x92EFB4", Offset = "0x92EFB4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetSliceDepths(int fluff)
		{
			throw null;
		}

		// Token: 0x0400709B RID: 28827
		[global::Cpp2ILInjected.Token(Token = "0x40089E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private Asset<Texture2D> _texture;

		// Token: 0x0400709C RID: 28828
		[global::Cpp2ILInjected.Token(Token = "0x40089E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private Color _color;

		// Token: 0x0400709D RID: 28829
		[global::Cpp2ILInjected.Token(Token = "0x40089E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
		private int _leftSliceDepth;

		// Token: 0x0400709E RID: 28830
		[global::Cpp2ILInjected.Token(Token = "0x40089EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private int _rightSliceDepth;

		// Token: 0x0400709F RID: 28831
		[global::Cpp2ILInjected.Token(Token = "0x40089EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15C")]
		private int _topSliceDepth;

		// Token: 0x040070A0 RID: 28832
		[global::Cpp2ILInjected.Token(Token = "0x40089EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private int _bottomSliceDepth;
	}
}
