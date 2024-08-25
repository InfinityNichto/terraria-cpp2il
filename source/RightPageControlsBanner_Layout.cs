using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000237")]
public class RightPageControlsBanner_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000D0A")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1FD8", Offset = "0x9D1FD8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000D0B")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D2024", Offset = "0x9D2024", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public RightPageControlsBanner_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001740")]
	public static RightPageControlsBanner_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x4001741")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public bool RedirectToMainControlsBanner;

	[global::Cpp2ILInjected.Token(Token = "0x4001742")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public ItemGrid_Layout Actions;

	[global::Cpp2ILInjected.Token(Token = "0x4001743")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout ActionStyle;

	[global::Cpp2ILInjected.Token(Token = "0x4001744")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public TransactionButton_Layout ActionStyleMultiple;
}
