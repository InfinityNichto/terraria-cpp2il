using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Events;

namespace Terraria.DataStructures
{
	// Token: 0x0200046C RID: 1132
	[global::Cpp2ILInjected.Token(Token = "0x2000668")]
	public class EntitySource_WorldEvent : IEntitySource
	{
		// Token: 0x060031E9 RID: 12777 RVA: 0x0002AEED File Offset: 0x000290ED
		[global::Cpp2ILInjected.Token(Token = "0x6003706")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D848", Offset = "0x141D848", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "TriggerLunarApocalypse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CultistRitual), Member = "TrySpawning", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Event), Member = "DropStarterCrystals", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MysticLogFairiesEvent), Member = "TrySpawningFairies", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_WorldEvent()
		{
			throw null;
		}
	}
}
