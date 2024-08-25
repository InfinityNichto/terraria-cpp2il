using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200019F")]
public class ControllerHardwareProfile_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B6A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC9B8", Offset = "0x9AC9B8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B6B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9ACA04", Offset = "0x9ACA04", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ControllerHardwareProfile_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000D16")]
	public static ControllerHardwareProfile_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000D17")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Title;

	[global::Cpp2ILInjected.Token(Token = "0x4000D18")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000D19")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public DraggableItemGrid_Layout OptionGrid;

	[global::Cpp2ILInjected.Token(Token = "0x4000D1A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout Close;

	[global::Cpp2ILInjected.Token(Token = "0x4000D1B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public TransactionButton_Layout ResetSettings;

	[global::Cpp2ILInjected.Token(Token = "0x4000D1C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TransactionButton_Layout Clear;

	[global::Cpp2ILInjected.Token(Token = "0x4000D1D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout EditMapping;

	[global::Cpp2ILInjected.Token(Token = "0x4000D1E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public ControllerProfileMappingEntry_Layout PulldownTemplate;
}
