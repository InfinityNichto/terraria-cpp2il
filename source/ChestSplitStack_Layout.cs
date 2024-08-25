using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200019A")]
public class ChestSplitStack_Layout : PageControllerLayoutDefinition<ChestSplitStack_Layout>
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B62")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC4BC", Offset = "0x9AC4BC", Length = "0x48")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PageControllerLayoutDefinition<>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public ChestSplitStack_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000CC6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout MainButton;

	[global::Cpp2ILInjected.Token(Token = "0x4000CC7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Panel_Layout SliderBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000CC8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Slider_Layout Slider;

	[global::Cpp2ILInjected.Token(Token = "0x4000CC9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public bool SliderConsoleRightDirection;

	[global::Cpp2ILInjected.Token(Token = "0x4000CCA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout ItemToSplit;

	[global::Cpp2ILInjected.Token(Token = "0x4000CCB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public String_Layout ItemToSplitCount;

	[global::Cpp2ILInjected.Token(Token = "0x4000CCC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public TransactionButton_Layout SplitButton;

	[global::Cpp2ILInjected.Token(Token = "0x4000CCD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public String_Layout SplitCount;

	[global::Cpp2ILInjected.Token(Token = "0x4000CCE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public TransactionButton_Layout ControllerMainButton;

	[global::Cpp2ILInjected.Token(Token = "0x4000CCF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public Panel_Layout ControllerSliderBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000CD0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public Slider_Layout ControllerSlider;

	[global::Cpp2ILInjected.Token(Token = "0x4000CD1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public TransactionButton_Layout ControllerItemToSplit;

	[global::Cpp2ILInjected.Token(Token = "0x4000CD2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public String_Layout ControllerItemToSplitCount;

	[global::Cpp2ILInjected.Token(Token = "0x4000CD3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public TransactionButton_Layout ControllerSplitButton;

	[global::Cpp2ILInjected.Token(Token = "0x4000CD4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public String_Layout ControllerSplitCount;
}
