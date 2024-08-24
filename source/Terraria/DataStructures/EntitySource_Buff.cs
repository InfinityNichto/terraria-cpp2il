using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x02000451 RID: 1105
	[global::Cpp2ILInjected.Token(Token = "0x200064D")]
	public class EntitySource_Buff : IEntitySource
	{
		// Token: 0x060031CE RID: 12750 RVA: 0x0002AE9C File Offset: 0x0002909C
		[global::Cpp2ILInjected.Token(Token = "0x60036EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D368", Offset = "0x141D368", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetProjectileSource_Buff", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_Buff(Entity entity, int buffId, int buffIndex)
		{
			throw null;
		}

		// Token: 0x04006408 RID: 25608
		[global::Cpp2ILInjected.Token(Token = "0x40077F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly Entity Entity;

		// Token: 0x04006409 RID: 25609
		[global::Cpp2ILInjected.Token(Token = "0x40077F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly int BuffId;

		// Token: 0x0400640A RID: 25610
		[global::Cpp2ILInjected.Token(Token = "0x40077FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public readonly int BuffIndex;
	}
}
