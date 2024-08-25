using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.UI;

namespace Terraria.GameContent.UI.Elements
{
	[global::Cpp2ILInjected.Token(Token = "0x2000AD5")]
	public class UIWorldCreationPreview : UIElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x600519C")]
		[global::Cpp2ILInjected.Address(RVA = "0x930E1C", Offset = "0x930E1C", Length = "0x9E4")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 49)]
		public UIWorldCreationPreview()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600519D")]
		[global::Cpp2ILInjected.Address(RVA = "0x931800", Offset = "0x931800", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UpdateOption(byte difficulty, byte evil, byte size)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600519E")]
		[global::Cpp2ILInjected.Address(RVA = "0x931810", Offset = "0x931810", Length = "0x2D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected override void DrawSelf(SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4008A20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private readonly Asset<Texture2D> _BorderTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private readonly Asset<Texture2D> _BackgroundExpertTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private readonly Asset<Texture2D> _BackgroundNormalTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private readonly Asset<Texture2D> _BackgroundMasterTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private readonly Asset<Texture2D> _BunnyExpertTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private readonly Asset<Texture2D> _BunnyNormalTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private readonly Asset<Texture2D> _BunnyCreativeTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private readonly Asset<Texture2D> _BunnyMasterTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		private readonly Asset<Texture2D> _EvilRandomTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		private readonly Asset<Texture2D> _EvilCorruptionTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
		private readonly Asset<Texture2D> _EvilCrimsonTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
		private readonly Asset<Texture2D> _SizeSmallTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
		private readonly Asset<Texture2D> _SizeMediumTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
		private readonly Asset<Texture2D> _SizeLargeTexture;

		[global::Cpp2ILInjected.Token(Token = "0x4008A2E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
		private byte _difficulty;

		[global::Cpp2ILInjected.Token(Token = "0x4008A2F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B9")]
		private byte _evil;

		[global::Cpp2ILInjected.Token(Token = "0x4008A30")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1BA")]
		private byte _size;
	}
}
