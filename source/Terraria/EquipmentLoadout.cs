using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.DataStructures;
using Terraria.IO;

namespace Terraria
{
	[global::Cpp2ILInjected.Token(Token = "0x200044E")]
	public class EquipmentLoadout : IFixLoadedData
	{
		[global::Cpp2ILInjected.Token(Token = "0x600296B")]
		[global::Cpp2ILInjected.Address(RVA = "0x115B004", Offset = "0x115B004", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EquipmentLoadout), Member = "CreateItemArray", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Item[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EquipmentLoadout()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600296C")]
		[global::Cpp2ILInjected.Address(RVA = "0x115B078", Offset = "0x115B078", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EquipmentLoadout), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private Item[] CreateItemArray(int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600296D")]
		[global::Cpp2ILInjected.Address(RVA = "0x115B13C", Offset = "0x115B13C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "InternalSavePlayerFile", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(ItemSerializationContext)
		}, ReturnType = typeof(void))]
		public void Serialize(BinaryWriter writer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600296E")]
		[global::Cpp2ILInjected.Address(RVA = "0x115B218", Offset = "0x115B218", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "DeserializeFrom", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ItemSerializationContext)
		}, ReturnType = typeof(void))]
		public void Deserialize(BinaryReader reader, int gameVersion)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600296F")]
		[global::Cpp2ILInjected.Address(RVA = "0x115B300", Offset = "0x115B300", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TrySwitchingLoadout", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Swap", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(ref object),
			typeof(ref object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Swap", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void Swap(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002970")]
		[global::Cpp2ILInjected.Address(RVA = "0x115B470", Offset = "0x115B470", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "DropItems", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "TryDroppingSingleItem", MemberParameters = new object[]
		{
			typeof(IEntitySource),
			typeof(Item)
		}, ReturnType = typeof(void))]
		public void TryDroppingItems(Player player, IEntitySource source)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002971")]
		[global::Cpp2ILInjected.Address(RVA = "0x115B518", Offset = "0x115B518", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "FixLoadedData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = "FixAgainstExploit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "FixLoadedData_EliminiateDuplicateAccessories", MemberParameters = new object[] { typeof(Item[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void FixLoadedData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003690")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Item[] Armor;

		[global::Cpp2ILInjected.Token(Token = "0x4003691")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public Item[] Dye;

		[global::Cpp2ILInjected.Token(Token = "0x4003692")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public bool[] Hide;
	}
}
