using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200036B RID: 875
	[global::Cpp2ILInjected.Token(Token = "0x2000413")]
	internal sealed class ObjectMap
	{
		// Token: 0x06001DE8 RID: 7656 RVA: 0x000198BF File Offset: 0x00017ABF
		[global::Cpp2ILInjected.Token(Token = "0x6002026")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E408", Offset = "0x1B5E408", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectMap), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type),
			typeof(string[]),
			typeof(ObjectReader),
			typeof(int),
			typeof(BinaryAssemblyInfo)
		}, ReturnType = typeof(ObjectMap))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "CreateReadObjectInfo", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(ReadObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "GetMemberTypes", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Type[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryConverter), Member = "GetParserBinaryTypeInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ref object)
		}, ReturnType = typeof(BinaryTypeEnum))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal ObjectMap(string objectName, global::System.Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo)
		{
			throw null;
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x000198C2 File Offset: 0x00017AC2
		[global::Cpp2ILInjected.Token(Token = "0x6002027")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E94C", Offset = "0x1B5E94C", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectMap), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(BinaryTypeEnum[]),
			typeof(object[]),
			typeof(int[]),
			typeof(ObjectReader),
			typeof(int),
			typeof(BinaryAssemblyInfo),
			typeof(SizedArray)
		}, ReturnType = typeof(ObjectMap))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "GetType", MemberParameters = new object[]
		{
			typeof(BinaryAssemblyInfo),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SizedArray), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryConverter), Member = "TypeFromInfo", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "CreateReadObjectInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string[]),
			typeof(global::System.Type[])
		}, ReturnType = typeof(ReadObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "GetMemberTypes", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Type[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal ObjectMap(string objectName, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable)
		{
			throw null;
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x000198C5 File Offset: 0x00017AC5
		[global::Cpp2ILInjected.Token(Token = "0x6002028")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5EBAC", Offset = "0x1B5EBAC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryObjectWithMap) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryObjectWithMapTyped) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "InitDataStore", MemberParameters = new object[]
		{
			typeof(ref SerializationInfo),
			typeof(ref object[])
		}, ReturnType = typeof(void))]
		internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref object[] memberData)
		{
			throw null;
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x000198C8 File Offset: 0x00017AC8
		[global::Cpp2ILInjected.Token(Token = "0x6002029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5ECAC", Offset = "0x1B5ECAC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryObjectWithMap) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectMap), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type),
			typeof(string[]),
			typeof(ObjectReader),
			typeof(int),
			typeof(BinaryAssemblyInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ObjectMap Create(string name, global::System.Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo)
		{
			throw null;
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x000198CB File Offset: 0x00017ACB
		[global::Cpp2ILInjected.Token(Token = "0x600202A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5ED44", Offset = "0x1B5ED44", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryObjectWithMapTyped) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectMap), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(BinaryTypeEnum[]),
			typeof(object[]),
			typeof(int[]),
			typeof(ObjectReader),
			typeof(int),
			typeof(BinaryAssemblyInfo),
			typeof(SizedArray)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ObjectMap Create(string name, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable)
		{
			throw null;
		}

		// Token: 0x04000DAB RID: 3499
		[global::Cpp2ILInjected.Token(Token = "0x400109D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string objectName;

		// Token: 0x04000DAC RID: 3500
		[global::Cpp2ILInjected.Token(Token = "0x400109E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.Type objectType;

		// Token: 0x04000DAD RID: 3501
		[global::Cpp2ILInjected.Token(Token = "0x400109F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal BinaryTypeEnum[] binaryTypeEnumA;

		// Token: 0x04000DAE RID: 3502
		[global::Cpp2ILInjected.Token(Token = "0x40010A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal object[] typeInformationA;

		// Token: 0x04000DAF RID: 3503
		[global::Cpp2ILInjected.Token(Token = "0x40010A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal global::System.Type[] memberTypes;

		// Token: 0x04000DB0 RID: 3504
		[global::Cpp2ILInjected.Token(Token = "0x40010A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal string[] memberNames;

		// Token: 0x04000DB1 RID: 3505
		[global::Cpp2ILInjected.Token(Token = "0x40010A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal ReadObjectInfo objectInfo;

		// Token: 0x04000DB2 RID: 3506
		[global::Cpp2ILInjected.Token(Token = "0x40010A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal bool isInitObjectInfo;

		// Token: 0x04000DB3 RID: 3507
		[global::Cpp2ILInjected.Token(Token = "0x40010A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal ObjectReader objectReader;

		// Token: 0x04000DB4 RID: 3508
		[global::Cpp2ILInjected.Token(Token = "0x40010A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal int objectId;

		// Token: 0x04000DB5 RID: 3509
		[global::Cpp2ILInjected.Token(Token = "0x40010A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal BinaryAssemblyInfo assemblyInfo;
	}
}
