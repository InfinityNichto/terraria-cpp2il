using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x20001B6")]
[JsonObject]
public class VirtualControlsAxisConfiguration_Layout
{
	[Cpp2IlInjected.Token(Token = "0x20007E7")]
	public enum Style
	{
		[Cpp2IlInjected.Token(Token = "0x4007C6D")]
		Blue,
		[Cpp2IlInjected.Token(Token = "0x4007C6E")]
		Green,
		[Cpp2IlInjected.Token(Token = "0x4007C6F")]
		BadPosition
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001362")]
	public string Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001363")]
	public Axis_Layout BlueLayout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001364")]
	public Axis_Layout GreenLayout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001365")]
	public Axis_Layout BadLayout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001366")]
	public Axis_Layout ControlLayout;

	[Cpp2IlInjected.Token(Token = "0x6000C27")]
	[Cpp2IlInjected.Address(RVA = "0xE8CC90", Offset = "0xE8CC90", VA = "0xE8CC90")]
	public void Validate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C28")]
	[Cpp2IlInjected.Address(RVA = "0xE8CC94", Offset = "0xE8CC94", VA = "0xE8CC94")]
	public Axis_Layout GetStyle(Style stlyeIndex)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C29")]
	[Cpp2IlInjected.Address(RVA = "0xE8CCB8", Offset = "0xE8CCB8", VA = "0xE8CCB8")]
	public VirtualControlsAxisConfiguration_Layout()
	{
	}
}
