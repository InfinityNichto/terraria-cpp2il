using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Telepathy
{
	// Token: 0x02000256 RID: 598
	[global::Cpp2ILInjected.Token(Token = "0x2000314")]
	public static class Logger
	{
		// Token: 0x06001115 RID: 4373 RVA: 0x00024E21 File Offset: 0x00023021
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

		// Token: 0x04001C32 RID: 7218
		[global::Cpp2ILInjected.Token(Token = "0x4002202")]
		public static Action<string> Log;

		// Token: 0x04001C33 RID: 7219
		[global::Cpp2ILInjected.Token(Token = "0x4002203")]
		public static Action<string> LogWarning;

		// Token: 0x04001C34 RID: 7220
		[global::Cpp2ILInjected.Token(Token = "0x4002204")]
		public static Action<string> LogError;
	}
}
