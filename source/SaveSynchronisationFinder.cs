using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x200021D")]
public static class SaveSynchronisationFinder
{
	[Cpp2IlInjected.Token(Token = "0x2000800")]
	public class SearchServerResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4007CEC")]
		public IPAddress ServerAddress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4007CED")]
		public string HostName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4007CEE")]
		public DrPlatform.DrPlatformType Platform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4007CEF")]
		public int PlayerFileCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4007CF0")]
		public int WorldFileCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4007CF1")]
		public DateTime LastRecieved;

		[Cpp2IlInjected.Token(Token = "0x600493C")]
		[Cpp2IlInjected.Address(RVA = "0xF9E9DC", Offset = "0xF9E9DC", VA = "0xF9E9DC")]
		public SearchServerResult()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4001A18")]
	private static List<SearchServerResult> TempResults;

	[Cpp2IlInjected.Token(Token = "0x4001A19")]
	private static DateTime LastListUpdate;

	[Cpp2IlInjected.Token(Token = "0x4001A1A")]
	public static List<SearchServerResult> Results;

	[Cpp2IlInjected.Token(Token = "0x4001A1B")]
	private const SocketOptionName OnlyAllowIPv6 = SocketOptionName.IPv6Only;

	[Cpp2IlInjected.Token(Token = "0x4001A1C")]
	private static UdpClient broadcastPort;

	[Cpp2IlInjected.Token(Token = "0x4001A1D")]
	private static Thread broadcastThread;

	[Cpp2IlInjected.Token(Token = "0x6000F49")]
	[Cpp2IlInjected.Address(RVA = "0xF9E04C", Offset = "0xF9E04C", VA = "0xF9E04C")]
	private static void BroadcastRecieveThread()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F4A")]
	[Cpp2IlInjected.Address(RVA = "0xF9E9E4", Offset = "0xF9E9E4", VA = "0xF9E9E4")]
	public static void UpdateResults()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F4B")]
	[Cpp2IlInjected.Address(RVA = "0xF9EE08", Offset = "0xF9EE08", VA = "0xF9EE08")]
	public static void StartSearching()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000F4C")]
	[Cpp2IlInjected.Address(RVA = "0xF9EF40", Offset = "0xF9EF40", VA = "0xF9EF40")]
	public static void StopSearching()
	{
	}
}
