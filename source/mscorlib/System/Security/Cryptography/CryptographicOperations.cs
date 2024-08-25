using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	[global::Cpp2ILInjected.Token(Token = "0x20002BC")]
	public static class CryptographicOperations
	{
		[global::Cpp2ILInjected.Token(Token = "0x60017AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF6930", Offset = "0x1AF6930", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		[MethodImpl(72)]
		public static bool FixedTimeEquals(global::System.ReadOnlySpan<byte> left, global::System.ReadOnlySpan<byte> right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60017B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF6B50", Offset = "0x1AF6B50", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<ReadAsyncCore>d__42", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(72)]
		public static void ZeroMemory(global::System.Span<byte> buffer)
		{
			throw null;
		}
	}
}
