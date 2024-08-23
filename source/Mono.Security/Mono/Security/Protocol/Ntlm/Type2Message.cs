using System;
using System.Net;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x02000025 RID: 37
	[global::Cpp2ILInjected.Token(Token = "0x2000040")]
	public class Type2Message : MessageBase
	{
		// Token: 0x06000181 RID: 385 RVA: 0x000033C0 File Offset: 0x000015C0
		[global::Cpp2ILInjected.Token(Token = "0x60001D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9A3F0", Offset = "0x1A9A3F0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Http.NtlmSession", Member = "Authenticate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Type2Message(byte[] message)
		{
			throw null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000033C3 File Offset: 0x000015C3
		[global::Cpp2ILInjected.Token(Token = "0x60001D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9A494", Offset = "0x1A9A494", Length = "0xA8")]
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

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000033C6 File Offset: 0x000015C6
		[global::Cpp2ILInjected.Token(Token = "0x17000088")]
		public byte[] Nonce
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A99740", Offset = "0x1A99740", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2", MemberParameters = new object[]
			{
				typeof(Type2Message),
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute", MemberParameters = new object[]
			{
				typeof(Type2Message),
				typeof(NtlmAuthLevel),
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(ref byte[]),
				typeof(ref byte[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type3Message), Member = ".ctor", MemberParameters = new object[] { typeof(Type2Message) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000033C9 File Offset: 0x000015C9
		[global::Cpp2ILInjected.Token(Token = "0x17000089")]
		public string TargetName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A9A53C", Offset = "0x1A9A53C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000185 RID: 389 RVA: 0x000033CC File Offset: 0x000015CC
		[global::Cpp2ILInjected.Token(Token = "0x1700008A")]
		public byte[] TargetInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A996D0", Offset = "0x1A996D0", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChallengeResponse2), Member = "Compute_NTLMv2", MemberParameters = new object[]
			{
				typeof(Type2Message),
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000033CF File Offset: 0x000015CF
		[global::Cpp2ILInjected.Token(Token = "0x60001DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9A544", Offset = "0x1A9A544", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageBase), Member = "Decode", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void Decode(byte[] message)
		{
			throw null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000033D2 File Offset: 0x000015D2
		[global::Cpp2ILInjected.Token(Token = "0x60001DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9A6AC", Offset = "0x1A9A6AC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MessageBase), Member = "PrepareMessage", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override byte[] GetBytes()
		{
			throw null;
		}

		// Token: 0x040000BE RID: 190
		[global::Cpp2ILInjected.Token(Token = "0x40000EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private byte[] _nonce;

		// Token: 0x040000BF RID: 191
		[global::Cpp2ILInjected.Token(Token = "0x40000EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string _targetName;

		// Token: 0x040000C0 RID: 192
		[global::Cpp2ILInjected.Token(Token = "0x40000ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] _targetInfo;
	}
}
