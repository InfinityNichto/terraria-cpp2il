using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x0200047B RID: 1147
	[global::Cpp2ILInjected.Token(Token = "0x2000542")]
	[global::System.Serializable]
	public abstract class TextReader : global::System.MarshalByRefObject, global::System.IDisposable
	{
		// Token: 0x0600251F RID: 9503 RVA: 0x0001AC69 File Offset: 0x00018E69
		[global::Cpp2ILInjected.Token(Token = "0x60027CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9A79C", Offset = "0x1B9A79C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		protected TextReader()
		{
			throw null;
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x0001AC6C File Offset: 0x00018E6C
		[global::Cpp2ILInjected.Token(Token = "0x60027CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9DC18", Offset = "0x1B9DC18", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void Close()
		{
			throw null;
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x0001AC6F File Offset: 0x00018E6F
		[global::Cpp2ILInjected.Token(Token = "0x60027CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9DC84", Offset = "0x1B9DC84", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x0001AC72 File Offset: 0x00018E72
		[global::Cpp2ILInjected.Token(Token = "0x60027D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9DCF0", Offset = "0x1B9DCF0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringReader), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x0001AC75 File Offset: 0x00018E75
		[global::Cpp2ILInjected.Token(Token = "0x60027D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9DCF4", Offset = "0x1B9DCF4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual int Peek()
		{
			throw null;
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x0001AC78 File Offset: 0x00018E78
		[global::Cpp2ILInjected.Token(Token = "0x60027D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9DCFC", Offset = "0x1B9DCFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual int Read()
		{
			throw null;
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x0001AC7B File Offset: 0x00018E7B
		[global::Cpp2ILInjected.Token(Token = "0x60027D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9DD04", Offset = "0x1B9DD04", Length = "0x188")]
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
		public virtual int Read(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x0001AC7E File Offset: 0x00018E7E
		[global::Cpp2ILInjected.Token(Token = "0x60027D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9DE8C", Offset = "0x1B9DE8C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual string ReadToEnd()
		{
			throw null;
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x0001AC81 File Offset: 0x00018E81
		[global::Cpp2ILInjected.Token(Token = "0x60027D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9DF7C", Offset = "0x1B9DF7C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual string ReadLine()
		{
			throw null;
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x0001AC84 File Offset: 0x00018E84
		[global::Cpp2ILInjected.Token(Token = "0x60027D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E064", Offset = "0x1B9E064", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
		{
			typeof(global::System.Text.Encoding),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextReader.SyncTextReader), Member = ".ctor", MemberParameters = new object[] { typeof(TextReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static TextReader Synchronized(TextReader reader)
		{
			throw null;
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x0001AC87 File Offset: 0x00018E87
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60027D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9E184", Offset = "0x1B9E184", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextReader.NullTextReader), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static TextReader()
		{
			throw null;
		}

		// Token: 0x04001290 RID: 4752
		[global::Cpp2ILInjected.Token(Token = "0x40015B0")]
		public static readonly TextReader Null;

		// Token: 0x02000612 RID: 1554
		[global::Cpp2ILInjected.Token(Token = "0x2000543")]
		[global::System.Serializable]
		private sealed class NullTextReader : TextReader
		{
			// Token: 0x06004185 RID: 16773 RVA: 0x0001FF0D File Offset: 0x0001E10D
			[global::Cpp2ILInjected.Token(Token = "0x60027D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9E1F0", Offset = "0x1B9E1F0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextReader), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public NullTextReader()
			{
				throw null;
			}

			// Token: 0x06004186 RID: 16774 RVA: 0x0001FF10 File Offset: 0x0001E110
			[global::Cpp2ILInjected.Token(Token = "0x60027D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9E248", Offset = "0x1B9E248", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int Read(char[] buffer, int index, int count)
			{
				throw null;
			}

			// Token: 0x06004187 RID: 16775 RVA: 0x0001FF13 File Offset: 0x0001E113
			[global::Cpp2ILInjected.Token(Token = "0x60027DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9E250", Offset = "0x1B9E250", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override string ReadLine()
			{
				throw null;
			}
		}

		// Token: 0x02000613 RID: 1555
		[global::Cpp2ILInjected.Token(Token = "0x2000544")]
		[global::System.Serializable]
		internal sealed class SyncTextReader : TextReader
		{
			// Token: 0x06004188 RID: 16776 RVA: 0x0001FF16 File Offset: 0x0001E116
			[global::Cpp2ILInjected.Token(Token = "0x60027DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9E118", Offset = "0x1B9E118", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TextReader), Member = "Synchronized", MemberParameters = new object[] { typeof(TextReader) }, ReturnType = typeof(TextReader))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal SyncTextReader(TextReader t)
			{
				throw null;
			}

			// Token: 0x06004189 RID: 16777 RVA: 0x0001FF19 File Offset: 0x0001E119
			[global::Cpp2ILInjected.Token(Token = "0x60027DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9E258", Offset = "0x1B9E258", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override void Close()
			{
				throw null;
			}

			// Token: 0x0600418A RID: 16778 RVA: 0x0001FF1C File Offset: 0x0001E11C
			[global::Cpp2ILInjected.Token(Token = "0x60027DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9E268", Offset = "0x1B9E268", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			[MethodImpl(32)]
			protected override void Dispose(bool disposing)
			{
				throw null;
			}

			// Token: 0x0600418B RID: 16779 RVA: 0x0001FF1F File Offset: 0x0001E11F
			[global::Cpp2ILInjected.Token(Token = "0x60027DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9E314", Offset = "0x1B9E314", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override int Peek()
			{
				throw null;
			}

			// Token: 0x0600418C RID: 16780 RVA: 0x0001FF22 File Offset: 0x0001E122
			[global::Cpp2ILInjected.Token(Token = "0x60027DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9E324", Offset = "0x1B9E324", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override int Read()
			{
				throw null;
			}

			// Token: 0x0600418D RID: 16781 RVA: 0x0001FF25 File Offset: 0x0001E125
			[global::Cpp2ILInjected.Token(Token = "0x60027E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9E334", Offset = "0x1B9E334", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override int Read(char[] buffer, int index, int count)
			{
				throw null;
			}

			// Token: 0x0600418E RID: 16782 RVA: 0x0001FF28 File Offset: 0x0001E128
			[global::Cpp2ILInjected.Token(Token = "0x60027E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9E344", Offset = "0x1B9E344", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override string ReadLine()
			{
				throw null;
			}

			// Token: 0x0600418F RID: 16783 RVA: 0x0001FF2B File Offset: 0x0001E12B
			[global::Cpp2ILInjected.Token(Token = "0x60027E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9E358", Offset = "0x1B9E358", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(32)]
			public override string ReadToEnd()
			{
				throw null;
			}

			// Token: 0x040019A8 RID: 6568
			[global::Cpp2ILInjected.Token(Token = "0x40015B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal readonly TextReader _in;
		}
	}
}
