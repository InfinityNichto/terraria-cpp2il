using System.Collections.Concurrent;
using System.Collections.Generic;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000039")]
public class MainThreadExecution
{
	[Cpp2IlInjected.Token(Token = "0x200077C")]
	public delegate void ExecutionSnippet(object data);

	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private static List<ManagedThread> ExcludedThreads;

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private static ConcurrentQueue<MainThreadExecution> _pendingRequests;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private object _lockObject;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private ExecutionSnippet _snippet;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private object _data;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private bool _completed;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x12E1888", Offset = "0x12E1888", VA = "0x12E1888")]
	public static void ExcludeThread(ManagedThread thread)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x12E191C", Offset = "0x12E191C", VA = "0x12E191C")]
	public static void ExecuteOnMainThread(ExecutionSnippet snippet, object data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x12E1C00", Offset = "0x12E1C00", VA = "0x12E1C00")]
	public static void ExecuteSnippetsOnly()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x12E1D48", Offset = "0x12E1D48", VA = "0x12E1D48")]
	public static void ExecuteSnippets()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x12E1AB4", Offset = "0x12E1AB4", VA = "0x12E1AB4")]
	public MainThreadExecution(ExecutionSnippet snippet, object data)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x12E1CB8", Offset = "0x12E1CB8", VA = "0x12E1CB8")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x12E1B38", Offset = "0x12E1B38", VA = "0x12E1B38")]
	public void WaitOnMainThreadComplete()
	{
	}
}
