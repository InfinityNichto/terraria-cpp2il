using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000A91")]
	public class GroupOptionButton<T> : UIElement, IGroupOptionButton
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008B9")]
		public T OptionValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004FDE")]
			[global::Cpp2ILInjected.Address(RVA = "0x16AE250", Offset = "0x16AE250", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170008BA")]
		public bool IsSelected
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004FDF")]
			[global::Cpp2ILInjected.Address(RVA = "0x16AE258", Offset = "0x16AE258", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.APerPlayerTogglePower), Member = "button_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowers.ASharedTogglePower), Member = "button_OnUpdate", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x16AE2BC", Offset = "0x16AE2BC", Length = "0x524")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowersHelper), Member = "CreateToggleButton", MemberParameters = new object[] { typeof(CreativePowerUIElementRequestInfo) }, ReturnType = typeof(GroupOptionButton<bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowersHelper), Member = "CreateSimpleButton", MemberParameters = new object[] { typeof(CreativePowerUIElementRequestInfo) }, ReturnType = typeof(GroupOptionButton<bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixels", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixelsAndPercent", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public GroupOptionButton(T option, LocalizedText title, LocalizedText description, Color textColor, string iconTexturePath, float textSize = 1f, float titleAlignmentX = 0.5f, float titleWidthReduction = 10f)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x16AE7E0", Offset = "0x16AE7E0", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Remove", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixelsAndPercent", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixels", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void SetText(LocalizedText text, float textSize, Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x16AE8D8", Offset = "0x16AE8D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetCurrentOption(T option)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x16AE8E4", Offset = "0x16AE8E4", Length = "0x3F0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x16AECD4", Offset = "0x16AECD4", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "LeftMouseDown", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void LeftMouseDown(UIMouseEvent evt)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x16AED1C", Offset = "0x16AED1C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void MouseOver(UIMouseEvent evt)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x16AED3C", Offset = "0x16AED3C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void MouseOut(UIMouseEvent evt)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x16AED58", Offset = "0x16AED58", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetColor(Color color, float opacity)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x16AED68", Offset = "0x16AED68", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowersHelper), Member = "CreateToggleButton", MemberParameters = new object[] { typeof(CreativePowerUIElementRequestInfo) }, ReturnType = typeof(GroupOptionButton<bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CreativePowersHelper), Member = "CreateSimpleButton", MemberParameters = new object[] { typeof(CreativePowerUIElementRequestInfo) }, ReturnType = typeof(GroupOptionButton<bool>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public void SetColorsBasedOnSelectionState(Color pickedColor, Color unpickedColor, float opacityPicked, float opacityNotPicked)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004FE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x16AED84", Offset = "0x16AED84", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetBorderColor(Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40088B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private T _currentOption;

		[global::Cpp2ILInjected.Token(Token = "0x40088B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _BasePanelTexture;

		[global::Cpp2ILInjected.Token(Token = "0x40088B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _selectedBorderTexture;

		[global::Cpp2ILInjected.Token(Token = "0x40088BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		[global::Cpp2ILInjected.Token(Token = "0x40088BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _iconTexture;

		[global::Cpp2ILInjected.Token(Token = "0x40088BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T _myOption;

		[global::Cpp2ILInjected.Token(Token = "0x40088BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Color _color;

		[global::Cpp2ILInjected.Token(Token = "0x40088BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Color _borderColor;

		[global::Cpp2ILInjected.Token(Token = "0x40088BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float FadeFromBlack;

		[global::Cpp2ILInjected.Token(Token = "0x40088C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float _whiteLerp;

		[global::Cpp2ILInjected.Token(Token = "0x40088C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float _opacity;

		[global::Cpp2ILInjected.Token(Token = "0x40088C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool _hovered;

		[global::Cpp2ILInjected.Token(Token = "0x40088C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool _soundedHover;

		[global::Cpp2ILInjected.Token(Token = "0x40088C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public bool ShowHighlightWhenSelected;

		[global::Cpp2ILInjected.Token(Token = "0x40088C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool _UseOverrideColors;

		[global::Cpp2ILInjected.Token(Token = "0x40088C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Color _overrideUnpickedColor;

		[global::Cpp2ILInjected.Token(Token = "0x40088C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Color _overridePickedColor;

		[global::Cpp2ILInjected.Token(Token = "0x40088C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float _overrideOpacityPicked;

		[global::Cpp2ILInjected.Token(Token = "0x40088C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float _overrideOpacityUnpicked;

		[global::Cpp2ILInjected.Token(Token = "0x40088CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly LocalizedText Description;

		[global::Cpp2ILInjected.Token(Token = "0x40088CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private UIText _title;
	}
}
