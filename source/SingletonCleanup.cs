using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200003D")]
internal class SingletonCleanup
{
	[Cpp2IlInjected.Token(Token = "0x200077D")]
	public delegate void CleanupSingletonCallback();

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public static event CleanupSingletonCallback CleanUpEvent
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x1061164", Offset = "0x1061164", VA = "0x1061164")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1061228", Offset = "0x1061228", VA = "0x1061228")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x10612EC", Offset = "0x10612EC", VA = "0x10612EC")]
	public static void Cleanup()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1061598", Offset = "0x1061598", VA = "0x1061598")]
	public SingletonCleanup()
	{
	}
}
