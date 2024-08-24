using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x02000463 RID: 1123
	[global::Cpp2ILInjected.Token(Token = "0x200065F")]
	public class EntitySource_BossSpawn : IEntitySource
	{
		// Token: 0x060031E0 RID: 12768 RVA: 0x0002AED2 File Offset: 0x000290D2
		[global::Cpp2ILInjected.Token(Token = "0x60036FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D6D4", Offset = "0x141D6D4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetBossSpawnSource", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_BossSpawn(Entity entity)
		{
			throw null;
		}

		// Token: 0x04006418 RID: 25624
		[global::Cpp2ILInjected.Token(Token = "0x4007808")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Entity Entity;
	}
}
