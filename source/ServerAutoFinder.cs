using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000225")]
public static class ServerAutoFinder
{
	[Cpp2IlInjected.Token(Token = "0x2000804")]
	public class SearchServerResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007D00")]
		public string WorldName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007D01")]
		public IPAddress ServerAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007D02")]
		public int ServerPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007D03")]
		public DateTime LastRecieved;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007D04")]
		public ushort WorldXSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4007D05")]
		public int NumberOfPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4007D06")]
		public int MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4007D07")]
		public short GameMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E")]
		[Cpp2IlInjected.Token(Token = "0x4007D08")]
		public bool Corruption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F")]
		[Cpp2IlInjected.Token(Token = "0x4007D09")]
		public bool HardMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4007D0A")]
		public string HostName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4007D0B")]
		public MPSession SourceSession;

		[Cpp2IlInjected.Token(Token = "0x6004941")]
		[Cpp2IlInjected.Address(RVA = "0xFA6814", Offset = "0xFA6814", VA = "0xFA6814")]
		public SearchServerResult()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4001A41")]
	private const SocketOptionName OnlyAllowIPv6 = SocketOptionName.IPv6Only;

	[Cpp2IlInjected.Token(Token = "0x4001A42")]
	private static UdpClient broadcastPort;

	[Cpp2IlInjected.Token(Token = "0x4001A43")]
	private static ManagedThread broadcastThread;

	[Cpp2IlInjected.Token(Token = "0x4001A44")]
	private static ManagedThread platformFriendGamesThread;

	[Cpp2IlInjected.Token(Token = "0x4001A45")]
	private static List<SearchServerResult> TempResults;

	[Cpp2IlInjected.Token(Token = "0x4001A46")]
	private static List<SearchServerResult> FriendResults;

	[Cpp2IlInjected.Token(Token = "0x4001A47")]
	private static DateTime LastListUpdate;

	[Cpp2IlInjected.Token(Token = "0x4001A48")]
	public static List<SearchServerResult> Results;

	[Cpp2IlInjected.Token(Token = "0x6000F87")]
	[Cpp2IlInjected.Address(RVA = "0xFA5D50", Offset = "0xFA5D50", VA = "0xFA5D50")]
	private static void BroadcastRecieveThread()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F88")]
	[Cpp2IlInjected.Address(RVA = "0xFA681C", Offset = "0xFA681C", VA = "0xFA681C")]
	private static void LookForFriendPlatformGames()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F89")]
	[Cpp2IlInjected.Address(RVA = "0xFA6C4C", Offset = "0xFA6C4C", VA = "0xFA6C4C")]
	public static void UpdateResults()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F8A")]
	[Cpp2IlInjected.Address(RVA = "0xFA71C4", Offset = "0xFA71C4", VA = "0xFA71C4")]
	public static void StartSearching()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F8B")]
	[Cpp2IlInjected.Address(RVA = "0xFA7410", Offset = "0xFA7410", VA = "0xFA7410")]
	public static void StopSearching()
	{
	}
}
