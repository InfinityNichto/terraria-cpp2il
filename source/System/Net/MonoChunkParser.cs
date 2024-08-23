using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020001A5 RID: 421
	[global::Cpp2ILInjected.Token(Token = "0x2000263")]
	internal class MonoChunkParser
	{
		// Token: 0x06000EDD RID: 3805 RVA: 0x000058CA File Offset: 0x00003ACA
		[global::Cpp2ILInjected.Token(Token = "0x6001079")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E01EC4", Offset = "0x1E01EC4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpListenerContext),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream),
			typeof(WebHeaderCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public MonoChunkParser(WebHeaderCollection headers)
		{
			throw null;
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x000058CD File Offset: 0x00003ACD
		[global::Cpp2ILInjected.Token(Token = "0x600107A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E01F70", Offset = "0x1E01F70", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "ReadFromChunks", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		public void WriteAndReadBack(byte[] buffer, int offset, int size, ref int read)
		{
			throw null;
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x000058D0 File Offset: 0x00003AD0
		[global::Cpp2ILInjected.Token(Token = "0x600107B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0200C", Offset = "0x1E0200C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = "OnRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public int Read(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x000058D3 File Offset: 0x00003AD3
		[global::Cpp2ILInjected.Token(Token = "0x600107C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E02010", Offset = "0x1E02010", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkParser), Member = "WriteAndReadBack", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.MonoChunkStream.<ProcessReadAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.MonoChunkStream.<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private int ReadFromChunks(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x000058D6 File Offset: 0x00003AD6
		[global::Cpp2ILInjected.Token(Token = "0x600107D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E01FEC", Offset = "0x1E01FEC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = "OnRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void Write(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000058D9 File Offset: 0x00003AD9
		[global::Cpp2ILInjected.Token(Token = "0x600107E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E02378", Offset = "0x1E02378", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkParser), Member = "WriteAndReadBack", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkParser), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.MonoChunkStream.<ProcessReadAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.MonoChunkStream.<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "GetChunkSize", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(MonoChunkParser.State))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "ReadBody", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(MonoChunkParser.State))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "ReadCRLF", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(MonoChunkParser.State))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "ReadTrailer", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(MonoChunkParser.State))]
		private void InternalWrite(byte[] buffer, ref int offset, int size)
		{
			throw null;
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000EE3 RID: 3811 RVA: 0x000058DC File Offset: 0x00003ADC
		[global::Cpp2ILInjected.Token(Token = "0x170003B1")]
		public bool WantMore
		{
			[global::Cpp2ILInjected.Token(Token = "0x600107F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E02BD4", Offset = "0x1E02BD4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = "BeginRead", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(AsyncCallback),
				typeof(object)
			}, ReturnType = typeof(IAsyncResult))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = "OnRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000EE4 RID: 3812 RVA: 0x000058DF File Offset: 0x00003ADF
		[global::Cpp2ILInjected.Token(Token = "0x170003B2")]
		public bool DataAvailable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001080")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E02BFC", Offset = "0x1E02BFC", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.MonoChunkStream.<ProcessReadAsync>d__7", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.MonoChunkStream.<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000EE5 RID: 3813 RVA: 0x000058E2 File Offset: 0x00003AE2
		[global::Cpp2ILInjected.Token(Token = "0x170003B3")]
		public int TotalDataSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001081")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E02CF0", Offset = "0x1E02CF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000EE6 RID: 3814 RVA: 0x000058E5 File Offset: 0x00003AE5
		[global::Cpp2ILInjected.Token(Token = "0x170003B4")]
		public int ChunkLeft
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001082")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E02CF8", Offset = "0x1E02CF8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = "OnRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x000058E8 File Offset: 0x00003AE8
		[global::Cpp2ILInjected.Token(Token = "0x6001083")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0276C", Offset = "0x1E0276C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private MonoChunkParser.State ReadBody(byte[] buffer, ref int offset, int size)
		{
			throw null;
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x000058EB File Offset: 0x00003AEB
		[global::Cpp2ILInjected.Token(Token = "0x6001084")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E024A8", Offset = "0x1E024A8", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "RemoveChunkExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "ThrowProtocolViolation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private MonoChunkParser.State GetChunkSize(byte[] buffer, ref int offset, int size)
		{
			throw null;
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x000058EE File Offset: 0x00003AEE
		[global::Cpp2ILInjected.Token(Token = "0x6001085")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E02D7C", Offset = "0x1E02D7C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkParser), Member = "GetChunkSize", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(MonoChunkParser.State))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		private static string RemoveChunkExtension(string input)
		{
			throw null;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x000058F1 File Offset: 0x00003AF1
		[global::Cpp2ILInjected.Token(Token = "0x6001086")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E02898", Offset = "0x1E02898", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "ThrowProtocolViolation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private MonoChunkParser.State ReadCRLF(byte[] buffer, ref int offset, int size)
		{
			throw null;
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x000058F4 File Offset: 0x00003AF4
		[global::Cpp2ILInjected.Token(Token = "0x6001087")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E02968", Offset = "0x1E02968", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "ThrowProtocolViolation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebHeaderCollection), Member = "Add", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private MonoChunkParser.State ReadTrailer(byte[] buffer, ref int offset, int size)
		{
			throw null;
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x000058F7 File Offset: 0x00003AF7
		[global::Cpp2ILInjected.Token(Token = "0x6001088")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E02D2C", Offset = "0x1E02D2C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkParser), Member = "GetChunkSize", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(MonoChunkParser.State))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkParser), Member = "ReadCRLF", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(MonoChunkParser.State))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkParser), Member = "ReadTrailer", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(ref int),
			typeof(int)
		}, ReturnType = typeof(MonoChunkParser.State))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void ThrowProtocolViolation(string message)
		{
			throw null;
		}

		// Token: 0x04000A0B RID: 2571
		[global::Cpp2ILInjected.Token(Token = "0x4000CF5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private WebHeaderCollection headers;

		// Token: 0x04000A0C RID: 2572
		[global::Cpp2ILInjected.Token(Token = "0x4000CF6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int chunkSize;

		// Token: 0x04000A0D RID: 2573
		[global::Cpp2ILInjected.Token(Token = "0x4000CF7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int chunkRead;

		// Token: 0x04000A0E RID: 2574
		[global::Cpp2ILInjected.Token(Token = "0x4000CF8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int totalWritten;

		// Token: 0x04000A0F RID: 2575
		[global::Cpp2ILInjected.Token(Token = "0x4000CF9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private MonoChunkParser.State state;

		// Token: 0x04000A10 RID: 2576
		[global::Cpp2ILInjected.Token(Token = "0x4000CFA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private StringBuilder saved;

		// Token: 0x04000A11 RID: 2577
		[global::Cpp2ILInjected.Token(Token = "0x4000CFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool sawCR;

		// Token: 0x04000A12 RID: 2578
		[global::Cpp2ILInjected.Token(Token = "0x4000CFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		private bool gotit;

		// Token: 0x04000A13 RID: 2579
		[global::Cpp2ILInjected.Token(Token = "0x4000CFD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int trailerState;

		// Token: 0x04000A14 RID: 2580
		[global::Cpp2ILInjected.Token(Token = "0x4000CFE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ArrayList chunks;

		// Token: 0x02000422 RID: 1058
		[global::Cpp2ILInjected.Token(Token = "0x2000264")]
		private enum State
		{
			// Token: 0x04001274 RID: 4724
			[global::Cpp2ILInjected.Token(Token = "0x4000D00")]
			None,
			// Token: 0x04001275 RID: 4725
			[global::Cpp2ILInjected.Token(Token = "0x4000D01")]
			PartialSize,
			// Token: 0x04001276 RID: 4726
			[global::Cpp2ILInjected.Token(Token = "0x4000D02")]
			Body,
			// Token: 0x04001277 RID: 4727
			[global::Cpp2ILInjected.Token(Token = "0x4000D03")]
			BodyFinished,
			// Token: 0x04001278 RID: 4728
			[global::Cpp2ILInjected.Token(Token = "0x4000D04")]
			Trailer
		}

		// Token: 0x02000423 RID: 1059
		[global::Cpp2ILInjected.Token(Token = "0x2000265")]
		private class Chunk
		{
			// Token: 0x06001E3B RID: 7739 RVA: 0x00008330 File Offset: 0x00006530
			[global::Cpp2ILInjected.Token(Token = "0x6001089")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E02D04", Offset = "0x1E02D04", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public Chunk(byte[] chunk)
			{
				throw null;
			}

			// Token: 0x06001E3C RID: 7740 RVA: 0x00008333 File Offset: 0x00006533
			[global::Cpp2ILInjected.Token(Token = "0x600108A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E02320", Offset = "0x1E02320", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			public int Read(byte[] buffer, int offset, int size)
			{
				throw null;
			}

			// Token: 0x04001279 RID: 4729
			[global::Cpp2ILInjected.Token(Token = "0x4000D05")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public byte[] Bytes;

			// Token: 0x0400127A RID: 4730
			[global::Cpp2ILInjected.Token(Token = "0x4000D06")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int Offset;
		}
	}
}
