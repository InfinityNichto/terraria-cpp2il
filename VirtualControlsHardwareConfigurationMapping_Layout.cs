using System;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x20001B9")]
public class VirtualControlsHardwareConfigurationMapping_Layout
{
	[Cpp2IlInjected.Token(Token = "0x20007E9")]
	public enum ContolType
	{
		[Cpp2IlInjected.Token(Token = "0x4007C76")]
		AutoFire,
		[Cpp2IlInjected.Token(Token = "0x4007C77")]
		SmartCursor,
		[Cpp2IlInjected.Token(Token = "0x4007C78")]
		CombatTargetting,
		[Cpp2IlInjected.Token(Token = "0x4007C79")]
		Jump,
		[Cpp2IlInjected.Token(Token = "0x4007C7A")]
		Heal,
		[Cpp2IlInjected.Token(Token = "0x4007C7B")]
		Mana,
		[Cpp2IlInjected.Token(Token = "0x4007C7C")]
		Buff,
		[Cpp2IlInjected.Token(Token = "0x4007C7D")]
		Mount,
		[Cpp2IlInjected.Token(Token = "0x4007C7E")]
		Interact,
		[Cpp2IlInjected.Token(Token = "0x4007C7F")]
		Fire,
		[Cpp2IlInjected.Token(Token = "0x4007C80")]
		GrappleAxis,
		[Cpp2IlInjected.Token(Token = "0x4007C81")]
		AutoSelect,
		[Cpp2IlInjected.Token(Token = "0x4007C82")]
		ZoomIn,
		[Cpp2IlInjected.Token(Token = "0x4007C83")]
		ZoomOut,
		[Cpp2IlInjected.Token(Token = "0x4007C84")]
		Move,
		[Cpp2IlInjected.Token(Token = "0x4007C85")]
		Aim,
		[Cpp2IlInjected.Token(Token = "0x4007C86")]
		GrappleFire,
		[Cpp2IlInjected.Token(Token = "0x4007C87")]
		ProfileSwitch,
		[Cpp2IlInjected.Token(Token = "0x4007C88")]
		InventoryToggle,
		[Cpp2IlInjected.Token(Token = "0x4007C89")]
		Settings,
		[Cpp2IlInjected.Token(Token = "0x4007C8A")]
		Loadout1,
		[Cpp2IlInjected.Token(Token = "0x4007C8B")]
		Loadout2,
		[Cpp2IlInjected.Token(Token = "0x4007C8C")]
		Loadout3,
		[Cpp2IlInjected.Token(Token = "0x4007C8D")]
		LoadoutCycle,
		[Cpp2IlInjected.Token(Token = "0x4007C8E")]
		Count
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400136F")]
	public string SlotId;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001370")]
	public VirtualControlsSlotTypeMapping_Layout Style;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001371")]
	public ContolType DefaultControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001372")]
	public ControlAnchor.ControlId AnchorControl;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001373")]
	public LayoutCalculator.AnchorType Anchor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001374")]
	public Vector2 Location;

	[Cpp2IlInjected.Token(Token = "0x6000C2E")]
	[Cpp2IlInjected.Address(RVA = "0xE8CD08", Offset = "0xE8CD08", VA = "0xE8CD08")]
	public void Copy(VirtualControlsHardwareConfigurationMapping_Layout other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2F")]
	[Cpp2IlInjected.Address(RVA = "0xE8CDC8", Offset = "0xE8CDC8", VA = "0xE8CDC8")]
	public bool IsSame(VirtualControlsHardwareConfigurationMapping_Layout other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C30")]
	[Cpp2IlInjected.Address(RVA = "0xE8CF00", Offset = "0xE8CF00", VA = "0xE8CF00")]
	public VirtualControlsHardwareConfigurationMapping_Layout()
	{
	}
}
