using System;
using System.Globalization;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000415")]
	internal sealed class Converter
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002030")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5BB64", Offset = "0x1B5BB64", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "GetParserBinaryTypeInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = typeof(BinaryTypeEnum))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(IOUtil), Member = "WriteWithCode", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(__BinaryWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "ToPrimitiveTypeEnum", MemberParameters = new object[] { typeof(global::System.TypeCode) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static InternalPrimitiveTypeE ToCode(global::System.Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002031")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5F064", Offset = "0x1B5F064", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseArray", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002032")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5F088", Offset = "0x1B5F088", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(int),
			typeof(global::System.Array)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadArrayAsBytes", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal static int TypeLength(InternalPrimitiveTypeE code)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002033")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5C454", Offset = "0x1B5C454", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "TypeFromInfo", MemberParameters = new object[]
		{
			typeof(BinaryTypeEnum),
			typeof(object),
			typeof(ObjectReader),
			typeof(BinaryAssemblyInfo),
			typeof(ref InternalPrimitiveTypeE),
			typeof(ref string),
			typeof(ref global::System.Type),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "InitArrayTypeA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static global::System.Type ToArrayType(InternalPrimitiveTypeE code)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002034")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5F39C", Offset = "0x1B5F39C", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Converter), Member = "ToType", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private static void InitTypeA()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002035")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5F0AC", Offset = "0x1B5F0AC", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Converter), Member = "ToArrayType", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private static void InitArrayTypeA()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002036")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5C3B4", Offset = "0x1B5C3B4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "TypeFromInfo", MemberParameters = new object[]
		{
			typeof(BinaryTypeEnum),
			typeof(object),
			typeof(ObjectReader),
			typeof(BinaryAssemblyInfo),
			typeof(ref InternalPrimitiveTypeE),
			typeof(ref string),
			typeof(ref global::System.Type),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "InitTypeA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static global::System.Type ToType(InternalPrimitiveTypeE code)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002037")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5F68C", Offset = "0x1B5F68C", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadArrayAsBytes", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal static global::System.Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002038")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5B6D4", Offset = "0x1B5B6D4", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(WriteObjectInfo),
			typeof(string),
			typeof(ObjectWriter),
			typeof(ref object),
			typeof(ref int)
		}, ReturnType = typeof(BinaryTypeEnum))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "GetParserBinaryTypeInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = typeof(BinaryTypeEnum))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal static bool IsPrimitiveArray(global::System.Type type, out object typeInformation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002039")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5F7AC", Offset = "0x1B5F7AC", Length = "0x3A4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Converter), Member = "ToComType", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		private static void InitValueA()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600203A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5C314", Offset = "0x1B5C314", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "TypeFromInfo", MemberParameters = new object[]
		{
			typeof(BinaryTypeEnum),
			typeof(object),
			typeof(ObjectReader),
			typeof(BinaryAssemblyInfo),
			typeof(ref InternalPrimitiveTypeE),
			typeof(ref string),
			typeof(ref global::System.Type),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "InitValueA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static string ToComType(InternalPrimitiveTypeE code)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600203B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5FB50", Offset = "0x1B5FB50", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Converter), Member = "ToTypeCode", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void InitTypeCodeA()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600203C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5FC08", Offset = "0x1B5FC08", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Converter), Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(InternalPrimitiveTypeE)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "InitTypeCodeA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static global::System.TypeCode ToTypeCode(InternalPrimitiveTypeE code)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600203D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5FCA8", Offset = "0x1B5FCA8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Converter), Member = "ToPrimitiveTypeEnum", MemberParameters = new object[] { typeof(global::System.TypeCode) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void InitCodeA()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600203E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5EFC4", Offset = "0x1B5EFC4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Converter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "InitCodeA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(global::System.TypeCode typeCode)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600203F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5FD60", Offset = "0x1B5FD60", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "ToTypeCode", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "ChangeType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.TypeCode),
			typeof(global::System.IFormatProvider)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static object FromString(string value, InternalPrimitiveTypeE code)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002040")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5FE4C", Offset = "0x1B5FE4C", Length = "0x784")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "GetAssembly", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		static Converter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40010BC")]
		private static int primitiveTypeEnumLength;

		[global::Cpp2ILInjected.Token(Token = "0x40010BD")]
		private static global::System.Type[] typeA;

		[global::Cpp2ILInjected.Token(Token = "0x40010BE")]
		private static global::System.Type[] arrayTypeA;

		[global::Cpp2ILInjected.Token(Token = "0x40010BF")]
		private static string[] valueA;

		[global::Cpp2ILInjected.Token(Token = "0x40010C0")]
		private static global::System.TypeCode[] typeCodeA;

		[global::Cpp2ILInjected.Token(Token = "0x40010C1")]
		private static InternalPrimitiveTypeE[] codeA;

		[global::Cpp2ILInjected.Token(Token = "0x40010C2")]
		internal static global::System.Type typeofISerializable;

		[global::Cpp2ILInjected.Token(Token = "0x40010C3")]
		internal static global::System.Type typeofString;

		[global::Cpp2ILInjected.Token(Token = "0x40010C4")]
		internal static global::System.Type typeofConverter;

		[global::Cpp2ILInjected.Token(Token = "0x40010C5")]
		internal static global::System.Type typeofBoolean;

		[global::Cpp2ILInjected.Token(Token = "0x40010C6")]
		internal static global::System.Type typeofByte;

		[global::Cpp2ILInjected.Token(Token = "0x40010C7")]
		internal static global::System.Type typeofChar;

		[global::Cpp2ILInjected.Token(Token = "0x40010C8")]
		internal static global::System.Type typeofDecimal;

		[global::Cpp2ILInjected.Token(Token = "0x40010C9")]
		internal static global::System.Type typeofDouble;

		[global::Cpp2ILInjected.Token(Token = "0x40010CA")]
		internal static global::System.Type typeofInt16;

		[global::Cpp2ILInjected.Token(Token = "0x40010CB")]
		internal static global::System.Type typeofInt32;

		[global::Cpp2ILInjected.Token(Token = "0x40010CC")]
		internal static global::System.Type typeofInt64;

		[global::Cpp2ILInjected.Token(Token = "0x40010CD")]
		internal static global::System.Type typeofSByte;

		[global::Cpp2ILInjected.Token(Token = "0x40010CE")]
		internal static global::System.Type typeofSingle;

		[global::Cpp2ILInjected.Token(Token = "0x40010CF")]
		internal static global::System.Type typeofTimeSpan;

		[global::Cpp2ILInjected.Token(Token = "0x40010D0")]
		internal static global::System.Type typeofDateTime;

		[global::Cpp2ILInjected.Token(Token = "0x40010D1")]
		internal static global::System.Type typeofUInt16;

		[global::Cpp2ILInjected.Token(Token = "0x40010D2")]
		internal static global::System.Type typeofUInt32;

		[global::Cpp2ILInjected.Token(Token = "0x40010D3")]
		internal static global::System.Type typeofUInt64;

		[global::Cpp2ILInjected.Token(Token = "0x40010D4")]
		internal static global::System.Type typeofObject;

		[global::Cpp2ILInjected.Token(Token = "0x40010D5")]
		internal static global::System.Type typeofSystemVoid;

		[global::Cpp2ILInjected.Token(Token = "0x40010D6")]
		internal static global::System.Reflection.Assembly urtAssembly;

		[global::Cpp2ILInjected.Token(Token = "0x40010D7")]
		internal static string urtAssemblyString;

		[global::Cpp2ILInjected.Token(Token = "0x40010D8")]
		internal static global::System.Type typeofTypeArray;

		[global::Cpp2ILInjected.Token(Token = "0x40010D9")]
		internal static global::System.Type typeofObjectArray;

		[global::Cpp2ILInjected.Token(Token = "0x40010DA")]
		internal static global::System.Type typeofStringArray;

		[global::Cpp2ILInjected.Token(Token = "0x40010DB")]
		internal static global::System.Type typeofBooleanArray;

		[global::Cpp2ILInjected.Token(Token = "0x40010DC")]
		internal static global::System.Type typeofByteArray;

		[global::Cpp2ILInjected.Token(Token = "0x40010DD")]
		internal static global::System.Type typeofCharArray;

		[global::Cpp2ILInjected.Token(Token = "0x40010DE")]
		internal static global::System.Type typeofDecimalArray;

		[global::Cpp2ILInjected.Token(Token = "0x40010DF")]
		internal static global::System.Type typeofDoubleArray;

		[global::Cpp2ILInjected.Token(Token = "0x40010E0")]
		internal static global::System.Type typeofInt16Array;

		[global::Cpp2ILInjected.Token(Token = "0x40010E1")]
		internal static global::System.Type typeofInt32Array;

		[global::Cpp2ILInjected.Token(Token = "0x40010E2")]
		internal static global::System.Type typeofInt64Array;

		[global::Cpp2ILInjected.Token(Token = "0x40010E3")]
		internal static global::System.Type typeofSByteArray;

		[global::Cpp2ILInjected.Token(Token = "0x40010E4")]
		internal static global::System.Type typeofSingleArray;

		[global::Cpp2ILInjected.Token(Token = "0x40010E5")]
		internal static global::System.Type typeofTimeSpanArray;

		[global::Cpp2ILInjected.Token(Token = "0x40010E6")]
		internal static global::System.Type typeofDateTimeArray;

		[global::Cpp2ILInjected.Token(Token = "0x40010E7")]
		internal static global::System.Type typeofUInt16Array;

		[global::Cpp2ILInjected.Token(Token = "0x40010E8")]
		internal static global::System.Type typeofUInt32Array;

		[global::Cpp2ILInjected.Token(Token = "0x40010E9")]
		internal static global::System.Type typeofUInt64Array;

		[global::Cpp2ILInjected.Token(Token = "0x40010EA")]
		internal static global::System.Type typeofMarshalByRefObject;
	}
}
