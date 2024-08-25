using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x200040D")]
	internal sealed class BinaryObjectWithMapTyped
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002007")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D8D4", Offset = "0x1B5D8D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryObjectWithMapTyped()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002008")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D8DC", Offset = "0x1B5D8DC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002009")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D904", Offset = "0x1B5D904", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600200A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D930", Offset = "0x1B5D930", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteObject", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(string[]),
			typeof(global::System.Type[]),
			typeof(WriteObjectInfo[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryConverter), Member = "WriteTypeInfo", MemberParameters = new object[]
		{
			typeof(BinaryTypeEnum),
			typeof(object),
			typeof(int),
			typeof(__BinaryWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600200B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5DA8C", Offset = "0x1B5DA8C", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadByte", ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryConverter), Member = "ReadTypeInfo", MemberParameters = new object[]
		{
			typeof(BinaryTypeEnum),
			typeof(__BinaryParser),
			typeof(ref int)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001087")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal BinaryHeaderEnum binaryHeaderEnum;

		[global::Cpp2ILInjected.Token(Token = "0x4001088")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int objectId;

		[global::Cpp2ILInjected.Token(Token = "0x4001089")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string name;

		[global::Cpp2ILInjected.Token(Token = "0x400108A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int numMembers;

		[global::Cpp2ILInjected.Token(Token = "0x400108B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string[] memberNames;

		[global::Cpp2ILInjected.Token(Token = "0x400108C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal BinaryTypeEnum[] binaryTypeEnumA;

		[global::Cpp2ILInjected.Token(Token = "0x400108D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal object[] typeInformationA;

		[global::Cpp2ILInjected.Token(Token = "0x400108E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal int[] memberAssemIds;

		[global::Cpp2ILInjected.Token(Token = "0x400108F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal int assemId;
	}
}
