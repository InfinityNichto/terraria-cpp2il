using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Localization;

namespace Terraria.Chat;

[Cpp2IlInjected.Token(Token = "0x200052D")]
public static class ChatHelper
{
	[Cpp2IlInjected.Token(Token = "0x200096D")]
	public class ChatRequest
	{
		[Cpp2IlInjected.Token(Token = "0x2000BA0")]
		public delegate void ChatRequestCallback(bool result, ChatRequest request);

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008BCB")]
		public PlatformUser LocalUser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4008BCC")]
		public PlatformUser SendingUser;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008BCD")]
		public ChatRequestCallback Callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4008BCE")]
		public string message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4008BCF")]
		public Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4008BD0")]
		public byte messageAuthor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4008BD1")]
		public bool result;

		[Cpp2IlInjected.Token(Token = "0x6004DB3")]
		[Cpp2IlInjected.Address(RVA = "0x11CC8E8", Offset = "0x11CC8E8", VA = "0x11CC8E8")]
		public ChatRequest()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4006891")]
	private static List<Tuple<string, Color>> _cachedMessages;

	[Cpp2IlInjected.Token(Token = "0x6003916")]
	[Cpp2IlInjected.Address(RVA = "0x11CBB04", Offset = "0x11CBB04", VA = "0x11CBB04")]
	public static void DisplayMessageOnClient(NetworkText text, Color color, int playerId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003917")]
	[Cpp2IlInjected.Address(RVA = "0x11CBE28", Offset = "0x11CBE28", VA = "0x11CBE28")]
	public static void SendChatMessageToClient(NetworkText text, Color color, int playerId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003918")]
	[Cpp2IlInjected.Address(RVA = "0x11CBEBC", Offset = "0x11CBEBC", VA = "0x11CBEBC")]
	public static void SendChatMessageToClientAs(byte messageAuthor, NetworkText text, Color color, int playerId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003919")]
	[Cpp2IlInjected.Address(RVA = "0x11CC03C", Offset = "0x11CC03C", VA = "0x11CC03C")]
	public static void BroadcastChatMessage(NetworkText text, Color color, int excludedPlayer = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600391A")]
	[Cpp2IlInjected.Address(RVA = "0x11CC0D0", Offset = "0x11CC0D0", VA = "0x11CC0D0")]
	public static void BroadcastChatMessageAs(byte messageAuthor, NetworkText text, Color color, int excludedPlayer = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600391B")]
	[Cpp2IlInjected.Address(RVA = "0x11CC288", Offset = "0x11CC288", VA = "0x11CC288")]
	public static bool OnlySendToPlayersWhoAreLoggedIn(int clientIndex)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600391C")]
	[Cpp2IlInjected.Address(RVA = "0x11CC31C", Offset = "0x11CC31C", VA = "0x11CC31C")]
	public static void SendChatMessageFromClient(ChatMessage message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600391D")]
	[Cpp2IlInjected.Address(RVA = "0x11CC3D8", Offset = "0x11CC3D8", VA = "0x11CC3D8")]
	public static void DisplayCheckedMessage(bool result, ChatRequest request)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600391E")]
	[Cpp2IlInjected.Address(RVA = "0x11CC714", Offset = "0x11CC714", VA = "0x11CC714")]
	public static void PlatformCheckedMessage(string message, Color color, byte messageAuthor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600391F")]
	[Cpp2IlInjected.Address(RVA = "0x11CBC80", Offset = "0x11CBC80", VA = "0x11CBC80")]
	public static void DisplayMessage(NetworkText text, Color color, byte messageAuthor)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003920")]
	[Cpp2IlInjected.Address(RVA = "0x11CC640", Offset = "0x11CC640", VA = "0x11CC640")]
	private static void CacheMessage(string message, Color color)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003921")]
	[Cpp2IlInjected.Address(RVA = "0x11CC904", Offset = "0x11CC904", VA = "0x11CC904")]
	public static void ShowCachedMessages()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003922")]
	[Cpp2IlInjected.Address(RVA = "0x11CCB1C", Offset = "0x11CCB1C", VA = "0x11CCB1C")]
	public static void ClearDelayedMessagesCache()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003923")]
	[Cpp2IlInjected.Address(RVA = "0x11CC594", Offset = "0x11CC594", VA = "0x11CC594")]
	private static bool ShouldCacheMessage()
	{
		return default(bool);
	}
}
