using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000C1 RID: 193
	[global::System.Diagnostics.DebuggerTypeProxy(typeof(global::System.SpanDebugView<>))]
	[global::System.Runtime.Versioning.NonVersionable]
	[global::System.Obsolete("Types with embedded references are not supported in this version of your compiler.", true)]
	[global::System.Diagnostics.DebuggerDisplay("{ToString(),raw}")]
	[global::Cpp2ILInjected.Token(Token = "0x20000F3")]
	public readonly ref struct ReadOnlySpan<T>
	{
		// Token: 0x06000857 RID: 2135 RVA: 0x00015D7C File Offset: 0x00013F7C
		[global::Cpp2ILInjected.Token(Token = "0x60008FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x185FDB0", Offset = "0x185FDB0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public ReadOnlySpan(T[] array)
		{
			throw null;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00015D7F File Offset: 0x00013F7F
		[global::Cpp2ILInjected.Token(Token = "0x6000900")]
		[global::Cpp2ILInjected.Address(RVA = "0x185FDD0", Offset = "0x185FDD0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[MethodImpl(256)]
		public ReadOnlySpan(T[] array, int start, int length)
		{
			throw null;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00015D82 File Offset: 0x00013F82
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000901")]
		[global::Cpp2ILInjected.Address(RVA = "0x185FE44", Offset = "0x185FE44", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public unsafe ReadOnlySpan(void* pointer, int length)
		{
			throw null;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00015D85 File Offset: 0x00013F85
		[global::Cpp2ILInjected.Token(Token = "0x6000902")]
		[global::Cpp2ILInjected.Address(RVA = "0x185FEA0", Offset = "0x185FEA0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		internal ReadOnlySpan(ref T ptr, int length)
		{
			throw null;
		}

		// Token: 0x17000084 RID: 132
		[global::Cpp2ILInjected.Token(Token = "0x1700009F")]
		public ref T this[int index]
		{
			[global::System.Runtime.CompilerServices.Intrinsic]
			[global::System.Runtime.Versioning.NonVersionable]
			[global::Cpp2ILInjected.Token(Token = "0x6000903")]
			[global::Cpp2ILInjected.Address(RVA = "0x185FEAC", Offset = "0x185FEAC", Length = "0x38")]
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

		// Token: 0x0600085C RID: 2140 RVA: 0x00015D8B File Offset: 0x00013F8B
		[global::Cpp2ILInjected.Token(Token = "0x6000904")]
		[global::Cpp2ILInjected.Address(RVA = "0x185FEE4", Offset = "0x185FEE4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MemoryExtensions), Member = "CopyTo", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]", "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.HashAlgorithm), Member = "HashCore", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.HashAlgorithm), Member = "TryHashFinal", MemberParameters = new object[]
		{
			typeof(global::System.Span<byte>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSA), Member = "TryCreateSignature", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSA), Member = "TryHashData", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.Security.Cryptography.HashAlgorithmName),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RandomNumberGenerator), Member = "GetBytes", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RandomNumberGenerator), Member = "GetNonZeroBytes", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "TryDecrypt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.Security.Cryptography.RSAEncryptionPadding),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "TryEncrypt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.Security.Cryptography.RSAEncryptionPadding),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "TryHashData", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.Security.Cryptography.HashAlgorithmName),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "TrySignHash", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.Security.Cryptography.HashAlgorithmName),
			typeof(global::System.Security.Cryptography.RSASignaturePadding),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.MemoryStream), Member = "Write", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlyMemory<byte>),
			typeof(global::System.Threading.CancellationToken)
		}, ReturnType = typeof(global::System.Threading.Tasks.ValueTask))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.Stream), Member = "Write", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddress", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket.<>c", Member = "<ReceiveAsyncApm>b__15_1", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "SendAsyncApm", MemberParameters = new object[] { "System.ReadOnlyMemory`1<Byte>", "System.Net.Sockets.SocketFlags" }, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Receive", MemberParameters = new object[] { "System.Span`1<Byte>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException_DestinationTooShort", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void CopyTo(global::System.Span<T> destination)
		{
			throw null;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00015D8E File Offset: 0x00013F8E
		[global::Cpp2ILInjected.Token(Token = "0x6000905")]
		[global::Cpp2ILInjected.Address(RVA = "0x185FFB0", Offset = "0x185FFB0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool TryCopyTo(global::System.Span<T> destination)
		{
			throw null;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00015D91 File Offset: 0x00013F91
		[global::Cpp2ILInjected.Token(Token = "0x6000906")]
		[global::Cpp2ILInjected.Address(RVA = "0x1860064", Offset = "0x1860064", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ReadOnlyMemory<>), Member = "ToString", ReturnType = typeof(string))]
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

		// Token: 0x0600085F RID: 2143 RVA: 0x00015D94 File Offset: 0x00013F94
		[global::Cpp2ILInjected.Token(Token = "0x6000907")]
		[global::Cpp2ILInjected.Address(RVA = "0x18601F0", Offset = "0x18601F0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public global::System.ReadOnlySpan<T> Slice(int start)
		{
			throw null;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00015D97 File Offset: 0x00013F97
		[global::Cpp2ILInjected.Token(Token = "0x6000908")]
		[global::Cpp2ILInjected.Address(RVA = "0x186024C", Offset = "0x186024C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public global::System.ReadOnlySpan<T> Slice(int start, int length)
		{
			throw null;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00015D9A File Offset: 0x00013F9A
		[global::Cpp2ILInjected.Token(Token = "0x6000909")]
		[global::Cpp2ILInjected.Address(RVA = "0x18602B4", Offset = "0x18602B4", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSA), Member = "TryCreateSignature", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.DSA), Member = "VerifySignature", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.ReadOnlySpan<byte>)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "TryDecrypt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.Security.Cryptography.RSAEncryptionPadding),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "TryEncrypt", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.Security.Cryptography.RSAEncryptionPadding),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "TrySignHash", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Span<byte>),
			typeof(global::System.Security.Cryptography.HashAlgorithmName),
			typeof(global::System.Security.Cryptography.RSASignaturePadding),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RSA), Member = "VerifyHash", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.ReadOnlySpan<byte>),
			typeof(global::System.Security.Cryptography.HashAlgorithmName),
			typeof(global::System.Security.Cryptography.RSASignaturePadding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.Socket", Member = "Send", MemberParameters = new object[] { "System.ReadOnlySpan`1<Byte>", "System.Net.Sockets.SocketFlags", "System.Net.Sockets.SocketError&" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IO.Compression.DeflateStream", Member = "WriteCore", MemberParameters = new object[] { "System.ReadOnlySpan`1<Byte>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public T[] ToArray()
		{
			throw null;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x00015D9D File Offset: 0x00013F9D
		[global::Cpp2ILInjected.Token(Token = "0x170000A0")]
		public int Length
		{
			[global::System.Runtime.Versioning.NonVersionable]
			[global::Cpp2ILInjected.Token(Token = "0x600090A")]
			[global::Cpp2ILInjected.Address(RVA = "0x18603E4", Offset = "0x18603E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x00015DA0 File Offset: 0x00013FA0
		[global::Cpp2ILInjected.Token(Token = "0x170000A1")]
		public bool IsEmpty
		{
			[global::System.Runtime.Versioning.NonVersionable]
			[global::Cpp2ILInjected.Token(Token = "0x600090B")]
			[global::Cpp2ILInjected.Address(RVA = "0x18603EC", Offset = "0x18603EC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00015DA3 File Offset: 0x00013FA3
		[global::System.Obsolete("Equals() on ReadOnlySpan will always throw an exception. Use == instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x600090C")]
		[global::Cpp2ILInjected.Address(RVA = "0x18603FC", Offset = "0x18603FC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00015DA6 File Offset: 0x00013FA6
		[global::System.Obsolete("GetHashCode() on ReadOnlySpan will always throw an exception.")]
		[global::Cpp2ILInjected.Token(Token = "0x600090D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1860448", Offset = "0x1860448", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00015DA9 File Offset: 0x00013FA9
		[global::Cpp2ILInjected.Token(Token = "0x600090E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1860494", Offset = "0x1860494", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UTF32Encoding), Member = "get_Preamble", ReturnType = typeof(global::System.ReadOnlySpan<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UTF8Encoding.UTF8EncodingSealed), Member = "get_Preamble", ReturnType = typeof(global::System.ReadOnlySpan<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UTF8Encoding), Member = "get_Preamble", ReturnType = typeof(global::System.ReadOnlySpan<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.UnicodeEncoding), Member = "get_Preamble", ReturnType = typeof(global::System.ReadOnlySpan<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.Encoding), Member = "get_Preamble", ReturnType = typeof(global::System.ReadOnlySpan<byte>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Rfc2898DeriveBytes), Member = "Func", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static implicit operator global::System.ReadOnlySpan<T>(T[] array)
		{
			throw null;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x00015DAC File Offset: 0x00013FAC
		[global::Cpp2ILInjected.Token(Token = "0x170000A2")]
		public static global::System.ReadOnlySpan<T> Empty
		{
			[global::Cpp2ILInjected.Token(Token = "0x600090F")]
			[global::Cpp2ILInjected.Address(RVA = "0x18604D0", Offset = "0x18604D0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400023F RID: 575
		[global::Cpp2ILInjected.Token(Token = "0x4000391")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly global::System.ByReference<T> _pointer;

		// Token: 0x04000240 RID: 576
		[global::Cpp2ILInjected.Token(Token = "0x4000392")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly int _length;
	}
}
