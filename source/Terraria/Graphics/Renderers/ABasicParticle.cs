using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020004FA RID: 1274
	[global::Cpp2ILInjected.Token(Token = "0x2000756")]
	public abstract class ABasicParticle : IPooledParticle, IParticle
	{
		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x0600375D RID: 14173 RVA: 0x0002BE4A File Offset: 0x0002A04A
		// (set) Token: 0x0600375E RID: 14174 RVA: 0x0002BE4D File Offset: 0x0002A04D
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

		// Token: 0x0600375F RID: 14175 RVA: 0x0002BE50 File Offset: 0x0002A050
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

		// Token: 0x06003760 RID: 14176 RVA: 0x0002BE53 File Offset: 0x0002A053
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

		// Token: 0x06003761 RID: 14177 RVA: 0x0002BE56 File Offset: 0x0002A056
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

		// Token: 0x06003762 RID: 14178
		[global::Cpp2ILInjected.Token(Token = "0x6003DD9")]
		public abstract void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch);

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06003763 RID: 14179 RVA: 0x0002BE59 File Offset: 0x0002A059
		// (set) Token: 0x06003764 RID: 14180 RVA: 0x0002BE5C File Offset: 0x0002A05C
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

		// Token: 0x06003765 RID: 14181 RVA: 0x0002BE5F File Offset: 0x0002A05F
		[global::Cpp2ILInjected.Token(Token = "0x6003DDC")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A6518", Offset = "0x14A6518", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void RestInPool()
		{
			throw null;
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x0002BE62 File Offset: 0x0002A062
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

		// Token: 0x040067A2 RID: 26530
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007C8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool <ShouldBeRemovedFromRenderer>k__BackingField;

		// Token: 0x040067A3 RID: 26531
		[global::Cpp2ILInjected.Token(Token = "0x4007C8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public Vector2 AccelerationPerFrame;

		// Token: 0x040067A4 RID: 26532
		[global::Cpp2ILInjected.Token(Token = "0x4007C8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public Vector2 Velocity;

		// Token: 0x040067A5 RID: 26533
		[global::Cpp2ILInjected.Token(Token = "0x4007C8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public Vector2 LocalPosition;

		// Token: 0x040067A6 RID: 26534
		[global::Cpp2ILInjected.Token(Token = "0x4007C8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected Asset<Texture2D> _texture;

		// Token: 0x040067A7 RID: 26535
		[global::Cpp2ILInjected.Token(Token = "0x4007C8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		protected Rectangle _frame;

		// Token: 0x040067A8 RID: 26536
		[global::Cpp2ILInjected.Token(Token = "0x4007C90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		protected Vector2 _origin;

		// Token: 0x040067A9 RID: 26537
		[global::Cpp2ILInjected.Token(Token = "0x4007C91")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public float Rotation;

		// Token: 0x040067AA RID: 26538
		[global::Cpp2ILInjected.Token(Token = "0x4007C92")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public float RotationVelocity;

		// Token: 0x040067AB RID: 26539
		[global::Cpp2ILInjected.Token(Token = "0x4007C93")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public float RotationAcceleration;

		// Token: 0x040067AC RID: 26540
		[global::Cpp2ILInjected.Token(Token = "0x4007C94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public Vector2 Scale;

		// Token: 0x040067AD RID: 26541
		[global::Cpp2ILInjected.Token(Token = "0x4007C95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public Vector2 ScaleVelocity;

		// Token: 0x040067AE RID: 26542
		[global::Cpp2ILInjected.Token(Token = "0x4007C96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		public Vector2 ScaleAcceleration;

		// Token: 0x040067AF RID: 26543
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007C97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private bool <IsRestingInPool>k__BackingField;
	}
}
