using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x200021F")]
public class VirtualInputControllerEdit_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000CD2")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D05B8", Offset = "0x9D05B8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000CD3")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0604", Offset = "0x9D0604", Length = "0x168")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public VirtualInputControllerEdit_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40014C9")]
	public static VirtualInputControllerEdit_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40014CA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float ControllerDragSpeed;

	[global::Cpp2ILInjected.Token(Token = "0x40014CB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Finish;

	[global::Cpp2ILInjected.Token(Token = "0x40014CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout ResetDefaults;

	[global::Cpp2ILInjected.Token(Token = "0x40014CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout CancelChanges;

	[global::Cpp2ILInjected.Token(Token = "0x40014CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout ControlSelection;

	[global::Cpp2ILInjected.Token(Token = "0x40014CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public Panel_Layout AllowedLeftRegion;

	[global::Cpp2ILInjected.Token(Token = "0x40014D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Panel_Layout AllowedRightRegion;

	[global::Cpp2ILInjected.Token(Token = "0x40014D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Panel_Layout LeftControlRegion;

	[global::Cpp2ILInjected.Token(Token = "0x40014D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public Color LeftControlRegionDraggingBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
	public Color LeftControlRegionDraggingBorderColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Panel_Layout RightControlRegion;

	[global::Cpp2ILInjected.Token(Token = "0x40014D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Color RightControlRegionDraggingBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public Color RightControlRegionDraggingBorderColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014D7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout AllowedInterfaceLeftRegion;

	[global::Cpp2ILInjected.Token(Token = "0x40014D8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public Panel_Layout AllowedInterfaceRightRegion;

	[global::Cpp2ILInjected.Token(Token = "0x40014D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public Panel_Layout AllowedInterfaceLeftRegionSmall;

	[global::Cpp2ILInjected.Token(Token = "0x40014DA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public Panel_Layout AllowedInterfaceRightRegionSmall;

	[global::Cpp2ILInjected.Token(Token = "0x40014DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public Panel_Layout LeftInterfaceRegion;

	[global::Cpp2ILInjected.Token(Token = "0x40014DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public Panel_Layout RightInterfaceRegion;

	[global::Cpp2ILInjected.Token(Token = "0x40014DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Color LeftInterfaceRegionDraggingBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public Color LeftInterfaceRegionDraggingBorderColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014DF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Color RightInterfaceRegionDraggingBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014E0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
	public Color RightInterfaceRegionDraggingBorderColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014E1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public Color DisabledPageBackingColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014E2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public Color DisabledPageIconColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Color DisabledHotbarColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public Color DisabledInventoryColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Color DisabledTrashColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
	public Color DisabledTrashIconColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public Color DisabledChestColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
	public Color DisabledPageTitleColor;

	[global::Cpp2ILInjected.Token(Token = "0x40014E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Panel_Layout ScreenBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40014EA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Panel_Layout ControlsBacking;

	[global::Cpp2ILInjected.Token(Token = "0x40014EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public ItemGrid_Layout ControlsGrid;

	[global::Cpp2ILInjected.Token(Token = "0x40014EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public float ControlsItemScale;

	[global::Cpp2ILInjected.Token(Token = "0x40014ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
	public Vector2 ControlsGridAxisOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40014EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
	public Vector2 ControlsGridButtonOffset;

	[global::Cpp2ILInjected.Token(Token = "0x40014EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public TransactionButton_Layout Mappings;

	[global::Cpp2ILInjected.Token(Token = "0x40014F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public TransactionButton_Layout Controls;

	[global::Cpp2ILInjected.Token(Token = "0x40014F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public FadeString_Layout FadeLabel;

	[global::Cpp2ILInjected.Token(Token = "0x40014F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public VirtualInputControllerEdit_Layout.SlotPriority ControlPriority;

	[global::Cpp2ILInjected.Token(Token = "0x40014F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public VirtualInputControllerEdit_Layout.ControlsWidgets EditControlWidgets;

	[global::Cpp2ILInjected.Token(Token = "0x2000220")]
	[Serializable]
	public class SlotPriority
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CD4")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D076C", Offset = "0x9D076C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIVirtualInputControllerEdit.<>c__DisplayClass72_0", Member = "<RefreshSlotOrder>b__0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int Priority(VirtualControlsHardwareConfigurationMapping_Layout.ContolType type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000CD5")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D0860", Offset = "0x9D0860", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SlotPriority()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40014F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int AutoFire;

		[global::Cpp2ILInjected.Token(Token = "0x40014F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int SmartCursor;

		[global::Cpp2ILInjected.Token(Token = "0x40014F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int CombatTargetting;

		[global::Cpp2ILInjected.Token(Token = "0x40014F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int Jump;

		[global::Cpp2ILInjected.Token(Token = "0x40014F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int Heal;

		[global::Cpp2ILInjected.Token(Token = "0x40014F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public int Mana;

		[global::Cpp2ILInjected.Token(Token = "0x40014FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public int Buff;

		[global::Cpp2ILInjected.Token(Token = "0x40014FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public int Mount;

		[global::Cpp2ILInjected.Token(Token = "0x40014FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public int Interact;

		[global::Cpp2ILInjected.Token(Token = "0x40014FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int Fire;

		[global::Cpp2ILInjected.Token(Token = "0x40014FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int GrappleAxis;

		[global::Cpp2ILInjected.Token(Token = "0x40014FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int AutoSelect;

		[global::Cpp2ILInjected.Token(Token = "0x4001500")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int ZoomIn;

		[global::Cpp2ILInjected.Token(Token = "0x4001501")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public int ZoomOut;

		[global::Cpp2ILInjected.Token(Token = "0x4001502")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public int Move;

		[global::Cpp2ILInjected.Token(Token = "0x4001503")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		public int Aim;

		[global::Cpp2ILInjected.Token(Token = "0x4001504")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public int GrappleFire;

		[global::Cpp2ILInjected.Token(Token = "0x4001505")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public int ProfileSwitch;

		[global::Cpp2ILInjected.Token(Token = "0x4001506")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public int Unbound;

		[global::Cpp2ILInjected.Token(Token = "0x4001507")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public int InventoryToggle;

		[global::Cpp2ILInjected.Token(Token = "0x4001508")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public int Settings;

		[global::Cpp2ILInjected.Token(Token = "0x4001509")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public int Loadout1;

		[global::Cpp2ILInjected.Token(Token = "0x400150A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public int Loadout2;

		[global::Cpp2ILInjected.Token(Token = "0x400150B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		public int Loadout3;

		[global::Cpp2ILInjected.Token(Token = "0x400150C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public int LoadoutCycle;
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000221")]
	[Serializable]
	public class ControlsWidgets
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CD6")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D0868", Offset = "0x9D0868", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ControlsWidgets()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400150D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public Panel_Layout OptionsGreyout;

		[global::Cpp2ILInjected.Token(Token = "0x400150E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public TransactionButton_Layout ProfileValue;

		[global::Cpp2ILInjected.Token(Token = "0x400150F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public String_Layout ProfileTitle;

		[global::Cpp2ILInjected.Token(Token = "0x4001510")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public TransactionButton_Layout ProfileRename;

		[global::Cpp2ILInjected.Token(Token = "0x4001511")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public Panel_Layout ProfileOptionsBacking;

		[global::Cpp2ILInjected.Token(Token = "0x4001512")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public TransactionButton_Layout Profile1;

		[global::Cpp2ILInjected.Token(Token = "0x4001513")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public TransactionButton_Layout Profile2;

		[global::Cpp2ILInjected.Token(Token = "0x4001514")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public TransactionButton_Layout Profile3;

		[global::Cpp2ILInjected.Token(Token = "0x4001515")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public TransactionButton_Layout Profile4;

		[global::Cpp2ILInjected.Token(Token = "0x4001516")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		public TransactionButton_Layout HardwareValue;

		[global::Cpp2ILInjected.Token(Token = "0x4001517")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public String_Layout HardwareTitle;

		[global::Cpp2ILInjected.Token(Token = "0x4001518")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		public Panel_Layout HardwareOptionsBacking;

		[global::Cpp2ILInjected.Token(Token = "0x4001519")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		public TransactionButton_Layout Hardware1;

		[global::Cpp2ILInjected.Token(Token = "0x400151A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		public TransactionButton_Layout Hardware2;

		[global::Cpp2ILInjected.Token(Token = "0x400151B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public TransactionButton_Layout Hardware3;

		[global::Cpp2ILInjected.Token(Token = "0x400151C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public TransactionButton_Layout Hardware4;

		[global::Cpp2ILInjected.Token(Token = "0x400151D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		public TransactionButton_Layout StyleValue;

		[global::Cpp2ILInjected.Token(Token = "0x400151E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public String_Layout StyleTitle;

		[global::Cpp2ILInjected.Token(Token = "0x400151F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public Panel_Layout StyleOptionsBacking2;

		[global::Cpp2ILInjected.Token(Token = "0x4001520")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		public Panel_Layout StyleOptionsBacking3;

		[global::Cpp2ILInjected.Token(Token = "0x4001521")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		public TransactionButton_Layout Style1;

		[global::Cpp2ILInjected.Token(Token = "0x4001522")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		public TransactionButton_Layout Style2;

		[global::Cpp2ILInjected.Token(Token = "0x4001523")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		public TransactionButton_Layout Style3;

		[global::Cpp2ILInjected.Token(Token = "0x4001524")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		public Panel_Layout PageOptionsBacking;

		[global::Cpp2ILInjected.Token(Token = "0x4001525")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		public TransactionButton_Layout PageOptionValue;

		[global::Cpp2ILInjected.Token(Token = "0x4001526")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		public TransactionButton_Layout BottomControls;

		[global::Cpp2ILInjected.Token(Token = "0x4001527")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		public TransactionButton_Layout SideControls;

		[global::Cpp2ILInjected.Token(Token = "0x4001528")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		public TransactionButton_Layout Undo;

		[global::Cpp2ILInjected.Token(Token = "0x4001529")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		public TransactionButton_Layout Redo;
	}
}
