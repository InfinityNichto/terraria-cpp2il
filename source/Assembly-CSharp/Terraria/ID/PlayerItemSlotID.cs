using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.ID
{
	// Token: 0x020003FB RID: 1019
	[global::Cpp2ILInjected.Token(Token = "0x20005E4")]
	public static class PlayerItemSlotID
	{
		// Token: 0x0600306A RID: 12394 RVA: 0x0002AA88 File Offset: 0x00028C88
		[global::Cpp2ILInjected.Token(Token = "0x600356E")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C77F0", Offset = "0x13C77F0", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerItemSlotID), Member = "AllocateSlots", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static PlayerItemSlotID()
		{
			throw null;
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x0002AA8B File Offset: 0x00028C8B
		[global::Cpp2ILInjected.Token(Token = "0x600356F")]
		[global::Cpp2ILInjected.Address(RVA = "0x13C79F0", Offset = "0x13C79F0", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerItemSlotID), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Resize", MemberTypeParameters = new object[] { typeof(bool) }, MemberParameters = new object[]
		{
			typeof(ref bool[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static int AllocateSlots(int amount, bool canNetRelay)
		{
			throw null;
		}

		// Token: 0x040055C0 RID: 21952
		[global::Cpp2ILInjected.Token(Token = "0x40068CB")]
		public static readonly int Inventory0;

		// Token: 0x040055C1 RID: 21953
		[global::Cpp2ILInjected.Token(Token = "0x40068CC")]
		public static readonly int InventoryMouseItem;

		// Token: 0x040055C2 RID: 21954
		[global::Cpp2ILInjected.Token(Token = "0x40068CD")]
		public static readonly int Armor0;

		// Token: 0x040055C3 RID: 21955
		[global::Cpp2ILInjected.Token(Token = "0x40068CE")]
		public static readonly int Dye0;

		// Token: 0x040055C4 RID: 21956
		[global::Cpp2ILInjected.Token(Token = "0x40068CF")]
		public static readonly int Misc0;

		// Token: 0x040055C5 RID: 21957
		[global::Cpp2ILInjected.Token(Token = "0x40068D0")]
		public static readonly int MiscDye0;

		// Token: 0x040055C6 RID: 21958
		[global::Cpp2ILInjected.Token(Token = "0x40068D1")]
		public static readonly int Bank1_0;

		// Token: 0x040055C7 RID: 21959
		[global::Cpp2ILInjected.Token(Token = "0x40068D2")]
		public static readonly int Bank2_0;

		// Token: 0x040055C8 RID: 21960
		[global::Cpp2ILInjected.Token(Token = "0x40068D3")]
		public static readonly int TrashItem;

		// Token: 0x040055C9 RID: 21961
		[global::Cpp2ILInjected.Token(Token = "0x40068D4")]
		public static readonly int Bank3_0;

		// Token: 0x040055CA RID: 21962
		[global::Cpp2ILInjected.Token(Token = "0x40068D5")]
		public static readonly int Bank4_0;

		// Token: 0x040055CB RID: 21963
		[global::Cpp2ILInjected.Token(Token = "0x40068D6")]
		public static readonly int Loadout1_Armor_0;

		// Token: 0x040055CC RID: 21964
		[global::Cpp2ILInjected.Token(Token = "0x40068D7")]
		public static readonly int Loadout1_Dye_0;

		// Token: 0x040055CD RID: 21965
		[global::Cpp2ILInjected.Token(Token = "0x40068D8")]
		public static readonly int Loadout2_Armor_0;

		// Token: 0x040055CE RID: 21966
		[global::Cpp2ILInjected.Token(Token = "0x40068D9")]
		public static readonly int Loadout2_Dye_0;

		// Token: 0x040055CF RID: 21967
		[global::Cpp2ILInjected.Token(Token = "0x40068DA")]
		public static readonly int Loadout3_Armor_0;

		// Token: 0x040055D0 RID: 21968
		[global::Cpp2ILInjected.Token(Token = "0x40068DB")]
		public static readonly int Loadout3_Dye_0;

		// Token: 0x040055D1 RID: 21969
		[global::Cpp2ILInjected.Token(Token = "0x40068DC")]
		public static bool[] CanRelay;

		// Token: 0x040055D2 RID: 21970
		[global::Cpp2ILInjected.Token(Token = "0x40068DD")]
		private static int _nextSlotId;
	}
}
