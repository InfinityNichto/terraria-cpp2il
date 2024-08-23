using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x0200025D RID: 605
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002FA")]
	public class SHA1Managed : SHA1
	{
		// Token: 0x060017B3 RID: 6067 RVA: 0x000187A9 File Offset: 0x000169A9
		[global::Cpp2ILInjected.Token(Token = "0x60019CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D5A8", Offset = "0x1B0D5A8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACSHA1), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public SHA1Managed()
		{
			throw null;
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x000187AC File Offset: 0x000169AC
		[global::Cpp2ILInjected.Token(Token = "0x60019CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D6B8", Offset = "0x1B0D6B8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void Initialize()
		{
			throw null;
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x000187AF File Offset: 0x000169AF
		[global::Cpp2ILInjected.Token(Token = "0x60019CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D70C", Offset = "0x1B0D70C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			throw null;
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x000187B2 File Offset: 0x000169B2
		[global::Cpp2ILInjected.Token(Token = "0x60019D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D88C", Offset = "0x1B0D88C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override byte[] HashFinal()
		{
			throw null;
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x000187B5 File Offset: 0x000169B5
		[global::Cpp2ILInjected.Token(Token = "0x60019D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D694", Offset = "0x1B0D694", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void InitializeState()
		{
			throw null;
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x000187B8 File Offset: 0x000169B8
		[global::Cpp2ILInjected.Token(Token = "0x60019D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D710", Offset = "0x1B0D710", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1Managed), Member = "_EndHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(uint*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		private unsafe void _HashData(byte[] partIn, int ibStart, int cbSize)
		{
			throw null;
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x000187BB File Offset: 0x000169BB
		[global::Cpp2ILInjected.Token(Token = "0x60019D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D890", Offset = "0x1B0D890", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Managed), Member = "_HashData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DWORDToBigEndian", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(uint[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private byte[] _EndHash()
		{
			throw null;
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x000187BE File Offset: 0x000169BE
		[global::Cpp2ILInjected.Token(Token = "0x60019D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0D9B4", Offset = "0x1B0D9B4", Length = "0x434")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1Managed), Member = "_HashData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DWORDFromBigEndian", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(int),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SHA1Managed), Member = "SHAExpand", MemberParameters = new object[] { typeof(uint*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static void SHATransform(uint* expandedBuffer, uint* state, byte* block)
		{
			throw null;
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x000187C1 File Offset: 0x000169C1
		[global::Cpp2ILInjected.Token(Token = "0x60019D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0DE94", Offset = "0x1B0DE94", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SHA1Managed), Member = "SHATransform", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(uint*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private unsafe static void SHAExpand(uint* x)
		{
			throw null;
		}

		// Token: 0x04000A39 RID: 2617
		[global::Cpp2ILInjected.Token(Token = "0x4000D13")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] _buffer;

		// Token: 0x04000A3A RID: 2618
		[global::Cpp2ILInjected.Token(Token = "0x4000D14")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private long _count;

		// Token: 0x04000A3B RID: 2619
		[global::Cpp2ILInjected.Token(Token = "0x4000D15")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private uint[] _stateSHA1;

		// Token: 0x04000A3C RID: 2620
		[global::Cpp2ILInjected.Token(Token = "0x4000D16")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private uint[] _expandedBuffer;
	}
}
