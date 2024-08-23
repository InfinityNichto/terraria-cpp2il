﻿using System;
using System.Buffers;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000A8 RID: 168
	[global::System.Diagnostics.DebuggerDisplay("{ToString(),raw}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(global::System.MemoryDebugView<>))]
	[global::Cpp2ILInjected.Token(Token = "0x20000D8")]
	public readonly struct Memory<T> : global::System.IEquatable<global::System.Memory<T>>
	{
		// Token: 0x0600076E RID: 1902 RVA: 0x00015AC1 File Offset: 0x00013CC1
		[global::Cpp2ILInjected.Token(Token = "0x6000813")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C9E3C", Offset = "0x17C9E3C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public Memory(T[] array)
		{
			throw null;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00015AC4 File Offset: 0x00013CC4
		[global::Cpp2ILInjected.Token(Token = "0x6000814")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C9E94", Offset = "0x17C9E94", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public Memory(T[] array, int start, int length)
		{
			throw null;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00015AC7 File Offset: 0x00013CC7
		[global::Cpp2ILInjected.Token(Token = "0x6000815")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C9F20", Offset = "0x17C9F20", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		internal Memory(object obj, int start, int length)
		{
			throw null;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00015ACA File Offset: 0x00013CCA
		[global::Cpp2ILInjected.Token(Token = "0x6000816")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C9F2C", Offset = "0x17C9F2C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "BeginReceive", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			"System.Net.Sockets.SocketFlags",
			"System.Net.Sockets.SocketError&",
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "BeginReceiveFrom", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			"System.Net.Sockets.SocketFlags",
			"System.Net.EndPoint&",
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "BeginSend", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			"System.Net.Sockets.SocketFlags",
			"System.Net.Sockets.SocketError&",
			typeof(global::System.AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(global::System.IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SocketAsyncResult", Member = "Init", MemberParameters = new object[]
		{
			"System.Net.Sockets.Socket",
			typeof(global::System.AsyncCallback),
			typeof(object),
			"System.Net.Sockets.SocketOperation"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator global::System.Memory<T>(T[] array)
		{
			throw null;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00015ACD File Offset: 0x00013CCD
		[global::Cpp2ILInjected.Token(Token = "0x6000817")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C9F94", Offset = "0x17C9F94", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(global::System.Memory<byte>),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(global::System.Memory<byte>),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(global::System.Memory<byte>),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsyncApm", MemberParameters = new object[] { "System.Memory`1<Byte>", "System.Net.Sockets.SocketFlags" }, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static implicit operator global::System.ReadOnlyMemory<T>(global::System.Memory<T> memory)
		{
			throw null;
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x00015AD0 File Offset: 0x00013CD0
		[global::Cpp2ILInjected.Token(Token = "0x17000090")]
		public int Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000818")]
			[global::Cpp2ILInjected.Address(RVA = "0x17C9F98", Offset = "0x17C9F98", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "ReadAsync", MemberParameters = new object[]
			{
				typeof(global::System.Memory<byte>),
				typeof(global::System.Threading.CancellationToken)
			}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask<int>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsyncApm", MemberParameters = new object[] { "System.Memory`1<Byte>", "System.Net.Sockets.SocketFlags" }, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.SocketAsyncEventArgs", Member = "SetBuffer", MemberParameters = new object[] { "System.Memory`1<Byte>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00015AD3 File Offset: 0x00013CD3
		[global::Cpp2ILInjected.Token(Token = "0x6000819")]
		[global::Cpp2ILInjected.Address(RVA = "0x17C9FA4", Offset = "0x17C9FA4", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "ToString", ReturnType = typeof(string))]
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

		// Token: 0x06000775 RID: 1909 RVA: 0x00015AD6 File Offset: 0x00013CD6
		[global::Cpp2ILInjected.Token(Token = "0x600081A")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CA198", Offset = "0x17CA198", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public global::System.Memory<T> Slice(int start, int length)
		{
			throw null;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x00015AD9 File Offset: 0x00013CD9
		[global::Cpp2ILInjected.Token(Token = "0x17000091")]
		public global::System.Span<T> Span
		{
			[global::Cpp2ILInjected.Token(Token = "0x600081B")]
			[global::Cpp2ILInjected.Address(RVA = "0x17CA218", Offset = "0x17CA218", Length = "0x340")]
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00015ADC File Offset: 0x00013CDC
		[global::Cpp2ILInjected.Token(Token = "0x600081C")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CA558", Offset = "0x17CA558", Length = "0x2CC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<.cctor>b__367_11", MemberParameters = new object[] { "System.IOAsyncResult" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Receive", MemberParameters = new object[]
		{
			"System.Memory`1<Byte>",
			typeof(int),
			typeof(int),
			"System.Net.Sockets.SocketFlags",
			"System.Net.Sockets.SocketError&"
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveFrom", MemberParameters = new object[]
		{
			"System.Memory`1<Byte>",
			typeof(int),
			typeof(int),
			"System.Net.Sockets.SocketFlags",
			"System.Net.EndPoint&",
			"System.Net.Sockets.SocketError&"
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "BeginSendCallback", MemberParameters = new object[]
		{
			"System.Net.Sockets.SocketAsyncResult",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.GCHandle), Member = "Alloc", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.InteropServices.GCHandleType)
		}, ReturnType = typeof(global::System.Runtime.InteropServices.GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(ref char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffers.MemoryHandle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(global::System.Runtime.InteropServices.GCHandle),
			typeof(global::System.Buffers.IPinnable)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public unsafe global::System.Buffers.MemoryHandle Pin()
		{
			throw null;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00015ADF File Offset: 0x00013CDF
		[global::Cpp2ILInjected.Token(Token = "0x600081D")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CA824", Offset = "0x17CA824", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "EndAccept", MemberParameters = new object[]
		{
			"System.Byte[]&",
			typeof(ref int),
			typeof(global::System.IAsyncResult)
		}, ReturnType = "System.Net.Sockets.Socket")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public T[] ToArray()
		{
			throw null;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00015AE2 File Offset: 0x00013CE2
		[global::Cpp2ILInjected.Token(Token = "0x600081E")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CA898", Offset = "0x17CA898", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlyMemory<>), Member = "Equals", MemberParameters = new object[] { "System.ReadOnlyMemory`1<T>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00015AE5 File Offset: 0x00013CE5
		[global::Cpp2ILInjected.Token(Token = "0x600081F")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CAAAC", Offset = "0x17CAAAC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsync", MemberParameters = new object[] { "System.Net.Sockets.SocketAsyncEventArgs" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsync", MemberParameters = new object[] { "System.Net.Sockets.SocketAsyncEventArgs" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool Equals(global::System.Memory<T> other)
		{
			throw null;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00015AE8 File Offset: 0x00013CE8
		[global::Cpp2ILInjected.Token(Token = "0x6000820")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CAAE0", Offset = "0x17CAAE0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00015AEB File Offset: 0x00013CEB
		[global::Cpp2ILInjected.Token(Token = "0x6000821")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CABA8", Offset = "0x17CABA8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int CombineHashCodes(int left, int right)
		{
			throw null;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00015AEE File Offset: 0x00013CEE
		[global::Cpp2ILInjected.Token(Token = "0x6000822")]
		[global::Cpp2ILInjected.Address(RVA = "0x17CABB4", Offset = "0x17CABB4", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static int CombineHashCodes(int h1, int h2, int h3)
		{
			throw null;
		}

		// Token: 0x0400021A RID: 538
		[global::Cpp2ILInjected.Token(Token = "0x4000367")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly object _object;

		// Token: 0x0400021B RID: 539
		[global::Cpp2ILInjected.Token(Token = "0x4000368")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int _index;

		// Token: 0x0400021C RID: 540
		[global::Cpp2ILInjected.Token(Token = "0x4000369")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int _length;
	}
}