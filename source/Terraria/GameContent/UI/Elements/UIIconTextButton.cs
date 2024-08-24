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
	// Token: 0x020006D4 RID: 1748
	[global::Cpp2ILInjected.Token(Token = "0x2000AB8")]
	public class UIIconTextButton : UIElement
	{
		// Token: 0x06004489 RID: 17545 RVA: 0x0002E43C File Offset: 0x0002C63C
		[global::Cpp2ILInjected.Token(Token = "0x60050DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x929168", Offset = "0x929168", Length = "0x3CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixels", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIIconTextButton), Member = "SetText", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public UIIconTextButton(LocalizedText title, Color textColor, string iconTexturePath, float textSize = 1f, float titleAlignmentX = 0.5f, float titleWidthReduction = 10f)
		{
			throw null;
		}

		// Token: 0x0600448A RID: 17546 RVA: 0x0002E43F File Offset: 0x0002C63F
		[global::Cpp2ILInjected.Token(Token = "0x60050DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x929540", Offset = "0x929540", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIIconTextButton), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(Color),
			typeof(string),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Remove", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(LocalizedText),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixels", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixelsAndPercent", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void SetText(LocalizedText text, float textSize, Color color)
		{
			throw null;
		}

		// Token: 0x0600448B RID: 17547 RVA: 0x0002E442 File Offset: 0x0002C642
		[global::Cpp2ILInjected.Token(Token = "0x60050DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x92971C", Offset = "0x92971C", Length = "0x2A0")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CalculatedStyle), Member = "Center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x0002E445 File Offset: 0x0002C645
		[global::Cpp2ILInjected.Token(Token = "0x60050DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x9299BC", Offset = "0x9299BC", Length = "0x48")]
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

		// Token: 0x0600448D RID: 17549 RVA: 0x0002E448 File Offset: 0x0002C648
		[global::Cpp2ILInjected.Token(Token = "0x60050DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x929A04", Offset = "0x929A04", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void MouseOver(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x0600448E RID: 17550 RVA: 0x0002E44B File Offset: 0x0002C64B
		[global::Cpp2ILInjected.Token(Token = "0x60050E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x929AD8", Offset = "0x929AD8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void MouseOut(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x0600448F RID: 17551 RVA: 0x0002E44E File Offset: 0x0002C64E
		[global::Cpp2ILInjected.Token(Token = "0x60050E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x929534", Offset = "0x929534", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetColor(Color color, float opacity)
		{
			throw null;
		}

		// Token: 0x06004490 RID: 17552 RVA: 0x0002E451 File Offset: 0x0002C651
		[global::Cpp2ILInjected.Token(Token = "0x60050E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x929BA4", Offset = "0x929BA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetHoverColor(Color color)
		{
			throw null;
		}

		// Token: 0x04007050 RID: 28752
		[global::Cpp2ILInjected.Token(Token = "0x4008997")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x04007051 RID: 28753
		[global::Cpp2ILInjected.Token(Token = "0x4008998")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private readonly Asset<Texture2D> _hoveredTexture;

		// Token: 0x04007052 RID: 28754
		[global::Cpp2ILInjected.Token(Token = "0x4008999")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private readonly Asset<Texture2D> _iconTexture;

		// Token: 0x04007053 RID: 28755
		[global::Cpp2ILInjected.Token(Token = "0x400899A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private Color _color;

		// Token: 0x04007054 RID: 28756
		[global::Cpp2ILInjected.Token(Token = "0x400899B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x164")]
		private Color _hoverColor;

		// Token: 0x04007055 RID: 28757
		[global::Cpp2ILInjected.Token(Token = "0x400899C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		public float FadeFromBlack;

		// Token: 0x04007056 RID: 28758
		[global::Cpp2ILInjected.Token(Token = "0x400899D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x16C")]
		private float _whiteLerp;

		// Token: 0x04007057 RID: 28759
		[global::Cpp2ILInjected.Token(Token = "0x400899E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private float _opacity;

		// Token: 0x04007058 RID: 28760
		[global::Cpp2ILInjected.Token(Token = "0x400899F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x174")]
		private bool _hovered;

		// Token: 0x04007059 RID: 28761
		[global::Cpp2ILInjected.Token(Token = "0x40089A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x175")]
		private bool _soundedHover;

		// Token: 0x0400705A RID: 28762
		[global::Cpp2ILInjected.Token(Token = "0x40089A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private UIText _title;
	}
}
