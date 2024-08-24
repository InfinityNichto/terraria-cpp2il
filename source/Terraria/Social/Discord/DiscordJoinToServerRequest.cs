using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Social.Base;

namespace Terraria.Social.Discord
{
	// Token: 0x0200038A RID: 906
	[global::Cpp2ILInjected.Token(Token = "0x2000525")]
	public class DiscordJoinToServerRequest : UserJoinToServerRequest, IEquatable<DiscordJoinToServerRequest>
	{
		// Token: 0x06002D50 RID: 11600 RVA: 0x0002A1FA File Offset: 0x000283FA
		[global::Cpp2ILInjected.Token(Token = "0x60031A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1329E2C", Offset = "0x1329E2C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JoinRequestSocialModule), Member = "ReceiveJoinRequest", MemberParameters = new object[] { typeof(ref DiscordRpc.DiscordUser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public DiscordJoinToServerRequest(string userDisplayName, string fullIdentifier, int durationInSeconds = 30)
		{
			throw null;
		}

		// Token: 0x06002D51 RID: 11601 RVA: 0x0002A1FD File Offset: 0x000283FD
		[global::Cpp2ILInjected.Token(Token = "0x60031AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A2DC", Offset = "0x132A2DC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "Compare", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsValid()
		{
			throw null;
		}

		// Token: 0x06002D52 RID: 11602 RVA: 0x0002A200 File Offset: 0x00028400
		[global::Cpp2ILInjected.Token(Token = "0x60031AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A350", Offset = "0x132A350", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "Subtract", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_Seconds", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override string GetUserWrapperText()
		{
			throw null;
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x0002A203 File Offset: 0x00028403
		[global::Cpp2ILInjected.Token(Token = "0x60031AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x132A42C", Offset = "0x132A42C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public bool Equals(DiscordJoinToServerRequest other)
		{
			throw null;
		}

		// Token: 0x040031CD RID: 12749
		[global::Cpp2ILInjected.Token(Token = "0x4003B58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private DateTime _expirationTime;
	}
}
