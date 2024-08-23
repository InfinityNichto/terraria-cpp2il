using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x0200047C RID: 1148
	[global::Cpp2ILInjected.Token(Token = "0x2000545")]
	[global::System.Serializable]
	public abstract class TextWriter : global::System.MarshalByRefObject, global::System.IDisposable
	{
		// Token: 0x0600252A RID: 9514 RVA: 0x0001AC8A File Offset: 0x00018E8A
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

		// Token: 0x0600252B RID: 9515 RVA: 0x0001AC8D File Offset: 0x00018E8D
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

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x0001AC90 File Offset: 0x00018E90
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

		// Token: 0x0600252D RID: 9517 RVA: 0x0001AC93 File Offset: 0x00018E93
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

		// Token: 0x0600252E RID: 9518 RVA: 0x0001AC96 File Offset: 0x00018E96
		[global::Cpp2ILInjected.Token(Token = "0x60027E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E43C", Offset = "0x1B9E43C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringWriter), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x0001AC99 File Offset: 0x00018E99
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

		// Token: 0x06002530 RID: 9520 RVA: 0x0001AC9C File Offset: 0x00018E9C
		[global::Cpp2ILInjected.Token(Token = "0x60027E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E4AC", Offset = "0x1B9E4AC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Flush()
		{
			throw null;
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06002531 RID: 9521
		[global::Cpp2ILInjected.Token(Token = "0x170005BA")]
		public abstract global::System.Text.Encoding Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60027EA")]
			get;
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x0001AC9F File Offset: 0x00018E9F
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

		// Token: 0x06002533 RID: 9523 RVA: 0x0001ACA2 File Offset: 0x00018EA2
		[global::Cpp2ILInjected.Token(Token = "0x60027EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E4B8", Offset = "0x1B9E4B8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Write(char value)
		{
			throw null;
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x0001ACA5 File Offset: 0x00018EA5
		[global::Cpp2ILInjected.Token(Token = "0x60027ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E4BC", Offset = "0x1B9E4BC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(char[] buffer)
		{
			throw null;
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x0001ACA8 File Offset: 0x00018EA8
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

		// Token: 0x06002536 RID: 9526 RVA: 0x0001ACAB File Offset: 0x00018EAB
		[global::Cpp2ILInjected.Token(Token = "0x60027EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E64C", Offset = "0x1B9E64C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Write(string value)
		{
			throw null;
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x0001ACAE File Offset: 0x00018EAE
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

		// Token: 0x06002538 RID: 9528 RVA: 0x0001ACB1 File Offset: 0x00018EB1
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

		// Token: 0x06002539 RID: 9529 RVA: 0x0001ACB4 File Offset: 0x00018EB4
		[global::Cpp2ILInjected.Token(Token = "0x60027F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E744", Offset = "0x1B9E744", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void WriteLine()
		{
			throw null;
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x0001ACB7 File Offset: 0x00018EB7
		[global::Cpp2ILInjected.Token(Token = "0x60027F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E758", Offset = "0x1B9E758", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void WriteLine(string value)
		{
			throw null;
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x0001ACBA File Offset: 0x00018EBA
		[global::Cpp2ILInjected.Token(Token = "0x60027F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E794", Offset = "0x1B9E794", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual void WriteLine(object value)
		{
			throw null;
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x0001ACBD File Offset: 0x00018EBD
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

		// Token: 0x0600253D RID: 9533 RVA: 0x0001ACC0 File Offset: 0x00018EC0
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

		// Token: 0x0600253E RID: 9534 RVA: 0x0001ACC3 File Offset: 0x00018EC3
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

		// Token: 0x0600253F RID: 9535 RVA: 0x0001ACC6 File Offset: 0x00018EC6
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

		// Token: 0x06002540 RID: 9536 RVA: 0x0001ACC9 File Offset: 0x00018EC9
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

		// Token: 0x04001291 RID: 4753
		[global::Cpp2ILInjected.Token(Token = "0x40015B2")]
		public static readonly TextWriter Null;

		// Token: 0x04001292 RID: 4754
		[global::Cpp2ILInjected.Token(Token = "0x40015B3")]
		private static readonly char[] s_coreNewLine;

		// Token: 0x04001293 RID: 4755
		[global::Cpp2ILInjected.Token(Token = "0x40015B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected char[] CoreNewLine;

		// Token: 0x04001294 RID: 4756
		[global::Cpp2ILInjected.Token(Token = "0x40015B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string CoreNewLineStr;

		// Token: 0x04001295 RID: 4757
		[global::Cpp2ILInjected.Token(Token = "0x40015B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.IFormatProvider _internalFormatProvider;

		// Token: 0x02000614 RID: 1556
		[global::Cpp2ILInjected.Token(Token = "0x2000546")]
		[global::System.Serializable]
		private sealed class NullTextWriter : TextWriter
		{
			// Token: 0x06004190 RID: 16784 RVA: 0x0001FF2E File Offset: 0x0001E12E
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

			// Token: 0x17000775 RID: 1909
			// (get) Token: 0x06004191 RID: 16785 RVA: 0x0001FF31 File Offset: 0x0001E131
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

			// Token: 0x06004192 RID: 16786 RVA: 0x0001FF34 File Offset: 0x0001E134
			[global::Cpp2ILInjected.Token(Token = "0x60027FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EC0C", Offset = "0x1B9EC0C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Write(char[] buffer, int index, int count)
			{
				throw null;
			}

			// Token: 0x06004193 RID: 16787 RVA: 0x0001FF37 File Offset: 0x0001E137
			[global::Cpp2ILInjected.Token(Token = "0x60027FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EC10", Offset = "0x1B9EC10", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Write(string value)
			{
				throw null;
			}

			// Token: 0x06004194 RID: 16788 RVA: 0x0001FF3A File Offset: 0x0001E13A
			[global::Cpp2ILInjected.Token(Token = "0x60027FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EC14", Offset = "0x1B9EC14", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void WriteLine()
			{
				throw null;
			}

			// Token: 0x06004195 RID: 16789 RVA: 0x0001FF3D File Offset: 0x0001E13D
			[global::Cpp2ILInjected.Token(Token = "0x60027FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EC18", Offset = "0x1B9EC18", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void WriteLine(string value)
			{
				throw null;
			}

			// Token: 0x06004196 RID: 16790 RVA: 0x0001FF40 File Offset: 0x0001E140
			[global::Cpp2ILInjected.Token(Token = "0x6002800")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EC1C", Offset = "0x1B9EC1C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void WriteLine(object value)
			{
				throw null;
			}

			// Token: 0x06004197 RID: 16791 RVA: 0x0001FF43 File Offset: 0x0001E143
			[global::Cpp2ILInjected.Token(Token = "0x6002801")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EC20", Offset = "0x1B9EC20", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void Write(char value)
			{
				throw null;
			}
		}

		// Token: 0x02000615 RID: 1557
		[global::Cpp2ILInjected.Token(Token = "0x2000547")]
		[global::System.Serializable]
		internal sealed class SyncTextWriter : TextWriter, global::System.IDisposable
		{
			// Token: 0x06004198 RID: 16792 RVA: 0x0001FF46 File Offset: 0x0001E146
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

			// Token: 0x17000776 RID: 1910
			// (get) Token: 0x06004199 RID: 16793 RVA: 0x0001FF49 File Offset: 0x0001E149
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

			// Token: 0x17000777 RID: 1911
			// (get) Token: 0x0600419A RID: 16794 RVA: 0x0001FF4C File Offset: 0x0001E14C
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

			// Token: 0x17000778 RID: 1912
			// (get) Token: 0x0600419B RID: 16795 RVA: 0x0001FF4F File Offset: 0x0001E14F
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

			// Token: 0x0600419C RID: 16796 RVA: 0x0001FF52 File Offset: 0x0001E152
			[global::Cpp2ILInjected.Token(Token = "0x6002806")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EC54", Offset = "0x1B9EC54", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Close()
			{
				throw null;
			}

			// Token: 0x0600419D RID: 16797 RVA: 0x0001FF55 File Offset: 0x0001E155
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

			// Token: 0x0600419E RID: 16798 RVA: 0x0001FF58 File Offset: 0x0001E158
			[global::Cpp2ILInjected.Token(Token = "0x6002808")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED10", Offset = "0x1B9ED10", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Flush()
			{
				throw null;
			}

			// Token: 0x0600419F RID: 16799 RVA: 0x0001FF5B File Offset: 0x0001E15B
			[global::Cpp2ILInjected.Token(Token = "0x6002809")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED20", Offset = "0x1B9ED20", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Write(char value)
			{
				throw null;
			}

			// Token: 0x060041A0 RID: 16800 RVA: 0x0001FF5E File Offset: 0x0001E15E
			[global::Cpp2ILInjected.Token(Token = "0x600280A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED34", Offset = "0x1B9ED34", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Write(char[] buffer)
			{
				throw null;
			}

			// Token: 0x060041A1 RID: 16801 RVA: 0x0001FF61 File Offset: 0x0001E161
			[global::Cpp2ILInjected.Token(Token = "0x600280B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED48", Offset = "0x1B9ED48", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Write(char[] buffer, int index, int count)
			{
				throw null;
			}

			// Token: 0x060041A2 RID: 16802 RVA: 0x0001FF64 File Offset: 0x0001E164
			[global::Cpp2ILInjected.Token(Token = "0x600280C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED5C", Offset = "0x1B9ED5C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Write(string value)
			{
				throw null;
			}

			// Token: 0x060041A3 RID: 16803 RVA: 0x0001FF67 File Offset: 0x0001E167
			[global::Cpp2ILInjected.Token(Token = "0x600280D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED70", Offset = "0x1B9ED70", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Write(string format, object arg0)
			{
				throw null;
			}

			// Token: 0x060041A4 RID: 16804 RVA: 0x0001FF6A File Offset: 0x0001E16A
			[global::Cpp2ILInjected.Token(Token = "0x600280E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED84", Offset = "0x1B9ED84", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Write(string format, object arg0, object arg1, object arg2)
			{
				throw null;
			}

			// Token: 0x060041A5 RID: 16805 RVA: 0x0001FF6D File Offset: 0x0001E16D
			[global::Cpp2ILInjected.Token(Token = "0x600280F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9ED98", Offset = "0x1B9ED98", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void WriteLine()
			{
				throw null;
			}

			// Token: 0x060041A6 RID: 16806 RVA: 0x0001FF70 File Offset: 0x0001E170
			[global::Cpp2ILInjected.Token(Token = "0x6002810")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EDAC", Offset = "0x1B9EDAC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void WriteLine(string value)
			{
				throw null;
			}

			// Token: 0x060041A7 RID: 16807 RVA: 0x0001FF73 File Offset: 0x0001E173
			[global::Cpp2ILInjected.Token(Token = "0x6002811")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EDC0", Offset = "0x1B9EDC0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void WriteLine(object value)
			{
				throw null;
			}

			// Token: 0x060041A8 RID: 16808 RVA: 0x0001FF76 File Offset: 0x0001E176
			[global::Cpp2ILInjected.Token(Token = "0x6002812")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EDD4", Offset = "0x1B9EDD4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void WriteLine(string format, object arg0)
			{
				throw null;
			}

			// Token: 0x060041A9 RID: 16809 RVA: 0x0001FF79 File Offset: 0x0001E179
			[global::Cpp2ILInjected.Token(Token = "0x6002813")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EDE8", Offset = "0x1B9EDE8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void WriteLine(string format, object arg0, object arg1)
			{
				throw null;
			}

			// Token: 0x060041AA RID: 16810 RVA: 0x0001FF7C File Offset: 0x0001E17C
			[global::Cpp2ILInjected.Token(Token = "0x6002814")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EDFC", Offset = "0x1B9EDFC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void WriteLine(string format, params object[] arg)
			{
				throw null;
			}

			// Token: 0x040019A9 RID: 6569
			[global::Cpp2ILInjected.Token(Token = "0x40015B7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private readonly TextWriter _out;
		}
	}
}
