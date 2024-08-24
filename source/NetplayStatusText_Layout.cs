using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200019A RID: 410
[global::Cpp2ILInjected.Token(Token = "0x2000228")]
public class NetplayStatusText_Layout : LayoutDefinition
{
	// Token: 0x06000BCD RID: 3021 RVA: 0x00023EAC File Offset: 0x000220AC
	[global::Cpp2ILInjected.Token(Token = "0x6000CE6")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1038", Offset = "0x9D1038", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x00023EAF File Offset: 0x000220AF
	[global::Cpp2ILInjected.Token(Token = "0x6000CE7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9D1084", Offset = "0x9D1084", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public NetplayStatusText_Layout()
	{
		throw null;
	}

	// Token: 0x04001127 RID: 4391
	[global::Cpp2ILInjected.Token(Token = "0x40015C1")]
	public static NetplayStatusText_Layout Instance;

	// Token: 0x04001128 RID: 4392
	[global::Cpp2ILInjected.Token(Token = "0x40015C2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public String_Layout StatusText;

	// Token: 0x04001129 RID: 4393
	[global::Cpp2ILInjected.Token(Token = "0x40015C3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public string TestString;
}
