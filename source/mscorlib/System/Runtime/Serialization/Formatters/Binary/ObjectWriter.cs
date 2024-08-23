using System;
using System.Collections;
using System.IO;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000377 RID: 887
	[global::Cpp2ILInjected.Token(Token = "0x2000421")]
	internal sealed class ObjectWriter
	{
		// Token: 0x06001E8F RID: 7823 RVA: 0x00019AB4 File Offset: 0x00017CB4
		[global::Cpp2ILInjected.Token(Token = "0x60020D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B69278", Offset = "0x1B69278", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationObjectManager), Member = ".ctor", MemberParameters = new object[] { typeof(StreamingContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal ObjectWriter(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder)
		{
			throw null;
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00019AB7 File Offset: 0x00017CB7
		[global::Cpp2ILInjected.Token(Token = "0x60020D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6936C", Offset = "0x1B6936C", Length = "0x428")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFormatter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteBegin", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectIDGenerator), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Queue), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerObjectInfoInit), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteSerializationHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "GetNext", MemberParameters = new object[] { typeof(ref long) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(ObjectWriter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(WriteObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "GetAssemblyId", MemberParameters = new object[] { typeof(WriteObjectInfo) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(WriteObjectInfo),
			typeof(InternalPrimitiveTypeE),
			typeof(NameInfo)
		}, ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "ObjectEnd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteSerializationHeaderEnd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteEnd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationObjectManager), Member = "RaiseOnSerializedEvent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		internal void Serialize(object graph, global::System.Runtime.Remoting.Messaging.Header[] inHeaders, __BinaryWriter serWriter, bool fCheck)
		{
			throw null;
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x00019ABA File Offset: 0x00017CBA
		[global::Cpp2ILInjected.Token(Token = "0x1700044C")]
		internal SerializationObjectManager ObjectManager
		{
			[global::Cpp2ILInjected.Token(Token = "0x60020D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B69F18", Offset = "0x1B69F18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x00019ABD File Offset: 0x00017CBD
		[global::Cpp2ILInjected.Token(Token = "0x60020D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B69ABC", Offset = "0x1B69ABC", Length = "0x308")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(__BinaryWriter),
			typeof(bool)
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteObjectString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "GetMemberInfo", MemberParameters = new object[]
		{
			typeof(ref string[]),
			typeof(ref global::System.Type[]),
			typeof(ref object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(ObjectWriter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(WriteObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(WriteObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "GetAssemblyId", MemberParameters = new object[] { typeof(WriteObjectInfo) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(string[]),
			typeof(global::System.Type[]),
			typeof(object[]),
			typeof(WriteObjectInfo[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo)
		{
			throw null;
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x00019AC0 File Offset: 0x00017CC0
		[global::Cpp2ILInjected.Token(Token = "0x60020D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6A668", Offset = "0x1B6A668", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteObject", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(string[]),
			typeof(global::System.Type[]),
			typeof(WriteObjectInfo[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "WriteMemberSetup", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(string),
			typeof(global::System.Type),
			typeof(object),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteObjectEnd", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, global::System.Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos)
		{
			throw null;
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x00019AC3 File Offset: 0x00017CC3
		[global::Cpp2ILInjected.Token(Token = "0x60020D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6A908", Offset = "0x1B6A908", Length = "0xFC")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(WriteObjectInfo),
			typeof(InternalPrimitiveTypeE),
			typeof(NameInfo)
		}, ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, global::System.Type memberType, object memberData, WriteObjectInfo memberObjectInfo)
		{
			throw null;
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x00019AC6 File Offset: 0x00017CC6
		[global::Cpp2ILInjected.Token(Token = "0x60020D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6AA38", Offset = "0x1B6AA38", Length = "0x300")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "CheckForNull", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(WriteObjectInfo),
			typeof(InternalPrimitiveTypeE),
			typeof(NameInfo)
		}, ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "Schedule", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool),
			typeof(global::System.Type),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteMemberNested", MemberParameters = new object[] { typeof(NameInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "WriteKnownValueClass", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteMemberObjectRef", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "ObjectEnd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo)
		{
			throw null;
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x00019AC9 File Offset: 0x00017CC9
		[global::Cpp2ILInjected.Token(Token = "0x60020D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B69F20", Offset = "0x1B69F20", Length = "0x6B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo)
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(WriteObjectInfo),
			typeof(InternalPrimitiveTypeE),
			typeof(NameInfo)
		}, ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(WriteObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "GetAssemblyId", MemberParameters = new object[] { typeof(WriteObjectInfo) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetLowerBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetUpperBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteSingleArray", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(int),
			typeof(global::System.Array)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "IsWriteAsByteArray", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteJaggedArray", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteRectangleArray", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(int[]),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "WriteRectangle", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(int),
			typeof(int[]),
			typeof(global::System.Array),
			typeof(NameInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteObjectByteArray", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(int),
			typeof(int),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteItemEnd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteObjectEnd", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo)
		{
			throw null;
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x00019ACC File Offset: 0x00017CCC
		[global::Cpp2ILInjected.Token(Token = "0x60020D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6AFF0", Offset = "0x1B6AFF0", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteRectangle", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(int),
			typeof(int[]),
			typeof(global::System.Array),
			typeof(NameInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "CheckForNull", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsSealed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "WriteKnownValueClass", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "Schedule", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool),
			typeof(global::System.Type),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteItemObjectRef", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(ObjectWriter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(WriteObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "GetAssemblyId", MemberParameters = new object[] { typeof(WriteObjectInfo) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(WriteObjectInfo),
			typeof(InternalPrimitiveTypeE),
			typeof(NameInfo)
		}, ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "ObjectEnd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data)
		{
			throw null;
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00019ACF File Offset: 0x00017CCF
		[global::Cpp2ILInjected.Token(Token = "0x60020D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6B29C", Offset = "0x1B6B29C", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteArray", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int[]) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, global::System.Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA)
		{
			throw null;
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00019AD2 File Offset: 0x00017CD2
		[global::Cpp2ILInjected.Token(Token = "0x60020DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B69DCC", Offset = "0x1B69DCC", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(__BinaryWriter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private object GetNext(out long objID)
		{
			throw null;
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00019AD5 File Offset: 0x00017CD5
		[global::Cpp2ILInjected.Token(Token = "0x60020DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B697A8", Offset = "0x1B697A8", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Schedule", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool),
			typeof(global::System.Type),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		private long InternalGetId(object obj, bool assignUniqueIdToValueType, global::System.Type type, out bool isNew)
		{
			throw null;
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00019AD8 File Offset: 0x00017CD8
		[global::Cpp2ILInjected.Token(Token = "0x60020DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6B4BC", Offset = "0x1B6B4BC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "Schedule", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool),
			typeof(global::System.Type),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(long))]
		private long Schedule(object obj, bool assignUniqueIdToValueType, global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x00019ADB File Offset: 0x00017CDB
		[global::Cpp2ILInjected.Token(Token = "0x60020DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6AE88", Offset = "0x1B6AE88", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object),
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Schedule", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool),
			typeof(global::System.Type)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "InternalGetId", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool),
			typeof(global::System.Type),
			typeof(ref bool)
		}, ReturnType = typeof(long))]
		private long Schedule(object obj, bool assignUniqueIdToValueType, global::System.Type type, WriteObjectInfo objectInfo)
		{
			throw null;
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00019ADE File Offset: 0x00017CDE
		[global::Cpp2ILInjected.Token(Token = "0x60020DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6AF18", Offset = "0x1B6AF18", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object),
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteItem", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "WriteString", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteMember", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data)
		{
			throw null;
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00019AE1 File Offset: 0x00017CE1
		[global::Cpp2ILInjected.Token(Token = "0x60020DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6AF0C", Offset = "0x1B6AF0C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteMemberObjectRef", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void WriteObjectRef(NameInfo nameInfo, long objectId)
		{
			throw null;
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x00019AE4 File Offset: 0x00017CE4
		[global::Cpp2ILInjected.Token(Token = "0x60020E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6B4C8", Offset = "0x1B6B4C8", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteKnownValueClass", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteMemberString", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteMemberObjectRef", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject)
		{
			throw null;
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x00019AE7 File Offset: 0x00017CE7
		[global::Cpp2ILInjected.Token(Token = "0x60020E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6AD38", Offset = "0x1B6AD38", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object),
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteDelayedNullItem", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteNullMember", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteNullItem", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data)
		{
			throw null;
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00019AEA File Offset: 0x00017CEA
		[global::Cpp2ILInjected.Token(Token = "0x60020E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B69794", Offset = "0x1B69794", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteSerializationHeader", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void WriteSerializedStreamHeader(long topId, long headerId)
		{
			throw null;
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00019AED File Offset: 0x00017CED
		[global::Cpp2ILInjected.Token(Token = "0x60020E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6B5EC", Offset = "0x1B6B5EC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Remoting.Messaging.Header[]),
			typeof(__BinaryWriter),
			typeof(bool)
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[] { typeof(WriteObjectInfo) }, ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo)
		}, ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "GetTypeFullName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
		private NameInfo TypeToNameInfo(global::System.Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo)
		{
			throw null;
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00019AF0 File Offset: 0x00017CF0
		[global::Cpp2ILInjected.Token(Token = "0x60020E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6AA04", Offset = "0x1B6AA04", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
		private NameInfo TypeToNameInfo(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00019AF3 File Offset: 0x00017CF3
		[global::Cpp2ILInjected.Token(Token = "0x60020E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B69A80", Offset = "0x1B69A80", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(WriteObjectInfo),
			typeof(InternalPrimitiveTypeE),
			typeof(NameInfo)
		}, ReturnType = typeof(NameInfo))]
		private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo)
		{
			throw null;
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00019AF6 File Offset: 0x00017CF6
		[global::Cpp2ILInjected.Token(Token = "0x60020E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6AE40", Offset = "0x1B6AE40", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(WriteObjectInfo),
			typeof(InternalPrimitiveTypeE),
			typeof(NameInfo)
		}, ReturnType = typeof(NameInfo))]
		private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo)
		{
			throw null;
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00019AF9 File Offset: 0x00017CF9
		[global::Cpp2ILInjected.Token(Token = "0x60020E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6ADD8", Offset = "0x1B6ADD8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteMembers", MemberParameters = new object[]
		{
			typeof(NameInfo),
			typeof(NameInfo),
			typeof(object),
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
		private void TypeToNameInfo(global::System.Type type, NameInfo nameInfo)
		{
			throw null;
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00019AFC File Offset: 0x00017CFC
		[global::Cpp2ILInjected.Token(Token = "0x60020E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6A8F0", Offset = "0x1B6A8F0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectWriter), Member = "GetNameInfo", ReturnType = typeof(NameInfo))]
		private NameInfo MemberToNameInfo(string name)
		{
			throw null;
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00019AFF File Offset: 0x00017CFF
		[global::Cpp2ILInjected.Token(Token = "0x60020E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6A5E8", Offset = "0x1B6A5E8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "GetBinaryTypeInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(WriteObjectInfo),
			typeof(string),
			typeof(ObjectWriter),
			typeof(ref object),
			typeof(ref int)
		}, ReturnType = typeof(BinaryTypeEnum))]
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
			typeof(NameInfo)
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[] { typeof(WriteObjectInfo) }, ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo)
		}, ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal InternalPrimitiveTypeE ToCode(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00019B02 File Offset: 0x00017D02
		[global::Cpp2ILInjected.Token(Token = "0x60020EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B69854", Offset = "0x1B69854", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
			typeof(NameInfo)
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "GetAssemblyString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteAssembly", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private long GetAssemblyId(WriteObjectInfo objectInfo)
		{
			throw null;
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x00019B05 File Offset: 0x00017D05
		[global::Cpp2ILInjected.Token(Token = "0x60020EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6A5DC", Offset = "0x1B6A5DC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		private global::System.Type GetType(object obj)
		{
			throw null;
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x00019B08 File Offset: 0x00017D08
		[global::Cpp2ILInjected.Token(Token = "0x60020EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6B674", Offset = "0x1B6B674", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(WriteObjectInfo),
			typeof(InternalPrimitiveTypeE),
			typeof(NameInfo)
		}, ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "MemberToNameInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private NameInfo GetNameInfo()
		{
			throw null;
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x00019B0B File Offset: 0x00017D0B
		[global::Cpp2ILInjected.Token(Token = "0x60020ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6A5D0", Offset = "0x1B6A5D0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want)
		{
			throw null;
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x00019B0E File Offset: 0x00017D0E
		[global::Cpp2ILInjected.Token(Token = "0x60020EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B69DC4", Offset = "0x1B69DC4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		private void PutNameInfo(NameInfo nameInfo)
		{
			throw null;
		}

		// Token: 0x04000E61 RID: 3681
		[global::Cpp2ILInjected.Token(Token = "0x4001156")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Collections.Queue m_objectQueue;

		// Token: 0x04000E62 RID: 3682
		[global::Cpp2ILInjected.Token(Token = "0x4001157")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ObjectIDGenerator m_idGenerator;

		// Token: 0x04000E63 RID: 3683
		[global::Cpp2ILInjected.Token(Token = "0x4001158")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int m_currentId;

		// Token: 0x04000E64 RID: 3684
		[global::Cpp2ILInjected.Token(Token = "0x4001159")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ISurrogateSelector m_surrogates;

		// Token: 0x04000E65 RID: 3685
		[global::Cpp2ILInjected.Token(Token = "0x400115A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private StreamingContext m_context;

		// Token: 0x04000E66 RID: 3686
		[global::Cpp2ILInjected.Token(Token = "0x400115B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private __BinaryWriter serWriter;

		// Token: 0x04000E67 RID: 3687
		[global::Cpp2ILInjected.Token(Token = "0x400115C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private SerializationObjectManager m_objectManager;

		// Token: 0x04000E68 RID: 3688
		[global::Cpp2ILInjected.Token(Token = "0x400115D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private long topId;

		// Token: 0x04000E69 RID: 3689
		[global::Cpp2ILInjected.Token(Token = "0x400115E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string topName;

		// Token: 0x04000E6A RID: 3690
		[global::Cpp2ILInjected.Token(Token = "0x400115F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.Runtime.Remoting.Messaging.Header[] headers;

		// Token: 0x04000E6B RID: 3691
		[global::Cpp2ILInjected.Token(Token = "0x4001160")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private InternalFE formatterEnums;

		// Token: 0x04000E6C RID: 3692
		[global::Cpp2ILInjected.Token(Token = "0x4001161")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private SerializationBinder m_binder;

		// Token: 0x04000E6D RID: 3693
		[global::Cpp2ILInjected.Token(Token = "0x4001162")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private SerObjectInfoInit serObjectInfoInit;

		// Token: 0x04000E6E RID: 3694
		[global::Cpp2ILInjected.Token(Token = "0x4001163")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private IFormatterConverter m_formatterConverter;

		// Token: 0x04000E6F RID: 3695
		[global::Cpp2ILInjected.Token(Token = "0x4001164")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		internal object[] crossAppDomainArray;

		// Token: 0x04000E70 RID: 3696
		[global::Cpp2ILInjected.Token(Token = "0x4001165")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private object previousObj;

		// Token: 0x04000E71 RID: 3697
		[global::Cpp2ILInjected.Token(Token = "0x4001166")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private long previousId;

		// Token: 0x04000E72 RID: 3698
		[global::Cpp2ILInjected.Token(Token = "0x4001167")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private global::System.Type previousType;

		// Token: 0x04000E73 RID: 3699
		[global::Cpp2ILInjected.Token(Token = "0x4001168")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private InternalPrimitiveTypeE previousCode;

		// Token: 0x04000E74 RID: 3700
		[global::Cpp2ILInjected.Token(Token = "0x4001169")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private global::System.Collections.Hashtable assemblyToIdTable;

		// Token: 0x04000E75 RID: 3701
		[global::Cpp2ILInjected.Token(Token = "0x400116A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private SerStack niPool;
	}
}
