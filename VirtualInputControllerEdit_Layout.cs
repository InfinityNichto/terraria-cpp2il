using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x2000194")]
public class VirtualInputControllerEdit_Layout : LayoutDefinition
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20007E4")]
	public class SlotPriority
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007C1B")]
		public int AutoFire;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007C1C")]
		public int SmartCursor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007C1D")]
		public int CombatTargetting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007C1E")]
		public int Jump;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007C1F")]
		public int Heal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007C20")]
		public int Mana;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007C21")]
		public int Buff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4007C22")]
		public int Mount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4007C23")]
		public int Interact;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4007C24")]
		public int Fire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4007C25")]
		public int GrappleAxis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4007C26")]
		public int AutoSelect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4007C27")]
		public int ZoomIn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4007C28")]
		public int ZoomOut;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4007C29")]
		public int Move;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4007C2A")]
		public int Aim;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4007C2B")]
		public int GrappleFire;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4007C2C")]
		public int ProfileSwitch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4007C2D")]
		public int Unbound;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4007C2E")]
		public int InventoryToggle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4007C2F")]
		public int Settings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4007C30")]
		public int Loadout1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4007C31")]
		public int Loadout2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4007C32")]
		public int Loadout3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4007C33")]
		public int LoadoutCycle;

		[Cpp2IlInjected.Token(Token = "0x600491F")]
		[Cpp2IlInjected.Address(RVA = "0xE8EA60", Offset = "0xE8EA60", VA = "0xE8EA60")]
		public int Priority(VirtualControlsHardwareConfigurationMapping_Layout.ContolType type)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6004920")]
		[Cpp2IlInjected.Address(RVA = "0xE8EBA8", Offset = "0xE8EBA8", VA = "0xE8EBA8")]
		public SlotPriority()
		{
		}
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20007E5")]
	public class ControlsWidgets
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007C34")]
		public Panel_Layout OptionsGreyout;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007C35")]
		public TransactionButton_Layout ProfileValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007C36")]
		public String_Layout ProfileTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007C37")]
		public TransactionButton_Layout ProfileRename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007C38")]
		public Panel_Layout ProfileOptionsBacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007C39")]
		public TransactionButton_Layout Profile1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007C3A")]
		public TransactionButton_Layout Profile2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4007C3B")]
		public TransactionButton_Layout Profile3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4007C3C")]
		public TransactionButton_Layout Profile4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4007C3D")]
		public TransactionButton_Layout HardwareValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4007C3E")]
		public String_Layout HardwareTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4007C3F")]
		public Panel_Layout HardwareOptionsBacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4007C40")]
		public TransactionButton_Layout Hardware1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4007C41")]
		public TransactionButton_Layout Hardware2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4007C42")]
		public TransactionButton_Layout Hardware3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4007C43")]
		public TransactionButton_Layout Hardware4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4007C44")]
		public TransactionButton_Layout StyleValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4007C45")]
		public String_Layout StyleTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4007C46")]
		public Panel_Layout StyleOptionsBacking2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4007C47")]
		public Panel_Layout StyleOptionsBacking3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4007C48")]
		public TransactionButton_Layout Style1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4007C49")]
		public TransactionButton_Layout Style2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4007C4A")]
		public TransactionButton_Layout Style3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4007C4B")]
		public Panel_Layout PageOptionsBacking;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4007C4C")]
		public TransactionButton_Layout PageOptionValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4007C4D")]
		public TransactionButton_Layout BottomControls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4007C4E")]
		public TransactionButton_Layout SideControls;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4007C4F")]
		public TransactionButton_Layout Undo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4007C50")]
		public TransactionButton_Layout Redo;

		[Cpp2IlInjected.Token(Token = "0x6004921")]
		[Cpp2IlInjected.Address(RVA = "0xE8EA58", Offset = "0xE8EA58", VA = "0xE8EA58")]
		public ControlsWidgets()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400106E")]
	public static VirtualInputControllerEdit_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400106F")]
	public float ControllerDragSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001070")]
	public TransactionButton_Layout Finish;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001071")]
	public TransactionButton_Layout ResetDefaults;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001072")]
	public TransactionButton_Layout CancelChanges;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001073")]
	public ItemGrid_Layout ControlSelection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001074")]
	public Panel_Layout AllowedLeftRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001075")]
	public Panel_Layout AllowedRightRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001076")]
	public Panel_Layout LeftControlRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001077")]
	public Color LeftControlRegionDraggingBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001078")]
	public Color LeftControlRegionDraggingBorderColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001079")]
	public Panel_Layout RightControlRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400107A")]
	public Color RightControlRegionDraggingBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400107B")]
	public Color RightControlRegionDraggingBorderColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400107C")]
	public Panel_Layout AllowedInterfaceLeftRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400107D")]
	public Panel_Layout AllowedInterfaceRightRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400107E")]
	public Panel_Layout AllowedInterfaceLeftRegionSmall;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400107F")]
	public Panel_Layout AllowedInterfaceRightRegionSmall;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001080")]
	public Panel_Layout LeftInterfaceRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001081")]
	public Panel_Layout RightInterfaceRegion;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001082")]
	public Color LeftInterfaceRegionDraggingBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001083")]
	public Color LeftInterfaceRegionDraggingBorderColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4001084")]
	public Color RightInterfaceRegionDraggingBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4001085")]
	public Color RightInterfaceRegionDraggingBorderColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4001086")]
	public Color DisabledPageBackingColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4001087")]
	public Color DisabledPageIconColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4001088")]
	public Color DisabledHotbarColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4001089")]
	public Color DisabledInventoryColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400108A")]
	public Color DisabledTrashColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400108B")]
	public Color DisabledTrashIconColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400108C")]
	public Color DisabledChestColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400108D")]
	public Color DisabledPageTitleColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400108E")]
	public Panel_Layout ScreenBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400108F")]
	public Panel_Layout ControlsBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4001090")]
	public ItemGrid_Layout ControlsGrid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4001091")]
	public float ControlsItemScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4001092")]
	public Vector2 ControlsGridAxisOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4001093")]
	public Vector2 ControlsGridButtonOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4001094")]
	public TransactionButton_Layout Mappings;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4001095")]
	public TransactionButton_Layout Controls;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4001096")]
	public FadeString_Layout FadeLabel;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4001097")]
	public SlotPriority ControlPriority;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4001098")]
	public ControlsWidgets EditControlWidgets;

	[Cpp2IlInjected.Token(Token = "0x6000BCE")]
	[Cpp2IlInjected.Address(RVA = "0xE8E864", Offset = "0xE8E864", VA = "0xE8E864")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000BCF")]
	[Cpp2IlInjected.Address(RVA = "0xE8E8C0", Offset = "0xE8E8C0", VA = "0xE8E8C0")]
	public VirtualInputControllerEdit_Layout()
	{
	}
}
