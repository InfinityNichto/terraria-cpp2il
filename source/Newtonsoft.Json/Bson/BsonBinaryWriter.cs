using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200011F")]
	internal class BsonBinaryWriter
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700022C")]
		public DateTimeKind DateTimeKindHandling
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B33")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D36C98", Offset = "0x1D36C98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000B34")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D36CA0", Offset = "0x1D36CA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D36CA8", Offset = "0x1D36CA8", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BsonBinaryWriter(BinaryWriter writer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D36CD8", Offset = "0x1D36CD8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Flush()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D36CE8", Offset = "0x1D36CE8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Close()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D36CF8", Offset = "0x1D36CF8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonBinaryWriter), Member = "CalculateSize", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		public void WriteToken(BsonToken t)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D37578", Offset = "0x1D37578", Length = "0xD94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteEnd", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeOffset), Member = "get_Offset", ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(TimeSpan)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonArray), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<BsonToken>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathUtils), Member = "IntLength", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonBinaryWriter), Member = "WriteString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonObject), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<BsonProperty>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int?), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTimeUtils), Member = "ConvertDateTimeToJavaScriptTicks", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(bool)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 67)]
		private void WriteTokenInternal(BsonToken t)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3839C", Offset = "0x1D3839C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteTokenInternal", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonBinaryWriter), Member = "WriteUtf8Bytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void WriteString(string s, int byteCount, int? calculatedlengthPrefix)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D384C4", Offset = "0x1D384C4", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void WriteUtf8Bytes(string s, int byteCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D385F0", Offset = "0x1D385F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int CalculateSize(int stringByteCount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D385F8", Offset = "0x1D385F8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int CalculateSizeWithLength(int stringByteCount, bool includeSize)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D36D20", Offset = "0x1D36D20", Length = "0x858")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonBinaryWriter), Member = "WriteToken", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonBinaryWriter), Member = "CalculateSize", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonWriter), Member = "WriteEnd", MemberParameters = new object[] { typeof(JsonToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonBinaryWriter), Member = "CalculateSize", MemberParameters = new object[] { typeof(BsonToken) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonObject), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<BsonProperty>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BsonArray), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<BsonToken>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathUtils), Member = "IntLength", MemberParameters = new object[] { typeof(ulong) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 46)]
		private int CalculateSize(BsonToken t)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000B3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3860C", Offset = "0x1D3860C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static BsonBinaryWriter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400042C")]
		private static readonly Encoding Encoding;

		[global::Cpp2ILInjected.Token(Token = "0x400042D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly BinaryWriter _writer;

		[global::Cpp2ILInjected.Token(Token = "0x400042E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private byte[] _largeByteBuffer;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400042F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private DateTimeKind <DateTimeKindHandling>k__BackingField;
	}
}
