using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x2000341")]
public static class Program
{
	[Cpp2IlInjected.Token(Token = "0x4002EE1")]
	public static bool IsXna;

	[Cpp2IlInjected.Token(Token = "0x4002EE2")]
	public static bool IsFna;

	[Cpp2IlInjected.Token(Token = "0x4002EE3")]
	public static bool IsMono;

	[Cpp2IlInjected.Token(Token = "0x4002EE4")]
	public const bool IsDebug = false;

	[Cpp2IlInjected.Token(Token = "0x4002EE5")]
	public static Dictionary<string, string> LaunchParameters;

	[Cpp2IlInjected.Token(Token = "0x4002EE6")]
	public static string SavePath;

	[Cpp2IlInjected.Token(Token = "0x4002EE7")]
	public const string TerrariaSaveFolderPath = "Terraria";

	[Cpp2IlInjected.Token(Token = "0x4002EE8")]
	private static int ThingsToLoad;

	[Cpp2IlInjected.Token(Token = "0x4002EE9")]
	private static int ThingsLoaded;

	[Cpp2IlInjected.Token(Token = "0x4002EEA")]
	public static bool LoadedEverything;

	[Cpp2IlInjected.Token(Token = "0x4002EEB")]
	public static IntPtr JitForcedMethodCache;

	[Cpp2IlInjected.Token(Token = "0x17000557")]
	public static float LoadedPercentage
	{
		[Cpp2IlInjected.Token(Token = "0x600270A")]
		[Cpp2IlInjected.Address(RVA = "0x8684F4", Offset = "0x8684F4", VA = "0x8684F4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600270B")]
	[Cpp2IlInjected.Address(RVA = "0x8685BC", Offset = "0x8685BC", VA = "0x8685BC")]
	public static void StartForceLoad()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600270C")]
	[Cpp2IlInjected.Address(RVA = "0x868638", Offset = "0x868638", VA = "0x868638")]
	public static void ForceLoadThread(object threadContext)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600270D")]
	[Cpp2IlInjected.Address(RVA = "0x8687B0", Offset = "0x8687B0", VA = "0x8687B0")]
	private static void ForceJITOnAssembly(Assembly assembly)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600270E")]
	[Cpp2IlInjected.Address(RVA = "0x8689F0", Offset = "0x8689F0", VA = "0x8689F0")]
	private static void ForceStaticInitializers(Assembly assembly)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600270F")]
	[Cpp2IlInjected.Address(RVA = "0x8686D8", Offset = "0x8686D8", VA = "0x8686D8")]
	private static void ForceLoadAssembly(Assembly assembly, bool initializeStaticMembers)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002710")]
	[Cpp2IlInjected.Address(RVA = "0x868A70", Offset = "0x868A70", VA = "0x868A70")]
	private static void ForceLoadAssembly(string name, bool initializeStaticMembers)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002711")]
	[Cpp2IlInjected.Address(RVA = "0x868B90", Offset = "0x868B90", VA = "0x868B90")]
	private static void SetupLogging()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002712")]
	[Cpp2IlInjected.Address(RVA = "0x868FD8", Offset = "0x868FD8", VA = "0x868FD8")]
	private static void InitializeConsoleOutput()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002713")]
	[Cpp2IlInjected.Address(RVA = "0x869128", Offset = "0x869128", VA = "0x869128")]
	public static void LaunchGame(string[] args, bool monoArgs = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002714")]
	[Cpp2IlInjected.Address(RVA = "0x86952C", Offset = "0x86952C", VA = "0x86952C")]
	private static void DisplayException(Exception e)
	{
	}
}
