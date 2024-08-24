using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria
{
	// Token: 0x02000339 RID: 825
	[global::Cpp2ILInjected.Token(Token = "0x200044D")]
	public struct GetItemSettings
	{
		// Token: 0x060026C7 RID: 9927 RVA: 0x00028E8C File Offset: 0x0002708C
		[global::Cpp2ILInjected.Token(Token = "0x6002967")]
		[global::Cpp2ILInjected.Address(RVA = "0x115AE9C", Offset = "0x115AE9C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public GetItemSettings(bool LongText = false, bool NoText = false, bool CanGoIntoVoidVault = false, Action<Item> StepAfterHandlingSlotNormally = null)
		{
			throw null;
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x00028E8F File Offset: 0x0002708F
		[global::Cpp2ILInjected.Token(Token = "0x6002968")]
		[global::Cpp2ILInjected.Address(RVA = "0x115AEBC", Offset = "0x115AEBC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "FillAmmo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(bool)
		}, ReturnType = typeof(Item))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_VoidVault", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item[]),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillIntoOccupiedSlot_VoidBag", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item[]),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillIntoOccupiedSlot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillEmptyInventorySlot_VoidBag", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item[]),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "GetItem_FillEmptyInventorySlot", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Item),
			typeof(GetItemSettings),
			typeof(Item),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void HandlePostAction(Item item)
		{
			throw null;
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x00028E92 File Offset: 0x00027092
		[global::Cpp2ILInjected.Token(Token = "0x6002969")]
		[global::Cpp2ILInjected.Address(RVA = "0x115AED8", Offset = "0x115AED8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void MakeNewAndShiny(Item item)
		{
			throw null;
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x00028E95 File Offset: 0x00027095
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600296A")]
		[global::Cpp2ILInjected.Address(RVA = "0x115AEE4", Offset = "0x115AEE4", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static GetItemSettings()
		{
			throw null;
		}

		// Token: 0x04002EBE RID: 11966
		[global::Cpp2ILInjected.Token(Token = "0x4003683")]
		public static GetItemSettings InventoryEntityToPlayerInventorySettings;

		// Token: 0x04002EBF RID: 11967
		[global::Cpp2ILInjected.Token(Token = "0x4003684")]
		public static GetItemSettings NPCEntityToPlayerInventorySettings;

		// Token: 0x04002EC0 RID: 11968
		[global::Cpp2ILInjected.Token(Token = "0x4003685")]
		public static GetItemSettings LootAllSettings;

		// Token: 0x04002EC1 RID: 11969
		[global::Cpp2ILInjected.Token(Token = "0x4003686")]
		public static GetItemSettings LootAllSettingsRegularChest;

		// Token: 0x04002EC2 RID: 11970
		[global::Cpp2ILInjected.Token(Token = "0x4003687")]
		public static GetItemSettings PickupItemFromWorld;

		// Token: 0x04002EC3 RID: 11971
		[global::Cpp2ILInjected.Token(Token = "0x4003688")]
		public static GetItemSettings GetItemInDropItemCheck;

		// Token: 0x04002EC4 RID: 11972
		[global::Cpp2ILInjected.Token(Token = "0x4003689")]
		public static GetItemSettings InventoryUIToInventorySettings;

		// Token: 0x04002EC5 RID: 11973
		[global::Cpp2ILInjected.Token(Token = "0x400368A")]
		public static GetItemSettings InventoryUIToInventorySettingsShowAsNew;

		// Token: 0x04002EC6 RID: 11974
		[global::Cpp2ILInjected.Token(Token = "0x400368B")]
		public static GetItemSettings ItemCreatedFromItemUsage;

		// Token: 0x04002EC7 RID: 11975
		[global::Cpp2ILInjected.Token(Token = "0x400368C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly bool LongText;

		// Token: 0x04002EC8 RID: 11976
		[global::Cpp2ILInjected.Token(Token = "0x400368D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		public readonly bool NoText;

		// Token: 0x04002EC9 RID: 11977
		[global::Cpp2ILInjected.Token(Token = "0x400368E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public readonly bool CanGoIntoVoidVault;

		// Token: 0x04002ECA RID: 11978
		[global::Cpp2ILInjected.Token(Token = "0x400368F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public readonly Action<Item> StepAfterHandlingSlotNormally;
	}
}
