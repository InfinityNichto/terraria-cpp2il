using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000084")]
	public class JsonPrimitiveContract : JsonContract
	{
		[global::Cpp2ILInjected.Token(Token = "0x170000CB")]
		internal PrimitiveTypeCode TypeCode
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3320", Offset = "0x1CE3320", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60004BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE3328", Offset = "0x1CE3328", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3330", Offset = "0x1CE3330", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultContractResolver), Member = "CreatePrimitiveContract", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(JsonPrimitiveContract))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonStringContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConvertUtils), Member = "GetTypeCode", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PrimitiveTypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, Int32Enum>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref Int32Enum)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public JsonPrimitiveContract(Type underlyingType)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60004C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE341C", Offset = "0x1CE341C", Length = "0x31C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, Int32Enum>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, Int32Enum>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			"System.Int32Enum"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		static JsonPrimitiveContract()
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400021E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private PrimitiveTypeCode <TypeCode>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x400021F")]
		private static readonly Dictionary<Type, ReadType> ReadTypeMap;
	}
}
