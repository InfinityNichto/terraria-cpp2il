﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Drawing;
using Terraria.Utilities;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020004F7 RID: 1271
	[global::Cpp2ILInjected.Token(Token = "0x2000753")]
	public class LittleFlyingCritterParticle : IPooledParticle, IParticle
	{
		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06003743 RID: 14147 RVA: 0x0002BDFC File Offset: 0x00029FFC
		// (set) Token: 0x06003744 RID: 14148 RVA: 0x0002BDFF File Offset: 0x00029FFF
		[global::Cpp2ILInjected.Token(Token = "0x17000785")]
		public bool IsRestingInPool
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003DBA")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A3D28", Offset = "0x14A3D28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003DBB")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A3D30", Offset = "0x14A3D30", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06003745 RID: 14149 RVA: 0x0002BE02 File Offset: 0x0002A002
		// (set) Token: 0x06003746 RID: 14150 RVA: 0x0002BE05 File Offset: 0x0002A005
		[global::Cpp2ILInjected.Token(Token = "0x17000786")]
		public bool ShouldBeRemovedFromRenderer
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003DBC")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A3D3C", Offset = "0x14A3D3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003DBD")]
			[global::Cpp2ILInjected.Address(RVA = "0x14A3D44", Offset = "0x14A3D44", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x0002BE08 File Offset: 0x0002A008
		[global::Cpp2ILInjected.Token(Token = "0x6003DBE")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3D50", Offset = "0x14A3D50", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "GetNewPooFlyParticle", ReturnType = typeof(LittleFlyingCritterParticle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LittleFlyingCritterParticle()
		{
			throw null;
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x0002BE0B File Offset: 0x0002A00B
		[global::Cpp2ILInjected.Token(Token = "0x6003DBF")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3D58", Offset = "0x14A3D58", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_PooFly", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LittleFlyingCritterParticle), Member = "RandomizeVelocity", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void Prepare(Vector2 position, int duration)
		{
			throw null;
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x0002BE0E File Offset: 0x0002A00E
		[global::Cpp2ILInjected.Token(Token = "0x6003DC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3EA4", Offset = "0x14A3EA4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LittleFlyingCritterParticle), Member = "Prepare", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LittleFlyingCritterParticle), Member = "Update", MemberParameters = new object[] { typeof(ref ParticleRendererSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextVector2Circular", MemberParameters = new object[]
		{
			typeof(UnifiedRandom),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void RandomizeVelocity()
		{
			throw null;
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x0002BE11 File Offset: 0x0002A011
		[global::Cpp2ILInjected.Token(Token = "0x6003DC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3F40", Offset = "0x14A3F40", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void RestInPool()
		{
			throw null;
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x0002BE14 File Offset: 0x0002A014
		[global::Cpp2ILInjected.Token(Token = "0x6003DC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3F4C", Offset = "0x14A3F4C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void FetchFromPool()
		{
			throw null;
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x0002BE17 File Offset: 0x0002A017
		[global::Cpp2ILInjected.Token(Token = "0x6003DC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A3F54", Offset = "0x14A3F54", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LittleFlyingCritterParticle), Member = "RandomizeVelocity", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Update(ref ParticleRendererSettings settings)
		{
			throw null;
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x0002BE1A File Offset: 0x0002A01A
		[global::Cpp2ILInjected.Token(Token = "0x6003DC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x14A4190", Offset = "0x14A4190", Length = "0x1434")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenHeight", ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Remap", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToTileCoordinates", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
			throw null;
		}

		// Token: 0x04006787 RID: 26503
		[global::Cpp2ILInjected.Token(Token = "0x4007C6F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _lifeTimeCounted;

		// Token: 0x04006788 RID: 26504
		[global::Cpp2ILInjected.Token(Token = "0x4007C70")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _lifeTimeTotal;

		// Token: 0x04006789 RID: 26505
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007C71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool <IsRestingInPool>k__BackingField;

		// Token: 0x0400678A RID: 26506
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4007C72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		private bool <ShouldBeRemovedFromRenderer>k__BackingField;

		// Token: 0x0400678B RID: 26507
		[global::Cpp2ILInjected.Token(Token = "0x4007C73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private Vector2 _spawnPosition;

		// Token: 0x0400678C RID: 26508
		[global::Cpp2ILInjected.Token(Token = "0x4007C74")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private Vector2 _localPosition;

		// Token: 0x0400678D RID: 26509
		[global::Cpp2ILInjected.Token(Token = "0x4007C75")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private Vector2 _velocity;

		// Token: 0x0400678E RID: 26510
		[global::Cpp2ILInjected.Token(Token = "0x4007C76")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private float _neverGoBelowThis;
	}
}