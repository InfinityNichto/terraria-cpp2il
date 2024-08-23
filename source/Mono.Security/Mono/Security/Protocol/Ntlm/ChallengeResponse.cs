using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace Mono.Security.Protocol.Ntlm
{
	// Token: 0x0200001E RID: 30
	[Obsolete("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
	[global::Cpp2ILInjected.Token(Token = "0x2000039")]
	public class ChallengeResponse : IDisposable
	{
		// Token: 0x0600015A RID: 346 RVA: 0x0000334E File Offset: 0x0000154E
		[global::Cpp2ILInjected.Token(Token = "0x60001B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A97A7C", Offset = "0x1A97A7C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChallengeResponse), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ChallengeResponse()
		{
			throw null;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00003351 File Offset: 0x00001551
		[global::Cpp2ILInjected.Token(Token = "0x60001B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A97AEC", Offset = "0x1A97AEC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type3Message), Member = "GetBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChallengeResponse), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChallengeResponse), Member = "set_Password", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChallengeResponse), Member = "set_Challenge", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		public ChallengeResponse(string password, byte[] challenge)
		{
			throw null;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00003354 File Offset: 0x00001554
		[global::Cpp2ILInjected.Token(Token = "0x60001B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9803C", Offset = "0x1A9803C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChallengeResponse), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x17000064 RID: 100
		// (set) Token: 0x0600015D RID: 349 RVA: 0x00003357 File Offset: 0x00001557
		[global::Cpp2ILInjected.Token(Token = "0x1700007F")]
		public string Password
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A97B24", Offset = "0x1A97B24", Length = "0x3EC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChallengeResponse), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(byte[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DES), Member = "Create", ReturnType = typeof(DES))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChallengeResponse), Member = "PasswordToKey", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD4), Member = "Create", ReturnType = typeof(MD4))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "ComputeHash", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SymmetricAlgorithm), Member = "Clear", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0000335A File Offset: 0x0000155A
		[global::Cpp2ILInjected.Token(Token = "0x17000080")]
		public byte[] Challenge
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A97F10", Offset = "0x1A97F10", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChallengeResponse), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(byte[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0000335D File Offset: 0x0000155D
		[global::Cpp2ILInjected.Token(Token = "0x17000081")]
		public byte[] LM
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A982C8", Offset = "0x1A982C8", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type3Message), Member = "GetBytes", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00003360 File Offset: 0x00001560
		[global::Cpp2ILInjected.Token(Token = "0x17000082")]
		public byte[] NT
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A985FC", Offset = "0x1A985FC", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Type3Message), Member = "GetBytes", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChallengeResponse), Member = "GetResponse", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00003363 File Offset: 0x00001563
		[global::Cpp2ILInjected.Token(Token = "0x60001B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A980DC", Offset = "0x1A980DC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChallengeResponse), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChallengeResponse), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00003366 File Offset: 0x00001566
		[global::Cpp2ILInjected.Token(Token = "0x60001B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A9865C", Offset = "0x1A9865C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChallengeResponse), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00003369 File Offset: 0x00001569
		[global::Cpp2ILInjected.Token(Token = "0x60001B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A98328", Offset = "0x1A98328", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChallengeResponse), Member = "get_NT", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DES), Member = "Create", ReturnType = typeof(DES))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChallengeResponse), Member = "PrepareDESKey", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private byte[] GetResponse(byte[] pwd)
		{
			throw null;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000336C File Offset: 0x0000156C
		[global::Cpp2ILInjected.Token(Token = "0x60001BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A986BC", Offset = "0x1A986BC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChallengeResponse), Member = "GetResponse", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChallengeResponse), Member = "PasswordToKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private byte[] PrepareDESKey(byte[] key56bits, int position)
		{
			throw null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000336F File Offset: 0x0000156F
		[global::Cpp2ILInjected.Token(Token = "0x60001BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A98140", Offset = "0x1A98140", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChallengeResponse), Member = "set_Password", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpper", MemberParameters = new object[] { typeof(CultureInfo) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChallengeResponse), Member = "PrepareDESKey", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private byte[] PasswordToKey(string password, int position)
		{
			throw null;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00003372 File Offset: 0x00001572
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60001BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A987BC", Offset = "0x1A987BC", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static ChallengeResponse()
		{
			throw null;
		}

		// Token: 0x040000A0 RID: 160
		[global::Cpp2ILInjected.Token(Token = "0x40000CD")]
		private static byte[] magic;

		// Token: 0x040000A1 RID: 161
		[global::Cpp2ILInjected.Token(Token = "0x40000CE")]
		private static byte[] nullEncMagic;

		// Token: 0x040000A2 RID: 162
		[global::Cpp2ILInjected.Token(Token = "0x40000CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _disposed;

		// Token: 0x040000A3 RID: 163
		[global::Cpp2ILInjected.Token(Token = "0x40000D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private byte[] _challenge;

		// Token: 0x040000A4 RID: 164
		[global::Cpp2ILInjected.Token(Token = "0x40000D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private byte[] _lmpwd;

		// Token: 0x040000A5 RID: 165
		[global::Cpp2ILInjected.Token(Token = "0x40000D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] _ntpwd;
	}
}
