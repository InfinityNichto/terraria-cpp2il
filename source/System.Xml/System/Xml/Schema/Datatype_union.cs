using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000B4 RID: 180
	[global::Cpp2ILInjected.Token(Token = "0x20000E0")]
	internal class Datatype_union : Datatype_anySimpleType
	{
		// Token: 0x06000802 RID: 2050 RVA: 0x0000465E File Offset: 0x0000285E
		[global::Cpp2ILInjected.Token(Token = "0x6000897")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBDF40", Offset = "0x1DBDF40", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "DeriveByList", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlSchemaType)
		}, ReturnType = typeof(XmlSchemaDatatype))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal bool HasAtomicMembers()
		{
			throw null;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00004661 File Offset: 0x00002861
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000898")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBDFAC", Offset = "0x1DBDFAC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Datatype_union()
		{
			throw null;
		}

		// Token: 0x04000354 RID: 852
		[global::Cpp2ILInjected.Token(Token = "0x40004CE")]
		private static readonly Type atomicValueType;

		// Token: 0x04000355 RID: 853
		[global::Cpp2ILInjected.Token(Token = "0x40004CF")]
		private static readonly Type listValueType;

		// Token: 0x04000356 RID: 854
		[global::Cpp2ILInjected.Token(Token = "0x40004D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private XmlSchemaSimpleType[] types;
	}
}
