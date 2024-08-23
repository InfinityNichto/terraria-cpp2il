using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x020001A2 RID: 418
[global::Cpp2ILInjected.Token(Token = "0x2000231")]
public class PurchaseChecker_Layout : LayoutDefinition
{
	// Token: 0x06000BE0 RID: 3040 RVA: 0x00023EE5 File Offset: 0x000220E5
	[global::Cpp2ILInjected.Token(Token = "0x6000CFA")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D15B8", Offset = "0x9D15B8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BE1 RID: 3041 RVA: 0x00023EE8 File Offset: 0x000220E8
	[global::Cpp2ILInjected.Token(Token = "0x6000CFB")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1604", Offset = "0x9D1604", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PurchaseChecker_Layout()
	{
		throw null;
	}

	// Token: 0x040011E2 RID: 4578
	[global::Cpp2ILInjected.Token(Token = "0x4001697")]
	public static PurchaseChecker_Layout Instance;

	// Token: 0x040011E3 RID: 4579
	[global::Cpp2ILInjected.Token(Token = "0x4001698")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public String_Layout Information;

	// Token: 0x040011E4 RID: 4580
	[global::Cpp2ILInjected.Token(Token = "0x4001699")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public TransactionButton_Layout Retry;

	// Token: 0x040011E5 RID: 4581
	[global::Cpp2ILInjected.Token(Token = "0x400169A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public TransactionButton_Layout Store;

	// Token: 0x040011E6 RID: 4582
	[global::Cpp2ILInjected.Token(Token = "0x400169B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Button_Layout SearchingIcon;
}
