using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200012A")]
public class ControllerMappingsCategories_Layout
{
	[Cpp2IlInjected.Token(Token = "0x20007D0")]
	public enum Category
	{
		[Cpp2IlInjected.Token(Token = "0x4007ADA")]
		GeneralSettings,
		[Cpp2IlInjected.Token(Token = "0x4007ADB")]
		Exploration,
		[Cpp2IlInjected.Token(Token = "0x4007ADC")]
		Fighting,
		[Cpp2IlInjected.Token(Token = "0x4007ADD")]
		Miscellaneous,
		[Cpp2IlInjected.Token(Token = "0x4007ADE")]
		UI,
		[Cpp2IlInjected.Token(Token = "0x4007ADF")]
		Chest,
		[Cpp2IlInjected.Token(Token = "0x4007AE0")]
		Equipment,
		[Cpp2IlInjected.Token(Token = "0x4007AE1")]
		Multiplayer,
		[Cpp2IlInjected.Token(Token = "0x4007AE2")]
		ShopCraft,
		[Cpp2IlInjected.Token(Token = "0x4007AE3")]
		Map
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20007D1")]
	public class Setting
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007AE4")]
		public Category Category;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007AE5")]
		public int SortOrder;

		[Cpp2IlInjected.Token(Token = "0x6004916")]
		[Cpp2IlInjected.Address(RVA = "0x120FEE0", Offset = "0x120FEE0", VA = "0x120FEE0")]
		public Setting()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20007D2")]
	public class MappingCategories
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007AE6")]
		public Setting Controls;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007AE7")]
		public Setting ControllerAimAndUseMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007AE8")]
		public Setting ControllerAimSensitivity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007AE9")]
		public Setting ControllerInterfaceMovementDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007AEA")]
		public Setting ControllerInterfaceMovementRepeatDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007AEB")]
		public Setting ControllerSmartCursorMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007AEC")]
		public Setting ControllerSwapShoulderButtons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4007AED")]
		public Setting ControllerShowControlsBanner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4007AEE")]
		public Setting MovementAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4007AEF")]
		public Setting MovementAxisAlt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4007AF0")]
		public Setting FireAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4007AF1")]
		public Setting FireAxisAlt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4007AF2")]
		public Setting GrappleAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4007AF3")]
		public Setting GridSnapAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4007AF4")]
		public Setting HotbarAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4007AF5")]
		public Setting GrappleFire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4007AF6")]
		public Setting Jump;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4007AF7")]
		public Setting Fire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4007AF8")]
		public Setting FireAlt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4007AF9")]
		public Setting Interact;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4007AFA")]
		public Setting TargetLockOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4007AFB")]
		public Setting InventoryToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4007AFC")]
		public Setting WorldFocusToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4007AFD")]
		public Setting AutoSelect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4007AFE")]
		public Setting SmartCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4007AFF")]
		public Setting AutoFire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4007B00")]
		public Setting HotbarNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4007B01")]
		public Setting HotbarPrevious;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4007B02")]
		public Setting BuffNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4007B03")]
		public Setting BuffPrevious;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4007B04")]
		public Setting BuffRemove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4007B05")]
		public Setting ZoomIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4007B06")]
		public Setting ZoomOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4007B07")]
		public Setting MapZoomIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4007B08")]
		public Setting MapZoomOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4007B09")]
		public Setting MapZoomDefault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4007B0A")]
		public Setting QuickHeal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4007B0B")]
		public Setting QuickMana;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4007B0C")]
		public Setting QuickBuff;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4007B0D")]
		public Setting QuickMount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4007B0E")]
		public Setting MapToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4007B0F")]
		public Setting MiniMapToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4007B10")]
		public Setting ChatToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4007B11")]
		public Setting WiringOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4007B12")]
		public Setting ToggleEmotes;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4007B13")]
		public Setting InventoryNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4007B14")]
		public Setting InventoryNavigationAlt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4007B15")]
		public Setting LeftPageCycle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4007B16")]
		public Setting RightPageCycle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4007B17")]
		public Setting ThrowItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4007B18")]
		public Setting TrashItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4007B19")]
		public Setting DepositHeldItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4007B1A")]
		public Setting FavouriteItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4007B1B")]
		public Setting SplitItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4007B1C")]
		public Setting ResearchItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4007B1D")]
		public Setting ShowHideItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4007B1E")]
		public Setting Sort;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4007B1F")]
		public Setting BuilderTools;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4007B20")]
		public Setting ChestQuickStack;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4007B21")]
		public Setting ChestLootAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4007B22")]
		public Setting ChestDepositAll;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4007B23")]
		public Setting ChestRestock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4007B24")]
		public Setting ChestRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4007B25")]
		public Setting ChestLoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4007B26")]
		public Setting ChestDeposit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4007B27")]
		public Setting ChestSort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4007B28")]
		public Setting EquipmentEquip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
		[Cpp2IlInjected.Token(Token = "0x4007B29")]
		public Setting EquipmentUnequip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4007B2A")]
		public Setting ShopSell;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
		[Cpp2IlInjected.Token(Token = "0x4007B2B")]
		public Setting ShopBuy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4007B2C")]
		public Setting MaterialPrevious;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4007B2D")]
		public Setting MaterialNext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4007B2E")]
		public Setting PVPEnableToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
		[Cpp2IlInjected.Token(Token = "0x4007B2F")]
		public Setting PVPTeleport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4007B30")]
		public Setting PVPSwitchTeam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4007B31")]
		public Setting BestiaryFilters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4007B32")]
		public Setting BestiaryFilterSearch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4007B33")]
		public Setting BestiarySortOrder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4007B34")]
		public Setting BestiaryDrops;

