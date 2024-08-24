using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.GameContent.UI.States;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006E7 RID: 1767
	[global::Cpp2ILInjected.Token(Token = "0x2000AD0")]
	public class UITextPanel<T> : UIPanel
	{
		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x0600451A RID: 17690 RVA: 0x0002E5E9 File Offset: 0x0002C7E9
		[global::Cpp2ILInjected.Token(Token = "0x170008D6")]
		public bool IsLarge
		{
			[global::Cpp2ILInjected.Token(Token = "0x600517D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1894F6C", Offset = "0x1894F6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x0600451B RID: 17691 RVA: 0x0002E5EC File Offset: 0x0002C7EC
		// (set) Token: 0x0600451C RID: 17692 RVA: 0x0002E5EF File Offset: 0x0002C7EF
		[global::Cpp2ILInjected.Token(Token = "0x170008D7")]
		public bool DrawPanel
		{
			[global::Cpp2ILInjected.Token(Token = "0x600517E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1894F74", Offset = "0x1894F74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600517F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1894F7C", Offset = "0x1894F7C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x0600451D RID: 17693 RVA: 0x0002E5F2 File Offset: 0x0002C7F2
		// (set) Token: 0x0600451E RID: 17694 RVA: 0x0002E5F5 File Offset: 0x0002C7F5
		[global::Cpp2ILInjected.Token(Token = "0x170008D8")]
		public float TextScale
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005180")]
			[global::Cpp2ILInjected.Address(RVA = "0x1894F88", Offset = "0x1894F88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6005181")]
			[global::Cpp2ILInjected.Address(RVA = "0x1894F90", Offset = "0x1894F90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x0600451F RID: 17695 RVA: 0x0002E5F8 File Offset: 0x0002C7F8
		[global::Cpp2ILInjected.Token(Token = "0x170008D9")]
		public Vector2 TextSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005182")]
			[global::Cpp2ILInjected.Address(RVA = "0x1894F98", Offset = "0x1894F98", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06004520 RID: 17696 RVA: 0x0002E5FB File Offset: 0x0002C7FB
		[global::Cpp2ILInjected.Token(Token = "0x170008DA")]
		public string Text
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005183")]
			[global::Cpp2ILInjected.Address(RVA = "0x1894FA4", Offset = "0x1894FA4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "get_Text", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "TypeText", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISearchBar), Member = "SetContents", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISearchBar), Member = "TrimDisplayIfOverElementDimensions", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextBox), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextBox), Member = "SetText", MemberParameters = new object[]
			{
				typeof(string),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextBox), Member = "Backspace", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextBox), Member = "CursorRight", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextBox), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06004521 RID: 17697 RVA: 0x0002E5FE File Offset: 0x0002C7FE
		// (set) Token: 0x06004522 RID: 17698 RVA: 0x0002E601 File Offset: 0x0002C801
		[global::Cpp2ILInjected.Token(Token = "0x170008DB")]
		public Color TextColor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005184")]
			[global::Cpp2ILInjected.Address(RVA = "0x1895004", Offset = "0x1895004", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6005185")]
			[global::Cpp2ILInjected.Address(RVA = "0x1895010", Offset = "0x1895010", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x0002E604 File Offset: 0x0002C804
		[global::Cpp2ILInjected.Token(Token = "0x6005186")]
		[global::Cpp2ILInjected.Address(RVA = "0x189501C", Offset = "0x189501C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementsMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "MakeExitButton", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIEmotesMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(UIVirtualKeyboard.KeyboardSubmitEvent),
			typeof(Action),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "CreateKeyboardButton", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(UITextPanel<object>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryInfoItemLine), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(DropRateInfo),
			typeof(BestiaryUICollectionInfo),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextBox), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public UITextPanel(T text, float textScale = 1f, bool large = false)
		{
			throw null;
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x0002E607 File Offset: 0x0002C807
		[global::Cpp2ILInjected.Token(Token = "0x6005187")]
		[global::Cpp2ILInjected.Address(RVA = "0x1895148", Offset = "0x1895148", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Recalculate", ReturnType = typeof(void))]
		public override void Recalculate()
		{
			throw null;
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x0002E60A File Offset: 0x0002C80A
		[global::Cpp2ILInjected.Token(Token = "0x6005188")]
		[global::Cpp2ILInjected.Address(RVA = "0x189517C", Offset = "0x189517C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "set_Text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "SetKeyState", MemberParameters = new object[] { typeof(UIVirtualKeyboard.KeyState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISearchBar), Member = "SetContents", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISearchBar), Member = "TrimDisplayIfOverElementDimensions", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextBox), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextBox), Member = "Backspace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetText(T text)
		{
			throw null;
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x0002E60D File Offset: 0x0002C80D
		[global::Cpp2ILInjected.Token(Token = "0x6005189")]
		[global::Cpp2ILInjected.Address(RVA = "0x1895194", Offset = "0x1895194", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextBox), Member = "SetText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFont), Member = "MeasureString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual void SetText(T text, float textScale, bool large)
		{
			throw null;
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x0002E610 File Offset: 0x0002C810
		[global::Cpp2ILInjected.Token(Token = "0x600518A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1895304", Offset = "0x1895304", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UITextBox), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x0002E613 File Offset: 0x0002C813
		[global::Cpp2ILInjected.Token(Token = "0x600518B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1895354", Offset = "0x1895354", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawBorderStringBig", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawBorderString", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void DrawText(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x040070B4 RID: 28852
		[global::Cpp2ILInjected.Token(Token = "0x4008A00")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected T _text;

		// Token: 0x040070B5 RID: 28853
		[global::Cpp2ILInjected.Token(Token = "0x4008A01")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected float _textScale;

		// Token: 0x040070B6 RID: 28854
		[global::Cpp2ILInjected.Token(Token = "0x4008A02")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected Vector2 _textSize;

		// Token: 0x040070B7 RID: 28855
		[global::Cpp2ILInjected.Token(Token = "0x4008A03")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected bool _isLarge;

		// Token: 0x040070B8 RID: 28856
		[global::Cpp2ILInjected.Token(Token = "0x4008A04")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected Color _color;

		// Token: 0x040070B9 RID: 28857
		[global::Cpp2ILInjected.Token(Token = "0x4008A05")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		protected bool _drawPanel;

		// Token: 0x040070BA RID: 28858
		[global::Cpp2ILInjected.Token(Token = "0x4008A06")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float TextHAlign;

		// Token: 0x040070BB RID: 28859
		[global::Cpp2ILInjected.Token(Token = "0x4008A07")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public bool HideContents;

		// Token: 0x040070BC RID: 28860
		[global::Cpp2ILInjected.Token(Token = "0x4008A08")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private string _asterisks;
	}
}
