using System;
using System.Net.Sockets;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Telepathy;
using UnityEngine;

// Token: 0x02000252 RID: 594
[global::Cpp2ILInjected.Token(Token = "0x200030F")]
public static class NetworkStreamExtensions
{
	// Token: 0x06001101 RID: 4353 RVA: 0x00024DE5 File Offset: 0x00022FE5
	[global::Cpp2ILInjected.Token(Token = "0x6001256")]
	[global::Cpp2ILInjected.Address(RVA = "0xA77908", Offset = "0xA77908", Length = "0x90")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetworkStreamExtensions), Member = "ReadExactly", MemberParameters = new object[]
	{
		typeof(NetworkStream),
		typeof(byte[]),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	public static int ReadSafely(this NetworkStream stream, byte[] buffer, int offset, int size)
	{
		throw null;
	}

	// Token: 0x06001102 RID: 4354 RVA: 0x00024DE8 File Offset: 0x00022FE8
	[global::Cpp2ILInjected.Token(Token = "0x6001257")]
	[global::Cpp2ILInjected.Address(RVA = "0xA77998", Offset = "0xA77998", Length = "0xC4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Common), Member = "ReadMessageBlocking", MemberParameters = new object[]
	{
		typeof(NetworkStream),
		typeof(int),
		typeof(ref byte[])
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetworkStreamExtensions), Member = "ReadSafely", MemberParameters = new object[]
	{
		typeof(NetworkStream),
		typeof(byte[]),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static bool ReadExactly(this NetworkStream stream, byte[] buffer, int amount)
	{
		throw null;
	}
}