		[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
		[Cpp2IlInjected.Token(Token = "0x4007B35")]
		public Setting PickupPlaceItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4007B36")]
		public Setting InventoryClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4007B37")]
		public Setting ReforgeItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4007B38")]
		public Setting CraftItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
		[Cpp2IlInjected.Token(Token = "0x4007B39")]
		public Setting FilterItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4007B3A")]
		public Setting InfoAccessories;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4007B3B")]
		public Setting FilterItemsSearch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4007B3C")]
		public Setting ToggleCraftDuplicate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
		[Cpp2IlInjected.Token(Token = "0x4007B3D")]
		public Setting HousingQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4007B3E")]
		public Setting TakeOne;

		[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
		[Cpp2IlInjected.Token(Token = "0x4007B3F")]
		public Setting DynamicHotbar1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4007B40")]
		public Setting DynamicHotbar2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x4007B41")]
		public Setting DynamicHotbar3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4007B42")]
		public Setting DynamicHotbar4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x4007B43")]
		public Setting Hotbar1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4007B44")]
		public Setting Hotbar2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
		[Cpp2IlInjected.Token(Token = "0x4007B45")]
		public Setting Hotbar3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4007B46")]
		public Setting Hotbar4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
		[Cpp2IlInjected.Token(Token = "0x4007B47")]
		public Setting Hotbar5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4007B48")]
		public Setting Hotbar6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
		[Cpp2IlInjected.Token(Token = "0x4007B49")]
		public Setting Hotbar7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4007B4A")]
		public Setting Hotbar8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x4007B4B")]
		public Setting Hotbar9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4007B4C")]
		public Setting Hotbar10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4007B4D")]
		public Setting Loadout1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4007B4E")]
		public Setting Loadout2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x4007B4F")]
		public Setting Loadout3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4007B50")]
		public Setting LoadoutCycle;

		[Cpp2IlInjected.Token(Token = "0x6004917")]
		[Cpp2IlInjected.Address(RVA = "0x120FED8", Offset = "0x120FED8", VA = "0x120FED8")]
		public MappingCategories()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000A0E")]
	public Panel_Layout Backing;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000A0F")]
	public TransactionButton_Layout GeneralSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000A10")]
	public TransactionButton_Layout Exploration;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000A11")]
	public TransactionButton_Layout Fighting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000A12")]
	public TransactionButton_Layout Miscellaneous;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000A13")]
	public TransactionButton_Layout UI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000A14")]
	public TransactionButton_Layout Chest;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000A15")]
	public TransactionButton_Layout Equipment;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000A16")]
	public TransactionButton_Layout Multiplayer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000A17")]
	public TransactionButton_Layout ShopCraft;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000A18")]
	public TransactionButton_Layout Map;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000A19")]
	public TransactionButton_Layout LB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000A1A")]
	public TransactionButton_Layout RB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000A1B")]
	public MappingCategories MappingSettings;

	[Cpp2IlInjected.Token(Token = "0x6000A72")]
	[Cpp2IlInjected.Address(RVA = "0x120DCE0", Offset = "0x120DCE0", VA = "0x120DCE0")]
	public void GetCategorySetup(GUISettingID id, out Category category, out int sortOrder)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A73")]
	[Cpp2IlInjected.Address(RVA = "0x120DE38", Offset = "0x120DE38", VA = "0x120DE38")]
	public void GetCategorySetup(string actionId, out Category category, out int sortOrder)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A74")]
	[Cpp2IlInjected.Address(RVA = "0x120FED0", Offset = "0x120FED0", VA = "0x120FED0")]
	public ControllerMappingsCategories_Layout()
	{
	}
}
