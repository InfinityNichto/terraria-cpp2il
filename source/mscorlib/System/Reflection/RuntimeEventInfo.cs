using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000448 RID: 1096
	[global::Cpp2ILInjected.Token(Token = "0x200050A")]
	[global::System.Serializable]
	[StructLayout(0)]
	internal sealed class RuntimeEventInfo : EventInfo, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060022EA RID: 8938
		[global::Cpp2ILInjected.Token(Token = "0x6002588")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8D900", Offset = "0x1B8D900", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void get_event_info(RuntimeEventInfo ev, out MonoEventInfo info);

		// Token: 0x060022EB RID: 8939 RVA: 0x0001A633 File Offset: 0x00018833
		[global::Cpp2ILInjected.Token(Token = "0x6002589")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8D904", Offset = "0x1B8D904", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static MonoEventInfo GetEventInfo(RuntimeEventInfo ev)
		{
			throw null;
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x0001A636 File Offset: 0x00018836
		[global::Cpp2ILInjected.Token(Token = "0x17000530")]
		public override Module Module
		{
			[global::Cpp2ILInjected.Token(Token = "0x600258A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8D940", Offset = "0x1B8D940", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeEventInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(global::System.RuntimeType))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x0001A639 File Offset: 0x00018839
		[global::Cpp2ILInjected.Token(Token = "0x17000531")]
		internal BindingFlags BindingFlags
		{
			[global::Cpp2ILInjected.Token(Token = "0x600258B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8D968", Offset = "0x1B8D968", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEventCandidates", MemberParameters = new object[]
			{
				typeof(string),
				typeof(BindingFlags),
				typeof(bool)
			}, ReturnType = typeof(global::System.RuntimeType.ListBuilder<EventInfo>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEvent", MemberParameters = new object[]
			{
				typeof(string),
				typeof(BindingFlags)
			}, ReturnType = typeof(EventInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x0001A63C File Offset: 0x0001883C
		[global::Cpp2ILInjected.Token(Token = "0x600258C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8DAE4", Offset = "0x1B8DAE4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeEventInfo), Member = "get_Module", ReturnType = typeof(Module))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetBindingFlags", ReturnType = typeof(BindingFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal global::System.RuntimeType GetDeclaringTypeInternal()
		{
			throw null;
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x0001A63F File Offset: 0x0001883F
		[global::Cpp2ILInjected.Token(Token = "0x17000532")]
		private global::System.RuntimeType ReflectedTypeInternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x600258D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8DB68", Offset = "0x1B8DB68", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetObjectData", MemberParameters = new object[]
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

		// Token: 0x060022F0 RID: 8944 RVA: 0x0001A642 File Offset: 0x00018842
		[global::Cpp2ILInjected.Token(Token = "0x600258E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8D954", Offset = "0x1B8D954", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeEventInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
		internal RuntimeModule GetRuntimeModule()
		{
			throw null;
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x0001A645 File Offset: 0x00018845
		[global::Cpp2ILInjected.Token(Token = "0x600258F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8DBEC", Offset = "0x1B8DBEC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeEventInfo), Member = "get_ReflectedTypeInternal", ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemberInfoSerializationHolder), Member = "GetSerializationInfo", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(string),
			typeof(global::System.RuntimeType),
			typeof(string),
			typeof(MemberTypes)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x0001A648 File Offset: 0x00018848
		[global::Cpp2ILInjected.Token(Token = "0x6002590")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8D96C", Offset = "0x1B8D96C", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeEventInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "FilterPreCalculate", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(BindingFlags))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal BindingFlags GetBindingFlags()
		{
			throw null;
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x0001A64B File Offset: 0x0001884B
		[global::Cpp2ILInjected.Token(Token = "0x6002591")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8DC84", Offset = "0x1B8DC84", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override MethodInfo GetAddMethod(bool nonPublic)
		{
			throw null;
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x0001A64E File Offset: 0x0001884E
		[global::Cpp2ILInjected.Token(Token = "0x6002592")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8DCEC", Offset = "0x1B8DCEC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override MethodInfo GetRaiseMethod(bool nonPublic)
		{
			throw null;
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x0001A651 File Offset: 0x00018851
		[global::Cpp2ILInjected.Token(Token = "0x6002593")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8DD54", Offset = "0x1B8DD54", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override MethodInfo GetRemoveMethod(bool nonPublic)
		{
			throw null;
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060022F6 RID: 8950 RVA: 0x0001A654 File Offset: 0x00018854
		[global::Cpp2ILInjected.Token(Token = "0x17000533")]
		public override global::System.Type DeclaringType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002594")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8DDBC", Offset = "0x1B8DDBC", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060022F7 RID: 8951 RVA: 0x0001A657 File Offset: 0x00018857
		[global::Cpp2ILInjected.Token(Token = "0x17000534")]
		public override global::System.Type ReflectedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002595")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8DDE8", Offset = "0x1B8DDE8", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060022F8 RID: 8952 RVA: 0x0001A65A File Offset: 0x0001885A
		[global::Cpp2ILInjected.Token(Token = "0x17000535")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002596")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8DE14", Offset = "0x1B8DE14", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x0001A65D File Offset: 0x0001885D
		[global::Cpp2ILInjected.Token(Token = "0x6002597")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8DE40", Offset = "0x1B8DE40", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x0001A660 File Offset: 0x00018860
		[global::Cpp2ILInjected.Token(Token = "0x6002598")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8DED0", Offset = "0x1B8DED0", Length = "0x70")]
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

		// Token: 0x060022FB RID: 8955 RVA: 0x0001A663 File Offset: 0x00018863
		[global::Cpp2ILInjected.Token(Token = "0x6002599")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8DF40", Offset = "0x1B8DF40", Length = "0x68")]
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

		// Token: 0x060022FC RID: 8956 RVA: 0x0001A666 File Offset: 0x00018866
		[global::Cpp2ILInjected.Token(Token = "0x600259A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8DFA8", Offset = "0x1B8DFA8", Length = "0x70")]
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

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x0001A669 File Offset: 0x00018869
		[global::Cpp2ILInjected.Token(Token = "0x17000536")]
		public override int MetadataToken
		{
			[global::Cpp2ILInjected.Token(Token = "0x600259B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B8E018", Offset = "0x1B8E018", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060022FE RID: 8958
		[global::Cpp2ILInjected.Token(Token = "0x600259C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E01C", Offset = "0x1B8E01C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern int get_metadata_token(RuntimeEventInfo monoEvent);

		// Token: 0x060022FF RID: 8959 RVA: 0x0001A66C File Offset: 0x0001886C
		[global::Cpp2ILInjected.Token(Token = "0x600259D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8E020", Offset = "0x1B8E020", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventInfo), Member = ".ctor", ReturnType = typeof(void))]
		public RuntimeEventInfo()
		{
			throw null;
		}

		// Token: 0x040011C8 RID: 4552
		[global::Cpp2ILInjected.Token(Token = "0x40014E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.IntPtr klass;

		// Token: 0x040011C9 RID: 4553
		[global::Cpp2ILInjected.Token(Token = "0x40014E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private global::System.IntPtr handle;
	}
}
