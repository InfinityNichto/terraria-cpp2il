using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Social.Base;

namespace Terraria.Social
{
	// Token: 0x02000381 RID: 897
	[global::Cpp2ILInjected.Token(Token = "0x2000510")]
	public static class SocialAPI
	{
		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06002D0C RID: 11532 RVA: 0x0002A143 File Offset: 0x00028343
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

		// Token: 0x06002D0D RID: 11533 RVA: 0x0002A146 File Offset: 0x00028346
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

		// Token: 0x06002D0E RID: 11534 RVA: 0x0002A149 File Offset: 0x00028349
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

		// Token: 0x06002D0F RID: 11535 RVA: 0x0002A14C File Offset: 0x0002834C
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

		// Token: 0x06002D10 RID: 11536 RVA: 0x0002A14F File Offset: 0x0002834F
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

		// Token: 0x06002D11 RID: 11537 RVA: 0x0002A152 File Offset: 0x00028352
		[global::Cpp2ILInjected.Token(Token = "0x600314A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304278", Offset = "0x1304278", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void LoadDiscord()
		{
			throw null;
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x0002A155 File Offset: 0x00028355
		[global::Cpp2ILInjected.Token(Token = "0x600314B")]
		[global::Cpp2ILInjected.Address(RVA = "0x130409C", Offset = "0x130409C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static void LoadSteam()
		{
			throw null;
		}

		// Token: 0x040031AC RID: 12716
		[global::Cpp2ILInjected.Token(Token = "0x4003B08")]
		private static SocialMode _mode;

		// Token: 0x040031AD RID: 12717
		[global::Cpp2ILInjected.Token(Token = "0x4003B09")]
		public static FriendsSocialModule Friends;

		// Token: 0x040031AE RID: 12718
		[global::Cpp2ILInjected.Token(Token = "0x4003B0A")]
		public static AchievementsSocialModule Achievements;

		// Token: 0x040031AF RID: 12719
		[global::Cpp2ILInjected.Token(Token = "0x4003B0B")]
		public static CloudSocialModule Cloud;

		// Token: 0x040031B0 RID: 12720
		[global::Cpp2ILInjected.Token(Token = "0x4003B0C")]
		public static NetSocialModule Network;

		// Token: 0x040031B1 RID: 12721
		[global::Cpp2ILInjected.Token(Token = "0x4003B0D")]
		public static OverlaySocialModule Overlay;

		// Token: 0x040031B2 RID: 12722
		[global::Cpp2ILInjected.Token(Token = "0x4003B0E")]
		public static ServerJoinRequestsManager JoinRequests;

		// Token: 0x040031B3 RID: 12723
		[global::Cpp2ILInjected.Token(Token = "0x4003B0F")]
		public static PlatformSocialModule Platform;

		// Token: 0x040031B4 RID: 12724
		[global::Cpp2ILInjected.Token(Token = "0x4003B10")]
		private static List<ISocialModule> _modules;
	}
}
