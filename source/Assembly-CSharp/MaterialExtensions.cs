using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000245 RID: 581
[global::Cpp2ILInjected.Token(Token = "0x20002FE")]
public static class MaterialExtensions
{
	// Token: 0x06001074 RID: 4212 RVA: 0x00024C3E File Offset: 0x00022E3E
	[global::Cpp2ILInjected.Token(Token = "0x60011C3")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6EB50", Offset = "0xA6EB50", Length = "0x9C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public static Material CloneMaterial(this Material material)
	{
		throw null;
	}
}
