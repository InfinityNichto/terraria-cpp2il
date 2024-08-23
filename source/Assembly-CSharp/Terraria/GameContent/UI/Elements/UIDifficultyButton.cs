using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.Localization;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	// Token: 0x020006CF RID: 1743
	[global::Cpp2ILInjected.Token(Token = "0x2000AB3")]
	public class UIDifficultyButton : UIElement
	{
		// Token: 0x06004470 RID: 17520 RVA: 0x0002E3F1 File Offset: 0x0002C5F1
		[global::Cpp2ILInjected.Token(Token = "0x60050C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x926760", Offset = "0x926760", Length = "0x37C")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "FromPixelsAndPercent", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(StyleDimension))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "Append", MemberParameters = new object[] { typeof(UIElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public UIDifficultyButton(Player player, LocalizedText title, LocalizedText description, byte difficulty, Color color)
		{
			throw null;
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x0002E3F4 File Offset: 0x0002C5F4
		[global::Cpp2ILInjected.Token(Token = "0x60050C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x926C64", Offset = "0x926C64", Length = "0x328")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x0002E3F7 File Offset: 0x0002C5F7
		[global::Cpp2ILInjected.Token(Token = "0x60050C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x926F8C", Offset = "0x926F8C", Length = "0x54")]
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

		// Token: 0x06004473 RID: 17523 RVA: 0x0002E3FA File Offset: 0x0002C5FA
		[global::Cpp2ILInjected.Token(Token = "0x60050C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x926FE0", Offset = "0x926FE0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOver", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void MouseOver(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x0002E3FD File Offset: 0x0002C5FD
		[global::Cpp2ILInjected.Token(Token = "0x60050C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x927000", Offset = "0x927000", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "MouseOut", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void MouseOut(UIMouseEvent evt)
		{
			throw null;
		}

		// Token: 0x04007034 RID: 28724
		[global::Cpp2ILInjected.Token(Token = "0x400897B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private readonly Player _player;

		// Token: 0x04007035 RID: 28725
		[global::Cpp2ILInjected.Token(Token = "0x400897C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private readonly Asset<Texture2D> _BasePanelTexture;

		// Token: 0x04007036 RID: 28726
		[global::Cpp2ILInjected.Token(Token = "0x400897D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private readonly Asset<Texture2D> _selectedBorderTexture;

		// Token: 0x04007037 RID: 28727
		[global::Cpp2ILInjected.Token(Token = "0x400897E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private readonly Asset<Texture2D> _hoveredBorderTexture;

		// Token: 0x04007038 RID: 28728
		[global::Cpp2ILInjected.Token(Token = "0x400897F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private readonly byte _difficulty;

		// Token: 0x04007039 RID: 28729
		[global::Cpp2ILInjected.Token(Token = "0x4008980")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x169")]
		private readonly Color _color;

		// Token: 0x0400703A RID: 28730
		[global::Cpp2ILInjected.Token(Token = "0x4008981")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x16D")]
		private bool _hovered;

		// Token: 0x0400703B RID: 28731
		[global::Cpp2ILInjected.Token(Token = "0x4008982")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x16E")]
		private bool _soundedHover;
	}
}
