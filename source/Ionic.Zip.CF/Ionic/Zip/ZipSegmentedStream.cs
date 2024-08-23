using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x0200002C RID: 44
	[global::Cpp2ILInjected.Token(Token = "0x2000032")]
	internal class ZipSegmentedStream : Stream
	{
		// Token: 0x0600026F RID: 623 RVA: 0x000055C6 File Offset: 0x000037C6
		[global::Cpp2ILInjected.Token(Token = "0x6000283")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A61570", Offset = "0x1A61570", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipSegmentedStream), Member = "ForReading", MemberParameters = new object[]
		{
			typeof(string),
			typeof(uint),
			typeof(uint)
		}, ReturnType = typeof(ZipSegmentedStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipSegmentedStream), Member = "ForWriting", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(ZipSegmentedStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ZipSegmentedStream()
		{
			throw null;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000055C9 File Offset: 0x000037C9
		[global::Cpp2ILInjected.Token(Token = "0x6000284")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A615D0", Offset = "0x1A615D0", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "StreamForDiskNumber", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = "_SetReadStream", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ZipSegmentedStream ForReading(string name, uint initialDiskNumber, uint maxDiskNumber)
		{
			throw null;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000055CC File Offset: 0x000037CC
		[global::Cpp2ILInjected.Token(Token = "0x6000285")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A616C4", Offset = "0x1A616C4", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "get_WriteStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = "_SetWriteStream", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static ZipSegmentedStream ForWriting(string name, int maxSegmentSize)
		{
			throw null;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000055CF File Offset: 0x000037CF
		[global::Cpp2ILInjected.Token(Token = "0x6000286")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6193C", Offset = "0x1A6193C", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "PostProcessOutput", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Open", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare)
		}, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static Stream ForUpdate(string name, uint diskNumber)
		{
			throw null;
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000273 RID: 627 RVA: 0x000055D2 File Offset: 0x000037D2
		// (set) Token: 0x06000274 RID: 628 RVA: 0x000055D5 File Offset: 0x000037D5
		[global::Cpp2ILInjected.Token(Token = "0x170000AF")]
		public bool ContiguousWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000287")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61A88", Offset = "0x1A61A88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000288")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61A90", Offset = "0x1A61A90", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000275 RID: 629 RVA: 0x000055D8 File Offset: 0x000037D8
		// (set) Token: 0x06000276 RID: 630 RVA: 0x000055DB File Offset: 0x000037DB
		[global::Cpp2ILInjected.Token(Token = "0x170000B0")]
		public uint CurrentSegment
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000289")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61A9C", Offset = "0x1A61A9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600028A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61650", Offset = "0x1A61650", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000277 RID: 631 RVA: 0x000055DE File Offset: 0x000037DE
		[global::Cpp2ILInjected.Token(Token = "0x170000B1")]
		public string CurrentName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61AA4", Offset = "0x1A61AA4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipSegmentedStream), Member = "Read", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = "_NameForSegment", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000278 RID: 632 RVA: 0x000055E1 File Offset: 0x000037E1
		[global::Cpp2ILInjected.Token(Token = "0x170000B2")]
		public string CurrentTempName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61C14", Offset = "0x1A61C14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000055E4 File Offset: 0x000037E4
		[global::Cpp2ILInjected.Token(Token = "0x600028D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A61ACC", Offset = "0x1A61ACC", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipSegmentedStream), Member = "get_CurrentName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipSegmentedStream), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipSegmentedStream), Member = "_SetReadStream", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipSegmentedStream), Member = "_SetWriteStream", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipSegmentedStream), Member = "TruncateBackward", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private string _NameForSegment(uint diskNumber)
		{
			throw null;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000055E7 File Offset: 0x000037E7
		[global::Cpp2ILInjected.Token(Token = "0x600028E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5F634", Offset = "0x1A5F634", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "WriteHeader", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public uint ComputeSegment(int length)
		{
			throw null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000055EA File Offset: 0x000037EA
		[global::Cpp2ILInjected.Token(Token = "0x600028F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A61C1C", Offset = "0x1A61C1C", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = "_NameForSegment", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000055ED File Offset: 0x000037ED
		[global::Cpp2ILInjected.Token(Token = "0x6000290")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6165C", Offset = "0x1A6165C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipSegmentedStream), Member = "ForReading", MemberParameters = new object[]
		{
			typeof(string),
			typeof(uint),
			typeof(uint)
		}, ReturnType = typeof(ZipSegmentedStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipSegmentedStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = "_NameForSegment", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "OpenRead", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FileStream))]
		private void _SetReadStream()
		{
			throw null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000055F0 File Offset: 0x000037F0
		[global::Cpp2ILInjected.Token(Token = "0x6000291")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A61DC4", Offset = "0x1A61DC4", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = "_SetReadStream", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = "get_CurrentName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000055F3 File Offset: 0x000037F3
		[global::Cpp2ILInjected.Token(Token = "0x6000292")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A617BC", Offset = "0x1A617BC", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipSegmentedStream), Member = "ForWriting", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(ZipSegmentedStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipSegmentedStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = "_NameForSegment", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Move", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "CreateAndOpenUniqueTempFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref Stream),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void _SetWriteStream(uint increment)
		{
			throw null;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000055F6 File Offset: 0x000037F6
		[global::Cpp2ILInjected.Token(Token = "0x6000293")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A61F74", Offset = "0x1A61F74", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = "_SetWriteStream", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000055F9 File Offset: 0x000037F9
		[global::Cpp2ILInjected.Token(Token = "0x6000294")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A620C8", Offset = "0x1A620C8", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "Write", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = "_NameForSegment", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "InternalGetTempFileName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Move", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "Workaround_Ladybug318918", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public long TruncateBackward(uint diskNumber, long offset)
		{
			throw null;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000281 RID: 641 RVA: 0x000055FC File Offset: 0x000037FC
		[global::Cpp2ILInjected.Token(Token = "0x170000B3")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000295")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A623A8", Offset = "0x1A623A8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000282 RID: 642 RVA: 0x000055FF File Offset: 0x000037FF
		[global::Cpp2ILInjected.Token(Token = "0x170000B4")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000296")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A623D0", Offset = "0x1A623D0", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00005602 File Offset: 0x00003802
		[global::Cpp2ILInjected.Token(Token = "0x170000B5")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000297")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A623E8", Offset = "0x1A623E8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00005605 File Offset: 0x00003805
		[global::Cpp2ILInjected.Token(Token = "0x6000298")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A62410", Offset = "0x1A62410", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00005608 File Offset: 0x00003808
		[global::Cpp2ILInjected.Token(Token = "0x170000B6")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000299")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A62424", Offset = "0x1A62424", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0000560B File Offset: 0x0000380B
		// (set) Token: 0x06000287 RID: 647 RVA: 0x0000560E File Offset: 0x0000380E
		[global::Cpp2ILInjected.Token(Token = "0x170000B7")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x600029A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A62434", Offset = "0x1A62434", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600029B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A62444", Offset = "0x1A62444", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00005611 File Offset: 0x00003811
		[global::Cpp2ILInjected.Token(Token = "0x600029C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A62458", Offset = "0x1A62458", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "Workaround_Ladybug318918", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00005614 File Offset: 0x00003814
		[global::Cpp2ILInjected.Token(Token = "0x600029D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A624F0", Offset = "0x1A624F0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00005617 File Offset: 0x00003817
		[global::Cpp2ILInjected.Token(Token = "0x600029E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A62554", Offset = "0x1A62554", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0400012C RID: 300
		[global::Cpp2ILInjected.Token(Token = "0x400013C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ZipSegmentedStream.RwMode rwMode;

		// Token: 0x0400012D RID: 301
		[global::Cpp2ILInjected.Token(Token = "0x400013D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private bool _exceptionPending;

		// Token: 0x0400012E RID: 302
		[global::Cpp2ILInjected.Token(Token = "0x400013E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string _baseName;

		// Token: 0x0400012F RID: 303
		[global::Cpp2ILInjected.Token(Token = "0x400013F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string _baseDir;

		// Token: 0x04000130 RID: 304
		[global::Cpp2ILInjected.Token(Token = "0x4000140")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string _currentName;

		// Token: 0x04000131 RID: 305
		[global::Cpp2ILInjected.Token(Token = "0x4000141")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string _currentTempName;

		// Token: 0x04000132 RID: 306
		[global::Cpp2ILInjected.Token(Token = "0x4000142")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private uint _currentDiskNumber;

		// Token: 0x04000133 RID: 307
		[global::Cpp2ILInjected.Token(Token = "0x4000143")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private uint _maxDiskNumber;

		// Token: 0x04000134 RID: 308
		[global::Cpp2ILInjected.Token(Token = "0x4000144")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int _maxSegmentSize;

		// Token: 0x04000135 RID: 309
		[global::Cpp2ILInjected.Token(Token = "0x4000145")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Stream _innerStream;

		// Token: 0x04000136 RID: 310
		[global::Cpp2ILInjected.Token(Token = "0x4000146")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool <ContiguousWrite>k__BackingField;

		// Token: 0x02000061 RID: 97
		[global::Cpp2ILInjected.Token(Token = "0x2000033")]
		private enum RwMode
		{
			// Token: 0x040002EF RID: 751
			[global::Cpp2ILInjected.Token(Token = "0x4000148")]
			None,
			// Token: 0x040002F0 RID: 752
			[global::Cpp2ILInjected.Token(Token = "0x4000149")]
			ReadOnly,
			// Token: 0x040002F1 RID: 753
			[global::Cpp2ILInjected.Token(Token = "0x400014A")]
			Write
		}
	}
}
