using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

[global::Cpp2ILInjected.Token(Token = "0x2000060")]
internal class SingletonCleanup
{
	[global::Cpp2ILInjected.Token(Token = "0x14000005")]
	public static event SingletonCleanup.CleanupSingletonCallback CleanUpEvent
	{
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000200")]
		[global::Cpp2ILInjected.Address(RVA = "0x70B038", Offset = "0x70B038", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Singleton<>), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6000201")]
		[global::Cpp2ILInjected.Address(RVA = "0x70B0F0", Offset = "0x70B0F0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Singleton<>), Member = "Destroy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		remove
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000202")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B1A8", Offset = "0x70B1A8", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static void Cleanup()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000203")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B210", Offset = "0x70B210", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SingletonCleanup()
	{
		throw null;
	}

	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x40001F5")]
	private static SingletonCleanup.CleanupSingletonCallback CleanUpEvent;

	[global::Cpp2ILInjected.Token(Token = "0x2000061")]
	public delegate void CleanupSingletonCallback();
}
