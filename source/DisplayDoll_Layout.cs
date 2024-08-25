using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001D1")]
public class DisplayDoll_Layout : PageControllerLayoutDefinition<DisplayDoll_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C00")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B5E94", Offset = "0x9B5E94", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public DisplayDoll_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400104B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x400104C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float AmourScale;

	[global::Cpp2ILInjected.Token(Token = "0x400104D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float ArmourHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x400104E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public ItemGrid_Layout ArmourDye;

	[global::Cpp2ILInjected.Token(Token = "0x400104F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public ItemGrid_Layout Armor;

	[global::Cpp2ILInjected.Token(Token = "0x4001050")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float AccessoryScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001051")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public float AccessoryHighlightScale;

	[global::Cpp2ILInjected.Token(Token = "0x4001052")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public ItemGrid_Layout AccessoryDye;

	[global::Cpp2ILInjected.Token(Token = "0x4001053")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public ItemGrid_Layout Accessory;

	[global::Cpp2ILInjected.Token(Token = "0x4001054")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout RemoveButton;
}
