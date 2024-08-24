using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000162 RID: 354
[global::Cpp2ILInjected.Token(Token = "0x20001E7")]
[Serializable]
public class KeyboardMappingsCategories_Layout
{
	// Token: 0x06000B3B RID: 2875 RVA: 0x00023CF6 File Offset: 0x00021EF6
	[global::Cpp2ILInjected.Token(Token = "0x6000C4E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CB008", Offset = "0x9CB008", Length = "0xCEC")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(ControllerActionVector),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappingEntry), Member = ".ctor", MemberParameters = new object[] { typeof(ControllerActionButton) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
	public void GetCategorySetup(string id, out KeyboardMappingsCategories_Layout.Category category, out int sortOrder, int axisIndex = 0)
	{
		throw null;
	}

	// Token: 0x06000B3C RID: 2876 RVA: 0x00023CF9 File Offset: 0x00021EF9
	[global::Cpp2ILInjected.Token(Token = "0x6000C4F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CBCF4", Offset = "0x9CBCF4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public KeyboardMappingsCategories_Layout()
	{
		throw null;
	}

	// Token: 0x04000D90 RID: 3472
	[global::Cpp2ILInjected.Token(Token = "0x4001193")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	// Token: 0x04000D91 RID: 3473
	[global::Cpp2ILInjected.Token(Token = "0x4001194")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout GeneralSettings;

	// Token: 0x04000D92 RID: 3474
	[global::Cpp2ILInjected.Token(Token = "0x4001195")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Exploration;

	// Token: 0x04000D93 RID: 3475
	[global::Cpp2ILInjected.Token(Token = "0x4001196")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Fighting;

	// Token: 0x04000D94 RID: 3476
	[global::Cpp2ILInjected.Token(Token = "0x4001197")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Miscellaneous;

	// Token: 0x04000D95 RID: 3477
	[global::Cpp2ILInjected.Token(Token = "0x4001198")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout UI;

	// Token: 0x04000D96 RID: 3478
	[global::Cpp2ILInjected.Token(Token = "0x4001199")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Chest;

	// Token: 0x04000D97 RID: 3479
	[global::Cpp2ILInjected.Token(Token = "0x400119A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Equipment;

	// Token: 0x04000D98 RID: 3480
	[global::Cpp2ILInjected.Token(Token = "0x400119B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Multiplayer;

	// Token: 0x04000D99 RID: 3481
	[global::Cpp2ILInjected.Token(Token = "0x400119C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout ShopCraft;

	// Token: 0x04000D9A RID: 3482
	[global::Cpp2ILInjected.Token(Token = "0x400119D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Map;

	// Token: 0x04000D9B RID: 3483
	[global::Cpp2ILInjected.Token(Token = "0x400119E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout LB;

	// Token: 0x04000D9C RID: 3484
	[global::Cpp2ILInjected.Token(Token = "0x400119F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout RB;

	// Token: 0x04000D9D RID: 3485
	[global::Cpp2ILInjected.Token(Token = "0x40011A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public KeyboardMappingsCategories_Layout.MappingCategories MappingSettings;

	// Token: 0x020007E6 RID: 2022
	[global::Cpp2ILInjected.Token(Token = "0x20001E8")]
	public enum Category
	{
		// Token: 0x04007BCE RID: 31694
		[global::Cpp2ILInjected.Token(Token = "0x40011A2")]
		GeneralSettings,
		// Token: 0x04007BCF RID: 31695
		[global::Cpp2ILInjected.Token(Token = "0x40011A3")]
		Exploration,
		// Token: 0x04007BD0 RID: 31696
		[global::Cpp2ILInjected.Token(Token = "0x40011A4")]
		Fighting,
		// Token: 0x04007BD1 RID: 31697
		[global::Cpp2ILInjected.Token(Token = "0x40011A5")]
		Miscellaneous,
		// Token: 0x04007BD2 RID: 31698
		[global::Cpp2ILInjected.Token(Token = "0x40011A6")]
		UI,
		// Token: 0x04007BD3 RID: 31699
		[global::Cpp2ILInjected.Token(Token = "0x40011A7")]
		Chest,
		// Token: 0x04007BD4 RID: 31700
		[global::Cpp2ILInjected.Token(Token = "0x40011A8")]
		Equipment,
		// Token: 0x04007BD5 RID: 31701
		[global::Cpp2ILInjected.Token(Token = "0x40011A9")]
		Multiplayer,
		// Token: 0x04007BD6 RID: 31702
		[global::Cpp2ILInjected.Token(Token = "0x40011AA")]
		ShopCraft,
		// Token: 0x04007BD7 RID: 31703
		[global::Cpp2ILInjected.Token(Token = "0x40011AB")]
		Map
	}

	// Token: 0x020007E7 RID: 2023
	[global::Cpp2ILInjected.Token(Token = "0x20001E9")]
	[Serializable]
	public class Setting
	{
		// Token: 0x060048E6 RID: 18662 RVA: 0x0002EF07 File Offset: 0x0002D107
		[global::Cpp2ILInjected.Token(Token = "0x6000C50")]
		[global::Cpp2ILInjected.Address(RVA = "0x9CBCFC", Offset = "0x9CBCFC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Setting()
		{
			throw null;
		}

		// Token: 0x04007BD8 RID: 31704
		[global::Cpp2ILInjected.Token(Token = "0x40011AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public KeyboardMappingsCategories_Layout.Category Category;

		// Token: 0x04007BD9 RID: 31705
		[global::Cpp2ILInjected.Token(Token = "0x40011AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int SortOrder;
	}

	// Token: 0x020007E8 RID: 2024
	[global::Cpp2ILInjected.Token(Token = "0x20001EA")]
	[Serializable]
	public class MappingCategories
	{
		// Token: 0x060048E7 RID: 18663 RVA: 0x0002EF0A File Offset: 0x0002D10A
		[global::Cpp2ILInjected.Token(Token = "0x6000C51")]
		[global::Cpp2ILInjected.Address(RVA = "0x9CBD0C", Offset = "0x9CBD0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MappingCategories()
		{
			throw null;
		}

		// Token: 0x04007BDA RID: 31706
		[global::Cpp2ILInjected.Token(Token = "0x40011AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public KeyboardMappingsCategories_Layout.Setting Up;

		// Token: 0x04007BDB RID: 31707
		[global::Cpp2ILInjected.Token(Token = "0x40011AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public KeyboardMappingsCategories_Layout.Setting Left;

		// Token: 0x04007BDC RID: 31708
		[global::Cpp2ILInjected.Token(Token = "0x40011B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public KeyboardMappingsCategories_Layout.Setting Down;

		// Token: 0x04007BDD RID: 31709
		[global::Cpp2ILInjected.Token(Token = "0x40011B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public KeyboardMappingsCategories_Layout.Setting Right;

		// Token: 0x04007BDE RID: 31710
		[global::Cpp2ILInjected.Token(Token = "0x40011B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public KeyboardMappingsCategories_Layout.Setting GrappleFire;

		// Token: 0x04007BDF RID: 31711
		[global::Cpp2ILInjected.Token(Token = "0x40011B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public KeyboardMappingsCategories_Layout.Setting Jump;

		// Token: 0x04007BE0 RID: 31712
		[global::Cpp2ILInjected.Token(Token = "0x40011B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public KeyboardMappingsCategories_Layout.Setting Fire;

		// Token: 0x04007BE1 RID: 31713
		[global::Cpp2ILInjected.Token(Token = "0x40011B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public KeyboardMappingsCategories_Layout.Setting Interact;

		// Token: 0x04007BE2 RID: 31714
		[global::Cpp2ILInjected.Token(Token = "0x40011B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public KeyboardMappingsCategories_Layout.Setting TargetLockOn;

		// Token: 0x04007BE3 RID: 31715
		[global::Cpp2ILInjected.Token(Token = "0x40011B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public KeyboardMappingsCategories_Layout.Setting InventoryToggle;

		// Token: 0x04007BE4 RID: 31716
		[global::Cpp2ILInjected.Token(Token = "0x40011B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public KeyboardMappingsCategories_Layout.Setting AutoSelect;

		// Token: 0x04007BE5 RID: 31717
		[global::Cpp2ILInjected.Token(Token = "0x40011B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public KeyboardMappingsCategories_Layout.Setting SmartCursor;

		// Token: 0x04007BE6 RID: 31718
		[global::Cpp2ILInjected.Token(Token = "0x40011BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public KeyboardMappingsCategories_Layout.Setting AutoFire;

		// Token: 0x04007BE7 RID: 31719
		[global::Cpp2ILInjected.Token(Token = "0x40011BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public KeyboardMappingsCategories_Layout.Setting HotbarNext;

		// Token: 0x04007BE8 RID: 31720
		[global::Cpp2ILInjected.Token(Token = "0x40011BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public KeyboardMappingsCategories_Layout.Setting HotbarPrevious;

		// Token: 0x04007BE9 RID: 31721
		[global::Cpp2ILInjected.Token(Token = "0x40011BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public KeyboardMappingsCategories_Layout.Setting ZoomIn;

		// Token: 0x04007BEA RID: 31722
		[global::Cpp2ILInjected.Token(Token = "0x40011BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public KeyboardMappingsCategories_Layout.Setting ZoomOut;

		// Token: 0x04007BEB RID: 31723
		[global::Cpp2ILInjected.Token(Token = "0x40011BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public KeyboardMappingsCategories_Layout.Setting MapZoomIn;

		// Token: 0x04007BEC RID: 31724
		[global::Cpp2ILInjected.Token(Token = "0x40011C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public KeyboardMappingsCategories_Layout.Setting MapZoomOut;

		// Token: 0x04007BED RID: 31725
		[global::Cpp2ILInjected.Token(Token = "0x40011C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public KeyboardMappingsCategories_Layout.Setting MapZoomDefault;

		// Token: 0x04007BEE RID: 31726
		[global::Cpp2ILInjected.Token(Token = "0x40011C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public KeyboardMappingsCategories_Layout.Setting QuickMount;

		// Token: 0x04007BEF RID: 31727
		[global::Cpp2ILInjected.Token(Token = "0x40011C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public KeyboardMappingsCategories_Layout.Setting QuickHeal;

		// Token: 0x04007BF0 RID: 31728
		[global::Cpp2ILInjected.Token(Token = "0x40011C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public KeyboardMappingsCategories_Layout.Setting QuickBuff;

		// Token: 0x04007BF1 RID: 31729
		[global::Cpp2ILInjected.Token(Token = "0x40011C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public KeyboardMappingsCategories_Layout.Setting QuickMana;

		// Token: 0x04007BF2 RID: 31730
		[global::Cpp2ILInjected.Token(Token = "0x40011C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public KeyboardMappingsCategories_Layout.Setting MapToggle;

		// Token: 0x04007BF3 RID: 31731
		[global::Cpp2ILInjected.Token(Token = "0x40011C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public KeyboardMappingsCategories_Layout.Setting MiniMapToggle;

		// Token: 0x04007BF4 RID: 31732
		[global::Cpp2ILInjected.Token(Token = "0x40011C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public KeyboardMappingsCategories_Layout.Setting ChatToggle;

		// Token: 0x04007BF5 RID: 31733
		[global::Cpp2ILInjected.Token(Token = "0x40011C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		public KeyboardMappingsCategories_Layout.Setting Settings;

		// Token: 0x04007BF6 RID: 31734
		[global::Cpp2ILInjected.Token(Token = "0x40011CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar1;

		// Token: 0x04007BF7 RID: 31735
		[global::Cpp2ILInjected.Token(Token = "0x40011CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar2;

		// Token: 0x04007BF8 RID: 31736
		[global::Cpp2ILInjected.Token(Token = "0x40011CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar3;

		// Token: 0x04007BF9 RID: 31737
		[global::Cpp2ILInjected.Token(Token = "0x40011CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar4;

		// Token: 0x04007BFA RID: 31738
		[global::Cpp2ILInjected.Token(Token = "0x40011CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar5;

		// Token: 0x04007BFB RID: 31739
		[global::Cpp2ILInjected.Token(Token = "0x40011CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar6;

		// Token: 0x04007BFC RID: 31740
		[global::Cpp2ILInjected.Token(Token = "0x40011D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar7;

		// Token: 0x04007BFD RID: 31741
		[global::Cpp2ILInjected.Token(Token = "0x40011D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar8;

		// Token: 0x04007BFE RID: 31742
		[global::Cpp2ILInjected.Token(Token = "0x40011D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar9;

		// Token: 0x04007BFF RID: 31743
		[global::Cpp2ILInjected.Token(Token = "0x40011D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar10;

		// Token: 0x04007C00 RID: 31744
		[global::Cpp2ILInjected.Token(Token = "0x40011D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		public KeyboardMappingsCategories_Layout.Setting Loadout1;

		// Token: 0x04007C01 RID: 31745
		[global::Cpp2ILInjected.Token(Token = "0x40011D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		public KeyboardMappingsCategories_Layout.Setting Loadout2;

		// Token: 0x04007C02 RID: 31746
		[global::Cpp2ILInjected.Token(Token = "0x40011D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		public KeyboardMappingsCategories_Layout.Setting Loadout3;

		// Token: 0x04007C03 RID: 31747
		[global::Cpp2ILInjected.Token(Token = "0x40011D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		public KeyboardMappingsCategories_Layout.Setting LoadoutCycle;

		// Token: 0x04007C04 RID: 31748
		[global::Cpp2ILInjected.Token(Token = "0x40011D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		public KeyboardMappingsCategories_Layout.Setting LeftPageCycle;

		// Token: 0x04007C05 RID: 31749
		[global::Cpp2ILInjected.Token(Token = "0x40011D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		public KeyboardMappingsCategories_Layout.Setting RightPageCycle;
	}
}
