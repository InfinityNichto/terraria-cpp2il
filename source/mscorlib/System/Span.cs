using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000C7 RID: 199
	[global::System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	[global::System.Diagnostics.DebuggerDisplay("{ToString(),raw}")]
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(global::System.SpanDebugView<>))]
	[global::System.Runtime.Versioning.NonVersionable]
	[global::Cpp2ILInjected.Token(Token = "0x20000F9")]
	public readonly ref struct Span<T>
	{
		// Token: 0x060008AD RID: 2221 RVA: 0x00015E78 File Offset: 0x00014078
		[global::Cpp2ILInjected.Token(Token = "0x6000955")]
		[global::Cpp2ILInjected.Address(RVA = "0x186B4E0", Offset = "0x186B4E0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public Span(T[] array)
		{
			throw null;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00015E7B File Offset: 0x0001407B
		[global::Cpp2ILInjected.Token(Token = "0x6000956")]
		[global::Cpp2ILInjected.Address(RVA = "0x186B538", Offset = "0x186B538", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public Span(T[] array, int start, int length)
		{
			throw null;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00015E7E File Offset: 0x0001407E
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000957")]
		[global::Cpp2ILInjected.Address(RVA = "0x186B5CC", Offset = "0x186B5CC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public unsafe Span(void* pointer, int length)
		{
			throw null;
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00015E81 File Offset: 0x00014081
		[global::Cpp2ILInjected.Token(Token = "0x6000958")]
		[global::Cpp2ILInjected.Address(RVA = "0x186B628", Offset = "0x186B628", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		internal Span(ref T ptr, int length)
		{
			throw null;
		}

		// Token: 0x17000088 RID: 136
		[global::Cpp2ILInjected.Token(Token = "0x170000A3")]
		public ref T this[int index]
		{
			[global::System.Runtime.CompilerServices.Intrinsic]
			[global::System.Runtime.Versioning.NonVersionable]
			[global::Cpp2ILInjected.Token(Token = "0x6000959")]
			[global::Cpp2ILInjected.Address(RVA = "0x186B634", Offset = "0x186B634", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowIndexOutOfRangeException", ReturnType = typeof(void))]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00015E87 File Offset: 0x00014087
		[global::Cpp2ILInjected.Token(Token = "0x600095A")]
		[global::Cpp2ILInjected.Address(RVA = "0x186B66C", Offset = "0x186B66C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RandomNumberGenerator), Member = "FillSpan", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public ref T GetPinnableReference()
		{
			throw null;
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00015E8A File Offset: 0x0001408A
		[global::Cpp2ILInjected.Token(Token = "0x600095B")]
		[global::Cpp2ILInjected.Address(RVA = "0x186B684", Offset = "0x186B684", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "ClearWithoutReferences", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[MethodImpl(256)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00015E8D File Offset: 0x0001408D
		[global::Cpp2ILInjected.Token(Token = "0x600095C")]
		[global::Cpp2ILInjected.Address(RVA = "0x186B698", Offset = "0x186B698", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.Unsafe), Member = "InitBlockUnaligned", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(byte),
			typeof(uint)
		}, ReturnType = typeof(void))]
		public void Fill(T value)
		{
			throw null;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00015E90 File Offset: 0x00014090
		[global::Cpp2ILInjected.Token(Token = "0x600095D")]
		[global::Cpp2ILInjected.Address(RVA = "0x186B6B0", Offset = "0x186B6B0", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Rfc2898DeriveBytes), Member = "Func", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "Read", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.File), Member = "ReadAllBytesUnknownLength", MemberParameters = new object[] { typeof(global::System.IO.FileStream) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Stream.<<ReadAsync>g__FinishReadAsync|44_0>d", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "Read", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStream", Member = "ReadCore", MemberParameters = new object[] { "System.Span`1<Byte>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException_DestinationTooShort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void CopyTo(global::System.Span<T> destination)
		{
			throw null;
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00015E93 File Offset: 0x00014093
		[global::Cpp2ILInjected.Token(Token = "0x600095E")]
		[global::Cpp2ILInjected.Address(RVA = "0x186B77C", Offset = "0x186B77C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool TryCopyTo(global::System.Span<T> destination)
		{
			throw null;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00015E96 File Offset: 0x00014096
		[global::Cpp2ILInjected.Token(Token = "0x600095F")]
		[global::Cpp2ILInjected.Address(RVA = "0x186B830", Offset = "0x186B830", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Rfc2898DeriveBytes), Member = "Func", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSA), Member = "TrySignData", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.Security.Cryptography.HashAlgorithmName),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "TrySignData", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.Security.Cryptography.HashAlgorithmName),
			typeof(global::System.Security.Cryptography.RSASignaturePadding),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "GetIgnoreCaseHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddress", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static implicit operator global::System.ReadOnlySpan<T>(global::System.Span<T> span)
		{
			throw null;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00015E99 File Offset: 0x00014099
		[global::Cpp2ILInjected.Token(Token = "0x6000960")]
		[global::Cpp2ILInjected.Address(RVA = "0x186B868", Offset = "0x186B868", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Memory<>), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public unsafe override string ToString()
		{
			throw null;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00015E9C File Offset: 0x0001409C
		[global::Cpp2ILInjected.Token(Token = "0x6000961")]
		[global::Cpp2ILInjected.Address(RVA = "0x186B9F4", Offset = "0x186B9F4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public global::System.Span<T> Slice(int start)
		{
			throw null;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00015E9F File Offset: 0x0001409F
		[global::Cpp2ILInjected.Token(Token = "0x6000962")]
		[global::Cpp2ILInjected.Address(RVA = "0x186BA50", Offset = "0x186BA50", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public global::System.Span<T> Slice(int start, int length)
		{
			throw null;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00015EA2 File Offset: 0x000140A2
		[global::Cpp2ILInjected.Token(Token = "0x6000963")]
		[global::Cpp2ILInjected.Address(RVA = "0x186BAB8", Offset = "0x186BAB8", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		[MethodImpl(256)]
		public T[] ToArray()
		{
			throw null;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x00015EA5 File Offset: 0x000140A5
		[global::Cpp2ILInjected.Token(Token = "0x170000A4")]
		public int Length
		{
			[global::System.Runtime.Versioning.NonVersionable]
			[global::Cpp2ILInjected.Token(Token = "0x6000964")]
			[global::Cpp2ILInjected.Address(RVA = "0x186BBE8", Offset = "0x186BBE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00015EA8 File Offset: 0x000140A8
		[global::System.Obsolete("Equals() on Span will always throw an exception. Use == instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x6000965")]
		[global::Cpp2ILInjected.Address(RVA = "0x186BBF0", Offset = "0x186BBF0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00015EAB File Offset: 0x000140AB
		[global::System.Obsolete("GetHashCode() on Span will always throw an exception.")]
		[global::Cpp2ILInjected.Token(Token = "0x6000966")]
		[global::Cpp2ILInjected.Address(RVA = "0x186BC3C", Offset = "0x186BC3C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00015EAE File Offset: 0x000140AE
		[global::Cpp2ILInjected.Token(Token = "0x6000967")]
		[global::Cpp2ILInjected.Address(RVA = "0x186BC88", Offset = "0x186BC88", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 36)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator global::System.Span<T>(T[] array)
		{
			throw null;
		}

		// Token: 0x0400024E RID: 590
		[global::Cpp2ILInjected.Token(Token = "0x40003A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly global::System.ByReference<T> _pointer;

		// Token: 0x0400024F RID: 591
		[global::Cpp2ILInjected.Token(Token = "0x40003A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int _length;
	}
}
