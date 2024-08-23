using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.BZip2
{
	// Token: 0x0200002D RID: 45
	[global::Cpp2ILInjected.Token(Token = "0x2000034")]
	internal class BitWriter
	{
		// Token: 0x0600028B RID: 651 RVA: 0x0000561A File Offset: 0x0000381A
		[global::Cpp2ILInjected.Token(Token = "0x600029F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A62618", Offset = "0x1A62618", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BitWriter(Stream s)
		{
			throw null;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000561D File Offset: 0x0000381D
		[global::Cpp2ILInjected.Token(Token = "0x170000B8")]
		public byte RemainingBits
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A62640", Offset = "0x1A62640", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00005620 File Offset: 0x00003820
		[global::Cpp2ILInjected.Token(Token = "0x170000B9")]
		public int NumRemainingBits
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A62650", Offset = "0x1A62650", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00005623 File Offset: 0x00003823
		[global::Cpp2ILInjected.Token(Token = "0x170000BA")]
		public int TotalBytesWrittenOut
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A62658", Offset = "0x1A62658", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00005626 File Offset: 0x00003826
		[global::Cpp2ILInjected.Token(Token = "0x60002A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A62660", Offset = "0x1A62660", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00005629 File Offset: 0x00003829
		[global::Cpp2ILInjected.Token(Token = "0x60002A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A626A8", Offset = "0x1A626A8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitWriter), Member = "WriteByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitWriter), Member = "WriteInt", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitWriter), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BitWriter), Member = "FinishAndPad", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "CompressAndWrite", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "sendMTFValues4", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "sendMTFValues5", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "sendMTFValues6", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "sendMTFValues7", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "moveToFrontCodeAndSend", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2OutputStream), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2OutputStream), Member = "EmitTrailer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 33)]
		public void WriteBits(int nbits, uint value)
		{
			throw null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000562C File Offset: 0x0000382C
		[global::Cpp2ILInjected.Token(Token = "0x60002A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A62734", Offset = "0x1A62734", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitWriter), Member = "WriteBits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint)
		}, ReturnType = typeof(void))]
		public void WriteByte(byte b)
		{
			throw null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000562F File Offset: 0x0000382F
		[global::Cpp2ILInjected.Token(Token = "0x60002A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A62740", Offset = "0x1A62740", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "CompressAndWrite", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2OutputStream), Member = "EmitTrailer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitWriter), Member = "WriteBits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint)
		}, ReturnType = typeof(void))]
		public void WriteInt(uint u)
		{
			throw null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00005632 File Offset: 0x00003832
		[global::Cpp2ILInjected.Token(Token = "0x60002A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A62794", Offset = "0x1A62794", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitWriter), Member = "WriteBits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint)
		}, ReturnType = typeof(void))]
		public void Flush()
		{
			throw null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00005635 File Offset: 0x00003835
		[global::Cpp2ILInjected.Token(Token = "0x60002A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A627A0", Offset = "0x1A627A0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2OutputStream), Member = "EmitTrailer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitWriter), Member = "WriteBits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint)
		}, ReturnType = typeof(void))]
		public void FinishAndPad()
		{
			throw null;
		}

		// Token: 0x04000137 RID: 311
		[global::Cpp2ILInjected.Token(Token = "0x400014B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private uint accumulator;

		// Token: 0x04000138 RID: 312
		[global::Cpp2ILInjected.Token(Token = "0x400014C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int nAccumulatedBits;

		// Token: 0x04000139 RID: 313
		[global::Cpp2ILInjected.Token(Token = "0x400014D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Stream output;

		// Token: 0x0400013A RID: 314
		[global::Cpp2ILInjected.Token(Token = "0x400014E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int totalBytesWrittenOut;
	}
}
