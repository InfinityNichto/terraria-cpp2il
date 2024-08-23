using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x02000207 RID: 519
[global::Cpp2ILInjected.Token(Token = "0x20002AC")]
public static class PlatformAwardNotifierFactory
{
	// Token: 0x06000E96 RID: 3734 RVA: 0x000246F2 File Offset: 0x000228F2
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
