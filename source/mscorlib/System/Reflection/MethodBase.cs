using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200041E RID: 1054
	[global::Cpp2ILInjected.Token(Token = "0x20004DD")]
	[global::System.Serializable]
	public abstract class MethodBase : MemberInfo
	{
		// Token: 0x0600212C RID: 8492 RVA: 0x0001A1B6 File Offset: 0x000183B6
		[global::Cpp2ILInjected.Token(Token = "0x60023C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80824", Offset = "0x1B80824", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected MethodBase()
		{
			throw null;
		}

		// Token: 0x0600212D RID: 8493
		[global::Cpp2ILInjected.Token(Token = "0x60023C7")]
		public abstract ParameterInfo[] GetParameters();

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x0600212E RID: 8494
		[global::Cpp2ILInjected.Token(Token = "0x170004B0")]
		public abstract MethodAttributes Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023C8")]
			get;
		}

		// Token: 0x0600212F RID: 8495
		[global::Cpp2ILInjected.Token(Token = "0x60023C9")]
		public abstract MethodImplAttributes GetMethodImplementationFlags();

		// Token: 0x06002130 RID: 8496 RVA: 0x0001A1B9 File Offset: 0x000183B9
		[global::Cpp2ILInjected.Token(Token = "0x60023CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8269C", Offset = "0x1B8269C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual MethodBody GetMethodBody()
		{
			throw null;
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x0001A1BC File Offset: 0x000183BC
		[global::Cpp2ILInjected.Token(Token = "0x170004B1")]
		public virtual CallingConventions CallingConvention
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B826D4", Offset = "0x1B826D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x0001A1BF File Offset: 0x000183BF
		[global::Cpp2ILInjected.Token(Token = "0x170004B2")]
		public bool IsAbstract
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B826DC", Offset = "0x1B826DC", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "ForceJITOnAssembly", MemberParameters = new object[] { typeof(Assembly) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FilterApplyBase", MemberParameters = new object[]
			{
				typeof(MemberInfo),
				typeof(BindingFlags),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x0001A1C2 File Offset: 0x000183C2
		[global::Cpp2ILInjected.Token(Token = "0x170004B3")]
		public bool IsConstructor
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B826FC", Offset = "0x1B826FC", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "PrivateInvoke", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Remoting.Proxies.RealProxy),
				typeof(global::System.Runtime.Remoting.Messaging.IMessage),
				typeof(ref global::System.Exception),
				typeof(ref object[])
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMethodRef), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMethodMessage) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x0001A1C5 File Offset: 0x000183C5
		[global::Cpp2ILInjected.Token(Token = "0x170004B4")]
		public bool IsStatic
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B827A0", Offset = "0x1B827A0", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(object),
				typeof(MethodInfo),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(global::System.Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBaseEventDefinition", MemberParameters = new object[] { typeof(RuntimeEventInfo) }, ReturnType = typeof(EventInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetBindingFlags", ReturnType = typeof(BindingFlags))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeMethodInfo), Member = "Invoke", MemberParameters = new object[]
			{
				typeof(object),
				typeof(BindingFlags),
				typeof(Binder),
				typeof(object[]),
				typeof(global::System.Globalization.CultureInfo)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "Invoke", MemberParameters = new object[]
			{
				typeof(object),
				typeof(BindingFlags),
				typeof(Binder),
				typeof(object[]),
				typeof(global::System.Globalization.CultureInfo)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetExtendedProperties", MemberParameters = new object[] { "System.ComponentModel.IExtenderProvider" }, ReturnType = "System.ComponentModel.PropertyDescriptor[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Design.Serialization.InstanceDescriptor", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(MemberInfo),
				typeof(global::System.Collections.ICollection),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.BaseInvokableCall", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(MethodInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.PersistentCall", Member = "GetRuntimeCall", MemberParameters = new object[] { "UnityEngine.Events.UnityEventBase" }, ReturnType = "UnityEngine.Events.BaseInvokableCall")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x0001A1C8 File Offset: 0x000183C8
		[global::Cpp2ILInjected.Token(Token = "0x170004B5")]
		public bool IsVirtual
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B827C0", Offset = "0x1B827C0", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FilterApplyBase", MemberParameters = new object[]
			{
				typeof(MemberInfo),
				typeof(BindingFlags),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBasePropertyDefinition", MemberParameters = new object[] { typeof(RuntimePropertyInfo) }, ReturnType = typeof(PropertyInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBaseEventDefinition", MemberParameters = new object[] { typeof(RuntimeEventInfo) }, ReturnType = typeof(EventInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBase", MemberParameters = new object[] { typeof(ICustomAttributeProvider) }, ReturnType = typeof(ICustomAttributeProvider))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "IsVirtual", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "IsValidCallback", MemberParameters = new object[]
			{
				typeof(MethodInfo),
				"System.Reflection.ParameterInfo[]",
				typeof(global::System.Type),
				typeof(MethodInfo),
				typeof(ref global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x0001A1CB File Offset: 0x000183CB
		[global::Cpp2ILInjected.Token(Token = "0x170004B6")]
		public bool IsPublic
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B827E0", Offset = "0x1B827E0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceMono", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBaseEventDefinition", MemberParameters = new object[] { typeof(RuntimeEventInfo) }, ReturnType = typeof(EventInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetBindingFlags", ReturnType = typeof(BindingFlags))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetAddMethod", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetRaiseMethod", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetRemoveMethod", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetGetMethod", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimePropertyInfo), Member = "GetSetMethod", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.SecurityUtils", Member = "MethodInfoInvoke", MemberParameters = new object[]
			{
				typeof(MethodInfo),
				typeof(object),
				"System.Object[]"
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetExtendedProperties", MemberParameters = new object[] { "System.ComponentModel.IExtenderProvider" }, ReturnType = "System.ComponentModel.PropertyDescriptor[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionObject", Member = "Create", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(MethodBase),
				"System.String[]"
			}, ReturnType = "Newtonsoft.Json.Utilities.ReflectionObject")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "IsPublic", MemberParameters = new object[] { typeof(PropertyInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x0001A1CE File Offset: 0x000183CE
		[global::Cpp2ILInjected.Token(Token = "0x170004B7")]
		public virtual bool IsGenericMethod
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B82808", Offset = "0x1B82808", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06002138 RID: 8504 RVA: 0x0001A1D1 File Offset: 0x000183D1
		[global::Cpp2ILInjected.Token(Token = "0x170004B8")]
		public virtual bool IsGenericMethodDefinition
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B82810", Offset = "0x1B82810", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002139 RID: 8505 RVA: 0x0001A1D4 File Offset: 0x000183D4
		[global::Cpp2ILInjected.Token(Token = "0x60023D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B82818", Offset = "0x1B82818", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual global::System.Type[] GetGenericArguments()
		{
			throw null;
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600213A RID: 8506 RVA: 0x0001A1D7 File Offset: 0x000183D7
		[global::Cpp2ILInjected.Token(Token = "0x170004B9")]
		public virtual bool ContainsGenericParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B82864", Offset = "0x1B82864", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x0001A1DA File Offset: 0x000183DA
		[global::System.Diagnostics.DebuggerHidden]
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::Cpp2ILInjected.Token(Token = "0x60023D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8286C", Offset = "0x1B8286C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object Invoke(object obj, object[] parameters)
		{
			throw null;
		}

		// Token: 0x0600213C RID: 8508
		[global::Cpp2ILInjected.Token(Token = "0x60023D6")]
		public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, global::System.Globalization.CultureInfo culture);

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600213D RID: 8509
		[global::Cpp2ILInjected.Token(Token = "0x170004BA")]
		public abstract global::System.RuntimeMethodHandle MethodHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023D7")]
			get;
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x0600213E RID: 8510 RVA: 0x0001A1DD File Offset: 0x000183DD
		[global::Cpp2ILInjected.Token(Token = "0x170004BB")]
		public virtual bool IsSecurityCritical
		{
			[global::Cpp2ILInjected.Token(Token = "0x60023D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8288C", Offset = "0x1B8288C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600213F RID: 8511 RVA: 0x0001A1E0 File Offset: 0x000183E0
		[global::Cpp2ILInjected.Token(Token = "0x60023D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8085C", Offset = "0x1B8085C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x0001A1E3 File Offset: 0x000183E3
		[global::Cpp2ILInjected.Token(Token = "0x60023DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8086C", Offset = "0x1B8086C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06002141 RID: 8513 RVA: 0x0001A1E6 File Offset: 0x000183E6
		[global::Cpp2ILInjected.Token(Token = "0x60023DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B82468", Offset = "0x1B82468", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "BindToMethod", MemberParameters = new object[]
		{
			typeof(BindingFlags),
			typeof(MethodBase[]),
			typeof(ref object[]),
			typeof(ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[]),
			typeof(ref object)
		}, ReturnType = typeof(MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "InvokeMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(object),
			typeof(object[]),
			typeof(ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new object[]
		{
			typeof(BindingFlags),
			typeof(Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(object[]),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UnitySerializationHolder), Member = "GetRealObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new object[]
		{
			typeof(global::System.MarshalByRefObject),
			typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
		}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMethodReturnMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "Invoke", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMethodRef), Member = "Resolve", ReturnType = typeof(MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodCall), Member = "get_MethodBase", ReturnType = typeof(MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodCall), Member = "ResolveMethod", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodResponse), Member = "get_MethodBase", ReturnType = typeof(MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MemberInfo),
			typeof(MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodBase), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodBase),
			typeof(MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodBase), Member = "GetMethodFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeMethodHandle) }, ReturnType = typeof(MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Diagnostics.StackFrame), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Diagnostics.StackTrace), Member = "AddFrames", MemberParameters = new object[]
		{
			typeof(global::System.Text.StringBuilder),
			typeof(bool),
			typeof(ref bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(ConstructorInfo),
			typeof(ConstructorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static bool operator ==(MethodBase left, MethodBase right)
		{
			throw null;
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x0001A1E9 File Offset: 0x000183E9
		[global::Cpp2ILInjected.Token(Token = "0x60023DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B82450", Offset = "0x1B82450", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "get_IsGenericMethodParameter", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Exception), Member = "get_Source", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UnitySerializationHolder), Member = "GetRealObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "GetMethodBaseFromName", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Type[])
		}, ReturnType = typeof(MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "FindInterfaceMethod", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Type[])
		}, ReturnType = typeof(MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMethodRef), Member = "Resolve", ReturnType = typeof(MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodCall), Member = "get_MethodSignature", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MonoMethodMessage), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MethodBase),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage), Member = "get_MethodName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage), Member = "get_MethodSignature", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ReturnMessage), Member = "get_TypeName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Diagnostics.StackTrace), Member = "init_frames", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MethodBase),
			typeof(MethodBase)
		}, ReturnType = typeof(bool))]
		public static bool operator !=(MethodBase left, MethodBase right)
		{
			throw null;
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x0001A1EC File Offset: 0x000183EC
		[global::Cpp2ILInjected.Token(Token = "0x60023DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8291C", Offset = "0x1B8291C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal virtual ParameterInfo[] GetParametersInternal()
		{
			throw null;
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x0001A1EF File Offset: 0x000183EF
		[global::Cpp2ILInjected.Token(Token = "0x60023DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8292C", Offset = "0x1B8292C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual int GetParametersCount()
		{
			throw null;
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x0001A1F2 File Offset: 0x000183F2
		[global::Cpp2ILInjected.Token(Token = "0x60023DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8294C", Offset = "0x1B8294C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "ConstructParameters", MemberParameters = new object[]
		{
			typeof(global::System.Type[]),
			typeof(CallingConventions),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal virtual string FormatNameAndSig(bool serialization)
		{
			throw null;
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x0001A1F5 File Offset: 0x000183F5
		[global::Cpp2ILInjected.Token(Token = "0x60023E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B82C3C", Offset = "0x1B82C3C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal virtual global::System.Type[] GetParameterTypes()
		{
			throw null;
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x0001A1F8 File Offset: 0x000183F8
		[global::Cpp2ILInjected.Token(Token = "0x60023E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B82D1C", Offset = "0x1B82D1C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal virtual ParameterInfo[] GetParametersNoCopy()
		{
			throw null;
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x0001A1FB File Offset: 0x000183FB
		[global::Cpp2ILInjected.Token(Token = "0x60023E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B82D2C", Offset = "0x1B82D2C", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeMethodHandle), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeMethodHandle), Member = "IsNullHandle", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeMethodInfo), Member = "GetMethodFromHandleInternalType", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MethodBase),
			typeof(MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static MethodBase GetMethodFromHandle(global::System.RuntimeMethodHandle handle)
		{
			throw null;
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x0001A1FE File Offset: 0x000183FE
		[global::Cpp2ILInjected.Token(Token = "0x60023E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B82A70", Offset = "0x1B82A70", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodBase), Member = "FormatNameAndSig", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal static string ConstructParameters(global::System.Type[] parameterTypes, CallingConventions callingConvention, bool serialization)
		{
			throw null;
		}
	}
}
