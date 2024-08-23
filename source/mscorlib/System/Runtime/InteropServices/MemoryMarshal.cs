using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000387 RID: 903
	[global::Cpp2ILInjected.Token(Token = "0x2000431")]
	public static class MemoryMarshal
	{
		// Token: 0x06001F10 RID: 7952 RVA: 0x00019C37 File Offset: 0x00017E37
		[global::Cpp2ILInjected.Token(Token = "0x6002151")]
		[global::Cpp2ILInjected.Address(RVA = "0x1591E68", Offset = "0x1591E68", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(256)]
		public static global::System.Span<byte> AsBytes<T>(global::System.Span<T> span) where T : struct
		{
			throw null;
		}

		// Token: 0x06001F11 RID: 7953 RVA: 0x00019C3A File Offset: 0x00017E3A
		[global::Cpp2ILInjected.Token(Token = "0x6002152")]
		[global::Cpp2ILInjected.Address(RVA = "0x1591F10", Offset = "0x1591F10", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		[MethodImpl(256)]
		public static global::System.ReadOnlySpan<byte> AsBytes<T>(global::System.ReadOnlySpan<T> span) where T : struct
		{
			throw null;
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x00019C3D File Offset: 0x00017E3D
		[global::Cpp2ILInjected.Token(Token = "0x6002153")]
		[global::Cpp2ILInjected.Address(RVA = "0x1592108", Offset = "0x1592108", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncForNetworkStream", MemberParameters = new object[]
		{
			"System.ReadOnlyMemory`1<Byte>",
			"System.Net.Sockets.SocketFlags",
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static global::System.Memory<T> AsMemory<T>(global::System.ReadOnlyMemory<T> memory)
		{
			throw null;
		}

		// Token: 0x06001F13 RID: 7955 RVA: 0x00019C40 File Offset: 0x00017E40
		[global::Cpp2ILInjected.Token(Token = "0x6002154")]
		[global::Cpp2ILInjected.Address(RVA = "0x1592174", Offset = "0x1592174", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		public static ref T GetReference<T>(global::System.Span<T> span)
		{
			throw null;
		}

		// Token: 0x06001F14 RID: 7956 RVA: 0x00019C43 File Offset: 0x00017E43
		[global::Cpp2ILInjected.Token(Token = "0x6002155")]
		[global::Cpp2ILInjected.Address(RVA = "0x1592170", Offset = "0x1592170", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Convert), Member = "ToBase64String", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Base64FormattingOptions)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Marvin), Member = "ComputeHash32", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(ulong)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "GetIgnoreCaseHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddress", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public static ref T GetReference<T>(global::System.ReadOnlySpan<T> span)
		{
			throw null;
		}

		// Token: 0x06001F15 RID: 7957 RVA: 0x00019C46 File Offset: 0x00017E46
		[global::Cpp2ILInjected.Token(Token = "0x6002156")]
		[global::Cpp2ILInjected.Address(RVA = "0x1592134", Offset = "0x1592134", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		internal static ref T GetNonNullPinnableReference<T>(global::System.Span<T> span)
		{
			throw null;
		}

		// Token: 0x06001F16 RID: 7958 RVA: 0x00019C49 File Offset: 0x00017E49
		[global::Cpp2ILInjected.Token(Token = "0x6002157")]
		[global::Cpp2ILInjected.Address(RVA = "0x1592128", Offset = "0x1592128", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		internal static ref T GetNonNullPinnableReference<T>(global::System.ReadOnlySpan<T> span)
		{
			throw null;
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x00019C4C File Offset: 0x00017E4C
		[global::Cpp2ILInjected.Token(Token = "0x6002158")]
		[global::Cpp2ILInjected.Address(RVA = "0x1592110", Offset = "0x1592110", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static global::System.ReadOnlySpan<T> CreateReadOnlySpan<T>(ref T reference, int length)
		{
			throw null;
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00019C4F File Offset: 0x00017E4F
		[global::Cpp2ILInjected.Token(Token = "0x6002159")]
		[global::Cpp2ILInjected.Address(RVA = "0x1592194", Offset = "0x1592194", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(global::System.Memory<byte>),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlyMemory<byte>),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(global::System.Memory<byte>),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlyMemory<byte>),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "ReadAsync", MemberParameters = new object[]
		{
			typeof(global::System.Memory<byte>),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask<int>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlyMemory<byte>),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "ReceiveAsyncApm", MemberParameters = new object[] { "System.Memory`1<Byte>", "System.Net.Sockets.SocketFlags" }, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncApm", MemberParameters = new object[] { "System.ReadOnlyMemory`1<Byte>", "System.Net.Sockets.SocketFlags" }, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArraySegment<>), Member = ".ctor", MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool TryGetArray<T>(global::System.ReadOnlyMemory<T> memory, out global::System.ArraySegment<T> segment)
		{
			throw null;
		}
	}
}
