using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001EF")]
public class LeftPageControlsBanner_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C75")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE478", Offset = "0x9CE478", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C76")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CE4C4", Offset = "0x9CE4C4", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public LeftPageControlsBanner_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40011FD")]
	public static LeftPageControlsBanner_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x40011FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool RedirectToMainControlsBanner;

	[global::Cpp2ILInjected.Token(Token = "0x40011FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout Actions;

	[global::Cpp2ILInjected.Token(Token = "0x4001200")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout ActionStyle;

	[global::Cpp2ILInjected.Token(Token = "0x4001201")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout ActionStyleMultiple;
}
