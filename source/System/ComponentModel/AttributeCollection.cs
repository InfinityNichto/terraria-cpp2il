using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Reflection;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000257 RID: 599
	[global::Cpp2ILInjected.Token(Token = "0x200034A")]
	public class AttributeCollection : ICollection, IEnumerable
	{
		// Token: 0x0600139F RID: 5023 RVA: 0x00006635 File Offset: 0x00004835
		[global::Cpp2ILInjected.Token(Token = "0x60015E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3DFA4", Offset = "0x1E3DFA4", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AttributeCollection), Member = "FromExisting", MemberParameters = new object[]
		{
			typeof(AttributeCollection),
			typeof(Attribute[])
		}, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AttributeCollection), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberDescriptor), Member = "CreateAttributeCollection", ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.AttributeProvider.AttributeTypeDescriptor", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(AttributeCollection))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public AttributeCollection(params Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00006638 File Offset: 0x00004838
		[global::Cpp2ILInjected.Token(Token = "0x60015E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3E0AC", Offset = "0x1E3E0AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected AttributeCollection()
		{
			throw null;
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x0000663B File Offset: 0x0000483B
		[global::Cpp2ILInjected.Token(Token = "0x60015E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3E0B4", Offset = "0x1E3E0B4", Length = "0x2E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static AttributeCollection FromExisting(AttributeCollection existing, params Attribute[] newAttributes)
		{
			throw null;
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x0000663E File Offset: 0x0000483E
		[global::Cpp2ILInjected.Token(Token = "0x170004F7")]
		protected virtual Attribute[] Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3E418", Offset = "0x1E3E418", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x00006641 File Offset: 0x00004841
		[global::Cpp2ILInjected.Token(Token = "0x170004F8")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3E398", Offset = "0x1E3E398", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptor), Member = "GetEditor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[] { typeof(MemberDescriptor) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(MemberDescriptor),
				typeof(Attribute[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetExtendedProperties", MemberParameters = new object[] { typeof(IExtenderProvider) }, ReturnType = typeof(PropertyDescriptor[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.AttributeProvider.AttributeTypeDescriptor", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "CreateDesigner", MemberParameters = new object[]
			{
				typeof(IComponent),
				typeof(Type)
			}, ReturnType = typeof(IDesigner))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004D0 RID: 1232
		[global::Cpp2ILInjected.Token(Token = "0x170004F9")]
		public virtual Attribute this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3E420", Offset = "0x1E3E420", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004D1 RID: 1233
		[global::Cpp2ILInjected.Token(Token = "0x170004FA")]
		public virtual Attribute this[Type attributeType]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3E448", Offset = "0x1E3E448", Length = "0x378")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "GetDefaultAttribute", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Attribute))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0000664A File Offset: 0x0000484A
		[global::Cpp2ILInjected.Token(Token = "0x60015E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3ECA8", Offset = "0x1E3ECA8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AttributeCollection), Member = "Contains", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderShouldSerializeValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ShouldSerializeValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeConverter.SimplePropertyDescriptor", Member = "get_IsReadOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Contains(Attribute attribute)
		{
			throw null;
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x0000664D File Offset: 0x0000484D
		[global::Cpp2ILInjected.Token(Token = "0x60015E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3ED00", Offset = "0x1E3ED00", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "Contains", MemberParameters = new object[] { typeof(Attribute) }, ReturnType = typeof(bool))]
		public bool Contains(Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00006650 File Offset: 0x00004850
		[global::Cpp2ILInjected.Token(Token = "0x60015EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3E7C0", Offset = "0x1E3E7C0", Length = "0x4E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AttributeCollection), Member = "get_Item", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetReflectionType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(FieldInfo),
			typeof(FieldInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(Type[]) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(ConstructorInfo),
			typeof(ConstructorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		protected Attribute GetDefaultAttribute(Type attributeType)
		{
			throw null;
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00006653 File Offset: 0x00004853
		[global::Cpp2ILInjected.Token(Token = "0x60015EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3ED68", Offset = "0x1E3ED68", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "FillAttributes", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetEditorAttribute", MemberParameters = new object[]
		{
			typeof(AttributeCollection),
			typeof(Type)
		}, ReturnType = typeof(EditorAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetExtendedProperties", MemberParameters = new object[] { typeof(IExtenderProvider) }, ReturnType = typeof(PropertyDescriptor[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		public IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00006656 File Offset: 0x00004856
		[global::Cpp2ILInjected.Token(Token = "0x60015EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3ED84", Offset = "0x1E3ED84", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AttributeCollection), Member = "Matches", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool Matches(Attribute attribute)
		{
			throw null;
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00006659 File Offset: 0x00004859
		[global::Cpp2ILInjected.Token(Token = "0x60015ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3EE18", Offset = "0x1E3EE18", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "Matches", MemberParameters = new object[] { typeof(Attribute) }, ReturnType = typeof(bool))]
		public bool Matches(Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x0000665C File Offset: 0x0000485C
		[global::Cpp2ILInjected.Token(Token = "0x170004FB")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3EE7C", Offset = "0x1E3EE7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x0000665F File Offset: 0x0000485F
		[global::Cpp2ILInjected.Token(Token = "0x170004FC")]
		private object System.Collections.ICollection.SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3EE84", Offset = "0x1E3EE84", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x00006662 File Offset: 0x00004862
		[global::Cpp2ILInjected.Token(Token = "0x170004FD")]
		private int System.Collections.ICollection.Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60015F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3EE8C", Offset = "0x1E3EE8C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00006665 File Offset: 0x00004865
		[global::Cpp2ILInjected.Token(Token = "0x60015F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3EEA8", Offset = "0x1E3EEA8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00006668 File Offset: 0x00004868
		[global::Cpp2ILInjected.Token(Token = "0x60015F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3E3B4", Offset = "0x1E3E3B4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AttributeCollection), Member = "FromExisting", MemberParameters = new object[]
		{
			typeof(AttributeCollection),
			typeof(Attribute[])
		}, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[] { typeof(MemberDescriptor) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.AttributeProvider.AttributeTypeDescriptor", Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
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

		// Token: 0x060013B1 RID: 5041 RVA: 0x0000666B File Offset: 0x0000486B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60015F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3EEC4", Offset = "0x1E3EEC4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static AttributeCollection()
		{
			throw null;
		}

		// Token: 0x04000DB2 RID: 3506
		[global::Cpp2ILInjected.Token(Token = "0x40011B3")]
		public static readonly AttributeCollection Empty;

		// Token: 0x04000DB3 RID: 3507
		[global::Cpp2ILInjected.Token(Token = "0x40011B4")]
		private static Hashtable s_defaultAttributes;

		// Token: 0x04000DB4 RID: 3508
		[global::Cpp2ILInjected.Token(Token = "0x40011B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Attribute[] _attributes;

		// Token: 0x04000DB5 RID: 3509
		[global::Cpp2ILInjected.Token(Token = "0x40011B6")]
		private static readonly object s_internalSyncObject;

		// Token: 0x04000DB6 RID: 3510
		[global::Cpp2ILInjected.Token(Token = "0x40011B7")]
		private const int FOUND_TYPES_LIMIT = 5;

		// Token: 0x04000DB7 RID: 3511
		[global::Cpp2ILInjected.Token(Token = "0x40011B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private AttributeCollection.AttributeEntry[] _foundAttributeTypes;

		// Token: 0x04000DB8 RID: 3512
		[global::Cpp2ILInjected.Token(Token = "0x40011B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _index;

		// Token: 0x02000455 RID: 1109
		[global::Cpp2ILInjected.Token(Token = "0x200034B")]
		private struct AttributeEntry
		{
			// Token: 0x04001385 RID: 4997
			[global::Cpp2ILInjected.Token(Token = "0x40011BA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Type type;

			// Token: 0x04001386 RID: 4998
			[global::Cpp2ILInjected.Token(Token = "0x40011BB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public int index;
		}
	}
}
