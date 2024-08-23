using System;
using System.Globalization;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200036D RID: 877
	[global::Cpp2ILInjected.Token(Token = "0x2000415")]
	internal sealed class Converter
	{
		// Token: 0x06001DF2 RID: 7666 RVA: 0x000198DD File Offset: 0x00017ADD
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

		// Token: 0x06001DF3 RID: 7667 RVA: 0x000198E0 File Offset: 0x00017AE0
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

		// Token: 0x06001DF4 RID: 7668 RVA: 0x000198E3 File Offset: 0x00017AE3
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

		// Token: 0x06001DF5 RID: 7669 RVA: 0x000198E6 File Offset: 0x00017AE6
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

		// Token: 0x06001DF6 RID: 7670 RVA: 0x000198E9 File Offset: 0x00017AE9
		[global::Cpp2ILInjected.Token(Token = "0x6002034")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5F39C", Offset = "0x1B5F39C", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Converter), Member = "ToType", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private static void InitTypeA()
		{
			throw null;
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x000198EC File Offset: 0x00017AEC
		[global::Cpp2ILInjected.Token(Token = "0x6002035")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5F0AC", Offset = "0x1B5F0AC", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Converter), Member = "ToArrayType", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private static void InitArrayTypeA()
		{
			throw null;
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x000198EF File Offset: 0x00017AEF
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

		// Token: 0x06001DF9 RID: 7673 RVA: 0x000198F2 File Offset: 0x00017AF2
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

		// Token: 0x06001DFA RID: 7674 RVA: 0x000198F5 File Offset: 0x00017AF5
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

		// Token: 0x06001DFB RID: 7675 RVA: 0x000198F8 File Offset: 0x00017AF8
		[global::Cpp2ILInjected.Token(Token = "0x6002039")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5F7AC", Offset = "0x1B5F7AC", Length = "0x3A4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Converter), Member = "ToComType", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		private static void InitValueA()
		{
			throw null;
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x000198FB File Offset: 0x00017AFB
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

		// Token: 0x06001DFD RID: 7677 RVA: 0x000198FE File Offset: 0x00017AFE
		[global::Cpp2ILInjected.Token(Token = "0x600203B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5FB50", Offset = "0x1B5FB50", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Converter), Member = "ToTypeCode", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void InitTypeCodeA()
		{
			throw null;
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x00019901 File Offset: 0x00017B01
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

		// Token: 0x06001DFF RID: 7679 RVA: 0x00019904 File Offset: 0x00017B04
		[global::Cpp2ILInjected.Token(Token = "0x600203D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5FCA8", Offset = "0x1B5FCA8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Converter), Member = "ToPrimitiveTypeEnum", MemberParameters = new object[] { typeof(global::System.TypeCode) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void InitCodeA()
		{
			throw null;
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00019907 File Offset: 0x00017B07
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

		// Token: 0x06001E01 RID: 7681 RVA: 0x0001990A File Offset: 0x00017B0A
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

		// Token: 0x06001E02 RID: 7682 RVA: 0x0001990D File Offset: 0x00017B0D
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

		// Token: 0x04000DCA RID: 3530
		[global::Cpp2ILInjected.Token(Token = "0x40010BC")]
		private static int primitiveTypeEnumLength;

		// Token: 0x04000DCB RID: 3531
		[global::Cpp2ILInjected.Token(Token = "0x40010BD")]
		private static global::System.Type[] typeA;

		// Token: 0x04000DCC RID: 3532
		[global::Cpp2ILInjected.Token(Token = "0x40010BE")]
		private static global::System.Type[] arrayTypeA;

		// Token: 0x04000DCD RID: 3533
		[global::Cpp2ILInjected.Token(Token = "0x40010BF")]
		private static string[] valueA;

		// Token: 0x04000DCE RID: 3534
		[global::Cpp2ILInjected.Token(Token = "0x40010C0")]
		private static global::System.TypeCode[] typeCodeA;

		// Token: 0x04000DCF RID: 3535
		[global::Cpp2ILInjected.Token(Token = "0x40010C1")]
		private static InternalPrimitiveTypeE[] codeA;

		// Token: 0x04000DD0 RID: 3536
		[global::Cpp2ILInjected.Token(Token = "0x40010C2")]
		internal static global::System.Type typeofISerializable;

		// Token: 0x04000DD1 RID: 3537
		[global::Cpp2ILInjected.Token(Token = "0x40010C3")]
		internal static global::System.Type typeofString;

		// Token: 0x04000DD2 RID: 3538
		[global::Cpp2ILInjected.Token(Token = "0x40010C4")]
		internal static global::System.Type typeofConverter;

		// Token: 0x04000DD3 RID: 3539
		[global::Cpp2ILInjected.Token(Token = "0x40010C5")]
		internal static global::System.Type typeofBoolean;

		// Token: 0x04000DD4 RID: 3540
		[global::Cpp2ILInjected.Token(Token = "0x40010C6")]
		internal static global::System.Type typeofByte;

		// Token: 0x04000DD5 RID: 3541
		[global::Cpp2ILInjected.Token(Token = "0x40010C7")]
		internal static global::System.Type typeofChar;

		// Token: 0x04000DD6 RID: 3542
		[global::Cpp2ILInjected.Token(Token = "0x40010C8")]
		internal static global::System.Type typeofDecimal;

		// Token: 0x04000DD7 RID: 3543
		[global::Cpp2ILInjected.Token(Token = "0x40010C9")]
		internal static global::System.Type typeofDouble;

		// Token: 0x04000DD8 RID: 3544
		[global::Cpp2ILInjected.Token(Token = "0x40010CA")]
		internal static global::System.Type typeofInt16;

		// Token: 0x04000DD9 RID: 3545
		[global::Cpp2ILInjected.Token(Token = "0x40010CB")]
		internal static global::System.Type typeofInt32;

		// Token: 0x04000DDA RID: 3546
		[global::Cpp2ILInjected.Token(Token = "0x40010CC")]
		internal static global::System.Type typeofInt64;

		// Token: 0x04000DDB RID: 3547
		[global::Cpp2ILInjected.Token(Token = "0x40010CD")]
		internal static global::System.Type typeofSByte;

		// Token: 0x04000DDC RID: 3548
		[global::Cpp2ILInjected.Token(Token = "0x40010CE")]
		internal static global::System.Type typeofSingle;

		// Token: 0x04000DDD RID: 3549
		[global::Cpp2ILInjected.Token(Token = "0x40010CF")]
		internal static global::System.Type typeofTimeSpan;

		// Token: 0x04000DDE RID: 3550
		[global::Cpp2ILInjected.Token(Token = "0x40010D0")]
		internal static global::System.Type typeofDateTime;

		// Token: 0x04000DDF RID: 3551
		[global::Cpp2ILInjected.Token(Token = "0x40010D1")]
		internal static global::System.Type typeofUInt16;

		// Token: 0x04000DE0 RID: 3552
		[global::Cpp2ILInjected.Token(Token = "0x40010D2")]
		internal static global::System.Type typeofUInt32;

		// Token: 0x04000DE1 RID: 3553
		[global::Cpp2ILInjected.Token(Token = "0x40010D3")]
		internal static global::System.Type typeofUInt64;

		// Token: 0x04000DE2 RID: 3554
		[global::Cpp2ILInjected.Token(Token = "0x40010D4")]
		internal static global::System.Type typeofObject;

		// Token: 0x04000DE3 RID: 3555
		[global::Cpp2ILInjected.Token(Token = "0x40010D5")]
		internal static global::System.Type typeofSystemVoid;

		// Token: 0x04000DE4 RID: 3556
		[global::Cpp2ILInjected.Token(Token = "0x40010D6")]
		internal static global::System.Reflection.Assembly urtAssembly;

		// Token: 0x04000DE5 RID: 3557
		[global::Cpp2ILInjected.Token(Token = "0x40010D7")]
		internal static string urtAssemblyString;

		// Token: 0x04000DE6 RID: 3558
		[global::Cpp2ILInjected.Token(Token = "0x40010D8")]
		internal static global::System.Type typeofTypeArray;

		// Token: 0x04000DE7 RID: 3559
		[global::Cpp2ILInjected.Token(Token = "0x40010D9")]
		internal static global::System.Type typeofObjectArray;

		// Token: 0x04000DE8 RID: 3560
		[global::Cpp2ILInjected.Token(Token = "0x40010DA")]
		internal static global::System.Type typeofStringArray;

		// Token: 0x04000DE9 RID: 3561
		[global::Cpp2ILInjected.Token(Token = "0x40010DB")]
		internal static global::System.Type typeofBooleanArray;

		// Token: 0x04000DEA RID: 3562
		[global::Cpp2ILInjected.Token(Token = "0x40010DC")]
		internal static global::System.Type typeofByteArray;

		// Token: 0x04000DEB RID: 3563
		[global::Cpp2ILInjected.Token(Token = "0x40010DD")]
		internal static global::System.Type typeofCharArray;

		// Token: 0x04000DEC RID: 3564
		[global::Cpp2ILInjected.Token(Token = "0x40010DE")]
		internal static global::System.Type typeofDecimalArray;

		// Token: 0x04000DED RID: 3565
		[global::Cpp2ILInjected.Token(Token = "0x40010DF")]
		internal static global::System.Type typeofDoubleArray;

		// Token: 0x04000DEE RID: 3566
		[global::Cpp2ILInjected.Token(Token = "0x40010E0")]
		internal static global::System.Type typeofInt16Array;

		// Token: 0x04000DEF RID: 3567
		[global::Cpp2ILInjected.Token(Token = "0x40010E1")]
		internal static global::System.Type typeofInt32Array;

		// Token: 0x04000DF0 RID: 3568
		[global::Cpp2ILInjected.Token(Token = "0x40010E2")]
		internal static global::System.Type typeofInt64Array;

		// Token: 0x04000DF1 RID: 3569
		[global::Cpp2ILInjected.Token(Token = "0x40010E3")]
		internal static global::System.Type typeofSByteArray;

		// Token: 0x04000DF2 RID: 3570
		[global::Cpp2ILInjected.Token(Token = "0x40010E4")]
		internal static global::System.Type typeofSingleArray;

		// Token: 0x04000DF3 RID: 3571
		[global::Cpp2ILInjected.Token(Token = "0x40010E5")]
		internal static global::System.Type typeofTimeSpanArray;

		// Token: 0x04000DF4 RID: 3572
		[global::Cpp2ILInjected.Token(Token = "0x40010E6")]
		internal static global::System.Type typeofDateTimeArray;

		// Token: 0x04000DF5 RID: 3573
		[global::Cpp2ILInjected.Token(Token = "0x40010E7")]
		internal static global::System.Type typeofUInt16Array;

		// Token: 0x04000DF6 RID: 3574
		[global::Cpp2ILInjected.Token(Token = "0x40010E8")]
		internal static global::System.Type typeofUInt32Array;

		// Token: 0x04000DF7 RID: 3575
		[global::Cpp2ILInjected.Token(Token = "0x40010E9")]
		internal static global::System.Type typeofUInt64Array;

		// Token: 0x04000DF8 RID: 3576
		[global::Cpp2ILInjected.Token(Token = "0x40010EA")]
		internal static global::System.Type typeofMarshalByRefObject;
	}
}
