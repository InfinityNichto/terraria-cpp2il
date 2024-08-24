using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Ambience;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.NetModules;
using Terraria.IO;
using Terraria.Net;
using Terraria.WorldBuilding;

namespace Terraria.Utilities
{
	// Token: 0x0200037A RID: 890
	[global::Cpp2ILInjected.Token(Token = "0x2000508")]
	[Serializable]
	public class UnifiedRandom
	{
		// Token: 0x06002CE7 RID: 11495 RVA: 0x0002A0DA File Offset: 0x000282DA
		[global::Cpp2ILInjected.Token(Token = "0x600311C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1303468", Offset = "0x1303468", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 43)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_TickCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		public UnifiedRandom()
		{
			throw null;
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x0002A0DD File Offset: 0x000282DD
		[global::Cpp2ILInjected.Token(Token = "0x600311D")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FEC70", Offset = "0x12FEC70", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "SetSeed", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UnifiedRandom(int Seed)
		{
			throw null;
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x0002A0E0 File Offset: 0x000282E0
		[global::Cpp2ILInjected.Token(Token = "0x600311E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1303488", Offset = "0x1303488", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnifiedRandom), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetSeed(int Seed)
		{
			throw null;
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x0002A0E3 File Offset: 0x000282E3
		[global::Cpp2ILInjected.Token(Token = "0x600311F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1303624", Offset = "0x1303624", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "InternalSample", ReturnType = typeof(int))]
		protected double Sample()
		{
			throw null;
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x0002A0E6 File Offset: 0x000282E6
		[global::Cpp2ILInjected.Token(Token = "0x6003120")]
		[global::Cpp2ILInjected.Address(RVA = "0x1303644", Offset = "0x1303644", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Modifiers.RadialDither), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Modifiers.Blotches), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Modifiers.Dither), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(int),
			typeof(int),
			typeof(object[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnifiedRandom), Member = "Sample", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnifiedRandom), Member = "Next", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnifiedRandom), Member = "GetSampleForLargeRange", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnifiedRandom), Member = "NextDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnifiedRandom), Member = "NextBytes", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		private int InternalSample()
		{
			throw null;
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x0002A0E9 File Offset: 0x000282E9
		[global::Cpp2ILInjected.Token(Token = "0x6003121")]
		[global::Cpp2ILInjected.Address(RVA = "0x13036AC", Offset = "0x13036AC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldCreateMenu), Member = "GenerateSeed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ModifyFlexibleWandPlacementInfo", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int?)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFileData), Member = "SetSeedToRandom", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CampsiteBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_PetExchange", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetAmbienceModule), Member = "SerializeSkyEntitySpawn", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(SkyEntityType)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Events.BirthdayParty.<>c", Member = "<NaturalAttempt>b__10_0", MemberParameters = new object[] { typeof(NPC) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "InternalSample", ReturnType = typeof(int))]
		public int Next()
		{
			throw null;
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x0002A0EC File Offset: 0x000282EC
		[global::Cpp2ILInjected.Token(Token = "0x6003122")]
		[global::Cpp2ILInjected.Address(RVA = "0x13036B0", Offset = "0x13036B0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "InternalSample", ReturnType = typeof(int))]
		private double GetSampleForLargeRange()
		{
			throw null;
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x0002A0EF File Offset: 0x000282EF
		[global::Cpp2ILInjected.Token(Token = "0x6003123")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F6F7C", Offset = "0x12F6F7C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3797)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "GetSampleForLargeRange", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "InternalSample", ReturnType = typeof(int))]
		public int Next(int minValue, int maxValue)
		{
			throw null;
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x0002A0F2 File Offset: 0x000282F2
		[global::Cpp2ILInjected.Token(Token = "0x6003124")]
		[global::Cpp2ILInjected.Address(RVA = "0x13036FC", Offset = "0x13036FC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4971)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "InternalSample", ReturnType = typeof(int))]
		public int Next(int maxValue)
		{
			throw null;
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x0002A0F5 File Offset: 0x000282F5
		[global::Cpp2ILInjected.Token(Token = "0x6003125")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F6D04", Offset = "0x12F6D04", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 301)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "InternalSample", ReturnType = typeof(int))]
		public double NextDouble()
		{
			throw null;
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x0002A0F8 File Offset: 0x000282F8
		[global::Cpp2ILInjected.Token(Token = "0x6003126")]
		[global::Cpp2ILInjected.Address(RVA = "0x1303740", Offset = "0x1303740", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "InternalSample", ReturnType = typeof(int))]
		public void NextBytes(byte[] buffer)
		{
			throw null;
		}

		// Token: 0x04003197 RID: 12695
		[global::Cpp2ILInjected.Token(Token = "0x4003AF0")]
		private const int MBIG = 2147483647;

		// Token: 0x04003198 RID: 12696
		[global::Cpp2ILInjected.Token(Token = "0x4003AF1")]
		private const int MSEED = 161803398;

		// Token: 0x04003199 RID: 12697
		[global::Cpp2ILInjected.Token(Token = "0x4003AF2")]
		private const int MZ = 0;

		// Token: 0x0400319A RID: 12698
		[global::Cpp2ILInjected.Token(Token = "0x4003AF3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int inext;

		// Token: 0x0400319B RID: 12699
		[global::Cpp2ILInjected.Token(Token = "0x4003AF4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int inextp;

		// Token: 0x0400319C RID: 12700
		[global::Cpp2ILInjected.Token(Token = "0x4003AF5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int[] SeedArray;

		// Token: 0x0400319D RID: 12701
		[global::Cpp2ILInjected.Token(Token = "0x4003AF6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public bool debug;
	}
}
