using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime
{
	// Token: 0x02000298 RID: 664
	[global::Cpp2ILInjected.Token(Token = "0x2000336")]
	internal static class RuntimeImports
	{
		// Token: 0x06001987 RID: 6535 RVA: 0x00018CC5 File Offset: 0x00016EC5
		[global::Cpp2ILInjected.Token(Token = "0x6001BAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24980", Offset = "0x1B24980", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "ClearWithoutReferences", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static void RhZeroMemory(ref byte b, ulong byteLength)
		{
			throw null;
		}

		// Token: 0x06001988 RID: 6536
		[global::Cpp2ILInjected.Token(Token = "0x6001BAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24984", Offset = "0x1B24984", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern void ZeroMemory(void* p, uint byteLength);

		// Token: 0x06001989 RID: 6537
		[global::Cpp2ILInjected.Token(Token = "0x6001BAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B24988", Offset = "0x1B24988", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal unsafe static extern void Memmove(byte* dest, byte* src, uint len);

		// Token: 0x0600198A RID: 6538
		[global::Cpp2ILInjected.Token(Token = "0x6001BAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B2498C", Offset = "0x1B2498C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal unsafe static extern void Memmove_wbarrier(byte* dest, byte* src, uint len, global::System.IntPtr type_handle);
	}
}
