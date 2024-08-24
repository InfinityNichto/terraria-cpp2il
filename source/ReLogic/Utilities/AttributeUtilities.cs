using System;
using System.Linq;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace ReLogic.Utilities
{
	// Token: 0x0200070D RID: 1805
	[global::Cpp2ILInjected.Token(Token = "0x2000B00")]
	public static class AttributeUtilities
	{
		// Token: 0x060045D9 RID: 17881 RVA: 0x0002E7FF File Offset: 0x0002C9FF
		[global::Cpp2ILInjected.Token(Token = "0x6005270")]
		[global::Cpp2ILInjected.Address(RVA = "0x1575A40", Offset = "0x1575A40", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "SingleOrDefault", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static T GetAttribute<T>(this MethodBase method) where T : Attribute
		{
			throw null;
		}

		// Token: 0x060045DA RID: 17882 RVA: 0x0002E802 File Offset: 0x0002CA02
		[global::Cpp2ILInjected.Token(Token = "0x6005271")]
		[global::Cpp2ILInjected.Address(RVA = "0x1575980", Offset = "0x1575980", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "GetName", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetField", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static T GetAttribute<T>(this Enum value) where T : Attribute
		{
			throw null;
		}

		// Token: 0x060045DB RID: 17883 RVA: 0x0002E805 File Offset: 0x0002CA05
		[global::Cpp2ILInjected.Token(Token = "0x6005272")]
		[global::Cpp2ILInjected.Address(RVA = "0x1575B6C", Offset = "0x1575B6C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static A GetCacheableAttribute<T, A>() where A : Attribute
		{
			throw null;
		}

		// Token: 0x060045DC RID: 17884 RVA: 0x0002E808 File Offset: 0x0002CA08
		[global::Cpp2ILInjected.Token(Token = "0x6005273")]
		[global::Cpp2ILInjected.Address(RVA = "0x1575B2C", Offset = "0x1575B2C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static T GetAttribute<T>(this Type type) where T : Attribute
		{
			throw null;
		}

		// Token: 0x02000ACF RID: 2767
		[global::Cpp2ILInjected.Token(Token = "0x2000B01")]
		private static class TypeAttributeCache<T, A> where A : Attribute
		{
			// Token: 0x060052C3 RID: 21187 RVA: 0x0003098F File Offset: 0x0002EB8F
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6005274")]
			[global::Cpp2ILInjected.Address(RVA = "0x1893D24", Offset = "0x1893D24", Length = "0x130")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			static TypeAttributeCache()
			{
				throw null;
			}

			// Token: 0x04008F85 RID: 36741
			[global::Cpp2ILInjected.Token(Token = "0x4008AC1")]
			public static readonly A Value;
		}
	}
}
