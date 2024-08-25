using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20001E7")]
[Serializable]
public class KeyboardMappingsCategories_Layout
{
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

	[global::Cpp2ILInjected.Token(Token = "0x6000C4F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CBCF4", Offset = "0x9CBCF4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public KeyboardMappingsCategories_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001193")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4001194")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout GeneralSettings;

	[global::Cpp2ILInjected.Token(Token = "0x4001195")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Exploration;

	[global::Cpp2ILInjected.Token(Token = "0x4001196")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Fighting;

	[global::Cpp2ILInjected.Token(Token = "0x4001197")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Miscellaneous;

	[global::Cpp2ILInjected.Token(Token = "0x4001198")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout UI;

	[global::Cpp2ILInjected.Token(Token = "0x4001199")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Chest;

	[global::Cpp2ILInjected.Token(Token = "0x400119A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Equipment;

	[global::Cpp2ILInjected.Token(Token = "0x400119B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Multiplayer;

	[global::Cpp2ILInjected.Token(Token = "0x400119C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout ShopCraft;

	[global::Cpp2ILInjected.Token(Token = "0x400119D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Map;

	[global::Cpp2ILInjected.Token(Token = "0x400119E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout LB;

	[global::Cpp2ILInjected.Token(Token = "0x400119F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout RB;

	[global::Cpp2ILInjected.Token(Token = "0x40011A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public KeyboardMappingsCategories_Layout.MappingCategories MappingSettings;

	[global::Cpp2ILInjected.Token(Token = "0x20001E8")]
	public enum Category
	{
		[global::Cpp2ILInjected.Token(Token = "0x40011A2")]
		GeneralSettings,
		[global::Cpp2ILInjected.Token(Token = "0x40011A3")]
		Exploration,
		[global::Cpp2ILInjected.Token(Token = "0x40011A4")]
		Fighting,
		[global::Cpp2ILInjected.Token(Token = "0x40011A5")]
		Miscellaneous,
		[global::Cpp2ILInjected.Token(Token = "0x40011A6")]
		UI,
		[global::Cpp2ILInjected.Token(Token = "0x40011A7")]
		Chest,
		[global::Cpp2ILInjected.Token(Token = "0x40011A8")]
		Equipment,
		[global::Cpp2ILInjected.Token(Token = "0x40011A9")]
		Multiplayer,
		[global::Cpp2ILInjected.Token(Token = "0x40011AA")]
		ShopCraft,
		[global::Cpp2ILInjected.Token(Token = "0x40011AB")]
		Map
	}

	[global::Cpp2ILInjected.Token(Token = "0x20001E9")]
	[Serializable]
	public class Setting
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C50")]
		[global::Cpp2ILInjected.Address(RVA = "0x9CBCFC", Offset = "0x9CBCFC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Setting()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40011AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public KeyboardMappingsCategories_Layout.Category Category;

		[global::Cpp2ILInjected.Token(Token = "0x40011AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int SortOrder;
	}

	[global::Cpp2ILInjected.Token(Token = "0x20001EA")]
	[Serializable]
	public class MappingCategories
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C51")]
		[global::Cpp2ILInjected.Address(RVA = "0x9CBD0C", Offset = "0x9CBD0C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MappingCategories()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40011AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public KeyboardMappingsCategories_Layout.Setting Up;

		[global::Cpp2ILInjected.Token(Token = "0x40011AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public KeyboardMappingsCategories_Layout.Setting Left;

		[global::Cpp2ILInjected.Token(Token = "0x40011B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public KeyboardMappingsCategories_Layout.Setting Down;

		[global::Cpp2ILInjected.Token(Token = "0x40011B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public KeyboardMappingsCategories_Layout.Setting Right;

		[global::Cpp2ILInjected.Token(Token = "0x40011B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public KeyboardMappingsCategories_Layout.Setting GrappleFire;

		[global::Cpp2ILInjected.Token(Token = "0x40011B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public KeyboardMappingsCategories_Layout.Setting Jump;

		[global::Cpp2ILInjected.Token(Token = "0x40011B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public KeyboardMappingsCategories_Layout.Setting Fire;

		[global::Cpp2ILInjected.Token(Token = "0x40011B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public KeyboardMappingsCategories_Layout.Setting Interact;

		[global::Cpp2ILInjected.Token(Token = "0x40011B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public KeyboardMappingsCategories_Layout.Setting TargetLockOn;

		[global::Cpp2ILInjected.Token(Token = "0x40011B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public KeyboardMappingsCategories_Layout.Setting InventoryToggle;

		[global::Cpp2ILInjected.Token(Token = "0x40011B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public KeyboardMappingsCategories_Layout.Setting AutoSelect;

		[global::Cpp2ILInjected.Token(Token = "0x40011B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public KeyboardMappingsCategories_Layout.Setting SmartCursor;

		[global::Cpp2ILInjected.Token(Token = "0x40011BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public KeyboardMappingsCategories_Layout.Setting AutoFire;

		[global::Cpp2ILInjected.Token(Token = "0x40011BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public KeyboardMappingsCategories_Layout.Setting HotbarNext;

		[global::Cpp2ILInjected.Token(Token = "0x40011BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public KeyboardMappingsCategories_Layout.Setting HotbarPrevious;

		[global::Cpp2ILInjected.Token(Token = "0x40011BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public KeyboardMappingsCategories_Layout.Setting ZoomIn;

		[global::Cpp2ILInjected.Token(Token = "0x40011BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public KeyboardMappingsCategories_Layout.Setting ZoomOut;

		[global::Cpp2ILInjected.Token(Token = "0x40011BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public KeyboardMappingsCategories_Layout.Setting MapZoomIn;

		[global::Cpp2ILInjected.Token(Token = "0x40011C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public KeyboardMappingsCategories_Layout.Setting MapZoomOut;

		[global::Cpp2ILInjected.Token(Token = "0x40011C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public KeyboardMappingsCategories_Layout.Setting MapZoomDefault;

		[global::Cpp2ILInjected.Token(Token = "0x40011C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public KeyboardMappingsCategories_Layout.Setting QuickMount;

		[global::Cpp2ILInjected.Token(Token = "0x40011C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public KeyboardMappingsCategories_Layout.Setting QuickHeal;

		[global::Cpp2ILInjected.Token(Token = "0x40011C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public KeyboardMappingsCategories_Layout.Setting QuickBuff;

		[global::Cpp2ILInjected.Token(Token = "0x40011C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public KeyboardMappingsCategories_Layout.Setting QuickMana;

		[global::Cpp2ILInjected.Token(Token = "0x40011C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public KeyboardMappingsCategories_Layout.Setting MapToggle;

		[global::Cpp2ILInjected.Token(Token = "0x40011C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public KeyboardMappingsCategories_Layout.Setting MiniMapToggle;

		[global::Cpp2ILInjected.Token(Token = "0x40011C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public KeyboardMappingsCategories_Layout.Setting ChatToggle;

		[global::Cpp2ILInjected.Token(Token = "0x40011C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		public KeyboardMappingsCategories_Layout.Setting Settings;

		[global::Cpp2ILInjected.Token(Token = "0x40011CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar1;

		[global::Cpp2ILInjected.Token(Token = "0x40011CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar2;

		[global::Cpp2ILInjected.Token(Token = "0x40011CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar3;

		[global::Cpp2ILInjected.Token(Token = "0x40011CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar4;

		[global::Cpp2ILInjected.Token(Token = "0x40011CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar5;

		[global::Cpp2ILInjected.Token(Token = "0x40011CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar6;

		[global::Cpp2ILInjected.Token(Token = "0x40011D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar7;

		[global::Cpp2ILInjected.Token(Token = "0x40011D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar8;

		[global::Cpp2ILInjected.Token(Token = "0x40011D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar9;

		[global::Cpp2ILInjected.Token(Token = "0x40011D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		public KeyboardMappingsCategories_Layout.Setting Hotbar10;

		[global::Cpp2ILInjected.Token(Token = "0x40011D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		public KeyboardMappingsCategories_Layout.Setting Loadout1;

		[global::Cpp2ILInjected.Token(Token = "0x40011D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		public KeyboardMappingsCategories_Layout.Setting Loadout2;

		[global::Cpp2ILInjected.Token(Token = "0x40011D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		public KeyboardMappingsCategories_Layout.Setting Loadout3;

		[global::Cpp2ILInjected.Token(Token = "0x40011D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		public KeyboardMappingsCategories_Layout.Setting LoadoutCycle;

		[global::Cpp2ILInjected.Token(Token = "0x40011D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		public KeyboardMappingsCategories_Layout.Setting LeftPageCycle;

		[global::Cpp2ILInjected.Token(Token = "0x40011D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		public KeyboardMappingsCategories_Layout.Setting RightPageCycle;
	}
}
