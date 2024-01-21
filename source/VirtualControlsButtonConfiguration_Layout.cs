using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x20001B8")]
[JsonObject]
public class VirtualControlsButtonConfiguration_Layout
{
	[Cpp2IlInjected.Token(Token = "0x20007E8")]
	public enum Style
	{
		[Cpp2IlInjected.Token(Token = "0x4007C71")]
		Blue,
		[Cpp2IlInjected.Token(Token = "0x4007C72")]
		Green,
		[Cpp2IlInjected.Token(Token = "0x4007C73")]
		Teal,
		[Cpp2IlInjected.Token(Token = "0x4007C74")]
		Bad
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001369")]
	public string Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400136A")]
	public QuickActionButton_Layout BlueLayout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400136B")]
	public QuickActionButton_Layout GreenLayout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400136C")]
	public QuickActionButton_Layout TealLayout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400136D")]
	public QuickActionButton_Layout BadPositionLayout;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400136E")]
	public QuickActionButton_Layout ControlLayout;

	[Cpp2IlInjected.Token(Token = "0x6000C2B")]
	[Cpp2IlInjected.Address(RVA = "0xE8CCC8", Offset = "0xE8CCC8", VA = "0xE8CCC8")]
	public void Validate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2C")]
	[Cpp2IlInjected.Address(RVA = "0xE8CCCC", Offset = "0xE8CCCC", VA = "0xE8CCCC")]
	public QuickActionButton_Layout GetStyle(Style stlyeIndex)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C2D")]
	[Cpp2IlInjected.Address(RVA = "0xE8CD00", Offset = "0xE8CD00", VA = "0xE8CD00")]
	public VirtualControlsButtonConfiguration_Layout()
	{
	}
}
