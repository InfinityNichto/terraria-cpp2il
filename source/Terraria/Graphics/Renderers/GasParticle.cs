using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Drawing;
using Terraria.Utilities;

namespace Terraria.Graphics.Renderers
{
	[global::Cpp2ILInjected.Token(Token = "0x200075A")]
	public class GasParticle : ABasicParticle
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003DEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A7584", Offset = "0x14A7584", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = "FetchFromPool", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void FetchFromPool()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A7668", Offset = "0x14A7668", Length = "0x2E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = "Update", MemberParameters = new object[] { typeof(ref ParticleRendererSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Remap", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Clamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void Update(ref ParticleRendererSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A7950", Offset = "0x14A7950", Length = "0x3B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadProjectile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Frame", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Rectangle))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A7D08", Offset = "0x14A7D08", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "GetNewGasParticle", ReturnType = typeof(GasParticle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ABasicParticle), Member = ".ctor", ReturnType = typeof(void))]
		public GasParticle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007CAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public float FadeInNormalizedTime;

		[global::Cpp2ILInjected.Token(Token = "0x4007CAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		public float FadeOutNormalizedTime;

		[global::Cpp2ILInjected.Token(Token = "0x4007CAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public float TimeToLive;

		[global::Cpp2ILInjected.Token(Token = "0x4007CAD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		public Color ColorTint;

		[global::Cpp2ILInjected.Token(Token = "0x4007CAE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public float Opacity;

		[global::Cpp2ILInjected.Token(Token = "0x4007CAF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		public float AdditiveAmount;

		[global::Cpp2ILInjected.Token(Token = "0x4007CB0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public float FadeInEnd;

		[global::Cpp2ILInjected.Token(Token = "0x4007CB1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		public float FadeOutStart;

		[global::Cpp2ILInjected.Token(Token = "0x4007CB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public float FadeOutEnd;

		[global::Cpp2ILInjected.Token(Token = "0x4007CB3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		public float SlowdownScalar;

		[global::Cpp2ILInjected.Token(Token = "0x4007CB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private float _timeSinceSpawn;

		[global::Cpp2ILInjected.Token(Token = "0x4007CB5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
		public Color LightColorTint;

		[global::Cpp2ILInjected.Token(Token = "0x4007CB6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private int _internalIndentifier;

		[global::Cpp2ILInjected.Token(Token = "0x4007CB7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		public float InitialScale;
	}
}
