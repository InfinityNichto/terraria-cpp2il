using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x0200045E RID: 1118
	[global::Cpp2ILInjected.Token(Token = "0x200065A")]
	public class EntitySource_SpawnNPC : IEntitySource
	{
		// Token: 0x060031DB RID: 12763 RVA: 0x0002AEC3 File Offset: 0x000290C3
		[global::Cpp2ILInjected.Token(Token = "0x60036F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D6AC", Offset = "0x141D6AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetSpawnSourceForNaturalSpawn", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetSpawnSourceForTownSpawn", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_SpawnNPC()
		{
			throw null;
		}
	}
}
