using Cpp2IlInjected;

namespace Terraria.Initializers;

[Cpp2IlInjected.Token(Token = "0x20003C0")]
public static class LaunchInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6002F55")]
	[Cpp2IlInjected.Address(RVA = "0xCFCAC4", Offset = "0xCFCAC4", VA = "0xCFCAC4")]
	public static void LoadParameters(Main game)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F56")]
	[Cpp2IlInjected.Address(RVA = "0xCFCB5C", Offset = "0xCFCB5C", VA = "0xCFCB5C")]
	private static void LoadSharedParameters(Main game)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F57")]
	[Cpp2IlInjected.Address(RVA = "0xCFDA30", Offset = "0xCFDA30", VA = "0xCFDA30")]
	private static void LoadClientParameters(Main game)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F58")]
	[Cpp2IlInjected.Address(RVA = "0xCFCD1C", Offset = "0xCFCD1C", VA = "0xCFCD1C")]
	private static void LoadServerParameters(Main game)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F59")]
	[Cpp2IlInjected.Address(RVA = "0xCFDDC4", Offset = "0xCFDDC4", VA = "0xCFDDC4")]
	private static bool HasParameter(params string[] keys)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002F5A")]
	[Cpp2IlInjected.Address(RVA = "0xCFDCC4", Offset = "0xCFDCC4", VA = "0xCFDCC4")]
	private static string TryParameter(params string[] keys)
	{
		return null;
	}
}
