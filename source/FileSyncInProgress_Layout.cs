using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20001F8")]
public class FileSyncInProgress_Layout : LayoutDefinition
{
	[global::Cpp2ILInjected.Token(Token = "0x6000C90")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEE28", Offset = "0x9CEE28", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000C91")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CEE74", Offset = "0x9CEE74", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public FileSyncInProgress_Layout()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x400124D")]
	public static FileSyncInProgress_Layout Instance;

	[global::Cpp2ILInjected.Token(Token = "0x400124E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public Panel_Layout Greyout;

	[global::Cpp2ILInjected.Token(Token = "0x400124F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public Panel_Layout Backing;

	[global::Cpp2ILInjected.Token(Token = "0x4001250")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public StringButton_Layout Status;

	[global::Cpp2ILInjected.Token(Token = "0x4001251")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Button_Layout SearchingIcon;
}
