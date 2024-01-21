using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat.Commands;

[Cpp2IlInjected.Token(Token = "0x200053B")]
[Cpp2IlInjected.Attribute(Name = "ChatCommandAttribute", RVA = "0x3853C8", Offset = "0x3853C8")]
public class HelpCommand : IChatCommand
{
	[Cpp2IlInjected.Token(Token = "0x40068A2")]
	private static readonly Color RESPONSE_COLOR;

	[Cpp2IlInjected.Token(Token = "0x6003962")]
	[Cpp2IlInjected.Address(RVA = "0x11CE520", Offset = "0x11CE520", VA = "0x11CE520", Slot = "4")]
	public void ProcessIncomingMessage(string text, byte clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003963")]
	[Cpp2IlInjected.Address(RVA = "0x11CE5E4", Offset = "0x11CE5E4", VA = "0x11CE5E4")]
	private static Dictionary<string, List<LocalizedText>> GetCommandAliasesByID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003964")]
	[Cpp2IlInjected.Address(RVA = "0x11CE7E0", Offset = "0x11CE7E0", VA = "0x11CE7E0")]
	private static NetworkText ComposeMessage(Dictionary<string, List<LocalizedText>> aliases)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003965")]
	[Cpp2IlInjected.Address(RVA = "0x11CEB4C", Offset = "0x11CEB4C", VA = "0x11CEB4C", Slot = "5")]
	public void ProcessOutgoingMessage(ChatMessage message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003966")]
	[Cpp2IlInjected.Address(RVA = "0x11CEB50", Offset = "0x11CEB50", VA = "0x11CEB50")]
	public HelpCommand()
	{
	}
}
