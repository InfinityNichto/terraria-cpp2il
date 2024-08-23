using System;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000371 RID: 881
	[global::Cpp2ILInjected.Token(Token = "0x2000419")]
	internal sealed class WriteObjectInfo
	{
		// Token: 0x06001E40 RID: 7744 RVA: 0x000199C7 File Offset: 0x00017BC7
		[global::Cpp2ILInjected.Token(Token = "0x600207E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B62324", Offset = "0x1B62324", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal WriteObjectInfo()
		{
			throw null;
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x000199CA File Offset: 0x00017BCA
		[global::Cpp2ILInjected.Token(Token = "0x600207F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6232C", Offset = "0x1B6232C", Length = "0x14")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		internal void ObjectEnd()
		{
			throw null;
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x000199CD File Offset: 0x00017BCD
		[global::Cpp2ILInjected.Token(Token = "0x6002080")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6234C", Offset = "0x1B6234C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void InternalInit()
		{
			throw null;
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x000199D0 File Offset: 0x00017BD0
		[global::Cpp2ILInjected.Token(Token = "0x6002081")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6236C", Offset = "0x1B6236C", Length = "0x88")]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "WriteArrayMember", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "GetObjectInfo", MemberParameters = new object[] { typeof(SerObjectInfoInit) }, ReturnType = typeof(WriteObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(ObjectWriter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
		{
			throw null;
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x000199D3 File Offset: 0x00017BD3
		[global::Cpp2ILInjected.Token(Token = "0x6002082")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B624B8", Offset = "0x1B624B8", Length = "0x460")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(ObjectWriter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(WriteObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "InitNoMembers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationObjectManager), Member = "RegisterObject", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(IFormatterConverter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "UnsafeTypeForwardersIsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "InitMemberInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "InitSiWrite", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "CheckTypeForwardedFrom", MemberParameters = new object[]
		{
			typeof(SerObjectInfoCache),
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder)
		{
			throw null;
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x000199D6 File Offset: 0x00017BD6
		[global::Cpp2ILInjected.Token(Token = "0x6002083")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6302C", Offset = "0x1B6302C", Length = "0x80")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "GetObjectInfo", MemberParameters = new object[] { typeof(SerObjectInfoInit) }, ReturnType = typeof(WriteObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		internal static WriteObjectInfo Serialize(global::System.Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
		{
			throw null;
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x000199D9 File Offset: 0x00017BD9
		[global::Cpp2ILInjected.Token(Token = "0x6002084")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B630AC", Offset = "0x1B630AC", Length = "0x2C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(WriteObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "InitNoMembers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(IFormatterConverter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerObjectInfoCache), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "InitMemberInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "CheckTypeForwardedFrom", MemberParameters = new object[]
		{
			typeof(SerObjectInfoCache),
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "UnsafeTypeForwardersIsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal void InitSerialize(global::System.Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder)
		{
			throw null;
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x000199DC File Offset: 0x00017BDC
		[global::Cpp2ILInjected.Token(Token = "0x6002085")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B62A10", Offset = "0x1B62A10", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(ObjectWriter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "GetEnumerator", ReturnType = typeof(SerializationInfoEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryFormatter), Member = "GetTypeInformation", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(TypeInformation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerObjectInfoCache), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_ObjectType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfoEnumerator), Member = "get_Value", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void InitSiWrite()
		{
			throw null;
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x000199DF File Offset: 0x00017BDF
		[global::Cpp2ILInjected.Token(Token = "0x6002086")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B62CAC", Offset = "0x1B62CAC", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(ObjectWriter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "UnsafeTypeForwardersIsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "IsAssemblyNameAssignmentSafe", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "get_IsFullyTrusted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Security.SecurityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, global::System.Type objectType, string binderAssemblyString)
		{
			throw null;
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x000199E2 File Offset: 0x00017BE2
		[global::Cpp2ILInjected.Token(Token = "0x6002087")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B62918", Offset = "0x1B62918", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(ObjectWriter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerObjectInfoCache), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void InitNoMembers()
		{
			throw null;
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x000199E5 File Offset: 0x00017BE5
		[global::Cpp2ILInjected.Token(Token = "0x6002088")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B62DD8", Offset = "0x1B62DD8", Length = "0x254")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(ObjectWriter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "InitSerialize", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerObjectInfoCache), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetSerializableMembers", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(StreamingContext)
		}, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WriteObjectInfo), Member = "GetMemberType", MemberParameters = new object[] { typeof(global::System.Reflection.MemberInfo) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.MemberInfo[])
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void InitMemberInfo()
		{
			throw null;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x000199E8 File Offset: 0x00017BE8
		[global::Cpp2ILInjected.Token(Token = "0x6002089")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5B980", Offset = "0x1B5B980", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "TypeToNameInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(WriteObjectInfo),
			typeof(InternalPrimitiveTypeE),
			typeof(NameInfo)
		}, ReturnType = typeof(NameInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal string GetTypeFullName()
		{
			throw null;
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x000199EB File Offset: 0x00017BEB
		[global::Cpp2ILInjected.Token(Token = "0x600208A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5B964", Offset = "0x1B5B964", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "GetAssemblyId", MemberParameters = new object[] { typeof(WriteObjectInfo) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal string GetAssemblyString()
		{
			throw null;
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x000199EE File Offset: 0x00017BEE
		[global::Cpp2ILInjected.Token(Token = "0x600208B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B629E8", Offset = "0x1B629E8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void InvokeSerializationBinder(SerializationBinder binder)
		{
			throw null;
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x000199F1 File Offset: 0x00017BF1
		[global::Cpp2ILInjected.Token(Token = "0x600208C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6336C", Offset = "0x1B6336C", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "InitMemberInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal global::System.Type GetMemberType(global::System.Reflection.MemberInfo objMember)
		{
			throw null;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x000199F4 File Offset: 0x00017BF4
		[global::Cpp2ILInjected.Token(Token = "0x600208D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B634B4", Offset = "0x1B634B4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(WriteObjectInfo),
			typeof(NameInfo),
			typeof(NameInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void GetMemberInfo(out string[] outMemberNames, out global::System.Type[] outMemberTypes, out object[] outMemberData)
		{
			throw null;
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x000199F7 File Offset: 0x00017BF7
		[global::Cpp2ILInjected.Token(Token = "0x600208E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B623F4", Offset = "0x1B623F4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(ObjectWriter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(WriteObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WriteObjectInfo), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(SerializationBinder)
		}, ReturnType = typeof(WriteObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "IsEmpty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Pop", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
		{
			throw null;
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x000199FA File Offset: 0x00017BFA
		[global::Cpp2ILInjected.Token(Token = "0x600208F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B62340", Offset = "0x1B62340", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo)
		{
			throw null;
		}

		// Token: 0x04000E1A RID: 3610
		[global::Cpp2ILInjected.Token(Token = "0x400110C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int objectInfoId;

		// Token: 0x04000E1B RID: 3611
		[global::Cpp2ILInjected.Token(Token = "0x400110D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal object obj;

		// Token: 0x04000E1C RID: 3612
		[global::Cpp2ILInjected.Token(Token = "0x400110E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal global::System.Type objectType;

		// Token: 0x04000E1D RID: 3613
		[global::Cpp2ILInjected.Token(Token = "0x400110F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal bool isSi;

		// Token: 0x04000E1E RID: 3614
		[global::Cpp2ILInjected.Token(Token = "0x4001110")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		internal bool isNamed;

		// Token: 0x04000E1F RID: 3615
		[global::Cpp2ILInjected.Token(Token = "0x4001111")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A")]
		internal bool isTyped;

		// Token: 0x04000E20 RID: 3616
		[global::Cpp2ILInjected.Token(Token = "0x4001112")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B")]
		internal bool isArray;

		// Token: 0x04000E21 RID: 3617
		[global::Cpp2ILInjected.Token(Token = "0x4001113")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal SerializationInfo si;

		// Token: 0x04000E22 RID: 3618
		[global::Cpp2ILInjected.Token(Token = "0x4001114")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal SerObjectInfoCache cache;

		// Token: 0x04000E23 RID: 3619
		[global::Cpp2ILInjected.Token(Token = "0x4001115")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal object[] memberData;

		// Token: 0x04000E24 RID: 3620
		[global::Cpp2ILInjected.Token(Token = "0x4001116")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal ISerializationSurrogate serializationSurrogate;

		// Token: 0x04000E25 RID: 3621
		[global::Cpp2ILInjected.Token(Token = "0x4001117")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal StreamingContext context;

		// Token: 0x04000E26 RID: 3622
		[global::Cpp2ILInjected.Token(Token = "0x4001118")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal SerObjectInfoInit serObjectInfoInit;

		// Token: 0x04000E27 RID: 3623
		[global::Cpp2ILInjected.Token(Token = "0x4001119")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal long objectId;

		// Token: 0x04000E28 RID: 3624
		[global::Cpp2ILInjected.Token(Token = "0x400111A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal long assemId;

		// Token: 0x04000E29 RID: 3625
		[global::Cpp2ILInjected.Token(Token = "0x400111B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private string binderTypeName;

		// Token: 0x04000E2A RID: 3626
		[global::Cpp2ILInjected.Token(Token = "0x400111C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private string binderAssemblyString;
	}
}
