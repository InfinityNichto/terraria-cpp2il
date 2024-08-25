using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007CA")]
	public abstract class AnOutlinedDrawRenderTargetContent : ARenderTargetContentByRequest
	{
		[global::Cpp2ILInjected.Token(Token = "0x60040A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x772820", Offset = "0x772820", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UseColor(Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x772828", Offset = "0x772828", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void HandleUseReqest(GraphicsDevice device, SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040A5")]
		internal abstract void DrawTheContent(SpriteBatch spriteBatch);

		[global::Cpp2ILInjected.Token(Token = "0x60040A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x77282C", Offset = "0x77282C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerHeadDrawRenderTargetContent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCHeadDrawRenderTargetContent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected AnOutlinedDrawRenderTargetContent()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007E54")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		protected int width;

		[global::Cpp2ILInjected.Token(Token = "0x4007E55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected int height;

		[global::Cpp2ILInjected.Token(Token = "0x4007E56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public Color _borderColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007E57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private EffectPass _coloringShader;

		[global::Cpp2ILInjected.Token(Token = "0x4007E58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private RenderTarget2D _helperTarget;
	}
}
