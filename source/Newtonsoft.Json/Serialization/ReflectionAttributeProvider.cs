﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200007E")]
	public class ReflectionAttributeProvider : IAttributeProvider
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000466")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE01BC", Offset = "0x1CE01BC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreatePropertyFromConstructorParameter", MemberParameters = new object[]
		{
			typeof(JsonProperty),
			typeof(ParameterInfo)
		}, ReturnType = typeof(JsonProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreateProperty", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberSerialization)
		}, ReturnType = typeof(JsonProperty))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ReflectionAttributeProvider(object attributeProvider)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000467")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0224", Offset = "0x1CE0224", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IList<Attribute> GetAttributes(bool inherit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000468")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE0290", Offset = "0x1CE0290", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IList<Attribute> GetAttributes(Type attributeType, bool inherit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000213")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly object _attributeProvider;
	}
}
