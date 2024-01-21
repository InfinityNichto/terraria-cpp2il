using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003D2")]
public class OldSaveSynchronise
{
	[Cpp2IlInjected.Token(Token = "0x40032BC")]
	private static string _oldSaveRoot;

	[Cpp2IlInjected.Token(Token = "0x17000600")]
	private static string OldSaveRoot
	{
		[Cpp2IlInjected.Token(Token = "0x6002FDE")]
		[Cpp2IlInjected.Address(RVA = "0xE41180", Offset = "0xE41180", VA = "0xE41180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002FDF")]
	[Cpp2IlInjected.Address(RVA = "0xE41414", Offset = "0xE41414", VA = "0xE41414")]
	public static void CopyOldSaves()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FE0")]
	[Cpp2IlInjected.Address(RVA = "0xE41F00", Offset = "0xE41F00", VA = "0xE41F00")]
	public OldSaveSynchronise()
	{
	}
}
