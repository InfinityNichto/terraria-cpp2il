using System;
using System.Runtime.Remoting;
using System.Security.Util;
using System.Text;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x02000479 RID: 1145
	[global::Cpp2ILInjected.Token(Token = "0x200053F")]
	[global::System.Serializable]
	public class StreamReader : TextReader
	{
		// Token: 0x060024E6 RID: 9446 RVA: 0x0001ABBE File Offset: 0x00018DBE
		[global::Cpp2ILInjected.Token(Token = "0x600278A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9A638", Offset = "0x1B9A638", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = "Peek", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = "ReadSpan", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = "ReadToEnd", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = "ReadLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "ThrowAsyncIOInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void CheckAsyncTaskInProgress()
		{
			throw null;
		}

		// Token: 0x060024E7 RID: 9447 RVA: 0x0001ABC1 File Offset: 0x00018DC1
		[global::Cpp2ILInjected.Token(Token = "0x600278B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9A694", Offset = "0x1B9A694", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void ThrowAsyncIOInProgress()
		{
			throw null;
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x0001ABC4 File Offset: 0x00018DC4
		[global::Cpp2ILInjected.Token(Token = "0x600278C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9A6E0", Offset = "0x1B9A6E0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader.NullStreamReader), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal StreamReader()
		{
			throw null;
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x0001ABC7 File Offset: 0x00018DC7
		[global::Cpp2ILInjected.Token(Token = "0x600278D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9A7A4", Offset = "0x1B9A7A4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utils", Member = "ReadEmbeddedResource", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.ResourcePack", Member = "LoadManifest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.LinuxNetworkInterface", Member = "ReadLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.LicFileLicenseProvider", Member = "GetLicense", MemberParameters = new object[]
		{
			"System.ComponentModel.LicenseContext",
			typeof(global::System.Type),
			typeof(object),
			typeof(bool)
		}, ReturnType = "System.ComponentModel.License")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(bool),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public StreamReader(Stream stream)
		{
			throw null;
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x0001ABCA File Offset: 0x00018DCA
		[global::Cpp2ILInjected.Token(Token = "0x600278E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9A7E0", Offset = "0x1B9A7E0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		public StreamReader(Stream stream, bool detectEncodingFromByteOrderMarks)
		{
			throw null;
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x0001ABCD File Offset: 0x00018DCD
		[global::Cpp2ILInjected.Token(Token = "0x600278F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9AA30", Offset = "0x1B9AA30", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Tokenizer), Member = "ChangeFormat", MemberParameters = new object[] { typeof(global::System.Text.Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnexceptionalStreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CStreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.ZlibBaseStream", Member = "UncompressString", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(Stream)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(bool),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public StreamReader(Stream stream, global::System.Text.Encoding encoding)
		{
			throw null;
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x0001ABD0 File Offset: 0x00018DD0
		[global::Cpp2ILInjected.Token(Token = "0x6002790")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9AA40", Offset = "0x1B9AA40", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Diagnostics.Process", Member = "StartWithCreateProcess", MemberParameters = new object[] { "System.Diagnostics.ProcessStartInfo" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(bool),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public StreamReader(Stream stream, global::System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks)
		{
			throw null;
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x0001ABD3 File Offset: 0x00018DD3
		[global::Cpp2ILInjected.Token(Token = "0x6002791")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9A820", Offset = "0x1B9A820", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "Init", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(bool),
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
		public StreamReader(Stream stream, global::System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x0001ABD6 File Offset: 0x00018DD6
		[global::Cpp2ILInjected.Token(Token = "0x6002792")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9AB74", Offset = "0x1B9AB74", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadDedConfig", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "IsBanned", MemberParameters = new object[] { "Terraria.Net.RemoteAddress" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "ReadXdgUserDir", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingConfiguration), Member = "LoadDefaultDelayedChannels", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "ReadFromFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Text.Encoding),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		public StreamReader(string path)
		{
			throw null;
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x0001ABD9 File Offset: 0x00018DD9
		[global::Cpp2ILInjected.Token(Token = "0x6002793")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9ABAC", Offset = "0x1B9ABAC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		public StreamReader(string path, bool detectEncodingFromByteOrderMarks)
		{
			throw null;
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x0001ABDC File Offset: 0x00018DDC
		[global::Cpp2ILInjected.Token(Token = "0x6002794")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9ABE8", Offset = "0x1B9ABE8", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(File), Member = "OpenText", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StreamReader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare),
			typeof(int),
			typeof(FileOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "Init", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(bool),
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
		public StreamReader(string path, global::System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize)
		{
			throw null;
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x0001ABDF File Offset: 0x00018DDF
		[global::Cpp2ILInjected.Token(Token = "0x6002795")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9AA50", Offset = "0x1B9AA50", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(bool),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Text.Encoding),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void Init(Stream stream, global::System.Text.Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x0001ABE2 File Offset: 0x00018DE2
		[global::Cpp2ILInjected.Token(Token = "0x6002796")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9AE1C", Offset = "0x1B9AE1C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Init(Stream stream)
		{
			throw null;
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x0001ABE5 File Offset: 0x00018DE5
		[global::Cpp2ILInjected.Token(Token = "0x6002797")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9AE2C", Offset = "0x1B9AE2C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x0001ABE8 File Offset: 0x00018DE8
		[global::Cpp2ILInjected.Token(Token = "0x6002798")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9AE3C", Offset = "0x1B9AE3C", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x0001ABEB File Offset: 0x00018DEB
		[global::Cpp2ILInjected.Token(Token = "0x170005B0")]
		public virtual global::System.Text.Encoding CurrentEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002799")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9AF1C", Offset = "0x1B9AF1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060024F6 RID: 9462 RVA: 0x0001ABEE File Offset: 0x00018DEE
		[global::Cpp2ILInjected.Token(Token = "0x170005B1")]
		public virtual Stream BaseStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x600279A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9AF24", Offset = "0x1B9AF24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060024F7 RID: 9463 RVA: 0x0001ABF1 File Offset: 0x00018DF1
		[global::Cpp2ILInjected.Token(Token = "0x170005B2")]
		internal bool LeaveOpen
		{
			[global::Cpp2ILInjected.Token(Token = "0x600279B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9AF0C", Offset = "0x1B9AF0C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x0001ABF4 File Offset: 0x00018DF4
		[global::Cpp2ILInjected.Token(Token = "0x600279C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9AF2C", Offset = "0x1B9AF2C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnexceptionalStreamReader), Member = "Peek", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CStreamReader), Member = "Peek", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int Peek()
		{
			throw null;
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x0001ABF7 File Offset: 0x00018DF7
		[global::Cpp2ILInjected.Token(Token = "0x600279D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9AFD8", Offset = "0x1B9AFD8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnexceptionalStreamReader), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnexceptionalStreamReader), Member = "Read", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int Read()
		{
			throw null;
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x0001ABFA File Offset: 0x00018DFA
		[global::Cpp2ILInjected.Token(Token = "0x600279E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9B084", Offset = "0x1B9B084", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override int Read(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x0001ABFD File Offset: 0x00018DFD
		[global::Cpp2ILInjected.Token(Token = "0x600279F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9B238", Offset = "0x1B9B238", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "ReadBuffer", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "CopyTo", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private int ReadSpan(global::System.Span<char> buffer)
		{
			throw null;
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x0001AC00 File Offset: 0x00018E00
		[global::Cpp2ILInjected.Token(Token = "0x60027A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9B784", Offset = "0x1B9B784", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnexceptionalStreamReader), Member = "ReadToEnd", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override string ReadToEnd()
		{
			throw null;
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x0001AC03 File Offset: 0x00018E03
		[global::Cpp2ILInjected.Token(Token = "0x60027A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9B894", Offset = "0x1B9B894", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void CompressBuffer(int n)
		{
			throw null;
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x0001AC06 File Offset: 0x00018E06
		[global::Cpp2ILInjected.Token(Token = "0x60027A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9B8D8", Offset = "0x1B9B8D8", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_Unicode", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.UTF32Encoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF32", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void DetectEncoding()
		{
			throw null;
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x0001AC09 File Offset: 0x00018E09
		[global::Cpp2ILInjected.Token(Token = "0x60027A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9BB28", Offset = "0x1B9BB28", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = "ReadBuffer", MemberParameters = new object[]
		{
			typeof(global::System.Span<char>),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool IsPreamble()
		{
			throw null;
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x0001AC0C File Offset: 0x00018E0C
		[global::Cpp2ILInjected.Token(Token = "0x60027A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9BC28", Offset = "0x1B9BC28", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "IsPreamble", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "DetectEncoding", ReturnType = typeof(void))]
		internal virtual int ReadBuffer()
		{
			throw null;
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x0001AC0F File Offset: 0x00018E0F
		[global::Cpp2ILInjected.Token(Token = "0x60027A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9B49C", Offset = "0x1B9B49C", Length = "0x2E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = "ReadSpan", MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "IsPreamble", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "DetectEncoding", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int ReadBuffer(global::System.Span<char> userBuffer, out bool readToUserBuffer)
		{
			throw null;
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x0001AC12 File Offset: 0x00018E12
		[global::Cpp2ILInjected.Token(Token = "0x60027A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9BD74", Offset = "0x1B9BD74", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnexceptionalStreamReader), Member = "ReadLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "CheckAsyncTaskInProgress", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override string ReadLine()
		{
			throw null;
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x0001AC15 File Offset: 0x00018E15
		[global::Cpp2ILInjected.Token(Token = "0x60027A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9BFA8", Offset = "0x1B9BFA8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "ReadKeyInternal", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "InputPending", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "QueueEcho", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		internal bool DataAvailable()
		{
			throw null;
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x0001AC18 File Offset: 0x00018E18
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60027A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9BFB8", Offset = "0x1B9BFB8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader.NullStreamReader), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static StreamReader()
		{
			throw null;
		}

		// Token: 0x04001274 RID: 4724
		[global::Cpp2ILInjected.Token(Token = "0x4001594")]
		public new static readonly StreamReader Null;

		// Token: 0x04001275 RID: 4725
		[global::Cpp2ILInjected.Token(Token = "0x4001595")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Stream _stream;

		// Token: 0x04001276 RID: 4726
		[global::Cpp2ILInjected.Token(Token = "0x4001596")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Text.Encoding _encoding;

		// Token: 0x04001277 RID: 4727
		[global::Cpp2ILInjected.Token(Token = "0x4001597")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Text.Decoder _decoder;

		// Token: 0x04001278 RID: 4728
		[global::Cpp2ILInjected.Token(Token = "0x4001598")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private byte[] _byteBuffer;

		// Token: 0x04001279 RID: 4729
		[global::Cpp2ILInjected.Token(Token = "0x4001599")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private char[] _charBuffer;

		// Token: 0x0400127A RID: 4730
		[global::Cpp2ILInjected.Token(Token = "0x400159A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int _charPos;

		// Token: 0x0400127B RID: 4731
		[global::Cpp2ILInjected.Token(Token = "0x400159B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int _charLen;

		// Token: 0x0400127C RID: 4732
		[global::Cpp2ILInjected.Token(Token = "0x400159C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int _byteLen;

		// Token: 0x0400127D RID: 4733
		[global::Cpp2ILInjected.Token(Token = "0x400159D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int _bytePos;

		// Token: 0x0400127E RID: 4734
		[global::Cpp2ILInjected.Token(Token = "0x400159E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int _maxCharsPerBuffer;

		// Token: 0x0400127F RID: 4735
		[global::Cpp2ILInjected.Token(Token = "0x400159F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private bool _detectEncoding;

		// Token: 0x04001280 RID: 4736
		[global::Cpp2ILInjected.Token(Token = "0x40015A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x55")]
		private bool _checkPreamble;

		// Token: 0x04001281 RID: 4737
		[global::Cpp2ILInjected.Token(Token = "0x40015A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x56")]
		private bool _isBlocked;

		// Token: 0x04001282 RID: 4738
		[global::Cpp2ILInjected.Token(Token = "0x40015A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x57")]
		private bool _closable;

		// Token: 0x04001283 RID: 4739
		[global::Cpp2ILInjected.Token(Token = "0x40015A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private global::System.Threading.Tasks.Task _asyncReadTask;

		// Token: 0x02000611 RID: 1553
		[global::Cpp2ILInjected.Token(Token = "0x2000540")]
		private class NullStreamReader : StreamReader
		{
			// Token: 0x0600417B RID: 16763 RVA: 0x0001FEEF File Offset: 0x0001E0EF
			[global::Cpp2ILInjected.Token(Token = "0x60027A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9C024", Offset = "0x1B9C024", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamReader), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal NullStreamReader()
			{
				throw null;
			}

			// Token: 0x17000773 RID: 1907
			// (get) Token: 0x0600417C RID: 16764 RVA: 0x0001FEF2 File Offset: 0x0001E0F2
			[global::Cpp2ILInjected.Token(Token = "0x170005B3")]
			public override Stream BaseStream
			{
				[global::Cpp2ILInjected.Token(Token = "0x60027AA")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B9C0B8", Offset = "0x1B9C0B8", Length = "0x58")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000774 RID: 1908
			// (get) Token: 0x0600417D RID: 16765 RVA: 0x0001FEF5 File Offset: 0x0001E0F5
			[global::Cpp2ILInjected.Token(Token = "0x170005B4")]
			public override global::System.Text.Encoding CurrentEncoding
			{
				[global::Cpp2ILInjected.Token(Token = "0x60027AB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B9C110", Offset = "0x1B9C110", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_Unicode", ReturnType = typeof(global::System.Text.Encoding))]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600417E RID: 16766 RVA: 0x0001FEF8 File Offset: 0x0001E0F8
			[global::Cpp2ILInjected.Token(Token = "0x60027AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9C118", Offset = "0x1B9C118", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected override void Dispose(bool disposing)
			{
				throw null;
			}

			// Token: 0x0600417F RID: 16767 RVA: 0x0001FEFB File Offset: 0x0001E0FB
			[global::Cpp2ILInjected.Token(Token = "0x60027AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9C11C", Offset = "0x1B9C11C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int Peek()
			{
				throw null;
			}

			// Token: 0x06004180 RID: 16768 RVA: 0x0001FEFE File Offset: 0x0001E0FE
			[global::Cpp2ILInjected.Token(Token = "0x60027AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9C124", Offset = "0x1B9C124", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int Read()
			{
				throw null;
			}

			// Token: 0x06004181 RID: 16769 RVA: 0x0001FF01 File Offset: 0x0001E101
			[global::Cpp2ILInjected.Token(Token = "0x60027AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9C12C", Offset = "0x1B9C12C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int Read(char[] buffer, int index, int count)
			{
				throw null;
			}

			// Token: 0x06004182 RID: 16770 RVA: 0x0001FF04 File Offset: 0x0001E104
			[global::Cpp2ILInjected.Token(Token = "0x60027B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9C134", Offset = "0x1B9C134", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override string ReadLine()
			{
				throw null;
			}

			// Token: 0x06004183 RID: 16771 RVA: 0x0001FF07 File Offset: 0x0001E107
			[global::Cpp2ILInjected.Token(Token = "0x60027B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9C13C", Offset = "0x1B9C13C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string ReadToEnd()
			{
				throw null;
			}

			// Token: 0x06004184 RID: 16772 RVA: 0x0001FF0A File Offset: 0x0001E10A
			[global::Cpp2ILInjected.Token(Token = "0x60027B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9C184", Offset = "0x1B9C184", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal override int ReadBuffer()
			{
				throw null;
			}
		}
	}
}
