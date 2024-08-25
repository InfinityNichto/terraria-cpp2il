using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x200040E")]
	internal sealed class BinaryArray
	{
		[global::Cpp2ILInjected.Token(Token = "0x600200C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5DCC0", Offset = "0x1B5DCC0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryArray()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600200D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5DCC8", Offset = "0x1B5DCC8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryArray(BinaryHeaderEnum binaryHeaderEnum)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600200E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5DCF0", Offset = "0x1B5DCF0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600200F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5DD44", Offset = "0x1B5DD44", Length = "0x230")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteJaggedArray", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteRectangleArray", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(int[]),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryConverter), Member = "WriteTypeInfo", MemberParameters = new object[]
		{
			typeof(BinaryTypeEnum),
			typeof(object),
			typeof(int),
			typeof(__BinaryWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5DF74", Offset = "0x1B5DF74", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadByte", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryConverter), Member = "ReadTypeInfo", MemberParameters = new object[]
		{
			typeof(BinaryTypeEnum),
			typeof(__BinaryParser),
			typeof(ref int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001090")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int objectId;

		[global::Cpp2ILInjected.Token(Token = "0x4001091")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int rank;

		[global::Cpp2ILInjected.Token(Token = "0x4001092")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int[] lengthA;

		[global::Cpp2ILInjected.Token(Token = "0x4001093")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int[] lowerBoundA;

		[global::Cpp2ILInjected.Token(Token = "0x4001094")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal BinaryTypeEnum binaryTypeEnum;

		[global::Cpp2ILInjected.Token(Token = "0x4001095")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal object typeInformation;

		[global::Cpp2ILInjected.Token(Token = "0x4001096")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal int assemId;

		[global::Cpp2ILInjected.Token(Token = "0x4001097")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private BinaryHeaderEnum binaryHeaderEnum;

		[global::Cpp2ILInjected.Token(Token = "0x4001098")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal BinaryArrayTypeEnum binaryArrayTypeEnum;
	}
}
