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
	// Token: 0x020006B7 RID: 1719
	[global::Cpp2ILInjected.Token(Token = "0x2000A91")]
	public class GroupOptionButton<T> : UIElement, IGroupOptionButton
	{
		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060043A4 RID: 17316 RVA: 0x0002E193 File Offset: 0x0002C393
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

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060043A5 RID: 17317 RVA: 0x0002E196 File Offset: 0x0002C396
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

		// Token: 0x060043A6 RID: 17318 RVA: 0x0002E199 File Offset: 0x0002C399
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

		// Token: 0x060043A7 RID: 17319 RVA: 0x0002E19C File Offset: 0x0002C39C
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

		// Token: 0x060043A8 RID: 17320 RVA: 0x0002E19F File Offset: 0x0002C39F
		[global::Cpp2ILInjected.Token(Token = "0x6004FE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x16AE8D8", Offset = "0x16AE8D8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetCurrentOption(T option)
		{
			throw null;
		}

		// Token: 0x060043A9 RID: 17321 RVA: 0x0002E1A2 File Offset: 0x0002C3A2
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

		// Token: 0x060043AA RID: 17322 RVA: 0x0002E1A5 File Offset: 0x0002C3A5
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

		// Token: 0x060043AB RID: 17323 RVA: 0x0002E1A8 File Offset: 0x0002C3A8
		[global::Cpp2ILInjected.Token(Token = "0x6004FE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x16AED1C", Offset = "0x16AED1C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void MouseOver(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x0002E1AB File Offset: 0x0002C3AB
		[global::Cpp2ILInjected.Token(Token = "0x6004FE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x16AED3C", Offset = "0x16AED3C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void MouseOut(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x060043AD RID: 17325 RVA: 0x0002E1AE File Offset: 0x0002C3AE
		[global::Cpp2ILInjected.Token(Token = "0x6004FE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x16AED58", Offset = "0x16AED58", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetColor(Color color, float opacity)
		{
			throw null;
		}

		// Token: 0x060043AE RID: 17326 RVA: 0x0002E1B1 File Offset: 0x0002C3B1
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

		// Token: 0x060043AF RID: 17327 RVA: 0x0002E1B4 File Offset: 0x0002C3B4
		[global::Cpp2ILInjected.Token(Token = "0x6004FE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x16AED84", Offset = "0x16AED84", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetBorderColor(Color color)
		{
			throw null;
		}

		// Token: 0x04006F8F RID: 28559
		[global::Cpp2ILInjected.Token(Token = "0x40088B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private T _currentOption;

		// Token: 0x04006F90 RID: 28560
		[global::Cpp2ILInjected.Token(Token = "0x40088B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x04006F91 RID: 28561
		[global::Cpp2ILInjected.Token(Token = "0x40088B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _selectedBorderTexture;

		// Token: 0x04006F92 RID: 28562
		[global::Cpp2ILInjected.Token(Token = "0x40088BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		// Token: 0x04006F93 RID: 28563
		[global::Cpp2ILInjected.Token(Token = "0x40088BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Asset<Texture2D> _iconTexture;

		// Token: 0x04006F94 RID: 28564
		[global::Cpp2ILInjected.Token(Token = "0x40088BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly T _myOption;

		// Token: 0x04006F95 RID: 28565
		[global::Cpp2ILInjected.Token(Token = "0x40088BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Color _color;

		// Token: 0x04006F96 RID: 28566
		[global::Cpp2ILInjected.Token(Token = "0x40088BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Color _borderColor;

		// Token: 0x04006F97 RID: 28567
		[global::Cpp2ILInjected.Token(Token = "0x40088BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float FadeFromBlack;

		// Token: 0x04006F98 RID: 28568
		[global::Cpp2ILInjected.Token(Token = "0x40088C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float _whiteLerp;

		// Token: 0x04006F99 RID: 28569
		[global::Cpp2ILInjected.Token(Token = "0x40088C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float _opacity;

		// Token: 0x04006F9A RID: 28570
		[global::Cpp2ILInjected.Token(Token = "0x40088C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool _hovered;

		// Token: 0x04006F9B RID: 28571
		[global::Cpp2ILInjected.Token(Token = "0x40088C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool _soundedHover;

		// Token: 0x04006F9C RID: 28572
		[global::Cpp2ILInjected.Token(Token = "0x40088C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public bool ShowHighlightWhenSelected;

		// Token: 0x04006F9D RID: 28573
		[global::Cpp2ILInjected.Token(Token = "0x40088C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool _UseOverrideColors;

		// Token: 0x04006F9E RID: 28574
		[global::Cpp2ILInjected.Token(Token = "0x40088C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Color _overrideUnpickedColor;

		// Token: 0x04006F9F RID: 28575
		[global::Cpp2ILInjected.Token(Token = "0x40088C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Color _overridePickedColor;

		// Token: 0x04006FA0 RID: 28576
		[global::Cpp2ILInjected.Token(Token = "0x40088C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float _overrideOpacityPicked;

		// Token: 0x04006FA1 RID: 28577
		[global::Cpp2ILInjected.Token(Token = "0x40088C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private float _overrideOpacityUnpicked;

		// Token: 0x04006FA2 RID: 28578
		[global::Cpp2ILInjected.Token(Token = "0x40088CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly LocalizedText Description;

		// Token: 0x04006FA3 RID: 28579
		[global::Cpp2ILInjected.Token(Token = "0x40088CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private UIText _title;
	}
}
