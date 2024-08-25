using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.ID
{
	[global::Cpp2ILInjected.Token(Token = "0x20005E4")]
	public static class PlayerItemSlotID
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x40068CB")]
		public static readonly int Inventory0;

		[global::Cpp2ILInjected.Token(Token = "0x40068CC")]
		public static readonly int InventoryMouseItem;

		[global::Cpp2ILInjected.Token(Token = "0x40068CD")]
		public static readonly int Armor0;

		[global::Cpp2ILInjected.Token(Token = "0x40068CE")]
		public static readonly int Dye0;

		[global::Cpp2ILInjected.Token(Token = "0x40068CF")]
		public static readonly int Misc0;

		[global::Cpp2ILInjected.Token(Token = "0x40068D0")]
		public static readonly int MiscDye0;

		[global::Cpp2ILInjected.Token(Token = "0x40068D1")]
		public static readonly int Bank1_0;

		[global::Cpp2ILInjected.Token(Token = "0x40068D2")]
		public static readonly int Bank2_0;

		[global::Cpp2ILInjected.Token(Token = "0x40068D3")]
		public static readonly int TrashItem;

		[global::Cpp2ILInjected.Token(Token = "0x40068D4")]
		public static readonly int Bank3_0;

		[global::Cpp2ILInjected.Token(Token = "0x40068D5")]
		public static readonly int Bank4_0;

		[global::Cpp2ILInjected.Token(Token = "0x40068D6")]
		public static readonly int Loadout1_Armor_0;

		[global::Cpp2ILInjected.Token(Token = "0x40068D7")]
		public static readonly int Loadout1_Dye_0;

		[global::Cpp2ILInjected.Token(Token = "0x40068D8")]
		public static readonly int Loadout2_Armor_0;

		[global::Cpp2ILInjected.Token(Token = "0x40068D9")]
		public static readonly int Loadout2_Dye_0;

		[global::Cpp2ILInjected.Token(Token = "0x40068DA")]
		public static readonly int Loadout3_Armor_0;

		[global::Cpp2ILInjected.Token(Token = "0x40068DB")]
		public static readonly int Loadout3_Dye_0;

		[global::Cpp2ILInjected.Token(Token = "0x40068DC")]
		public static bool[] CanRelay;

		[global::Cpp2ILInjected.Token(Token = "0x40068DD")]
		private static int _nextSlotId;
	}
}
