using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000365 RID: 869
	[global::Cpp2ILInjected.Token(Token = "0x200040D")]
	internal sealed class BinaryObjectWithMapTyped
	{
		// Token: 0x06001DC9 RID: 7625 RVA: 0x00019862 File Offset: 0x00017A62
		[global::Cpp2ILInjected.Token(Token = "0x6002007")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D8D4", Offset = "0x1B5D8D4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryObjectWithMapTyped()
		{
			throw null;
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00019865 File Offset: 0x00017A65
		[global::Cpp2ILInjected.Token(Token = "0x6002008")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D8DC", Offset = "0x1B5D8DC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum)
		{
			throw null;
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x00019868 File Offset: 0x00017A68
		[global::Cpp2ILInjected.Token(Token = "0x6002009")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D904", Offset = "0x1B5D904", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId)
		{
			throw null;
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x0001986B File Offset: 0x00017A6B
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

		// Token: 0x06001DCD RID: 7629 RVA: 0x0001986E File Offset: 0x00017A6E
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

		// Token: 0x04000D95 RID: 3477
		[global::Cpp2ILInjected.Token(Token = "0x4001087")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal BinaryHeaderEnum binaryHeaderEnum;

		// Token: 0x04000D96 RID: 3478
		[global::Cpp2ILInjected.Token(Token = "0x4001088")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int objectId;

		// Token: 0x04000D97 RID: 3479
		[global::Cpp2ILInjected.Token(Token = "0x4001089")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string name;

		// Token: 0x04000D98 RID: 3480
		[global::Cpp2ILInjected.Token(Token = "0x400108A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int numMembers;

		// Token: 0x04000D99 RID: 3481
		[global::Cpp2ILInjected.Token(Token = "0x400108B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal string[] memberNames;

		// Token: 0x04000D9A RID: 3482
		[global::Cpp2ILInjected.Token(Token = "0x400108C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal BinaryTypeEnum[] binaryTypeEnumA;

		// Token: 0x04000D9B RID: 3483
		[global::Cpp2ILInjected.Token(Token = "0x400108D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal object[] typeInformationA;

		// Token: 0x04000D9C RID: 3484
		[global::Cpp2ILInjected.Token(Token = "0x400108E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal int[] memberAssemIds;

		// Token: 0x04000D9D RID: 3485
		[global::Cpp2ILInjected.Token(Token = "0x400108F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal int assemId;
	}
}
