using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Social.Base;

namespace Terraria.Social
{
	[global::Cpp2ILInjected.Token(Token = "0x2000510")]
	public static class SocialAPI
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000627")]
		public static SocialMode Mode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003145")]
			[global::Cpp2ILInjected.Address(RVA = "0x1303CFC", Offset = "0x1303CFC", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003146")]
		[global::Cpp2ILInjected.Address(RVA = "0x1303D44", Offset = "0x1303D44", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = "UnityStart", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "LaunchGame", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerJoinRequestsManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "add_OnTickForInternalCodeOnly", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public static void Initialize(SocialMode? mode = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003147")]
		[global::Cpp2ILInjected.Address(RVA = "0x13040A0", Offset = "0x13040A0", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "startDedInputCallBack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "QuitGame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Reverse", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void Shutdown()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003148")]
		[global::Cpp2ILInjected.Address(RVA = "0x159D5C4", Offset = "0x159D5C4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static T LoadModule<T>() where T : ISocialModule, new()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003149")]
		[global::Cpp2ILInjected.Address(RVA = "0x159D698", Offset = "0x159D698", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static T LoadModule<T>(T module) where T : ISocialModule
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600314A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304278", Offset = "0x1304278", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void LoadDiscord()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600314B")]
		[global::Cpp2ILInjected.Address(RVA = "0x130409C", Offset = "0x130409C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void LoadSteam()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4003B08")]
		private static SocialMode _mode;

		[global::Cpp2ILInjected.Token(Token = "0x4003B09")]
		public static FriendsSocialModule Friends;

		[global::Cpp2ILInjected.Token(Token = "0x4003B0A")]
		public static AchievementsSocialModule Achievements;

		[global::Cpp2ILInjected.Token(Token = "0x4003B0B")]
		public static CloudSocialModule Cloud;

		[global::Cpp2ILInjected.Token(Token = "0x4003B0C")]
		public static NetSocialModule Network;

		[global::Cpp2ILInjected.Token(Token = "0x4003B0D")]
		public static OverlaySocialModule Overlay;

		[global::Cpp2ILInjected.Token(Token = "0x4003B0E")]
		public static ServerJoinRequestsManager JoinRequests;

		[global::Cpp2ILInjected.Token(Token = "0x4003B0F")]
		public static PlatformSocialModule Platform;

		[global::Cpp2ILInjected.Token(Token = "0x4003B10")]
		private static List<ISocialModule> _modules;
	}
}
