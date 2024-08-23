using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200010E RID: 270
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000146")]
	public static class Buffer
	{
		// Token: 0x06000C1F RID: 3103
		[global::Cpp2ILInjected.Token(Token = "0x6000CED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C60230", Offset = "0x1C60230", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 58)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern bool InternalBlockCopy(global::System.Array src, int srcOffsetBytes, global::System.Array dst, int dstOffsetBytes, int byteCount);

		// Token: 0x06000C20 RID: 3104 RVA: 0x00016832 File Offset: 0x00014A32
		[global::Cpp2ILInjected.Token(Token = "0x6000CEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C60234", Offset = "0x1C60234", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.ByteEqualityComparer), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(byte),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal unsafe static int IndexOfByte(byte* src, byte value, int index, int count)
		{
			throw null;
		}

		// Token: 0x06000C21 RID: 3105
		[global::Cpp2ILInjected.Token(Token = "0x6000CEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C60344", Offset = "0x1C60344", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern int _ByteLength(global::System.Array array);

		// Token: 0x06000C22 RID: 3106 RVA: 0x00016835 File Offset: 0x00014A35
		[global::Cpp2ILInjected.Token(Token = "0x6000CF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C60348", Offset = "0x1C60348", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "SetLength", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		internal unsafe static void ZeroMemory(byte* src, long len)
		{
			throw null;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00016838 File Offset: 0x00014A38
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000CF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6036C", Offset = "0x1C6036C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref byte[]),
			typeof(int),
			typeof(global::System.Security.Cryptography.PaddingMode),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal unsafe static void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len)
		{
			throw null;
		}

		// Token: 0x06000C24 RID: 3108
		[global::Cpp2ILInjected.Token(Token = "0x6000CF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6040C", Offset = "0x1C6040C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal unsafe static extern void InternalMemcpy(byte* dest, byte* src, int count);

		// Token: 0x06000C25 RID: 3109 RVA: 0x0001683B File Offset: 0x00014A3B
		[global::Cpp2ILInjected.Token(Token = "0x6000CF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C60410", Offset = "0x1C60410", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static int ByteLength(global::System.Array array)
		{
			throw null;
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0001683E File Offset: 0x00014A3E
		[global::Cpp2ILInjected.Token(Token = "0x6000CF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C604A4", Offset = "0x1C604A4", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 297)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "ByteLength", MemberParameters = new object[] { typeof(global::System.Array) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static void BlockCopy(global::System.Array src, int srcOffset, global::System.Array dst, int dstOffset, int count)
		{
			throw null;
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00016841 File Offset: 0x00014A41
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000CF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C6064C", Offset = "0x1C6064C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StreamWriter), Member = "Write", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StreamWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StreamWriter), Member = "WriteSpan", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StreamWriter), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.StreamWriter), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "InvariantCreateSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(global::System.Globalization.SortKey))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetEventSource", Member = "DumpBuffer", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		public unsafe static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy)
		{
			throw null;
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00016844 File Offset: 0x00014A44
		[global::Cpp2ILInjected.Token(Token = "0x6000CF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C606F8", Offset = "0x1C606F8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffer), Member = "Memcpy", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal unsafe static void memcpy4(byte* dest, byte* src, int size)
		{
			throw null;
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00016847 File Offset: 0x00014A47
		[global::Cpp2ILInjected.Token(Token = "0x6000CF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C60784", Offset = "0x1C60784", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffer), Member = "Memcpy", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal unsafe static void memcpy2(byte* dest, byte* src, int size)
		{
			throw null;
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0001684A File Offset: 0x00014A4A
		[global::Cpp2ILInjected.Token(Token = "0x6000CF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C60800", Offset = "0x1C60800", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffer), Member = "Memcpy", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private unsafe static void memcpy1(byte* dest, byte* src, int size)
		{
			throw null;
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0001684D File Offset: 0x00014A4D
		[global::Cpp2ILInjected.Token(Token = "0x6000CF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C603A0", Offset = "0x1C603A0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "memcpy", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.RijndaelManagedTransform), Member = "EncryptData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref byte[]),
			typeof(int),
			typeof(global::System.Security.Cryptography.PaddingMode),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "ReadInt16", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "ReadInt32", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "WriteInt16", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.IO.UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			"System.UriComponents"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "memcpy4", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "memcpy1", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "memcpy2", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe static void Memcpy(byte* dest, byte* src, int len, bool useICall = true)
		{
			throw null;
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00016850 File Offset: 0x00014A50
		[global::Cpp2ILInjected.Token(Token = "0x6000CFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C606CC", Offset = "0x1C606CC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "FillStringChecked", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "JoinCore", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(string[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "PadRight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Remove", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "InternalSubString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CreateTrimmedString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Ctor", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Ctor", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Ctor", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Ctor", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<char>) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Copy", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "wstrcpy", MemberParameters = new object[]
		{
			typeof(char*),
			typeof(char*),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffer), Member = "MemoryCopy", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(void*),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Buffer), Member = "Memmove", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T&",
			"T&",
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memcpy", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.RuntimeImports), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		internal unsafe static void Memmove(byte* dest, byte* src, uint len)
		{
			throw null;
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x00016853 File Offset: 0x00014A53
		[global::Cpp2ILInjected.Token(Token = "0x6000CFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1576500", Offset = "0x1576500", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memmove", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe static void Memmove<T>(ref T destination, ref T source, ulong elementCount)
		{
			throw null;
		}
	}
}
