using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000276 RID: 630
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000313")]
	public sealed class MD5CryptoServiceProvider : MD5
	{
		// Token: 0x060018A0 RID: 6304 RVA: 0x00018A64 File Offset: 0x00016C64
		[global::Cpp2ILInjected.Token(Token = "0x6001ABA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B14F20", Offset = "0x1B14F20", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACMD5), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD5), Member = "Create", ReturnType = typeof(MD5))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD5), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public MD5CryptoServiceProvider()
		{
			throw null;
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00018A67 File Offset: 0x00016C67
		[global::Cpp2ILInjected.Token(Token = "0x6001ABB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B18008", Offset = "0x1B18008", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00018A6A File Offset: 0x00016C6A
		[global::Cpp2ILInjected.Token(Token = "0x6001ABC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B180AC", Offset = "0x1B180AC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashAlgorithm), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00018A6D File Offset: 0x00016C6D
		[global::Cpp2ILInjected.Token(Token = "0x6001ABD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1811C", Offset = "0x1B1811C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD5CryptoServiceProvider), Member = "ProcessBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			throw null;
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00018A70 File Offset: 0x00016C70
		[global::Cpp2ILInjected.Token(Token = "0x6001ABE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B18CD8", Offset = "0x1B18CD8", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD5CryptoServiceProvider), Member = "ProcessFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override byte[] HashFinal()
		{
			throw null;
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00018A73 File Offset: 0x00016C73
		[global::Cpp2ILInjected.Token(Token = "0x6001ABF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B18ED0", Offset = "0x1B18ED0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Initialize()
		{
			throw null;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00018A76 File Offset: 0x00016C76
		[global::Cpp2ILInjected.Token(Token = "0x6001AC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B1821C", Offset = "0x1B1821C", Length = "0xABC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD5CryptoServiceProvider), Member = "HashCore", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD5CryptoServiceProvider), Member = "ProcessFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ProcessBlock(byte[] inputBuffer, int inputOffset)
		{
			throw null;
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00018A79 File Offset: 0x00016C79
		[global::Cpp2ILInjected.Token(Token = "0x6001AC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B18D80", Offset = "0x1B18D80", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD5CryptoServiceProvider), Member = "HashFinal", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD5CryptoServiceProvider), Member = "AddLength", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MD5CryptoServiceProvider), Member = "ProcessBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			throw null;
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00018A7C File Offset: 0x00016C7C
		[global::Cpp2ILInjected.Token(Token = "0x6001AC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B18EEC", Offset = "0x1B18EEC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MD5CryptoServiceProvider), Member = "ProcessFinalBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void AddLength(ulong length, byte[] buffer, int position)
		{
			throw null;
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x00018A7F File Offset: 0x00016C7F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001AC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B18F4C", Offset = "0x1B18F4C", Length = "0x1094")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static MD5CryptoServiceProvider()
		{
			throw null;
		}

		// Token: 0x04000AC0 RID: 2752
		[global::Cpp2ILInjected.Token(Token = "0x4000D9A")]
		private const int BLOCK_SIZE_BYTES = 64;

		// Token: 0x04000AC1 RID: 2753
		[global::Cpp2ILInjected.Token(Token = "0x4000D9B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private uint[] _H;

		// Token: 0x04000AC2 RID: 2754
		[global::Cpp2ILInjected.Token(Token = "0x4000D9C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private uint[] buff;

		// Token: 0x04000AC3 RID: 2755
		[global::Cpp2ILInjected.Token(Token = "0x4000D9D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ulong count;

		// Token: 0x04000AC4 RID: 2756
		[global::Cpp2ILInjected.Token(Token = "0x4000D9E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private byte[] _ProcessingBuffer;

		// Token: 0x04000AC5 RID: 2757
		[global::Cpp2ILInjected.Token(Token = "0x4000D9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int _ProcessingBufferCount;

		// Token: 0x04000AC6 RID: 2758
		[global::Cpp2ILInjected.Token(Token = "0x4000DA0")]
		private static readonly uint[] K;
	}
}
