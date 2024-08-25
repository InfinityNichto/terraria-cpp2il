using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001DE")]
public class InventorySplitStack_Layout : PageControllerLayoutDefinition<InventorySplitStack_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C44")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CAC74", Offset = "0x9CAC74", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public InventorySplitStack_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001116")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout MainButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001117")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout SliderBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4001118")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Slider_Layout Slider;

	[global::Cpp2ILInjected.Token(Token = "0x4001119")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout ItemToSplit;

	[global::Cpp2ILInjected.Token(Token = "0x400111A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public String_Layout ItemToSplitCount;

	[global::Cpp2ILInjected.Token(Token = "0x400111B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout SplitButton;

	[global::Cpp2ILInjected.Token(Token = "0x400111C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public String_Layout SplitCount;

	[global::Cpp2ILInjected.Token(Token = "0x400111D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TransactionButton_Layout ControllerMainButton;

	[global::Cpp2ILInjected.Token(Token = "0x400111E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public Panel_Layout ControllerSliderBacking;

	[global::Cpp2ILInjected.Token(Token = "0x400111F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Slider_Layout ControllerSlider;

	[global::Cpp2ILInjected.Token(Token = "0x4001120")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public TransactionButton_Layout ControllerItemToSplit;

	[global::Cpp2ILInjected.Token(Token = "0x4001121")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public String_Layout ControllerItemToSplitCount;

	[global::Cpp2ILInjected.Token(Token = "0x4001122")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public TransactionButton_Layout ControllerSplitButton;

	[global::Cpp2ILInjected.Token(Token = "0x4001123")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public String_Layout ControllerSplitCount;
}
