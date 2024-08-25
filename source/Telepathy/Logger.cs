using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Telepathy
{
	[global::Cpp2ILInjected.Token(Token = "0x2000314")]
	public static class Logger
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600126C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA79DC4", Offset = "0xA79DC4", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		static Logger()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4002202")]
		public static Action<string> Log;

		[global::Cpp2ILInjected.Token(Token = "0x4002203")]
		public static Action<string> LogWarning;

		[global::Cpp2ILInjected.Token(Token = "0x4002204")]
		public static Action<string> LogError;
	}
}
