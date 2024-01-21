using System.Collections.Generic;
using Controller;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x2000052")]
public class GUIControllerMappings
{
	[Cpp2IlInjected.Token(Token = "0x200077F")]
	public enum MappingType
	{
		[Cpp2IlInjected.Token(Token = "0x40078CA")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x40078CB")]
		Advanced,
		[Cpp2IlInjected.Token(Token = "0x40078CC")]
		Console,
		[Cpp2IlInjected.Token(Token = "0x40078CD")]
		Custom
	}

	[Cpp2IlInjected.Token(Token = "0x2000780")]
	public enum InteractionOverloadState
	{
		[Cpp2IlInjected.Token(Token = "0x40078CF")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40078D0")]
		Inventory,
		[Cpp2IlInjected.Token(Token = "0x40078D1")]
		NPC,
		[Cpp2IlInjected.Token(Token = "0x40078D2")]
		NPCItem,
		[Cpp2IlInjected.Token(Token = "0x40078D3")]
		Map
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public bool Enabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public MappingType mapping;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private VirtualControllerInputState.CursorInputMode BackupControllerAimAndUse;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private VirtualControllerInputState.CursorInputMode BackupControllerSmartCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private bool BackupSwapBumpersTriggers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private float BackupNavigationDelay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private float BackupControllerAimSensitivity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private GUIControllerMappingEntryBase overlayEntry;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private Rectangle overlayRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public bool performingBinding;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private int disableScroll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private bool hasFocus;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private GUIInputRegionExclusive _categoriesBlocker;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private float TimeSinceItemChange;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private ControllerMappingsCategories_Layout.Category[] TabOrder;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public ControllerMappingsCategories_Layout.Category Selected;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private float GameplayButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private float UIButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private float SaveAndCloseButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private float ResetSettingsButtonScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private float titleScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	public float ScrollOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private float ScrollMomentum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int ScrollDragging;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private Vector2 DragOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public List<GUIControllerMappingEntryBase> _allSettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public List<GUIControllerMappingEntryBase> _categorySettings;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public InteractionOverloadState interactionOverloadState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private ControllerActionButton.RequiredButtonState noModifiers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private ControllerActionButton.RequiredButtonState noLeftModifiers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private ControllerActionButton.RequiredButtonState noRightModifiers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private List<GUIControllerMappingScheme> Schemes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public GUIControllerMappingOverlay _controllerInput;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public List<ControllerActionAxis> WorldAxisTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public List<ControllerActionVector> WorldAxisMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public List<ControllerActionButton> WorldButtonMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public List<ControllerActionVector> InventoryAxisMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public List<ControllerActionAxis> InventoryAxisTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public List<ControllerActionButton> InventoryButtonMappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public List<ControllerActionButton> BaseInventoryTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public List<ControllerActionButton> InventoryTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public List<ControllerActionButton> EquipmentTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public List<ControllerActionButton> ItemHeldTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public List<ControllerActionButton> ChestInvTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public List<ControllerActionButton> ChestTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public List<ControllerActionButton> ShopTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public List<ControllerActionButton> ShopInvTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public List<ControllerActionButton> CraftingTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public List<ControllerActionButton> PVPTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public List<ControllerActionButton> HousingTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public List<ControllerActionButton> ReforgeTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public List<ControllerActionButton> ChatTable;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public List<ControllerActionAxis> AxisTableEmpty;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public ControllerActionAxis MovementAxisX;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public ControllerActionAxis MovementAxisY;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public ControllerActionVector MovementAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public ControllerActionAxis MapAxisX;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public ControllerActionAxis MapAxisY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public ControllerActionVector MapAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public ControllerActionAxis MovementAxisAltX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public ControllerActionAxis MovementAxisAltY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public ControllerActionVector MovementAxisAlt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public ControllerActionAxis FireAxisX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public ControllerActionAxis FireAxisY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public ControllerActionVector FireAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public ControllerActionAxis FireAxisAltX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public ControllerActionAxis FireAxisAltY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public ControllerActionVector FireAxisAlt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public ControllerActionAxis GrappleAxisX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12C")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public ControllerActionAxis GrappleAxisY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public ControllerActionVector GrappleAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public ControllerActionButton GrappleFire;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public ControllerActionButton Jump;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public ControllerActionButton Fire;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public ControllerActionButton Interact;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public ControllerActionButton TargetLockOn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public ControllerActionButton InventoryToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public ControllerActionButton AutoSelect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public ControllerActionButton SmartCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x154")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public ControllerActionButton AutoFire;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public ControllerActionButton HotbarNext;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public ControllerActionButton HotbarPrevious;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public ControllerActionButton FireAlt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public ControllerActionAxis GridSnapAxisX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public ControllerActionAxis GridSnapAxisY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public ControllerActionVector GridSnapAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public ControllerActionButton BuffNext;

