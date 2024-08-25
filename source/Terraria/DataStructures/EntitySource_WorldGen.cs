using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200065E")]
	public class EntitySource_WorldGen : IEntitySource
	{
		[global::Cpp2ILInjected.Token(Token = "0x60036FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D6CC", Offset = "0x141D6CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_79", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "DungeonEnt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(ushort),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_WorldGen()
		{
			throw null;
		}
	}
}
