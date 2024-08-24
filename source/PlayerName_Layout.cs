using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000181 RID: 385
[global::Cpp2ILInjected.Token(Token = "0x200020B")]
public class PlayerName_Layout : LayoutDefinition
{
	// Token: 0x06000B9F RID: 2975 RVA: 0x00023E22 File Offset: 0x00022022
	[global::Cpp2ILInjected.Token(Token = "0x6000CB4")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFA38", Offset = "0x9CFA38", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000BA0 RID: 2976 RVA: 0x00023E25 File Offset: 0x00022025
	[global::Cpp2ILInjected.Token(Token = "0x6000CB5")]
	[global::Cpp2ILInjected.Address(RVA = "0x9CFA84", Offset = "0x9CFA84", Length = "0x58")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public PlayerName_Layout()
	{
		throw null;
	}

	// Token: 0x04000F18 RID: 3864
	[global::Cpp2ILInjected.Token(Token = "0x4001365")]
	public static PlayerName_Layout Instance;

	// Token: 0x04000F19 RID: 3865
	[global::Cpp2ILInjected.Token(Token = "0x4001366")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public String_Layout Title;

	// Token: 0x04000F1A RID: 3866
	[global::Cpp2ILInjected.Token(Token = "0x4001367")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public String_Layout InputCharacterName;
}
