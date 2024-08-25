using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Renderers
{
	[global::Cpp2ILInjected.Token(Token = "0x2000756")]
	public abstract class ABasicParticle : IPooledParticle, IParticle
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700078A")]
		public bool ShouldBeRemovedFromRenderer
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003DD4")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A6118", Offset = "0x14A6118", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003DD5")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A6120", Offset = "0x14A6120", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A612C", Offset = "0x14A612C", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FadingParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlameParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RandomizedFrameParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GasParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrettySparkleParticle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public ABasicParticle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DD7")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A62C4", Offset = "0x14A62C4", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlameParticle), Member = "SetBasicInfo", MemberParameters = new object[]
		{
			typeof(Asset<Texture2D>),
			typeof(Rectangle?),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = "get_Value", ReturnType = "T")]
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
		public virtual void SetBasicInfo(Asset<Texture2D> textureAsset, Rectangle? frame, Vector2 initialVelocity, Vector2 initialLocalPosition)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DD8")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A6428", Offset = "0x14A6428", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FadingParticle), Member = "Update", MemberParameters = new object[] { typeof(ref ParticleRendererSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlameParticle), Member = "Update", MemberParameters = new object[] { typeof(ref ParticleRendererSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RandomizedFrameParticle), Member = "Update", MemberParameters = new object[] { typeof(ref ParticleRendererSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GasParticle), Member = "Update", MemberParameters = new object[] { typeof(ref ParticleRendererSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrettySparkleParticle), Member = "Update", MemberParameters = new object[] { typeof(ref ParticleRendererSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void Update(ref ParticleRendererSettings settings)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DD9")]
		public abstract void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch);

		[global::Cpp2ILInjected.Token(Token = "0x1700078B")]
		public bool IsRestingInPool
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003DDA")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A6504", Offset = "0x14A6504", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003DDB")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A650C", Offset = "0x14A650C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A6518", Offset = "0x14A6518", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void RestInPool()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003DDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A6524", Offset = "0x14A6524", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FadingParticle), Member = "FetchFromPool", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FlameParticle), Member = "FetchFromPool", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RandomizedFrameParticle), Member = "FetchFromPool", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GasParticle), Member = "FetchFromPool", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PrettySparkleParticle), Member = "FetchFromPool", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public virtual void FetchFromPool()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007C8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <ShouldBeRemovedFromRenderer>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4007C8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Vector2 AccelerationPerFrame;

		[global::Cpp2ILInjected.Token(Token = "0x4007C8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public Vector2 Velocity;

		[global::Cpp2ILInjected.Token(Token = "0x4007C8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public Vector2 LocalPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4007C8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected Asset<Texture2D> _texture;

		[global::Cpp2ILInjected.Token(Token = "0x4007C8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		protected Rectangle _frame;

		[global::Cpp2ILInjected.Token(Token = "0x4007C90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		protected Vector2 _origin;

		[global::Cpp2ILInjected.Token(Token = "0x4007C91")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public float Rotation;

		[global::Cpp2ILInjected.Token(Token = "0x4007C92")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public float RotationVelocity;

		[global::Cpp2ILInjected.Token(Token = "0x4007C93")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public float RotationAcceleration;

		[global::Cpp2ILInjected.Token(Token = "0x4007C94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public Vector2 Scale;

		[global::Cpp2ILInjected.Token(Token = "0x4007C95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public Vector2 ScaleVelocity;

		[global::Cpp2ILInjected.Token(Token = "0x4007C96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		public Vector2 ScaleAcceleration;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007C97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private bool <IsRestingInPool>k__BackingField;
	}
}
