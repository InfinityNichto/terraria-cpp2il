using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Chat.Commands;

[Cpp2IlInjected.Token(Token = "0x200053D")]
[Cpp2IlInjected.Attribute(Name = "ChatCommandAttribute", RVA = "0x385430", Offset = "0x385430")]
public class PartyChatCommand : IChatCommand
{
	[Cpp2IlInjected.Token(Token = "0x40068A4")]
	private static readonly Color ERROR_COLOR;

	[Cpp2IlInjected.Token(Token = "0x600396C")]
	[Cpp2IlInjected.Address(RVA = "0x11CF3B4", Offset = "0x11CF3B4", VA = "0x11CF3B4", Slot = "4")]
	public void ProcessIncomingMessage(string text, byte clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600396D")]
	[Cpp2IlInjected.Address(RVA = "0x11CF69C", Offset = "0x11CF69C", VA = "0x11CF69C", Slot = "5")]
	public void ProcessOutgoingMessage(ChatMessage message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600396E")]
	[Cpp2IlInjected.Address(RVA = "0x11CF598", Offset = "0x11CF598", VA = "0x11CF598")]
	private void SendNoTeamError(byte clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600396F")]
	[Cpp2IlInjected.Address(RVA = "0x11CF6A0", Offset = "0x11CF6A0", VA = "0x11CF6A0")]
	public PartyChatCommand()
	{
	}
}
