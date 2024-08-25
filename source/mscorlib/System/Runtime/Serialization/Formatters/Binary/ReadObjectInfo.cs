using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x200041A")]
	internal sealed class ReadObjectInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002090")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B63544", Offset = "0x1B63544", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal ReadObjectInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002091")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6354C", Offset = "0x1B6354C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseObjectEnd", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void ObjectEnd()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002092")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5ECA4", Offset = "0x1B5ECA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void PrepareForReuse()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002093")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B63550", Offset = "0x1B63550", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "CreateReadObjectInfo", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(ReadObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseObject", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "GetObjectInfo", MemberParameters = new object[] { typeof(SerObjectInfoInit) }, ReturnType = typeof(ReadObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "InitReadConstructor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		internal static ReadObjectInfo Create(global::System.Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002094")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B63638", Offset = "0x1B63638", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Init(global::System.Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002095")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B637E4", Offset = "0x1B637E4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "CreateReadObjectInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string[]),
			typeof(global::System.Type[])
		}, ReturnType = typeof(ReadObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "GetObjectInfo", MemberParameters = new object[] { typeof(SerObjectInfoInit) }, ReturnType = typeof(ReadObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "Init", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string[]),
			typeof(global::System.Type[]),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(ObjectManager),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		internal static ReadObjectInfo Create(global::System.Type objectType, string[] memberNames, global::System.Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002096")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B63880", Offset = "0x1B63880", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "Create", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string[]),
			typeof(global::System.Type[]),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(ObjectManager),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(bool)
		}, ReturnType = typeof(ReadObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "InitReadConstructor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		internal void Init(global::System.Type objectType, string[] memberNames, global::System.Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002097")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B63654", Offset = "0x1B63654", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "Create", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(ObjectManager),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(bool)
		}, ReturnType = typeof(ReadObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "Init", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string[]),
			typeof(global::System.Type[]),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(ObjectManager),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "InitNoMembers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "InitSiRead", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "InitMemberInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void InitReadConstructor(global::System.Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002098")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B63930", Offset = "0x1B63930", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "InitReadConstructor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void InitSiRead()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002099")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B638D0", Offset = "0x1B638D0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "InitReadConstructor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerObjectInfoCache), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void InitNoMembers()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600209A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B639A8", Offset = "0x1B639A8", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "InitReadConstructor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerObjectInfoCache), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetSerializableMembers", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(StreamingContext)
		}, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "GetMemberType", MemberParameters = new object[] { typeof(global::System.Reflection.MemberInfo) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void InitMemberInfo()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600209B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B63C9C", Offset = "0x1B63C9C", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ParseRecord),
			typeof(ParseRecord),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueFixup), Member = "Fixup", MemberParameters = new object[]
		{
			typeof(ParseRecord),
			typeof(ParseRecord)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "Position", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal global::System.Reflection.MemberInfo GetMemberInfo(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600209C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B63F04", Offset = "0x1B63F04", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "Position", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal global::System.Type GetType(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600209D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B64074", Offset = "0x1B64074", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "Position", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600209E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5EBE0", Offset = "0x1B5EBE0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectMap), Member = "CreateObjectInfo", MemberParameters = new object[]
		{
			typeof(ref SerializationInfo),
			typeof(ref object[])
		}, ReturnType = typeof(ReadObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(IFormatterConverter),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void InitDataStore(ref SerializationInfo si, ref object[] memberData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600209F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B640EC", Offset = "0x1B640EC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "Position", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void RecordFixup(long objectId, string name, long idRef)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6416C", Offset = "0x1B6416C", Length = "0x1090")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseObjectEnd", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "PopulateObjectMembers", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.MemberInfo[]),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void PopulateObjectMembers(object obj, object[] memberData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B63E1C", Offset = "0x1B63E1C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "GetMemberInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.MemberInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "GetType", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(ref SerializationInfo),
			typeof(ref object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "RecordFixup", MemberParameters = new object[]
		{
			typeof(long),
			typeof(string),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		private int Position(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E588", Offset = "0x1B5E588", Length = "0x3C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectMap), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type),
			typeof(string[]),
			typeof(ObjectReader),
			typeof(int),
			typeof(BinaryAssemblyInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectMap), Member = ".ctor", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "GetMemberType", MemberParameters = new object[] { typeof(global::System.Reflection.MemberInfo) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		internal global::System.Type[] GetMemberTypes(string[] inMemberNames, global::System.Type objectType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B63B54", Offset = "0x1B63B54", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "InitMemberInfo", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "GetMemberTypes", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(global::System.Type)
		}, ReturnType = typeof(global::System.Type[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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

		[global::Cpp2ILInjected.Token(Token = "0x60020A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B635D0", Offset = "0x1B635D0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "Create", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(ObjectManager),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(bool)
		}, ReturnType = typeof(ReadObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReadObjectInfo), Member = "Create", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string[]),
			typeof(global::System.Type[]),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(ObjectManager),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(bool)
		}, ReturnType = typeof(ReadObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Increment", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400111D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int objectInfoId;

		[global::Cpp2ILInjected.Token(Token = "0x400111E")]
		internal static int readObjectInfoCounter;

		[global::Cpp2ILInjected.Token(Token = "0x400111F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal global::System.Type objectType;

		[global::Cpp2ILInjected.Token(Token = "0x4001120")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal ObjectManager objectManager;

		[global::Cpp2ILInjected.Token(Token = "0x4001121")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int count;

		[global::Cpp2ILInjected.Token(Token = "0x4001122")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		internal bool isSi;

		[global::Cpp2ILInjected.Token(Token = "0x4001123")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D")]
		internal bool isNamed;

		[global::Cpp2ILInjected.Token(Token = "0x4001124")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E")]
		internal bool isTyped;

		[global::Cpp2ILInjected.Token(Token = "0x4001125")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F")]
		internal bool bSimpleAssembly;

		[global::Cpp2ILInjected.Token(Token = "0x4001126")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal SerObjectInfoCache cache;

		[global::Cpp2ILInjected.Token(Token = "0x4001127")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal string[] wireMemberNames;

		[global::Cpp2ILInjected.Token(Token = "0x4001128")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal global::System.Type[] wireMemberTypes;

		[global::Cpp2ILInjected.Token(Token = "0x4001129")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int lastPosition;

		[global::Cpp2ILInjected.Token(Token = "0x400112A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal ISerializationSurrogate serializationSurrogate;

		[global::Cpp2ILInjected.Token(Token = "0x400112B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal StreamingContext context;

		[global::Cpp2ILInjected.Token(Token = "0x400112C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal global::System.Collections.Generic.List<global::System.Type> memberTypesList;

		[global::Cpp2ILInjected.Token(Token = "0x400112D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal SerObjectInfoInit serObjectInfoInit;

		[global::Cpp2ILInjected.Token(Token = "0x400112E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal IFormatterConverter formatterConverter;
	}
}
