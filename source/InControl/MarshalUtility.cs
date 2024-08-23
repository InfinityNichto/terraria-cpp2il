using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000057 RID: 87
	[global::Cpp2ILInjected.Token(Token = "0x2000062")]
	public static class MarshalUtility
	{
		// Token: 0x06000452 RID: 1106 RVA: 0x00002D23 File Offset: 0x00000F23
		[global::Cpp2ILInjected.Token(Token = "0x6000466")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B58E0", Offset = "0x19B58E0", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "ArrayExpand", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]&",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(int[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void Copy(IntPtr source, uint[] destination, int length)
		{
			throw null;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00002D26 File Offset: 0x00000F26
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000467")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B59FC", Offset = "0x19B59FC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static MarshalUtility()
		{
			throw null;
		}

		// Token: 0x04000393 RID: 915
		[global::Cpp2ILInjected.Token(Token = "0x40003E0")]
		private static int[] buffer;
	}
}
