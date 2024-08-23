using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000C0 RID: 192
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(global::System.MemoryDebugView<>))]
	[global::System.Diagnostics.DebuggerDisplay("{ToString(),raw}")]
	[global::Cpp2ILInjected.Token(Token = "0x20000F2")]
	public readonly struct ReadOnlyMemory<T> : global::System.IEquatable<global::System.ReadOnlyMemory<T>>
	{
		// Token: 0x0600084C RID: 2124 RVA: 0x00015D5B File Offset: 0x00013F5B
		[global::Cpp2ILInjected.Token(Token = "0x60008F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x185E990", Offset = "0x185E990", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public ReadOnlyMemory(T[] array)
		{
			throw null;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00015D5E File Offset: 0x00013F5E
		[global::Cpp2ILInjected.Token(Token = "0x60008F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x185E9B0", Offset = "0x185E9B0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[MethodImpl(256)]
		public ReadOnlyMemory(T[] array, int start, int length)
		{
			throw null;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00015D61 File Offset: 0x00013F61
		[global::Cpp2ILInjected.Token(Token = "0x1700009D")]
		public int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x185EA1C", Offset = "0x185EA1C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "WriteAsync", MemberParameters = new object[]
			{
				typeof(global::System.ReadOnlyMemory<byte>),
				typeof(global::System.Threading.CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncApm", MemberParameters = new object[] { "System.ReadOnlyMemory`1<Byte>", "System.Net.Sockets.SocketFlags" }, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00015D64 File Offset: 0x00013F64
		[global::Cpp2ILInjected.Token(Token = "0x60008F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x185EA28", Offset = "0x185EA28", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00015D67 File Offset: 0x00013F67
		[global::Cpp2ILInjected.Token(Token = "0x1700009E")]
		public global::System.ReadOnlySpan<T> Span
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x185EC1C", Offset = "0x185EC1C", Length = "0x3A0")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00015D6A File Offset: 0x00013F6A
		[global::Cpp2ILInjected.Token(Token = "0x60008F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x185EFBC", Offset = "0x185EFBC", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00015D6D File Offset: 0x00013F6D
		[global::Cpp2ILInjected.Token(Token = "0x60008FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x185F19C", Offset = "0x185F19C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Memory<>), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool Equals(global::System.ReadOnlyMemory<T> other)
		{
			throw null;
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00015D70 File Offset: 0x00013F70
		[global::Cpp2ILInjected.Token(Token = "0x60008FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x185F1D0", Offset = "0x185F1D0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00015D73 File Offset: 0x00013F73
		[global::Cpp2ILInjected.Token(Token = "0x60008FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x185F298", Offset = "0x185F298", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int CombineHashCodes(int left, int right)
		{
			throw null;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00015D76 File Offset: 0x00013F76
		[global::Cpp2ILInjected.Token(Token = "0x60008FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x185F2A4", Offset = "0x185F2A4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static int CombineHashCodes(int h1, int h2, int h3)
		{
			throw null;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00015D79 File Offset: 0x00013F79
		[global::Cpp2ILInjected.Token(Token = "0x60008FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x185F388", Offset = "0x185F388", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		internal object GetObjectStartLength(out int start, out int length)
		{
			throw null;
		}

		// Token: 0x0400023C RID: 572
		[global::Cpp2ILInjected.Token(Token = "0x400038E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly object _object;

		// Token: 0x0400023D RID: 573
		[global::Cpp2ILInjected.Token(Token = "0x400038F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int _index;

		// Token: 0x0400023E RID: 574
		[global::Cpp2ILInjected.Token(Token = "0x4000390")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int _length;
	}
}
