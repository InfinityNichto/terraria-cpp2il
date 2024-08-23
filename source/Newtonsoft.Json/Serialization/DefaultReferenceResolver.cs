using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200006D RID: 109
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000086")]
	internal class DefaultReferenceResolver : IReferenceResolver
	{
		// Token: 0x06000484 RID: 1156 RVA: 0x00002DEC File Offset: 0x00000FEC
		[global::Cpp2ILInjected.Token(Token = "0x60004C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE37C8", Offset = "0x1CE37C8", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultReferenceResolver), Member = "ResolveReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultReferenceResolver), Member = "GetReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultReferenceResolver), Member = "AddReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultReferenceResolver), Member = "IsReferenced", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonSerializerProxy), Member = "GetInternalSerializer", ReturnType = typeof(JsonSerializerInternalBase))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private BidirectionalDictionary<string, object> GetMappings(object context)
		{
			throw null;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002DEF File Offset: 0x00000FEF
		[global::Cpp2ILInjected.Token(Token = "0x60004C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE39E0", Offset = "0x1CE39E0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultReferenceResolver), Member = "GetMappings", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(BidirectionalDictionary<string, object>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BidirectionalDictionary<, >), Member = "TryGetByFirst", MemberParameters = new object[] { "TFirst", "TSecond&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object ResolveReference(object context, string reference)
		{
			throw null;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002DF2 File Offset: 0x00000FF2
		[global::Cpp2ILInjected.Token(Token = "0x60004C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3A4C", Offset = "0x1CE3A4C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultReferenceResolver), Member = "GetMappings", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(BidirectionalDictionary<string, object>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BidirectionalDictionary<, >), Member = "TryGetBySecond", MemberParameters = new object[] { "TSecond", "TFirst&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BidirectionalDictionary<, >), Member = "Set", MemberParameters = new object[] { "TFirst", "TSecond" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public string GetReference(object context, object value)
		{
			throw null;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002DF5 File Offset: 0x00000FF5
		[global::Cpp2ILInjected.Token(Token = "0x60004CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3B40", Offset = "0x1CE3B40", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultReferenceResolver), Member = "GetMappings", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(BidirectionalDictionary<string, object>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BidirectionalDictionary<, >), Member = "Set", MemberParameters = new object[] { "TFirst", "TSecond" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddReference(object context, string reference, object value)
		{
			throw null;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00002DF8 File Offset: 0x00000FF8
		[global::Cpp2ILInjected.Token(Token = "0x60004CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3BA4", Offset = "0x1CE3BA4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DefaultReferenceResolver), Member = "GetMappings", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(BidirectionalDictionary<string, object>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BidirectionalDictionary<, >), Member = "TryGetBySecond", MemberParameters = new object[] { "TSecond", "TFirst&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool IsReferenced(object context, object value)
		{
			throw null;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00002DFB File Offset: 0x00000FFB
		[global::Cpp2ILInjected.Token(Token = "0x60004CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CE3C10", Offset = "0x1CE3C10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "GetReferenceResolver", ReturnType = typeof(IReferenceResolver))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultReferenceResolver()
		{
			throw null;
		}

		// Token: 0x040001DD RID: 477
		[global::Cpp2ILInjected.Token(Token = "0x4000222")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _referenceCount;
	}
}
