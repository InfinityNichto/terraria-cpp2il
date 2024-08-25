using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000428")]
	internal sealed class ValueFixup
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002139")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B680D0", Offset = "0x1B680D0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ValueFixup(global::System.Array arrayObj, int[] indexMap)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600213A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B68468", Offset = "0x1B68468", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ValueFixup(object memberObject, string memberName, ReadObjectInfo objectInfo)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600213B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B67684", Offset = "0x1B67684", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseObjectEnd", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MemberInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMember", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "SerializationSetValue", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "GetMemberInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.MemberInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MemberInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal void Fixup(ParseRecord record, ParseRecord parent)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40011B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ValueFixupEnum valueFixupEnum;

		[global::Cpp2ILInjected.Token(Token = "0x40011B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.Array arrayObj;

		[global::Cpp2ILInjected.Token(Token = "0x40011B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int[] indexMap;

		[global::Cpp2ILInjected.Token(Token = "0x40011B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal object header;

		[global::Cpp2ILInjected.Token(Token = "0x40011BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal object memberObject;

		[global::Cpp2ILInjected.Token(Token = "0x40011BB")]
		internal static global::System.Reflection.MemberInfo valueInfo;

		[global::Cpp2ILInjected.Token(Token = "0x40011BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal ReadObjectInfo objectInfo;

		[global::Cpp2ILInjected.Token(Token = "0x40011BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal string memberName;
	}
}
