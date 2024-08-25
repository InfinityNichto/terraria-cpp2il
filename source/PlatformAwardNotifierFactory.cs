using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x20002AC")]
public static class PlatformAwardNotifierFactory
{
	[global::Cpp2ILInjected.Token(Token = "0x6000FC6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA39CC8", Offset = "0xA39CC8", Length = "0x54")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public static IPlatformAwardNotifier CreateForActivePlatform()
	{
		throw null;
	}
}
