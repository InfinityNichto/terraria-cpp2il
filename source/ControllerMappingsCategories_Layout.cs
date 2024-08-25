using System;
using Controller;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20001A1")]
[Serializable]
public class ControllerMappingsCategories_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B6D")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ACA64", Offset = "0x9ACA64", Length = "0xB4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerPulldownEntry), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerSliderEntry), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerToggleEntry), Member = ".ctor", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public void GetCategorySetup(GUISettingID id, out ControllerMappingsCategories_Layout.Category category, out int sortOrder)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B6E")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ACB18", Offset = "0x9ACB18", Length = "0x1D1C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(ControllerActionVector),
		typeof(GUIControllerMappingStateTable)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(ControllerActionButton),
		typeof(GUIControllerMappingStateTable)
	}, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 102)]
	public void GetCategorySetup(string actionId, out ControllerMappingsCategories_Layout.Category category, out int sortOrder)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B6F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AE834", Offset = "0x9AE834", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public ControllerMappingsCategories_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000D27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000D28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public TransactionButton_Layout GeneralSettings;

	[global::Cpp2ILInjected.Token(Token = "0x4000D29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Exploration;

	[global::Cpp2ILInjected.Token(Token = "0x4000D2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Fighting;

	[global::Cpp2ILInjected.Token(Token = "0x4000D2B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Miscellaneous;

	[global::Cpp2ILInjected.Token(Token = "0x4000D2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout UI;

	[global::Cpp2ILInjected.Token(Token = "0x4000D2D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Chest;

	[global::Cpp2ILInjected.Token(Token = "0x4000D2E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout Equipment;

	[global::Cpp2ILInjected.Token(Token = "0x4000D2F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout Multiplayer;

	[global::Cpp2ILInjected.Token(Token = "0x4000D30")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout ShopCraft;

	[global::Cpp2ILInjected.Token(Token = "0x4000D31")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout Map;

	[global::Cpp2ILInjected.Token(Token = "0x4000D32")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public TransactionButton_Layout LB;

	[global::Cpp2ILInjected.Token(Token = "0x4000D33")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout RB;

	[global::Cpp2ILInjected.Token(Token = "0x4000D34")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public ControllerMappingsCategories_Layout.MappingCategories MappingSettings;

	[global::Cpp2ILInjected.Token(Token = "0x20001A2")]
	public enum Category
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000D36")]
		GeneralSettings,
		[global::Cpp2ILInjected.Token(Token = "0x4000D37")]
		Exploration,
		[global::Cpp2ILInjected.Token(Token = "0x4000D38")]
		Fighting,
		[global::Cpp2ILInjected.Token(Token = "0x4000D39")]
		Miscellaneous,
		[global::Cpp2ILInjected.Token(Token = "0x4000D3A")]
		UI,
		[global::Cpp2ILInjected.Token(Token = "0x4000D3B")]
		Chest,
		[global::Cpp2ILInjected.Token(Token = "0x4000D3C")]
		Equipment,
		[global::Cpp2ILInjected.Token(Token = "0x4000D3D")]
		Multiplayer,
		[global::Cpp2ILInjected.Token(Token = "0x4000D3E")]
		ShopCraft,
		[global::Cpp2ILInjected.Token(Token = "0x4000D3F")]
		Map
	}

	[global::Cpp2ILInjected.Token(Token = "0x20001A3")]
	[Serializable]
	public class Setting
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B70")]
		[global::Cpp2ILInjected.Address(RVA = "0x9AE83C", Offset = "0x9AE83C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Setting()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D40")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public ControllerMappingsCategories_Layout.Category Category;

		[global::Cpp2ILInjected.Token(Token = "0x4000D41")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int SortOrder;
	}

	[global::Cpp2ILInjected.Token(Token = "0x20001A4")]
	[Serializable]
	public class MappingCategories
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B71")]
		[global::Cpp2ILInjected.Address(RVA = "0x9AE84C", Offset = "0x9AE84C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MappingCategories()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000D42")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public ControllerMappingsCategories_Layout.Setting Controls;

		[global::Cpp2ILInjected.Token(Token = "0x4000D43")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public ControllerMappingsCategories_Layout.Setting ControllerAimAndUseMode;

		[global::Cpp2ILInjected.Token(Token = "0x4000D44")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public ControllerMappingsCategories_Layout.Setting ControllerAimSensitivity;

		[global::Cpp2ILInjected.Token(Token = "0x4000D45")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public ControllerMappingsCategories_Layout.Setting ControllerInterfaceMovementDelay;

		[global::Cpp2ILInjected.Token(Token = "0x4000D46")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public ControllerMappingsCategories_Layout.Setting ControllerInterfaceMovementRepeatDelay;

		[global::Cpp2ILInjected.Token(Token = "0x4000D47")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public ControllerMappingsCategories_Layout.Setting ControllerSmartCursorMode;

		[global::Cpp2ILInjected.Token(Token = "0x4000D48")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public ControllerMappingsCategories_Layout.Setting ControllerSwapShoulderButtons;

		[global::Cpp2ILInjected.Token(Token = "0x4000D49")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public ControllerMappingsCategories_Layout.Setting ControllerShowControlsBanner;

		[global::Cpp2ILInjected.Token(Token = "0x4000D4A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public ControllerMappingsCategories_Layout.Setting MovementAxis;

		[global::Cpp2ILInjected.Token(Token = "0x4000D4B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public ControllerMappingsCategories_Layout.Setting MovementAxisAlt;

		[global::Cpp2ILInjected.Token(Token = "0x4000D4C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public ControllerMappingsCategories_Layout.Setting FireAxis;

		[global::Cpp2ILInjected.Token(Token = "0x4000D4D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public ControllerMappingsCategories_Layout.Setting FireAxisAlt;

		[global::Cpp2ILInjected.Token(Token = "0x4000D4E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public ControllerMappingsCategories_Layout.Setting GrappleAxis;

		[global::Cpp2ILInjected.Token(Token = "0x4000D4F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public ControllerMappingsCategories_Layout.Setting GridSnapAxis;

		[global::Cpp2ILInjected.Token(Token = "0x4000D50")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public ControllerMappingsCategories_Layout.Setting HotbarAxis;

		[global::Cpp2ILInjected.Token(Token = "0x4000D51")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public ControllerMappingsCategories_Layout.Setting GrappleFire;

		[global::Cpp2ILInjected.Token(Token = "0x4000D52")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public ControllerMappingsCategories_Layout.Setting Jump;

		[global::Cpp2ILInjected.Token(Token = "0x4000D53")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public ControllerMappingsCategories_Layout.Setting Fire;

		[global::Cpp2ILInjected.Token(Token = "0x4000D54")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public ControllerMappingsCategories_Layout.Setting FireAlt;

		[global::Cpp2ILInjected.Token(Token = "0x4000D55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public ControllerMappingsCategories_Layout.Setting Interact;

		[global::Cpp2ILInjected.Token(Token = "0x4000D56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public ControllerMappingsCategories_Layout.Setting TargetLockOn;

		[global::Cpp2ILInjected.Token(Token = "0x4000D57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public ControllerMappingsCategories_Layout.Setting InventoryToggle;

		[global::Cpp2ILInjected.Token(Token = "0x4000D58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public ControllerMappingsCategories_Layout.Setting WorldFocusToggle;

		[global::Cpp2ILInjected.Token(Token = "0x4000D59")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public ControllerMappingsCategories_Layout.Setting AutoSelect;

		[global::Cpp2ILInjected.Token(Token = "0x4000D5A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public ControllerMappingsCategories_Layout.Setting SmartCursor;

		[global::Cpp2ILInjected.Token(Token = "0x4000D5B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public ControllerMappingsCategories_Layout.Setting AutoFire;

		[global::Cpp2ILInjected.Token(Token = "0x4000D5C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public ControllerMappingsCategories_Layout.Setting HotbarNext;

		[global::Cpp2ILInjected.Token(Token = "0x4000D5D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		public ControllerMappingsCategories_Layout.Setting HotbarPrevious;

		[global::Cpp2ILInjected.Token(Token = "0x4000D5E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		public ControllerMappingsCategories_Layout.Setting BuffNext;

		[global::Cpp2ILInjected.Token(Token = "0x4000D5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		public ControllerMappingsCategories_Layout.Setting BuffPrevious;

		[global::Cpp2ILInjected.Token(Token = "0x4000D60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		public ControllerMappingsCategories_Layout.Setting BuffRemove;

		[global::Cpp2ILInjected.Token(Token = "0x4000D61")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		public ControllerMappingsCategories_Layout.Setting ZoomIn;

		[global::Cpp2ILInjected.Token(Token = "0x4000D62")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		public ControllerMappingsCategories_Layout.Setting ZoomOut;

		[global::Cpp2ILInjected.Token(Token = "0x4000D63")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		public ControllerMappingsCategories_Layout.Setting MapZoomIn;

		[global::Cpp2ILInjected.Token(Token = "0x4000D64")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		public ControllerMappingsCategories_Layout.Setting MapZoomOut;

		[global::Cpp2ILInjected.Token(Token = "0x4000D65")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		public ControllerMappingsCategories_Layout.Setting MapZoomDefault;

		[global::Cpp2ILInjected.Token(Token = "0x4000D66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		public ControllerMappingsCategories_Layout.Setting QuickHeal;

		[global::Cpp2ILInjected.Token(Token = "0x4000D67")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		public ControllerMappingsCategories_Layout.Setting QuickMana;

		[global::Cpp2ILInjected.Token(Token = "0x4000D68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		public ControllerMappingsCategories_Layout.Setting QuickBuff;

		[global::Cpp2ILInjected.Token(Token = "0x4000D69")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		public ControllerMappingsCategories_Layout.Setting QuickMount;

		[global::Cpp2ILInjected.Token(Token = "0x4000D6A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		public ControllerMappingsCategories_Layout.Setting MapToggle;

		[global::Cpp2ILInjected.Token(Token = "0x4000D6B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		public ControllerMappingsCategories_Layout.Setting MiniMapToggle;

		[global::Cpp2ILInjected.Token(Token = "0x4000D6C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		public ControllerMappingsCategories_Layout.Setting ChatToggle;

		[global::Cpp2ILInjected.Token(Token = "0x4000D6D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		public ControllerMappingsCategories_Layout.Setting WiringOptions;

		[global::Cpp2ILInjected.Token(Token = "0x4000D6E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		public ControllerMappingsCategories_Layout.Setting ToggleEmotes;

		[global::Cpp2ILInjected.Token(Token = "0x4000D6F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		public ControllerMappingsCategories_Layout.Setting InventoryNavigation;

		[global::Cpp2ILInjected.Token(Token = "0x4000D70")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		public ControllerMappingsCategories_Layout.Setting InventoryNavigationAlt;

		[global::Cpp2ILInjected.Token(Token = "0x4000D71")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		public ControllerMappingsCategories_Layout.Setting LeftPageCycle;

		[global::Cpp2ILInjected.Token(Token = "0x4000D72")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		public ControllerMappingsCategories_Layout.Setting RightPageCycle;

		[global::Cpp2ILInjected.Token(Token = "0x4000D73")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
		public ControllerMappingsCategories_Layout.Setting ThrowItem;

		[global::Cpp2ILInjected.Token(Token = "0x4000D74")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
		public ControllerMappingsCategories_Layout.Setting TrashItem;

		[global::Cpp2ILInjected.Token(Token = "0x4000D75")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
		public ControllerMappingsCategories_Layout.Setting DepositHeldItem;

		[global::Cpp2ILInjected.Token(Token = "0x4000D76")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
		public ControllerMappingsCategories_Layout.Setting FavouriteItem;

		[global::Cpp2ILInjected.Token(Token = "0x4000D77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
		public ControllerMappingsCategories_Layout.Setting SplitItem;

		[global::Cpp2ILInjected.Token(Token = "0x4000D78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
		public ControllerMappingsCategories_Layout.Setting ResearchItem;

		[global::Cpp2ILInjected.Token(Token = "0x4000D79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
		public ControllerMappingsCategories_Layout.Setting ShowHideItem;

		[global::Cpp2ILInjected.Token(Token = "0x4000D7A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
		public ControllerMappingsCategories_Layout.Setting Sort;

		[global::Cpp2ILInjected.Token(Token = "0x4000D7B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
		public ControllerMappingsCategories_Layout.Setting BuilderTools;

		[global::Cpp2ILInjected.Token(Token = "0x4000D7C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
		public ControllerMappingsCategories_Layout.Setting ChestQuickStack;

		[global::Cpp2ILInjected.Token(Token = "0x4000D7D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
		public ControllerMappingsCategories_Layout.Setting ChestLootAll;

		[global::Cpp2ILInjected.Token(Token = "0x4000D7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
		public ControllerMappingsCategories_Layout.Setting ChestDepositAll;

		[global::Cpp2ILInjected.Token(Token = "0x4000D7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
		public ControllerMappingsCategories_Layout.Setting ChestRestock;

		[global::Cpp2ILInjected.Token(Token = "0x4000D80")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
		public ControllerMappingsCategories_Layout.Setting ChestRename;

		[global::Cpp2ILInjected.Token(Token = "0x4000D81")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
		public ControllerMappingsCategories_Layout.Setting ChestLoot;

		[global::Cpp2ILInjected.Token(Token = "0x4000D82")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
		public ControllerMappingsCategories_Layout.Setting ChestDeposit;

		[global::Cpp2ILInjected.Token(Token = "0x4000D83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
		public ControllerMappingsCategories_Layout.Setting ChestSort;

		[global::Cpp2ILInjected.Token(Token = "0x4000D84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
		public ControllerMappingsCategories_Layout.Setting EquipmentEquip;

		[global::Cpp2ILInjected.Token(Token = "0x4000D85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
		public ControllerMappingsCategories_Layout.Setting EquipmentUnequip;

		[global::Cpp2ILInjected.Token(Token = "0x4000D86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
		public ControllerMappingsCategories_Layout.Setting ShopSell;

		[global::Cpp2ILInjected.Token(Token = "0x4000D87")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
		public ControllerMappingsCategories_Layout.Setting ShopBuy;

		[global::Cpp2ILInjected.Token(Token = "0x4000D88")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
		public ControllerMappingsCategories_Layout.Setting MaterialPrevious;

		[global::Cpp2ILInjected.Token(Token = "0x4000D89")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x248")]
		public ControllerMappingsCategories_Layout.Setting MaterialNext;

		[global::Cpp2ILInjected.Token(Token = "0x4000D8A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x250")]
		public ControllerMappingsCategories_Layout.Setting PVPEnableToggle;

		[global::Cpp2ILInjected.Token(Token = "0x4000D8B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x258")]
		public ControllerMappingsCategories_Layout.Setting PVPTeleport;

		[global::Cpp2ILInjected.Token(Token = "0x4000D8C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x260")]
		public ControllerMappingsCategories_Layout.Setting PVPSwitchTeam;

		[global::Cpp2ILInjected.Token(Token = "0x4000D8D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x268")]
		public ControllerMappingsCategories_Layout.Setting BestiaryFilters;

		[global::Cpp2ILInjected.Token(Token = "0x4000D8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x270")]
		public ControllerMappingsCategories_Layout.Setting BestiaryFilterSearch;

		[global::Cpp2ILInjected.Token(Token = "0x4000D8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x278")]
		public ControllerMappingsCategories_Layout.Setting BestiarySortOrder;

		[global::Cpp2ILInjected.Token(Token = "0x4000D90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x280")]
		public ControllerMappingsCategories_Layout.Setting BestiaryDrops;

		[global::Cpp2ILInjected.Token(Token = "0x4000D91")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x288")]
		public ControllerMappingsCategories_Layout.Setting PickupPlaceItem;

		[global::Cpp2ILInjected.Token(Token = "0x4000D92")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x290")]
		public ControllerMappingsCategories_Layout.Setting InventoryClose;

		[global::Cpp2ILInjected.Token(Token = "0x4000D93")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x298")]
		public ControllerMappingsCategories_Layout.Setting ReforgeItem;

		[global::Cpp2ILInjected.Token(Token = "0x4000D94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A0")]
		public ControllerMappingsCategories_Layout.Setting CraftItem;

		[global::Cpp2ILInjected.Token(Token = "0x4000D95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A8")]
		public ControllerMappingsCategories_Layout.Setting FilterItems;

		[global::Cpp2ILInjected.Token(Token = "0x4000D96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B0")]
		public ControllerMappingsCategories_Layout.Setting InfoAccessories;

		[global::Cpp2ILInjected.Token(Token = "0x4000D97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B8")]
		public ControllerMappingsCategories_Layout.Setting FilterItemsSearch;

		[global::Cpp2ILInjected.Token(Token = "0x4000D98")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C0")]
		public ControllerMappingsCategories_Layout.Setting ToggleCraftDuplicate;

		[global::Cpp2ILInjected.Token(Token = "0x4000D99")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C8")]
		public ControllerMappingsCategories_Layout.Setting HousingQuery;

		[global::Cpp2ILInjected.Token(Token = "0x4000D9A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D0")]
		public ControllerMappingsCategories_Layout.Setting TakeOne;

		[global::Cpp2ILInjected.Token(Token = "0x4000D9B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D8")]
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar1;

		[global::Cpp2ILInjected.Token(Token = "0x4000D9C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E0")]
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar2;

		[global::Cpp2ILInjected.Token(Token = "0x4000D9D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E8")]
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar3;

		[global::Cpp2ILInjected.Token(Token = "0x4000D9E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F0")]
		public ControllerMappingsCategories_Layout.Setting DynamicHotbar4;

		[global::Cpp2ILInjected.Token(Token = "0x4000D9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F8")]
		public ControllerMappingsCategories_Layout.Setting Hotbar1;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x300")]
		public ControllerMappingsCategories_Layout.Setting Hotbar2;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x308")]
		public ControllerMappingsCategories_Layout.Setting Hotbar3;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x310")]
		public ControllerMappingsCategories_Layout.Setting Hotbar4;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x318")]
		public ControllerMappingsCategories_Layout.Setting Hotbar5;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x320")]
		public ControllerMappingsCategories_Layout.Setting Hotbar6;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x328")]
		public ControllerMappingsCategories_Layout.Setting Hotbar7;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x330")]
		public ControllerMappingsCategories_Layout.Setting Hotbar8;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x338")]
		public ControllerMappingsCategories_Layout.Setting Hotbar9;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x340")]
		public ControllerMappingsCategories_Layout.Setting Hotbar10;

		[global::Cpp2ILInjected.Token(Token = "0x4000DA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x348")]
		public ControllerMappingsCategories_Layout.Setting Loadout1;

		[global::Cpp2ILInjected.Token(Token = "0x4000DAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x350")]
		public ControllerMappingsCategories_Layout.Setting Loadout2;

		[global::Cpp2ILInjected.Token(Token = "0x4000DAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x358")]
		public ControllerMappingsCategories_Layout.Setting Loadout3;

		[global::Cpp2ILInjected.Token(Token = "0x4000DAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x360")]
		public ControllerMappingsCategories_Layout.Setting LoadoutCycle;
	}
}
