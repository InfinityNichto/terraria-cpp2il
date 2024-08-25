using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Graphics;
using Terraria.Graphics.Renderers;

namespace Terraria.GameContent
{
	[global::Cpp2ILInjected.Token(Token = "0x20007C9")]
	public abstract class ARenderTargetContentByRequest : INeedRenderTargetContent
	{
		[global::Cpp2ILInjected.Token(Token = "0x170007BD")]
		public bool IsReady
		{
			[global::Cpp2ILInjected.Token(Token = "0x6004098")]
			[global::Cpp2ILInjected.Address(RVA = "0x7727B4", Offset = "0x7727B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6004099")]
		[global::Cpp2ILInjected.Address(RVA = "0x7727BC", Offset = "0x7727BC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(int),
			typeof(Player),
			typeof(Vector2),
			typeof(Color),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHeadRenderer), Member = "DrawPlayerHead", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Player),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCHeadRenderer), Member = "DrawWithOutlines", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(int),
			typeof(Vector2),
			typeof(Color),
			typeof(float),
			typeof(float),
			typeof(SpriteEffects)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public void Request()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600409A")]
		[global::Cpp2ILInjected.Address(RVA = "0x7727C8", Offset = "0x7727C8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public RenderTarget2D GetTarget()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600409B")]
		[global::Cpp2ILInjected.Address(RVA = "0x7727D0", Offset = "0x7727D0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHeadRenderer), Member = "PrepareRenderTarget", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPCHeadRenderer), Member = "PrepareRenderTarget", MemberParameters = new object[]
		{
			typeof(GraphicsDevice),
			typeof(SpriteBatch)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600409C")]
		protected abstract void HandleUseReqest(GraphicsDevice device, SpriteBatch spriteBatch);

		[global::Cpp2ILInjected.Token(Token = "0x600409D")]
		[global::Cpp2ILInjected.Address(RVA = "0x7727F0", Offset = "0x7727F0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void PrepareARenderTarget_AndListenToEvents(ref RenderTarget2D target, GraphicsDevice device, int neededWidth, int neededHeight, RenderTargetUsage usage)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600409E")]
		[global::Cpp2ILInjected.Address(RVA = "0x7727F4", Offset = "0x7727F4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void target_Disposing(object sender, EventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600409F")]
		[global::Cpp2ILInjected.Address(RVA = "0x772800", Offset = "0x772800", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void target_ContentLost(object sender, EventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x772808", Offset = "0x772808", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHeadRenderer), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x772814", Offset = "0x772814", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected void PrepareARenderTarget_WithoutListeningToEvents(ref RenderTarget2D target, GraphicsDevice device, int neededWidth, int neededHeight, RenderTargetUsage usage)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60040A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x772818", Offset = "0x772818", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected ARenderTargetContentByRequest()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007E51")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected RenderTarget2D _target;

		[global::Cpp2ILInjected.Token(Token = "0x4007E52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected bool _wasPrepared;

		[global::Cpp2ILInjected.Token(Token = "0x4007E53")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool _wasRequested;
	}
}
