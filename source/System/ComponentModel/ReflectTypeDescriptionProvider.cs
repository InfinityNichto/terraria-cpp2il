using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002EA RID: 746
	[global::Cpp2ILInjected.Token(Token = "0x20003EA")]
	internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider
	{
		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x00007235 File Offset: 0x00005435
		[global::Cpp2ILInjected.Token(Token = "0x17000624")]
		internal static Guid ExtenderProviderKey
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A9E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6F4A8", Offset = "0x1E6F4A8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00007238 File Offset: 0x00005438
		[global::Cpp2ILInjected.Token(Token = "0x6001A9F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6F500", Offset = "0x1E6F500", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptionProvider), Member = ".ctor", ReturnType = typeof(void))]
		internal ReflectTypeDescriptionProvider()
		{
			throw null;
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x0000723B File Offset: 0x0000543B
		[global::Cpp2ILInjected.Token(Token = "0x17000625")]
		private static Hashtable IntrinsicTypeConverters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001AA0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6F508", Offset = "0x1E6F508", Length = "0xAF8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetConverter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 60)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x0000723E File Offset: 0x0000543E
		[global::Cpp2ILInjected.Token(Token = "0x6001AA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E70000", Offset = "0x1E70000", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddEditorTable", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Hashtable)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		internal static void AddEditorTable(Type editorBaseType, Hashtable table)
		{
			throw null;
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00007241 File Offset: 0x00005441
		[global::Cpp2ILInjected.Token(Token = "0x6001AA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7028C", Offset = "0x1E7028C", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "SecureConstructorInvoke", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type[]),
			typeof(object[]),
			typeof(bool),
			typeof(BindingFlags)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "SecureConstructorInvoke", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type[]),
			typeof(object[]),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "SecureCreateInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			throw null;
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00007244 File Offset: 0x00005444
		[global::Cpp2ILInjected.Token(Token = "0x6001AA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E70424", Offset = "0x1E70424", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetConverter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetEditor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "SearchIntrinsicTable", MemberParameters = new object[]
		{
			typeof(Hashtable),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "SecureConstructorInvoke", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type[]),
			typeof(object[]),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "SecureCreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static object CreateInstance(Type objectType, Type callingType)
		{
			throw null;
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00007247 File Offset: 0x00005447
		[global::Cpp2ILInjected.Token(Token = "0x6001AA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7050C", Offset = "0x1E7050C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetAttributes", ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
		internal AttributeCollection GetAttributes(Type type)
		{
			throw null;
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x0000724A File Offset: 0x0000544A
		[global::Cpp2ILInjected.Token(Token = "0x6001AA5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E70C4C", Offset = "0x1E70C4C", Length = "0x35C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public override IDictionary GetCache(object instance)
		{
			throw null;
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x0000724D File Offset: 0x0000544D
		[global::Cpp2ILInjected.Token(Token = "0x6001AA6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E70FA8", Offset = "0x1E70FA8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetClassName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal string GetClassName(Type type)
		{
			throw null;
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00007250 File Offset: 0x00005450
		[global::Cpp2ILInjected.Token(Token = "0x6001AA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E70FE0", Offset = "0x1E70FE0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetComponentName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData))]
		internal string GetComponentName(Type type, object instance)
		{
			throw null;
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x00007253 File Offset: 0x00005453
		[global::Cpp2ILInjected.Token(Token = "0x6001AA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E711A8", Offset = "0x1E711A8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetConverter", ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData))]
		internal TypeConverter GetConverter(Type type, object instance)
		{
			throw null;
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00007256 File Offset: 0x00005456
		[global::Cpp2ILInjected.Token(Token = "0x6001AA9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E71610", Offset = "0x1E71610", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent", ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData))]
		internal EventDescriptor GetDefaultEvent(Type type, object instance)
		{
			throw null;
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x00007259 File Offset: 0x00005459
		[global::Cpp2ILInjected.Token(Token = "0x6001AAA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E717BC", Offset = "0x1E717BC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty", ReturnType = typeof(PropertyDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData))]
		internal PropertyDescriptor GetDefaultProperty(Type type, object instance)
		{
			throw null;
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x0000725C File Offset: 0x0000545C
		[global::Cpp2ILInjected.Token(Token = "0x6001AAB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E71968", Offset = "0x1E71968", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEditor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData))]
		internal object GetEditor(Type type, object instance, Type editorBaseType)
		{
			throw null;
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x0000725F File Offset: 0x0000545F
		[global::Cpp2ILInjected.Token(Token = "0x6001AAC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E71EB4", Offset = "0x1E71EB4", Length = "0x3EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetEditor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "RunClassConstructor", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		private static Hashtable GetEditorTable(Type editorBaseType)
		{
			throw null;
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00007262 File Offset: 0x00005462
		[global::Cpp2ILInjected.Token(Token = "0x6001AAD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E722A0", Offset = "0x1E722A0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEvents", ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEvents", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData))]
		internal EventDescriptorCollection GetEvents(Type type)
		{
			throw null;
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00007265 File Offset: 0x00005465
		[global::Cpp2ILInjected.Token(Token = "0x6001AAE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E72598", Offset = "0x1E72598", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal AttributeCollection GetExtendedAttributes(object instance)
		{
			throw null;
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00007268 File Offset: 0x00005468
		[global::Cpp2ILInjected.Token(Token = "0x6001AAF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E725F0", Offset = "0x1E725F0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetClassName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal string GetExtendedClassName(object instance)
		{
			throw null;
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x0000726B File Offset: 0x0000546B
		[global::Cpp2ILInjected.Token(Token = "0x6001AB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7262C", Offset = "0x1E7262C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetComponentName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetComponentName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		internal string GetExtendedComponentName(object instance)
		{
			throw null;
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x0000726E File Offset: 0x0000546E
		[global::Cpp2ILInjected.Token(Token = "0x6001AB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E72668", Offset = "0x1E72668", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetConverter", ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetConverter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeConverter))]
		internal TypeConverter GetExtendedConverter(object instance)
		{
			throw null;
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00007271 File Offset: 0x00005471
		[global::Cpp2ILInjected.Token(Token = "0x6001AB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E726A4", Offset = "0x1E726A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent", ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal EventDescriptor GetExtendedDefaultEvent(object instance)
		{
			throw null;
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00007274 File Offset: 0x00005474
		[global::Cpp2ILInjected.Token(Token = "0x6001AB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E726AC", Offset = "0x1E726AC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty", ReturnType = typeof(PropertyDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal PropertyDescriptor GetExtendedDefaultProperty(object instance)
		{
			throw null;
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00007277 File Offset: 0x00005477
		[global::Cpp2ILInjected.Token(Token = "0x6001AB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E726B4", Offset = "0x1E726B4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetEditor", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetEditor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		internal object GetExtendedEditor(object instance, Type editorBaseType)
		{
			throw null;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x0000727A File Offset: 0x0000547A
		[global::Cpp2ILInjected.Token(Token = "0x6001AB5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E726F8", Offset = "0x1E726F8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal EventDescriptorCollection GetExtendedEvents(object instance)
		{
			throw null;
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0000727D File Offset: 0x0000547D
		[global::Cpp2ILInjected.Token(Token = "0x6001AB6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E72750", Offset = "0x1E72750", Length = "0x4FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetExtendedProperties", MemberParameters = new object[] { typeof(IExtenderProvider) }, ReturnType = typeof(PropertyDescriptor[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PropertyDescriptor[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		internal PropertyDescriptorCollection GetExtendedProperties(object instance)
		{
			throw null;
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00007280 File Offset: 0x00005480
		[global::Cpp2ILInjected.Token(Token = "0x6001AB7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E73A8C", Offset = "0x1E73A8C", Length = "0x490")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		protected internal override IExtenderProvider[] GetExtenderProviders(object instance)
		{
			throw null;
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00007283 File Offset: 0x00005483
		[global::Cpp2ILInjected.Token(Token = "0x6001AB8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E73F1C", Offset = "0x1E73F1C", Length = "0xA6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
		private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache)
		{
			throw null;
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00007286 File Offset: 0x00005486
		[global::Cpp2ILInjected.Token(Token = "0x6001AB9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E74988", Offset = "0x1E74988", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner", MemberParameters = new object[] { typeof(PropertyDescriptor) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd)
		{
			throw null;
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00007289 File Offset: 0x00005489
		[global::Cpp2ILInjected.Token(Token = "0x6001ABA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E74A10", Offset = "0x1E74A10", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
			throw null;
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0000728C File Offset: 0x0000548C
		[global::Cpp2ILInjected.Token(Token = "0x6001ABB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E74A18", Offset = "0x1E74A18", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override string GetFullComponentName(object component)
		{
			throw null;
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0000728F File Offset: 0x0000548F
		[global::Cpp2ILInjected.Token(Token = "0x6001ABC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E74BC8", Offset = "0x1E74BC8", Length = "0x498")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[] { typeof(Module) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Module), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Module),
			typeof(Module)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		internal Type[] GetPopulatedTypes(Module module)
		{
			throw null;
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00007292 File Offset: 0x00005492
		[global::Cpp2ILInjected.Token(Token = "0x6001ABD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E7507C", Offset = "0x1E7507C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetProperties", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData))]
		internal PropertyDescriptorCollection GetProperties(Type type)
		{
			throw null;
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00007295 File Offset: 0x00005495
		[global::Cpp2ILInjected.Token(Token = "0x6001ABE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E749AC", Offset = "0x1E749AC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor", Member = "System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner", MemberParameters = new object[] { typeof(PropertyDescriptor) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAssociation", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd)
		{
			throw null;
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00007298 File Offset: 0x00005498
		[global::Cpp2ILInjected.Token(Token = "0x6001ABF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E75374", Offset = "0x1E75374", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override Type GetReflectionType(Type objectType, object instance)
		{
			throw null;
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0000729B File Offset: 0x0000549B
		[global::Cpp2ILInjected.Token(Token = "0x6001AC0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E70520", Offset = "0x1E70520", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetAttributes", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetClassName", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetComponentName", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetConverter", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultEvent", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetDefaultProperty", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(PropertyDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetEditor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetEvents", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedClassName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedComponentName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedConverter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedEditor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetProperties", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "IsPopulated", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "Refresh", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[] { typeof(Module) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 18)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(Type type, bool createIfNeeded)
		{
			throw null;
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x0000729E File Offset: 0x0000549E
		[global::Cpp2ILInjected.Token(Token = "0x6001AC1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E753A4", Offset = "0x1E753A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			throw null;
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x000072A1 File Offset: 0x000054A1
		[global::Cpp2ILInjected.Token(Token = "0x6001AC2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E753AC", Offset = "0x1E753AC", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetExtendedProperties", MemberParameters = new object[] { typeof(IExtenderProvider) }, ReturnType = typeof(PropertyDescriptor[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static Type GetTypeFromName(string typeName)
		{
			throw null;
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x000072A4 File Offset: 0x000054A4
		[global::Cpp2ILInjected.Token(Token = "0x6001AC3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E754B4", Offset = "0x1E754B4", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[]
		{
			typeof(object),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "Refresh", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData))]
		internal bool IsPopulated(Type type)
		{
			throw null;
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x000072A7 File Offset: 0x000054A7
		[global::Cpp2ILInjected.Token(Token = "0x6001AC4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E754E4", Offset = "0x1E754E4", Length = "0x414")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetAttributes", ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		private static Attribute[] ReflectGetAttributes(Type type)
		{
			throw null;
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x000072AA File Offset: 0x000054AA
		[global::Cpp2ILInjected.Token(Token = "0x6001AC5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6DA5C", Offset = "0x1E6DA5C", Length = "0x414")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectEventDescriptor), Member = "FillEventInfoAttribute", MemberParameters = new object[]
		{
			typeof(EventInfo),
			typeof(IList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectEventDescriptor), Member = "FillSingleMethodAttribute", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(IList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "FillAttributes", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		internal static Attribute[] ReflectGetAttributes(MemberInfo member)
		{
			throw null;
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x000072AD File Offset: 0x000054AD
		[global::Cpp2ILInjected.Token(Token = "0x6001AC6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E758F8", Offset = "0x1E758F8", Length = "0x604")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetEvents", ReturnType = typeof(EventDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsNestedPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Assembly),
			typeof(Assembly)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventInfo), Member = "GetAddMethod", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventInfo), Member = "GetRemoveMethod", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectEventDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(EventInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 42)]
		private static EventDescriptor[] ReflectGetEvents(Type type)
		{
			throw null;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x000072B0 File Offset: 0x000054B0
		[global::Cpp2ILInjected.Token(Token = "0x6001AC7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E72CB0", Offset = "0x1E72CB0", Length = "0xDDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedProperties", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetCache", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(IDictionary))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExtendedPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ReflectPropertyDescriptor),
			typeof(Type),
			typeof(IExtenderProvider),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type),
			typeof(Type),
			typeof(MethodInfo),
			typeof(MethodInfo),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 95)]
		private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider)
		{
			throw null;
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x000072B3 File Offset: 0x000054B3
		[global::Cpp2ILInjected.Token(Token = "0x6001AC8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E75EFC", Offset = "0x1E75EFC", Length = "0x584")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetProperties", ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "GetGetMethod", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "GetSetMethod", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type),
			typeof(PropertyInfo),
			typeof(MethodInfo),
			typeof(MethodInfo),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		private static PropertyDescriptor[] ReflectGetProperties(Type type)
		{
			throw null;
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x000072B6 File Offset: 0x000054B6
		[global::Cpp2ILInjected.Token(Token = "0x6001AC9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E76480", Offset = "0x1E76480", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetTypeData", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData))]
		internal void Refresh(Type type)
		{
			throw null;
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x000072B9 File Offset: 0x000054B9
		[global::Cpp2ILInjected.Token(Token = "0x6001ACA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E764C4", Offset = "0x1E764C4", Length = "0x8FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetConverter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeConverter))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetEditor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(Type[]) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(ConstructorInfo),
			typeof(ConstructorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
		private static object SearchIntrinsicTable(Hashtable table, Type callingType)
		{
			throw null;
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x000072BC File Offset: 0x000054BC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001ACB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E76DC0", Offset = "0x1E76DC0", Length = "0x29C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "NewGuid", ReturnType = typeof(Guid))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		static ReflectTypeDescriptionProvider()
		{
			throw null;
		}

		// Token: 0x04000F15 RID: 3861
		[global::Cpp2ILInjected.Token(Token = "0x4001336")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Hashtable _typeData;

		// Token: 0x04000F16 RID: 3862
		[global::Cpp2ILInjected.Token(Token = "0x4001337")]
		private static Type[] _typeConstructor;

		// Token: 0x04000F17 RID: 3863
		[global::Cpp2ILInjected.Token(Token = "0x4001338")]
		private static Hashtable _editorTables;

		// Token: 0x04000F18 RID: 3864
		[global::Cpp2ILInjected.Token(Token = "0x4001339")]
		private static Hashtable _intrinsicTypeConverters;

		// Token: 0x04000F19 RID: 3865
		[global::Cpp2ILInjected.Token(Token = "0x400133A")]
		private static object _intrinsicReferenceKey;

		// Token: 0x04000F1A RID: 3866
		[global::Cpp2ILInjected.Token(Token = "0x400133B")]
		private static object _intrinsicNullableKey;

		// Token: 0x04000F1B RID: 3867
		[global::Cpp2ILInjected.Token(Token = "0x400133C")]
		private static object _dictionaryKey;

		// Token: 0x04000F1C RID: 3868
		[global::Cpp2ILInjected.Token(Token = "0x400133D")]
		private static Hashtable _propertyCache;

		// Token: 0x04000F1D RID: 3869
		[global::Cpp2ILInjected.Token(Token = "0x400133E")]
		private static Hashtable _eventCache;

		// Token: 0x04000F1E RID: 3870
		[global::Cpp2ILInjected.Token(Token = "0x400133F")]
		private static Hashtable _attributeCache;

		// Token: 0x04000F1F RID: 3871
		[global::Cpp2ILInjected.Token(Token = "0x4001340")]
		private static Hashtable _extendedPropertyCache;

		// Token: 0x04000F20 RID: 3872
		[global::Cpp2ILInjected.Token(Token = "0x4001341")]
		private static readonly Guid _extenderProviderKey;

		// Token: 0x04000F21 RID: 3873
		[global::Cpp2ILInjected.Token(Token = "0x4001342")]
		private static readonly Guid _extenderPropertiesKey;

		// Token: 0x04000F22 RID: 3874
		[global::Cpp2ILInjected.Token(Token = "0x4001343")]
		private static readonly Guid _extenderProviderPropertiesKey;

		// Token: 0x04000F23 RID: 3875
		[global::Cpp2ILInjected.Token(Token = "0x4001344")]
		private static readonly Type[] _skipInterfaceAttributeList;

		// Token: 0x04000F24 RID: 3876
		[global::Cpp2ILInjected.Token(Token = "0x4001345")]
		private static object _internalSyncObject;

		// Token: 0x02000462 RID: 1122
		[global::Cpp2ILInjected.Token(Token = "0x20003EB")]
		private class ReflectedTypeData
		{
			// Token: 0x06001EFF RID: 7935 RVA: 0x0000857C File Offset: 0x0000677C
			[global::Cpp2ILInjected.Token(Token = "0x6001ACC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E7537C", Offset = "0x1E7537C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal ReflectedTypeData(Type type)
			{
				throw null;
			}

			// Token: 0x1700075B RID: 1883
			// (get) Token: 0x06001F00 RID: 7936 RVA: 0x0000857F File Offset: 0x0000677F
			[global::Cpp2ILInjected.Token(Token = "0x17000626")]
			internal bool IsPopulated
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001ACD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E75060", Offset = "0x1E75060", Length = "0x1C")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06001F01 RID: 7937 RVA: 0x00008582 File Offset: 0x00006782
			[global::Cpp2ILInjected.Token(Token = "0x6001ACE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E70788", Offset = "0x1E70788", Length = "0x4C4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetAttributes", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(AttributeCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetAttributes", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Attribute[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_Attributes", ReturnType = typeof(TypeAttributes))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(AttributeCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "CopyTo", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OrderedDictionary), Member = "get_Values", ReturnType = typeof(ICollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = ".ctor", MemberParameters = new object[] { typeof(Attribute[]) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
			internal AttributeCollection GetAttributes()
			{
				throw null;
			}

			// Token: 0x06001F02 RID: 7938 RVA: 0x00008585 File Offset: 0x00006785
			[global::Cpp2ILInjected.Token(Token = "0x6001ACF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E70FCC", Offset = "0x1E70FCC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string GetClassName(object instance)
			{
				throw null;
			}

			// Token: 0x06001F03 RID: 7939 RVA: 0x00008588 File Offset: 0x00006788
			[global::Cpp2ILInjected.Token(Token = "0x6001AD0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E70FFC", Offset = "0x1E70FFC", Length = "0x1AC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedComponentName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			internal string GetComponentName(object instance)
			{
				throw null;
			}

			// Token: 0x06001F04 RID: 7940 RVA: 0x0000858B File Offset: 0x0000678B
			[global::Cpp2ILInjected.Token(Token = "0x6001AD1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E711C4", Offset = "0x1E711C4", Length = "0x44C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedConverter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(AttributeCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AttributeCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetTypeFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "get_IntrinsicTypeConverters", ReturnType = typeof(Hashtable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "SearchIntrinsicTable", MemberParameters = new object[]
			{
				typeof(Hashtable),
				typeof(Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			internal TypeConverter GetConverter(object instance)
			{
				throw null;
			}

			// Token: 0x06001F05 RID: 7941 RVA: 0x0000858E File Offset: 0x0000678E
			[global::Cpp2ILInjected.Token(Token = "0x6001AD2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E7162C", Offset = "0x1E7162C", Length = "0x190")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AttributeCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(AttributeCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(EventDescriptorCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(EventDescriptorCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			internal EventDescriptor GetDefaultEvent(object instance)
			{
				throw null;
			}

			// Token: 0x06001F06 RID: 7942 RVA: 0x00008591 File Offset: 0x00006791
			[global::Cpp2ILInjected.Token(Token = "0x6001AD3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E717D8", Offset = "0x1E717D8", Length = "0x190")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AttributeCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(AttributeCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(PropertyDescriptorCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PropertyDescriptorCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			internal PropertyDescriptor GetDefaultProperty(object instance)
			{
				throw null;
			}

			// Token: 0x06001F07 RID: 7943 RVA: 0x00008594 File Offset: 0x00006794
			[global::Cpp2ILInjected.Token(Token = "0x6001AD4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E71994", Offset = "0x1E71994", Length = "0x520")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetExtendedEditor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(AttributeCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetEditorAttribute", MemberParameters = new object[]
			{
				typeof(AttributeCollection),
				typeof(Type)
			}, ReturnType = typeof(EditorAttribute))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(AttributeCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetTypeFromName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "CreateInstance", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(object))]
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
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "GetEditorTable", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Hashtable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "SearchIntrinsicTable", MemberParameters = new object[]
			{
				typeof(Hashtable),
				typeof(Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "CopyTo", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
			internal object GetEditor(object instance, Type editorBaseType)
			{
				throw null;
			}

			// Token: 0x06001F08 RID: 7944 RVA: 0x00008597 File Offset: 0x00006797
			[global::Cpp2ILInjected.Token(Token = "0x6001AD5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E77404", Offset = "0x1E77404", Length = "0x3B4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetEditor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
			private static EditorAttribute GetEditorAttribute(AttributeCollection attributes, Type editorBaseType)
			{
				throw null;
			}

			// Token: 0x06001F09 RID: 7945 RVA: 0x0000859A File Offset: 0x0000679A
			[global::Cpp2ILInjected.Token(Token = "0x6001AD6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E722B4", Offset = "0x1E722B4", Length = "0x2E4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetEvents", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(EventDescriptor[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection), Member = "CopyTo", MemberParameters = new object[]
			{
				typeof(object[]),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(EventDescriptor[]),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			internal EventDescriptorCollection GetEvents()
			{
				throw null;
			}

			// Token: 0x06001F0A RID: 7946 RVA: 0x0000859D File Offset: 0x0000679D
			[global::Cpp2ILInjected.Token(Token = "0x6001AD7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E75090", Offset = "0x1E75090", Length = "0x2E4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetProperties", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PropertyDescriptor[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection), Member = "CopyTo", MemberParameters = new object[]
			{
				typeof(object[]),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptorCollection), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(PropertyDescriptor[]),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			internal PropertyDescriptorCollection GetProperties()
			{
				throw null;
			}

			// Token: 0x06001F0B RID: 7947 RVA: 0x000085A0 File Offset: 0x000067A0
			[global::Cpp2ILInjected.Token(Token = "0x6001AD8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E7705C", Offset = "0x1E7705C", Length = "0x19C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetConverter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(TypeConverter))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider.ReflectedTypeData), Member = "GetEditor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			private Type GetTypeFromName(string typeName)
			{
				throw null;
			}

			// Token: 0x06001F0C RID: 7948 RVA: 0x000085A3 File Offset: 0x000067A3
			[global::Cpp2ILInjected.Token(Token = "0x6001AD9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E764AC", Offset = "0x1E764AC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void Refresh()
			{
				throw null;
			}

			// Token: 0x040013A5 RID: 5029
			[global::Cpp2ILInjected.Token(Token = "0x4001346")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Type _type;

			// Token: 0x040013A6 RID: 5030
			[global::Cpp2ILInjected.Token(Token = "0x4001347")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private AttributeCollection _attributes;

			// Token: 0x040013A7 RID: 5031
			[global::Cpp2ILInjected.Token(Token = "0x4001348")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private EventDescriptorCollection _events;

			// Token: 0x040013A8 RID: 5032
			[global::Cpp2ILInjected.Token(Token = "0x4001349")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private PropertyDescriptorCollection _properties;

			// Token: 0x040013A9 RID: 5033
			[global::Cpp2ILInjected.Token(Token = "0x400134A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private TypeConverter _converter;

			// Token: 0x040013AA RID: 5034
			[global::Cpp2ILInjected.Token(Token = "0x400134B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private object[] _editors;

			// Token: 0x040013AB RID: 5035
			[global::Cpp2ILInjected.Token(Token = "0x400134C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private Type[] _editorTypes;

			// Token: 0x040013AC RID: 5036
			[global::Cpp2ILInjected.Token(Token = "0x400134D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private int _editorCount;
		}
	}
}
