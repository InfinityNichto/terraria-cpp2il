using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Localization;

namespace Terraria.Chat.Commands;

[Cpp2IlInjected.Token(Token = "0x2000538")]
[Cpp2IlInjected.Attribute(Name = "ChatCommandAttribute", RVA = "0x38532C", Offset = "0x38532C")]
public class EmojiCommand : IChatCommand
{
	[Cpp2IlInjected.Token(Token = "0x400689F")]
	public const int PlayerEmojiDuration = 360;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40068A0")]
	private readonly Dictionary<LocalizedText, int> _byName;

	[Cpp2IlInjected.Token(Token = "0x6003956")]
	[Cpp2IlInjected.Address(RVA = "0x11CDDA0", Offset = "0x11CDDA0", VA = "0x11CDDA0")]
	public EmojiCommand()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003957")]
	[Cpp2IlInjected.Address(RVA = "0x11CDE2C", Offset = "0x11CDE2C", VA = "0x11CDE2C")]
	public void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003958")]
	[Cpp2IlInjected.Address(RVA = "0x11CDF34", Offset = "0x11CDF34", VA = "0x11CDF34", Slot = "4")]
	public void ProcessIncomingMessage(string text, byte clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003959")]
	[Cpp2IlInjected.Address(RVA = "0x11CDF38", Offset = "0x11CDF38", VA = "0x11CDF38", Slot = "5")]
	public void ProcessOutgoingMessage(ChatMessage message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600395A")]
	[Cpp2IlInjected.Address(RVA = "0x11CE27C", Offset = "0x11CE27C", VA = "0x11CE27C")]
	public void PrintWarning(string text)
	{
	}
}
