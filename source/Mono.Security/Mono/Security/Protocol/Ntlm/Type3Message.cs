using System;
using System.Net;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000026 RID: 38
	[global::Cpp2ILInjected.Token(Token = "0x2000041")]
	public class Type3Message : MessageBase
	{
		// Token: 0x06000188 RID: 392 RVA: 0x000033D5 File Offset: 0x000015D5
		[global::Cpp2ILInjected.Token(Token = "0x60001DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9A71C", Offset = "0x1A9A71C", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type2Message), Member = "get_Nonce", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_MachineName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Environment), Member = "get_UserName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public Type3Message(Type2Message type2)
		{
			throw null;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000033D8 File Offset: 0x000015D8
		[global::Cpp2ILInjected.Token(Token = "0x60001DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9A8FC", Offset = "0x1A9A8FC", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x17000070 RID: 112
		// (set) Token: 0x0600018A RID: 394 RVA: 0x000033DB File Offset: 0x000015DB
		[global::Cpp2ILInjected.Token(Token = "0x1700008B")]
		public string Domain
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9A9DC", Offset = "0x1A9A9DC", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebRequest),
				typeof(ICredentials)
			}, ReturnType = typeof(Authorization))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000071 RID: 113
		// (set) Token: 0x0600018B RID: 395 RVA: 0x000033DE File Offset: 0x000015DE
		[global::Cpp2ILInjected.Token(Token = "0x1700008C")]
		public string Password
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9AA5C", Offset = "0x1A9AA5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000072 RID: 114
		// (set) Token: 0x0600018C RID: 396 RVA: 0x000033E1 File Offset: 0x000015E1
		[global::Cpp2ILInjected.Token(Token = "0x1700008D")]
		public string Username
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9AA64", Offset = "0x1A9AA64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000033E4 File Offset: 0x000015E4
		[global::Cpp2ILInjected.Token(Token = "0x60001E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9AA6C", Offset = "0x1A9AA6C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageBase), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type3Message), Member = "DecodeString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void Decode(byte[] message)
		{
			throw null;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000033E7 File Offset: 0x000015E7
		[global::Cpp2ILInjected.Token(Token = "0x60001E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9AC54", Offset = "0x1A9AC54", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type3Message), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string DecodeString(byte[] buffer, int offset, int len)
		{
			throw null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000033EA File Offset: 0x000015EA
		[global::Cpp2ILInjected.Token(Token = "0x60001E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9ACA4", Offset = "0x1A9ACA4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type3Message), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private byte[] EncodeString(string text)
		{
			throw null;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000033ED File Offset: 0x000015ED
		[global::Cpp2ILInjected.Token(Token = "0x60001E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9AD2C", Offset = "0x1A9AD2C", Length = "0x4D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type3Message), Member = "EncodeString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChallengeResponse2), Member = "Compute", MemberParameters = new object[]
		{
			typeof(Type2Message),
			typeof(NtlmAuthLevel),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(ref byte[]),
			typeof(ref byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChallengeResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChallengeResponse), Member = "get_LM", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChallengeResponse), Member = "get_NT", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageBase), Member = "PrepareMessage", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public override byte[] GetBytes()
		{
			throw null;
		}

		// Token: 0x040000C1 RID: 193
		[global::Cpp2ILInjected.Token(Token = "0x40000EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private NtlmAuthLevel _level;

		// Token: 0x040000C2 RID: 194
		[global::Cpp2ILInjected.Token(Token = "0x40000EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private byte[] _challenge;

		// Token: 0x040000C3 RID: 195
		[global::Cpp2ILInjected.Token(Token = "0x40000F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _host;

		// Token: 0x040000C4 RID: 196
		[global::Cpp2ILInjected.Token(Token = "0x40000F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _domain;

		// Token: 0x040000C5 RID: 197
		[global::Cpp2ILInjected.Token(Token = "0x40000F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string _username;

		// Token: 0x040000C6 RID: 198
		[global::Cpp2ILInjected.Token(Token = "0x40000F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string _password;

		// Token: 0x040000C7 RID: 199
		[global::Cpp2ILInjected.Token(Token = "0x40000F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Type2Message _type2;

		// Token: 0x040000C8 RID: 200
		[global::Cpp2ILInjected.Token(Token = "0x40000F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private byte[] _lm;

		// Token: 0x040000C9 RID: 201
		[global::Cpp2ILInjected.Token(Token = "0x40000F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private byte[] _nt;
	}
}
