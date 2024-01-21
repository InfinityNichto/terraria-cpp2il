using Cpp2IlInjected;
using UnityEngine;

[Cpp2IlInjected.Token(Token = "0x2000038")]
public class Localisation
{
	[Cpp2IlInjected.Token(Token = "0x200077B")]
	public enum SupportedLanguages
	{
		[Cpp2IlInjected.Token(Token = "0x40078BD")]
		English = 1,
		[Cpp2IlInjected.Token(Token = "0x40078BE")]
		German = 2,
		[Cpp2IlInjected.Token(Token = "0x40078BF")]
		Italian = 3,
		[Cpp2IlInjected.Token(Token = "0x40078C0")]
		French = 4,
		[Cpp2IlInjected.Token(Token = "0x40078C1")]
		Spanish = 5,
		[Cpp2IlInjected.Token(Token = "0x40078C2")]
		Russian = 6,
		[Cpp2IlInjected.Token(Token = "0x40078C3")]
		Portuguese = 8,
		[Cpp2IlInjected.Token(Token = "0x40078C4")]
		Japanese = 10
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x12DF4B0", Offset = "0x12DF4B0", VA = "0x12DF4B0")]
	private static SystemLanguage GetPS4SystemLanguage()
	{
		return default(SystemLanguage);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x12DF4B8", Offset = "0x12DF4B8", VA = "0x12DF4B8")]
	private static SystemLanguage GetSwitchSystemLanguage()
	{
		return default(SystemLanguage);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x12DF4C0", Offset = "0x12DF4C0", VA = "0x12DF4C0")]
	public static int GetLanguage()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x12DF740", Offset = "0x12DF740", VA = "0x12DF740")]
	public Localisation()
	{
	}
}
