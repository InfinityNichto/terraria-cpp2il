using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Text
{
	[global::Cpp2ILInjected.Token(Token = "0x2000B17")]
	internal static class StringBuilderExtension
	{
		[global::Cpp2ILInjected.Token(Token = "0x6005320")]
		[global::Cpp2ILInjected.Address(RVA = "0x940FE0", Offset = "0x940FE0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		internal static bool IsEmpty(this StringBuilder stringBuilder)
		{
			throw null;
		}
	}
}
