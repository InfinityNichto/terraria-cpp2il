using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001EB")]
	internal class HeaderInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F24678", Offset = "0x1F24678", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal HeaderInfo(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000A76")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal readonly bool IsRequestRestricted;

		[global::Cpp2ILInjected.Token(Token = "0x4000A77")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
		internal readonly bool IsResponseRestricted;

		[global::Cpp2ILInjected.Token(Token = "0x4000A78")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal readonly HeaderParser Parser;

		[global::Cpp2ILInjected.Token(Token = "0x4000A79")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal readonly string HeaderName;

		[global::Cpp2ILInjected.Token(Token = "0x4000A7A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal readonly bool AllowMultiValues;
	}
}
