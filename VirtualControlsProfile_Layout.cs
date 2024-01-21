using System;
using Cpp2IlInjected;
using Newtonsoft.Json;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x20001BB")]
[JsonObject]
public class VirtualControlsProfile_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400137F")]
	[JsonProperty]
	public string Id;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001380")]
	[JsonProperty]
	public string EditedName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001381")]
	[JsonProperty]
	public string Hardware;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001382")]
	private VirtualControlsHardwareConfiguration_Layout _cachedHardware;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001383")]
	[JsonProperty]
	public VirtualControlsBinding_Layout[] Controls;

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	public VirtualControlsHardwareConfiguration_Layout HardwareConfig
	{
		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0xE8D83C", Offset = "0xE8D83C", VA = "0xE8D83C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000C36")]
	[Cpp2IlInjected.Address(RVA = "0xE8D65C", Offset = "0xE8D65C", VA = "0xE8D65C")]
	public bool HasProfileMapping()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C37")]
	[Cpp2IlInjected.Address(RVA = "0xE8D69C", Offset = "0xE8D69C", VA = "0xE8D69C")]
	public string GetDisplayName(float maxWidth = 800f)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000C39")]
	[Cpp2IlInjected.Address(RVA = "0xE8D940", Offset = "0xE8D940", VA = "0xE8D940")]
	public void Copy(VirtualControlsProfile_Layout other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3A")]
	[Cpp2IlInjected.Address(RVA = "0xE8DA60", Offset = "0xE8DA60", VA = "0xE8DA60")]
	public bool IsSame(VirtualControlsProfile_Layout other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000C3B")]
	[Cpp2IlInjected.Address(RVA = "0xE8DAF0", Offset = "0xE8DAF0", VA = "0xE8DAF0")]
	public VirtualControlsProfile_Layout()
	{
	}
}
