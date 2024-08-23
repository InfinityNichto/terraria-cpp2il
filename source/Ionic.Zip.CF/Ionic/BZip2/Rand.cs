using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.BZip2
{
	// Token: 0x02000032 RID: 50
	[global::Cpp2ILInjected.Token(Token = "0x200003D")]
	internal static class Rand
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x00005755 File Offset: 0x00003955
		[global::Cpp2ILInjected.Token(Token = "0x600030B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6336C", Offset = "0x1A6336C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "randomiseBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupRandPartA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupRandPartB", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static int Rnums(int i)
		{
			throw null;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00005758 File Offset: 0x00003958
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600030C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6897C", Offset = "0x1A6897C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static Rand()
		{
			throw null;
		}

		// Token: 0x04000186 RID: 390
		[global::Cpp2ILInjected.Token(Token = "0x40001D2")]
		private static int[] RNUMS;
	}
}
