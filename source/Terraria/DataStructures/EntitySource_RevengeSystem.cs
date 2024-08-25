using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000667")]
	public class EntitySource_RevengeSystem : IEntitySource
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003705")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D840", Offset = "0x141D840", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoinLossRevengeSystem.RevengeMarker), Member = "SpawnEnemy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_RevengeSystem()
		{
			throw null;
		}
	}
}
