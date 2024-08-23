﻿using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x0200044D RID: 1101
	[global::Cpp2ILInjected.Token(Token = "0x200050F")]
	[global::System.Serializable]
	[StructLayout(0)]
	internal class RuntimeConstructorInfo : ConstructorInfo, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06002367 RID: 9063 RVA: 0x0001A753 File Offset: 0x00018953
		[global::Cpp2ILInjected.Token(Token = "0x17000551")]
		public override Module Module
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002605")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B90AD8", Offset = "0x1B90AD8", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x0001A756 File Offset: 0x00018956
		[global::Cpp2ILInjected.Token(Token = "0x6002606")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90ADC", Offset = "0x1B90ADC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetModule", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(RuntimeModule))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal RuntimeModule GetRuntimeModule()
		{
			throw null;
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06002369 RID: 9065 RVA: 0x0001A759 File Offset: 0x00018959
		[global::Cpp2ILInjected.Token(Token = "0x17000552")]
		internal BindingFlags BindingFlags
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002607")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B90B64", Offset = "0x1B90B64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FilterApplyConstructorInfo", MemberParameters = new object[]
			{
				typeof(RuntimeConstructorInfo),
				typeof(BindingFlags),
				typeof(CallingConventions),
				typeof(global::System.Type[])
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x0600236A RID: 9066 RVA: 0x0001A75C File Offset: 0x0001895C
		[global::Cpp2ILInjected.Token(Token = "0x17000553")]
		private global::System.RuntimeType ReflectedTypeInternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002608")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B90B6C", Offset = "0x1B90B6C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "GetObjectData", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Serialization.SerializationInfo),
				typeof(global::System.Runtime.Serialization.StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x0001A75F File Offset: 0x0001895F
		[global::Cpp2ILInjected.Token(Token = "0x6002609")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90BF0", Offset = "0x1B90BF0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeConstructorInfo), Member = "get_ReflectedTypeInternal", ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberInfoSerializationHolder), Member = "GetSerializationInfo", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(string),
			typeof(global::System.RuntimeType),
			typeof(string),
			typeof(string),
			typeof(MemberTypes),
			typeof(global::System.Type[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x0001A762 File Offset: 0x00018962
		[global::Cpp2ILInjected.Token(Token = "0x600260A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90CC8", Offset = "0x1B90CC8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemberInfoSerializationHolder), Member = "GetRealObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal string SerializationToString()
		{
			throw null;
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x0001A765 File Offset: 0x00018965
		[global::Cpp2ILInjected.Token(Token = "0x600260B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90CDC", Offset = "0x1B90CDC", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ObjectManager), Member = "CompleteISerializableObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.SafeSerializationManager), Member = "System.Runtime.Serialization.IObjectReference.GetRealObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal void SerializationInvoke(object target, global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x0600236E RID: 9070 RVA: 0x0001A768 File Offset: 0x00018968
		[global::Cpp2ILInjected.Token(Token = "0x600260C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90DD4", Offset = "0x1B90DD4", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override MethodImplAttributes GetMethodImplementationFlags()
		{
			throw null;
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x0001A76B File Offset: 0x0001896B
		[global::Cpp2ILInjected.Token(Token = "0x600260D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90E00", Offset = "0x1B90E00", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override ParameterInfo[] GetParameters()
		{
			throw null;
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x0001A76E File Offset: 0x0001896E
		[global::Cpp2ILInjected.Token(Token = "0x600260E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90E0C", Offset = "0x1B90E0C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override ParameterInfo[] GetParametersInternal()
		{
			throw null;
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x0001A771 File Offset: 0x00018971
		[global::Cpp2ILInjected.Token(Token = "0x600260F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90E18", Offset = "0x1B90E18", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override int GetParametersCount()
		{
			throw null;
		}

		// Token: 0x06002372 RID: 9074
		[global::Cpp2ILInjected.Token(Token = "0x6002610")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90E38", Offset = "0x1B90E38", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal extern object InternalInvoke(object obj, object[] parameters, out global::System.Exception exc);

		// Token: 0x06002373 RID: 9075 RVA: 0x0001A774 File Offset: 0x00018974
		[global::System.Diagnostics.DebuggerHidden]
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::Cpp2ILInjected.Token(Token = "0x6002611")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90E3C", Offset = "0x1B90E3C", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TargetException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x06002374 RID: 9076 RVA: 0x0001A777 File Offset: 0x00018977
		[global::Cpp2ILInjected.Token(Token = "0x6002612")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B90F30", Offset = "0x1B90F30", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(BindingFlags),
			typeof(Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeMethodInfo), Member = "ConvertValues", MemberParameters = new object[]
		{
			typeof(Binder),
			typeof(object[]),
			typeof(ParameterInfo[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(BindingFlags)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemberAccessException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x0001A77A File Offset: 0x0001897A
		[global::Cpp2ILInjected.Token(Token = "0x6002613")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91110", Offset = "0x1B91110", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceMono", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceForAnotherGenericParameter", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TargetInvocationException), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public object InternalInvoke(object obj, object[] parameters, bool wrapExceptions)
		{
			throw null;
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x0001A77D File Offset: 0x0001897D
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6002614")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91268", Offset = "0x1B91268", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(BindingFlags),
			typeof(Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(object))]
		public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x0001A780 File Offset: 0x00018980
		[global::Cpp2ILInjected.Token(Token = "0x17000554")]
		public override global::System.RuntimeMethodHandle MethodHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002615")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B91280", Offset = "0x1B91280", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06002378 RID: 9080 RVA: 0x0001A783 File Offset: 0x00018983
		[global::Cpp2ILInjected.Token(Token = "0x17000555")]
		public override MethodAttributes Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002616")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B91288", Offset = "0x1B91288", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x0001A786 File Offset: 0x00018986
		[global::Cpp2ILInjected.Token(Token = "0x17000556")]
		public override CallingConventions CallingConvention
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002617")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B91290", Offset = "0x1B91290", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x0600237A RID: 9082 RVA: 0x0001A789 File Offset: 0x00018989
		[global::Cpp2ILInjected.Token(Token = "0x17000557")]
		public override bool ContainsGenericParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002618")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B912BC", Offset = "0x1B912BC", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x0001A78C File Offset: 0x0001898C
		[global::Cpp2ILInjected.Token(Token = "0x17000558")]
		public override global::System.Type ReflectedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002619")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B912E0", Offset = "0x1B912E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x0600237C RID: 9084 RVA: 0x0001A78F File Offset: 0x0001898F
		[global::Cpp2ILInjected.Token(Token = "0x17000559")]
		public override global::System.Type DeclaringType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600261A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B912E8", Offset = "0x1B912E8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x0001A792 File Offset: 0x00018992
		[global::Cpp2ILInjected.Token(Token = "0x1700055A")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600261B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B91314", Offset = "0x1B91314", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x0001A795 File Offset: 0x00018995
		[global::Cpp2ILInjected.Token(Token = "0x600261C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91328", Offset = "0x1B91328", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsDefined(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x0001A798 File Offset: 0x00018998
		[global::Cpp2ILInjected.Token(Token = "0x600261D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91398", Offset = "0x1B91398", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override object[] GetCustomAttributes(bool inherit)
		{
			throw null;
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x0001A79B File Offset: 0x0001899B
		[global::Cpp2ILInjected.Token(Token = "0x600261E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91400", Offset = "0x1B91400", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override object[] GetCustomAttributes(global::System.Type attributeType, bool inherit)
		{
			throw null;
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x0001A79E File Offset: 0x0001899E
		[global::Cpp2ILInjected.Token(Token = "0x600261F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91470", Offset = "0x1B91470", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override MethodBody GetMethodBody()
		{
			throw null;
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x0001A7A1 File Offset: 0x000189A1
		[global::Cpp2ILInjected.Token(Token = "0x6002620")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B91478", Offset = "0x1B91478", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x0001A7A4 File Offset: 0x000189A4
		[global::Cpp2ILInjected.Token(Token = "0x6002621")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B914E0", Offset = "0x1B914E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int get_core_clr_security_level()
		{
			throw null;
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x0001A7A7 File Offset: 0x000189A7
		[global::Cpp2ILInjected.Token(Token = "0x1700055B")]
		public override bool IsSecurityCritical
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002622")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B914E8", Offset = "0x1B914E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x0001A7AA File Offset: 0x000189AA
		[global::Cpp2ILInjected.Token(Token = "0x1700055C")]
		public override int MetadataToken
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002623")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B914F0", Offset = "0x1B914F0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002386 RID: 9094
		[global::Cpp2ILInjected.Token(Token = "0x6002624")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B914F4", Offset = "0x1B914F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern int get_metadata_token(RuntimeConstructorInfo method);

		// Token: 0x06002387 RID: 9095 RVA: 0x0001A7AD File Offset: 0x000189AD
		[global::Cpp2ILInjected.Token(Token = "0x6002625")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B914F8", Offset = "0x1B914F8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public RuntimeConstructorInfo()
		{
			throw null;
		}

		// Token: 0x040011D7 RID: 4567
		[global::Cpp2ILInjected.Token(Token = "0x40014F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.IntPtr mhandle;

		// Token: 0x040011D8 RID: 4568
		[global::Cpp2ILInjected.Token(Token = "0x40014F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string name;

		// Token: 0x040011D9 RID: 4569
		[global::Cpp2ILInjected.Token(Token = "0x40014F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.Type reftype;
	}
}