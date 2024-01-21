using System.Threading;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000041")]
public class ManagedThread
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private ParameterizedThreadStart ParameterizedThreadStartCallBack;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private object ParameterizedThreadStartCallbackState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private ThreadStart ThreadStartCallBack;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public LocalUser User;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public Thread ActiveThread;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool IsAlive;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x12E2400", Offset = "0x12E2400", VA = "0x12E2400")]
	public ManagedThread(ParameterizedThreadStart callBack, object state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x12E24C0", Offset = "0x12E24C0", VA = "0x12E24C0")]
	public ManagedThread(ThreadStart callBack)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x12E2578", Offset = "0x12E2578", VA = "0x12E2578")]
	public void Run()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x12E25B0", Offset = "0x12E25B0", VA = "0x12E25B0")]
	public void RunCritical()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x12E25E8", Offset = "0x12E25E8", VA = "0x12E25E8")]
	private void ThreadExecute()
	{
	}
}
