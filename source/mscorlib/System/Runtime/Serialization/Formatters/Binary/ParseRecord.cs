using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000379 RID: 889
	[global::Cpp2ILInjected.Token(Token = "0x2000423")]
	internal sealed class ParseRecord
	{
		// Token: 0x06001EDD RID: 7901 RVA: 0x00019B9E File Offset: 0x00017D9E
		[global::Cpp2ILInjected.Token(Token = "0x600211E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6BB18", Offset = "0x1B6BB18", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectProgress), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ParseRecord()
		{
			throw null;
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x00019BA1 File Offset: 0x00017DA1
		[global::Cpp2ILInjected.Token(Token = "0x600211F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6D860", Offset = "0x1B6D860", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectProgress), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void Init()
		{
			throw null;
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x00019BA4 File Offset: 0x00017DA4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002120")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6ECA8", Offset = "0x1B6ECA8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static ParseRecord()
		{
			throw null;
		}

		// Token: 0x04000E8F RID: 3727
		[global::Cpp2ILInjected.Token(Token = "0x4001184")]
		internal static int parseRecordIdCount;

		// Token: 0x04000E90 RID: 3728
		[global::Cpp2ILInjected.Token(Token = "0x4001185")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal InternalParseTypeE PRparseTypeEnum;

		// Token: 0x04000E91 RID: 3729
		[global::Cpp2ILInjected.Token(Token = "0x4001186")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal InternalObjectTypeE PRobjectTypeEnum;

		// Token: 0x04000E92 RID: 3730
		[global::Cpp2ILInjected.Token(Token = "0x4001187")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal InternalArrayTypeE PRarrayTypeEnum;

		// Token: 0x04000E93 RID: 3731
		[global::Cpp2ILInjected.Token(Token = "0x4001188")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal InternalMemberTypeE PRmemberTypeEnum;

		// Token: 0x04000E94 RID: 3732
		[global::Cpp2ILInjected.Token(Token = "0x4001189")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal InternalMemberValueE PRmemberValueEnum;

		// Token: 0x04000E95 RID: 3733
		[global::Cpp2ILInjected.Token(Token = "0x400118A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal InternalObjectPositionE PRobjectPositionEnum;

		// Token: 0x04000E96 RID: 3734
		[global::Cpp2ILInjected.Token(Token = "0x400118B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string PRname;

		// Token: 0x04000E97 RID: 3735
		[global::Cpp2ILInjected.Token(Token = "0x400118C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal string PRvalue;

		// Token: 0x04000E98 RID: 3736
		[global::Cpp2ILInjected.Token(Token = "0x400118D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal object PRvarValue;

		// Token: 0x04000E99 RID: 3737
		[global::Cpp2ILInjected.Token(Token = "0x400118E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal string PRkeyDt;

		// Token: 0x04000E9A RID: 3738
		[global::Cpp2ILInjected.Token(Token = "0x400118F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal global::System.Type PRdtType;

		// Token: 0x04000E9B RID: 3739
		[global::Cpp2ILInjected.Token(Token = "0x4001190")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal InternalPrimitiveTypeE PRdtTypeCode;

		// Token: 0x04000E9C RID: 3740
		[global::Cpp2ILInjected.Token(Token = "0x4001191")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		internal bool PRisEnum;

		// Token: 0x04000E9D RID: 3741
		[global::Cpp2ILInjected.Token(Token = "0x4001192")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal long PRobjectId;

		// Token: 0x04000E9E RID: 3742
		[global::Cpp2ILInjected.Token(Token = "0x4001193")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal long PRidRef;

		// Token: 0x04000E9F RID: 3743
		[global::Cpp2ILInjected.Token(Token = "0x4001194")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal string PRarrayElementTypeString;

		// Token: 0x04000EA0 RID: 3744
		[global::Cpp2ILInjected.Token(Token = "0x4001195")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal global::System.Type PRarrayElementType;

		// Token: 0x04000EA1 RID: 3745
		[global::Cpp2ILInjected.Token(Token = "0x4001196")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal bool PRisArrayVariant;

		// Token: 0x04000EA2 RID: 3746
		[global::Cpp2ILInjected.Token(Token = "0x4001197")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		internal InternalPrimitiveTypeE PRarrayElementTypeCode;

		// Token: 0x04000EA3 RID: 3747
		[global::Cpp2ILInjected.Token(Token = "0x4001198")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		internal int PRrank;

		// Token: 0x04000EA4 RID: 3748
		[global::Cpp2ILInjected.Token(Token = "0x4001199")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		internal int[] PRlengthA;

		// Token: 0x04000EA5 RID: 3749
		[global::Cpp2ILInjected.Token(Token = "0x400119A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal int[] PRpositionA;

		// Token: 0x04000EA6 RID: 3750
		[global::Cpp2ILInjected.Token(Token = "0x400119B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		internal int[] PRlowerBoundA;

		// Token: 0x04000EA7 RID: 3751
		[global::Cpp2ILInjected.Token(Token = "0x400119C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		internal int[] PRupperBoundA;

		// Token: 0x04000EA8 RID: 3752
		[global::Cpp2ILInjected.Token(Token = "0x400119D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		internal int[] PRindexMap;

		// Token: 0x04000EA9 RID: 3753
		[global::Cpp2ILInjected.Token(Token = "0x400119E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		internal int PRmemberIndex;

		// Token: 0x04000EAA RID: 3754
		[global::Cpp2ILInjected.Token(Token = "0x400119F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		internal int PRlinearlength;

		// Token: 0x04000EAB RID: 3755
		[global::Cpp2ILInjected.Token(Token = "0x40011A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		internal int[] PRrectangularMap;

		// Token: 0x04000EAC RID: 3756
		[global::Cpp2ILInjected.Token(Token = "0x40011A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		internal bool PRisLowerBound;

		// Token: 0x04000EAD RID: 3757
		[global::Cpp2ILInjected.Token(Token = "0x40011A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		internal long PRtopId;

		// Token: 0x04000EAE RID: 3758
		[global::Cpp2ILInjected.Token(Token = "0x40011A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		internal long PRheaderId;

		// Token: 0x04000EAF RID: 3759
		[global::Cpp2ILInjected.Token(Token = "0x40011A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		internal ReadObjectInfo PRobjectInfo;

		// Token: 0x04000EB0 RID: 3760
		[global::Cpp2ILInjected.Token(Token = "0x40011A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		internal bool PRisValueTypeFixup;

		// Token: 0x04000EB1 RID: 3761
		[global::Cpp2ILInjected.Token(Token = "0x40011A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		internal object PRnewObj;

		// Token: 0x04000EB2 RID: 3762
		[global::Cpp2ILInjected.Token(Token = "0x40011A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		internal object[] PRobjectA;

		// Token: 0x04000EB3 RID: 3763
		[global::Cpp2ILInjected.Token(Token = "0x40011A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		internal PrimitiveArray PRprimitiveArray;

		// Token: 0x04000EB4 RID: 3764
		[global::Cpp2ILInjected.Token(Token = "0x40011A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		internal bool PRisRegistered;

		// Token: 0x04000EB5 RID: 3765
		[global::Cpp2ILInjected.Token(Token = "0x40011AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		internal object[] PRmemberData;

		// Token: 0x04000EB6 RID: 3766
		[global::Cpp2ILInjected.Token(Token = "0x40011AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		internal SerializationInfo PRsi;

		// Token: 0x04000EB7 RID: 3767
		[global::Cpp2ILInjected.Token(Token = "0x40011AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		internal int PRnullCount;
	}
}
