using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Drawing;

namespace Terraria.Graphics.Renderers
{
	[global::Cpp2ILInjected.Token(Token = "0x2000757")]
	public class FadingParticle : ABasicParticle
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003DDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A67D4", Offset = "0x14A67D4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = "FetchFromPool", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void FetchFromPool()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A684C", Offset = "0x14A684C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetTypeInfo(float timeToLive)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A6854", Offset = "0x14A6854", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = "Update", MemberParameters = new object[] { typeof(ref ParticleRendererSettings) }, ReturnType = typeof(void))]
		public override void Update(ref ParticleRendererSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A6888", Offset = "0x14A6888", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A6A68", Offset = "0x14A6A68", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "GetNewFadingParticle", ReturnType = typeof(FadingParticle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public FadingParticle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007C98")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public float FadeInNormalizedTime;

		[global::Cpp2ILInjected.Token(Token = "0x4007C99")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		public float FadeOutNormalizedTime;

		[global::Cpp2ILInjected.Token(Token = "0x4007C9A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public Color ColorTint;

		[global::Cpp2ILInjected.Token(Token = "0x4007C9B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		private float _timeTolive;

		[global::Cpp2ILInjected.Token(Token = "0x4007C9C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private float _timeSinceSpawn;
	}
}
