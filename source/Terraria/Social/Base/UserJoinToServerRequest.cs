using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Discord;
using Terraria.UI;

namespace Terraria.Social.Base
{
	[global::Cpp2ILInjected.Token(Token = "0x2000533")]
	public abstract class UserJoinToServerRequest
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6003209")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A2B0", Offset = "0x132A2B0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public UserJoinToServerRequest(string userDisplayName, string fullIdentifier)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600320A")]
		[global::Cpp2ILInjected.Address(RVA = "0x132B5EC", Offset = "0x132B5EC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "OnMouseOver", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Accept()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600320B")]
		[global::Cpp2ILInjected.Address(RVA = "0x132B608", Offset = "0x132B608", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InGamePopups.PlayerWantsToJoinGamePopup), Member = "OnMouseOver", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Reject()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600320C")]
		public abstract bool IsValid();

		[global::Cpp2ILInjected.Token(Token = "0x600320D")]
		public abstract string GetUserWrapperText();

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003B6C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string <UserDisplayName>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003B6D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string <UserFullIdentifier>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003B6E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Action OnAccepted;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003B6F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Action OnRejected;
	}
}
