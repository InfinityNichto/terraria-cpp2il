using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;

namespace ReLogic.IO
{
	// Token: 0x02000735 RID: 1845
	[global::Cpp2ILInjected.Token(Token = "0x2000B34")]
	public class ConsoleOutputMirror : IDisposable
	{
		// Token: 0x060046F3 RID: 18163 RVA: 0x0002EAE1 File Offset: 0x0002CCE1
		[global::Cpp2ILInjected.Token(Token = "0x60053A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x944DF8", Offset = "0x944DF8", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Program), Member = "SetupLogging", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConsoleOutputMirror), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void ToFile(string path)
		{
			throw null;
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x0002EAE4 File Offset: 0x0002CCE4
		[global::Cpp2ILInjected.Token(Token = "0x60053A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x944F44", Offset = "0x944F44", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConsoleOutputMirror), Member = "ToFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetParent", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConsoleOutputMirror.DoubleWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "SetOut", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private ConsoleOutputMirror(string path)
		{
			throw null;
		}

		// Token: 0x060046F5 RID: 18165 RVA: 0x0002EAE7 File Offset: 0x0002CCE7
		[global::Cpp2ILInjected.Token(Token = "0x60053AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x945114", Offset = "0x945114", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "SetOut", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060046F6 RID: 18166 RVA: 0x0002EAEA File Offset: 0x0002CCEA
		[global::Cpp2ILInjected.Token(Token = "0x60053AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x944F34", Offset = "0x944F34", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x04007343 RID: 29507
		[global::Cpp2ILInjected.Token(Token = "0x4008CE0")]
		private static ConsoleOutputMirror _instance;

		// Token: 0x04007344 RID: 29508
		[global::Cpp2ILInjected.Token(Token = "0x4008CE1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private FileStream _fileStream;

		// Token: 0x04007345 RID: 29509
		[global::Cpp2ILInjected.Token(Token = "0x4008CE2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private StreamWriter _fileWriter;

		// Token: 0x04007346 RID: 29510
		[global::Cpp2ILInjected.Token(Token = "0x4008CE3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private TextWriter _newConsoleOutput;

		// Token: 0x04007347 RID: 29511
		[global::Cpp2ILInjected.Token(Token = "0x4008CE4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly TextWriter _oldConsoleOutput;

		// Token: 0x04007348 RID: 29512
		[global::Cpp2ILInjected.Token(Token = "0x4008CE5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _disposedValue;

		// Token: 0x02000ADB RID: 2779
		[global::Cpp2ILInjected.Token(Token = "0x2000B35")]
		private class DoubleWriter : TextWriter
		{
			// Token: 0x060052E1 RID: 21217 RVA: 0x000309E9 File Offset: 0x0002EBE9
			[global::Cpp2ILInjected.Token(Token = "0x60053AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x9450A4", Offset = "0x9450A4", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConsoleOutputMirror), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextWriter), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public DoubleWriter(TextWriter first, TextWriter second)
			{
				throw null;
			}

			// Token: 0x1700090C RID: 2316
			// (get) Token: 0x060052E2 RID: 21218 RVA: 0x000309EC File Offset: 0x0002EBEC
			[global::Cpp2ILInjected.Token(Token = "0x1700090E")]
			public override Encoding Encoding
			{
				[global::Cpp2ILInjected.Token(Token = "0x60053AD")]
				[global::Cpp2ILInjected.Address(RVA = "0x9451D0", Offset = "0x9451D0", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060052E3 RID: 21219 RVA: 0x000309EF File Offset: 0x0002EBEF
			[global::Cpp2ILInjected.Token(Token = "0x60053AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x9451E0", Offset = "0x9451E0", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void Flush()
			{
				throw null;
			}

			// Token: 0x060052E4 RID: 21220 RVA: 0x000309F2 File Offset: 0x0002EBF2
			[global::Cpp2ILInjected.Token(Token = "0x60053AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x94520C", Offset = "0x94520C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override void Write(char value)
			{
				throw null;
			}

			// Token: 0x04008FA9 RID: 36777
			[global::Cpp2ILInjected.Token(Token = "0x4008CE6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private readonly TextWriter _first;

			// Token: 0x04008FAA RID: 36778
			[global::Cpp2ILInjected.Token(Token = "0x4008CE7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private readonly TextWriter _second;
		}
	}
}
