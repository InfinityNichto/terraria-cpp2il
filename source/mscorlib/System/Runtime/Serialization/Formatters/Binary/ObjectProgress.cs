using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000414")]
	internal sealed class ObjectProgress
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600202D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5EEA8", Offset = "0x1B5EEA8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectNull", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void ArrayCountIncrement(int value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600202E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5EEB8", Offset = "0x1B5EEB8", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600202F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5EF78", Offset = "0x1B5EF78", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static ObjectProgress()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40010A8")]
		internal static int opRecordIdCount;

		[global::Cpp2ILInjected.Token(Token = "0x40010A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal bool isInitial;

		[global::Cpp2ILInjected.Token(Token = "0x40010AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int count;

		[global::Cpp2ILInjected.Token(Token = "0x40010AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal BinaryTypeEnum expectedType;

		[global::Cpp2ILInjected.Token(Token = "0x40010AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal object expectedTypeInformation;

		[global::Cpp2ILInjected.Token(Token = "0x40010AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string name;

		[global::Cpp2ILInjected.Token(Token = "0x40010AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal InternalObjectTypeE objectTypeEnum;

		[global::Cpp2ILInjected.Token(Token = "0x40010AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal InternalMemberTypeE memberTypeEnum;

		[global::Cpp2ILInjected.Token(Token = "0x40010B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal InternalMemberValueE memberValueEnum;

		[global::Cpp2ILInjected.Token(Token = "0x40010B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal global::System.Type dtType;

		[global::Cpp2ILInjected.Token(Token = "0x40010B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal int numItems;

		[global::Cpp2ILInjected.Token(Token = "0x40010B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		internal BinaryTypeEnum binaryTypeEnum;

		[global::Cpp2ILInjected.Token(Token = "0x40010B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal object typeInformation;

		[global::Cpp2ILInjected.Token(Token = "0x40010B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal int nullCount;

		[global::Cpp2ILInjected.Token(Token = "0x40010B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		internal int memberLength;

		[global::Cpp2ILInjected.Token(Token = "0x40010B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal BinaryTypeEnum[] binaryTypeEnumA;

		[global::Cpp2ILInjected.Token(Token = "0x40010B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal object[] typeInformationA;

		[global::Cpp2ILInjected.Token(Token = "0x40010B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal string[] memberNames;

		[global::Cpp2ILInjected.Token(Token = "0x40010BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal global::System.Type[] memberTypes;

		[global::Cpp2ILInjected.Token(Token = "0x40010BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		internal ParseRecord pr;
	}
}
