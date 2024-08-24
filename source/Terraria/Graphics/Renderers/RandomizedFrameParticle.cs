using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.GameContent.Drawing;
using Terraria.Utilities;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020004FD RID: 1277
	[global::Cpp2ILInjected.Token(Token = "0x2000759")]
	public class RandomizedFrameParticle : ABasicParticle
	{
		// Token: 0x06003772 RID: 14194 RVA: 0x0002BE86 File Offset: 0x0002A086
		[global::Cpp2ILInjected.Token(Token = "0x6003DE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A7128", Offset = "0x14A7128", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = "FetchFromPool", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void FetchFromPool()
		{
			throw null;
		}

		// Token: 0x06003773 RID: 14195 RVA: 0x0002BE89 File Offset: 0x0002A089
		[global::Cpp2ILInjected.Token(Token = "0x6003DEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A71A8", Offset = "0x14A71A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_BlackLightningSmall", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_BlackLightningHit", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void SetTypeInfo(int animationFramesAmount, int gameFramesPerAnimationFrame, float timeToLive)
		{
			throw null;
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x0002BE8C File Offset: 0x0002A08C
		[global::Cpp2ILInjected.Token(Token = "0x6003DEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A71B4", Offset = "0x14A71B4", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RandomizedFrameParticle), Member = "Update", MemberParameters = new object[] { typeof(ref ParticleRendererSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void RandomizeFrame()
		{
			throw null;
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x0002BE8F File Offset: 0x0002A08F
		[global::Cpp2ILInjected.Token(Token = "0x6003DEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A72DC", Offset = "0x14A72DC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = "Update", MemberParameters = new object[] { typeof(ref ParticleRendererSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RandomizedFrameParticle), Member = "RandomizeFrame", ReturnType = typeof(void))]
		public override void Update(ref ParticleRendererSettings settings)
		{
			throw null;
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x0002BE92 File Offset: 0x0002A092
		[global::Cpp2ILInjected.Token(Token = "0x6003DED")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A7338", Offset = "0x14A7338", Length = "0x1E0")]
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

		// Token: 0x06003777 RID: 14199 RVA: 0x0002BE95 File Offset: 0x0002A095
		[global::Cpp2ILInjected.Token(Token = "0x6003DEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A7518", Offset = "0x14A7518", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "GetNewRandomizedFrameParticle", ReturnType = typeof(RandomizedFrameParticle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RandomizedFrameParticle()
		{
			throw null;
		}

		// Token: 0x040067BA RID: 26554
		[global::Cpp2ILInjected.Token(Token = "0x4007CA2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public float FadeInNormalizedTime;

		// Token: 0x040067BB RID: 26555
		[global::Cpp2ILInjected.Token(Token = "0x4007CA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		public float FadeOutNormalizedTime;

		// Token: 0x040067BC RID: 26556
		[global::Cpp2ILInjected.Token(Token = "0x4007CA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public Color ColorTint;

		// Token: 0x040067BD RID: 26557
		[global::Cpp2ILInjected.Token(Token = "0x4007CA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		public int AnimationFramesAmount;

		// Token: 0x040067BE RID: 26558
		[global::Cpp2ILInjected.Token(Token = "0x4007CA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public int GameFramesPerAnimationFrame;

		// Token: 0x040067BF RID: 26559
		[global::Cpp2ILInjected.Token(Token = "0x4007CA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private float _timeTolive;

		// Token: 0x040067C0 RID: 26560
		[global::Cpp2ILInjected.Token(Token = "0x4007CA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private float _timeSinceSpawn;

		// Token: 0x040067C1 RID: 26561
		[global::Cpp2ILInjected.Token(Token = "0x4007CA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		private int _gameFramesCounted;
	}
}
