using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200037A RID: 890
	[global::Cpp2ILInjected.Token(Token = "0x2000424")]
	internal sealed class SerStack
	{
		// Token: 0x06001EE0 RID: 7904 RVA: 0x00019BA7 File Offset: 0x00017DA7
		[global::Cpp2ILInjected.Token(Token = "0x6002121")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B652AC", Offset = "0x1B652AC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerObjectInfoInit), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "get_ValueFixupStack", ReturnType = typeof(SerStack))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "InitFullDeserialization", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(InternalFE),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(ObjectReader)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "PutOp", MemberParameters = new object[] { typeof(ObjectProgress) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal SerStack(string stackId)
		{
			throw null;
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x00019BAA File Offset: 0x00017DAA
		[global::Cpp2ILInjected.Token(Token = "0x6002122")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B66F88", Offset = "0x1B66F88", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "ObjectEnd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "PutObjectInfo", MemberParameters = new object[]
		{
			typeof(SerObjectInfoInit),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseSerializedStreamHeader", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseObject", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(__BinaryWriter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(string[]),
			typeof(global::System.Type[]),
			typeof(object[]),
			typeof(WriteObjectInfo[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteMemberSetup", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(string),
			typeof(global::System.Type),
			typeof(object),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "PutNameInfo", MemberParameters = new object[] { typeof(NameInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryObjectWithMap) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryObjectWithMapTyped) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "PutOp", MemberParameters = new object[] { typeof(ObjectProgress) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "IncreaseCapacity", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void Push(object obj)
		{
			throw null;
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x00019BAD File Offset: 0x00017DAD
		[global::Cpp2ILInjected.Token(Token = "0x6002123")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B67008", Offset = "0x1B67008", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "GetObjectInfo", MemberParameters = new object[] { typeof(SerObjectInfoInit) }, ReturnType = typeof(WriteObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal object Pop()
		{
			throw null;
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x00019BB0 File Offset: 0x00017DB0
		[global::Cpp2ILInjected.Token(Token = "0x6002124")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6ECF4", Offset = "0x1B6ECF4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void IncreaseCapacity()
		{
			throw null;
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x00019BB3 File Offset: 0x00017DB3
		[global::Cpp2ILInjected.Token(Token = "0x6002125")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6765C", Offset = "0x1B6765C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal object Peek()
		{
			throw null;
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00019BB6 File Offset: 0x00017DB6
		[global::Cpp2ILInjected.Token(Token = "0x6002126")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6DDC4", Offset = "0x1B6DDC4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal object PeekPeek()
		{
			throw null;
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00019BB9 File Offset: 0x00017DB9
		[global::Cpp2ILInjected.Token(Token = "0x6002127")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6B750", Offset = "0x1B6B750", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "GetObjectInfo", MemberParameters = new object[] { typeof(SerObjectInfoInit) }, ReturnType = typeof(WriteObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal bool IsEmpty()
		{
			throw null;
		}

		// Token: 0x04000EB8 RID: 3768
		[global::Cpp2ILInjected.Token(Token = "0x40011AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal object[] objects;

		// Token: 0x04000EB9 RID: 3769
		[global::Cpp2ILInjected.Token(Token = "0x40011AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string stackId;

		// Token: 0x04000EBA RID: 3770
		[global::Cpp2ILInjected.Token(Token = "0x40011AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int top;
	}
}
