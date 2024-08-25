using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000423")]
	internal sealed class ParseRecord
	{
		[global::Cpp2ILInjected.Token(Token = "0x600211E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6BB18", Offset = "0x1B6BB18", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectProgress), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ParseRecord()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600211F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6D860", Offset = "0x1B6D860", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectProgress), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void Init()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002120")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6ECA8", Offset = "0x1B6ECA8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static ParseRecord()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001184")]
		internal static int parseRecordIdCount;

		[global::Cpp2ILInjected.Token(Token = "0x4001185")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal InternalParseTypeE PRparseTypeEnum;

		[global::Cpp2ILInjected.Token(Token = "0x4001186")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal InternalObjectTypeE PRobjectTypeEnum;

		[global::Cpp2ILInjected.Token(Token = "0x4001187")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal InternalArrayTypeE PRarrayTypeEnum;

		[global::Cpp2ILInjected.Token(Token = "0x4001188")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal InternalMemberTypeE PRmemberTypeEnum;

		[global::Cpp2ILInjected.Token(Token = "0x4001189")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal InternalMemberValueE PRmemberValueEnum;

		[global::Cpp2ILInjected.Token(Token = "0x400118A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal InternalObjectPositionE PRobjectPositionEnum;

		[global::Cpp2ILInjected.Token(Token = "0x400118B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string PRname;

		[global::Cpp2ILInjected.Token(Token = "0x400118C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal string PRvalue;

		[global::Cpp2ILInjected.Token(Token = "0x400118D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal object PRvarValue;

		[global::Cpp2ILInjected.Token(Token = "0x400118E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal string PRkeyDt;

		[global::Cpp2ILInjected.Token(Token = "0x400118F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal global::System.Type PRdtType;

		[global::Cpp2ILInjected.Token(Token = "0x4001190")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal InternalPrimitiveTypeE PRdtTypeCode;

		[global::Cpp2ILInjected.Token(Token = "0x4001191")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		internal bool PRisEnum;

		[global::Cpp2ILInjected.Token(Token = "0x4001192")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal long PRobjectId;

		[global::Cpp2ILInjected.Token(Token = "0x4001193")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal long PRidRef;

		[global::Cpp2ILInjected.Token(Token = "0x4001194")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal string PRarrayElementTypeString;

		[global::Cpp2ILInjected.Token(Token = "0x4001195")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal global::System.Type PRarrayElementType;

		[global::Cpp2ILInjected.Token(Token = "0x4001196")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal bool PRisArrayVariant;

		[global::Cpp2ILInjected.Token(Token = "0x4001197")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		internal InternalPrimitiveTypeE PRarrayElementTypeCode;

		[global::Cpp2ILInjected.Token(Token = "0x4001198")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		internal int PRrank;

		[global::Cpp2ILInjected.Token(Token = "0x4001199")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		internal int[] PRlengthA;

		[global::Cpp2ILInjected.Token(Token = "0x400119A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal int[] PRpositionA;

		[global::Cpp2ILInjected.Token(Token = "0x400119B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		internal int[] PRlowerBoundA;

		[global::Cpp2ILInjected.Token(Token = "0x400119C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		internal int[] PRupperBoundA;

		[global::Cpp2ILInjected.Token(Token = "0x400119D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		internal int[] PRindexMap;

		[global::Cpp2ILInjected.Token(Token = "0x400119E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		internal int PRmemberIndex;

		[global::Cpp2ILInjected.Token(Token = "0x400119F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		internal int PRlinearlength;

		[global::Cpp2ILInjected.Token(Token = "0x40011A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		internal int[] PRrectangularMap;

		[global::Cpp2ILInjected.Token(Token = "0x40011A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		internal bool PRisLowerBound;

		[global::Cpp2ILInjected.Token(Token = "0x40011A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		internal long PRtopId;

		[global::Cpp2ILInjected.Token(Token = "0x40011A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		internal long PRheaderId;

		[global::Cpp2ILInjected.Token(Token = "0x40011A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		internal ReadObjectInfo PRobjectInfo;

		[global::Cpp2ILInjected.Token(Token = "0x40011A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		internal bool PRisValueTypeFixup;

		[global::Cpp2ILInjected.Token(Token = "0x40011A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		internal object PRnewObj;

		[global::Cpp2ILInjected.Token(Token = "0x40011A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		internal object[] PRobjectA;

		[global::Cpp2ILInjected.Token(Token = "0x40011A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		internal PrimitiveArray PRprimitiveArray;

		[global::Cpp2ILInjected.Token(Token = "0x40011A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		internal bool PRisRegistered;

		[global::Cpp2ILInjected.Token(Token = "0x40011AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		internal object[] PRmemberData;

		[global::Cpp2ILInjected.Token(Token = "0x40011AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		internal SerializationInfo PRsi;

		[global::Cpp2ILInjected.Token(Token = "0x40011AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		internal int PRnullCount;
	}
}
