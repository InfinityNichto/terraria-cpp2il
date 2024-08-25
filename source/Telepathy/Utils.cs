using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Telepathy
{
	[global::Cpp2ILInjected.Token(Token = "0x200031B")]
	public static class Utils
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001284")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7B7A8", Offset = "0xA7B7A8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] IntToBytesBigEndian(int value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001285")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7B7FC", Offset = "0xA7B7FC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void IntToBytesBigEndianNonAlloc(int value, byte[] bytes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001286")]
		[global::Cpp2ILInjected.Address(RVA = "0xA7B808", Offset = "0xA7B808", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int BytesToIntBigEndian(byte[] bytes)
		{
			throw null;
		}
	}
}
