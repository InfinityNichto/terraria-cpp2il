using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000123")]
public class ChestSplitStack_Layout : PageControllerLayoutDefinition<ChestSplitStack_Layout>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40009AD")]
	public TransactionButton_Layout MainButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40009AE")]
	public Panel_Layout SliderBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40009AF")]
	public Slider_Layout Slider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40009B0")]
	public bool SliderConsoleRightDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40009B1")]
	public TransactionButton_Layout ItemToSplit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40009B2")]
	public String_Layout ItemToSplitCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40009B3")]
	public TransactionButton_Layout SplitButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40009B4")]
	public String_Layout SplitCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40009B5")]
	public TransactionButton_Layout ControllerMainButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40009B6")]
	public Panel_Layout ControllerSliderBacking;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40009B7")]
	public Slider_Layout ControllerSlider;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40009B8")]
	public TransactionButton_Layout ControllerItemToSplit;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40009B9")]
	public String_Layout ControllerItemToSplitCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40009BA")]
	public TransactionButton_Layout ControllerSplitButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40009BB")]
	public String_Layout ControllerSplitCount;

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0x1205090", Offset = "0x1205090", VA = "0x1205090")]
	public ChestSplitStack_Layout()
	{
	}
}
