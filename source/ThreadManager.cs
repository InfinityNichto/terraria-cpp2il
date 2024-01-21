using System.Collections.Generic;
using System.Threading;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class ThreadManager
{
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static object LockObject;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static Dictionary<ManagedThread, LocalUser> ThreadUser;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static List<ManagedThread> ActiveThreads;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static List<ManagedThread> ThreadsToShutdown;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x10CD3C4", Offset = "0x10CD3C4", VA = "0x10CD3C4")]
	public static ManagedThread Run(ParameterizedThreadStart callBack, object state)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x10CD494", Offset = "0x10CD494", VA = "0x10CD494")]
	public static ManagedThread Run(ThreadStart callBack)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x10CD55C", Offset = "0x10CD55C", VA = "0x10CD55C")]
	public static ManagedThread RunForUser(ParameterizedThreadStart callBack, object state, LocalUser user)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x10CD65C", Offset = "0x10CD65C", VA = "0x10CD65C")]
	public static ManagedThread RunForUser(ThreadStart callBack, LocalUser user)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x10CD754", Offset = "0x10CD754", VA = "0x10CD754")]
	public static ManagedThread RunForUserCritical(ParameterizedThreadStart callBack, object state, LocalUser user)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x10CD854", Offset = "0x10CD854", VA = "0x10CD854")]
	public static ManagedThread RunCritical(ThreadStart callBack)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x10CD91C", Offset = "0x10CD91C", VA = "0x10CD91C")]
	public static void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x10CDBA8", Offset = "0x10CDBA8", VA = "0x10CDBA8")]
	public static void TerminateUserThreads(LocalUser user)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x10CDE4C", Offset = "0x10CDE4C", VA = "0x10CDE4C")]
	public static void TerminateThread(ManagedThread thread)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x10CE02C", Offset = "0x10CE02C", VA = "0x10CE02C")]
	public static void TerminateThreadAndWait(ManagedThread thread)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x10CE258", Offset = "0x10CE258", VA = "0x10CE258")]
	public static void TerminateAll()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x10CE67C", Offset = "0x10CE67C", VA = "0x10CE67C")]
	public static bool IsThreadRunning(ManagedThread thread)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x10CE694", Offset = "0x10CE694", VA = "0x10CE694")]
	public static void CheckThreadTerminiate()
	{
	}
}
