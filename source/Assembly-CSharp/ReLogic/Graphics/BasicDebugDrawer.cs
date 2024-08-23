using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.Golf;
using Terraria.Graphics;
using Terraria.UI;

namespace ReLogic.Graphics
{
	// Token: 0x02000736 RID: 1846
	[global::Cpp2ILInjected.Token(Token = "0x2000B36")]
	public class BasicDebugDrawer : IDebugDrawer, IDisposable
	{
		// Token: 0x060046F7 RID: 18167 RVA: 0x0002EAED File Offset: 0x0002CCED
		[global::Cpp2ILInjected.Token(Token = "0x60053B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x945250", Offset = "0x945250", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyGolfPredictionLine), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public BasicDebugDrawer(GraphicsDevice graphicsDevice)
		{
			throw null;
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x0002EAF0 File Offset: 0x0002CCF0
		[global::Cpp2ILInjected.Token(Token = "0x60053B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x945380", Offset = "0x945380", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyGolfPredictionLine), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(SpriteBatch),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix?), Member = ".ctor", MemberParameters = new object[] { typeof(Matrix) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Begin(Matrix matrix)
		{
			throw null;
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x0002EAF3 File Offset: 0x0002CCF3
		[global::Cpp2ILInjected.Token(Token = "0x60053B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x945464", Offset = "0x945464", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void Begin()
		{
			throw null;
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x0002EAF6 File Offset: 0x0002CCF6
		[global::Cpp2ILInjected.Token(Token = "0x60053B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x9454B8", Offset = "0x9454B8", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void DrawSquare(Vector4 positionAndSize, Color color)
		{
			throw null;
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x0002EAF9 File Offset: 0x0002CCF9
		[global::Cpp2ILInjected.Token(Token = "0x60053B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x94560C", Offset = "0x94560C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void DrawSquare(Vector2 position, Vector2 size, Color color)
		{
			throw null;
		}

		// Token: 0x060046FC RID: 18172 RVA: 0x0002EAFC File Offset: 0x0002CCFC
		[global::Cpp2ILInjected.Token(Token = "0x60053B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x945740", Offset = "0x945740", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DrawSquareFromCenter(Vector2 center, Vector2 size, float rotation, Color color)
		{
			throw null;
		}

		// Token: 0x060046FD RID: 18173 RVA: 0x0002EAFF File Offset: 0x0002CCFF
		[global::Cpp2ILInjected.Token(Token = "0x60053B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x945850", Offset = "0x945850", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UIElement), Member = "DrawDebugHitbox", MemberParameters = new object[]
		{
			typeof(BasicDebugDrawer),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(Vector2),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void DrawLine(Vector2 start, Vector2 end, float width, Color color)
		{
			throw null;
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x0002EB02 File Offset: 0x0002CD02
		[global::Cpp2ILInjected.Token(Token = "0x60053B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x9459C4", Offset = "0x9459C4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyGolfPredictionLine), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(SpriteBatch),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		public void End()
		{
			throw null;
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x0002EB05 File Offset: 0x0002CD05
		[global::Cpp2ILInjected.Token(Token = "0x60053B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x9459D0", Offset = "0x9459D0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsResource), Member = "Dispose", ReturnType = typeof(void))]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x0002EB08 File Offset: 0x0002CD08
		[global::Cpp2ILInjected.Token(Token = "0x60053B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x945A1C", Offset = "0x945A1C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x04007349 RID: 29513
		[global::Cpp2ILInjected.Token(Token = "0x4008CE8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private SpriteBatch _spriteBatch;

		// Token: 0x0400734A RID: 29514
		[global::Cpp2ILInjected.Token(Token = "0x4008CE9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Texture2D _texture;

		// Token: 0x0400734B RID: 29515
		[global::Cpp2ILInjected.Token(Token = "0x4008CEA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool _disposedValue;
	}
}
