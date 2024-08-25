using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Http;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000187")]
	public class Authorization
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08AF0", Offset = "0x1F08AF0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BasicClient), Member = "InternalAuthenticate", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "Authenticate", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "MakeStringNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Authorization(string token)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08B70", Offset = "0x1F08B70", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NtlmSession), Member = "Authenticate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebRequest),
			typeof(ICredentials)
		}, ReturnType = typeof(Authorization))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "MakeStringNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Authorization(string token, bool finished)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08BF0", Offset = "0x1F08BF0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Authorization(string token, bool finished, string connectionGroupId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08BFC", Offset = "0x1F08BFC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "MakeStringNull", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Authorization(string token, bool finished, string connectionGroupId, bool mutualAuth)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000207")]
		public string Message
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A15")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F08CA0", Offset = "0x1F08CA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000208")]
		public string ConnectionGroupId
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A16")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F08CA8", Offset = "0x1F08CA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000209")]
		public bool Complete
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A17")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F08CB0", Offset = "0x1F08CB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000A18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F08CB8", Offset = "0x1F08CB8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetComplete(bool complete)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700020A")]
		public string[] ProtectionRealm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A19")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F08CC4", Offset = "0x1F08CC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A1A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F08CCC", Offset = "0x1F08CCC", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "MakeEmptyArrayNull", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700020B")]
		public bool MutuallyAuthenticated
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F08D38", Offset = "0x1F08D38", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000A1C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F08D58", Offset = "0x1F08D58", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40007B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string m_Message;

		[global::Cpp2ILInjected.Token(Token = "0x40007B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool m_Complete;

		[global::Cpp2ILInjected.Token(Token = "0x40007B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string[] m_ProtectionRealm;

		[global::Cpp2ILInjected.Token(Token = "0x40007B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string m_ConnectionGroupId;

		[global::Cpp2ILInjected.Token(Token = "0x40007B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool m_MutualAuth;

		[global::Cpp2ILInjected.Token(Token = "0x40007B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal string ModuleAuthenticationType;
	}
}
