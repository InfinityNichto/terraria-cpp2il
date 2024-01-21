using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x20001BC")]
[JsonObject]
public class VirtualControlsSlotTypeMapping_Layout
{
	[Cpp2IlInjected.Token(Token = "0x20007EA")]
	public enum SlotType
	{
		[Cpp2IlInjected.Token(Token = "0x4007C90")]
		Axis,
		[Cpp2IlInjected.Token(Token = "0x4007C91")]
		Button
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001384")]
	[JsonProperty]
	public string ControlTypeId;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001385")]
	[JsonProperty]
	public SlotType ControlType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001386")]
	private VirtualControlsButtonConfiguration_Layout _buttonMapping;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001387")]
	private VirtualControlsAxisConfiguration_Layout _axisMapping;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001388")]
	private string _lastControlTypeId;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public VirtualControlsButtonConfiguration_Layout ButtonConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0xE8DAF8", Offset = "0xE8DAF8", VA = "0xE8DAF8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public VirtualControlsAxisConfiguration_Layout AxisConfiguration
	{
		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0xE8DC48", Offset = "0xE8DC48", VA = "0xE8DC48")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3C")]
	[Cpp2IlInjected.Address(RVA = "0xE8CDC0", Offset = "0xE8CDC0", VA = "0xE8CDC0")]
	public VirtualControlsSlotTypeMapping_Layout()
	{
	}
}
