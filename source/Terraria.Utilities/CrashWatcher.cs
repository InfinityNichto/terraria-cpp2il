using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Terraria.Utilities;

[Cpp2IlInjected.Token(Token = "0x2000375")]
public static class CrashWatcher
{
	[Cpp2IlInjected.Token(Token = "0x170005A5")]
	public static bool LogAllExceptions
	{
		[Cpp2IlInjected.Token(Token = "0x6002CD8")]
		[Cpp2IlInjected.Address(RVA = "0x10D96F8", Offset = "0x10D96F8", VA = "0x10D96F8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002CD9")]
		[Cpp2IlInjected.Address(RVA = "0x10D9750", Offset = "0x10D9750", VA = "0x10D9750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005A6")]
	public static bool DumpOnException
	{
		[Cpp2IlInjected.Token(Token = "0x6002CDA")]
		[Cpp2IlInjected.Address(RVA = "0x10D97AC", Offset = "0x10D97AC", VA = "0x10D97AC")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002CDB")]
		[Cpp2IlInjected.Address(RVA = "0x10D9804", Offset = "0x10D9804", VA = "0x10D9804")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005A7")]
	public static bool DumpOnCrash
	{
		[Cpp2IlInjected.Token(Token = "0x6002CDC")]
		[Cpp2IlInjected.Address(RVA = "0x10D9860", Offset = "0x10D9860", VA = "0x10D9860")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002CDD")]
		[Cpp2IlInjected.Address(RVA = "0x10D98B8", Offset = "0x10D98B8", VA = "0x10D98B8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005A8")]
	public static CrashDump.Options CrashDumpOptions
	{
		[Cpp2IlInjected.Token(Token = "0x6002CDE")]
		[Cpp2IlInjected.Address(RVA = "0x10D9914", Offset = "0x10D9914", VA = "0x10D9914")]
		[CompilerGenerated]
		get
		{
			return default(CrashDump.Options);
		}
		[Cpp2IlInjected.Token(Token = "0x6002CDF")]
		[Cpp2IlInjected.Address(RVA = "0x10D996C", Offset = "0x10D996C", VA = "0x10D996C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005A9")]
	private static string DumpPath
	{
		[Cpp2IlInjected.Token(Token = "0x6002CE0")]
		[Cpp2IlInjected.Address(RVA = "0x10D99C8", Offset = "0x10D99C8", VA = "0x10D99C8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002CE1")]
	[Cpp2IlInjected.Address(RVA = "0x10D9A88", Offset = "0x10D9A88", VA = "0x10D9A88")]
	public static void Inititialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CE2")]
	[Cpp2IlInjected.Address(RVA = "0x10D9C9C", Offset = "0x10D9C9C", VA = "0x10D9C9C")]
	private static string PrintException(Exception ex)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002CE3")]
	[Cpp2IlInjected.Address(RVA = "0x10D9F0C", Offset = "0x10D9F0C", VA = "0x10D9F0C")]
	public static void EnableCrashDumps(CrashDump.Options options)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CE4")]
	[Cpp2IlInjected.Address(RVA = "0x10D9FA8", Offset = "0x10D9FA8", VA = "0x10D9FA8")]
	public static void DisableCrashDumps()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002CE5")]
	[Cpp2IlInjected.Address(RVA = "0x10DA004", Offset = "0x10DA004", VA = "0x10DA004")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x393714", Offset = "0x393714")]
	[Cpp2IlInjected.Attribute(Name = "ConditionalAttribute", RVA = "0x393714", Offset = "0x393714")]
	private static void HookDebugExceptionDialog()
	{
	}
}
