using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200036C RID: 876
	[global::Cpp2ILInjected.Token(Token = "0x2000414")]
	internal sealed class ObjectProgress
	{
		// Token: 0x06001DED RID: 7661 RVA: 0x000198CE File Offset: 0x00017ACE
		[global::Cpp2ILInjected.Token(Token = "0x600202B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5EE00", Offset = "0x1B5EE00", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParseRecord), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ObjectProgress()
		{
			throw null;
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x000198D1 File Offset: 0x00017AD1
		[global::Cpp2ILInjected.Token(Token = "0x600202C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5EE68", Offset = "0x1B5EE68", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "GetOp", ReturnType = typeof(ObjectProgress))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParseRecord), Member = "Init", ReturnType = typeof(void))]
		internal void Init()
		{
			throw null;
		}

		// Token: 0x06001DEF RID: 7663 RVA: 0x000198D4 File Offset: 0x00017AD4
		[global::Cpp2ILInjected.Token(Token = "0x600202D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5EEA8", Offset = "0x1B5EEA8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectNull", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void ArrayCountIncrement(int value)
		{
			throw null;
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x000198D7 File Offset: 0x00017AD7
		[global::Cpp2ILInjected.Token(Token = "0x600202E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5EEB8", Offset = "0x1B5EEB8", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation)
		{
			throw null;
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x000198DA File Offset: 0x00017ADA
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600202F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5EF78", Offset = "0x1B5EF78", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static ObjectProgress()
		{
			throw null;
		}

		// Token: 0x04000DB6 RID: 3510
		[global::Cpp2ILInjected.Token(Token = "0x40010A8")]
		internal static int opRecordIdCount;

		// Token: 0x04000DB7 RID: 3511
		[global::Cpp2ILInjected.Token(Token = "0x40010A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal bool isInitial;

		// Token: 0x04000DB8 RID: 3512
		[global::Cpp2ILInjected.Token(Token = "0x40010AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int count;

		// Token: 0x04000DB9 RID: 3513
		[global::Cpp2ILInjected.Token(Token = "0x40010AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal BinaryTypeEnum expectedType;

		// Token: 0x04000DBA RID: 3514
		[global::Cpp2ILInjected.Token(Token = "0x40010AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal object expectedTypeInformation;

		// Token: 0x04000DBB RID: 3515
		[global::Cpp2ILInjected.Token(Token = "0x40010AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string name;

		// Token: 0x04000DBC RID: 3516
		[global::Cpp2ILInjected.Token(Token = "0x40010AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal InternalObjectTypeE objectTypeEnum;

		// Token: 0x04000DBD RID: 3517
		[global::Cpp2ILInjected.Token(Token = "0x40010AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal InternalMemberTypeE memberTypeEnum;

		// Token: 0x04000DBE RID: 3518
		[global::Cpp2ILInjected.Token(Token = "0x40010B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal InternalMemberValueE memberValueEnum;

		// Token: 0x04000DBF RID: 3519
		[global::Cpp2ILInjected.Token(Token = "0x40010B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal global::System.Type dtType;

		// Token: 0x04000DC0 RID: 3520
		[global::Cpp2ILInjected.Token(Token = "0x40010B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal int numItems;

		// Token: 0x04000DC1 RID: 3521
		[global::Cpp2ILInjected.Token(Token = "0x40010B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		internal BinaryTypeEnum binaryTypeEnum;

		// Token: 0x04000DC2 RID: 3522
		[global::Cpp2ILInjected.Token(Token = "0x40010B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal object typeInformation;

		// Token: 0x04000DC3 RID: 3523
		[global::Cpp2ILInjected.Token(Token = "0x40010B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal int nullCount;

		// Token: 0x04000DC4 RID: 3524
		[global::Cpp2ILInjected.Token(Token = "0x40010B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		internal int memberLength;

		// Token: 0x04000DC5 RID: 3525
		[global::Cpp2ILInjected.Token(Token = "0x40010B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal BinaryTypeEnum[] binaryTypeEnumA;

		// Token: 0x04000DC6 RID: 3526
		[global::Cpp2ILInjected.Token(Token = "0x40010B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal object[] typeInformationA;

		// Token: 0x04000DC7 RID: 3527
		[global::Cpp2ILInjected.Token(Token = "0x40010B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal string[] memberNames;

		// Token: 0x04000DC8 RID: 3528
		[global::Cpp2ILInjected.Token(Token = "0x40010BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal global::System.Type[] memberTypes;

		// Token: 0x04000DC9 RID: 3529
		[global::Cpp2ILInjected.Token(Token = "0x40010BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		internal ParseRecord pr;
	}
}
