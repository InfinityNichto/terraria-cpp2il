using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200019E")]
	internal static class IntPtrHelper
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0E29C", Offset = "0x1F0E29C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(IntPtr))]
		internal static IntPtr Add(IntPtr a, int b)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0E2BC", Offset = "0x1F0E2BC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(long))]
		internal static long Subtract(IntPtr a, IntPtr b)
		{
			throw null;
		}
	}
}
