using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x2000064")]
public class StackTraceSnapshot : MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x6000214")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B378", Offset = "0x70B378", Length = "0x5C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StackTraceUtility), Member = "ExtractStackTrace", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void UpdateStackTrace()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000215")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B3D4", Offset = "0x70B3D4", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	public StackTraceSnapshot()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x40001F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public string StackTrace;
}
