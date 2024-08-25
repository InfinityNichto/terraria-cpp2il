using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.UI.States;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AD1")]
	public class UIToggleImage : UIElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008DC")]
		public bool IsOn
		{
			[global::Cpp2ILInjected.Token(Token = "0x600518C")]
			[global::Cpp2ILInjected.Address(RVA = "0x92FE88", Offset = "0x92FE88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600518D")]
		[global::Cpp2ILInjected.Address(RVA = "0x92FE90", Offset = "0x92FE90", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIAchievementsMenu), Member = "InitializePage", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public UIToggleImage(Asset<Texture2D> texture, int width, int height, Point onTextureOffset, Point offTextureOffset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600518E")]
		[global::Cpp2ILInjected.Address(RVA = "0x92FFF8", Offset = "0x92FFF8", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600518F")]
		[global::Cpp2ILInjected.Address(RVA = "0x930198", Offset = "0x930198", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = "LeftClick", MemberParameters = new object[] { typeof(UIMouseEvent) }, ReturnType = typeof(void))]
		public override void LeftClick(UIMouseEvent evt)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005190")]
		[global::Cpp2ILInjected.Address(RVA = "0x9301BC", Offset = "0x9301BC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetState(bool value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005191")]
		[global::Cpp2ILInjected.Address(RVA = "0x9301AC", Offset = "0x9301AC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Toggle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008A09")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private Asset<Texture2D> _onTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A0A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private Asset<Texture2D> _offTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private int _drawWidth;

		[global::Cpp2ILInjected.Token(Token = "0x4008A0C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15C")]
		private int _drawHeight;

		[global::Cpp2ILInjected.Token(Token = "0x4008A0D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private Point _onTextureOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4008A0E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private Point _offTextureOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4008A0F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private bool _isOn;
	}
}
