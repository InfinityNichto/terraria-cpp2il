using System;
using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.Social.Discord;

[Cpp2IlInjected.Token(Token = "0x200038B")]
public class DiscordRpc
{
	[Cpp2IlInjected.Token(Token = "0x20008D6")]
	[Cpp2IlInjected.Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x385878", Offset = "0x385878")]
	public delegate void OnReadyInfo(ref DiscordUser connectedUser);

	[Cpp2IlInjected.Token(Token = "0x20008D7")]
	[Cpp2IlInjected.Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x38588C", Offset = "0x38588C")]
	public delegate void OnDisconnectedInfo(int errorCode, string message);

	[Cpp2IlInjected.Token(Token = "0x20008D8")]
	[Cpp2IlInjected.Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x3858A0", Offset = "0x3858A0")]
	public delegate void OnErrorInfo(int errorCode, string message);

	[Cpp2IlInjected.Token(Token = "0x20008D9")]
	[Cpp2IlInjected.Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x3858B4", Offset = "0x3858B4")]
	public delegate void OnJoinInfo(string secret);

	[Cpp2IlInjected.Token(Token = "0x20008DA")]
	[Cpp2IlInjected.Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x3858C8", Offset = "0x3858C8")]
	public delegate void OnSpectateInfo(string secret);

	[Cpp2IlInjected.Token(Token = "0x20008DB")]
	[Cpp2IlInjected.Attribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x3858DC", Offset = "0x3858DC")]
	public delegate void OnRequestInfo(ref DiscordUser request);

	[Cpp2IlInjected.Token(Token = "0x20008DC")]
	public struct EventHandlers
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40080EC")]
		public OnReadyInfo readyCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40080ED")]
		public OnDisconnectedInfo disconnectedCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40080EE")]
		public OnErrorInfo errorCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40080EF")]
		public OnJoinInfo joinCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40080F0")]
		public OnSpectateInfo spectateCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40080F1")]
		public OnRequestInfo requestCallback;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20008DD")]
	public struct RichPresenceStruct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40080F2")]
		public IntPtr state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40080F3")]
		public IntPtr details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40080F4")]
		public long startTimestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40080F5")]
		public long endTimestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40080F6")]
		public IntPtr largeImageKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40080F7")]
		public IntPtr largeImageText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40080F8")]
		public IntPtr smallImageKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40080F9")]
		public IntPtr smallImageText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40080FA")]
		public IntPtr partyId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40080FB")]
		public int partySize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40080FC")]
		public int partyMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40080FD")]
		public IntPtr matchSecret;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40080FE")]
		public IntPtr joinSecret;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40080FF")]
		public IntPtr spectateSecret;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4008100")]
		public bool instance;
	}

	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20008DE")]
	public struct DiscordUser
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008101")]
		public string userId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4008102")]
		public string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008103")]
		public string discriminator;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008104")]
		public string avatar;
	}

	[Cpp2IlInjected.Token(Token = "0x20008DF")]
	public enum Reply
	{
		[Cpp2IlInjected.Token(Token = "0x4008106")]
		No,
		[Cpp2IlInjected.Token(Token = "0x4008107")]
		Yes,
		[Cpp2IlInjected.Token(Token = "0x4008108")]
		Ignore
	}

	[Cpp2IlInjected.Token(Token = "0x20008E0")]
	public class RichPresence
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008109")]
		private RichPresenceStruct _presence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400810A")]
		private readonly List<IntPtr> _buffers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400810B")]
		public string state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400810C")]
		public string details;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400810D")]
		public long startTimestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400810E")]
		public long endTimestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400810F")]
		public string largeImageKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4008110")]
		public string largeImageText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4008111")]
		public string smallImageKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4008112")]
		public string smallImageText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4008113")]
		public string partyId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4008114")]
		public int partySize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4008115")]
		public int partyMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4008116")]
		public string matchSecret;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4008117")]
		public string joinSecret;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4008118")]
		public string spectateSecret;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4008119")]
		public bool instance;

		[Cpp2IlInjected.Token(Token = "0x6004C33")]
		[Cpp2IlInjected.Address(RVA = "0x14E3D78", Offset = "0x14E3D78", VA = "0x14E3D78")]
		internal RichPresenceStruct GetStruct()
		{
			return default(RichPresenceStruct);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C34")]
		[Cpp2IlInjected.Address(RVA = "0x14E42A8", Offset = "0x14E42A8", VA = "0x14E42A8")]
		private IntPtr StrToPtr(string input)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6004C35")]
		[Cpp2IlInjected.Address(RVA = "0x14E4438", Offset = "0x14E4438", VA = "0x14E4438")]
		private static string StrToUtf8NullTerm(string toconv)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6004C36")]
		[Cpp2IlInjected.Address(RVA = "0x14E3EA8", Offset = "0x14E3EA8", VA = "0x14E3EA8")]
		internal void FreeMem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6004C37")]
		[Cpp2IlInjected.Address(RVA = "0x14E4520", Offset = "0x14E4520", VA = "0x14E4520")]
		public RichPresence()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002D78")]
	[Cpp2IlInjected.Address(RVA = "0x14E1B30", Offset = "0x14E1B30", VA = "0x14E1B30")]
	public static extern void Initialize(string applicationId, ref EventHandlers handlers, bool autoRegister, string optionalSteamId);

	[Cpp2IlInjected.Token(Token = "0x6002D79")]
	[Cpp2IlInjected.Address(RVA = "0x14E2168", Offset = "0x14E2168", VA = "0x14E2168")]
	public static extern void Shutdown();

	[Cpp2IlInjected.Token(Token = "0x6002D7A")]
	[Cpp2IlInjected.Address(RVA = "0x14E2208", Offset = "0x14E2208", VA = "0x14E2208")]
	public static extern void RunCallbacks();

	[Cpp2IlInjected.Token(Token = "0x6002D7B")]
	[Cpp2IlInjected.Address(RVA = "0x14E3968", Offset = "0x14E3968", VA = "0x14E3968")]
	private static extern void UpdatePresenceNative(ref RichPresenceStruct presence);

	[Cpp2IlInjected.Token(Token = "0x6002D7C")]
	[Cpp2IlInjected.Address(RVA = "0x14E3AC8", Offset = "0x14E3AC8", VA = "0x14E3AC8")]
	public static extern void ClearPresence();

	[Cpp2IlInjected.Token(Token = "0x6002D7D")]
	[Cpp2IlInjected.Address(RVA = "0x14E3B60", Offset = "0x14E3B60", VA = "0x14E3B60")]
	public static extern void Respond(string userId, Reply reply);

	[Cpp2IlInjected.Token(Token = "0x6002D7E")]
	[Cpp2IlInjected.Address(RVA = "0x14E3C28", Offset = "0x14E3C28", VA = "0x14E3C28")]
	public static extern void UpdateHandlers(ref EventHandlers handlers);

	[Cpp2IlInjected.Token(Token = "0x6002D7F")]
	[Cpp2IlInjected.Address(RVA = "0x14E3D34", Offset = "0x14E3D34", VA = "0x14E3D34")]
	public static void UpdatePresence(RichPresence presence)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D80")]
	[Cpp2IlInjected.Address(RVA = "0x14E3F90", Offset = "0x14E3F90", VA = "0x14E3F90")]
	public DiscordRpc()
	{
	}
}
