using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000254 RID: 596
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002F1")]
	public class RIPEMD160Managed : RIPEMD160
	{
		// Token: 0x06001729 RID: 5929 RVA: 0x00018611 File Offset: 0x00016811
		[global::Cpp2ILInjected.Token(Token = "0x6001943")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFE81C", Offset = "0x1AFE81C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HMACRIPEMD160), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RIPEMD160), Member = "Create", ReturnType = typeof(RIPEMD160))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CryptoConfig), Member = "CreateFromName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CryptoConfig), Member = "get_AllowOnlyFipsAlgorithms", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public RIPEMD160Managed()
		{
			throw null;
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00018614 File Offset: 0x00016814
		[global::Cpp2ILInjected.Token(Token = "0x6001944")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B05630", Offset = "0x1B05630", Length = "0x54")]
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

		// Token: 0x0600172B RID: 5931 RVA: 0x00018617 File Offset: 0x00016817
		[global::Cpp2ILInjected.Token(Token = "0x6001945")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B05684", Offset = "0x1B05684", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void HashCore(byte[] rgb, int ibStart, int cbSize)
		{
			throw null;
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x0001861A File Offset: 0x0001681A
		[global::Cpp2ILInjected.Token(Token = "0x6001946")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B05804", Offset = "0x1B05804", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override byte[] HashFinal()
		{
			throw null;
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x0001861D File Offset: 0x0001681D
		[global::Cpp2ILInjected.Token(Token = "0x6001947")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0560C", Offset = "0x1B0560C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void InitializeState()
		{
			throw null;
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00018620 File Offset: 0x00016820
		[global::Cpp2ILInjected.Token(Token = "0x6001948")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B05688", Offset = "0x1B05688", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RIPEMD160Managed), Member = "_EndHash", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RIPEMD160Managed), Member = "MDTransform", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(uint*),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		private unsafe void _HashData(byte[] partIn, int ibStart, int cbSize)
		{
			throw null;
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00018623 File Offset: 0x00016823
		[global::Cpp2ILInjected.Token(Token = "0x6001949")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B05808", Offset = "0x1B05808", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RIPEMD160Managed), Member = "_HashData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DWORDToLittleEndian", MemberParameters = new object[]
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

		// Token: 0x06001730 RID: 5936 RVA: 0x00018626 File Offset: 0x00016826
		[global::Cpp2ILInjected.Token(Token = "0x600194A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B05930", Offset = "0x1B05930", Length = "0x1740")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RIPEMD160Managed), Member = "_HashData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "DWORDFromLittleEndian", MemberParameters = new object[]
		{
			typeof(uint*),
			typeof(int),
			typeof(byte*)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static void MDTransform(uint* blockDWords, uint* state, byte* block)
		{
			throw null;
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00018629 File Offset: 0x00016829
		[global::Cpp2ILInjected.Token(Token = "0x600194B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B07070", Offset = "0x1B07070", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint F(uint x, uint y, uint z)
		{
			throw null;
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x0001862C File Offset: 0x0001682C
		[global::Cpp2ILInjected.Token(Token = "0x600194C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0707C", Offset = "0x1B0707C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint G(uint x, uint y, uint z)
		{
			throw null;
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x0001862F File Offset: 0x0001682F
		[global::Cpp2ILInjected.Token(Token = "0x600194D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B0708C", Offset = "0x1B0708C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint H(uint x, uint y, uint z)
		{
			throw null;
		}

		// Token: 0x06001734 RID: 5940 RVA: 0x00018632 File Offset: 0x00016832
		[global::Cpp2ILInjected.Token(Token = "0x600194E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B07098", Offset = "0x1B07098", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint I(uint x, uint y, uint z)
		{
			throw null;
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x00018635 File Offset: 0x00016835
		[global::Cpp2ILInjected.Token(Token = "0x600194F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B070A8", Offset = "0x1B070A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static uint J(uint x, uint y, uint z)
		{
			throw null;
		}

		// Token: 0x04000A17 RID: 2583
		[global::Cpp2ILInjected.Token(Token = "0x4000CF1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] _buffer;

		// Token: 0x04000A18 RID: 2584
		[global::Cpp2ILInjected.Token(Token = "0x4000CF2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private long _count;

		// Token: 0x04000A19 RID: 2585
		[global::Cpp2ILInjected.Token(Token = "0x4000CF3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private uint[] _stateMD160;

		// Token: 0x04000A1A RID: 2586
		[global::Cpp2ILInjected.Token(Token = "0x4000CF4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private uint[] _blockDWords;
	}
}
