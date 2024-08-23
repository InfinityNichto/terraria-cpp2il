using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Discord;
using Terraria.UI;

namespace Terraria.Social.Base
{
	// Token: 0x02000396 RID: 918
	[global::Cpp2ILInjected.Token(Token = "0x2000533")]
	public abstract class UserJoinToServerRequest
	{
		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06002DA5 RID: 11685 RVA: 0x0002A26C File Offset: 0x0002846C
		// (set) Token: 0x06002DA6 RID: 11686 RVA: 0x0002A26F File Offset: 0x0002846F
		[global::Cpp2ILInjected.Token(Token = "0x17000628")]
		internal string UserDisplayName
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003201")]
			[global::Cpp2ILInjected.Address(RVA = "0x132B494", Offset = "0x132B494", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003202")]
			[global::Cpp2ILInjected.Address(RVA = "0x132B49C", Offset = "0x132B49C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06002DA7 RID: 11687 RVA: 0x0002A272 File Offset: 0x00028472
		// (set) Token: 0x06002DA8 RID: 11688 RVA: 0x0002A275 File Offset: 0x00028475
		[global::Cpp2ILInjected.Token(Token = "0x17000629")]
		internal string UserFullIdentifier
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003203")]
			[global::Cpp2ILInjected.Address(RVA = "0x132B4A4", Offset = "0x132B4A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003204")]
			[global::Cpp2ILInjected.Address(RVA = "0x132B4AC", Offset = "0x132B4AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06002DA9 RID: 11689 RVA: 0x0002A278 File Offset: 0x00028478
		// (remove) Token: 0x06002DAA RID: 11690 RVA: 0x0002A27B File Offset: 0x0002847B
		[global::Cpp2ILInjected.Token(Token = "0x14000031")]
		public event Action OnAccepted
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003205")]
			[global::Cpp2ILInjected.Address(RVA = "0x1329ECC", Offset = "0x1329ECC", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JoinRequestSocialModule), Member = "ReceiveJoinRequest", MemberParameters = new object[] { typeof(ref DiscordRpc.DiscordUser) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerJoinRequestsManager), Member = "Add", MemberParameters = new object[] { typeof(UserJoinToServerRequest) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003206")]
			[global::Cpp2ILInjected.Address(RVA = "0x132B4B4", Offset = "0x132B4B4", Length = "0x9C")]
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

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06002DAB RID: 11691 RVA: 0x0002A27E File Offset: 0x0002847E
		// (remove) Token: 0x06002DAC RID: 11692 RVA: 0x0002A281 File Offset: 0x00028481
		[global::Cpp2ILInjected.Token(Token = "0x14000032")]
		public event Action OnRejected
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6003207")]
			[global::Cpp2ILInjected.Address(RVA = "0x1329F68", Offset = "0x1329F68", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JoinRequestSocialModule), Member = "ReceiveJoinRequest", MemberParameters = new object[] { typeof(ref DiscordRpc.DiscordUser) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServerJoinRequestsManager), Member = "Add", MemberParameters = new object[] { typeof(UserJoinToServerRequest) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
			[global::Cpp2ILInjected.Token(Token = "0x6003208")]
			[global::Cpp2ILInjected.Address(RVA = "0x132B550", Offset = "0x132B550", Length = "0x9C")]
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

		// Token: 0x06002DAD RID: 11693 RVA: 0x0002A284 File Offset: 0x00028484
		[global::Cpp2ILInjected.Token(Token = "0x6003209")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A2B0", Offset = "0x132A2B0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public UserJoinToServerRequest(string userDisplayName, string fullIdentifier)
		{
			throw null;
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x0002A287 File Offset: 0x00028487
		[global::Cpp2ILInjected.Token(Token = "0x600320A")]
		[global::Cpp2ILInjected.Address(RVA = "0x132B5EC", Offset = "0x132B5EC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "OnMouseOver", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Accept()
		{
			throw null;
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x0002A28A File Offset: 0x0002848A
		[global::Cpp2ILInjected.Token(Token = "0x600320B")]
		[global::Cpp2ILInjected.Address(RVA = "0x132B608", Offset = "0x132B608", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "OnMouseOver", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Reject()
		{
			throw null;
		}

		// Token: 0x06002DB0 RID: 11696
		[global::Cpp2ILInjected.Token(Token = "0x600320C")]
		public abstract bool IsValid();

		// Token: 0x06002DB1 RID: 11697
		[global::Cpp2ILInjected.Token(Token = "0x600320D")]
		public abstract string GetUserWrapperText();

		// Token: 0x040031D9 RID: 12761
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003B6C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <UserDisplayName>k__BackingField;

		// Token: 0x040031DA RID: 12762
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003B6D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <UserFullIdentifier>k__BackingField;

		// Token: 0x040031DB RID: 12763
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003B6E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Action OnAccepted;

		// Token: 0x040031DC RID: 12764
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003B6F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Action OnRejected;
	}
}
