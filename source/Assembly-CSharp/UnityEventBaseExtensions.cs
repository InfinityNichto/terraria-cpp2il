using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;

// Token: 0x02000248 RID: 584
[global::Cpp2ILInjected.Token(Token = "0x2000301")]
public static class UnityEventBaseExtensions
{
	// Token: 0x06001080 RID: 4224 RVA: 0x00024C62 File Offset: 0x00022E62
	[global::Cpp2ILInjected.Token(Token = "0x60011CF")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6EEE0", Offset = "0xA6EEE0", Length = "0x204")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(Type)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = "GetValidMethodInfo", MemberParameters = new object[]
	{
		typeof(object),
		typeof(string),
		typeof(Type[])
	}, ReturnType = typeof(MethodInfo))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
	public static MethodInfo FindMethod(this UnityEventBase eventBase, string name, object listener, PersistentListenerMode mode, Type argumentType)
	{
		throw null;
	}
}
