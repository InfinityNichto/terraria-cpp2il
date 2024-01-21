using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Localization;

namespace Terraria.UI;

[Cpp2IlInjected.Token(Token = "0x20004C9")]
public class ItemTooltip
{
	[Cpp2IlInjected.Token(Token = "0x4006695")]
	public static readonly ItemTooltip None;

	[Cpp2IlInjected.Token(Token = "0x4006696")]
	private static readonly List<TooltipProcessor> _globalProcessors;

	[Cpp2IlInjected.Token(Token = "0x4006697")]
	private static ulong _globalValidatorKey;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006698")]
	private string[] _tooltipLines;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006699")]
	private ulong _validatorKey;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400669A")]
	private readonly LocalizedText _text;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400669B")]
	private string _processedText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400669C")]
	private readonly short _id;

	[Cpp2IlInjected.Token(Token = "0x170006C8")]
	public int Lines
	{
		[Cpp2IlInjected.Token(Token = "0x60035F0")]
		[Cpp2IlInjected.Address(RVA = "0x13425C8", Offset = "0x13425C8", VA = "0x13425C8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60035F1")]
	[Cpp2IlInjected.Address(RVA = "0x1342824", Offset = "0x1342824", VA = "0x1342824")]
	private ItemTooltip()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035F2")]
	[Cpp2IlInjected.Address(RVA = "0x134282C", Offset = "0x134282C", VA = "0x134282C")]
	private ItemTooltip(short id, string key)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035F3")]
	[Cpp2IlInjected.Address(RVA = "0x1342860", Offset = "0x1342860", VA = "0x1342860")]
	public static ItemTooltip FromLanguageKey(short id, string key)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60035F4")]
	[Cpp2IlInjected.Address(RVA = "0x1342924", Offset = "0x1342924", VA = "0x1342924")]
	public string GetLine(int line)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60035F5")]
	[Cpp2IlInjected.Address(RVA = "0x13425EC", Offset = "0x13425EC", VA = "0x13425EC")]
	private void ValidateTooltip()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035F6")]
	[Cpp2IlInjected.Address(RVA = "0x1342C20", Offset = "0x1342C20", VA = "0x1342C20")]
	public static void AddGlobalProcessor(TooltipProcessor processor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035F7")]
	[Cpp2IlInjected.Address(RVA = "0x1342CB4", Offset = "0x1342CB4", VA = "0x1342CB4")]
	public static void RemoveGlobalProcessor(TooltipProcessor processor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035F8")]
	[Cpp2IlInjected.Address(RVA = "0x1342D48", Offset = "0x1342D48", VA = "0x1342D48")]
	public static void ClearGlobalProcessors()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60035F9")]
	[Cpp2IlInjected.Address(RVA = "0x1342DD4", Offset = "0x1342DD4", VA = "0x1342DD4")]
	public static void InvalidateTooltips()
	{
	}
}
