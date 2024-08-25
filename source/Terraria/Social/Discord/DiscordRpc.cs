using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Base;

namespace Terraria.Social.Discord
{
	[global::Cpp2ILInjected.Token(Token = "0x2000517")]
	public class DiscordRpc
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003179")]
		[global::Cpp2ILInjected.Address(RVA = "0x13282E0", Offset = "0x13282E0", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoreSocialModule), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		[PreserveSig]
		public static extern void Initialize(string applicationId, ref DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);

		[global::Cpp2ILInjected.Token(Token = "0x600317A")]
		[global::Cpp2ILInjected.Address(RVA = "0x13287F0", Offset = "0x13287F0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoreSocialModule), Member = "Shutdown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		public static extern void Shutdown();

		[global::Cpp2ILInjected.Token(Token = "0x600317B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328858", Offset = "0x1328858", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		public static extern void RunCallbacks();

		[global::Cpp2ILInjected.Token(Token = "0x600317C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328E44", Offset = "0x1328E44", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DiscordRpc), Member = "UpdatePresence", MemberParameters = new object[] { typeof(DiscordRpc.RichPresence) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		private static extern void UpdatePresenceNative(ref DiscordRpc.RichPresenceStruct presence);

		[global::Cpp2ILInjected.Token(Token = "0x600317D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328F5C", Offset = "0x1328F5C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		public static extern void ClearPresence();

		[global::Cpp2ILInjected.Token(Token = "0x600317E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328FC0", Offset = "0x1328FC0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.JoinRequestSocialModule.<>c__DisplayClass3_0", Member = "<ReceiveJoinRequest>b__0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.JoinRequestSocialModule.<>c__DisplayClass3_0", Member = "<ReceiveJoinRequest>b__1", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[PreserveSig]
		public static extern void Respond(string userId, DiscordRpc.Reply reply);

		[global::Cpp2ILInjected.Token(Token = "0x600317F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1329054", Offset = "0x1329054", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[PreserveSig]
		public static extern void UpdateHandlers(ref DiscordRpc.EventHandlers handlers);

		[global::Cpp2ILInjected.Token(Token = "0x6003180")]
		[global::Cpp2ILInjected.Address(RVA = "0x1329110", Offset = "0x1329110", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RichPresenceSocialModule), Member = "PublishPresence", MemberParameters = new object[] { typeof(RichPresenceState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.RichPresence), Member = "GetStruct", ReturnType = typeof(DiscordRpc.RichPresenceStruct))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc), Member = "UpdatePresenceNative", MemberParameters = new object[] { typeof(ref DiscordRpc.RichPresenceStruct) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.RichPresence), Member = "FreeMem", ReturnType = typeof(void))]
		public static void UpdatePresence(DiscordRpc.RichPresence presence)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003181")]
		[global::Cpp2ILInjected.Address(RVA = "0x1329350", Offset = "0x1329350", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DiscordRpc()
		{
			throw null;
		}

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x2000518")]
		public delegate void OnReadyInfo(ref DiscordRpc.DiscordUser connectedUser);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x2000519")]
		public delegate void OnDisconnectedInfo(int errorCode, string message);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x200051A")]
		public delegate void OnErrorInfo(int errorCode, string message);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x200051B")]
		public delegate void OnJoinInfo(string secret);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x200051C")]
		public delegate void OnSpectateInfo(string secret);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x200051D")]
		public delegate void OnRequestInfo(ref DiscordRpc.DiscordUser request);

		[global::Cpp2ILInjected.Token(Token = "0x200051E")]
		public struct EventHandlers
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003B28")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public DiscordRpc.OnReadyInfo readyCallback;

			[global::Cpp2ILInjected.Token(Token = "0x4003B29")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public DiscordRpc.OnDisconnectedInfo disconnectedCallback;

			[global::Cpp2ILInjected.Token(Token = "0x4003B2A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public DiscordRpc.OnErrorInfo errorCallback;

			[global::Cpp2ILInjected.Token(Token = "0x4003B2B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public DiscordRpc.OnJoinInfo joinCallback;

			[global::Cpp2ILInjected.Token(Token = "0x4003B2C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public DiscordRpc.OnSpectateInfo spectateCallback;

			[global::Cpp2ILInjected.Token(Token = "0x4003B2D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public DiscordRpc.OnRequestInfo requestCallback;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200051F")]
		[Serializable]
		public struct RichPresenceStruct
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003B2E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IntPtr state;

			[global::Cpp2ILInjected.Token(Token = "0x4003B2F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public IntPtr details;

			[global::Cpp2ILInjected.Token(Token = "0x4003B30")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public long startTimestamp;

			[global::Cpp2ILInjected.Token(Token = "0x4003B31")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public long endTimestamp;

			[global::Cpp2ILInjected.Token(Token = "0x4003B32")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public IntPtr largeImageKey;

			[global::Cpp2ILInjected.Token(Token = "0x4003B33")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public IntPtr largeImageText;

			[global::Cpp2ILInjected.Token(Token = "0x4003B34")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public IntPtr smallImageKey;

			[global::Cpp2ILInjected.Token(Token = "0x4003B35")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public IntPtr smallImageText;

			[global::Cpp2ILInjected.Token(Token = "0x4003B36")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public IntPtr partyId;

			[global::Cpp2ILInjected.Token(Token = "0x4003B37")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public int partySize;

			[global::Cpp2ILInjected.Token(Token = "0x4003B38")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			public int partyMax;

			[global::Cpp2ILInjected.Token(Token = "0x4003B39")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			public IntPtr matchSecret;

			[global::Cpp2ILInjected.Token(Token = "0x4003B3A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			public IntPtr joinSecret;

			[global::Cpp2ILInjected.Token(Token = "0x4003B3B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			public IntPtr spectateSecret;

			[global::Cpp2ILInjected.Token(Token = "0x4003B3C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			public bool instance;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000520")]
		[Serializable]
		public struct DiscordUser
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003B3D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public string userId;

			[global::Cpp2ILInjected.Token(Token = "0x4003B3E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public string username;

			[global::Cpp2ILInjected.Token(Token = "0x4003B3F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string discriminator;

			[global::Cpp2ILInjected.Token(Token = "0x4003B40")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public string avatar;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000521")]
		public enum Reply
		{
			[global::Cpp2ILInjected.Token(Token = "0x4003B42")]
			No,
			[global::Cpp2ILInjected.Token(Token = "0x4003B43")]
			Yes,
			[global::Cpp2ILInjected.Token(Token = "0x4003B44")]
			Ignore
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000522")]
		public class RichPresence
		{
			[global::Cpp2ILInjected.Token(Token = "0x600319A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1329150", Offset = "0x1329150", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DiscordRpc), Member = "UpdatePresence", MemberParameters = new object[] { typeof(DiscordRpc.RichPresence) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.RichPresence), Member = "FreeMem", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DiscordRpc.RichPresence), Member = "StrToPtr", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IntPtr))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal DiscordRpc.RichPresenceStruct GetStruct()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600319B")]
			[global::Cpp2ILInjected.Address(RVA = "0x13296B0", Offset = "0x13296B0", Length = "0x1C8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DiscordRpc.RichPresence), Member = "GetStruct", ReturnType = typeof(DiscordRpc.RichPresenceStruct))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(IntPtr))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "WriteByte", MemberParameters = new object[]
			{
				typeof(IntPtr),
				typeof(int),
				typeof(byte)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(IntPtr),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			private IntPtr StrToPtr(string input)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600319C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1329878", Offset = "0x1329878", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private static string StrToUtf8NullTerm(string toconv)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600319D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1329264", Offset = "0x1329264", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DiscordRpc.RichPresence), Member = "GetStruct", ReturnType = typeof(DiscordRpc.RichPresenceStruct))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DiscordRpc), Member = "UpdatePresence", MemberParameters = new object[] { typeof(DiscordRpc.RichPresence) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<IntPtr>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<IntPtr>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			internal void FreeMem()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600319E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1329950", Offset = "0x1329950", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RichPresenceSocialModule), Member = "PublishPresence", MemberParameters = new object[] { typeof(RichPresenceState) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<IntPtr>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public RichPresence()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4003B45")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private DiscordRpc.RichPresenceStruct _presence;

			[global::Cpp2ILInjected.Token(Token = "0x4003B46")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private readonly List<IntPtr> _buffers;

			[global::Cpp2ILInjected.Token(Token = "0x4003B47")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
			public string state;

			[global::Cpp2ILInjected.Token(Token = "0x4003B48")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			public string details;

			[global::Cpp2ILInjected.Token(Token = "0x4003B49")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
			public long startTimestamp;

			[global::Cpp2ILInjected.Token(Token = "0x4003B4A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
			public long endTimestamp;

			[global::Cpp2ILInjected.Token(Token = "0x4003B4B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
			public string largeImageKey;

			[global::Cpp2ILInjected.Token(Token = "0x4003B4C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
			public string largeImageText;

			[global::Cpp2ILInjected.Token(Token = "0x4003B4D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
			public string smallImageKey;

			[global::Cpp2ILInjected.Token(Token = "0x4003B4E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
			public string smallImageText;

			[global::Cpp2ILInjected.Token(Token = "0x4003B4F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
			public string partyId;

			[global::Cpp2ILInjected.Token(Token = "0x4003B50")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
			public int partySize;

			[global::Cpp2ILInjected.Token(Token = "0x4003B51")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
			public int partyMax;

			[global::Cpp2ILInjected.Token(Token = "0x4003B52")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
			public string matchSecret;

			[global::Cpp2ILInjected.Token(Token = "0x4003B53")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
			public string joinSecret;

			[global::Cpp2ILInjected.Token(Token = "0x4003B54")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
			public string spectateSecret;

			[global::Cpp2ILInjected.Token(Token = "0x4003B55")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
			public bool instance;
		}
	}
}
