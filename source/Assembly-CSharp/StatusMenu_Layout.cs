using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000192 RID: 402
[global::Cpp2ILInjected.Token(Token = "0x200021E")]
public class StatusMenu_Layout : LayoutDefinition
{
	// Token: 0x06000BBA RID: 3002 RVA: 0x00023E73 File Offset: 0x00022073
	[global::Cpp2ILInjected.Token(Token = "0x6000CD0")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0514", Offset = "0x9D0514", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x00023E76 File Offset: 0x00022076
	[global::Cpp2ILInjected.Token(Token = "0x6000CD1")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D0560", Offset = "0x9D0560", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public StatusMenu_Layout()
	{
		throw null;
	}

	// Token: 0x04001062 RID: 4194
	[global::Cpp2ILInjected.Token(Token = "0x40014C6")]
	public static StatusMenu_Layout Instance;

	// Token: 0x04001063 RID: 4195
	[global::Cpp2ILInjected.Token(Token = "0x40014C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public StringButton_Layout Status;

	// Token: 0x04001064 RID: 4196
	[global::Cpp2ILInjected.Token(Token = "0x40014C8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout GameTip;
}
