using System;
using System.IO;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.Authenticode
{
	// Token: 0x02000041 RID: 65
	[global::Cpp2ILInjected.Token(Token = "0x200005F")]
	public class AuthenticodeBase
	{
		// Token: 0x06000224 RID: 548 RVA: 0x00003588 File Offset: 0x00001788
		[global::Cpp2ILInjected.Token(Token = "0x6000296")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA273C", Offset = "0x1AA273C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public AuthenticodeBase()
		{
			throw null;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000225 RID: 549 RVA: 0x0000358B File Offset: 0x0000178B
		[global::Cpp2ILInjected.Token(Token = "0x170000BC")]
		internal int PEOffset
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000297")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AA2798", Offset = "0x1AA2798", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticodeBase), Member = "ReadFirstBlock", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000358E File Offset: 0x0000178E
		[global::Cpp2ILInjected.Token(Token = "0x6000298")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA287C", Offset = "0x1AA287C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void Open(string filename)
		{
			throw null;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00003591 File Offset: 0x00001791
		[global::Cpp2ILInjected.Token(Token = "0x6000299")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA2934", Offset = "0x1AA2934", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void Open(byte[] rawdata)
		{
			throw null;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00003594 File Offset: 0x00001794
		[global::Cpp2ILInjected.Token(Token = "0x600029A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA2908", Offset = "0x1AA2908", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal void Close()
		{
			throw null;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00003597 File Offset: 0x00001797
		[global::Cpp2ILInjected.Token(Token = "0x600029B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA27C0", Offset = "0x1AA27C0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeBase), Member = "get_PEOffset", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeBase), Member = "GetSecurityEntry", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeBase), Member = "GetHash", MemberParameters = new object[] { typeof(HashAlgorithm) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticodeBase), Member = "ProcessFirstBlock", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Locale), Member = "GetText", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void ReadFirstBlock()
		{
			throw null;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000359A File Offset: 0x0000179A
		[global::Cpp2ILInjected.Token(Token = "0x600029C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA29B8", Offset = "0x1AA29B8", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeBase), Member = "ReadFirstBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Locale), Member = "GetText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal int ProcessFirstBlock()
		{
			throw null;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000359D File Offset: 0x0000179D
		[global::Cpp2ILInjected.Token(Token = "0x600029D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA2BC8", Offset = "0x1AA2BC8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticodeBase), Member = "ReadFirstBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal byte[] GetSecurityEntry()
		{
			throw null;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000035A0 File Offset: 0x000017A0
		[global::Cpp2ILInjected.Token(Token = "0x600029E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AA2C84", Offset = "0x1AA2C84", Length = "0x3DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AuthenticodeBase), Member = "ReadFirstBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "TransformBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "TransformFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal byte[] GetHash(HashAlgorithm hash)
		{
			throw null;
		}

		// Token: 0x04000245 RID: 581
		[global::Cpp2ILInjected.Token(Token = "0x400027A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private byte[] fileblock;

		// Token: 0x04000246 RID: 582
		[global::Cpp2ILInjected.Token(Token = "0x400027B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Stream fs;

		// Token: 0x04000247 RID: 583
		[global::Cpp2ILInjected.Token(Token = "0x400027C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int blockNo;

		// Token: 0x04000248 RID: 584
		[global::Cpp2ILInjected.Token(Token = "0x400027D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int blockLength;

		// Token: 0x04000249 RID: 585
		[global::Cpp2ILInjected.Token(Token = "0x400027E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int peOffset;

		// Token: 0x0400024A RID: 586
		[global::Cpp2ILInjected.Token(Token = "0x400027F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private int dirSecurityOffset;

		// Token: 0x0400024B RID: 587
		[global::Cpp2ILInjected.Token(Token = "0x4000280")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int dirSecuritySize;

		// Token: 0x0400024C RID: 588
		[global::Cpp2ILInjected.Token(Token = "0x4000281")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int coffSymbolTableOffset;

		// Token: 0x0400024D RID: 589
		[global::Cpp2ILInjected.Token(Token = "0x4000282")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool pe64;
	}
}
