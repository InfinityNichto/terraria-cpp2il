using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.Desert;
using Terraria.GameContent.Generation;
using Terraria.IO;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000354 RID: 852
	[global::Cpp2ILInjected.Token(Token = "0x200048B")]
	public abstract class GenAction : GenBase
	{
		// Token: 0x06002C23 RID: 11299
		[global::Cpp2ILInjected.Token(Token = "0x6002F89")]
		public abstract bool Apply(Point origin, int x, int y, params object[] args);

		// Token: 0x06002C24 RID: 11300 RVA: 0x00029EA0 File Offset: 0x000280A0
		[global::Cpp2ILInjected.Token(Token = "0x6002F8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3E08", Offset = "0x12F3E08", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 51)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShapeData), Member = "Add", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected bool UnitApply(Point origin, int x, int y, params object[] args)
		{
			throw null;
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x00029EA3 File Offset: 0x000280A3
		[global::Cpp2ILInjected.Token(Token = "0x6002F8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3F08", Offset = "0x12F3F08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public GenAction IgnoreFailures()
		{
			throw null;
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x00029EA6 File Offset: 0x000280A6
		[global::Cpp2ILInjected.Token(Token = "0x6002F8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3F10", Offset = "0x12F3F10", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected bool Fail()
		{
			throw null;
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x00029EA9 File Offset: 0x000280A9
		[global::Cpp2ILInjected.Token(Token = "0x6002F8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3F20", Offset = "0x12F3F20", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_55", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "smCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CampsiteBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CorruptionPitBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnchantedSwordBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HoneyPatchBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AnthillEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChambersEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LarvaHoleEntrance), Member = "PlaceAt", MemberParameters = new object[]
		{
			typeof(DesertDescription),
			typeof(Point),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		public GenAction Output(ShapeData data)
		{
			throw null;
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x00029EAC File Offset: 0x000280AC
		[global::Cpp2ILInjected.Token(Token = "0x6002F8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F3F28", Offset = "0x12F3F28", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActionGrass), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActionPlaceStatue), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActionStalagtite), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ActionVines), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnchantedSwordBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected GenAction()
		{
			throw null;
		}

		// Token: 0x040030BD RID: 12477
		[global::Cpp2ILInjected.Token(Token = "0x4003973")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public GenAction NextAction;

		// Token: 0x040030BE RID: 12478
		[global::Cpp2ILInjected.Token(Token = "0x4003974")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public ShapeData OutputData;

		// Token: 0x040030BF RID: 12479
		[global::Cpp2ILInjected.Token(Token = "0x4003975")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool _returnFalseOnFailure;
	}
}
