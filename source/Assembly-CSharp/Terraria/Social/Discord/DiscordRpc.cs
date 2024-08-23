using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Base;

namespace Terraria.Social.Discord
{
	// Token: 0x02000388 RID: 904
	[global::Cpp2ILInjected.Token(Token = "0x2000517")]
	public class DiscordRpc
	{
		// Token: 0x06002D40 RID: 11584
		[global::Cpp2ILInjected.Token(Token = "0x6003179")]
		[global::Cpp2ILInjected.Address(RVA = "0x13282E0", Offset = "0x13282E0", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoreSocialModule), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		[PreserveSig]
		public static extern void Initialize(string applicationId, ref DiscordRpc.EventHandlers handlers, bool autoRegister, string optionalSteamId);

		// Token: 0x06002D41 RID: 11585
		[global::Cpp2ILInjected.Token(Token = "0x600317A")]
		[global::Cpp2ILInjected.Address(RVA = "0x13287F0", Offset = "0x13287F0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CoreSocialModule), Member = "Shutdown", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		public static extern void Shutdown();

		// Token: 0x06002D42 RID: 11586
		[global::Cpp2ILInjected.Token(Token = "0x600317B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328858", Offset = "0x1328858", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		public static extern void RunCallbacks();

		// Token: 0x06002D43 RID: 11587
		[global::Cpp2ILInjected.Token(Token = "0x600317C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328E44", Offset = "0x1328E44", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DiscordRpc), Member = "UpdatePresence", MemberParameters = new object[] { typeof(DiscordRpc.RichPresence) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		private static extern void UpdatePresenceNative(ref DiscordRpc.RichPresenceStruct presence);

		// Token: 0x06002D44 RID: 11588
		[global::Cpp2ILInjected.Token(Token = "0x600317D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328F5C", Offset = "0x1328F5C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		public static extern void ClearPresence();

		// Token: 0x06002D45 RID: 11589
		[global::Cpp2ILInjected.Token(Token = "0x600317E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1328FC0", Offset = "0x1328FC0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.JoinRequestSocialModule.<>c__DisplayClass3_0", Member = "<ReceiveJoinRequest>b__0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Social.Discord.JoinRequestSocialModule.<>c__DisplayClass3_0", Member = "<ReceiveJoinRequest>b__1", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[PreserveSig]
		public static extern void Respond(string userId, DiscordRpc.Reply reply);

		// Token: 0x06002D46 RID: 11590
		[global::Cpp2ILInjected.Token(Token = "0x600317F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1329054", Offset = "0x1329054", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[PreserveSig]
		public static extern void UpdateHandlers(ref DiscordRpc.EventHandlers handlers);

		// Token: 0x06002D47 RID: 11591 RVA: 0x0002A1DF File Offset: 0x000283DF
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

		// Token: 0x06002D48 RID: 11592 RVA: 0x0002A1E2 File Offset: 0x000283E2
		[global::Cpp2ILInjected.Token(Token = "0x6003181")]
		[global::Cpp2ILInjected.Address(RVA = "0x1329350", Offset = "0x1329350", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DiscordRpc()
		{
			throw null;
		}

		// Token: 0x020008DF RID: 2271
		// (Invoke) Token: 0x06004BE5 RID: 19429
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x2000518")]
		public delegate void OnReadyInfo(ref DiscordRpc.DiscordUser connectedUser);

		// Token: 0x020008E0 RID: 2272
		// (Invoke) Token: 0x06004BE9 RID: 19433
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x2000519")]
		public delegate void OnDisconnectedInfo(int errorCode, string message);

		// Token: 0x020008E1 RID: 2273
		// (Invoke) Token: 0x06004BED RID: 19437
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x200051A")]
		public delegate void OnErrorInfo(int errorCode, string message);

		// Token: 0x020008E2 RID: 2274
		// (Invoke) Token: 0x06004BF1 RID: 19441
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x200051B")]
		public delegate void OnJoinInfo(string secret);

		// Token: 0x020008E3 RID: 2275
		// (Invoke) Token: 0x06004BF5 RID: 19445
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x200051C")]
		public delegate void OnSpectateInfo(string secret);

		// Token: 0x020008E4 RID: 2276
		// (Invoke) Token: 0x06004BF9 RID: 19449
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x200051D")]
		public delegate void OnRequestInfo(ref DiscordRpc.DiscordUser request);

		// Token: 0x020008E5 RID: 2277
		[global::Cpp2ILInjected.Token(Token = "0x200051E")]
		public struct EventHandlers
		{
			// Token: 0x040080FF RID: 33023
			[global::Cpp2ILInjected.Token(Token = "0x4003B28")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public DiscordRpc.OnReadyInfo readyCallback;

			// Token: 0x04008100 RID: 33024
			[global::Cpp2ILInjected.Token(Token = "0x4003B29")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public DiscordRpc.OnDisconnectedInfo disconnectedCallback;

			// Token: 0x04008101 RID: 33025
			[global::Cpp2ILInjected.Token(Token = "0x4003B2A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public DiscordRpc.OnErrorInfo errorCallback;

			// Token: 0x04008102 RID: 33026
			[global::Cpp2ILInjected.Token(Token = "0x4003B2B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public DiscordRpc.OnJoinInfo joinCallback;

			// Token: 0x04008103 RID: 33027
			[global::Cpp2ILInjected.Token(Token = "0x4003B2C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public DiscordRpc.OnSpectateInfo spectateCallback;

			// Token: 0x04008104 RID: 33028
			[global::Cpp2ILInjected.Token(Token = "0x4003B2D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public DiscordRpc.OnRequestInfo requestCallback;
		}

		// Token: 0x020008E6 RID: 2278
		[global::Cpp2ILInjected.Token(Token = "0x200051F")]
		[Serializable]
		public struct RichPresenceStruct
		{
			// Token: 0x04008105 RID: 33029
			[global::Cpp2ILInjected.Token(Token = "0x4003B2E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public IntPtr state;

			// Token: 0x04008106 RID: 33030
			[global::Cpp2ILInjected.Token(Token = "0x4003B2F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public IntPtr details;

			// Token: 0x04008107 RID: 33031
			[global::Cpp2ILInjected.Token(Token = "0x4003B30")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public long startTimestamp;

			// Token: 0x04008108 RID: 33032
			[global::Cpp2ILInjected.Token(Token = "0x4003B31")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public long endTimestamp;

			// Token: 0x04008109 RID: 33033
			[global::Cpp2ILInjected.Token(Token = "0x4003B32")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public IntPtr largeImageKey;

			// Token: 0x0400810A RID: 33034
			[global::Cpp2ILInjected.Token(Token = "0x4003B33")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public IntPtr largeImageText;

			// Token: 0x0400810B RID: 33035
			[global::Cpp2ILInjected.Token(Token = "0x4003B34")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public IntPtr smallImageKey;

			// Token: 0x0400810C RID: 33036
			[global::Cpp2ILInjected.Token(Token = "0x4003B35")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public IntPtr smallImageText;

			// Token: 0x0400810D RID: 33037
			[global::Cpp2ILInjected.Token(Token = "0x4003B36")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public IntPtr partyId;

			// Token: 0x0400810E RID: 33038
			[global::Cpp2ILInjected.Token(Token = "0x4003B37")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public int partySize;

			// Token: 0x0400810F RID: 33039
			[global::Cpp2ILInjected.Token(Token = "0x4003B38")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			public int partyMax;

			// Token: 0x04008110 RID: 33040
			[global::Cpp2ILInjected.Token(Token = "0x4003B39")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			public IntPtr matchSecret;

			// Token: 0x04008111 RID: 33041
			[global::Cpp2ILInjected.Token(Token = "0x4003B3A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			public IntPtr joinSecret;

			// Token: 0x04008112 RID: 33042
			[global::Cpp2ILInjected.Token(Token = "0x4003B3B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			public IntPtr spectateSecret;

			// Token: 0x04008113 RID: 33043
			[global::Cpp2ILInjected.Token(Token = "0x4003B3C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			public bool instance;
		}

		// Token: 0x020008E7 RID: 2279
		[global::Cpp2ILInjected.Token(Token = "0x2000520")]
		[Serializable]
		public struct DiscordUser
		{
			// Token: 0x04008114 RID: 33044
			[global::Cpp2ILInjected.Token(Token = "0x4003B3D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public string userId;

			// Token: 0x04008115 RID: 33045
			[global::Cpp2ILInjected.Token(Token = "0x4003B3E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public string username;

			// Token: 0x04008116 RID: 33046
			[global::Cpp2ILInjected.Token(Token = "0x4003B3F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string discriminator;

			// Token: 0x04008117 RID: 33047
			[global::Cpp2ILInjected.Token(Token = "0x4003B40")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public string avatar;
		}

		// Token: 0x020008E8 RID: 2280
		[global::Cpp2ILInjected.Token(Token = "0x2000521")]
		public enum Reply
		{
			// Token: 0x04008119 RID: 33049
			[global::Cpp2ILInjected.Token(Token = "0x4003B42")]
			No,
			// Token: 0x0400811A RID: 33050
			[global::Cpp2ILInjected.Token(Token = "0x4003B43")]
			Yes,
			// Token: 0x0400811B RID: 33051
			[global::Cpp2ILInjected.Token(Token = "0x4003B44")]
			Ignore
		}

		// Token: 0x020008E9 RID: 2281
		[global::Cpp2ILInjected.Token(Token = "0x2000522")]
		public class RichPresence
		{
			// Token: 0x06004BFC RID: 19452 RVA: 0x0002F729 File Offset: 0x0002D929
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

			// Token: 0x06004BFD RID: 19453 RVA: 0x0002F72C File Offset: 0x0002D92C
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

			// Token: 0x06004BFE RID: 19454 RVA: 0x0002F72F File Offset: 0x0002D92F
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

			// Token: 0x06004BFF RID: 19455 RVA: 0x0002F732 File Offset: 0x0002D932
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

			// Token: 0x06004C00 RID: 19456 RVA: 0x0002F735 File Offset: 0x0002D935
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

			// Token: 0x0400811C RID: 33052
			[global::Cpp2ILInjected.Token(Token = "0x4003B45")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private DiscordRpc.RichPresenceStruct _presence;

			// Token: 0x0400811D RID: 33053
			[global::Cpp2ILInjected.Token(Token = "0x4003B46")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			private readonly List<IntPtr> _buffers;

			// Token: 0x0400811E RID: 33054
			[global::Cpp2ILInjected.Token(Token = "0x4003B47")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
			public string state;

			// Token: 0x0400811F RID: 33055
			[global::Cpp2ILInjected.Token(Token = "0x4003B48")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
			public string details;

			// Token: 0x04008120 RID: 33056
			[global::Cpp2ILInjected.Token(Token = "0x4003B49")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
			public long startTimestamp;

			// Token: 0x04008121 RID: 33057
			[global::Cpp2ILInjected.Token(Token = "0x4003B4A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
			public long endTimestamp;

			// Token: 0x04008122 RID: 33058
			[global::Cpp2ILInjected.Token(Token = "0x4003B4B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
			public string largeImageKey;

			// Token: 0x04008123 RID: 33059
			[global::Cpp2ILInjected.Token(Token = "0x4003B4C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
			public string largeImageText;

			// Token: 0x04008124 RID: 33060
			[global::Cpp2ILInjected.Token(Token = "0x4003B4D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
			public string smallImageKey;

			// Token: 0x04008125 RID: 33061
			[global::Cpp2ILInjected.Token(Token = "0x4003B4E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
			public string smallImageText;

			// Token: 0x04008126 RID: 33062
			[global::Cpp2ILInjected.Token(Token = "0x4003B4F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
			public string partyId;

			// Token: 0x04008127 RID: 33063
			[global::Cpp2ILInjected.Token(Token = "0x4003B50")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
			public int partySize;

			// Token: 0x04008128 RID: 33064
			[global::Cpp2ILInjected.Token(Token = "0x4003B51")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
			public int partyMax;

			// Token: 0x04008129 RID: 33065
			[global::Cpp2ILInjected.Token(Token = "0x4003B52")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
			public string matchSecret;

			// Token: 0x0400812A RID: 33066
			[global::Cpp2ILInjected.Token(Token = "0x4003B53")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
			public string joinSecret;

			// Token: 0x0400812B RID: 33067
			[global::Cpp2ILInjected.Token(Token = "0x4003B54")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
			public string spectateSecret;

			// Token: 0x0400812C RID: 33068
			[global::Cpp2ILInjected.Token(Token = "0x4003B55")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
			public bool instance;
		}
	}
}
