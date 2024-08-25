using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001D6")]
public class HatRack_Layout : PageControllerLayoutDefinition<HatRack_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C0F")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B6A3C", Offset = "0x9B6A3C", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public HatRack_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40010E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x40010E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float HatScale;

	[global::Cpp2ILInjected.Token(Token = "0x40010E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float HatHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x40010E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout HatDye;

	[global::Cpp2ILInjected.Token(Token = "0x40010E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout Hat;

	[global::Cpp2ILInjected.Token(Token = "0x40010E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout RemoveButton;
}
