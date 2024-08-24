using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Shaders;

namespace Terraria.Graphics
{
	// Token: 0x020004E0 RID: 1248
	[global::Cpp2ILInjected.Token(Token = "0x2000736")]
	public class TileBatch : SpriteBatch
	{
		// Token: 0x060036AA RID: 13994 RVA: 0x0002BC43 File Offset: 0x00029E43
		[global::Cpp2ILInjected.Token(Token = "0x6003D0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x149A318", Offset = "0x149A318", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ThreadedRenderManager.RenderThreadInstance), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public TileBatch(GraphicsDevice graphicsDevice)
		{
			throw null;
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x0002BC46 File Offset: 0x00029E46
		[global::Cpp2ILInjected.Token(Token = "0x6003D0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x149A380", Offset = "0x149A380", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSimpleSurfaceBackground", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "StepLiquids", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "DrawWaves", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Draw(Texture2D texture, Vector4 destination, VertexColors colors)
		{
			throw null;
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x0002BC49 File Offset: 0x00029E49
		[global::Cpp2ILInjected.Token(Token = "0x6003D0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x149A4D4", Offset = "0x149A4D4", Length = "0x148")]
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
			typeof(Rectangle?),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Draw(Texture2D texture, Vector4 destination, Rectangle? sourceRectangle, VertexColors colors)
		{
			throw null;
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x0002BC4C File Offset: 0x00029E4C
		[global::Cpp2ILInjected.Token(Token = "0x6003D0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x149A61C", Offset = "0x149A61C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "DrawWaves", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		public void Draw(Texture2D texture, Vector4 destination, Rectangle? sourceRectangle, VertexColors colors, Vector2 origin, SpriteEffects effects, float rotation)
		{
			throw null;
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x0002BC4F File Offset: 0x00029E4F
		[global::Cpp2ILInjected.Token(Token = "0x6003D10")]
		[global::Cpp2ILInjected.Address(RVA = "0x149A6FC", Offset = "0x149A6FC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OldDrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(ref VertexColors),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		public void Draw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, ref VertexColors colors, Vector2 origin, float scale, SpriteEffects effects)
		{
			throw null;
		}
	}
}
