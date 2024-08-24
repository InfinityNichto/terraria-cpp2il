using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes;
using Terraria.GameContent.Biomes.CaveHouse;
using Terraria.WorldBuilding;

namespace Terraria
{
	// Token: 0x02000342 RID: 834
	[global::Cpp2ILInjected.Token(Token = "0x2000458")]
	public class Ref<T>
	{
		// Token: 0x06002721 RID: 10017 RVA: 0x00028F9A File Offset: 0x0002719A
		[global::Cpp2ILInjected.Token(Token = "0x60029DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1862904", Offset = "0x1862904", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Ref()
		{
			throw null;
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x00028F9D File Offset: 0x0002719D
		[global::Cpp2ILInjected.Token(Token = "0x60029DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x186290C", Offset = "0x186290C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CampsiteBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HiveBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HoneyPatchBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MiningExplosivesBiome), Member = "Place", MemberParameters = new object[]
		{
			typeof(Point),
			typeof(StructureMap)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HouseUtils), Member = "GetRoomSolidPrecentage", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Ref(T value)
		{
			throw null;
		}

		// Token: 0x04002F12 RID: 12050
		[global::Cpp2ILInjected.Token(Token = "0x40036F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public T Value;
	}
}
