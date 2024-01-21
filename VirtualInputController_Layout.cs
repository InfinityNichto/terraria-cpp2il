using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Cpp2IlInjected.Token(Token = "0x20001BE")]
public class VirtualInputController_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x20007EB")]
	public enum ContolType
	{
		[Cpp2IlInjected.Token(Token = "0x4007C93")]
		AutoFire,
		[Cpp2IlInjected.Token(Token = "0x4007C94")]
		SmartCursor,
		[Cpp2IlInjected.Token(Token = "0x4007C95")]
		CombatTargetting,
		[Cpp2IlInjected.Token(Token = "0x4007C96")]
		Jump,
		[Cpp2IlInjected.Token(Token = "0x4007C97")]
		Heal,
		[Cpp2IlInjected.Token(Token = "0x4007C98")]
		Mana,
		[Cpp2IlInjected.Token(Token = "0x4007C99")]
		Buff,
		[Cpp2IlInjected.Token(Token = "0x4007C9A")]
		Mount,
		[Cpp2IlInjected.Token(Token = "0x4007C9B")]
		Interact,
		[Cpp2IlInjected.Token(Token = "0x4007C9C")]
		Fire,
		[Cpp2IlInjected.Token(Token = "0x4007C9D")]
		GrappleAxis,
		[Cpp2IlInjected.Token(Token = "0x4007C9E")]
		Count
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20007EC")]
	public class SlotEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007C9F")]
		public ContolType DefaultControl;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007CA0")]
		public ControlAnchor.ControlId AnchorControl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007CA1")]
		public LayoutCalculator.AnchorType Anchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007CA2")]
		public Vector2 Location;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4007CA3")]
		public float Scale;

		[Cpp2IlInjected.Token(Token = "0x6004923")]
		[Cpp2IlInjected.Address(RVA = "0xE8EC88", Offset = "0xE8EC88", VA = "0xE8EC88")]
		public SlotEntry()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4001390")]
	public static VirtualInputController_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001391")]
	public QuickActionButton_Layout Jump;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001392")]
	public QuickActionButton_Layout Jump2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001393")]
	public Axis_Layout Movement;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001394")]
	public QuickActionButton_Layout Heal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001395")]
	public QuickActionButton_Layout Mana;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001396")]
	public QuickActionButton_Layout Buff;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001397")]
	public QuickActionButton_Layout Mount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001398")]
	public QuickActionButton_Layout SmartCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001399")]
	public QuickActionButton_Layout AutoFire;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400139A")]
	public QuickActionButton_Layout ZoomIn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400139B")]
	public QuickActionButton_Layout ZoomOut;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400139C")]
	public Panel_Layout ZoomBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400139D")]
	public QuickActionButton_Layout Interact;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400139E")]
	public QuickActionButton_Layout Fire;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400139F")]
	public QuickActionButton_Layout Fire2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40013A0")]
	public QuickActionButton_Layout Inventory;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40013A1")]
	public QuickActionButton_Layout AutoSelect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40013A2")]
	public QuickActionButton_Layout GrappleSelect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40013A3")]
	public QuickActionButton_Layout TargetLockOn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40013A4")]
	public FadeString_Layout ZoomValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40013A5")]
	public Axis_Layout FireAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40013A6")]
	public Axis_Layout GrappleAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40013A7")]
	public FadeString_Layout NotifySmartCursor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40013A8")]
	public FadeString_Layout NotifyAutoFire;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40013A9")]
	public FadeString_Layout NotifyCombatTargeting;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40013AA")]
	public FadeString_Layout NotifyProfile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40013AB")]
	public FadeString_Layout NotifySmartCursorController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40013AC")]
	public FadeString_Layout NotifyAutoFireController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40013AD")]
	public FadeString_Layout NotifyCombatTargetingController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40013AE")]
	public FadeString_Layout NotifyProfileController;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40013AF")]
	public String_Layout ProfileSwitchString;

	[Cpp2IlInjected.Token(Token = "0x6000C49")]
	[Cpp2IlInjected.Address(RVA = "0xE8EBB0", Offset = "0xE8EBB0", VA = "0xE8EBB0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C4A")]
	[Cpp2IlInjected.Address(RVA = "0xE8EC0C", Offset = "0xE8EC0C", VA = "0xE8EC0C")]
	public VirtualInputController_Layout()
	{
	}
}
