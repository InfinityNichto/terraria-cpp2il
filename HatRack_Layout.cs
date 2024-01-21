using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000152")]
public class HatRack_Layout : PageControllerLayoutDefinition<HatRack_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000CEA")]
	public String_Layout Title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000CEB")]
	public float HatScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000CEC")]
	public float HatHighlightScale;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000CED")]
	public ItemGrid_Layout HatDye;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000CEE")]
	public ItemGrid_Layout Hat;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000CEF")]
	public TransactionButton_Layout RemoveButton;

	[Cpp2IlInjected.Token(Token = "0x6000B0E")]
	[Cpp2IlInjected.Address(RVA = "0x116ED88", Offset = "0x116ED88", VA = "0x116ED88")]
	public HatRack_Layout()
	{
	}
}
