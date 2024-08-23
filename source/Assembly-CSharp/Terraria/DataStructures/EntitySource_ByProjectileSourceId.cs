using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x0200045C RID: 1116
	[global::Cpp2ILInjected.Token(Token = "0x2000658")]
	public class EntitySource_ByProjectileSourceId : IEntitySource
	{
		// Token: 0x060031D9 RID: 12761 RVA: 0x0002AEBD File Offset: 0x000290BD
		[global::Cpp2ILInjected.Token(Token = "0x60036F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D654", Offset = "0x141D654", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetProjectileSource_SetBonus", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetProjectileSource_Misc", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "UpdateWorld", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_ByProjectileSourceId(int projectileSourceId)
		{
			throw null;
		}

		// Token: 0x04006415 RID: 25621
		[global::Cpp2ILInjected.Token(Token = "0x4007805")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly int SourceId;
	}
}
