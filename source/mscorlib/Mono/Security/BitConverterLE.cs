using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace Mono.Security
{
	// Token: 0x0200002B RID: 43
	[global::Cpp2ILInjected.Token(Token = "0x2000041")]
	internal sealed class BitConverterLE
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00014834 File Offset: 0x00012A34
		[global::Cpp2ILInjected.Token(Token = "0x6000111")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB6950", Offset = "0x1AB6950", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitConverterLE), Member = "GetBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitConverterLE), Member = "GetBytes", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe static byte[] GetUIntBytes(byte* bytes)
		{
			throw null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00014837 File Offset: 0x00012A37
		[global::Cpp2ILInjected.Token(Token = "0x6000112")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB6A0C", Offset = "0x1AB6A0C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitConverterLE), Member = "GetBytes", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private unsafe static byte[] GetULongBytes(byte* bytes)
		{
			throw null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0001483A File Offset: 0x00012A3A
		[global::Cpp2ILInjected.Token(Token = "0x6000113")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB6B08", Offset = "0x1AB6B08", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "I2OSP", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "GetUIntBytes", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte[]))]
		internal unsafe static byte[] GetBytes(int value)
		{
			throw null;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0001483D File Offset: 0x00012A3D
		[global::Cpp2ILInjected.Token(Token = "0x6000114")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB6B20", Offset = "0x1AB6B20", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.BinaryWriter), Member = "Write", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "GetUIntBytes", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte[]))]
		internal unsafe static byte[] GetBytes(float value)
		{
			throw null;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00014840 File Offset: 0x00012A40
		[global::Cpp2ILInjected.Token(Token = "0x6000115")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB6B38", Offset = "0x1AB6B38", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.BinaryWriter), Member = "Write", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "GetULongBytes", MemberParameters = new object[] { typeof(byte*) }, ReturnType = typeof(byte[]))]
		internal unsafe static byte[] GetBytes(double value)
		{
			throw null;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00014843 File Offset: 0x00012A43
		[global::Cpp2ILInjected.Token(Token = "0x6000116")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB6B50", Offset = "0x1AB6B50", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitConverterLE), Member = "ToSingle", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static void UIntFromBytes(byte* dst, byte[] src, int startIndex)
		{
			throw null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00014846 File Offset: 0x00012A46
		[global::Cpp2ILInjected.Token(Token = "0x6000117")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB6C1C", Offset = "0x1AB6C1C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitConverterLE), Member = "ToDouble", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe static void ULongFromBytes(byte* dst, byte[] src, int startIndex)
		{
			throw null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00014849 File Offset: 0x00012A49
		[global::Cpp2ILInjected.Token(Token = "0x6000118")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB6CD8", Offset = "0x1AB6CD8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.BinaryReader), Member = "ReadSingle", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "UIntFromBytes", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal unsafe static float ToSingle(byte[] value, int startIndex)
		{
			throw null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0001484C File Offset: 0x00012A4C
		[global::Cpp2ILInjected.Token(Token = "0x6000119")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB6CFC", Offset = "0x1AB6CFC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.BinaryReader), Member = "ReadDouble", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverterLE), Member = "ULongFromBytes", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal unsafe static double ToDouble(byte[] value, int startIndex)
		{
			throw null;
		}
	}
}
