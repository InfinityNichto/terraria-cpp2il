using System.Text;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x20000BC")]
public static class GUIFadeString
{
	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x1385F80", Offset = "0x1385F80", VA = "0x1385F80")]
	public static void Draw(String_Layout layout, string text, float timeVisible, float fadeDelay = -1f, float fadeTime = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x138613C", Offset = "0x138613C", VA = "0x138613C")]
	public static void Draw(String_Layout layout, StringBuilder value, float timeVisible, float fadeDelay = -1f, float fadeTime = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x13862F0", Offset = "0x13862F0", VA = "0x13862F0")]
	public static void Draw(FadeString_Layout layout, StringBuilder value, float timeVisible)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x138644C", Offset = "0x138644C", VA = "0x138644C")]
	public static void Draw(FadeString_Layout layout, string text, float timeVisible)
	{
	}
}
