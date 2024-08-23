using System;
using System.Collections;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002B0 RID: 688
	[global::Cpp2ILInjected.Token(Token = "0x20003AC")]
	public abstract class PropertyDescriptor : MemberDescriptor
	{
		// Token: 0x06001679 RID: 5753 RVA: 0x00006D97 File Offset: 0x00004F97
		[global::Cpp2ILInjected.Token(Token = "0x60018D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56EE0", Offset = "0x1E56EE0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeConverter.SimplePropertyDescriptor", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeConverter.SimplePropertyDescriptor", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JPropertyDescriptor", Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Linq.JObject", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", MemberParameters = new object[] { "System.Attribute[]" }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		protected PropertyDescriptor(string name, Attribute[] attrs)
		{
			throw null;
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x00006D9A File Offset: 0x00004F9A
		[global::Cpp2ILInjected.Token(Token = "0x60018D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E56EE8", Offset = "0x1E56EE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[] { typeof(MemberDescriptor) }, ReturnType = typeof(void))]
		protected PropertyDescriptor(MemberDescriptor descr)
		{
			throw null;
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x00006D9D File Offset: 0x00004F9D
		[global::Cpp2ILInjected.Token(Token = "0x60018D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4C168", Offset = "0x1E4C168", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(PropertyDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		protected PropertyDescriptor(MemberDescriptor descr, Attribute[] attrs)
		{
			throw null;
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x0600167C RID: 5756
		[global::Cpp2ILInjected.Token(Token = "0x170005AB")]
		public abstract Type ComponentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018D4")]
			get;
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x00006DA0 File Offset: 0x00004FA0
		[global::Cpp2ILInjected.Token(Token = "0x170005AC")]
		public virtual TypeConverter Converter
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E56EF0", Offset = "0x1E56EF0", Length = "0x248")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = "GetTypeFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = "CreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetConverter", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(TypeConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x00006DA3 File Offset: 0x00004FA3
		[global::Cpp2ILInjected.Token(Token = "0x170005AD")]
		public virtual bool IsLocalizable
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E574F4", Offset = "0x1E574F4", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600167F RID: 5759
		[global::Cpp2ILInjected.Token(Token = "0x170005AE")]
		public abstract bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018D7")]
			get;
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x00006DA6 File Offset: 0x00004FA6
		[global::Cpp2ILInjected.Token(Token = "0x170005AF")]
		public DesignerSerializationVisibility SerializationVisibility
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E575DC", Offset = "0x1E575DC", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001681 RID: 5761
		[global::Cpp2ILInjected.Token(Token = "0x170005B0")]
		public abstract Type PropertyType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018D9")]
			get;
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00006DA9 File Offset: 0x00004FA9
		[global::Cpp2ILInjected.Token(Token = "0x60018DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E576B4", Offset = "0x1E576B4", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "AddValueChanged", MemberParameters = new object[]
		{
			typeof(object),
			typeof(EventHandler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public virtual void AddValueChanged(object component, EventHandler handler)
		{
			throw null;
		}

		// Token: 0x06001683 RID: 5763
		[global::Cpp2ILInjected.Token(Token = "0x60018DB")]
		public abstract bool CanResetValue(object component);

		// Token: 0x06001684 RID: 5764 RVA: 0x00006DAC File Offset: 0x00004FAC
		[global::Cpp2ILInjected.Token(Token = "0x60018DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E57800", Offset = "0x1E57800", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00006DAF File Offset: 0x00004FAF
		[global::Cpp2ILInjected.Token(Token = "0x60018DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E57314", Offset = "0x1E57314", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptor), Member = "get_Converter", ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptor), Member = "GetEditor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(Type[]) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(ConstructorInfo),
			typeof(ConstructorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(IServiceProvider),
			typeof(Type),
			typeof(Type[]),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		protected object CreateInstance(Type type)
		{
			throw null;
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00006DB2 File Offset: 0x00004FB2
		[global::Cpp2ILInjected.Token(Token = "0x60018DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E579EC", Offset = "0x1E579EC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "FillAttributes", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "FillAttributes", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		protected override void FillAttributes(IList attributeList)
		{
			throw null;
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00006DB5 File Offset: 0x00004FB5
		[global::Cpp2ILInjected.Token(Token = "0x60018DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E57A00", Offset = "0x1E57A00", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public PropertyDescriptorCollection GetChildProperties()
		{
			throw null;
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00006DB8 File Offset: 0x00004FB8
		[global::Cpp2ILInjected.Token(Token = "0x60018E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E57A18", Offset = "0x1E57A18", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public PropertyDescriptorCollection GetChildProperties(Attribute[] filter)
		{
			throw null;
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00006DBB File Offset: 0x00004FBB
		[global::Cpp2ILInjected.Token(Token = "0x60018E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E57A30", Offset = "0x1E57A30", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public PropertyDescriptorCollection GetChildProperties(object instance)
		{
			throw null;
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00006DBE File Offset: 0x00004FBE
		[global::Cpp2ILInjected.Token(Token = "0x60018E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E57A44", Offset = "0x1E57A44", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter)
		{
			throw null;
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00006DC1 File Offset: 0x00004FC1
		[global::Cpp2ILInjected.Token(Token = "0x60018E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E57AFC", Offset = "0x1E57AFC", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = "GetTypeFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetEditor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = "CreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public virtual object GetEditor(Type editorBaseType)
		{
			throw null;
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00006DC4 File Offset: 0x00004FC4
		[global::Cpp2ILInjected.Token(Token = "0x60018E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E57E44", Offset = "0x1E57E44", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00006DC7 File Offset: 0x00004FC7
		[global::Cpp2ILInjected.Token(Token = "0x60018E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E57E90", Offset = "0x1E57E90", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "GetInvocationTarget", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override object GetInvocationTarget(Type type, object instance)
		{
			throw null;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00006DCA File Offset: 0x00004FCA
		[global::Cpp2ILInjected.Token(Token = "0x60018E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E57138", Offset = "0x1E57138", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptor), Member = "get_Converter", ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PropertyDescriptor), Member = "GetEditor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected Type GetTypeFromName(string typeName)
		{
			throw null;
		}

		// Token: 0x0600168F RID: 5775
		[global::Cpp2ILInjected.Token(Token = "0x60018E7")]
		public abstract object GetValue(object component);

		// Token: 0x06001690 RID: 5776 RVA: 0x00006DCD File Offset: 0x00004FCD
		[global::Cpp2ILInjected.Token(Token = "0x60018E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E57F78", Offset = "0x1E57F78", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "OnValueChanged", MemberParameters = new object[]
		{
			typeof(object),
			typeof(EventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual void OnValueChanged(object component, EventArgs e)
		{
			throw null;
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00006DD0 File Offset: 0x00004FD0
		[global::Cpp2ILInjected.Token(Token = "0x60018E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E58028", Offset = "0x1E58028", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "RemoveValueChanged", MemberParameters = new object[]
		{
			typeof(object),
			typeof(EventHandler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public virtual void RemoveValueChanged(object component, EventHandler handler)
		{
			throw null;
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00006DD3 File Offset: 0x00004FD3
		[global::Cpp2ILInjected.Token(Token = "0x60018EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E58190", Offset = "0x1E58190", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "AddValueChanged", MemberParameters = new object[]
		{
			typeof(object),
			typeof(EventHandler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "RemoveValueChanged", MemberParameters = new object[]
		{
			typeof(object),
			typeof(EventHandler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal EventHandler GetValueChangedHandler(object component)
		{
			throw null;
		}

		// Token: 0x06001693 RID: 5779
		[global::Cpp2ILInjected.Token(Token = "0x60018EB")]
		public abstract void ResetValue(object component);

		// Token: 0x06001694 RID: 5780
		[global::Cpp2ILInjected.Token(Token = "0x60018EC")]
		public abstract void SetValue(object component, object value);

		// Token: 0x06001695 RID: 5781
		[global::Cpp2ILInjected.Token(Token = "0x60018ED")]
		public abstract bool ShouldSerializeValue(object component);

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x00006DD6 File Offset: 0x00004FD6
		[global::Cpp2ILInjected.Token(Token = "0x170005B1")]
		public virtual bool SupportsChangeEvents
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E58210", Offset = "0x1E58210", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000E86 RID: 3718
		[global::Cpp2ILInjected.Token(Token = "0x40012A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private TypeConverter _converter;

		// Token: 0x04000E87 RID: 3719
		[global::Cpp2ILInjected.Token(Token = "0x40012A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Hashtable _valueChangedHandlers;

		// Token: 0x04000E88 RID: 3720
		[global::Cpp2ILInjected.Token(Token = "0x40012A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private object[] _editors;

		// Token: 0x04000E89 RID: 3721
		[global::Cpp2ILInjected.Token(Token = "0x40012A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private Type[] _editorTypes;

		// Token: 0x04000E8A RID: 3722
		[global::Cpp2ILInjected.Token(Token = "0x40012A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private int _editorCount;
	}
}
