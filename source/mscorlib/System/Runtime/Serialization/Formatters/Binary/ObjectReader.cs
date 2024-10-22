﻿using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x200041E")]
	internal sealed class ObjectReader
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700044A")]
		private SerStack ValueFixupStack
		{
			[global::Cpp2ILInjected.Token(Token = "0x60020AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B65434", Offset = "0x1B65434", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseObjectEnd", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700044B")]
		internal object TopObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x60020AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B654AC", Offset = "0x1B654AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60020AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B654B4", Offset = "0x1B654B4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B654C8", Offset = "0x1B654C8", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Runtime.Remoting.Messaging.HeaderHandler),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal ObjectReader(global::System.IO.Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B655D8", Offset = "0x1B655D8", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryFormatter), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Runtime.Remoting.Messaging.HeaderHandler),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "HasSurrogate", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal object Deserialize(global::System.Runtime.Remoting.Messaging.HeaderHandler handler, __BinaryParser serParser, bool fCheck)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B65DD8", Offset = "0x1B65DD8", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Remoting.Messaging.HeaderHandler),
			typeof(__BinaryParser),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "CheckSerializable", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool HasSurrogate(global::System.Type t)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B65EAC", Offset = "0x1B65EAC", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseObject", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "HasSurrogate", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void CheckSerializable(global::System.Type t)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B65FB8", Offset = "0x1B65FB8", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseObject", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "GetId", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void InitFullDeserialization()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B660B0", Offset = "0x1B660B0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal object CrossAppDomainArray(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B660C0", Offset = "0x1B660C0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectMap), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type),
			typeof(string[]),
			typeof(ObjectReader),
			typeof(int),
			typeof(BinaryAssemblyInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "Create", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(ObjectManager),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(bool)
		}, ReturnType = typeof(ReadObjectInfo))]
		internal ReadObjectInfo CreateReadObjectInfo(global::System.Type objectType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B660F4", Offset = "0x1B660F4", Length = "0x44")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "Create", MemberParameters = new object[]
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
		internal ReadObjectInfo CreateReadObjectInfo(global::System.Type objectType, string[] memberNames, global::System.Type[] memberTypes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B66138", Offset = "0x1B66138", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "Run", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryObjectWithMap) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryObjectWithMapTyped) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectString", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectNull", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "ParseObject", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "ParseObjectEnd", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "ParseMemberEnd", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal void Parse(ParseRecord pr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B66D38", Offset = "0x1B66D38", Length = "0x250")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseMemberEnd", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private void ParseError(ParseRecord processing, ParseRecord onStack)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B66258", Offset = "0x1B66258", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		private void ParseSerializedStreamHeader(ParseRecord pr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B66260", Offset = "0x1B66260", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void ParseSerializedStreamHeaderEnd(ParseRecord pr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B66284", Offset = "0x1B66284", Length = "0x2F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "InitFullDeserialization", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "ParseArray", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "CheckSerializable", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetUninitializedObject", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "RaiseOnDeserializingEvent", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "Create", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(ISurrogateSelector),
			typeof(StreamingContext),
			typeof(ObjectManager),
			typeof(SerObjectInfoInit),
			typeof(IFormatterConverter),
			typeof(bool)
		}, ReturnType = typeof(ReadObjectInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeLoadExceptionHolder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ParseRecord),
			typeof(ParseRecord),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void ParseObject(ParseRecord pr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6657C", Offset = "0x1B6657C", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMemberEnd", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseMemberEnd", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ParseRecord),
			typeof(ParseRecord),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "PopulateObjectMembers", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "get_ValueFixupStack", ReturnType = typeof(SerStack))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueFixup), Member = "Fixup", MemberParameters = new object[]
		{
			typeof(ParseRecord),
			typeof(ParseRecord)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "ObjectEnd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void ParseObjectEnd(ParseRecord pr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B67038", Offset = "0x1B67038", Length = "0x624")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseObject", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "IsWriteAsByteArray", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "UnsafeCreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int[]),
			typeof(int[])
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ParseRecord),
			typeof(ParseRecord),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "UnsafeCreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int[])
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PrimitiveArray), Member = "Init", MemberParameters = new object[]
		{
			typeof(InternalPrimitiveTypeE),
			typeof(global::System.Array)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		private void ParseArray(ParseRecord pr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B67978", Offset = "0x1B67978", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void NextRectangleMap(ParseRecord pr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B679F8", Offset = "0x1B679F8", Length = "0x6D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "NextRectangleMap", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "ParseObject", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ParseRecord),
			typeof(ParseRecord),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PrimitiveArray), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "get_ValueFixupStack", ReturnType = typeof(SerStack))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "CheckSerializable", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetUninitializedObject", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(InternalPrimitiveTypeE)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "ParseError", MemberParameters = new object[]
		{
			typeof(ParseRecord),
			typeof(ParseRecord)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private void ParseArrayMember(ParseRecord pr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B68454", Offset = "0x1B68454", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "ParseObjectEnd", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		private void ParseArrayMemberEnd(ParseRecord pr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B667E8", Offset = "0x1B667E8", Length = "0x4A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "FromString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(InternalPrimitiveTypeE)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "GetType", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Converter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(ref SerializationInfo),
			typeof(ref object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "RecordFixup", MemberParameters = new object[]
		{
			typeof(long),
			typeof(string),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "ParseObject", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerStack), Member = "Push", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "get_ValueFixupStack", ReturnType = typeof(SerStack))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ParseRecord),
			typeof(ParseRecord),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "ParseError", MemberParameters = new object[]
		{
			typeof(ParseRecord),
			typeof(ParseRecord)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		private void ParseMember(ParseRecord pr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B66C8C", Offset = "0x1B66C8C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "Parse", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "ParseObjectEnd", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "ParseError", MemberParameters = new object[]
		{
			typeof(ParseRecord),
			typeof(ParseRecord)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ParseMemberEnd(ParseRecord pr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B68104", Offset = "0x1B68104", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ParseRecord),
			typeof(ParseRecord),
			typeof(bool)
		}, ReturnType = typeof(void))]
		private void ParseString(ParseRecord pr, ParseRecord parentPr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6767C", Offset = "0x1B6767C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ParseRecord),
			typeof(ParseRecord),
			typeof(bool)
		}, ReturnType = typeof(void))]
		private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B684AC", Offset = "0x1B684AC", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseObject", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseObjectEnd", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseArray", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseArrayMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseMember", MemberParameters = new object[] { typeof(ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "ParseString", MemberParameters = new object[]
		{
			typeof(ParseRecord),
			typeof(ParseRecord)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ParseRecord),
			typeof(ParseRecord)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadObjectInfo), Member = "GetMemberInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.MemberInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "RegisterString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long),
			typeof(SerializationInfo),
			typeof(long),
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(long),
			typeof(SerializationInfo),
			typeof(long),
			typeof(global::System.Reflection.MemberInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B685C4", Offset = "0x1B685C4", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadSerializationHeaderRecord", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObject", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryObjectWithMap) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMapTyped", MemberParameters = new object[] { typeof(BinaryObjectWithMapTyped) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectString", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadArray", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "InitFullDeserialization", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntSizedArray), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntSizedArray), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal long GetId(long objectId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B68810", Offset = "0x1B68810", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "GetType", MemberParameters = new object[]
		{
			typeof(BinaryAssemblyInfo),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal global::System.Type Bind(string assemblyString, string typeString)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B68868", Offset = "0x1B68868", Length = "0x2D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameCache), Member = "GetCachedValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.AssemblyName), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "ResolveSimpleAssemblyName", MemberParameters = new object[] { typeof(global::System.Reflection.AssemblyName) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "GetSimplyNamedTypeFromAssembly", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(string),
			typeof(ref global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "CheckTypeForwardedTo", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameCache), Member = "SetCachedValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetTypeFromAssembly", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		internal global::System.Type FastBindToType(string assemblyName, string typeName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B68BDC", Offset = "0x1B68BDC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "FastBindToType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeAssembly), Member = "LoadWithPartialNameInternal", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.AssemblyName),
			typeof(global::System.Security.Policy.Evidence),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Reflection.RuntimeAssembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeAssembly), Member = "LoadWithPartialNameInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Security.Policy.Evidence),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Reflection.RuntimeAssembly))]
		[MethodImpl(8)]
		private static global::System.Reflection.Assembly ResolveSimpleAssemblyName(global::System.Reflection.AssemblyName assemblyName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B68C3C", Offset = "0x1B68C3C", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "FastBindToType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "GetType", MemberParameters = new object[]
		{
			typeof(BinaryAssemblyInfo),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetTypeFromAssembly", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Func<, , , >), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Func<global::System.Reflection.AssemblyName, global::System.Reflection.Assembly>),
			typeof(global::System.Func<global::System.Reflection.Assembly, string, bool, global::System.Type>),
			typeof(bool)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		private static void GetSimplyNamedTypeFromAssembly(global::System.Reflection.Assembly assm, string typeName, ref global::System.Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B6907C", Offset = "0x1B6907C", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryConverter), Member = "TypeFromInfo", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadObjectWithMap", MemberParameters = new object[] { typeof(BinaryObjectWithMap) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "Bind", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryAssemblyInfo), Member = "GetAssembly", ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "GetSimplyNamedTypeFromAssembly", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(string),
			typeof(ref global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetTypeFromAssembly", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectReader), Member = "CheckTypeForwardedTo", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal global::System.Type GetType(BinaryAssemblyInfo assemblyInfo, string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60020CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B68E88", Offset = "0x1B68E88", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "FastBindToType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectReader), Member = "GetType", MemberParameters = new object[]
		{
			typeof(BinaryAssemblyInfo),
			typeof(string)
		}, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "UnsafeTypeForwardersIsEnabled", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(global::System.Reflection.Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryFormatter), Member = "GetTypeInformation", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(TypeInformation))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private static void CheckTypeForwardedTo(global::System.Reflection.Assembly sourceAssembly, global::System.Reflection.Assembly destAssembly, global::System.Type resolvedType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400113B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.IO.Stream m_stream;

		[global::Cpp2ILInjected.Token(Token = "0x400113C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal ISurrogateSelector m_surrogates;

		[global::Cpp2ILInjected.Token(Token = "0x400113D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal StreamingContext m_context;

		[global::Cpp2ILInjected.Token(Token = "0x400113E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal ObjectManager m_objectManager;

		[global::Cpp2ILInjected.Token(Token = "0x400113F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal InternalFE formatterEnums;

		[global::Cpp2ILInjected.Token(Token = "0x4001140")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal SerializationBinder m_binder;

		[global::Cpp2ILInjected.Token(Token = "0x4001141")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal long topId;

		[global::Cpp2ILInjected.Token(Token = "0x4001142")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal bool bSimpleAssembly;

		[global::Cpp2ILInjected.Token(Token = "0x4001143")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal object handlerObject;

		[global::Cpp2ILInjected.Token(Token = "0x4001144")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal object m_topObject;

		[global::Cpp2ILInjected.Token(Token = "0x4001145")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal global::System.Runtime.Remoting.Messaging.Header[] headers;

		[global::Cpp2ILInjected.Token(Token = "0x4001146")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal global::System.Runtime.Remoting.Messaging.HeaderHandler handler;

		[global::Cpp2ILInjected.Token(Token = "0x4001147")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal SerObjectInfoInit serObjectInfoInit;

		[global::Cpp2ILInjected.Token(Token = "0x4001148")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		internal IFormatterConverter m_formatterConverter;

		[global::Cpp2ILInjected.Token(Token = "0x4001149")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		internal SerStack stack;

		[global::Cpp2ILInjected.Token(Token = "0x400114A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private SerStack valueFixupStack;

		[global::Cpp2ILInjected.Token(Token = "0x400114B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		internal object[] crossAppDomainArray;

		[global::Cpp2ILInjected.Token(Token = "0x400114C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private bool bFullDeserialization;

		[global::Cpp2ILInjected.Token(Token = "0x400114D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA1")]
		private bool bOldFormatDetected;

		[global::Cpp2ILInjected.Token(Token = "0x400114E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private IntSizedArray valTypeObjectIdTable;

		[global::Cpp2ILInjected.Token(Token = "0x400114F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private NameCache typeCache;

		[global::Cpp2ILInjected.Token(Token = "0x4001150")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private string previousAssemblyString;

		[global::Cpp2ILInjected.Token(Token = "0x4001151")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private string previousName;

		[global::Cpp2ILInjected.Token(Token = "0x4001152")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private global::System.Type previousType;

		[global::Cpp2ILInjected.Token(Token = "0x200041F")]
		internal class TypeNAssembly
		{
			[global::Cpp2ILInjected.Token(Token = "0x60020CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B68FC4", Offset = "0x1B68FC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public TypeNAssembly()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001153")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public global::System.Type type;

			[global::Cpp2ILInjected.Token(Token = "0x4001154")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public string assemblyName;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000420")]
		internal sealed class TopLevelAssemblyTypeResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x60020CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B69054", Offset = "0x1B69054", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public TopLevelAssemblyTypeResolver(global::System.Reflection.Assembly topLevelAssembly)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x60020CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B69218", Offset = "0x1B69218", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.Assembly),
				typeof(global::System.Reflection.Assembly)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public global::System.Type ResolveType(global::System.Reflection.Assembly assembly, string simpleTypeName, bool ignoreCase)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4001155")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private global::System.Reflection.Assembly m_topLevelAssembly;
		}
	}
}
