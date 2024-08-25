using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Drawing;

namespace Terraria.Graphics.Renderers
{
	[global::Cpp2ILInjected.Token(Token = "0x200075B")]
	public class PrettySparkleParticle : ABasicParticle
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4007CB8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public float FadeInNormalizedTime;

		[global::Cpp2ILInjected.Token(Token = "0x4007CB9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		public float FadeOutNormalizedTime;

		[global::Cpp2ILInjected.Token(Token = "0x4007CBA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public float TimeToLive;

		[global::Cpp2ILInjected.Token(Token = "0x4007CBB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		public Color ColorTint;

		[global::Cpp2ILInjected.Token(Token = "0x4007CBC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public float Opacity;

		[global::Cpp2ILInjected.Token(Token = "0x4007CBD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		public float AdditiveAmount;

		[global::Cpp2ILInjected.Token(Token = "0x4007CBE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public float FadeInEnd;

		[global::Cpp2ILInjected.Token(Token = "0x4007CBF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		public float FadeOutStart;

		[global::Cpp2ILInjected.Token(Token = "0x4007CC0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public float FadeOutEnd;

		[global::Cpp2ILInjected.Token(Token = "0x4007CC1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public bool DrawHorizontalAxis;

		[global::Cpp2ILInjected.Token(Token = "0x4007CC2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9D")]
		public bool DrawVerticalAxis;

		[global::Cpp2ILInjected.Token(Token = "0x4007CC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private float _timeSinceSpawn;
	}
}