	[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public ControllerActionButton BuffPrevious;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public ControllerActionButton BuffRemove;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public ControllerActionAxis HotbarAxisX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public ControllerActionAxis HotbarAxisY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public ControllerActionVector HotbarAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public ControllerActionButton ZoomIn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public ControllerActionButton ZoomOut;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public ControllerActionButton MapZoomIn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public ControllerActionButton MapZoomOut;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public ControllerActionButton MapZoomDefault;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public ControllerActionButton QuickMount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public ControllerActionButton QuickHeal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public ControllerActionButton QuickBuff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public ControllerActionButton QuickMana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public ControllerActionButton MapToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public ControllerActionButton MiniMapToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public ControllerActionButton ChatToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public ControllerActionButton Hotbar1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public ControllerActionButton Hotbar2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public ControllerActionButton Hotbar3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public ControllerActionButton Hotbar4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public ControllerActionButton Hotbar5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public ControllerActionButton Hotbar6;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public ControllerActionButton Hotbar7;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public ControllerActionButton Hotbar8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public ControllerActionButton Hotbar9;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public ControllerActionButton Hotbar10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public ControllerActionButton DynamicHotbar1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public ControllerActionButton DynamicHotbar2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public ControllerActionButton DynamicHotbar3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public ControllerActionButton DynamicHotbar4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public ControllerActionButton Loadout1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public ControllerActionButton Loadout2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public ControllerActionButton Loadout3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public ControllerActionButton LoadoutCycle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public ControllerActionAxis InventoryNavigationX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public ControllerActionAxis InventoryNavigationY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public ControllerActionVector InventoryNavigation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public ControllerActionAxis InventoryNavigationAltX;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public ControllerActionAxis InventoryNavigationAltY;

	[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public ControllerActionVector InventoryNavigationAlt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public ControllerActionButton WorldFocusToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public ControllerActionButton LeftPageCycle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public ControllerActionButton RightPageCycle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public ControllerActionButton ThrowItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public ControllerActionButton TrashItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public ControllerActionButton DepositHeldItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public ControllerActionButton FavouriteItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public ControllerActionButton ResearchItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public ControllerActionButton SplitItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23C")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public ControllerActionButton PickupPlaceItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public ControllerActionButton CraftItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x244")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public ControllerActionButton FilterItems;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public ControllerActionButton ToggleCraftDuplicate;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public ControllerActionButton HousingQuery;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public ControllerActionButton Sort;

	[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public ControllerActionButton BuilderTools;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public ControllerActionButton TakeOne;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public ControllerActionButton InventoryClose;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public ControllerActionButton ReforgeItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public ControllerActionButton ShowHideItem;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public ControllerActionButton InfoAccessories;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public ControllerActionButton ChestQuickStack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public ControllerActionButton ChestLootAll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public ControllerActionButton ChestDepositAll;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public ControllerActionButton ChestRestock;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public ControllerActionButton ChestRename;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	public ControllerActionButton ChestLoot;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	public ControllerActionButton ChestDeposit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	public ControllerActionButton ChestSort;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	public ControllerActionButton EquipmentEquip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	public ControllerActionButton EquipmentUnequip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public ControllerActionButton ShopSell;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public ControllerActionButton ShopBuy;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29C")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	public ControllerActionButton PVPEnableToggle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	public ControllerActionButton PVPSwitchTeam;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A4")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public GUIControllerMappingStateTable WorldInteractFallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public GUIControllerMappingStateTable WorldInteract;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2AC")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public GUIControllerMappingStateTable WorldShared;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public GUIControllerMappingStateTable World;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public GUIControllerMappingStateTable BaseInventory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public GUIControllerMappingStateTable Inventory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	public GUIControllerMappingStateTable Equipment;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public GUIControllerMappingStateTable PVP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	public GUIControllerMappingStateTable Housing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	public GUIControllerMappingStateTable ItemHeld;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2CC")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	public GUIControllerMappingStateTable ChestInv;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	public GUIControllerMappingStateTable Chest;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D4")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	public GUIControllerMappingStateTable ShopInv;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public GUIControllerMappingStateTable Shop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public GUIControllerMappingStateTable Crafting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public GUIControllerMappingStateTable Reforge;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public GUIControllerMappingStateTable Chat;

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xF748E0", Offset = "0xF748E0", VA = "0xF748E0")]
	public void ClearMappingStates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0xF756B8", Offset = "0xF756B8", VA = "0xF756B8")]
	private void ClearWorldMappings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0xF7598C", Offset = "0xF7598C", VA = "0xF7598C")]
	private void ClearInventoryMappings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0xF75B70", Offset = "0xF75B70", VA = "0xF75B70")]
	public void Backup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0xF76998", Offset = "0xF76998", VA = "0xF76998")]
	public void RestoreBackup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0xF76A38", Offset = "0xF76A38", VA = "0xF76A38")]
	public void ClearMapping()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0xF6DCD4", Offset = "0xF6DCD4", VA = "0xF6DCD4")]
	public void RegisterOverlay(GUIControllerMappingEntryBase entry, Rectangle region)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0xF76AFC", Offset = "0xF76AFC", VA = "0xF76AFC")]
	public void Draw()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0xF78944", Offset = "0xF78944", VA = "0xF78944")]
	public void LooseFocus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0xF76E5C", Offset = "0xF76E5C", VA = "0xF76E5C")]
	private void GainFocus()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0xF789CC", Offset = "0xF789CC", VA = "0xF789CC")]
	private bool IsOverCategories(Vector2 cursorPosition)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0xF776C8", Offset = "0xF776C8", VA = "0xF776C8")]
	private void DrawCategories()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0xF76E4C", Offset = "0xF76E4C", VA = "0xF76E4C")]
	public void Close()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0xF78248", Offset = "0xF78248", VA = "0xF78248")]
	private void DrawMainButtons()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0xF771F0", Offset = "0xF771F0", VA = "0xF771F0")]
	private void DrawTitle()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0xF76F18", Offset = "0xF76F18", VA = "0xF76F18")]
	private void DrawBacking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0xF77024", Offset = "0xF77024", VA = "0xF77024")]
	private void DrawCategoryOptions()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0xF78B78", Offset = "0xF78B78", VA = "0xF78B78")]
	private float SettingScale(int index)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0xF78B80", Offset = "0xF78B80", VA = "0xF78B80")]
	private void SettingOver(int index)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0xF78B84", Offset = "0xF78B84", VA = "0xF78B84")]
	private void SettingDraw(ItemGrid_Layout gridLayout, int index, Vector2 position, float scale)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0xF78CD0", Offset = "0xF78CD0", VA = "0xF78CD0")]
	private Vector2 SettingSize(int index)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0xF75C14", Offset = "0xF75C14", VA = "0xF75C14")]
	public void SetCategory(ControllerMappingsCategories_Layout.Category category)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0xF6DEC4", Offset = "0xF6DEC4", VA = "0xF6DEC4")]
	public void RefreshConfigurationState()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0xF78D98", Offset = "0xF78D98", VA = "0xF78D98")]
	public VirtualControllerInputState.CursorInputMode GetMode(Preferences preferences, string id, VirtualControllerInputState.CursorInputMode defaultValue)
	{
		return default(VirtualControllerInputState.CursorInputMode);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0xF78E28", Offset = "0xF78E28", VA = "0xF78E28")]
	public void LoadConfiguration(Preferences preferences, bool existingConfiguration)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0xF79430", Offset = "0xF79430", VA = "0xF79430")]
	public GUIControllerMappingScheme GetDefaultScheme(MappingType mappingType)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0xF79324", Offset = "0xF79324", VA = "0xF79324")]
	public void SetMapping(MappingType mappingType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0xF794F8", Offset = "0xF794F8", VA = "0xF794F8")]
	private void SetupUIMappingState(ControllerActionButton buttonMapping)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0xF795D4", Offset = "0xF795D4", VA = "0xF795D4")]
	private void SetupWorldUIMappingState(ControllerActionButton buttonMapping)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xF796E0", Offset = "0xF796E0", VA = "0xF796E0")]
	public void UpdateUIInteractionOverloads(InteractionOverloadState newInteractionOverloadState)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0xF79CC4", Offset = "0xF79CC4", VA = "0xF79CC4")]
	public void SetupMappings()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0xF6DE98", Offset = "0xF6DE98", VA = "0xF6DE98")]
	public void LoadMappingValues()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0xF7B734", Offset = "0xF7B734", VA = "0xF7B734")]
	public void SaveConfiguration(Preferences preferences)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0xF7BB28", Offset = "0xF7BB28", VA = "0xF7BB28")]
	public GUIControllerMappings()
	{
	}
}
