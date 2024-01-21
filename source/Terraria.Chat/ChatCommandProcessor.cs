using System.Collections.Generic;
using Cpp2IlInjected;
using Terraria.Chat.Commands;
using Terraria.Localization;

namespace Terraria.Chat;

[Cpp2IlInjected.Token(Token = "0x200052F")]
public class ChatCommandProcessor : IChatProcessor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006893")]
	private readonly Dictionary<LocalizedText, ChatCommandId> _localizedCommands;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4006894")]
	private readonly Dictionary<ChatCommandId, IChatCommand> _commands;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006895")]
	private readonly Dictionary<LocalizedText, NetworkText> _aliases;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006896")]
	private IChatCommand _defaultCommand;

	[Cpp2IlInjected.Token(Token = "0x600392A")]
	[Cpp2IlInjected.Address(RVA = "0x206E51C", Offset = "0x206E51C", VA = "0x206E51C")]
	public ChatCommandProcessor AddCommand<T>() where T : IChatCommand, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600392B")]
	[Cpp2IlInjected.Address(RVA = "0x11CB190", Offset = "0x11CB190", VA = "0x11CB190")]
	public void AddAlias(LocalizedText text, NetworkText result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600392C")]
	[Cpp2IlInjected.Address(RVA = "0x11CB1FC", Offset = "0x11CB1FC", VA = "0x11CB1FC")]
	public void ClearAliases()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600392D")]
	[Cpp2IlInjected.Address(RVA = "0x206E7EC", Offset = "0x206E7EC", VA = "0x206E7EC")]
	public ChatCommandProcessor AddDefaultCommand<T>() where T : IChatCommand, new()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600392E")]
	[Cpp2IlInjected.Address(RVA = "0x11CB258", Offset = "0x11CB258", VA = "0x11CB258")]
	private static bool HasLocalizedCommand(ChatMessage message, LocalizedText command)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600392F")]
	[Cpp2IlInjected.Address(RVA = "0x11CB2C4", Offset = "0x11CB2C4", VA = "0x11CB2C4")]
	private static string RemoveCommandPrefix(string messageText, LocalizedText command)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003930")]
	[Cpp2IlInjected.Address(RVA = "0x11CB374", Offset = "0x11CB374", VA = "0x11CB374", Slot = "5")]
	public ChatMessage CreateOutgoingMessage(string text)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6003931")]
	[Cpp2IlInjected.Address(RVA = "0x11CB7A0", Offset = "0x11CB7A0", VA = "0x11CB7A0", Slot = "4")]
	public void ProcessIncomingMessage(ChatMessage message, int clientId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003932")]
	[Cpp2IlInjected.Address(RVA = "0x11CB91C", Offset = "0x11CB91C", VA = "0x11CB91C")]
	public ChatCommandProcessor()
	{
	}
}
