using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200003C RID: 60
[global::Cpp2ILInjected.Token(Token = "0x2000060")]
internal class SingletonCleanup
{
	// Token: 0x14000002 RID: 2
	// (add) Token: 0x06000171 RID: 369 RVA: 0x00021FCB File Offset: 0x000201CB
	// (remove) Token: 0x06000172 RID: 370 RVA: 0x00021FCE File Offset: 0x000201CE
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

	// Token: 0x06000173 RID: 371 RVA: 0x00021FD1 File Offset: 0x000201D1
	[global::Cpp2ILInjected.Token(Token = "0x6000202")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B1A8", Offset = "0x70B1A8", Length = "0x68")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
	public static void Cleanup()
	{
		throw null;
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00021FD4 File Offset: 0x000201D4
	[global::Cpp2ILInjected.Token(Token = "0x6000203")]
	[global::Cpp2ILInjected.Address(RVA = "0x70B210", Offset = "0x70B210", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public SingletonCleanup()
	{
		throw null;
	}

	// Token: 0x04000102 RID: 258
	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x40001F5")]
	private static SingletonCleanup.CleanupSingletonCallback CleanUpEvent;

	// Token: 0x02000786 RID: 1926
	// (Invoke) Token: 0x06004863 RID: 18531
	[global::Cpp2ILInjected.Token(Token = "0x2000061")]
	public delegate void CleanupSingletonCallback();
}
