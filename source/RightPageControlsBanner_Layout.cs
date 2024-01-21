using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20001A9")]
public class RightPageControlsBanner_Layout : LayoutDefinition
{
	[Cpp2IlInjected.Token(Token = "0x4001294")]
	public static RightPageControlsBanner_Layout Instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001295")]
	public bool RedirectToMainControlsBanner;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001296")]
	public ItemGrid_Layout Actions;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001297")]
	public TransactionButton_Layout ActionStyle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001298")]
	public TransactionButton_Layout ActionStyleMultiple;

	[Cpp2IlInjected.Token(Token = "0x6000C03")]
	[Cpp2IlInjected.Address(RVA = "0xF99958", Offset = "0xF99958", VA = "0xF99958")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000C04")]
	[Cpp2IlInjected.Address(RVA = "0xF999B4", Offset = "0xF999B4", VA = "0xF999B4")]
	public RightPageControlsBanner_Layout()
	{
	}
}
