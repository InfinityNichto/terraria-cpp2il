using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System.IO
{
	// Token: 0x0200047A RID: 1146
	[global::Cpp2ILInjected.Token(Token = "0x2000541")]
	[global::System.Serializable]
	public class StreamWriter : TextWriter
	{
		// Token: 0x06002505 RID: 9477 RVA: 0x0001AC1B File Offset: 0x00018E1B
		[global::Cpp2ILInjected.Token(Token = "0x60027B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9C18C", Offset = "0x1B9C18C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "set_AutoFlush", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "WriteSpan", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "ThrowAsyncIOInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void CheckAsyncTaskInProgress()
		{
			throw null;
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x0001AC1E File Offset: 0x00018E1E
		[global::Cpp2ILInjected.Token(Token = "0x60027B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9C1E8", Offset = "0x1B9C1E8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void ThrowAsyncIOInProgress()
		{
			throw null;
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x0001AC21 File Offset: 0x00018E21
		[global::Cpp2ILInjected.Token(Token = "0x170005B5")]
		private static global::System.Text.Encoding UTF8NoBOM
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9C234", Offset = "0x1B9C234", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.EncodingHelper), Member = "get_UTF8Unmarked", ReturnType = typeof(global::System.Text.Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x0001AC24 File Offset: 0x00018E24
		[global::Cpp2ILInjected.Token(Token = "0x60027B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9C284", Offset = "0x1B9C284", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal StreamWriter()
		{
			throw null;
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x0001AC27 File Offset: 0x00018E27
		[global::Cpp2ILInjected.Token(Token = "0x60027B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9C3C8", Offset = "0x1B9C3C8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CSVWriter", Member = "SetupStreams", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.TimeLogger", Member = "NewDrawFrame", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.IO.ConsoleOutputMirror", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "get_UTF8NoBOM", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public StreamWriter(Stream stream)
		{
			throw null;
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x0001AC2A File Offset: 0x00018E2A
		[global::Cpp2ILInjected.Token(Token = "0x60027B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9C63C", Offset = "0x1B9C63C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CSVWriter", Member = "SetupStreams", MemberParameters = new object[] { typeof(global::System.Text.UTF8Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.KeyPairPersistence), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new object[] { "System.Diagnostics.ProcessStartInfo" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.Text.Encoding)
		}, ReturnType = "Ionic.Zip.ZipEntry")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public StreamWriter(Stream stream, global::System.Text.Encoding encoding)
		{
			throw null;
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x0001AC2D File Offset: 0x00018E2D
		[global::Cpp2ILInjected.Token(Token = "0x60027B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9C648", Offset = "0x1B9C648", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpListenerResponse", Member = "SendHeaders", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(MemoryStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public StreamWriter(Stream stream, global::System.Text.Encoding encoding, int bufferSize)
		{
			throw null;
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x0001AC30 File Offset: 0x00018E30
		[global::Cpp2ILInjected.Token(Token = "0x60027BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9C43C", Offset = "0x1B9C43C", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnexceptionalStreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CStreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Init", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public StreamWriter(Stream stream, global::System.Text.Encoding encoding, int bufferSize, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x0001AC33 File Offset: 0x00018E33
		[global::Cpp2ILInjected.Token(Token = "0x60027BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9C77C", Offset = "0x1B9C77C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "WriteToFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "get_UTF8NoBOM", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public StreamWriter(string path)
		{
			throw null;
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x0001AC36 File Offset: 0x00018E36
		[global::Cpp2ILInjected.Token(Token = "0x60027BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9CA2C", Offset = "0x1B9CA2C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "AddBan", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "ValidateWorld", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileInfo), Member = "CreateText", ReturnType = typeof(StreamWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileInfo), Member = "AppendText", ReturnType = typeof(StreamWriter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "get_UTF8NoBOM", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(global::System.Text.Encoding),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public StreamWriter(string path, bool append)
		{
			throw null;
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x0001AC39 File Offset: 0x00018E39
		[global::Cpp2ILInjected.Token(Token = "0x60027BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9C7F0", Offset = "0x1B9C7F0", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare),
			typeof(int),
			typeof(FileOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Init", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public StreamWriter(string path, bool append, global::System.Text.Encoding encoding, int bufferSize)
		{
			throw null;
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x0001AC3C File Offset: 0x00018E3C
		[global::Cpp2ILInjected.Token(Token = "0x60027BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9C650", Offset = "0x1B9C650", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(global::System.Text.Encoding),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void Init(Stream streamArg, global::System.Text.Encoding encodingArg, int bufferSize, bool shouldLeaveOpen)
		{
			throw null;
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x0001AC3F File Offset: 0x00018E3F
		[global::Cpp2ILInjected.Token(Token = "0x60027BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9CB20", Offset = "0x1B9CB20", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x0001AC42 File Offset: 0x00018E42
		[global::Cpp2ILInjected.Token(Token = "0x60027C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9CB8C", Offset = "0x1B9CB8C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Flush", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x0001AC45 File Offset: 0x00018E45
		[global::Cpp2ILInjected.Token(Token = "0x60027C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9CD84", Offset = "0x1B9CD84", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnexceptionalStreamWriter), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Flush", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x0001AC48 File Offset: 0x00018E48
		[global::Cpp2ILInjected.Token(Token = "0x60027C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9CC20", Offset = "0x1B9CC20", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "set_AutoFlush", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "WriteSpan", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void Flush(bool flushStream, bool flushEncoder)
		{
			throw null;
		}

		// Token: 0x1700053C RID: 1340
		// (set) Token: 0x06002515 RID: 9493 RVA: 0x0001AC4B File Offset: 0x00018E4B
		[global::Cpp2ILInjected.Token(Token = "0x170005B6")]
		public virtual bool AutoFlush
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9CDA4", Offset = "0x1B9CDA4", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Flush", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x0001AC4E File Offset: 0x00018E4E
		[global::Cpp2ILInjected.Token(Token = "0x170005B7")]
		internal bool LeaveOpen
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9CDE8", Offset = "0x1B9CDE8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x0001AC51 File Offset: 0x00018E51
		[global::Cpp2ILInjected.Token(Token = "0x170005B8")]
		public override global::System.Text.Encoding Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9CDF8", Offset = "0x1B9CDF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x0001AC54 File Offset: 0x00018E54
		[global::Cpp2ILInjected.Token(Token = "0x60027C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9CE00", Offset = "0x1B9CE00", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnexceptionalStreamWriter), Member = "Write", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CStreamWriter), Member = "InternalWriteChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Flush", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public override void Write(char value)
		{
			throw null;
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x0001AC57 File Offset: 0x00018E57
		[global::Cpp2ILInjected.Token(Token = "0x60027C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9CE74", Offset = "0x1B9CE74", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnexceptionalStreamWriter), Member = "Write", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Flush", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "MemoryCopy", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(void*),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		[MethodImpl(8)]
		public unsafe override void Write(char[] buffer)
		{
			throw null;
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x0001AC5A File Offset: 0x00018E5A
		[global::Cpp2ILInjected.Token(Token = "0x60027C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9D0A4", Offset = "0x1B9D0A4", Length = "0x394")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnexceptionalStreamWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CStreamWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CStreamWriter), Member = "InternalWriteChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Flush", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "MemoryCopy", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(void*),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		[MethodImpl(8)]
		public unsafe override void Write(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x0001AC5D File Offset: 0x00018E5D
		[global::Cpp2ILInjected.Token(Token = "0x60027C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9D438", Offset = "0x1B9D438", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Flush", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "MemoryCopy", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(void*),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		[MethodImpl(256)]
		private unsafe void WriteSpan(global::System.ReadOnlySpan<char> buffer, bool appendNewLine)
		{
			throw null;
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x0001AC60 File Offset: 0x00018E60
		[global::Cpp2ILInjected.Token(Token = "0x60027CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9D69C", Offset = "0x1B9D69C", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnexceptionalStreamWriter), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CStreamWriter), Member = "InternalWriteString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CStreamWriter), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Flush", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "MemoryCopy", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(void*),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		[MethodImpl(8)]
		public unsafe override void Write(string value)
		{
			throw null;
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x0001AC63 File Offset: 0x00018E63
		[global::Cpp2ILInjected.Token(Token = "0x60027CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9D8D0", Offset = "0x1B9D8D0", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Flush", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "MemoryCopy", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(void*),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		[MethodImpl(8)]
		public unsafe override void WriteLine(string value)
		{
			throw null;
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x0001AC66 File Offset: 0x00018E66
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60027CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9DB6C", Offset = "0x1B9DB6C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "get_UTF8NoBOM", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static StreamWriter()
		{
			throw null;
		}

		// Token: 0x04001284 RID: 4740
		[global::Cpp2ILInjected.Token(Token = "0x40015A4")]
		public new static readonly StreamWriter Null;

		// Token: 0x04001285 RID: 4741
		[global::Cpp2ILInjected.Token(Token = "0x40015A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Stream _stream;

		// Token: 0x04001286 RID: 4742
		[global::Cpp2ILInjected.Token(Token = "0x40015A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.Text.Encoding _encoding;

		// Token: 0x04001287 RID: 4743
		[global::Cpp2ILInjected.Token(Token = "0x40015A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private global::System.Text.Encoder _encoder;

		// Token: 0x04001288 RID: 4744
		[global::Cpp2ILInjected.Token(Token = "0x40015A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private byte[] _byteBuffer;

		// Token: 0x04001289 RID: 4745
		[global::Cpp2ILInjected.Token(Token = "0x40015A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private char[] _charBuffer;

		// Token: 0x0400128A RID: 4746
		[global::Cpp2ILInjected.Token(Token = "0x40015AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int _charPos;

		// Token: 0x0400128B RID: 4747
		[global::Cpp2ILInjected.Token(Token = "0x40015AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private int _charLen;

		// Token: 0x0400128C RID: 4748
		[global::Cpp2ILInjected.Token(Token = "0x40015AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private bool _autoFlush;

		// Token: 0x0400128D RID: 4749
		[global::Cpp2ILInjected.Token(Token = "0x40015AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
		private bool _haveWrittenPreamble;

		// Token: 0x0400128E RID: 4750
		[global::Cpp2ILInjected.Token(Token = "0x40015AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x62")]
		private bool _closable;

		// Token: 0x0400128F RID: 4751
		[global::Cpp2ILInjected.Token(Token = "0x40015AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private global::System.Threading.Tasks.Task _asyncWriteTask;
	}
}
