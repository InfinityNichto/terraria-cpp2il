using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x200013E")]
	public class HttpVersion
	{
		[global::Cpp2ILInjected.Token(Token = "0x600078E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE85A0", Offset = "0x1EE85A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public HttpVersion()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600078F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE85A8", Offset = "0x1EE85A8", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static HttpVersion()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000635")]
		public static readonly Version Unknown;

		[global::Cpp2ILInjected.Token(Token = "0x4000636")]
		public static readonly Version Version10;

		[global::Cpp2ILInjected.Token(Token = "0x4000637")]
		public static readonly Version Version11;

		[global::Cpp2ILInjected.Token(Token = "0x4000638")]
		public static readonly Version Version20;
	}
}
