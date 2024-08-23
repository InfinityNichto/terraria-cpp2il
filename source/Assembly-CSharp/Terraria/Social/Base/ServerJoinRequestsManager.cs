using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Discord;
using Terraria.UI;

namespace Terraria.Social.Base
{
	// Token: 0x02000395 RID: 917
	[global::Cpp2ILInjected.Token(Token = "0x2000531")]
	public class ServerJoinRequestsManager
	{
		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06002D9C RID: 11676 RVA: 0x0002A251 File Offset: 0x00028451
		// (remove) Token: 0x06002D9D RID: 11677 RVA: 0x0002A254 File Offset: 0x00028454
		[global::Cpp2ILInjected.Token(Token = "0x1400002F")]
		public event ServerJoinRequestEvent OnRequestAdded
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60031F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x132AF5C", Offset = "0x132AF5C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGameNotificationsTracker), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60031F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x132AFF8", Offset = "0x132AFF8", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06002D9E RID: 11678 RVA: 0x0002A257 File Offset: 0x00028457
		// (remove) Token: 0x06002D9F RID: 11679 RVA: 0x0002A25A File Offset: 0x0002845A
		[global::Cpp2ILInjected.Token(Token = "0x14000030")]
		public event ServerJoinRequestEvent OnRequestRemoved
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60031F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x132B094", Offset = "0x132B094", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGameNotificationsTracker), Member = "Initialize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60031F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x132B130", Offset = "0x132B130", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x0002A25D File Offset: 0x0002845D
		[global::Cpp2ILInjected.Token(Token = "0x60031F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x132B1CC", Offset = "0x132B1CC", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SocialAPI), Member = "Initialize", MemberParameters = new object[] { typeof(SocialMode?) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IList<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public ServerJoinRequestsManager()
		{
			throw null;
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x0002A260 File Offset: 0x00028460
		[global::Cpp2ILInjected.Token(Token = "0x60031FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x132B298", Offset = "0x132B298", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerJoinRequestsManager), Member = "RemoveRequestAtIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x0002A263 File Offset: 0x00028463
		[global::Cpp2ILInjected.Token(Token = "0x60031FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A004", Offset = "0x132A004", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JoinRequestSocialModule), Member = "ReceiveJoinRequest", MemberParameters = new object[] { typeof(ref DiscordRpc.DiscordUser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerJoinRequestsManager), Member = "RemoveRequestAtIndex", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserJoinToServerRequest), Member = "add_OnAccepted", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserJoinToServerRequest), Member = "add_OnRejected", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Add(UserJoinToServerRequest request)
		{
			throw null;
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x0002A266 File Offset: 0x00028466
		[global::Cpp2ILInjected.Token(Token = "0x60031FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x132B33C", Offset = "0x132B33C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerJoinRequestsManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerJoinRequestsManager), Member = "Add", MemberParameters = new object[] { typeof(UserJoinToServerRequest) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void RemoveRequestAtIndex(int i)
		{
			throw null;
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x0002A269 File Offset: 0x00028469
		[global::Cpp2ILInjected.Token(Token = "0x60031FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x132B3F4", Offset = "0x132B3F4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerJoinRequestsManager.<>c__DisplayClass10_0), Member = "<Add>b__0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerJoinRequestsManager.<>c__DisplayClass10_0), Member = "<Add>b__1", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void RemoveRequest(UserJoinToServerRequest request)
		{
			throw null;
		}

		// Token: 0x040031D5 RID: 12757
		[global::Cpp2ILInjected.Token(Token = "0x4003B66")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly List<UserJoinToServerRequest> _requests;

		// Token: 0x040031D6 RID: 12758
		[global::Cpp2ILInjected.Token(Token = "0x4003B67")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly ReadOnlyCollection<UserJoinToServerRequest> CurrentRequests;

		// Token: 0x040031D7 RID: 12759
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003B68")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ServerJoinRequestEvent OnRequestAdded;

		// Token: 0x040031D8 RID: 12760
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003B69")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ServerJoinRequestEvent OnRequestRemoved;

		// Token: 0x020008EC RID: 2284
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000532")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06004C04 RID: 19460 RVA: 0x0002F741 File Offset: 0x0002D941
			[global::Cpp2ILInjected.Token(Token = "0x60031FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x132B3EC", Offset = "0x132B3EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass10_0()
			{
				throw null;
			}

			// Token: 0x06004C05 RID: 19461 RVA: 0x0002F744 File Offset: 0x0002D944
			[global::Cpp2ILInjected.Token(Token = "0x60031FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x132B47C", Offset = "0x132B47C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerJoinRequestsManager), Member = "RemoveRequest", MemberParameters = new object[] { typeof(UserJoinToServerRequest) }, ReturnType = typeof(void))]
			internal void <Add>b__0()
			{
				throw null;
			}

			// Token: 0x06004C06 RID: 19462 RVA: 0x0002F747 File Offset: 0x0002D947
			[global::Cpp2ILInjected.Token(Token = "0x6003200")]
			[global::Cpp2ILInjected.Address(RVA = "0x132B488", Offset = "0x132B488", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServerJoinRequestsManager), Member = "RemoveRequest", MemberParameters = new object[] { typeof(UserJoinToServerRequest) }, ReturnType = typeof(void))]
			internal void <Add>b__1()
			{
				throw null;
			}

			// Token: 0x04008134 RID: 33076
			[global::Cpp2ILInjected.Token(Token = "0x4003B6A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public ServerJoinRequestsManager <>4__this;

			// Token: 0x04008135 RID: 33077
			[global::Cpp2ILInjected.Token(Token = "0x4003B6B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public UserJoinToServerRequest request;
		}
	}
}
