using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Globalization.Unicode
{
	[global::Cpp2ILInjected.Token(Token = "0x200003F")]
	internal class SortKeyBuffer
	{
		[global::Cpp2ILInjected.Token(Token = "0x60000FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB12BC", Offset = "0x1AB12BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public SortKeyBuffer(int lcid)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB5518", Offset = "0x1AB5518", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB12C4", Offset = "0x1AB12C4", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(global::System.Globalization.SortKey))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal void Initialize(global::System.Globalization.CompareOptions options, int lcid, string s, bool frenchSort)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB1C80", Offset = "0x1AB1C80", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new object[]
		{
			typeof(int),
			"Mono.Globalization.Unicode.SimpleCollator.ExtenderType",
			typeof(SortKeyBuffer),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKeyBuffer), Member = "AppendBufferPrimitive", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(ref byte[]),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		internal void AppendCJKExtension(byte lv1msb, byte lv1lsb)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000100")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB1DB8", Offset = "0x1AB1DB8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new object[]
		{
			typeof(int),
			"Mono.Globalization.Unicode.SimpleCollator.ExtenderType",
			typeof(SortKeyBuffer),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKeyBuffer), Member = "AppendNormal", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKeyBuffer), Member = "AppendBufferPrimitive", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(ref byte[]),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000101")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB1B6C", Offset = "0x1AB1B6C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(SortKeyBuffer),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "FillSurrogateSortKeyRaw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(SortKeyBuffer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendKana", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(bool),
			typeof(byte),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKeyBuffer), Member = "AppendLevel5", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKeyBuffer), Member = "AppendBufferPrimitive", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(ref byte[]),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000102")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB55D4", Offset = "0x1AB55D4", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendNormal", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKeyBuffer), Member = "AppendBufferPrimitive", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(ref byte[]),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		private void AppendLevel5(byte category, byte lv1)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000103")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB552C", Offset = "0x1AB552C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendCJKExtension", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendKana", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(bool),
			typeof(byte),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendNormal", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendLevel5", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void AppendBufferPrimitive(byte value, ref byte[] buf, ref int bidx)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000104")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB1778", Offset = "0x1AB1778", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortKeyBuffer), Member = "GetResult", ReturnType = typeof(global::System.Globalization.SortKey))]
		public global::System.Globalization.SortKey GetResultAndReset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000105")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB5BF4", Offset = "0x1AB5BF4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int GetOptimizedLength(byte[] data, int len, byte defaultValue)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000106")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AB566C", Offset = "0x1AB566C", Length = "0x588")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(global::System.Globalization.SortKey))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortKeyBuffer), Member = "GetResultAndReset", ReturnType = typeof(global::System.Globalization.SortKey))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.SortKey), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(byte[]),
			typeof(global::System.Globalization.CompareOptions),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array[]), Member = "Reverse", MemberTypeParameters = new object[] { typeof(byte) }, MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public global::System.Globalization.SortKey GetResult()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000125")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private byte[] l1b;

		[global::Cpp2ILInjected.Token(Token = "0x4000126")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private byte[] l2b;

		[global::Cpp2ILInjected.Token(Token = "0x4000127")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private byte[] l3b;

		[global::Cpp2ILInjected.Token(Token = "0x4000128")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] l4sb;

		[global::Cpp2ILInjected.Token(Token = "0x4000129")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private byte[] l4tb;

		[global::Cpp2ILInjected.Token(Token = "0x400012A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private byte[] l4kb;

		[global::Cpp2ILInjected.Token(Token = "0x400012B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private byte[] l4wb;

		[global::Cpp2ILInjected.Token(Token = "0x400012C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private byte[] l5b;

		[global::Cpp2ILInjected.Token(Token = "0x400012D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string source;

		[global::Cpp2ILInjected.Token(Token = "0x400012E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int l1;

		[global::Cpp2ILInjected.Token(Token = "0x400012F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private int l2;

		[global::Cpp2ILInjected.Token(Token = "0x4000130")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int l3;

		[global::Cpp2ILInjected.Token(Token = "0x4000131")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private int l4s;

		[global::Cpp2ILInjected.Token(Token = "0x4000132")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private int l4t;

		[global::Cpp2ILInjected.Token(Token = "0x4000133")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		private int l4k;

		[global::Cpp2ILInjected.Token(Token = "0x4000134")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private int l4w;

		[global::Cpp2ILInjected.Token(Token = "0x4000135")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private int l5;

		[global::Cpp2ILInjected.Token(Token = "0x4000136")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private int lcid;

		[global::Cpp2ILInjected.Token(Token = "0x4000137")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private global::System.Globalization.CompareOptions options;

		[global::Cpp2ILInjected.Token(Token = "0x4000138")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private bool processLevel2;

		[global::Cpp2ILInjected.Token(Token = "0x4000139")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x81")]
		private bool frenchSort;

		[global::Cpp2ILInjected.Token(Token = "0x400013A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x82")]
		private bool frenchSorted;
	}
}
