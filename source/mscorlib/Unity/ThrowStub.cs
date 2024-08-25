using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Unity
{
	[global::Cpp2ILInjected.Token(Token = "0x20006A8")]
	internal sealed class ThrowStub : global::System.ObjectDisposedException
	{
		[global::Cpp2ILInjected.Token(Token = "0x60031ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C15B2C", Offset = "0x1C15B2C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void ThrowNotSupportedException()
		{
			throw null;
		}
	}
}
