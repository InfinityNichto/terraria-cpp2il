using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[global::Cpp2ILInjected.Token(Token = "0x20002FB")]
public static class AnimatorExtensions
{
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
