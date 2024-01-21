using System;
using Cpp2IlInjected;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x20001B7")]
public class VirtualControlsBinding_Layout
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001367")]
	public string SlotId;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001368")]
	public VirtualControlsHardwareConfigurationMapping_Layout.ContolType Action;

	[Cpp2IlInjected.Token(Token = "0x6000C2A")]
	[Cpp2IlInjected.Address(RVA = "0xE8CCC0", Offset = "0xE8CCC0", VA = "0xE8CCC0")]
	public VirtualControlsBinding_Layout()
	{
	}
}
