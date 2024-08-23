using System;
using System.Reflection;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000088 RID: 136
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000B3")]
	internal static class CachedAttributeGetter<T> where T : Attribute
	{
		// Token: 0x06000643 RID: 1603 RVA: 0x000032E4 File Offset: 0x000014E4
		[global::Cpp2ILInjected.Token(Token = "0x60006BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EB5E8", Offset = "0x18EB5E8", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetDataContractAttribute", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(DataContractAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTypeReflector), Member = "GetDataMemberAttribute", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(DataMemberAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static T GetAttribute(object type)
		{
			throw null;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000032E7 File Offset: 0x000014E7
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60006BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EB6C8", Offset = "0x18EB6C8", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		static CachedAttributeGetter()
		{
			throw null;
		}

		// Token: 0x04000274 RID: 628
		[global::Cpp2ILInjected.Token(Token = "0x40002E7")]
		private static readonly ThreadSafeStore<object, T> TypeAttributeCache;
	}
}
