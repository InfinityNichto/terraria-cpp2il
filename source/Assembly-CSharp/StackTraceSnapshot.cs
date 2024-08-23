using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x0200003F RID: 63
[global::Cpp2ILInjected.Token(Token = "0x2000064")]
public class StackTraceSnapshot : MonoBehaviour
{
	// Token: 0x06000181 RID: 385 RVA: 0x00021FFB File Offset: 0x000201FB
	[global::Cpp2ILInjected.Token(Token = "0x6000214")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B378", Offset = "0x70B378", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackTraceUtility), Member = "ExtractStackTrace", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void UpdateStackTrace()
	{
		throw null;
	}

	// Token: 0x06000182 RID: 386 RVA: 0x00021FFE File Offset: 0x000201FE
	[global::Cpp2ILInjected.Token(Token = "0x6000215")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B3D4", Offset = "0x70B3D4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	public StackTraceSnapshot()
	{
		throw null;
	}

	// Token: 0x04000106 RID: 262
	[global::Cpp2ILInjected.Token(Token = "0x40001F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string StackTrace;
}
