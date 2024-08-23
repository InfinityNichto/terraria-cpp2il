using System;
using System.Collections.Generic;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Crc;

namespace Ionic.Zip
{
	// Token: 0x02000018 RID: 24
	[global::Cpp2ILInjected.Token(Token = "0x2000018")]
	public class CountingStream : Stream
	{
		// Token: 0x0600007B RID: 123 RVA: 0x00004FF9 File Offset: 0x000031F9
		[global::Cpp2ILInjected.Token(Token = "0x600007B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A474C8", Offset = "0x1A474C8", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "_WriteEntryData", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "PrepOutputStream", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long),
			typeof(ref CountingStream),
			typeof(ref Stream),
			typeof(ref Stream),
			typeof(ref CrcCalculatorStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughWithRecompute", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughWithNoChange", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "_Init", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public CountingStream(Stream stream)
		{
			throw null;
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00004FFC File Offset: 0x000031FC
		[global::Cpp2ILInjected.Token(Token = "0x17000012")]
		public Stream WrappedStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A475D0", Offset = "0x1A475D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00004FFF File Offset: 0x000031FF
		[global::Cpp2ILInjected.Token(Token = "0x17000013")]
		public long BytesWritten
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A475D8", Offset = "0x1A475D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00005002 File Offset: 0x00003202
		[global::Cpp2ILInjected.Token(Token = "0x17000014")]
		public long BytesRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A475E0", Offset = "0x1A475E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005005 File Offset: 0x00003205
		[global::Cpp2ILInjected.Token(Token = "0x600007F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A475E8", Offset = "0x1A475E8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "PostProcessOutput", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "Write", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Adjust(long delta)
		{
			throw null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00005008 File Offset: 0x00003208
		[global::Cpp2ILInjected.Token(Token = "0x6000080")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A476B4", Offset = "0x1A476B4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000500B File Offset: 0x0000320B
		[global::Cpp2ILInjected.Token(Token = "0x6000081")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A476E4", Offset = "0x1A476E4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000500E File Offset: 0x0000320E
		[global::Cpp2ILInjected.Token(Token = "0x17000015")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000082")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A47724", Offset = "0x1A47724", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00005011 File Offset: 0x00003211
		[global::Cpp2ILInjected.Token(Token = "0x17000016")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000083")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A47734", Offset = "0x1A47734", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00005014 File Offset: 0x00003214
		[global::Cpp2ILInjected.Token(Token = "0x17000017")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000084")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A47744", Offset = "0x1A47744", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00005017 File Offset: 0x00003217
		[global::Cpp2ILInjected.Token(Token = "0x6000085")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A47754", Offset = "0x1A47754", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000501A File Offset: 0x0000321A
		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000086")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A47768", Offset = "0x1A47768", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000501D File Offset: 0x0000321D
		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		public long ComputedPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000087")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A47778", Offset = "0x1A47778", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutput), Member = "WriteCentralDirectoryStructure", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(ICollection<ZipEntry>),
				typeof(uint),
				typeof(Zip64Option),
				typeof(string),
				typeof(ZipContainer)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00005020 File Offset: 0x00003220
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00005023 File Offset: 0x00003223
		[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000088")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A47788", Offset = "0x1A47788", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000089")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A47798", Offset = "0x1A47798", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00005026 File Offset: 0x00003226
		[global::Cpp2ILInjected.Token(Token = "0x600008A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A47824", Offset = "0x1A47824", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00005029 File Offset: 0x00003229
		[global::Cpp2ILInjected.Token(Token = "0x600008B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A47838", Offset = "0x1A47838", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x04000033 RID: 51
		[global::Cpp2ILInjected.Token(Token = "0x4000033")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Stream _s;

		// Token: 0x04000034 RID: 52
		[global::Cpp2ILInjected.Token(Token = "0x4000034")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private long _bytesWritten;

		// Token: 0x04000035 RID: 53
		[global::Cpp2ILInjected.Token(Token = "0x4000035")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private long _bytesRead;

		// Token: 0x04000036 RID: 54
		[global::Cpp2ILInjected.Token(Token = "0x4000036")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private long _initialOffset;
	}
}
