using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

[global::Cpp2ILInjected.Token(Token = "0x2000249")]
[Serializable]
public class VirtualControlsHardwareConfigurationMapping_Layout
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D35")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5998", Offset = "0x9D5998", Length = "0x98")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void Copy(VirtualControlsHardwareConfigurationMapping_Layout other)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D36")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5A38", Offset = "0x9D5A38", Length = "0x10C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "IsSame", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Vector2),
		typeof(Vector2)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public bool IsSame(VirtualControlsHardwareConfigurationMapping_Layout other)
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D37")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D5B44", Offset = "0x9D5B44", Length = "0xA4")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VirtualControlsHardwareConfiguration_Layout), Member = "Copy", MemberParameters = new object[] { typeof(VirtualControlsHardwareConfiguration_Layout) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIVirtualInputControllerEdit), Member = "CreateNewSlot", MemberParameters = new object[]
	{
		typeof(VirtualControlsSlotTypeMapping_Layout.SlotType),
		typeof(string),
		typeof(Vector2)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public VirtualControlsHardwareConfigurationMapping_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001824")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string SlotId;

	[global::Cpp2ILInjected.Token(Token = "0x4001825")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public VirtualControlsSlotTypeMapping_Layout Style;

	[global::Cpp2ILInjected.Token(Token = "0x4001826")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public VirtualControlsHardwareConfigurationMapping_Layout.ContolType DefaultControl;

	[global::Cpp2ILInjected.Token(Token = "0x4001827")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public ControlAnchor.ControlId AnchorControl;

	[global::Cpp2ILInjected.Token(Token = "0x4001828")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public LayoutCalculator.AnchorType Anchor;

	[global::Cpp2ILInjected.Token(Token = "0x4001829")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public Vector2 Location;

	[global::Cpp2ILInjected.Token(Token = "0x200024A")]
	public enum ContolType
	{
		[global::Cpp2ILInjected.Token(Token = "0x400182B")]
		AutoFire,
		[global::Cpp2ILInjected.Token(Token = "0x400182C")]
		SmartCursor,
		[global::Cpp2ILInjected.Token(Token = "0x400182D")]
		CombatTargetting,
		[global::Cpp2ILInjected.Token(Token = "0x400182E")]
		Jump,
		[global::Cpp2ILInjected.Token(Token = "0x400182F")]
		Heal,
		[global::Cpp2ILInjected.Token(Token = "0x4001830")]
		Mana,
		[global::Cpp2ILInjected.Token(Token = "0x4001831")]
		Buff,
		[global::Cpp2ILInjected.Token(Token = "0x4001832")]
		Mount,
		[global::Cpp2ILInjected.Token(Token = "0x4001833")]
		Interact,
		[global::Cpp2ILInjected.Token(Token = "0x4001834")]
		Fire,
		[global::Cpp2ILInjected.Token(Token = "0x4001835")]
		GrappleAxis,
		[global::Cpp2ILInjected.Token(Token = "0x4001836")]
		AutoSelect,
		[global::Cpp2ILInjected.Token(Token = "0x4001837")]
		ZoomIn,
		[global::Cpp2ILInjected.Token(Token = "0x4001838")]
		ZoomOut,
		[global::Cpp2ILInjected.Token(Token = "0x4001839")]
		Move,
		[global::Cpp2ILInjected.Token(Token = "0x400183A")]
		Aim,
		[global::Cpp2ILInjected.Token(Token = "0x400183B")]
		GrappleFire,
		[global::Cpp2ILInjected.Token(Token = "0x400183C")]
		ProfileSwitch,
		[global::Cpp2ILInjected.Token(Token = "0x400183D")]
		InventoryToggle,
		[global::Cpp2ILInjected.Token(Token = "0x400183E")]
		Settings,
		[global::Cpp2ILInjected.Token(Token = "0x400183F")]
		Loadout1,
		[global::Cpp2ILInjected.Token(Token = "0x4001840")]
		Loadout2,
		[global::Cpp2ILInjected.Token(Token = "0x4001841")]
		Loadout3,
		[global::Cpp2ILInjected.Token(Token = "0x4001842")]
		LoadoutCycle,
		[global::Cpp2ILInjected.Token(Token = "0x4001843")]
		Count
	}
}
