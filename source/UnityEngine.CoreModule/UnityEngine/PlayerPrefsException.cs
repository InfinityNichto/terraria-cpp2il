using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x02000030 RID: 48
	[global::Cpp2ILInjected.Token(Token = "0x2000033")]
	public class PlayerPrefsException : Exception
	{
		// Token: 0x0600002D RID: 45 RVA: 0x000020C2 File Offset: 0x000002C2
		[global::Cpp2ILInjected.Token(Token = "0x6000035")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6A4AC", Offset = "0x1F6A4AC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerPrefs), Member = "SetInt", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerPrefs), Member = "SetFloat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerPrefs), Member = "SetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PlayerPrefsException(string error)
		{
			throw null;
		}
	}
}
