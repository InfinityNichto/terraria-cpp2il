using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Terraria.Utilities;

namespace Terraria.Localization;

[Cpp2IlInjected.Token(Token = "0x20003B8")]
public static class Language
{
	[Cpp2IlInjected.Token(Token = "0x400326C")]
	public const char NodeKeySeperator = '*';

	[Cpp2IlInjected.Token(Token = "0x170005F0")]
	public static GameCulture ActiveCulture
	{
		[Cpp2IlInjected.Token(Token = "0x6002EDF")]
		[Cpp2IlInjected.Address(RVA = "0x474918", Offset = "0x474918", VA = "0x474918")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002EE0")]
	[Cpp2IlInjected.Address(RVA = "0x475424", Offset = "0x475424", VA = "0x475424")]
	public static LocalizedText GetText(string key)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002EE1")]
	[Cpp2IlInjected.Address(RVA = "0x47557C", Offset = "0x47557C", VA = "0x47557C")]
	public static string GetTextValue(string key)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002EE2")]
	[Cpp2IlInjected.Address(RVA = "0x475690", Offset = "0x475690", VA = "0x475690")]
	public static string GetTextValue(string key, object arg0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002EE3")]
	[Cpp2IlInjected.Address(RVA = "0x4757C0", Offset = "0x4757C0", VA = "0x4757C0")]
	public static string GetTextValue(string key, object arg0, object arg1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002EE4")]
	[Cpp2IlInjected.Address(RVA = "0x475908", Offset = "0x475908", VA = "0x475908")]
	public static string GetTextValue(string key, object arg0, object arg1, object arg2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002EE5")]
	[Cpp2IlInjected.Address(RVA = "0x475A70", Offset = "0x475A70", VA = "0x475A70")]
	public static string GetTextValue(string key, params object[] args)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002EE6")]
	[Cpp2IlInjected.Address(RVA = "0x475BA0", Offset = "0x475BA0", VA = "0x475BA0")]
	public static string GetTextValueWith(string key, object obj)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002EE7")]
	[Cpp2IlInjected.Address(RVA = "0x475D60", Offset = "0x475D60", VA = "0x475D60")]
	public static StringBuilder GetTextValueWith(string key, object obj, StringBuilder sb)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002EE8")]
	[Cpp2IlInjected.Address(RVA = "0x476150", Offset = "0x476150", VA = "0x476150")]
	public static bool Exists(string key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EE9")]
	[Cpp2IlInjected.Address(RVA = "0x476238", Offset = "0x476238", VA = "0x476238")]
	public static int GetCategorySize(string key)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6002EEA")]
	[Cpp2IlInjected.Address(RVA = "0x476350", Offset = "0x476350", VA = "0x476350")]
	public static LocalizedText[] FindAll(Regex regex)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002EEB")]
	[Cpp2IlInjected.Address(RVA = "0x476644", Offset = "0x476644", VA = "0x476644")]
	public static LocalizedText[] FindAll(LanguageSearchFilter filter)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002EEC")]
	[Cpp2IlInjected.Address(RVA = "0x476860", Offset = "0x476860", VA = "0x476860")]
	public static LocalizedText[] FindAll(string categoryName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002EED")]
	[Cpp2IlInjected.Address(RVA = "0x476A40", Offset = "0x476A40", VA = "0x476A40")]
	public static LocalizedText SelectRandom(LanguageSearchFilter filter, [Optional] UnifiedRandom random)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002EEE")]
	[Cpp2IlInjected.Address(RVA = "0x476D94", Offset = "0x476D94", VA = "0x476D94")]
	public static LocalizedText RandomFromCategory(string categoryName, [Optional] UnifiedRandom random)
	{
		return null;
	}
}
