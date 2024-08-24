using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Drawing;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020004FF RID: 1279
	[global::Cpp2ILInjected.Token(Token = "0x200075B")]
	public class PrettySparkleParticle : ABasicParticle
	{
		// Token: 0x0600377C RID: 14204 RVA: 0x0002BEA4 File Offset: 0x0002A0A4
		[global::Cpp2ILInjected.Token(Token = "0x6003DF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A7D40", Offset = "0x14A7D40", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = "FetchFromPool", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void FetchFromPool()
		{
			throw null;
		}

		// Token: 0x0600377D RID: 14205 RVA: 0x0002BEA7 File Offset: 0x0002A0A7
		[global::Cpp2ILInjected.Token(Token = "0x6003DF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A7DD8", Offset = "0x14A7DD8", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = "Update", MemberParameters = new object[] { typeof(ref ParticleRendererSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void Update(ref ParticleRendererSettings settings)
		{
			throw null;
		}

		// Token: 0x0600377E RID: 14206 RVA: 0x0002BEAA File Offset: 0x0002A0AA
		[global::Cpp2ILInjected.Token(Token = "0x6003DF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A7EB0", Offset = "0x14A7EB0", Length = "0x4F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
			throw null;
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x0002BEAD File Offset: 0x0002A0AD
		[global::Cpp2ILInjected.Token(Token = "0x6003DF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A83A4", Offset = "0x14A83A4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "GetNewPrettySparkleParticle", ReturnType = typeof(PrettySparkleParticle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = ".ctor", ReturnType = typeof(void))]
		public PrettySparkleParticle()
		{
			throw null;
		}

		// Token: 0x040067D0 RID: 26576
		[global::Cpp2ILInjected.Token(Token = "0x4007CB8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public float FadeInNormalizedTime;

		// Token: 0x040067D1 RID: 26577
		[global::Cpp2ILInjected.Token(Token = "0x4007CB9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		public float FadeOutNormalizedTime;

		// Token: 0x040067D2 RID: 26578
		[global::Cpp2ILInjected.Token(Token = "0x4007CBA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public float TimeToLive;

		// Token: 0x040067D3 RID: 26579
		[global::Cpp2ILInjected.Token(Token = "0x4007CBB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		public Color ColorTint;

		// Token: 0x040067D4 RID: 26580
		[global::Cpp2ILInjected.Token(Token = "0x4007CBC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public float Opacity;

		// Token: 0x040067D5 RID: 26581
		[global::Cpp2ILInjected.Token(Token = "0x4007CBD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		public float AdditiveAmount;

		// Token: 0x040067D6 RID: 26582
		[global::Cpp2ILInjected.Token(Token = "0x4007CBE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public float FadeInEnd;

		// Token: 0x040067D7 RID: 26583
		[global::Cpp2ILInjected.Token(Token = "0x4007CBF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		public float FadeOutStart;

		// Token: 0x040067D8 RID: 26584
		[global::Cpp2ILInjected.Token(Token = "0x4007CC0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public float FadeOutEnd;

		// Token: 0x040067D9 RID: 26585
		[global::Cpp2ILInjected.Token(Token = "0x4007CC1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public bool DrawHorizontalAxis;

		// Token: 0x040067DA RID: 26586
		[global::Cpp2ILInjected.Token(Token = "0x4007CC2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9D")]
		public bool DrawVerticalAxis;

		// Token: 0x040067DB RID: 26587
		[global::Cpp2ILInjected.Token(Token = "0x4007CC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private float _timeSinceSpawn;
	}
}
