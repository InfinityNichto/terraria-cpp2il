using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x200019E")]
public class ControllerDisconnected_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000B68")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC914", Offset = "0x9AC914", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000B69")]
	[global::Cpp2ILInjected.Address(RVA = "0x9AC960", Offset = "0x9AC960", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public ControllerDisconnected_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000D0D")]
	public static ControllerDisconnected_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4000D0E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Greyout;

	[global::Cpp2ILInjected.Token(Token = "0x4000D0F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4000D10")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Status;

	[global::Cpp2ILInjected.Token(Token = "0x4000D11")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Button_Layout SearchingIcon;

	[global::Cpp2ILInjected.Token(Token = "0x4000D12")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Panel_Layout SwitchBacking;

	[global::Cpp2ILInjected.Token(Token = "0x4000D13")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public String_Layout SwitchStatus;

	[global::Cpp2ILInjected.Token(Token = "0x4000D14")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public TransactionButton_Layout SwitchConfigure;

	[global::Cpp2ILInjected.Token(Token = "0x4000D15")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public Button_Layout SwitchSearchingIcon;
}
