using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono;

namespace System.Reflection
{
	// Token: 0x02000429 RID: 1065
	[global::Cpp2ILInjected.Token(Token = "0x20004E8")]
	[global::System.Serializable]
	public abstract class PropertyInfo : MemberInfo
	{
		// Token: 0x0600217F RID: 8575 RVA: 0x0001A29D File Offset: 0x0001849D
		[global::Cpp2ILInjected.Token(Token = "0x6002419")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83F20", Offset = "0x1B83F20", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimePropertyInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected PropertyInfo()
		{
			throw null;
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x0001A2A0 File Offset: 0x000184A0
		[global::Cpp2ILInjected.Token(Token = "0x170004CD")]
		public override MemberTypes MemberType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600241A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B83F28", Offset = "0x1B83F28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06002181 RID: 8577
		[global::Cpp2ILInjected.Token(Token = "0x170004CE")]
		public abstract global::System.Type PropertyType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600241B")]
			get;
		}

		// Token: 0x06002182 RID: 8578
		[global::Cpp2ILInjected.Token(Token = "0x600241C")]
		public abstract ParameterInfo[] GetIndexParameters();

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06002183 RID: 8579
		[global::Cpp2ILInjected.Token(Token = "0x170004CF")]
		public abstract bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x600241D")]
			get;
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06002184 RID: 8580
		[global::Cpp2ILInjected.Token(Token = "0x170004D0")]
		public abstract bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600241E")]
			get;
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x0001A2A3 File Offset: 0x000184A3
		[global::Cpp2ILInjected.Token(Token = "0x600241F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83F30", Offset = "0x1B83F30", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetProperties", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = "System.ComponentModel.PropertyDescriptor[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Design.Serialization.InstanceDescriptor", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(global::System.Collections.ICollection),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "IsVirtual", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetBaseDefinition", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "IsPublic", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MethodInfo GetGetMethod()
		{
			throw null;
		}

		// Token: 0x06002186 RID: 8582
		[global::Cpp2ILInjected.Token(Token = "0x6002420")]
		public abstract MethodInfo GetGetMethod(bool nonPublic);

		// Token: 0x06002187 RID: 8583 RVA: 0x0001A2A6 File Offset: 0x000184A6
		[global::Cpp2ILInjected.Token(Token = "0x6002421")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83F44", Offset = "0x1B83F44", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetProperties", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = "System.ComponentModel.PropertyDescriptor[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "IsVirtual", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetBaseDefinition", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "IsPublic", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MethodInfo GetSetMethod()
		{
			throw null;
		}

		// Token: 0x06002188 RID: 8584
		[global::Cpp2ILInjected.Token(Token = "0x6002422")]
		public abstract MethodInfo GetSetMethod(bool nonPublic);

		// Token: 0x06002189 RID: 8585 RVA: 0x0001A2A9 File Offset: 0x000184A9
		[global::System.Diagnostics.DebuggerHidden]
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::Cpp2ILInjected.Token(Token = "0x6002423")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83F58", Offset = "0x1B83F58", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.DependencyInjector), Member = "ReflectionLoad", ReturnType = typeof(global::Mono.ISystemDependencyProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object GetValue(object obj)
		{
			throw null;
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x0001A2AC File Offset: 0x000184AC
		[global::System.Diagnostics.DebuggerHidden]
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::Cpp2ILInjected.Token(Token = "0x6002424")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83F6C", Offset = "0x1B83F6C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual object GetValue(object obj, object[] index)
		{
			throw null;
		}

		// Token: 0x0600218B RID: 8587
		[global::Cpp2ILInjected.Token(Token = "0x6002425")]
		public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, global::System.Globalization.CultureInfo culture);

		// Token: 0x0600218C RID: 8588 RVA: 0x0001A2AF File Offset: 0x000184AF
		[global::System.Diagnostics.DebuggerHidden]
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::Cpp2ILInjected.Token(Token = "0x6002426")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83F8C", Offset = "0x1B83F8C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void SetValue(object obj, object value, object[] index)
		{
			throw null;
		}

		// Token: 0x0600218D RID: 8589
		[global::Cpp2ILInjected.Token(Token = "0x6002427")]
		public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, global::System.Globalization.CultureInfo culture);

		// Token: 0x0600218E RID: 8590 RVA: 0x0001A2B2 File Offset: 0x000184B2
		[global::Cpp2ILInjected.Token(Token = "0x6002428")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83FAC", Offset = "0x1B83FAC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x0001A2B5 File Offset: 0x000184B5
		[global::Cpp2ILInjected.Token(Token = "0x6002429")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83FB4", Offset = "0x1B83FB4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x0001A2B8 File Offset: 0x000184B8
		[global::Cpp2ILInjected.Token(Token = "0x600242A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B82658", Offset = "0x1B82658", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.DependencyInjector), Member = "ReflectionLoad", ReturnType = typeof(global::Mono.ISystemDependencyProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetPropertyFromHandle", MemberParameters = new object[]
		{
			typeof(global::Mono.RuntimePropertyHandle),
			typeof(global::System.RuntimeTypeHandle)
		}, ReturnType = typeof(PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ComponentResourceManager", Member = "ApplyResources", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool operator ==(PropertyInfo left, PropertyInfo right)
		{
			throw null;
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x0001A2BB File Offset: 0x000184BB
		[global::Cpp2ILInjected.Token(Token = "0x600242B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8261C", Offset = "0x1B8261C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "ExactPropertyBinding", MemberParameters = new object[]
		{
			typeof(PropertyInfo[]),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(ParameterModifier[])
		}, ReturnType = typeof(PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ComponentResourceManager", Member = "ApplyResources", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Type),
			typeof(PropertyInfo),
			typeof(MethodInfo),
			typeof(MethodInfo),
			"System.Attribute[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "get_GetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "get_SetMethodValue", ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public static bool operator !=(PropertyInfo left, PropertyInfo right)
		{
			throw null;
		}
	}
}
