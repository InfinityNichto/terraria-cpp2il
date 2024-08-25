using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x2000250")]
public class VirtualInputController_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D50")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D71B8", Offset = "0x9D71B8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D51")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D7204", Offset = "0x9D7204", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public VirtualInputController_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001862")]
	public static VirtualInputController_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001863")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public QuickActionButton_Layout Jump;

	[global::Cpp2ILInjected.Token(Token = "0x4001864")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public QuickActionButton_Layout Jump2;

	[global::Cpp2ILInjected.Token(Token = "0x4001865")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Axis_Layout Movement;

	[global::Cpp2ILInjected.Token(Token = "0x4001866")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public QuickActionButton_Layout Heal;

	[global::Cpp2ILInjected.Token(Token = "0x4001867")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public QuickActionButton_Layout Mana;

	[global::Cpp2ILInjected.Token(Token = "0x4001868")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public QuickActionButton_Layout Buff;

	[global::Cpp2ILInjected.Token(Token = "0x4001869")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public QuickActionButton_Layout Mount;

	[global::Cpp2ILInjected.Token(Token = "0x400186A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public QuickActionButton_Layout SmartCursor;

	[global::Cpp2ILInjected.Token(Token = "0x400186B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public QuickActionButton_Layout AutoFire;

	[global::Cpp2ILInjected.Token(Token = "0x400186C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public QuickActionButton_Layout ZoomIn;

	[global::Cpp2ILInjected.Token(Token = "0x400186D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public QuickActionButton_Layout ZoomOut;

	[global::Cpp2ILInjected.Token(Token = "0x400186E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Panel_Layout ZoomBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400186F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public QuickActionButton_Layout Interact;

	[global::Cpp2ILInjected.Token(Token = "0x4001870")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public QuickActionButton_Layout Fire;

	[global::Cpp2ILInjected.Token(Token = "0x4001871")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public QuickActionButton_Layout Fire2;

	[global::Cpp2ILInjected.Token(Token = "0x4001872")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public QuickActionButton_Layout Inventory;

	[global::Cpp2ILInjected.Token(Token = "0x4001873")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public QuickActionButton_Layout AutoSelect;

	[global::Cpp2ILInjected.Token(Token = "0x4001874")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public QuickActionButton_Layout GrappleSelect;

	[global::Cpp2ILInjected.Token(Token = "0x4001875")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public QuickActionButton_Layout TargetLockOn;

	[global::Cpp2ILInjected.Token(Token = "0x4001876")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public FadeString_Layout ZoomValue;

	[global::Cpp2ILInjected.Token(Token = "0x4001877")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public Axis_Layout FireAxis;

	[global::Cpp2ILInjected.Token(Token = "0x4001878")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public Axis_Layout GrappleAxis;

	[global::Cpp2ILInjected.Token(Token = "0x4001879")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public FadeString_Layout NotifySmartCursor;

	[global::Cpp2ILInjected.Token(Token = "0x400187A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public FadeString_Layout NotifyAutoFire;

	[global::Cpp2ILInjected.Token(Token = "0x400187B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public FadeString_Layout NotifyCombatTargeting;

	[global::Cpp2ILInjected.Token(Token = "0x400187C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public FadeString_Layout NotifyProfile;

	[global::Cpp2ILInjected.Token(Token = "0x400187D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public FadeString_Layout NotifySmartCursorController;

	[global::Cpp2ILInjected.Token(Token = "0x400187E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public FadeString_Layout NotifyAutoFireController;

	[global::Cpp2ILInjected.Token(Token = "0x400187F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public FadeString_Layout NotifyCombatTargetingController;

	[global::Cpp2ILInjected.Token(Token = "0x4001880")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public FadeString_Layout NotifyProfileController;

	[global::Cpp2ILInjected.Token(Token = "0x4001881")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public String_Layout ProfileSwitchString;

	[global::Cpp2ILInjected.Token(Token = "0x2000251")]
	public enum ContolType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001883")]
		AutoFire,
		[global::Cpp2ILInjected.Token(Token = "0x4001884")]
		SmartCursor,
		[global::Cpp2ILInjected.Token(Token = "0x4001885")]
		CombatTargetting,
		[global::Cpp2ILInjected.Token(Token = "0x4001886")]
		Jump,
		[global::Cpp2ILInjected.Token(Token = "0x4001887")]
		Heal,
		[global::Cpp2ILInjected.Token(Token = "0x4001888")]
		Mana,
		[global::Cpp2ILInjected.Token(Token = "0x4001889")]
		Buff,
		[global::Cpp2ILInjected.Token(Token = "0x400188A")]
		Mount,
		[global::Cpp2ILInjected.Token(Token = "0x400188B")]
		Interact,
		[global::Cpp2ILInjected.Token(Token = "0x400188C")]
		Fire,
		[global::Cpp2ILInjected.Token(Token = "0x400188D")]
		GrappleAxis,
		[global::Cpp2ILInjected.Token(Token = "0x400188E")]
		Count
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000252")]
	[Serializable]
	public class SlotEntry
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000D52")]
		[global::Cpp2ILInjected.Address(RVA = "0x9D725C", Offset = "0x9D725C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public SlotEntry()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400188F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public VirtualInputController_Layout.ContolType DefaultControl;

		[global::Cpp2ILInjected.Token(Token = "0x4001890")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public ControlAnchor.ControlId AnchorControl;

		[global::Cpp2ILInjected.Token(Token = "0x4001891")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public LayoutCalculator.AnchorType Anchor;

		[global::Cpp2ILInjected.Token(Token = "0x4001892")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public Vector2 Location;

		[global::Cpp2ILInjected.Token(Token = "0x4001893")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public float Scale;
	}
}
