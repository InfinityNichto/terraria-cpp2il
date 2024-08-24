using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.UI.ResourceSets
{
	// Token: 0x020006AF RID: 1711
	[global::Cpp2ILInjected.Token(Token = "0x2000A87")]
	public struct PlayerStatsSnapshot
	{
		// Token: 0x06004375 RID: 17269 RVA: 0x0002E10C File Offset: 0x0002C30C
		[global::Cpp2ILInjected.Token(Token = "0x6004FA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x8FFF88", Offset = "0x8FFF88", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FancyClassicPlayerResourcesDisplaySet), Member = "PrepareFields", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HorizontalBarsPlayerResourcesDisplaySet), Member = "PrepareFields", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public PlayerStatsSnapshot(Player player)
		{
			throw null;
		}

		// Token: 0x04006F65 RID: 28517
		[global::Cpp2ILInjected.Token(Token = "0x4008889")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int Life;

		// Token: 0x04006F66 RID: 28518
		[global::Cpp2ILInjected.Token(Token = "0x400888A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int LifeMax;

		// Token: 0x04006F67 RID: 28519
		[global::Cpp2ILInjected.Token(Token = "0x400888B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public int LifeFruitCount;

		// Token: 0x04006F68 RID: 28520
		[global::Cpp2ILInjected.Token(Token = "0x400888C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public float LifePerSegment;

		// Token: 0x04006F69 RID: 28521
		[global::Cpp2ILInjected.Token(Token = "0x400888D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int Mana;

		// Token: 0x04006F6A RID: 28522
		[global::Cpp2ILInjected.Token(Token = "0x400888E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int ManaMax;

		// Token: 0x04006F6B RID: 28523
		[global::Cpp2ILInjected.Token(Token = "0x400888F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public float ManaPerSegment;
	}
}
