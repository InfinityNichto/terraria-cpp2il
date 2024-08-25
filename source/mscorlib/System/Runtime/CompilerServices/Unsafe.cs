using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::Cpp2ILInjected.Token(Token = "0x20004A4")]
	internal static class Unsafe
	{
		[global::Cpp2ILInjected.Token(Token = "0x60022B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A2A44", Offset = "0x15A2A44", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static ref T Add<T>(ref T source, int elementOffset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A2A7C", Offset = "0x15A2A7C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static ref T Add<T>(ref T source, global::System.IntPtr elementOffset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A2A84", Offset = "0x15A2A84", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public unsafe static void* Add<T>(void* source, int elementOffset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A2CF0", Offset = "0x15A2CF0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static ref T AddByteOffset<T>(ref T source, global::System.IntPtr byteOffset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A2DE0", Offset = "0x15A2DE0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool AreSame<T>(ref T left, ref T right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A2E04", Offset = "0x15A2E04", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static T As<T>(object o) where T : class
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A2E08", Offset = "0x15A2E08", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static ref TTo As<TFrom, TTo>(ref TFrom source)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A2F88", Offset = "0x15A2F88", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public unsafe static void* AsPointer<T>(ref T value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A2F9C", Offset = "0x15A2F9C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public unsafe static ref T AsRef<T>(void* source)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A2F98", Offset = "0x15A2F98", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "InternalGetNumericValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CharUnicodeInfo), Member = "InternalGetCategoryValue", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public static ref T AsRef<T>(in T source)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75B38", Offset = "0x1B75B38", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Span<>), Member = "Fill", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A32F4", Offset = "0x15A32F4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public unsafe static T Read<T>(void* source)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A3308", Offset = "0x15A3308", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static T ReadUnaligned<T>(ref byte source)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A3354", Offset = "0x15A3354", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int SizeOf<T>()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A338C", Offset = "0x15A338C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void WriteUnaligned<T>(ref byte destination, T value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A2FB8", Offset = "0x15A2FB8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool IsAddressLessThan<T>(ref T left, ref T right)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60022C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A2CF8", Offset = "0x15A2CF8", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(global::System.IntPtr))]
		[MethodImpl(256)]
		internal unsafe static ref T AddByteOffset<T>(ref T source, ulong byteOffset)
		{
			throw null;
		}
	}
}
