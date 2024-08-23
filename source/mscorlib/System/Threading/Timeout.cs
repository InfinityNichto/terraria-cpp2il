using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000174 RID: 372
	[global::Cpp2ILInjected.Token(Token = "0x20001C6")]
	public static class Timeout
	{
		// Token: 0x06000F96 RID: 3990 RVA: 0x00017117 File Offset: 0x00015317
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60010C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C943FC", Offset = "0x1C943FC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TimeSpan), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Timeout()
		{
			throw null;
		}

		// Token: 0x04000714 RID: 1812
		[global::Cpp2ILInjected.Token(Token = "0x4000914")]
		public static readonly global::System.TimeSpan InfiniteTimeSpan;
	}
}
