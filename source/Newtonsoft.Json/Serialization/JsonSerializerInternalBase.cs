using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000082 RID: 130
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000A6")]
	internal abstract class JsonSerializerInternalBase
	{
		// Token: 0x06000599 RID: 1433 RVA: 0x000030E6 File Offset: 0x000012E6
		[global::Cpp2ILInjected.Token(Token = "0x60005FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEF85C", Offset = "0x1CEF85C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = ".ctor", MemberParameters = new object[] { typeof(JsonSerializer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = ".ctor", MemberParameters = new object[] { typeof(JsonSerializer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected JsonSerializerInternalBase(JsonSerializer serializer)
		{
			throw null;
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x000030E9 File Offset: 0x000012E9
		[global::Cpp2ILInjected.Token(Token = "0x1700012B")]
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000600")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CE38CC", Offset = "0x1CE38CC", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BidirectionalDictionary<, >), Member = ".ctor", MemberParameters = new object[]
			{
				"System.Collections.Generic.IEqualityComparer`1<TFirst>",
				"System.Collections.Generic.IEqualityComparer`1<TSecond>",
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000030EC File Offset: 0x000012EC
		[global::Cpp2ILInjected.Token(Token = "0x6000601")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEF8E4", Offset = "0x1CEF8E4", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalBase), Member = "IsErrorHandled", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonContract),
			typeof(object),
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error)
		{
			throw null;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000030EF File Offset: 0x000012EF
		[global::Cpp2ILInjected.Token(Token = "0x6000602")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEF9C4", Offset = "0x1CEF9C4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ThrowUnexpectedEndException", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "HandleError", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "HandleError", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected void ClearErrorContext()
		{
			throw null;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x000030F2 File Offset: 0x000012F2
		[global::Cpp2ILInjected.Token(Token = "0x6000603")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CEFA24", Offset = "0x1CEFA24", Length = "0x384")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateDictionary", MemberParameters = new object[]
		{
			typeof(IDictionary),
			typeof(JsonReader),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "ThrowUnexpectedEndException", MemberParameters = new object[]
		{
			typeof(JsonReader),
			typeof(JsonContract),
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateList", MemberParameters = new object[]
		{
			typeof(IList),
			typeof(JsonReader),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "PopulateObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalReader), Member = "EndProcessProperty", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonReader),
			typeof(JsonObjectContract),
			typeof(int),
			typeof(JsonProperty),
			typeof(JsonSerializerInternalReader.PropertyPresence),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(object),
			typeof(JsonObjectContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeList", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IEnumerable),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(Array),
			typeof(JsonArrayContract),
			typeof(JsonProperty),
			typeof(int),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalWriter), Member = "SerializeDictionary", MemberParameters = new object[]
		{
			typeof(JsonWriter),
			typeof(IDictionary),
			typeof(JsonDictionaryContract),
			typeof(JsonProperty),
			typeof(JsonContainerContract),
			typeof(JsonProperty)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerInternalBase), Member = "GetErrorContext", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(ErrorContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonPosition), Member = "FormatMessage", MemberParameters = new object[]
		{
			typeof(IJsonLineInfo),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonContract), Member = "InvokeOnError", MemberParameters = new object[]
		{
			typeof(object),
			typeof(StreamingContext),
			typeof(ErrorContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ErrorEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ErrorContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializer), Member = "OnError", MemberParameters = new object[] { typeof(ErrorEventArgs) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex)
		{
			throw null;
		}

		// Token: 0x0400025D RID: 605
		[global::Cpp2ILInjected.Token(Token = "0x40002BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ErrorContext _currentErrorContext;

		// Token: 0x0400025E RID: 606
		[global::Cpp2ILInjected.Token(Token = "0x40002BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private BidirectionalDictionary<string, object> _mappings;

		// Token: 0x0400025F RID: 607
		[global::Cpp2ILInjected.Token(Token = "0x40002BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal readonly JsonSerializer Serializer;

		// Token: 0x04000260 RID: 608
		[global::Cpp2ILInjected.Token(Token = "0x40002BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal readonly ITraceWriter TraceWriter;

		// Token: 0x04000261 RID: 609
		[global::Cpp2ILInjected.Token(Token = "0x40002C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected JsonSerializerProxy InternalSerializer;

		// Token: 0x02000115 RID: 277
		[global::Cpp2ILInjected.Token(Token = "0x20000A7")]
		private class ReferenceEqualsEqualityComparer : IEqualityComparer<object>
		{
			// Token: 0x06000AE5 RID: 2789 RVA: 0x0000402B File Offset: 0x0000222B
			[global::Cpp2ILInjected.Token(Token = "0x6000604")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEFDA8", Offset = "0x1CEFDA8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y)
			{
				throw null;
			}

			// Token: 0x06000AE6 RID: 2790 RVA: 0x0000402E File Offset: 0x0000222E
			[global::Cpp2ILInjected.Token(Token = "0x6000605")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEFDB4", Offset = "0x1CEFDB4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "GetHashCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
			private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj)
			{
				throw null;
			}

			// Token: 0x06000AE7 RID: 2791 RVA: 0x00004031 File Offset: 0x00002231
			[global::Cpp2ILInjected.Token(Token = "0x6000606")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CEF8DC", Offset = "0x1CEF8DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ReferenceEqualsEqualityComparer()
			{
				throw null;
			}
		}
	}
}
