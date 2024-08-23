using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x0200054E RID: 1358
	[global::Cpp2ILInjected.Token(Token = "0x20007CA")]
	public abstract class AnOutlinedDrawRenderTargetContent : ARenderTargetContentByRequest
	{
		// Token: 0x060039CD RID: 14797 RVA: 0x0002C52B File Offset: 0x0002A72B
		[global::Cpp2ILInjected.Token(Token = "0x60040A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x772820", Offset = "0x772820", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UseColor(Color color)
		{
			throw null;
		}

		// Token: 0x060039CE RID: 14798 RVA: 0x0002C52E File Offset: 0x0002A72E
		[global::Cpp2ILInjected.Token(Token = "0x60040A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x772828", Offset = "0x772828", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void HandleUseReqest(GraphicsDevice device, SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060039CF RID: 14799
		[global::Cpp2ILInjected.Token(Token = "0x60040A5")]
		internal abstract void DrawTheContent(SpriteBatch spriteBatch);

		// Token: 0x060039D0 RID: 14800 RVA: 0x0002C531 File Offset: 0x0002A731
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

		// Token: 0x040068EF RID: 26863
		[global::Cpp2ILInjected.Token(Token = "0x4007E54")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		protected int width;

		// Token: 0x040068F0 RID: 26864
		[global::Cpp2ILInjected.Token(Token = "0x4007E55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected int height;

		// Token: 0x040068F1 RID: 26865
		[global::Cpp2ILInjected.Token(Token = "0x4007E56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public Color _borderColor;

		// Token: 0x040068F2 RID: 26866
		[global::Cpp2ILInjected.Token(Token = "0x4007E57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private EffectPass _coloringShader;

		// Token: 0x040068F3 RID: 26867
		[global::Cpp2ILInjected.Token(Token = "0x4007E58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private RenderTarget2D _helperTarget;
	}
}
