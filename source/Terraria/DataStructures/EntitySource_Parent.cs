using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x02000450 RID: 1104
	[global::Cpp2ILInjected.Token(Token = "0x200064C")]
	public class EntitySource_Parent : IEntitySource
	{
		// Token: 0x060031CD RID: 12749 RVA: 0x0002AE99 File Offset: 0x00029099
		[global::Cpp2ILInjected.Token(Token = "0x60036EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D340", Offset = "0x141D340", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "GetNPCSource_FromThis", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetSpawnSource_NPCRelease", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetSpawnSource_NPCCatch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetSpawnSource_NPCHurt", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetSpawnSource_ForProjectile", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetSpawnSourceForProjectileNPC", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "GetSpawnSourceForNPCFromNPCAI", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "GetNPCSource_FromThis", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "GetProjectileSource_FromThis", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "GetItemSource_FromThis", ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_Parent(Entity entity)
		{
			throw null;
		}

		// Token: 0x04006407 RID: 25607
		[global::Cpp2ILInjected.Token(Token = "0x40077F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Entity Entity;
	}
}
