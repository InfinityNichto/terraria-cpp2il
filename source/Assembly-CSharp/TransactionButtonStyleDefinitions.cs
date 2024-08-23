using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x0200013F RID: 319
[global::Cpp2ILInjected.Token(Token = "0x20001C0")]
public class TransactionButtonStyleDefinitions : LayoutDefinition
{
	// Token: 0x06000AC8 RID: 2760 RVA: 0x00023B9D File Offset: 0x00021D9D
	[global::Cpp2ILInjected.Token(Token = "0x6000BD7")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B3CC8", Offset = "0x9B3CC8", Length = "0x4C")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000AC9 RID: 2761 RVA: 0x00023BA0 File Offset: 0x00021DA0
	[global::Cpp2ILInjected.Token(Token = "0x6000BD8")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B3D14", Offset = "0x9B3D14", Length = "0x1D0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutDefinition), Member = "RefreshFields", MemberParameters = new object[]
	{
		typeof(Type),
		typeof(object),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "Find", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
	public static TransactionButtonStyle_Definition GetDefinition(string id)
	{
		throw null;
	}

	// Token: 0x06000ACA RID: 2762 RVA: 0x00023BA3 File Offset: 0x00021DA3
	[global::Cpp2ILInjected.Token(Token = "0x6000BD9")]
	[global::Cpp2ILInjected.Address(RVA = "0x9B3EE4", Offset = "0x9B3EE4", Length = "0xA0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutDefinition), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
	public TransactionButtonStyleDefinitions()
	{
		throw null;
	}

	// Token: 0x04000AFD RID: 2813
	[global::Cpp2ILInjected.Token(Token = "0x4000EED")]
	public static TransactionButtonStyleDefinitions Instance;

	// Token: 0x04000AFE RID: 2814
	[global::Cpp2ILInjected.Token(Token = "0x4000EEE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public List<TransactionButtonStyle_Definition> Definitions;
}
