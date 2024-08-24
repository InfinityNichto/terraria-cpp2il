﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

// Token: 0x02000242 RID: 578
[global::Cpp2ILInjected.Token(Token = "0x20002FB")]
public static class AnimatorExtensions
{
	// Token: 0x06001066 RID: 4198 RVA: 0x00024C14 File Offset: 0x00022E14
	[global::Cpp2ILInjected.Token(Token = "0x60011B5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E2F4", Offset = "0xA6E2F4", Length = "0x80")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Animator), Member = "get_parameterCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Animator), Member = "get_parameters", ReturnType = typeof(AnimatorControllerParameter[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimatorControllerParameter), Member = "get_name", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(string),
		typeof(string)
	}, ReturnType = typeof(bool))]
	public static bool HasParameter(this Animator animator, string parameterName)
	{
		throw null;
	}

	// Token: 0x06001067 RID: 4199 RVA: 0x00024C17 File Offset: 0x00022E17
	[global::Cpp2ILInjected.Token(Token = "0x60011B6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E374", Offset = "0xA6E374", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Animator), Member = "get_parameterCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Animator), Member = "get_parameters", ReturnType = typeof(AnimatorControllerParameter[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimatorControllerParameter), Member = "get_nameHash", ReturnType = typeof(int))]
	public static bool HasParameter(this Animator animator, int parameterNameHash)
	{
		throw null;
	}

	// Token: 0x06001068 RID: 4200 RVA: 0x00024C1A File Offset: 0x00022E1A
	[global::Cpp2ILInjected.Token(Token = "0x60011B7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA6E3EC", Offset = "0xA6E3EC", Length = "0xC8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Animator), Member = "get_parameterCount", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Animator), Member = "get_parameters", ReturnType = typeof(AnimatorControllerParameter[]))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AnimatorControllerParameter), Member = "get_nameHash", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
	{
		typeof(int[]),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static void GetParameters(this Animator animator, int[] parameterNameHashTable, bool[] hasAnimatorValue)
	{
		throw null;
	}
}