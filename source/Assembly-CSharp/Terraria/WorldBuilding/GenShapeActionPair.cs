using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes.Desert;

namespace Terraria.WorldBuilding
{
	// Token: 0x02000361 RID: 865
	[global::Cpp2ILInjected.Token(Token = "0x20004D8")]
	public struct GenShapeActionPair
	{
		// Token: 0x06002C4A RID: 11338 RVA: 0x00029F09 File Offset: 0x00028109
		[global::Cpp2ILInjected.Token(Token = "0x600303D")]
		[global::Cpp2ILInjected.Address(RVA = "0x12F9B84", Offset = "0x12F9B84", Length = "0x8")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public GenShapeActionPair(GenShape shape, GenAction action)
		{
			throw null;
		}

		// Token: 0x040030CF RID: 12495
		[global::Cpp2ILInjected.Token(Token = "0x40039D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly GenShape Shape;

		// Token: 0x040030D0 RID: 12496
		[global::Cpp2ILInjected.Token(Token = "0x40039D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly GenAction Action;
	}
}
