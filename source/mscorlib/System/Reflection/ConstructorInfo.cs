using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200040E RID: 1038
	[global::Cpp2ILInjected.Token(Token = "0x20004CC")]
	[global::System.Serializable]
	public abstract class ConstructorInfo : MethodBase
	{
		// Token: 0x060020D9 RID: 8409 RVA: 0x0001A105 File Offset: 0x00018305
		[global::Cpp2ILInjected.Token(Token = "0x6002371")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8081C", Offset = "0x1B8081C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeConstructorInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected ConstructorInfo()
		{
			throw null;
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x0001A108 File Offset: 0x00018308
		[global::Cpp2ILInjected.Token(Token = "0x17000499")]
		public override MemberTypes MemberType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002372")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8082C", Offset = "0x1B8082C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x0001A10B File Offset: 0x0001830B
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6002373")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80834", Offset = "0x1B80834", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "RegisterChannelConfig", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.ChannelData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			"System.Type[]",
			"System.Object[]",
			typeof(bool),
			typeof(BindingFlags)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.AttributeCollection", Member = "GetDefaultAttribute", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.Design.Serialization.InstanceDescriptor", Member = "Invoke", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory.<>c__DisplayClass3_0", Member = "<CreateParameterizedConstructor>b__0", MemberParameters = new object[] { "System.Object[]" }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0`1", Member = "<CreateMethodCall>b__0", MemberParameters = new object[] { "T", "System.Object[]" }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0`1", Member = "<CreateDefaultConstructor>b__1", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.PersistentCall", Member = "GetObjectCall", MemberParameters = new object[]
		{
			"UnityEngine.Object",
			typeof(MethodInfo),
			"UnityEngine.Events.ArgumentCache"
		}, ReturnType = "UnityEngine.Events.BaseInvokableCall")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object Invoke(object[] parameters)
		{
			throw null;
		}

		// Token: 0x060020DC RID: 8412
		[global::Cpp2ILInjected.Token(Token = "0x6002374")]
		public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, global::System.Globalization.CultureInfo culture);

		// Token: 0x060020DD RID: 8413 RVA: 0x0001A10E File Offset: 0x0001830E
		[global::Cpp2ILInjected.Token(Token = "0x6002375")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80854", Offset = "0x1B80854", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x0001A111 File Offset: 0x00018311
		[global::Cpp2ILInjected.Token(Token = "0x6002376")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80864", Offset = "0x1B80864", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x0001A114 File Offset: 0x00018314
		[global::Cpp2ILInjected.Token(Token = "0x6002377")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80874", Offset = "0x1B80874", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetDefaultConstructor", ReturnType = typeof(RuntimeConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetSerializationCtor", ReturnType = typeof(RuntimeConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceMono", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.ChannelServices), Member = "RegisterChannelConfig", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.ChannelData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ObjectManager), Member = "GetConstructor", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(RuntimeConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "SearchIntrinsicTable", MemberParameters = new object[]
		{
			typeof(global::System.Collections.Hashtable),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool operator ==(ConstructorInfo left, ConstructorInfo right)
		{
			throw null;
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x0001A117 File Offset: 0x00018317
		[global::Cpp2ILInjected.Token(Token = "0x6002378")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B808A0", Offset = "0x1B808A0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceMono", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.SafeSerializationManager), Member = "System.Runtime.Serialization.IObjectReference.GetRealObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MethodBase),
			typeof(MethodBase)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CustomAttributeData), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			"System.Type[]",
			"System.Object[]",
			typeof(bool),
			typeof(BindingFlags)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.AttributeCollection", Member = "GetDefaultAttribute", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Attribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BindingList`1", Member = "get_ItemTypeHasDefaultConstructor", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.CultureInfoConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.GuidConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.PropertyDescriptor", Member = "CreateInstance", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.DateTimeOffsetConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator !=(ConstructorInfo left, ConstructorInfo right)
		{
			throw null;
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x0001A11A File Offset: 0x0001831A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002379")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B80934", Offset = "0x1B80934", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ConstructorInfo()
		{
			throw null;
		}

		// Token: 0x0400106B RID: 4203
		[global::Cpp2ILInjected.Token(Token = "0x4001385")]
		public static readonly string ConstructorName;

		// Token: 0x0400106C RID: 4204
		[global::Cpp2ILInjected.Token(Token = "0x4001386")]
		public static readonly string TypeConstructorName;
	}
}
