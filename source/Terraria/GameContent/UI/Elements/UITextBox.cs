﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.UI.States;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000ACF")]
	internal class UITextBox : UITextPanel<string>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005175")]
		[global::Cpp2ILInjected.Address(RVA = "0x92E4A4", Offset = "0x92E4A4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(UIVirtualKeyboard.KeyboardSubmitEvent),
			typeof(Action),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UISearchBar), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = ".ctor", MemberParameters = new object[]
		{
			"T",
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public UITextBox(string text, float textScale = 1f, bool large = false)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005176")]
		[global::Cpp2ILInjected.Address(RVA = "0x92F8C4", Offset = "0x92F8C4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.UI.States.UIVirtualKeyboard.<>c__DisplayClass52_0", Member = "<BuildSpaceBarArea>b__2", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "PressSpace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "TypeText", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "SetText", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Write(string text)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005177")]
		[global::Cpp2ILInjected.Address(RVA = "0x92F960", Offset = "0x92F960", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "SetText", MemberParameters = new object[]
		{
			"T",
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void SetText(string text, float textScale, bool large)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005178")]
		[global::Cpp2ILInjected.Address(RVA = "0x92FA78", Offset = "0x92FA78", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetTextMaxLength(int maxLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005179")]
		[global::Cpp2ILInjected.Address(RVA = "0x92FA80", Offset = "0x92FA80", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "BackSpace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "<.ctor>b__50_18", MemberParameters = new object[]
		{
			typeof(UIMouseEvent),
			typeof(UIElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "SetText", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Backspace()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600517A")]
		[global::Cpp2ILInjected.Address(RVA = "0x92FB28", Offset = "0x92FB28", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "CursorLeft", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void CursorLeft()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600517B")]
		[global::Cpp2ILInjected.Address(RVA = "0x92FB3C", Offset = "0x92FB3C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIVirtualKeyboard), Member = "CursorRight", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CursorRight()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600517C")]
		[global::Cpp2ILInjected.Address(RVA = "0x92FBA4", Offset = "0x92FBA4", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UITextPanel<>), Member = "DrawSelf", MemberParameters = new object[] { typeof(SpriteBatch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40089FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
		private int _cursor;

		[global::Cpp2ILInjected.Token(Token = "0x40089FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19C")]
		private int _frameCount;

		[global::Cpp2ILInjected.Token(Token = "0x40089FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
		private int _maxLength;

		[global::Cpp2ILInjected.Token(Token = "0x40089FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A4")]
		public bool ShowInputTicker;

		[global::Cpp2ILInjected.Token(Token = "0x40089FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A5")]
		public bool HideSelf;
	}
}
