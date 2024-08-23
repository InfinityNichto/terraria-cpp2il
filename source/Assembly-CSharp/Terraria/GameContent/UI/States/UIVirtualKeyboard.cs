using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.GameContent.UI.Elements;
using Terraria.GameInput;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.States
{
	// Token: 0x020006A7 RID: 1703
	[global::Cpp2ILInjected.Token(Token = "0x2000A77")]
	public class UIVirtualKeyboard : UIState
	{
		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06004300 RID: 17152 RVA: 0x0002DFB3 File Offset: 0x0002C1B3
		// (set) Token: 0x06004301 RID: 17153 RVA: 0x0002DFB6 File Offset: 0x0002C1B6
		[global::Cpp2ILInjected.Token(Token = "0x170008A9")]
		public string Text
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004F19")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F6DBC", Offset = "0x8F6DBC", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(UIVirtualKeyboard.KeyboardSubmitEvent),
				typeof(Action),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "PressSpace", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "TypeText", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "TextIsValidForSubmit", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "InternalSubmit", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "CopyTextToSign", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "CopyTextToChest", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "<.ctor>b__50_14", MemberParameters = new object[]
			{
				typeof(UIMouseEvent),
				typeof(UIElement)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "get_Text", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6004F1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F6E04", Offset = "0x8F6E04", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(UIVirtualKeyboard.KeyboardSubmitEvent),
				typeof(Action),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "RestoreCanceledInput", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "SetText", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06004302 RID: 17154 RVA: 0x0002DFB9 File Offset: 0x0002C1B9
		// (set) Token: 0x06004303 RID: 17155 RVA: 0x0002DFBC File Offset: 0x0002C1BC
		[global::Cpp2ILInjected.Token(Token = "0x170008AA")]
		public bool HideContents
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004F1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F6FF8", Offset = "0x8F6FF8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6004F1C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F7004", Offset = "0x8F7004", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x0002DFBF File Offset: 0x0002C1BF
		[global::Cpp2ILInjected.Token(Token = "0x6004F1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EE5B8", Offset = "0x8EE5B8", Length = "0x13D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IngameFancyUI), Member = "OpenVirtualKeyboard", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIBestiaryTest), Member = "OpenVirtualKeyboardWhenNeeded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "OpenVirtualKeyboardWhenNeeded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToInt", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "SetPadding", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIPanel), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextBox), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "CreateKeyboardButton", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(UITextPanel<object>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOut", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIImage), Member = ".ctor", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "BuildSpaceBarArea", MemberParameters = new object[] { typeof(UIPanel) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "ValidateText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "StyleKey", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"Terraria.GameContent.UI.Elements.UITextPanel`1<T>",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "set_Text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "SetKeyState", MemberParameters = new object[] { typeof(UIVirtualKeyboard.KeyState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "UpdateOffsetDown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 108)]
		public UIVirtualKeyboard(string labelText, string startingText, UIVirtualKeyboard.KeyboardSubmitEvent submitAction, Action cancelAction, int inputMode = 0, bool allowEmpty = false)
		{
			throw null;
		}

		// Token: 0x06004305 RID: 17157 RVA: 0x0002DFC2 File Offset: 0x0002C1C2
		[global::Cpp2ILInjected.Token(Token = "0x6004F1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8EF98C", Offset = "0x8EF98C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICreativeInfiniteItemsDisplay), Member = "OpenVirtualKeyboardWhenNeeded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void SetMaxInputLength(int length)
		{
			throw null;
		}

		// Token: 0x06004306 RID: 17158 RVA: 0x0002DFC5 File Offset: 0x0002C1C5
		[global::Cpp2ILInjected.Token(Token = "0x6004F1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F71A4", Offset = "0x8F71A4", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(UIVirtualKeyboard.KeyboardSubmitEvent),
			typeof(Action),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "CanRestore", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "CreateKeyboardButton", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(UITextPanel<object>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void BuildSpaceBarArea(UIPanel mainPanel)
		{
			throw null;
		}

		// Token: 0x06004307 RID: 17159 RVA: 0x0002DFC8 File Offset: 0x0002C1C8
		[global::Cpp2ILInjected.Token(Token = "0x6004F20")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F76E4", Offset = "0x8F76E4", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard.<>c__DisplayClass52_0), Member = "<BuildSpaceBarArea>b__1", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextBox), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "ValidateText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void PressSpace()
		{
			throw null;
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x0002DFCB File Offset: 0x0002C1CB
		[global::Cpp2ILInjected.Token(Token = "0x6004F21")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F763C", Offset = "0x8F763C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard.<>c__DisplayClass52_0), Member = "<BuildSpaceBarArea>b__0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "BuildSpaceBarArea", MemberParameters = new object[] { typeof(UIPanel) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool CanRestore()
		{
			throw null;
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x0002DFCE File Offset: 0x0002C1CE
		[global::Cpp2ILInjected.Token(Token = "0x6004F22")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F77BC", Offset = "0x8F77BC", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextBox), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "ValidateText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "SetKeyState", MemberParameters = new object[] { typeof(UIVirtualKeyboard.KeyState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void TypeText(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x0002DFD1 File Offset: 0x0002C1D1
		[global::Cpp2ILInjected.Token(Token = "0x6004F23")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F7350", Offset = "0x8F7350", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(UIVirtualKeyboard.KeyboardSubmitEvent),
			typeof(Action),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "TypeText", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "CycleSymbols", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "<.ctor>b__50_2", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "<.ctor>b__50_5", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "SetText", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void SetKeyState(UIVirtualKeyboard.KeyState keyState)
		{
			throw null;
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x0002DFD4 File Offset: 0x0002C1D4
		[global::Cpp2ILInjected.Token(Token = "0x6004F24")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F6E64", Offset = "0x8F6E64", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard.<>c__DisplayClass52_0), Member = "<BuildSpaceBarArea>b__2", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard.<>c__DisplayClass52_1), Member = "<BuildSpaceBarArea>b__3", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(UIVirtualKeyboard.KeyboardSubmitEvent),
			typeof(Action),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "PressSpace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "TypeText", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "BackSpace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "<.ctor>b__50_6", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "<.ctor>b__50_7", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "<.ctor>b__50_12", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "<.ctor>b__50_13", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "<.ctor>b__50_18", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "TextIsValidForSubmit", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void ValidateText()
		{
			throw null;
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x0002DFD7 File Offset: 0x0002C1D7
		[global::Cpp2ILInjected.Token(Token = "0x6004F25")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F7938", Offset = "0x8F7938", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "ValidateText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "InternalSubmit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "<.ctor>b__50_14", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool TextIsValidForSubmit()
		{
			throw null;
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x0002DFDA File Offset: 0x0002C1DA
		[global::Cpp2ILInjected.Token(Token = "0x6004F26")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A28B4", Offset = "0x15A28B4", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOver", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnMouseOut", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void StyleKey<T>(UITextPanel<T> button, bool external = false)
		{
			throw null;
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x0002DFDD File Offset: 0x0002C1DD
		[global::Cpp2ILInjected.Token(Token = "0x6004F27")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F7014", Offset = "0x8F7014", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard.<>c__DisplayClass52_0), Member = "<BuildSpaceBarArea>b__0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(UIVirtualKeyboard.KeyboardSubmitEvent),
			typeof(Action),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "BuildSpaceBarArea", MemberParameters = new object[] { typeof(UIPanel) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "StyleKey", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"Terraria.GameContent.UI.Elements.UITextPanel`1<T>",
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private UITextPanel<object> CreateKeyboardButton(object text, int x, int y, int width = 1, bool style = true)
		{
			throw null;
		}

		// Token: 0x0600430F RID: 17167 RVA: 0x0002DFE0 File Offset: 0x0002C1E0
		[global::Cpp2ILInjected.Token(Token = "0x6004F28")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F79B4", Offset = "0x8F79B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput.SettingsForUI), Member = "get_ShowGamepadHints", ReturnType = typeof(bool))]
		private bool ShouldShowKeyboard()
		{
			throw null;
		}

		// Token: 0x06004310 RID: 17168 RVA: 0x0002DFE3 File Offset: 0x0002C1E3
		[global::Cpp2ILInjected.Token(Token = "0x6004F29")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F79BC", Offset = "0x8F79BC", Length = "0x744")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerInput.SettingsForUI), Member = "get_ShowGamepadHints", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Remove", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Activate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Deactivate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserInterface), Member = "ResetLasts", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_editSign", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_editChest", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "UpdateOffsetDown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "ToRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "GetInputText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Rectangle),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "RenameChestSubmit", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IngameFancyUI), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "get_CanSubmit", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "Submit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "TryEscapingMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "RenameChestCancel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IngameFancyUI), Member = "CanShowVirtualKeyboard", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "set_Text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "CopyTextToSign", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "CopyTextToChest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x0002DFE6 File Offset: 0x0002C1E6
		[global::Cpp2ILInjected.Token(Token = "0x6004F2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F820C", Offset = "0x8F820C", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "InputTextSignCancel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChestUI), Member = "RenameChestCancel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "Cancel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IngameFancyUI), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private bool TryEscapingMenu()
		{
			throw null;
		}

		// Token: 0x06004312 RID: 17170 RVA: 0x0002DFE9 File Offset: 0x0002C1E9
		[global::Cpp2ILInjected.Token(Token = "0x6004F2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F755C", Offset = "0x8F755C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(UIVirtualKeyboard.KeyboardSubmitEvent),
			typeof(Action),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void UpdateOffsetDown()
		{
			throw null;
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x0002DFEC File Offset: 0x0002C1EC
		[global::Cpp2ILInjected.Token(Token = "0x6004F2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F8524", Offset = "0x8F8524", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void OnActivate()
		{
			throw null;
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x0002DFEF File Offset: 0x0002C1EF
		[global::Cpp2ILInjected.Token(Token = "0x6004F2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F8528", Offset = "0x8F8528", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "OnDeactivate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void OnDeactivate()
		{
			throw null;
		}

		// Token: 0x06004315 RID: 17173 RVA: 0x0002DFF2 File Offset: 0x0002C1F2
		[global::Cpp2ILInjected.Token(Token = "0x6004F2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F8590", Offset = "0x8F8590", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "SetKeyState", MemberParameters = new object[] { typeof(UIVirtualKeyboard.KeyState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void CycleSymbols()
		{
			throw null;
		}

		// Token: 0x06004316 RID: 17174 RVA: 0x0002DFF5 File Offset: 0x0002C1F5
		[global::Cpp2ILInjected.Token(Token = "0x6004F2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F868C", Offset = "0x8F868C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextBox), Member = "Backspace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "ValidateText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void BackSpace()
		{
			throw null;
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06004317 RID: 17175 RVA: 0x0002DFF8 File Offset: 0x0002C1F8
		[global::Cpp2ILInjected.Token(Token = "0x170008AB")]
		public static bool CanSubmit
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004F30")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F8100", Offset = "0x8F8100", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004318 RID: 17176 RVA: 0x0002DFFB File Offset: 0x0002C1FB
		[global::Cpp2ILInjected.Token(Token = "0x6004F31")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F8188", Offset = "0x8F8188", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard.<>c), Member = "<.ctor>b__50_8", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "InternalSubmit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Submit()
		{
			throw null;
		}

		// Token: 0x06004319 RID: 17177 RVA: 0x0002DFFE File Offset: 0x0002C1FE
		[global::Cpp2ILInjected.Token(Token = "0x6004F32")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F8748", Offset = "0x8F8748", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "Submit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "TextIsValidForSubmit", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void InternalSubmit()
		{
			throw null;
		}

		// Token: 0x0600431A RID: 17178 RVA: 0x0002E001 File Offset: 0x0002C201
		[global::Cpp2ILInjected.Token(Token = "0x6004F33")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F8470", Offset = "0x8F8470", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "TryEscapingMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Cancel()
		{
			throw null;
		}

		// Token: 0x0600431B RID: 17179 RVA: 0x0002E004 File Offset: 0x0002C204
		[global::Cpp2ILInjected.Token(Token = "0x6004F34")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F87BC", Offset = "0x8F87BC", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextBox), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "ValidateText", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "SetKeyState", MemberParameters = new object[] { typeof(UIVirtualKeyboard.KeyState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Write(string text)
		{
			throw null;
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x0002E007 File Offset: 0x0002C207
		[global::Cpp2ILInjected.Token(Token = "0x6004F35")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F8910", Offset = "0x8F8910", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextBox), Member = "CursorLeft", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void CursorLeft()
		{
			throw null;
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x0002E00A File Offset: 0x0002C20A
		[global::Cpp2ILInjected.Token(Token = "0x6004F36")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F89BC", Offset = "0x8F89BC", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextBox), Member = "CursorRight", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void CursorRight()
		{
			throw null;
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x0002E00D File Offset: 0x0002C20D
		[global::Cpp2ILInjected.Token(Token = "0x6004F37")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F8A68", Offset = "0x8F8A68", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IngameFancyUI), Member = "CanShowVirtualKeyboard", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool CanDisplay(int keyboardContext)
		{
			throw null;
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600431F RID: 17183 RVA: 0x0002E010 File Offset: 0x0002C210
		[global::Cpp2ILInjected.Token(Token = "0x170008AC")]
		public static int KeyboardContext
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004F38")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F8AD8", Offset = "0x8F8AD8", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "InputTextSign", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "InputTextChest", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IngameFancyUI), Member = "Close", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IngameFancyUI), Member = "Draw", MemberParameters = new object[]
			{
				typeof(SpriteBatch),
				typeof(GameTime)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004320 RID: 17184 RVA: 0x0002E013 File Offset: 0x0002C213
		[global::Cpp2ILInjected.Token(Token = "0x6004F39")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F8B58", Offset = "0x8F8B58", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "InputTextSignCancel", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcChatText", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void CacheCanceledInput(int cacheMode)
		{
			throw null;
		}

		// Token: 0x06004321 RID: 17185 RVA: 0x0002E016 File Offset: 0x0002C216
		[global::Cpp2ILInjected.Token(Token = "0x6004F3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F8BF0", Offset = "0x8F8BF0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard.<>c__DisplayClass52_1), Member = "<BuildSpaceBarArea>b__3", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_npcChatText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_npcChatText", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "set_Text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void RestoreCanceledInput(int cacheMode)
		{
			throw null;
		}

		// Token: 0x06004322 RID: 17186 RVA: 0x0002E019 File Offset: 0x0002C219
		[global::Cpp2ILInjected.Token(Token = "0x6004F3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F831C", Offset = "0x8F831C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_npcChatText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void CopyTextToSign()
		{
			throw null;
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x0002E01C File Offset: 0x0002C21C
		[global::Cpp2ILInjected.Token(Token = "0x6004F3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F83F4", Offset = "0x8F83F4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_npcChatText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void CopyTextToChest()
		{
			throw null;
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x0002E01F File Offset: 0x0002C21F
		[global::Cpp2ILInjected.Token(Token = "0x6004F3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F8CCC", Offset = "0x8F8CCC", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x0002E022 File Offset: 0x0002C222
		[global::Cpp2ILInjected.Token(Token = "0x6004F3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F8E04", Offset = "0x8F8E04", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x0002E025 File Offset: 0x0002C225
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6004F3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F8F20", Offset = "0x8F8F20", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static UIVirtualKeyboard()
		{
			throw null;
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x0002E028 File Offset: 0x0002C228
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004F40")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F8F80", Offset = "0x8F8F80", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void <.ctor>b__50_0(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x0002E02B File Offset: 0x0002C22B
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004F41")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F8FD4", Offset = "0x8F8FD4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void <.ctor>b__50_1(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x0002E02E File Offset: 0x0002C22E
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004F42")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F90B0", Offset = "0x8F90B0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "SetKeyState", MemberParameters = new object[] { typeof(UIVirtualKeyboard.KeyState) }, ReturnType = typeof(void))]
		private void <.ctor>b__50_2(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x0002E031 File Offset: 0x0002C231
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004F43")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F90F4", Offset = "0x8F90F4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void <.ctor>b__50_3(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x0002E034 File Offset: 0x0002C234
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004F44")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F9148", Offset = "0x8F9148", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void <.ctor>b__50_4(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x0002E037 File Offset: 0x0002C237
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004F45")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F9224", Offset = "0x8F9224", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "SetKeyState", MemberParameters = new object[] { typeof(UIVirtualKeyboard.KeyState) }, ReturnType = typeof(void))]
		private void <.ctor>b__50_5(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x0600432D RID: 17197 RVA: 0x0002E03A File Offset: 0x0002C23A
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004F46")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F9264", Offset = "0x8F9264", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "ValidateText", ReturnType = typeof(void))]
		private void <.ctor>b__50_6(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x0600432E RID: 17198 RVA: 0x0002E03D File Offset: 0x0002C23D
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004F47")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F9268", Offset = "0x8F9268", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "ValidateText", ReturnType = typeof(void))]
		private void <.ctor>b__50_7(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x0600432F RID: 17199 RVA: 0x0002E040 File Offset: 0x0002C240
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004F48")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F926C", Offset = "0x8F926C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void <.ctor>b__50_9(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004330 RID: 17200 RVA: 0x0002E043 File Offset: 0x0002C243
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004F49")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F92AC", Offset = "0x8F92AC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "ValidateText", ReturnType = typeof(void))]
		private void <.ctor>b__50_12(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004331 RID: 17201 RVA: 0x0002E046 File Offset: 0x0002C246
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004F4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F92B0", Offset = "0x8F92B0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "ValidateText", ReturnType = typeof(void))]
		private void <.ctor>b__50_13(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004332 RID: 17202 RVA: 0x0002E049 File Offset: 0x0002C249
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004F4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F92B4", Offset = "0x8F92B4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "TextIsValidForSubmit", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void <.ctor>b__50_14(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x0002E04C File Offset: 0x0002C24C
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004F4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F9328", Offset = "0x8F9328", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void <.ctor>b__50_17(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x0002E04F File Offset: 0x0002C24F
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6004F4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8F9368", Offset = "0x8F9368", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(SoundEffectInstance))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextBox), Member = "Backspace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "ValidateText", ReturnType = typeof(void))]
		private void <.ctor>b__50_18(UIMouseEvent evt, UIElement listeningElement)
		{
			throw null;
		}

		// Token: 0x04006F01 RID: 28417
		[global::Cpp2ILInjected.Token(Token = "0x400880F")]
		private static UIVirtualKeyboard _currentInstance;

		// Token: 0x04006F02 RID: 28418
		[global::Cpp2ILInjected.Token(Token = "0x4008810")]
		private static string _cancelCacheSign;

		// Token: 0x04006F03 RID: 28419
		[global::Cpp2ILInjected.Token(Token = "0x4008811")]
		private static string _cancelCacheChest;

		// Token: 0x04006F04 RID: 28420
		[global::Cpp2ILInjected.Token(Token = "0x4008812")]
		private const string DEFAULT_KEYS = "1234567890qwertyuiopasdfghjkl'zxcvbnm,.?";

		// Token: 0x04006F05 RID: 28421
		[global::Cpp2ILInjected.Token(Token = "0x4008813")]
		private const string SHIFT_KEYS = "1234567890QWERTYUIOPASDFGHJKL'ZXCVBNM,.?";

		// Token: 0x04006F06 RID: 28422
		[global::Cpp2ILInjected.Token(Token = "0x4008814")]
		private const string SYMBOL_KEYS = "1234567890!@#$%^&*()-_+=/\\{}[]<>;:\"`|~£¥";

		// Token: 0x04006F07 RID: 28423
		[global::Cpp2ILInjected.Token(Token = "0x4008815")]
		private const float KEY_SPACING = 4f;

		// Token: 0x04006F08 RID: 28424
		[global::Cpp2ILInjected.Token(Token = "0x4008816")]
		private const float KEY_WIDTH = 48f;

		// Token: 0x04006F09 RID: 28425
		[global::Cpp2ILInjected.Token(Token = "0x4008817")]
		private const float KEY_HEIGHT = 37f;

		// Token: 0x04006F0A RID: 28426
		[global::Cpp2ILInjected.Token(Token = "0x4008818")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private UITextPanel<object>[] _keyList;

		// Token: 0x04006F0B RID: 28427
		[global::Cpp2ILInjected.Token(Token = "0x4008819")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private UITextPanel<object> _shiftButton;

		// Token: 0x04006F0C RID: 28428
		[global::Cpp2ILInjected.Token(Token = "0x400881A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private UITextPanel<object> _symbolButton;

		// Token: 0x04006F0D RID: 28429
		[global::Cpp2ILInjected.Token(Token = "0x400881B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private UITextBox _textBox;

		// Token: 0x04006F0E RID: 28430
		[global::Cpp2ILInjected.Token(Token = "0x400881C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private UITextPanel<LocalizedText> _submitButton;

		// Token: 0x04006F0F RID: 28431
		[global::Cpp2ILInjected.Token(Token = "0x400881D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private UITextPanel<LocalizedText> _cancelButton;

		// Token: 0x04006F10 RID: 28432
		[global::Cpp2ILInjected.Token(Token = "0x400881E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private UIText _label;

		// Token: 0x04006F11 RID: 28433
		[global::Cpp2ILInjected.Token(Token = "0x400881F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private UITextPanel<object> _enterButton;

		// Token: 0x04006F12 RID: 28434
		[global::Cpp2ILInjected.Token(Token = "0x4008820")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		private UITextPanel<object> _spacebarButton;

		// Token: 0x04006F13 RID: 28435
		[global::Cpp2ILInjected.Token(Token = "0x4008821")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		private UITextPanel<object> _restoreButton;

		// Token: 0x04006F14 RID: 28436
		[global::Cpp2ILInjected.Token(Token = "0x4008822")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
		private Asset<Texture2D> _textureShift;

		// Token: 0x04006F15 RID: 28437
		[global::Cpp2ILInjected.Token(Token = "0x4008823")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
		private Asset<Texture2D> _textureBackspace;

		// Token: 0x04006F16 RID: 28438
		[global::Cpp2ILInjected.Token(Token = "0x4008824")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
		private Color _internalBorderColor;

		// Token: 0x04006F17 RID: 28439
		[global::Cpp2ILInjected.Token(Token = "0x4008825")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1AC")]
		private Color _internalBorderColorSelected;

		// Token: 0x04006F18 RID: 28440
		[global::Cpp2ILInjected.Token(Token = "0x4008826")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
		private UITextPanel<LocalizedText> _submitButton2;

		// Token: 0x04006F19 RID: 28441
		[global::Cpp2ILInjected.Token(Token = "0x4008827")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
		private UITextPanel<LocalizedText> _cancelButton2;

		// Token: 0x04006F1A RID: 28442
		[global::Cpp2ILInjected.Token(Token = "0x4008828")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
		private UIElement outerLayer1;

		// Token: 0x04006F1B RID: 28443
		[global::Cpp2ILInjected.Token(Token = "0x4008829")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
		private UIElement outerLayer2;

		// Token: 0x04006F1C RID: 28444
		[global::Cpp2ILInjected.Token(Token = "0x400882A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
		private bool _allowEmpty;

		// Token: 0x04006F1D RID: 28445
		[global::Cpp2ILInjected.Token(Token = "0x400882B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D4")]
		private UIVirtualKeyboard.KeyState _keyState;

		// Token: 0x04006F1E RID: 28446
		[global::Cpp2ILInjected.Token(Token = "0x400882C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
		private UIVirtualKeyboard.KeyboardSubmitEvent _submitAction;

		// Token: 0x04006F1F RID: 28447
		[global::Cpp2ILInjected.Token(Token = "0x400882D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
		private Action _cancelAction;

		// Token: 0x04006F20 RID: 28448
		[global::Cpp2ILInjected.Token(Token = "0x400882E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
		private int _lastOffsetDown;

		// Token: 0x04006F21 RID: 28449
		[global::Cpp2ILInjected.Token(Token = "0x400882F")]
		public static int OffsetDown;

		// Token: 0x04006F22 RID: 28450
		[global::Cpp2ILInjected.Token(Token = "0x4008830")]
		public static bool ShouldHideText;

		// Token: 0x04006F23 RID: 28451
		[global::Cpp2ILInjected.Token(Token = "0x4008831")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1EC")]
		private int _keyboardContext;

		// Token: 0x04006F24 RID: 28452
		[global::Cpp2ILInjected.Token(Token = "0x4008832")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
		private bool _edittingSign;

		// Token: 0x04006F25 RID: 28453
		[global::Cpp2ILInjected.Token(Token = "0x4008833")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F1")]
		private bool _edittingChest;

		// Token: 0x04006F26 RID: 28454
		[global::Cpp2ILInjected.Token(Token = "0x4008834")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F4")]
		private float _textBoxHeight;

		// Token: 0x04006F27 RID: 28455
		[global::Cpp2ILInjected.Token(Token = "0x4008835")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
		private float _labelHeight;

		// Token: 0x04006F28 RID: 28456
		[global::Cpp2ILInjected.Token(Token = "0x4008836")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
		public Func<string, bool> CustomTextValidationForUpdate;

		// Token: 0x04006F29 RID: 28457
		[global::Cpp2ILInjected.Token(Token = "0x4008837")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
		public Func<string, bool> CustomTextValidationForSubmit;

		// Token: 0x04006F2A RID: 28458
		[global::Cpp2ILInjected.Token(Token = "0x4008838")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
		public Func<bool> CustomEscapeAttempt;

		// Token: 0x04006F2B RID: 28459
		[global::Cpp2ILInjected.Token(Token = "0x4008839")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
		private bool _canSubmit;

		// Token: 0x02000AAC RID: 2732
		// (Invoke) Token: 0x06005246 RID: 21062
		[global::Cpp2ILInjected.Token(Token = "0x2000A78")]
		public delegate void KeyboardSubmitEvent(string text);

		// Token: 0x02000AAD RID: 2733
		[global::Cpp2ILInjected.Token(Token = "0x2000A79")]
		public enum KeyState
		{
			// Token: 0x04008F1B RID: 36635
			[global::Cpp2ILInjected.Token(Token = "0x400883B")]
			Default,
			// Token: 0x04008F1C RID: 36636
			[global::Cpp2ILInjected.Token(Token = "0x400883C")]
			Symbol,
			// Token: 0x04008F1D RID: 36637
			[global::Cpp2ILInjected.Token(Token = "0x400883D")]
			Shift
		}

		// Token: 0x02000AAE RID: 2734
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A7A")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005249 RID: 21065 RVA: 0x00030839 File Offset: 0x0002EA39
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6004F52")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F93E8", Offset = "0x8F93E8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x0600524A RID: 21066 RVA: 0x0003083C File Offset: 0x0002EA3C
			[global::Cpp2ILInjected.Token(Token = "0x6004F53")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F9444", Offset = "0x8F9444", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x0600524B RID: 21067 RVA: 0x0003083F File Offset: 0x0002EA3F
			[global::Cpp2ILInjected.Token(Token = "0x6004F54")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F944C", Offset = "0x8F944C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "Submit", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void <.ctor>b__50_8(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			// Token: 0x0600524C RID: 21068 RVA: 0x00030842 File Offset: 0x0002EA42
			[global::Cpp2ILInjected.Token(Token = "0x6004F55")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F9498", Offset = "0x8F9498", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal void <.ctor>b__50_10(UIMouseEvent a, UIElement b)
			{
				throw null;
			}

			// Token: 0x0600524D RID: 21069 RVA: 0x00030845 File Offset: 0x0002EA45
			[global::Cpp2ILInjected.Token(Token = "0x6004F56")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F9598", Offset = "0x8F9598", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal void <.ctor>b__50_11(UIMouseEvent a, UIElement b)
			{
				throw null;
			}

			// Token: 0x0600524E RID: 21070 RVA: 0x00030848 File Offset: 0x0002EA48
			[global::Cpp2ILInjected.Token(Token = "0x6004F57")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F9698", Offset = "0x8F9698", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal void <.ctor>b__50_15(UIMouseEvent a, UIElement b)
			{
				throw null;
			}

			// Token: 0x0600524F RID: 21071 RVA: 0x0003084B File Offset: 0x0002EA4B
			[global::Cpp2ILInjected.Token(Token = "0x6004F58")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F9798", Offset = "0x8F9798", Length = "0x100")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			internal void <.ctor>b__50_16(UIMouseEvent a, UIElement b)
			{
				throw null;
			}

			// Token: 0x04008F1E RID: 36638
			[global::Cpp2ILInjected.Token(Token = "0x400883E")]
			public static readonly UIVirtualKeyboard.<>c <>9;

			// Token: 0x04008F1F RID: 36639
			[global::Cpp2ILInjected.Token(Token = "0x400883F")]
			public static UIElement.MouseEvent <>9__50_8;

			// Token: 0x04008F20 RID: 36640
			[global::Cpp2ILInjected.Token(Token = "0x4008840")]
			public static UIElement.MouseEvent <>9__50_10;

			// Token: 0x04008F21 RID: 36641
			[global::Cpp2ILInjected.Token(Token = "0x4008841")]
			public static UIElement.MouseEvent <>9__50_11;

			// Token: 0x04008F22 RID: 36642
			[global::Cpp2ILInjected.Token(Token = "0x4008842")]
			public static UIElement.MouseEvent <>9__50_15;

			// Token: 0x04008F23 RID: 36643
			[global::Cpp2ILInjected.Token(Token = "0x4008843")]
			public static UIElement.MouseEvent <>9__50_16;
		}

		// Token: 0x02000AAF RID: 2735
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A7B")]
		private sealed class <>c__DisplayClass52_0
		{
			// Token: 0x06005250 RID: 21072 RVA: 0x0003084E File Offset: 0x0002EA4E
			[global::Cpp2ILInjected.Token(Token = "0x6004F59")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F7634", Offset = "0x8F7634", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass52_0()
			{
				throw null;
			}

			// Token: 0x06005251 RID: 21073 RVA: 0x00030851 File Offset: 0x0002EA51
			[global::Cpp2ILInjected.Token(Token = "0x6004F5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F9898", Offset = "0x8F9898", Length = "0x1E8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "CanRestore", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "CreateKeyboardButton", MemberParameters = new object[]
			{
				typeof(object),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(UITextPanel<object>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement.MouseEvent), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "add_OnLeftClick", MemberParameters = new object[] { typeof(UIElement.MouseEvent) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			internal void <BuildSpaceBarArea>b__0()
			{
				throw null;
			}

			// Token: 0x06005252 RID: 21074 RVA: 0x00030854 File Offset: 0x0002EA54
			[global::Cpp2ILInjected.Token(Token = "0x6004F5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F9A80", Offset = "0x8F9A80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "PressSpace", ReturnType = typeof(void))]
			internal void <BuildSpaceBarArea>b__1(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			// Token: 0x06005253 RID: 21075 RVA: 0x00030857 File Offset: 0x0002EA57
			[global::Cpp2ILInjected.Token(Token = "0x6004F5C")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F9A88", Offset = "0x8F9A88", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextBox), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "ValidateText", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <BuildSpaceBarArea>b__2(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			// Token: 0x04008F24 RID: 36644
			[global::Cpp2ILInjected.Token(Token = "0x4008844")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public UIVirtualKeyboard <>4__this;

			// Token: 0x04008F25 RID: 36645
			[global::Cpp2ILInjected.Token(Token = "0x4008845")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public UIPanel mainPanel;

			// Token: 0x04008F26 RID: 36646
			[global::Cpp2ILInjected.Token(Token = "0x4008846")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public Action createTheseTwo;

			// Token: 0x04008F27 RID: 36647
			[global::Cpp2ILInjected.Token(Token = "0x4008847")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public UIElement.MouseEvent <>9__1;

			// Token: 0x04008F28 RID: 36648
			[global::Cpp2ILInjected.Token(Token = "0x4008848")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public UIElement.MouseEvent <>9__2;
		}

		// Token: 0x02000AB0 RID: 2736
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A7C")]
		private sealed class <>c__DisplayClass52_1
		{
			// Token: 0x06005254 RID: 21076 RVA: 0x0003085A File Offset: 0x0002EA5A
			[global::Cpp2ILInjected.Token(Token = "0x6004F5D")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F76DC", Offset = "0x8F76DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass52_1()
			{
				throw null;
			}

			// Token: 0x06005255 RID: 21077 RVA: 0x0003085D File Offset: 0x0002EA5D
			[global::Cpp2ILInjected.Token(Token = "0x6004F5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x8F9B00", Offset = "0x8F9B00", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "RestoreCanceledInput", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIVirtualKeyboard), Member = "ValidateText", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Remove", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <BuildSpaceBarArea>b__3(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			// Token: 0x04008F29 RID: 36649
			[global::Cpp2ILInjected.Token(Token = "0x4008849")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public UITextPanel<object> restoreBar;

			// Token: 0x04008F2A RID: 36650
			[global::Cpp2ILInjected.Token(Token = "0x400884A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public UIVirtualKeyboard.<>c__DisplayClass52_0 field_Public_<>c__DisplayClass52_0_0;
		}

		// Token: 0x02000AB1 RID: 2737
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000A7D")]
		private sealed class <>c__DisplayClass60_0<T>
		{
			// Token: 0x06005256 RID: 21078 RVA: 0x00030860 File Offset: 0x0002EA60
			[global::Cpp2ILInjected.Token(Token = "0x6004F5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B3A5C", Offset = "0x15B3A5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass60_0()
			{
				throw null;
			}

			// Token: 0x06005257 RID: 21079 RVA: 0x00030863 File Offset: 0x0002EA63
			[global::Cpp2ILInjected.Token(Token = "0x6004F60")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B3A64", Offset = "0x15B3A64", Length = "0x20C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			internal void <StyleKey>b__0(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			// Token: 0x06005258 RID: 21080 RVA: 0x00030866 File Offset: 0x0002EA66
			[global::Cpp2ILInjected.Token(Token = "0x6004F61")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B3C70", Offset = "0x15B3C70", Length = "0x20C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			internal void <StyleKey>b__1(UIMouseEvent evt, UIElement listeningElement)
			{
				throw null;
			}

			// Token: 0x04008F2B RID: 36651
			[global::Cpp2ILInjected.Token(Token = "0x400884B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public bool external;

			// Token: 0x04008F2C RID: 36652
			[global::Cpp2ILInjected.Token(Token = "0x400884C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public UIVirtualKeyboard <>4__this;
		}
	}
}
