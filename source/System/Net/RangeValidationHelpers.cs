using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000CB RID: 203
	[global::Cpp2ILInjected.Token(Token = "0x200012D")]
	internal static class RangeValidationHelpers
	{
		// Token: 0x0600067B RID: 1659 RVA: 0x000040C4 File Offset: 0x000022C4
		[global::Cpp2ILInjected.Token(Token = "0x600072B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE5158", Offset = "0x1EE5158", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool ValidateRange(int actual, int fromAllowed, int toAllowed)
		{
			throw null;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x000040C7 File Offset: 0x000022C7
		[global::Cpp2ILInjected.Token(Token = "0x600072C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE5170", Offset = "0x1EE5170", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void ValidateSegment(ArraySegment<byte> segment)
		{
			throw null;
		}
	}
}
