using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.GameContent.UI.States;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006E1 RID: 1761
	[global::Cpp2ILInjected.Token(Token = "0x2000ACA")]
	public class UIScrollbar : UIElement
	{
		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060044CD RID: 17613 RVA: 0x0002E502 File Offset: 0x0002C702
		// (set) Token: 0x060044CE RID: 17614 RVA: 0x0002E505 File Offset: 0x0002C705
		[global::Cpp2ILInjected.Token(Token = "0x170008C9")]
		public float ViewPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005130")]
			[global::Cpp2ILInjected.Address(RVA = "0x92D35C", Offset = "0x92D35C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6005131")]
			[global::Cpp2ILInjected.Address(RVA = "0x92B6F0", Offset = "0x92B6F0", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryInfoPage), Member = "UpdateScrollbar", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(float))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060044CF RID: 17615 RVA: 0x0002E508 File Offset: 0x0002C708
		[global::Cpp2ILInjected.Token(Token = "0x170008CA")]
		public bool CanScroll
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005132")]
			[global::Cpp2ILInjected.Address(RVA = "0x92D364", Offset = "0x92D364", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "Recalculate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryInfoPage), Member = "CheckScrollBar", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060044D0 RID: 17616 RVA: 0x0002E50B File Offset: 0x0002C70B
		[global::Cpp2ILInjected.Token(Token = "0x6005133")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D378", Offset = "0x92D378", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public void GoToBottom()
		{
			throw null;
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x0002E50E File Offset: 0x0002C70E
		[global::Cpp2ILInjected.Token(Token = "0x6005134")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D3A8", Offset = "0x92D3A8", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementsMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryInfoPage), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "BuildInfinitesMenuContents", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public UIScrollbar()
		{
			throw null;
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x0002E511 File Offset: 0x0002C711
		[global::Cpp2ILInjected.Token(Token = "0x6005135")]
		[global::Cpp2ILInjected.Address(RVA = "0x92BB4C", Offset = "0x92BB4C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementsMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryEntryInfoPage), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIList), Member = "Recalculate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIList), Member = "UpdateScrollbar", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIList), Member = "SetScrollbar", MemberParameters = new object[] { typeof(UIScrollbar) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIList), Member = "UpdateOrder", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		public void SetView(float viewSize, float maxViewSize)
		{
			throw null;
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x0002E514 File Offset: 0x0002C714
		[global::Cpp2ILInjected.Token(Token = "0x6005136")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D5E0", Offset = "0x92D5E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float GetValue()
		{
			throw null;
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x0002E517 File Offset: 0x0002C717
		[global::Cpp2ILInjected.Token(Token = "0x6005137")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D5E8", Offset = "0x92D5E8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIScrollbar), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIScrollbar), Member = "LeftMouseDown", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private Rectangle GetHandleRectangle()
		{
			throw null;
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x0002E51A File Offset: 0x0002C71A
		[global::Cpp2ILInjected.Token(Token = "0x6005138")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D6A4", Offset = "0x92D6A4", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIScrollbar), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Rectangle?),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void DrawBar(SpriteBatch spriteBatch, Texture2D texture, Rectangle dimensions, Color color)
		{
			throw null;
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x0002E51D File Offset: 0x0002C71D
		[global::Cpp2ILInjected.Token(Token = "0x6005139")]
		[global::Cpp2ILInjected.Address(RVA = "0x92D8AC", Offset = "0x92D8AC", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIScrollbar), Member = "GetHandleRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIScrollbar), Member = "DrawBar", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Texture2D),
			typeof(Rectangle),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x0002E520 File Offset: 0x0002C720
		[global::Cpp2ILInjected.Token(Token = "0x600513A")]
		[global::Cpp2ILInjected.Address(RVA = "0x92DB30", Offset = "0x92DB30", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "LeftMouseDown", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIScrollbar), Member = "GetHandleRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void LeftMouseDown(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x060044D8 RID: 17624 RVA: 0x0002E523 File Offset: 0x0002C723
		[global::Cpp2ILInjected.Token(Token = "0x600513B")]
		[global::Cpp2ILInjected.Address(RVA = "0x92DC7C", Offset = "0x92DC7C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "LeftMouseUp", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void LeftMouseUp(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x04007086 RID: 28806
		[global::Cpp2ILInjected.Token(Token = "0x40089D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x144")]
		private float _viewPosition;

		// Token: 0x04007087 RID: 28807
		[global::Cpp2ILInjected.Token(Token = "0x40089D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private float _viewSize;

		// Token: 0x04007088 RID: 28808
		[global::Cpp2ILInjected.Token(Token = "0x40089D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14C")]
		private float _maxViewSize;

		// Token: 0x04007089 RID: 28809
		[global::Cpp2ILInjected.Token(Token = "0x40089D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private bool _isDragging;

		// Token: 0x0400708A RID: 28810
		[global::Cpp2ILInjected.Token(Token = "0x40089D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x151")]
		private bool _isHoveringOverHandle;

		// Token: 0x0400708B RID: 28811
		[global::Cpp2ILInjected.Token(Token = "0x40089D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
		private float _dragYOffset;

		// Token: 0x0400708C RID: 28812
		[global::Cpp2ILInjected.Token(Token = "0x40089D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private Asset<Texture2D> _texture;

		// Token: 0x0400708D RID: 28813
		[global::Cpp2ILInjected.Token(Token = "0x40089D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private Asset<Texture2D> _innerTexture;
	}
}
