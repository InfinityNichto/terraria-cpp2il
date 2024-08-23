using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000047 RID: 71
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000055")]
	internal class ThreadSafeStore<TKey, TValue>
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x00002960 File Offset: 0x00000B60
		[Preserve]
		[global::Cpp2ILInjected.Token(Token = "0x6000310")]
		[global::Cpp2ILInjected.Address(RVA = "0x187E178", Offset = "0x187E178", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumUtils), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public ThreadSafeStore(Func<TKey, TValue> creator)
		{
			throw null;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002963 File Offset: 0x00000B63
		[Preserve]
		[global::Cpp2ILInjected.Token(Token = "0x6000311")]
		[global::Cpp2ILInjected.Address(RVA = "0x187E274", Offset = "0x187E274", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumUtils), Member = "ParseEnumName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumUtils), Member = "ToEnumName", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetJsonConverter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "CreateJsonConverterInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object[])
		}, ReturnType = typeof(JsonConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetAssociatedMetadataType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = "WriteJson", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyValuePairConverter), Member = "ReadJson", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(object),
			typeof(JsonSerializer)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		public TValue Get(TKey key)
		{
			throw null;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002966 File Offset: 0x00000B66
		[Preserve]
		[global::Cpp2ILInjected.Token(Token = "0x6000312")]
		[global::Cpp2ILInjected.Address(RVA = "0x187E2E4", Offset = "0x187E2E4", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private TValue AddValue(TKey key)
		{
			throw null;
		}

		// Token: 0x0400016A RID: 362
		[global::Cpp2ILInjected.Token(Token = "0x4000194")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly object _lock;

		// Token: 0x0400016B RID: 363
		[global::Cpp2ILInjected.Token(Token = "0x4000195")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, TValue> _store;

		// Token: 0x0400016C RID: 364
		[global::Cpp2ILInjected.Token(Token = "0x4000196")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Func<TKey, TValue> _creator;
	}
}
