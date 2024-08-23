using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;
using Terraria.UI.Chat;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006DB RID: 1755
	[global::Cpp2ILInjected.Token(Token = "0x2000AC0")]
	public class UIKeybindingToggleListItem : UIElement
	{
		// Token: 0x060044A8 RID: 17576 RVA: 0x0002E493 File Offset: 0x0002C693
		[global::Cpp2ILInjected.Token(Token = "0x60050FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x92AB38", Offset = "0x92AB38", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public UIKeybindingToggleListItem(Func<string> getText, Func<bool> getStatus, Color color)
		{
			throw null;
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x0002E496 File Offset: 0x0002C696
		[global::Cpp2ILInjected.Token(Token = "0x60050FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x92ADCC", Offset = "0x92ADCC", Length = "0x5CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "MultiplyRGBA", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DrawSettingsPanel", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChatManager), Member = "DrawColorCodedStringWithShadow", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(SpriteFont),
			typeof(string),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
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
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x0400706D RID: 28781
		[global::Cpp2ILInjected.Token(Token = "0x40089B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x141")]
		private Color _color;

		// Token: 0x0400706E RID: 28782
		[global::Cpp2ILInjected.Token(Token = "0x40089B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private Func<string> _TextDisplayFunction;

		// Token: 0x0400706F RID: 28783
		[global::Cpp2ILInjected.Token(Token = "0x40089B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private Func<bool> _IsOnFunction;

		// Token: 0x04007070 RID: 28784
		[global::Cpp2ILInjected.Token(Token = "0x40089B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private Asset<Texture2D> _toggleTexture;

		// Token: 0x02000AC1 RID: 2753
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000AC1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005281 RID: 21121 RVA: 0x000308D5 File Offset: 0x0002EAD5
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60050FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x92B398", Offset = "0x92B398", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06005282 RID: 21122 RVA: 0x000308D8 File Offset: 0x0002EAD8
			[global::Cpp2ILInjected.Token(Token = "0x6005100")]
			[global::Cpp2ILInjected.Address(RVA = "0x92B3F4", Offset = "0x92B3F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06005283 RID: 21123 RVA: 0x000308DB File Offset: 0x0002EADB
			[global::Cpp2ILInjected.Token(Token = "0x6005101")]
			[global::Cpp2ILInjected.Address(RVA = "0x92B3FC", Offset = "0x92B3FC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string <.ctor>b__4_0()
			{
				throw null;
			}

			// Token: 0x06005284 RID: 21124 RVA: 0x000308DE File Offset: 0x0002EADE
			[global::Cpp2ILInjected.Token(Token = "0x6005102")]
			[global::Cpp2ILInjected.Address(RVA = "0x92B43C", Offset = "0x92B43C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <.ctor>b__4_1()
			{
				throw null;
			}

			// Token: 0x04008F55 RID: 36693
			[global::Cpp2ILInjected.Token(Token = "0x40089BA")]
			public static readonly UIKeybindingToggleListItem.<>c <>9;

			// Token: 0x04008F56 RID: 36694
			[global::Cpp2ILInjected.Token(Token = "0x40089BB")]
			public static Func<string> <>9__4_0;

			// Token: 0x04008F57 RID: 36695
			[global::Cpp2ILInjected.Token(Token = "0x40089BC")]
			public static Func<bool> <>9__4_1;
		}
	}
}
