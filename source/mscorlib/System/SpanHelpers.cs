﻿using System;
using System.Globalization;
using System.Numerics;
using System.Runtime;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000C9 RID: 201
	[global::Cpp2ILInjected.Token(Token = "0x20000FB")]
	internal static class SpanHelpers
	{
		// Token: 0x060008C0 RID: 2240 RVA: 0x00015EB1 File Offset: 0x000140B1
		[global::Cpp2ILInjected.Token(Token = "0x6000968")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C48138", Offset = "0x1C48138", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MemoryExtensions), Member = "IndexOfAny", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlySpan`1<T>", "System.ReadOnlySpan`1<T>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(byte),
			typeof(int)
		}, ReturnType = typeof(int))]
		public static int IndexOfAny(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength)
		{
			throw null;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00015EB4 File Offset: 0x000140B4
		[global::Cpp2ILInjected.Token(Token = "0x6000969")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C481B8", Offset = "0x1C481B8", Length = "0x298")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlySpan`1<T>", "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SpanHelpers), Member = "IndexOfAny", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(int),
			typeof(ref byte),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(global::System.IntPtr))]
		public unsafe static int IndexOf(ref byte searchSpace, byte value, int length)
		{
			throw null;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00015EB7 File Offset: 0x000140B7
		[global::Cpp2ILInjected.Token(Token = "0x600096A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C48450", Offset = "0x1C48450", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 74)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(void*) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UIntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.UIntPtr),
			typeof(global::System.UIntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UIntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.UIntPtr),
			typeof(global::System.UIntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public unsafe static bool SequenceEqual(ref byte first, ref byte second, ulong length)
		{
			throw null;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00015EBA File Offset: 0x000140BA
		[global::Cpp2ILInjected.Token(Token = "0x600096B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C48618", Offset = "0x1C48618", Length = "0x4D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CompareOrdinalHelper", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.CompareInfo), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Vector), Member = "get_IsHardwareAccelerated", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UIntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.UIntPtr),
			typeof(global::System.UIntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "CompareTo", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public unsafe static int SequenceCompareTo(ref char first, int firstLength, ref char second, int secondLength)
		{
			throw null;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00015EBD File Offset: 0x000140BD
		[global::Cpp2ILInjected.Token(Token = "0x600096C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C48AE8", Offset = "0x1C48AE8", Length = "0x73C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MemoryExtensions), Member = "IndexOf", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlySpan`1<T>", "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Vector), Member = "get_IsHardwareAccelerated", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Vector<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Vector<>), Member = "Equals", MemberParameters = new object[] { "System.Numerics.Vector`1<T>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Vector<ulong>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 61)]
		public static int IndexOf(ref char searchSpace, char value, int length)
		{
			throw null;
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00015EC0 File Offset: 0x000140C0
		[global::Cpp2ILInjected.Token(Token = "0x600096D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C49224", Offset = "0x1C49224", Length = "0x6E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Vector), Member = "get_IsHardwareAccelerated", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Vector<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Vector<>), Member = "Equals", MemberParameters = new object[] { "System.Numerics.Vector`1<T>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Vector<ulong>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 55)]
		public static int LastIndexOf(ref char searchSpace, char value, int length)
		{
			throw null;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00015EC3 File Offset: 0x000140C3
		[global::Cpp2ILInjected.Token(Token = "0x600096E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C49908", Offset = "0x1C49908", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Vector<ulong>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		[MethodImpl(256)]
		private static int LocateFirstFoundChar(global::System.Numerics.Vector<ushort> match)
		{
			throw null;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00015EC6 File Offset: 0x000140C6
		[global::Cpp2ILInjected.Token(Token = "0x600096F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C49AC8", Offset = "0x1C49AC8", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		private static int LocateFirstFoundChar(ulong match)
		{
			throw null;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00015EC9 File Offset: 0x000140C9
		[global::Cpp2ILInjected.Token(Token = "0x6000970")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C49AE8", Offset = "0x1C49AE8", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Numerics.Vector<ulong>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		[MethodImpl(256)]
		private static int LocateLastFoundChar(global::System.Numerics.Vector<ushort> match)
		{
			throw null;
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00015ECC File Offset: 0x000140CC
		[global::Cpp2ILInjected.Token(Token = "0x6000971")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C49CA8", Offset = "0x1C49CA8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		private static int LocateLastFoundChar(ulong match)
		{
			throw null;
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00015ECF File Offset: 0x000140CF
		[global::Cpp2ILInjected.Token(Token = "0x6000972")]
		[global::Cpp2ILInjected.Address(RVA = "0x159D754", Offset = "0x159D754", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "Equals", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(global::System.IntPtr) }, ReturnType = typeof(void*))]
		public unsafe static int IndexOf<T>(ref T searchSpace, T value, int length) where T : global::System.IEquatable<T>
		{
			throw null;
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x00015ED2 File Offset: 0x000140D2
		[global::Cpp2ILInjected.Token(Token = "0x6000973")]
		[global::Cpp2ILInjected.Address(RVA = "0x159E534", Offset = "0x159E534", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static int IndexOfAny<T>(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) where T : global::System.IEquatable<T>
		{
			throw null;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00015ED5 File Offset: 0x000140D5
		[global::Cpp2ILInjected.Token(Token = "0x6000974")]
		[global::Cpp2ILInjected.Address(RVA = "0x159E664", Offset = "0x159E664", Length = "0x380")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "Equals", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(int)
		}, ReturnType = typeof(global::System.IntPtr))]
		public static bool SequenceEqual<T>(ref T first, ref T second, int length) where T : global::System.IEquatable<T>
		{
			throw null;
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00015ED8 File Offset: 0x000140D8
		[global::Cpp2ILInjected.Token(Token = "0x6000975")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C49CD4", Offset = "0x1C49CD4", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MemoryExtensions), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SpanHelpers), Member = "SequenceEqual", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "IsSuffix", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static bool EndsWithCultureHelper(global::System.ReadOnlySpan<char> span, global::System.ReadOnlySpan<char> value, global::System.Globalization.CompareInfo compareInfo)
		{
			throw null;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00015EDB File Offset: 0x000140DB
		[global::Cpp2ILInjected.Token(Token = "0x6000976")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C49ECC", Offset = "0x1C49ECC", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MemoryExtensions), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "IsSuffix", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool EndsWithCultureIgnoreCaseHelper(global::System.ReadOnlySpan<char> span, global::System.ReadOnlySpan<char> value, global::System.Globalization.CompareInfo compareInfo)
		{
			throw null;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00015EDE File Offset: 0x000140DE
		[global::Cpp2ILInjected.Token(Token = "0x6000977")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C49FE4", Offset = "0x1C49FE4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MemoryExtensions), Member = "EndsWith", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "CompareOrdinalIgnoreCase", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.ReadOnlySpan<char>)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool EndsWithOrdinalIgnoreCaseHelper(global::System.ReadOnlySpan<char> span, global::System.ReadOnlySpan<char> value)
		{
			throw null;
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00015EE1 File Offset: 0x000140E1
		[global::Cpp2ILInjected.Token(Token = "0x6000978")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4A0C4", Offset = "0x1C4A0C4", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Span<>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddressParser", Member = "Parse", MemberParameters = new object[]
		{
			"System.ReadOnlySpan`1<Char>",
			typeof(bool)
		}, ReturnType = "System.Net.IPAddress")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.RuntimeImports), Member = "RhZeroMemory", MemberParameters = new object[]
		{
			typeof(ref byte),
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void ClearWithoutReferences(ref byte b, ulong byteLength)
		{
			throw null;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00015EE4 File Offset: 0x000140E4
		[global::Cpp2ILInjected.Token(Token = "0x6000979")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4A2AC", Offset = "0x1C4A2AC", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(global::System.IntPtr))]
		public static void ClearWithReferences(ref global::System.IntPtr ip, ulong pointerSizeLength)
		{
			throw null;
		}
	}
}