using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AA8")]
	public class UICharacterNameButton : UIElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005064")]
		[global::Cpp2ILInjected.Address(RVA = "0x90DE90", Offset = "0x90DE90", Length = "0x3F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixels", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Language), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(LocalizedText))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UICharacterNameButton), Member = "SetContents", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public UICharacterNameButton(LocalizedText titleText, LocalizedText emptyContentText, LocalizedText description = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005065")]
		[global::Cpp2ILInjected.Address(RVA = "0x90E388", Offset = "0x90E388", Length = "0x224")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005066")]
		[global::Cpp2ILInjected.Address(RVA = "0x90E284", Offset = "0x90E284", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UICharacterNameButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(LocalizedText),
			typeof(LocalizedText)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "SetText", MemberParameters = new object[] { typeof(LocalizedText) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "SetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixels", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void SetContents(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005067")]
		[global::Cpp2ILInjected.Address(RVA = "0x90E5AC", Offset = "0x90E5AC", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "get_Text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = "SetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void TrimDisplayIfOverElementDimensions(int padding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005068")]
		[global::Cpp2ILInjected.Address(RVA = "0x90E8E4", Offset = "0x90E8E4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "LeftMouseDown", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void LeftMouseDown(UIMouseEvent evt)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005069")]
		[global::Cpp2ILInjected.Address(RVA = "0x90E8EC", Offset = "0x90E8EC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void MouseOver(UIMouseEvent evt)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600506A")]
		[global::Cpp2ILInjected.Address(RVA = "0x90E90C", Offset = "0x90E90C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void MouseOut(UIMouseEvent evt)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008922")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private readonly Asset<Texture2D> _BasePanelTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008923")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private readonly Asset<Texture2D> _selectedBorderTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008924")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008925")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private bool _hovered;

		[global::Cpp2ILInjected.Token(Token = "0x4008926")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x161")]
		private bool _soundedHover;

		[global::Cpp2ILInjected.Token(Token = "0x4008927")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private readonly LocalizedText _textToShowWhenEmpty;

		[global::Cpp2ILInjected.Token(Token = "0x4008928")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private string actualContents;

		[global::Cpp2ILInjected.Token(Token = "0x4008929")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private UIText _text;

		[global::Cpp2ILInjected.Token(Token = "0x400892A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private UIText _title;

		[global::Cpp2ILInjected.Token(Token = "0x400892B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		public readonly LocalizedText Description;

		[global::Cpp2ILInjected.Token(Token = "0x400892C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		public float DistanceFromTitleToOption;
	}
}
