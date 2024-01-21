using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000244")]
public static class AnimatorExtensions
{
	[Cpp2IlInjected.Token(Token = "0x600107F")]
	[Cpp2IlInjected.Address(RVA = "0x11FF71C", Offset = "0x11FF71C", VA = "0x11FF71C")]
	public static bool HasParameter(this Animator animator, string parameterName)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001080")]
	[Cpp2IlInjected.Address(RVA = "0x11FF7A0", Offset = "0x11FF7A0", VA = "0x11FF7A0")]
	public static bool HasParameter(this Animator animator, int parameterNameHash)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001081")]
	[Cpp2IlInjected.Address(RVA = "0x11FF818", Offset = "0x11FF818", VA = "0x11FF818")]
	public static void GetParameters(this Animator animator, int[] parameterNameHashTable, bool[] hasAnimatorValue)
	{
	}
}
