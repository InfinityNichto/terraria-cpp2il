using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;

namespace Terraria.Localization;

[Cpp2IlInjected.Token(Token = "0x20003BA")]
public class LocalizedText
{
	[Cpp2IlInjected.Token(Token = "0x4003276")]
	public static readonly LocalizedText Empty;

	[Cpp2IlInjected.Token(Token = "0x4003277")]
	private static Regex _substitutionRegex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003278")]
	public readonly string Key;

	[Cpp2IlInjected.Token(Token = "0x170005F2")]
	public string Value
	{
		[Cpp2IlInjected.Token(Token = "0x6002F14")]
		[Cpp2IlInjected.Address(RVA = "0x479CF4", Offset = "0x479CF4", VA = "0x479CF4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002F15")]
		[Cpp2IlInjected.Address(RVA = "0x479CFC", Offset = "0x479CFC", VA = "0x479CFC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002F16")]
	[Cpp2IlInjected.Address(RVA = "0x478EF4", Offset = "0x478EF4", VA = "0x478EF4")]
	internal LocalizedText(string key, string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F17")]
	[Cpp2IlInjected.Address(RVA = "0x477E4C", Offset = "0x477E4C", VA = "0x477E4C")]
	internal void SetValue(string text)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F18")]
	[Cpp2IlInjected.Address(RVA = "0x475C30", Offset = "0x475C30", VA = "0x475C30")]
	public string FormatWith(object obj)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F19")]
	[Cpp2IlInjected.Address(RVA = "0x475DF8", Offset = "0x475DF8", VA = "0x475DF8")]
	public StringBuilder FormatWith(object obj, StringBuilder sb)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F1A")]
	[Cpp2IlInjected.Address(RVA = "0x479D0C", Offset = "0x479D0C", VA = "0x479D0C")]
	public bool CanFormatWith(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002F1B")]
	[Cpp2IlInjected.Address(RVA = "0x47A1C4", Offset = "0x47A1C4", VA = "0x47A1C4")]
	public NetworkText ToNetworkText()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F1C")]
	[Cpp2IlInjected.Address(RVA = "0x47A390", Offset = "0x47A390", VA = "0x47A390")]
	public NetworkText ToNetworkText(params object[] substitutions)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F1D")]
	[Cpp2IlInjected.Address(RVA = "0x47A414", Offset = "0x47A414", VA = "0x47A414")]
	public static explicit operator string(LocalizedText text)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F1E")]
	[Cpp2IlInjected.Address(RVA = "0x479AC8", Offset = "0x479AC8", VA = "0x479AC8")]
	public string Format(object arg0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F1F")]
	[Cpp2IlInjected.Address(RVA = "0x479AD4", Offset = "0x479AD4", VA = "0x479AD4")]
	public string Format(object arg0, object arg1)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F20")]
	[Cpp2IlInjected.Address(RVA = "0x479AE0", Offset = "0x479AE0", VA = "0x479AE0")]
	public string Format(object arg0, object arg1, object arg2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F21")]
	[Cpp2IlInjected.Address(RVA = "0x479B04", Offset = "0x479B04", VA = "0x479B04")]
	public string Format(params object[] args)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F22")]
	[Cpp2IlInjected.Address(RVA = "0x47A41C", Offset = "0x47A41C", VA = "0x47A41C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
