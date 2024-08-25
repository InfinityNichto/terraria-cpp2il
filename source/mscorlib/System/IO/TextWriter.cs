using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	[global::Cpp2ILInjected.Token(Token = "0x2000545")]
	[global::System.Serializable]
	public abstract class TextWriter : global::System.MarshalByRefObject, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x60027E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9CAA4", Offset = "0x1B9CAA4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.IO.ConsoleOutputMirror.DoubleWriter", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextWriter),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(global::System.Text.Encoding),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnityLogWriter", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected TextWriter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9C340", Offset = "0x1B9C340", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextWriter.NullTextWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextWriter.SyncTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected TextWriter(global::System.IFormatProvider formatProvider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005B9")]
		public virtual global::System.IFormatProvider FormatProvider
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9E368", Offset = "0x1B9E368", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E3D0", Offset = "0x1B9E3D0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void Close()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E43C", Offset = "0x1B9E43C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringWriter), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E440", Offset = "0x1B9E440", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E4AC", Offset = "0x1B9E4AC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Flush()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005BA")]
		public abstract global::System.Text.Encoding Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027EA")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005BB")]
		public virtual string NewLine
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9E4B0", Offset = "0x1B9E4B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E4B8", Offset = "0x1B9E4B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Write(char value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E4BC", Offset = "0x1B9E4BC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(char[] buffer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E4DC", Offset = "0x1B9E4DC", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public virtual void Write(char[] buffer, int index, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E64C", Offset = "0x1B9E64C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E684", Offset = "0x1B9E684", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(string format, object arg0)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E6D8", Offset = "0x1B9E6D8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(string format, object arg0, object arg1, object arg2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E744", Offset = "0x1B9E744", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void WriteLine()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E758", Offset = "0x1B9E758", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void WriteLine(string value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E794", Offset = "0x1B9E794", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual void WriteLine(object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E8B4", Offset = "0x1B9E8B4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void WriteLine(string format, object arg0)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E908", Offset = "0x1B9E908", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void WriteLine(string format, object arg0, object arg1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E96C", Offset = "0x1B9E96C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void WriteLine(string format, params object[] arg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60027F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E9C0", Offset = "0x1B9E9C0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
		{
			typeof(global::System.Text.Encoding),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "SetOut", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextWriter.SyncTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static TextWriter Synchronized(TextWriter writer)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60027F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9EAF0", Offset = "0x1B9EAF0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextWriter.NullTextWriter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static TextWriter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40015B2")]
		public static readonly TextWriter Null;

		[global::Cpp2ILInjected.Token(Token = "0x40015B3")]
		private static readonly char[] s_coreNewLine;

		[global::Cpp2ILInjected.Token(Token = "0x40015B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected char[] CoreNewLine;

		[global::Cpp2ILInjected.Token(Token = "0x40015B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string CoreNewLineStr;

		[global::Cpp2ILInjected.Token(Token = "0x40015B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.IFormatProvider _internalFormatProvider;

		[global::Cpp2ILInjected.Token(Token = "0x2000546")]
		[global::System.Serializable]
		private sealed class NullTextWriter : TextWriter
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EB78", Offset = "0x1B9EB78", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextWriter), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			internal NullTextWriter()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005BC")]
			public override global::System.Text.Encoding Encoding
			{
				[global::Cpp2ILInjected.Token(Token = "0x60027FB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B9EC04", Offset = "0x1B9EC04", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_Unicode", ReturnType = typeof(global::System.Text.Encoding))]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x60027FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EC0C", Offset = "0x1B9EC0C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Write(char[] buffer, int index, int count)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60027FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EC10", Offset = "0x1B9EC10", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Write(string value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60027FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EC14", Offset = "0x1B9EC14", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void WriteLine()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60027FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EC18", Offset = "0x1B9EC18", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void WriteLine(string value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002800")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EC1C", Offset = "0x1B9EC1C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void WriteLine(object value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002801")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EC20", Offset = "0x1B9EC20", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Write(char value)
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000547")]
		[global::System.Serializable]
		internal sealed class SyncTextWriter : TextWriter, global::System.IDisposable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002802")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EA74", Offset = "0x1B9EA74", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextWriter), Member = "Synchronized", MemberParameters = new object[] { typeof(TextWriter) }, ReturnType = typeof(TextWriter))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.IFormatProvider) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal SyncTextWriter(TextWriter t)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005BD")]
			public override global::System.Text.Encoding Encoding
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002803")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B9EC24", Offset = "0x1B9EC24", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005BE")]
			public override global::System.IFormatProvider FormatProvider
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002804")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B9EC34", Offset = "0x1B9EC34", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x170005BF")]
			public override string NewLine
			{
				[global::Cpp2ILInjected.Token(Token = "0x6002805")]
				[global::Cpp2ILInjected.Address(RVA = "0x1B9EC44", Offset = "0x1B9EC44", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				[MethodImpl(32)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002806")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EC54", Offset = "0x1B9EC54", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Close()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002807")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EC64", Offset = "0x1B9EC64", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			[MethodImpl(32)]
			protected override void Dispose(bool disposing)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002808")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED10", Offset = "0x1B9ED10", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Flush()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002809")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED20", Offset = "0x1B9ED20", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Write(char value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600280A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED34", Offset = "0x1B9ED34", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Write(char[] buffer)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600280B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED48", Offset = "0x1B9ED48", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Write(char[] buffer, int index, int count)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600280C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED5C", Offset = "0x1B9ED5C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Write(string value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600280D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED70", Offset = "0x1B9ED70", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Write(string format, object arg0)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600280E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED84", Offset = "0x1B9ED84", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Write(string format, object arg0, object arg1, object arg2)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600280F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED98", Offset = "0x1B9ED98", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void WriteLine()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002810")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EDAC", Offset = "0x1B9EDAC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void WriteLine(string value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002811")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EDC0", Offset = "0x1B9EDC0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void WriteLine(object value)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002812")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EDD4", Offset = "0x1B9EDD4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void WriteLine(string format, object arg0)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002813")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EDE8", Offset = "0x1B9EDE8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void WriteLine(string format, object arg0, object arg1)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6002814")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EDFC", Offset = "0x1B9EDFC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void WriteLine(string format, params object[] arg)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40015B7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private readonly TextWriter _out;
		}
	}
}
