using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Biomes.Desert;

namespace Terraria.WorldBuilding
{
	[global::Cpp2ILInjected.Token(Token = "0x20004D8")]
	public struct GenShapeActionPair
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x40039D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly GenShape Shape;

		[global::Cpp2ILInjected.Token(Token = "0x40039D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly GenAction Action;
	}
}
