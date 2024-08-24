using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x02000455 RID: 1109
	[global::Cpp2ILInjected.Token(Token = "0x2000651")]
	public class EntitySource_Mount : IEntitySource
	{
		// Token: 0x060031D2 RID: 12754 RVA: 0x0002AEA8 File Offset: 0x000290A8
		[global::Cpp2ILInjected.Token(Token = "0x60036EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D43C", Offset = "0x141D43C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "GetProjectileSpawnSource", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_Mount(Entity entity, int mountId)
		{
			throw null;
		}

		// Token: 0x04006410 RID: 25616
		[global::Cpp2ILInjected.Token(Token = "0x4007800")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Entity Entity;

		// Token: 0x04006411 RID: 25617
		[global::Cpp2ILInjected.Token(Token = "0x4007801")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly int MountId;
	}
}
