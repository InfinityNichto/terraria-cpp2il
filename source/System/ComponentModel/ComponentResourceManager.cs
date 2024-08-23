using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000267 RID: 615
	[global::Cpp2ILInjected.Token(Token = "0x200035B")]
	public class ComponentResourceManager : ResourceManager
	{
		// Token: 0x0600142B RID: 5163 RVA: 0x000067B2 File Offset: 0x000049B2
		[global::Cpp2ILInjected.Token(Token = "0x600166D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E409F4", Offset = "0x1E409F4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ComponentResourceManager()
		{
			throw null;
		}

		// Token: 0x0600142C RID: 5164 RVA: 0x000067B5 File Offset: 0x000049B5
		[global::Cpp2ILInjected.Token(Token = "0x600166E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E40A4C", Offset = "0x1E40A4C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceManager), Member = ".ctor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ComponentResourceManager(Type t)
		{
			throw null;
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x000067B8 File Offset: 0x000049B8
		[global::Cpp2ILInjected.Token(Token = "0x1700051F")]
		private CultureInfo NeutralResourcesCulture
		{
			[global::Cpp2ILInjected.Token(Token = "0x600166F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E40AB4", Offset = "0x1E40AB4", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ComponentResourceManager), Member = "FillResources", MemberParameters = new object[]
			{
				typeof(CultureInfo),
				typeof(ref ResourceSet)
			}, ReturnType = typeof(SortedList<string, object>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Assembly),
				typeof(Assembly)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourceManager), Member = "GetNeutralResourcesLanguage", MemberParameters = new object[] { typeof(Assembly) }, ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x000067BB File Offset: 0x000049BB
		[global::Cpp2ILInjected.Token(Token = "0x6001670")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E40B3C", Offset = "0x1E40B3C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ApplyResources(object value, string objectName)
		{
			throw null;
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x000067BE File Offset: 0x000049BE
		[global::Cpp2ILInjected.Token(Token = "0x6001671")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E40B4C", Offset = "0x1E40B4C", Length = "0xA08")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ComponentResourceManager), Member = "FillResources", MemberParameters = new object[]
		{
			typeof(CultureInfo),
			typeof(ref ResourceSet)
		}, ReturnType = typeof(SortedList<string, object>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortedList<, >), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.IEnumerator`1<KeyValuePair`2<TKey, TValue>>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags)
		}, ReturnType = typeof(PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(PropertyInfo),
			typeof(PropertyInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(PropertyInfo),
			typeof(PropertyInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 57)]
		public virtual void ApplyResources(object value, string objectName, CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x000067C1 File Offset: 0x000049C1
		[global::Cpp2ILInjected.Token(Token = "0x6001672")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E41554", Offset = "0x1E41554", Length = "0x4C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ComponentResourceManager), Member = "ApplyResources", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string),
			typeof(CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ComponentResourceManager), Member = "FillResources", MemberParameters = new object[]
		{
			typeof(CultureInfo),
			typeof(ref ResourceSet)
		}, ReturnType = typeof(SortedList<string, object>))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ComponentResourceManager), Member = "get_NeutralResourcesCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortedList<, >), Member = ".ctor", MemberParameters = new object[] { "System.Collections.Generic.IComparer`1<TKey>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ComponentResourceManager), Member = "FillResources", MemberParameters = new object[]
		{
			typeof(CultureInfo),
			typeof(ref ResourceSet)
		}, ReturnType = typeof(SortedList<string, object>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortedList<, >), Member = "set_Item", MemberParameters = new object[] { "TKey", "TValue" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private SortedList<string, object> FillResources(CultureInfo culture, out ResourceSet resourceSet)
		{
			throw null;
		}

		// Token: 0x04000DDE RID: 3550
		[global::Cpp2ILInjected.Token(Token = "0x40011E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Hashtable _resourceSets;

		// Token: 0x04000DDF RID: 3551
		[global::Cpp2ILInjected.Token(Token = "0x40011E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private CultureInfo _neutralResourcesCulture;
	}
}
