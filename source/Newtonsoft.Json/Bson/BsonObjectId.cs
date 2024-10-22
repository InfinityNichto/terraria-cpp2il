﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200012D")]
	public class BsonObjectId
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000240")]
		public byte[] Value
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000BB4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3BB44", Offset = "0x1D3BB44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000BB5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D3BB4C", Offset = "0x1D3BB4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000BB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D3BB54", Offset = "0x1D3BB54", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BsonObjectIdConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public BsonObjectId(byte[] value)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000472")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private byte[] <Value>k__BackingField;
	}
}
