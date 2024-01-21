using System;
using System.IO;
using System.Text;
using Cpp2IlInjected;

namespace ReLogic.IO;

[Cpp2IlInjected.Token(Token = "0x2000738")]
public class ConsoleOutputMirror : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000AD2")]
	private class DoubleWriter : TextWriter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4008F96")]
		private readonly TextWriter _first;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4008F97")]
		private readonly TextWriter _second;

		[Cpp2IlInjected.Token(Token = "0x1700090E")]
		public override Encoding Encoding
		{
			[Cpp2IlInjected.Token(Token = "0x6005319")]
			[Cpp2IlInjected.Address(RVA = "0xF90F44", Offset = "0xF90F44", VA = "0xF90F44", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6005318")]
		[Cpp2IlInjected.Address(RVA = "0xF90EB8", Offset = "0xF90EB8", VA = "0xF90EB8")]
		public DoubleWriter(TextWriter first, TextWriter second)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600531A")]
		[Cpp2IlInjected.Address(RVA = "0xF90F58", Offset = "0xF90F58", VA = "0xF90F58", Slot = "10")]
		public override void Flush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600531B")]
		[Cpp2IlInjected.Address(RVA = "0xF90F90", Offset = "0xF90F90", VA = "0xF90F90", Slot = "12")]
		public override void Write(char value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4007344")]
	private static ConsoleOutputMirror _instance;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4007345")]
	private FileStream _fileStream;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4007346")]
	private StreamWriter _fileWriter;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4007347")]
	private TextWriter _newConsoleOutput;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4007348")]
	private readonly TextWriter _oldConsoleOutput;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4007349")]
	private bool _disposedValue;

	[Cpp2IlInjected.Token(Token = "0x6004732")]
	[Cpp2IlInjected.Address(RVA = "0x10C1498", Offset = "0x10C1498", VA = "0x10C1498")]
	public static void ToFile(string path)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004733")]
	[Cpp2IlInjected.Address(RVA = "0x10C1620", Offset = "0x10C1620", VA = "0x10C1620")]
	private ConsoleOutputMirror(string path)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004734")]
	[Cpp2IlInjected.Address(RVA = "0x10C17B8", Offset = "0x10C17B8", VA = "0x10C17B8", Slot = "5")]
	protected virtual void Dispose(bool disposing)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004735")]
	[Cpp2IlInjected.Address(RVA = "0x10C160C", Offset = "0x10C160C", VA = "0x10C160C", Slot = "4")]
	public void Dispose()
	{
	}
}
