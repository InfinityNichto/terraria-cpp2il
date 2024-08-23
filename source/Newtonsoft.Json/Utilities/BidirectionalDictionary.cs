using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000048 RID: 72
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000056")]
	internal class BidirectionalDictionary<TFirst, TSecond>
	{
		// Token: 0x060002F9 RID: 761 RVA: 0x00002969 File Offset: 0x00000B69
		[global::Cpp2ILInjected.Token(Token = "0x6000313")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E5B28", Offset = "0x18E5B28", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public BidirectionalDictionary()
		{
			throw null;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000296C File Offset: 0x00000B6C
		[global::Cpp2ILInjected.Token(Token = "0x6000314")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E5B94", Offset = "0x18E5B94", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumUtils), Member = "InitializeEnumType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(BidirectionalDictionary<string, string>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer)
		{
			throw null;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000296F File Offset: 0x00000B6F
		[global::Cpp2ILInjected.Token(Token = "0x6000315")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E5C14", Offset = "0x18E5C14", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializerInternalBase), Member = "get_DefaultReferenceMappings", ReturnType = typeof(BidirectionalDictionary<string, object>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
		{
			throw null;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00002972 File Offset: 0x00000B72
		[global::Cpp2ILInjected.Token(Token = "0x6000316")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E5CD4", Offset = "0x18E5CD4", Length = "0x31C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumUtils), Member = "InitializeEnumType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(BidirectionalDictionary<string, string>))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringUtils), Member = "FormatWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public void Set(TFirst first, TSecond second)
		{
			throw null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002975 File Offset: 0x00000B75
		[global::Cpp2ILInjected.Token(Token = "0x6000317")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E5FF0", Offset = "0x18E5FF0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumUtils), Member = "ToEnumName", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultReferenceResolver), Member = "ResolveReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool TryGetByFirst(TFirst first, out TSecond second)
		{
			throw null;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00002978 File Offset: 0x00000B78
		[global::Cpp2ILInjected.Token(Token = "0x6000318")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6090", Offset = "0x18E6090", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumUtils), Member = "InitializeEnumType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(BidirectionalDictionary<string, string>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EnumUtils), Member = "ResolvedEnumName", MemberParameters = new object[]
		{
			typeof(BidirectionalDictionary<string, string>),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultReferenceResolver), Member = "GetReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultReferenceResolver), Member = "IsReferenced", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool TryGetBySecond(TSecond second, out TFirst first)
		{
			throw null;
		}

		// Token: 0x0400016D RID: 365
		[global::Cpp2ILInjected.Token(Token = "0x4000197")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TFirst, TSecond> _firstToSecond;

		// Token: 0x0400016E RID: 366
		[global::Cpp2ILInjected.Token(Token = "0x4000198")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly IDictionary<TSecond, TFirst> _secondToFirst;

		// Token: 0x0400016F RID: 367
		[global::Cpp2ILInjected.Token(Token = "0x4000199")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string _duplicateFirstErrorMessage;

		// Token: 0x04000170 RID: 368
		[global::Cpp2ILInjected.Token(Token = "0x400019A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string _duplicateSecondErrorMessage;
	}
}
