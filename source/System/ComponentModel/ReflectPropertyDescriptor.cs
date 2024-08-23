using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002E9 RID: 745
	[global::Cpp2ILInjected.Token(Token = "0x20003E9")]
	internal sealed class ReflectPropertyDescriptor : PropertyDescriptor
	{
		// Token: 0x06001811 RID: 6161 RVA: 0x000071C9 File Offset: 0x000053C9
		[global::Cpp2ILInjected.Token(Token = "0x6001A7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E69AF8", Offset = "0x1E69AF8", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type),
			typeof(PropertyInfo),
			typeof(MethodInfo),
			typeof(MethodInfo),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type),
			typeof(Type),
			typeof(MethodInfo),
			typeof(MethodInfo),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "CreateProperty", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x06001812 RID: 6162 RVA: 0x000071CC File Offset: 0x000053CC
		[global::Cpp2ILInjected.Token(Token = "0x6001A7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E69DA8", Offset = "0x1E69DA8", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetProperties", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PropertyDescriptor[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(PropertyInfo),
			typeof(PropertyInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ReflectPropertyDescriptor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs)
		{
			throw null;
		}

		// Token: 0x06001813 RID: 6163 RVA: 0x000071CF File Offset: 0x000053CF
		[global::Cpp2ILInjected.Token(Token = "0x6001A7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E69EC8", Offset = "0x1E69EC8", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetExtendedProperties", MemberParameters = new object[] { typeof(IExtenderProvider) }, ReturnType = typeof(PropertyDescriptor[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(string),
			typeof(Type),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ReflectPropertyDescriptor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs)
		{
			throw null;
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x000071D2 File Offset: 0x000053D2
		[global::Cpp2ILInjected.Token(Token = "0x6001A7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E69F94", Offset = "0x1E69F94", Length = "0x3C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "CreateProperty", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(PropertyDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(PropertyDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberDescriptor),
			typeof(Attribute[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public ReflectPropertyDescriptor(Type componentClass, PropertyDescriptor oldReflectPropertyDescriptor, Attribute[] attributes)
		{
			throw null;
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x000071D5 File Offset: 0x000053D5
		[global::Cpp2ILInjected.Token(Token = "0x17000617")]
		private object AmbientValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6A358", Offset = "0x1E6A358", Length = "0x174")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new object[]
			{
				typeof(IExtenderProvider),
				typeof(object),
				typeof(PropertyDescriptor)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "CanResetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x000071D8 File Offset: 0x000053D8
		[global::Cpp2ILInjected.Token(Token = "0x17000618")]
		private EventDescriptor ChangedEventValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A7F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6A4CC", Offset = "0x1E6A4CC", Length = "0x180")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_SupportsChangeEvents", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(EventDescriptorCollection))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(IFormatProvider),
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x000071DB File Offset: 0x000053DB
		// (set) Token: 0x06001818 RID: 6168 RVA: 0x000071DE File Offset: 0x000053DE
		[global::Cpp2ILInjected.Token(Token = "0x17000619")]
		private EventDescriptor IPropChangedEventValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A80")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6A7A4", Offset = "0x1E6A7A4", Length = "0x1A4")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_SupportsChangeEvents", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetEvents", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(EventDescriptorCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001A81")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6A948", Offset = "0x1E6A948", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x000071E1 File Offset: 0x000053E1
		[global::Cpp2ILInjected.Token(Token = "0x1700061A")]
		public override Type ComponentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A82")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6A9C4", Offset = "0x1E6A9C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x000071E4 File Offset: 0x000053E4
		[global::Cpp2ILInjected.Token(Token = "0x1700061B")]
		private object DefaultValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A83")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6A9CC", Offset = "0x1E6A9CC", Length = "0x27C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderCanResetValue", MemberParameters = new object[]
			{
				typeof(IExtenderProvider),
				typeof(object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new object[]
			{
				typeof(IExtenderProvider),
				typeof(object),
				typeof(PropertyDescriptor)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderShouldSerializeValue", MemberParameters = new object[]
			{
				typeof(IExtenderProvider),
				typeof(object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "CanResetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ShouldSerializeValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x000071E7 File Offset: 0x000053E7
		[global::Cpp2ILInjected.Token(Token = "0x1700061C")]
		private MethodInfo GetMethodValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A84")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6AC48", Offset = "0x1E6AC48", Length = "0x3E0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderGetValue", MemberParameters = new object[]
			{
				typeof(IExtenderProvider),
				typeof(object)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "GetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(PropertyInfo),
				typeof(PropertyInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new object[]
			{
				typeof(string),
				typeof(BindingFlags),
				typeof(Binder),
				typeof(Type),
				typeof(Type[]),
				typeof(ParameterModifier[])
			}, ReturnType = typeof(PropertyInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "FindMethod", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(string),
				typeof(Type[]),
				typeof(Type),
				typeof(bool)
			}, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(MethodInfo),
				typeof(MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(PropertyInfo),
				typeof(PropertyInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x000071EA File Offset: 0x000053EA
		[global::Cpp2ILInjected.Token(Token = "0x1700061D")]
		private bool IsExtender
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A85")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6B028", Offset = "0x1E6B028", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "CanResetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "FillAttributes", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "GetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x000071ED File Offset: 0x000053ED
		[global::Cpp2ILInjected.Token(Token = "0x1700061E")]
		public override bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A86")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6B088", Offset = "0x1E6B088", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(MethodInfo),
				typeof(MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x000071F0 File Offset: 0x000053F0
		[global::Cpp2ILInjected.Token(Token = "0x1700061F")]
		public override Type PropertyType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A87")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6B64C", Offset = "0x1E6B64C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x000071F3 File Offset: 0x000053F3
		[global::Cpp2ILInjected.Token(Token = "0x17000620")]
		private MethodInfo ResetMethodValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A88")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6B654", Offset = "0x1E6B654", Length = "0x1F4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderCanResetValue", MemberParameters = new object[]
			{
				typeof(IExtenderProvider),
				typeof(object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new object[]
			{
				typeof(IExtenderProvider),
				typeof(object),
				typeof(PropertyDescriptor)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "CanResetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ResetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "FindMethod", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(string),
				typeof(Type[]),
				typeof(Type),
				typeof(bool)
			}, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x000071F6 File Offset: 0x000053F6
		[global::Cpp2ILInjected.Token(Token = "0x17000621")]
		private MethodInfo SetMethodValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A89")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6B180", Offset = "0x1E6B180", Length = "0x4CC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "get_IsReadOnly", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderSetValue", MemberParameters = new object[]
			{
				typeof(IExtenderProvider),
				typeof(object),
				typeof(object),
				typeof(PropertyDescriptor)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "FillAttributes", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(MethodInfo),
				typeof(MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new object[]
			{
				typeof(string),
				typeof(BindingFlags),
				typeof(Binder),
				typeof(Type),
				typeof(Type[]),
				typeof(ParameterModifier[])
			}, ReturnType = typeof(PropertyInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(PropertyInfo),
				typeof(PropertyInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "GetSetMethod", ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(MethodInfo),
				typeof(MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyInfo), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(PropertyInfo),
				typeof(PropertyInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "FindMethod", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(string),
				typeof(Type[]),
				typeof(Type),
				typeof(bool)
			}, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x000071F9 File Offset: 0x000053F9
		[global::Cpp2ILInjected.Token(Token = "0x17000622")]
		private MethodInfo ShouldSerializeMethodValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A8A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6B848", Offset = "0x1E6B848", Length = "0x1F4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderCanResetValue", MemberParameters = new object[]
			{
				typeof(IExtenderProvider),
				typeof(object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderShouldSerializeValue", MemberParameters = new object[]
			{
				typeof(IExtenderProvider),
				typeof(object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "CanResetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ShouldSerializeValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "FindMethod", MemberParameters = new object[]
			{
				typeof(Type),
				typeof(string),
				typeof(Type[]),
				typeof(Type),
				typeof(bool)
			}, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x000071FC File Offset: 0x000053FC
		[global::Cpp2ILInjected.Token(Token = "0x6001A8B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6BA3C", Offset = "0x1E6BA3C", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ChangedEventValue", ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = "GetValueChangedHandler", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(EventHandler))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_IPropChangedEventValue", ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyChangedEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = "AddValueChanged", MemberParameters = new object[]
		{
			typeof(object),
			typeof(EventHandler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void AddValueChanged(object component, EventHandler handler)
		{
			throw null;
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x000071FF File Offset: 0x000053FF
		[global::Cpp2ILInjected.Token(Token = "0x6001A8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6BBDC", Offset = "0x1E6BBDC", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = "CanResetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderGetValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ResetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ShouldSerializeMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		internal bool ExtenderCanResetValue(IExtenderProvider provider, object component)
		{
			throw null;
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x00007202 File Offset: 0x00005402
		[global::Cpp2ILInjected.Token(Token = "0x6001A8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6BF5C", Offset = "0x1E6BF5C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal Type ExtenderGetReceiverType()
		{
			throw null;
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00007205 File Offset: 0x00005405
		[global::Cpp2ILInjected.Token(Token = "0x6001A8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6BF64", Offset = "0x1E6BF64", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = "get_PropertyType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal Type ExtenderGetType(IExtenderProvider provider)
		{
			throw null;
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00007208 File Offset: 0x00005408
		[global::Cpp2ILInjected.Token(Token = "0x6001A8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6BE40", Offset = "0x1E6BE40", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = "GetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderCanResetValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderResetValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object),
			typeof(PropertyDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderSetValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object),
			typeof(object),
			typeof(PropertyDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderShouldSerializeValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal object ExtenderGetValue(IExtenderProvider provider, object component)
		{
			throw null;
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x0000720B File Offset: 0x0000540B
		[global::Cpp2ILInjected.Token(Token = "0x6001A90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6BF74", Offset = "0x1E6BF74", Length = "0x500")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = "ResetValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_AmbientValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ResetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "GetSite", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ISite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderGetValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc)
		{
			throw null;
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x0000720E File Offset: 0x0000540E
		[global::Cpp2ILInjected.Token(Token = "0x6001A91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6C474", Offset = "0x1E6C474", Length = "0x440")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "GetSite", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ISite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderGetValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc)
		{
			throw null;
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00007211 File Offset: 0x00005411
		[global::Cpp2ILInjected.Token(Token = "0x6001A92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6C8B4", Offset = "0x1E6C8B4", Length = "0x3E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ExtendedPropertyDescriptor), Member = "ShouldSerializeValue", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ShouldSerializeMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "ExtenderGetValue", MemberParameters = new object[]
		{
			typeof(IExtenderProvider),
			typeof(object)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "Contains", MemberParameters = new object[] { typeof(Attribute) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component)
		{
			throw null;
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00007214 File Offset: 0x00005414
		[global::Cpp2ILInjected.Token(Token = "0x6001A93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6CC98", Offset = "0x1E6CC98", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_IsExtender", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ResetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ShouldSerializeMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_AmbientValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override bool CanResetValue(object component)
		{
			throw null;
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00007217 File Offset: 0x00005417
		[global::Cpp2ILInjected.Token(Token = "0x6001A94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6CEFC", Offset = "0x1E6CEFC", Length = "0xA10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetAttributes", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(AttributeCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_IsExtender", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(Type),
			typeof(Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectTypeDescriptionProvider), Member = "ReflectGetAttributes", MemberParameters = new object[] { typeof(MemberInfo) }, ReturnType = typeof(Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMember", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(MemberInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = "FillAttributes", MemberParameters = new object[] { typeof(IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
		protected override void FillAttributes(IList attributes)
		{
			throw null;
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x0000721A File Offset: 0x0000541A
		[global::Cpp2ILInjected.Token(Token = "0x6001A95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6DE70", Offset = "0x1E6DE70", Length = "0x380")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_IsExtender", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "MethodInfoInvoke", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TargetInvocationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public override object GetValue(object component)
		{
			throw null;
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x0000721D File Offset: 0x0000541D
		[global::Cpp2ILInjected.Token(Token = "0x6001A96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6E1F0", Offset = "0x1E6E1F0", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool),
			typeof(CultureInfo)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void OnINotifyPropertyChanged(object component, PropertyChangedEventArgs e)
		{
			throw null;
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00007220 File Offset: 0x00005420
		[global::Cpp2ILInjected.Token(Token = "0x6001A97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6E2E4", Offset = "0x1E6E2E4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = "OnValueChanged", MemberParameters = new object[]
		{
			typeof(object),
			typeof(EventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnValueChanged(object component, EventArgs e)
		{
			throw null;
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00007223 File Offset: 0x00005423
		[global::Cpp2ILInjected.Token(Token = "0x6001A98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6E38C", Offset = "0x1E6E38C", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ChangedEventValue", ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = "RemoveValueChanged", MemberParameters = new object[]
		{
			typeof(object),
			typeof(EventHandler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyDescriptor), Member = "GetValueChangedHandler", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(EventHandler))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_IPropChangedEventValue", ReturnType = typeof(EventDescriptor))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyChangedEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void RemoveValueChanged(object component, EventHandler handler)
		{
			throw null;
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00007226 File Offset: 0x00005426
		[global::Cpp2ILInjected.Token(Token = "0x6001A99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6E528", Offset = "0x1E6E528", Length = "0x458")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_AmbientValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ResetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "GetSite", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ISite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "MethodInfoInvoke", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public override void ResetValue(object component)
		{
			throw null;
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00007229 File Offset: 0x00005429
		[global::Cpp2ILInjected.Token(Token = "0x6001A9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6E980", Offset = "0x1E6E980", Length = "0x5CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberDescriptor), Member = "GetSite", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ISite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "MethodInfoInvoke", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 48)]
		public override void SetValue(object component, object value)
		{
			throw null;
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x0000722C File Offset: 0x0000542C
		[global::Cpp2ILInjected.Token(Token = "0x6001A9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6EF4C", Offset = "0x1E6EF4C", Length = "0x2FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ShouldSerializeMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_DefaultValue", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AttributeCollection), Member = "Contains", MemberParameters = new object[] { typeof(Attribute) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public override bool ShouldSerializeValue(object component)
		{
			throw null;
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x0000722F File Offset: 0x0000542F
		[global::Cpp2ILInjected.Token(Token = "0x17000623")]
		public override bool SupportsChangeEvents
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001A9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E6F248", Offset = "0x1E6F248", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_IPropChangedEventValue", ReturnType = typeof(EventDescriptor))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectPropertyDescriptor), Member = "get_ChangedEventValue", ReturnType = typeof(EventDescriptor))]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00007232 File Offset: 0x00005432
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001A9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E6F278", Offset = "0x1E6F278", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TraceSwitch), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "CreateMask", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitVector32), Member = "CreateMask", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		static ReflectPropertyDescriptor()
		{
			throw null;
		}

		// Token: 0x04000EFA RID: 3834
		[global::Cpp2ILInjected.Token(Token = "0x400131B")]
		private static readonly Type[] argsNone;

		// Token: 0x04000EFB RID: 3835
		[global::Cpp2ILInjected.Token(Token = "0x400131C")]
		private static readonly object noValue;

		// Token: 0x04000EFC RID: 3836
		[global::Cpp2ILInjected.Token(Token = "0x400131D")]
		private static TraceSwitch PropDescCreateSwitch;

		// Token: 0x04000EFD RID: 3837
		[global::Cpp2ILInjected.Token(Token = "0x400131E")]
		private static TraceSwitch PropDescUsageSwitch;

		// Token: 0x04000EFE RID: 3838
		[global::Cpp2ILInjected.Token(Token = "0x400131F")]
		private static readonly int BitDefaultValueQueried;

		// Token: 0x04000EFF RID: 3839
		[global::Cpp2ILInjected.Token(Token = "0x4001320")]
		private static readonly int BitGetQueried;

		// Token: 0x04000F00 RID: 3840
		[global::Cpp2ILInjected.Token(Token = "0x4001321")]
		private static readonly int BitSetQueried;

		// Token: 0x04000F01 RID: 3841
		[global::Cpp2ILInjected.Token(Token = "0x4001322")]
		private static readonly int BitShouldSerializeQueried;

		// Token: 0x04000F02 RID: 3842
		[global::Cpp2ILInjected.Token(Token = "0x4001323")]
		private static readonly int BitResetQueried;

		// Token: 0x04000F03 RID: 3843
		[global::Cpp2ILInjected.Token(Token = "0x4001324")]
		private static readonly int BitChangedQueried;

		// Token: 0x04000F04 RID: 3844
		[global::Cpp2ILInjected.Token(Token = "0x4001325")]
		private static readonly int BitIPropChangedQueried;

		// Token: 0x04000F05 RID: 3845
		[global::Cpp2ILInjected.Token(Token = "0x4001326")]
		private static readonly int BitReadOnlyChecked;

		// Token: 0x04000F06 RID: 3846
		[global::Cpp2ILInjected.Token(Token = "0x4001327")]
		private static readonly int BitAmbientValueQueried;

		// Token: 0x04000F07 RID: 3847
		[global::Cpp2ILInjected.Token(Token = "0x4001328")]
		private static readonly int BitSetOnDemand;

		// Token: 0x04000F08 RID: 3848
		[global::Cpp2ILInjected.Token(Token = "0x4001329")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		private BitVector32 state;

		// Token: 0x04000F09 RID: 3849
		[global::Cpp2ILInjected.Token(Token = "0x400132A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Type componentClass;

		// Token: 0x04000F0A RID: 3850
		[global::Cpp2ILInjected.Token(Token = "0x400132B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private Type type;

		// Token: 0x04000F0B RID: 3851
		[global::Cpp2ILInjected.Token(Token = "0x400132C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private object defaultValue;

		// Token: 0x04000F0C RID: 3852
		[global::Cpp2ILInjected.Token(Token = "0x400132D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private object ambientValue;

		// Token: 0x04000F0D RID: 3853
		[global::Cpp2ILInjected.Token(Token = "0x400132E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private PropertyInfo propInfo;

		// Token: 0x04000F0E RID: 3854
		[global::Cpp2ILInjected.Token(Token = "0x400132F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private MethodInfo getMethod;

		// Token: 0x04000F0F RID: 3855
		[global::Cpp2ILInjected.Token(Token = "0x4001330")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private MethodInfo setMethod;

		// Token: 0x04000F10 RID: 3856
		[global::Cpp2ILInjected.Token(Token = "0x4001331")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private MethodInfo shouldSerializeMethod;

		// Token: 0x04000F11 RID: 3857
		[global::Cpp2ILInjected.Token(Token = "0x4001332")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private MethodInfo resetMethod;

		// Token: 0x04000F12 RID: 3858
		[global::Cpp2ILInjected.Token(Token = "0x4001333")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private EventDescriptor realChangedEvent;

		// Token: 0x04000F13 RID: 3859
		[global::Cpp2ILInjected.Token(Token = "0x4001334")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private EventDescriptor realIPropChangedEvent;

		// Token: 0x04000F14 RID: 3860
		[global::Cpp2ILInjected.Token(Token = "0x4001335")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private Type receiverType;
	}
}
