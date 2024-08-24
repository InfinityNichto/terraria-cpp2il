using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x02000467 RID: 1127
	[global::Cpp2ILInjected.Token(Token = "0x2000663")]
	public class EntitySource_Loot : IEntitySource
	{
		// Token: 0x060031E4 RID: 12772 RVA: 0x0002AEDE File Offset: 0x000290DE
		[global::Cpp2ILInjected.Token(Token = "0x6003701")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D774", Offset = "0x141D774", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetItemSource_Loot", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "Kill", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "DropGeodeGems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_Loot(Entity entity)
		{
			throw null;
		}

		// Token: 0x0400641C RID: 25628
		[global::Cpp2ILInjected.Token(Token = "0x400780C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Entity Entity;
	}
}
