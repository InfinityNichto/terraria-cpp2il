using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000ACD")]
	public class UISlicedImage : UIElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x170008CE")]
		public Color Color
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005155")]
			[global::Cpp2ILInjected.Address(RVA = "0x92EDA4", Offset = "0x92EDA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6005156")]
			[global::Cpp2ILInjected.Address(RVA = "0x92EDAC", Offset = "0x92EDAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005157")]
		[global::Cpp2ILInjected.Address(RVA = "0x92EDB4", Offset = "0x92EDB4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIElement), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Width", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StyleDimension), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Height", MemberParameters = new object[] { typeof(Asset<Texture2D>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public UISlicedImage(Asset<Texture2D> texture)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005158")]
		[global::Cpp2ILInjected.Address(RVA = "0x92EE88", Offset = "0x92EE88", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetImage(Asset<Texture2D> texture)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6005159")]
		[global::Cpp2ILInjected.Address(RVA = "0x92EE90", Offset = "0x92EE90", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600515A")]
		[global::Cpp2ILInjected.Address(RVA = "0x92EFA0", Offset = "0x92EFA0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetSliceDepths(int top, int bottom, int left, int right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600515B")]
		[global::Cpp2ILInjected.Address(RVA = "0x92EFB4", Offset = "0x92EFB4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetSliceDepths(int fluff)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40089E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private Asset<Texture2D> _texture;

		[global::Cpp2ILInjected.Token(Token = "0x40089E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private Color _color;

		[global::Cpp2ILInjected.Token(Token = "0x40089E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
		private int _leftSliceDepth;

		[global::Cpp2ILInjected.Token(Token = "0x40089EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private int _rightSliceDepth;

		[global::Cpp2ILInjected.Token(Token = "0x40089EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x15C")]
		private int _topSliceDepth;

		[global::Cpp2ILInjected.Token(Token = "0x40089EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private int _bottomSliceDepth;
	}
}
