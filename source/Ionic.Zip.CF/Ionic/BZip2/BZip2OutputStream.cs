using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Zip;

namespace Ionic.BZip2
{
	// Token: 0x02000031 RID: 49
	[global::Cpp2ILInjected.Token(Token = "0x200003B")]
	public class BZip2OutputStream : Stream
	{
		// Token: 0x060002DF RID: 735 RVA: 0x00005716 File Offset: 0x00003916
		[global::Cpp2ILInjected.Token(Token = "0x60002F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A67ED8", Offset = "0x1A67ED8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BZip2OutputStream(Stream output)
		{
			throw null;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00005719 File Offset: 0x00003919
		[global::Cpp2ILInjected.Token(Token = "0x60002F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6821C", Offset = "0x1A6821C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2OutputStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public BZip2OutputStream(Stream output, int blockSize)
		{
			throw null;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000571C File Offset: 0x0000391C
		[global::Cpp2ILInjected.Token(Token = "0x60002F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A68224", Offset = "0x1A68224", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "MaybeApplyCompression", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2OutputStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BZip2OutputStream(Stream output, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000571F File Offset: 0x0000391F
		[global::Cpp2ILInjected.Token(Token = "0x60002F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A67F4C", Offset = "0x1A67F4C", Length = "0x2D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2OutputStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2OutputStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BitWriter),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2OutputStream), Member = "EmitHeader", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public BZip2OutputStream(Stream output, int blockSize, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00005722 File Offset: 0x00003922
		[global::Cpp2ILInjected.Token(Token = "0x60002FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6833C", Offset = "0x1A6833C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2OutputStream), Member = "Finish", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00005725 File Offset: 0x00003925
		[global::Cpp2ILInjected.Token(Token = "0x60002FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6841C", Offset = "0x1A6841C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitWriter), Member = "WriteBits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00005728 File Offset: 0x00003928
		[global::Cpp2ILInjected.Token(Token = "0x60002FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6829C", Offset = "0x1A6829C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2OutputStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void EmitHeader()
		{
			throw null;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000572B File Offset: 0x0000392B
		[global::Cpp2ILInjected.Token(Token = "0x60002FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6845C", Offset = "0x1A6845C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2OutputStream), Member = "Finish", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitWriter), Member = "WriteBits", MemberParameters = new object[]
		{
			typeof(int),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitWriter), Member = "WriteInt", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitWriter), Member = "FinishAndPad", ReturnType = typeof(void))]
		private void EmitTrailer()
		{
			throw null;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000572E File Offset: 0x0000392E
		[global::Cpp2ILInjected.Token(Token = "0x60002FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A68384", Offset = "0x1A68384", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2OutputStream), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "CompressAndWrite", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2OutputStream), Member = "EmitTrailer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void Finish()
		{
			throw null;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00005731 File Offset: 0x00003931
		[global::Cpp2ILInjected.Token(Token = "0x170000C4")]
		public int BlockSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A684DC", Offset = "0x1A684DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00005734 File Offset: 0x00003934
		[global::Cpp2ILInjected.Token(Token = "0x6000300")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A684E4", Offset = "0x1A684E4", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "Fill", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2Compressor), Member = "CompressAndWrite", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00005737 File Offset: 0x00003937
		[global::Cpp2ILInjected.Token(Token = "0x170000C5")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000301")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A686F8", Offset = "0x1A686F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0000573A File Offset: 0x0000393A
		[global::Cpp2ILInjected.Token(Token = "0x170000C6")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000302")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A68700", Offset = "0x1A68700", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0000573D File Offset: 0x0000393D
		[global::Cpp2ILInjected.Token(Token = "0x170000C7")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000303")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A68708", Offset = "0x1A68708", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00005740 File Offset: 0x00003940
		[global::Cpp2ILInjected.Token(Token = "0x170000C8")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000304")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6876C", Offset = "0x1A6876C", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002EE RID: 750 RVA: 0x00005743 File Offset: 0x00003943
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00005746 File Offset: 0x00003946
		[global::Cpp2ILInjected.Token(Token = "0x170000C9")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000305")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A687A4", Offset = "0x1A687A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000306")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A687AC", Offset = "0x1A687AC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00005749 File Offset: 0x00003949
		[global::Cpp2ILInjected.Token(Token = "0x6000307")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A687E4", Offset = "0x1A687E4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000574C File Offset: 0x0000394C
		[global::Cpp2ILInjected.Token(Token = "0x6000308")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6881C", Offset = "0x1A6881C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000574F File Offset: 0x0000394F
		[global::Cpp2ILInjected.Token(Token = "0x6000309")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A68854", Offset = "0x1A68854", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00005752 File Offset: 0x00003952
		[Conditional("Trace")]
		[global::Cpp2ILInjected.Token(Token = "0x600030A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6888C", Offset = "0x1A6888C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "Write", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void TraceOutput(BZip2OutputStream.TraceBits bits, string format, params object[] varParams)
		{
			throw null;
		}

		// Token: 0x0400017E RID: 382
		[global::Cpp2ILInjected.Token(Token = "0x40001C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int totalBytesWrittenIn;

		// Token: 0x0400017F RID: 383
		[global::Cpp2ILInjected.Token(Token = "0x40001C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private bool leaveOpen;

		// Token: 0x04000180 RID: 384
		[global::Cpp2ILInjected.Token(Token = "0x40001C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private BZip2Compressor compressor;

		// Token: 0x04000181 RID: 385
		[global::Cpp2ILInjected.Token(Token = "0x40001C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private uint combinedCRC;

		// Token: 0x04000182 RID: 386
		[global::Cpp2ILInjected.Token(Token = "0x40001C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Stream output;

		// Token: 0x04000183 RID: 387
		[global::Cpp2ILInjected.Token(Token = "0x40001CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private BitWriter bw;

		// Token: 0x04000184 RID: 388
		[global::Cpp2ILInjected.Token(Token = "0x40001CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int blockSize100k;

		// Token: 0x04000185 RID: 389
		[global::Cpp2ILInjected.Token(Token = "0x40001CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private BZip2OutputStream.TraceBits desiredTrace;

		// Token: 0x02000065 RID: 101
		[Flags]
		[global::Cpp2ILInjected.Token(Token = "0x200003C")]
		private enum TraceBits : uint
		{
			// Token: 0x04000326 RID: 806
			[global::Cpp2ILInjected.Token(Token = "0x40001CE")]
			None = 0U,
			// Token: 0x04000327 RID: 807
			[global::Cpp2ILInjected.Token(Token = "0x40001CF")]
			Crc = 1U,
			// Token: 0x04000328 RID: 808
			[global::Cpp2ILInjected.Token(Token = "0x40001D0")]
			Write = 2U,
			// Token: 0x04000329 RID: 809
			[global::Cpp2ILInjected.Token(Token = "0x40001D1")]
			All = 4294967295U
		}
	}
}
