using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002B1 RID: 689
	[global::Cpp2ILInjected.Token(Token = "0x20003AD")]
	public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary
	{
		// Token: 0x06001697 RID: 5783 RVA: 0x00006DD9 File Offset: 0x00004FD9
		[global::Cpp2ILInjected.Token(Token = "0x60018EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E58218", Offset = "0x1E58218", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArrayConverter), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(ITypeDescriptorContext),
			typeof(object),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PropertyDescriptor[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", MemberParameters = new object[] { "System.Attribute[]" }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public PropertyDescriptorCollection(PropertyDescriptor[] properties)
		{
			throw null;
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00006DDC File Offset: 0x00004FDC
		[global::Cpp2ILInjected.Token(Token = "0x60018F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E58300", Offset = "0x1E58300", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetProperties", ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedProperties", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetPropertiesImpl", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[]),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineAttributeFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(Attribute[]),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineFilter", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "PipelineMerge", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ICollection),
			typeof(ICollection),
			typeof(object),
			typeof(IDictionary)
		}, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[] { typeof(PropertyDescriptor[]) }, ReturnType = typeof(void))]
		public PropertyDescriptorCollection(PropertyDescriptor[] properties, bool readOnly)
		{
			throw null;
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00006DDF File Offset: 0x00004FDF
		[global::Cpp2ILInjected.Token(Token = "0x60018F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E58324", Offset = "0x1E58324", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "Sort", ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "Sort", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "Sort", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(IComparer)
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "Sort", MemberParameters = new object[] { typeof(IComparer) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private PropertyDescriptorCollection(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer)
		{
			throw null;
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x00006DE2 File Offset: 0x00004FE2
		// (set) Token: 0x0600169B RID: 5787 RVA: 0x00006DE5 File Offset: 0x00004FE5
		[global::Cpp2ILInjected.Token(Token = "0x170005B2")]
		public int Count
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60018F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E58424", Offset = "0x1E58424", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60018F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5842C", Offset = "0x1E5842C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000583 RID: 1411
		[global::Cpp2ILInjected.Token(Token = "0x170005B3")]
		public virtual PropertyDescriptor this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E58434", Offset = "0x1E58434", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000584 RID: 1412
		[global::Cpp2ILInjected.Token(Token = "0x170005B4")]
		public virtual PropertyDescriptor this[string name]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5854C", Offset = "0x1E5854C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00006DEE File Offset: 0x00004FEE
		[global::Cpp2ILInjected.Token(Token = "0x60018F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E58560", Offset = "0x1E58560", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IDictionary.Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IDictionary.set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IList.Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", MemberParameters = new object[] { "System.Attribute[]" }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsureSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int Add(PropertyDescriptor value)
		{
			throw null;
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00006DF1 File Offset: 0x00004FF1
		[global::Cpp2ILInjected.Token(Token = "0x60018F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E58704", Offset = "0x1E58704", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IList.Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IDictionary.Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x00006DF4 File Offset: 0x00004FF4
		[global::Cpp2ILInjected.Token(Token = "0x60018F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E58754", Offset = "0x1E58754", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(PropertyDescriptor) }, ReturnType = typeof(int))]
		public bool Contains(PropertyDescriptor value)
		{
			throw null;
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x00006DF7 File Offset: 0x00004FF7
		[global::Cpp2ILInjected.Token(Token = "0x60018F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E587CC", Offset = "0x1E587CC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void CopyTo(Array array, int index)
		{
			throw null;
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00006DFA File Offset: 0x00004FFA
		[global::Cpp2ILInjected.Token(Token = "0x60018FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E584A0", Offset = "0x1E584A0", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(PropertyDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "EnsureSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IDictionary.set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IList.set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "InternalSort", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnsurePropsOwned()
		{
			throw null;
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x00006DFD File Offset: 0x00004FFD
		[global::Cpp2ILInjected.Token(Token = "0x60018FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E58610", Offset = "0x1E58610", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "Add", MemberParameters = new object[] { typeof(PropertyDescriptor) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(PropertyDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void EnsureSize(int sizeNeeded)
		{
			throw null;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00006E00 File Offset: 0x00005000
		[global::Cpp2ILInjected.Token(Token = "0x60018FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E58A20", Offset = "0x1E58A20", Length = "0x404")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public virtual PropertyDescriptor Find(string name, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00006E03 File Offset: 0x00005003
		[global::Cpp2ILInjected.Token(Token = "0x60018FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5876C", Offset = "0x1E5876C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "Contains", MemberParameters = new object[] { typeof(PropertyDescriptor) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "Remove", MemberParameters = new object[] { typeof(PropertyDescriptor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IList.Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IList.IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(object),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int IndexOf(PropertyDescriptor value)
		{
			throw null;
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00006E06 File Offset: 0x00005006
		[global::Cpp2ILInjected.Token(Token = "0x60018FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E58E24", Offset = "0x1E58E24", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IList.Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsureSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void Insert(int index, PropertyDescriptor value)
		{
			throw null;
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x00006E09 File Offset: 0x00005009
		[global::Cpp2ILInjected.Token(Token = "0x60018FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E58EF4", Offset = "0x1E58EF4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IList.Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(PropertyDescriptor) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Remove(PropertyDescriptor value)
		{
			throw null;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x00006E0C File Offset: 0x0000500C
		[global::Cpp2ILInjected.Token(Token = "0x6001900")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E58F5C", Offset = "0x1E58F5C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "System.Collections.IList.RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x00006E0F File Offset: 0x0000500F
		[global::Cpp2ILInjected.Token(Token = "0x6001901")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E58FF0", Offset = "0x1E58FF0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PropertyDescriptor[]),
			typeof(int),
			typeof(string[]),
			typeof(IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual PropertyDescriptorCollection Sort()
		{
			throw null;
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00006E12 File Offset: 0x00005012
		[global::Cpp2ILInjected.Token(Token = "0x6001902")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E59068", Offset = "0x1E59068", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PropertyDescriptor[]),
			typeof(int),
			typeof(string[]),
			typeof(IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual PropertyDescriptorCollection Sort(string[] names)
		{
			throw null;
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00006E15 File Offset: 0x00005015
		[global::Cpp2ILInjected.Token(Token = "0x6001903")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E590E4", Offset = "0x1E590E4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PropertyDescriptor[]),
			typeof(int),
			typeof(string[]),
			typeof(IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual PropertyDescriptorCollection Sort(string[] names, IComparer comparer)
		{
			throw null;
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00006E18 File Offset: 0x00005018
		[global::Cpp2ILInjected.Token(Token = "0x6001904")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E59160", Offset = "0x1E59160", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PropertyDescriptor[]),
			typeof(int),
			typeof(string[]),
			typeof(IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual PropertyDescriptorCollection Sort(IComparer comparer)
		{
			throw null;
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00006E1B File Offset: 0x0000501B
		[global::Cpp2ILInjected.Token(Token = "0x6001905")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E58808", Offset = "0x1E58808", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "InternalSort", MemberParameters = new object[] { typeof(IComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		protected void InternalSort(string[] names)
		{
			throw null;
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00006E1E File Offset: 0x0000501E
		[global::Cpp2ILInjected.Token(Token = "0x6001906")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E591DC", Offset = "0x1E591DC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection), Member = "InternalSort", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "SortDescriptorArray", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void InternalSort(IComparer sorter)
		{
			throw null;
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00006E21 File Offset: 0x00005021
		[global::Cpp2ILInjected.Token(Token = "0x6001907")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E59254", Offset = "0x1E59254", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x00006E24 File Offset: 0x00005024
		[global::Cpp2ILInjected.Token(Token = "0x170005B5")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001908")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E592E4", Offset = "0x1E592E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x00006E27 File Offset: 0x00005027
		[global::Cpp2ILInjected.Token(Token = "0x170005B6")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001909")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E592EC", Offset = "0x1E592EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x00006E2A File Offset: 0x0000502A
		[global::Cpp2ILInjected.Token(Token = "0x170005B7")]
		private int System.Collections.ICollection.Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x600190A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E592F4", Offset = "0x1E592F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00006E2D File Offset: 0x0000502D
		[global::Cpp2ILInjected.Token(Token = "0x600190B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E592FC", Offset = "0x1E592FC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "Clear", ReturnType = typeof(void))]
		private void System.Collections.IList.Clear()
		{
			throw null;
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00006E30 File Offset: 0x00005030
		[global::Cpp2ILInjected.Token(Token = "0x600190C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E59300", Offset = "0x1E59300", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "Clear", ReturnType = typeof(void))]
		private void System.Collections.IDictionary.Clear()
		{
			throw null;
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00006E33 File Offset: 0x00005033
		[global::Cpp2ILInjected.Token(Token = "0x600190D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E59304", Offset = "0x1E59304", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00006E36 File Offset: 0x00005036
		[global::Cpp2ILInjected.Token(Token = "0x600190E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E59314", Offset = "0x1E59314", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		private void System.Collections.IList.RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00006E39 File Offset: 0x00005039
		[global::Cpp2ILInjected.Token(Token = "0x600190F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E59318", Offset = "0x1E59318", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "Add", MemberParameters = new object[] { typeof(PropertyDescriptor) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void System.Collections.IDictionary.Add(object key, object value)
		{
			throw null;
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00006E3C File Offset: 0x0000503C
		[global::Cpp2ILInjected.Token(Token = "0x6001910")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E593DC", Offset = "0x1E593DC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool System.Collections.IDictionary.Contains(object key)
		{
			throw null;
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00006E3F File Offset: 0x0000503F
		[global::Cpp2ILInjected.Token(Token = "0x6001911")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5945C", Offset = "0x1E5945C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x00006E42 File Offset: 0x00005042
		[global::Cpp2ILInjected.Token(Token = "0x170005B8")]
		private bool System.Collections.IDictionary.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001912")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E594F0", Offset = "0x1E594F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x00006E45 File Offset: 0x00005045
		[global::Cpp2ILInjected.Token(Token = "0x170005B9")]
		private bool System.Collections.IDictionary.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001913")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E594F8", Offset = "0x1E594F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x00006E48 File Offset: 0x00005048
		// (set) Token: 0x060016BD RID: 5821 RVA: 0x00006E4B File Offset: 0x0000504B
		[global::Cpp2ILInjected.Token(Token = "0x170005BA")]
		private object System.Collections.IDictionary.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001914")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E59500", Offset = "0x1E59500", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001915")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5957C", Offset = "0x1E5957C", Length = "0x38C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "Add", MemberParameters = new object[] { typeof(PropertyDescriptor) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x00006E4E File Offset: 0x0000504E
		[global::Cpp2ILInjected.Token(Token = "0x170005BB")]
		private ICollection System.Collections.IDictionary.Keys
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001916")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E59908", Offset = "0x1E59908", Length = "0xC0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x00006E51 File Offset: 0x00005051
		[global::Cpp2ILInjected.Token(Token = "0x170005BC")]
		private ICollection System.Collections.IDictionary.Values
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001917")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E599C8", Offset = "0x1E599C8", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00006E54 File Offset: 0x00005054
		[global::Cpp2ILInjected.Token(Token = "0x6001918")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E59A98", Offset = "0x1E59A98", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Collections.IDictionary.Remove(object key)
		{
			throw null;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00006E57 File Offset: 0x00005057
		[global::Cpp2ILInjected.Token(Token = "0x6001919")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E59B8C", Offset = "0x1E59B8C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "Add", MemberParameters = new object[] { typeof(PropertyDescriptor) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int System.Collections.IList.Add(object value)
		{
			throw null;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00006E5A File Offset: 0x0000505A
		[global::Cpp2ILInjected.Token(Token = "0x600191A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E59C10", Offset = "0x1E59C10", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(PropertyDescriptor) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool System.Collections.IList.Contains(object value)
		{
			throw null;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00006E5D File Offset: 0x0000505D
		[global::Cpp2ILInjected.Token(Token = "0x600191B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E59CA0", Offset = "0x1E59CA0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "IndexOf", MemberParameters = new object[] { typeof(PropertyDescriptor) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int System.Collections.IList.IndexOf(object value)
		{
			throw null;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x00006E60 File Offset: 0x00005060
		[global::Cpp2ILInjected.Token(Token = "0x600191C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E59D24", Offset = "0x1E59D24", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(PropertyDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void System.Collections.IList.Insert(int index, object value)
		{
			throw null;
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x00006E63 File Offset: 0x00005063
		[global::Cpp2ILInjected.Token(Token = "0x170005BD")]
		private bool System.Collections.IList.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x600191D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E59DB8", Offset = "0x1E59DB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x00006E66 File Offset: 0x00005066
		[global::Cpp2ILInjected.Token(Token = "0x170005BE")]
		private bool System.Collections.IList.IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600191E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E59DC0", Offset = "0x1E59DC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x00006E69 File Offset: 0x00005069
		[global::Cpp2ILInjected.Token(Token = "0x600191F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E59DC8", Offset = "0x1E59DC8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "Remove", MemberParameters = new object[] { typeof(PropertyDescriptor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void System.Collections.IList.Remove(object value)
		{
			throw null;
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x00006E6C File Offset: 0x0000506C
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x00006E6F File Offset: 0x0000506F
		[global::Cpp2ILInjected.Token(Token = "0x170005BF")]
		private object System.Collections.IList.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001920")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E59E4C", Offset = "0x1E59E4C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001921")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E59E5C", Offset = "0x1E59E5C", Length = "0x1B4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = "EnsurePropsOwned", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x00006E72 File Offset: 0x00005072
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001922")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5A010", Offset = "0x1E5A010", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[] { typeof(PropertyDescriptor[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static PropertyDescriptorCollection()
		{
			throw null;
		}

		// Token: 0x04000E8B RID: 3723
		[global::Cpp2ILInjected.Token(Token = "0x40012A6")]
		public static readonly PropertyDescriptorCollection Empty;

		// Token: 0x04000E8C RID: 3724
		[global::Cpp2ILInjected.Token(Token = "0x40012A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IDictionary _cachedFoundProperties;

		// Token: 0x04000E8D RID: 3725
		[global::Cpp2ILInjected.Token(Token = "0x40012A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _cachedIgnoreCase;

		// Token: 0x04000E8E RID: 3726
		[global::Cpp2ILInjected.Token(Token = "0x40012A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private PropertyDescriptor[] _properties;

		// Token: 0x04000E8F RID: 3727
		[global::Cpp2ILInjected.Token(Token = "0x40012AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly string[] _namedSort;

		// Token: 0x04000E90 RID: 3728
		[global::Cpp2ILInjected.Token(Token = "0x40012AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly IComparer _comparer;

		// Token: 0x04000E91 RID: 3729
		[global::Cpp2ILInjected.Token(Token = "0x40012AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool _propsOwned;

		// Token: 0x04000E92 RID: 3730
		[global::Cpp2ILInjected.Token(Token = "0x40012AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x39")]
		private bool _needSort;

		// Token: 0x04000E93 RID: 3731
		[global::Cpp2ILInjected.Token(Token = "0x40012AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A")]
		private bool _readOnly;

		// Token: 0x04000E94 RID: 3732
		[global::Cpp2ILInjected.Token(Token = "0x40012AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly object _internalSyncObject;

		// Token: 0x04000E95 RID: 3733
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40012B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int <Count>k__BackingField;

		// Token: 0x0200045E RID: 1118
		[global::Cpp2ILInjected.Token(Token = "0x20003AE")]
		private class PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06001EEE RID: 7918 RVA: 0x00008549 File Offset: 0x00006749
			[global::Cpp2ILInjected.Token(Token = "0x6001923")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E594C0", Offset = "0x1E594C0", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public PropertyDescriptorEnumerator(PropertyDescriptorCollection owner)
			{
				throw null;
			}

			// Token: 0x17000753 RID: 1875
			// (get) Token: 0x06001EEF RID: 7919 RVA: 0x0000854C File Offset: 0x0000674C
			[global::Cpp2ILInjected.Token(Token = "0x170005C0")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001924")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E5A074", Offset = "0x1E5A074", Length = "0x64")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection.PropertyDescriptorEnumerator), Member = "get_Entry", ReturnType = typeof(DictionaryEntry))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000754 RID: 1876
			// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x0000854F File Offset: 0x0000674F
			[global::Cpp2ILInjected.Token(Token = "0x170005C1")]
			public DictionaryEntry Entry
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001925")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E5A0D8", Offset = "0x1E5A0D8", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptorCollection.PropertyDescriptorEnumerator), Member = "get_Current", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DictionaryEntry), Member = ".ctor", MemberParameters = new object[]
				{
					typeof(object),
					typeof(object)
				}, ReturnType = typeof(void))]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000755 RID: 1877
			// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x00008552 File Offset: 0x00006752
			[global::Cpp2ILInjected.Token(Token = "0x170005C2")]
			public object Key
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001926")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E5A134", Offset = "0x1E5A134", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x00008555 File Offset: 0x00006755
			[global::Cpp2ILInjected.Token(Token = "0x170005C3")]
			public object Value
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001927")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E5A164", Offset = "0x1E5A164", Length = "0x30")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001EF3 RID: 7923 RVA: 0x00008558 File Offset: 0x00006758
			[global::Cpp2ILInjected.Token(Token = "0x6001928")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5A194", Offset = "0x1E5A194", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06001EF4 RID: 7924 RVA: 0x0000855B File Offset: 0x0000675B
			[global::Cpp2ILInjected.Token(Token = "0x6001929")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5A1C4", Offset = "0x1E5A1C4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x0400139F RID: 5023
			[global::Cpp2ILInjected.Token(Token = "0x40012B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private PropertyDescriptorCollection _owner;

			// Token: 0x040013A0 RID: 5024
			[global::Cpp2ILInjected.Token(Token = "0x40012B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _index;
		}
	}
}
