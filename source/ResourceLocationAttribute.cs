using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200003D RID: 61
[AttributeUsage(AttributeTargets.All)]
[global::Cpp2ILInjected.Token(Token = "0x2000062")]
public class ResourceLocationAttribute : Attribute
{
	// Token: 0x06000175 RID: 373 RVA: 0x00021FD7 File Offset: 0x000201D7
	[global::Cpp2ILInjected.Token(Token = "0x6000208")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B314", Offset = "0x70B314", Length = "0x64")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public ResourceLocationAttribute(string location)
	{
		throw null;
	}

	// Token: 0x04000103 RID: 259
	[global::Cpp2ILInjected.Token(Token = "0x40001F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public readonly string Location;
}
