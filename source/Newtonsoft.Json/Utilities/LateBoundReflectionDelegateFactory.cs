using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000041 RID: 65
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000045")]
	internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000028F4 File Offset: 0x00000AF4
		[global::Cpp2ILInjected.Token(Token = "0x1700008D")]
		internal static ReflectionDelegateFactory Instance
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD0448", Offset = "0x1CD0448", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000028F7 File Offset: 0x00000AF7
		[global::Cpp2ILInjected.Token(Token = "0x60002D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD04A0", Offset = "0x1CD04A0", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectConstructor<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method)
		{
			throw null;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000028FA File Offset: 0x00000AFA
		[global::Cpp2ILInjected.Token(Token = "0x60002D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x158F878", Offset = "0x158F878", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method)
		{
			throw null;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000028FD File Offset: 0x00000AFD
		[global::Cpp2ILInjected.Token(Token = "0x60002D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x158F5AC", Offset = "0x158F5AC", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeExtensions), Member = "IsValueType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionUtils), Member = "GetDefaultConstructor", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override Func<T> CreateDefaultConstructor<T>(Type type)
		{
			throw null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002900 File Offset: 0x00000B00
		[global::Cpp2ILInjected.Token(Token = "0x60002D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x158F7B4", Offset = "0x158F7B4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo)
		{
			throw null;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002903 File Offset: 0x00000B03
		[global::Cpp2ILInjected.Token(Token = "0x60002D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x158F6F0", Offset = "0x158F6F0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo)
		{
			throw null;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002906 File Offset: 0x00000B06
		[global::Cpp2ILInjected.Token(Token = "0x60002D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x158F9AC", Offset = "0x158F9AC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo)
		{
			throw null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002909 File Offset: 0x00000B09
		[global::Cpp2ILInjected.Token(Token = "0x60002D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x158FA70", Offset = "0x158FA70", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationUtils), Member = "ArgumentNotNull", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo)
		{
			throw null;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000290C File Offset: 0x00000B0C
		[global::Cpp2ILInjected.Token(Token = "0x60002D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD05F8", Offset = "0x1CD05F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LateBoundReflectionDelegateFactory()
		{
			throw null;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000290F File Offset: 0x00000B0F
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60002DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD0600", Offset = "0x1CD0600", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static LateBoundReflectionDelegateFactory()
		{
			throw null;
		}

		// Token: 0x04000161 RID: 353
		[global::Cpp2ILInjected.Token(Token = "0x400017E")]
		private static readonly LateBoundReflectionDelegateFactory _instance;

		// Token: 0x020000F6 RID: 246
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000046")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06000A89 RID: 2697 RVA: 0x00003F17 File Offset: 0x00002117
			[global::Cpp2ILInjected.Token(Token = "0x60002DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD05F0", Offset = "0x1CD05F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass3_0()
			{
				throw null;
			}

			// Token: 0x06000A8A RID: 2698 RVA: 0x00003F1A File Offset: 0x0000211A
			[global::Cpp2ILInjected.Token(Token = "0x60002DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD065C", Offset = "0x1CD065C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(object))]
			internal object <CreateParameterizedConstructor>b__0(object[] a)
			{
				throw null;
			}

			// Token: 0x06000A8B RID: 2699 RVA: 0x00003F1D File Offset: 0x0000211D
			[global::Cpp2ILInjected.Token(Token = "0x60002DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD0668", Offset = "0x1CD0668", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object[])
			}, ReturnType = typeof(object))]
			internal object <CreateParameterizedConstructor>b__1(object[] a)
			{
				throw null;
			}

			// Token: 0x04000381 RID: 897
			[global::Cpp2ILInjected.Token(Token = "0x400017F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public ConstructorInfo c;

			// Token: 0x04000382 RID: 898
			[global::Cpp2ILInjected.Token(Token = "0x4000180")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public MethodBase method;
		}

		// Token: 0x020000F7 RID: 247
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000047")]
		private sealed class <>c__DisplayClass4_0<T>
		{
			// Token: 0x06000A8C RID: 2700 RVA: 0x00003F20 File Offset: 0x00002120
			[global::Cpp2ILInjected.Token(Token = "0x60002DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B326C", Offset = "0x15B326C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass4_0()
			{
				throw null;
			}

			// Token: 0x06000A8D RID: 2701 RVA: 0x00003F23 File Offset: 0x00002123
			[global::Cpp2ILInjected.Token(Token = "0x60002DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B3274", Offset = "0x15B3274", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(object))]
			internal object <CreateMethodCall>b__0(T o, object[] a)
			{
				throw null;
			}

			// Token: 0x06000A8E RID: 2702 RVA: 0x00003F26 File Offset: 0x00002126
			[global::Cpp2ILInjected.Token(Token = "0x60002E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B3284", Offset = "0x15B3284", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object[])
			}, ReturnType = typeof(object))]
			internal object <CreateMethodCall>b__1(T o, object[] a)
			{
				throw null;
			}

			// Token: 0x04000383 RID: 899
			[global::Cpp2ILInjected.Token(Token = "0x4000181")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public ConstructorInfo c;

			// Token: 0x04000384 RID: 900
			[global::Cpp2ILInjected.Token(Token = "0x4000182")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public MethodBase method;
		}

		// Token: 0x020000F8 RID: 248
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000048")]
		private sealed class <>c__DisplayClass5_0<T>
		{
			// Token: 0x06000A8F RID: 2703 RVA: 0x00003F29 File Offset: 0x00002129
			[global::Cpp2ILInjected.Token(Token = "0x60002E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B3978", Offset = "0x15B3978", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass5_0()
			{
				throw null;
			}

			// Token: 0x06000A90 RID: 2704 RVA: 0x00003F2C File Offset: 0x0000212C
			[global::Cpp2ILInjected.Token(Token = "0x60002E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B3980", Offset = "0x15B3980", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal T <CreateDefaultConstructor>b__0()
			{
				throw null;
			}

			// Token: 0x06000A91 RID: 2705 RVA: 0x00003F2F File Offset: 0x0000212F
			[global::Cpp2ILInjected.Token(Token = "0x60002E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B39EC", Offset = "0x15B39EC", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal T <CreateDefaultConstructor>b__1()
			{
				throw null;
			}

			// Token: 0x04000385 RID: 901
			[global::Cpp2ILInjected.Token(Token = "0x4000183")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public Type type;

			// Token: 0x04000386 RID: 902
			[global::Cpp2ILInjected.Token(Token = "0x4000184")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public ConstructorInfo constructorInfo;
		}

		// Token: 0x020000F9 RID: 249
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000049")]
		private sealed class <>c__DisplayClass6_0<T>
		{
			// Token: 0x06000A92 RID: 2706 RVA: 0x00003F32 File Offset: 0x00002132
			[global::Cpp2ILInjected.Token(Token = "0x60002E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B4140", Offset = "0x15B4140", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass6_0()
			{
				throw null;
			}

			// Token: 0x06000A93 RID: 2707 RVA: 0x00003F35 File Offset: 0x00002135
			[global::Cpp2ILInjected.Token(Token = "0x60002E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B4148", Offset = "0x15B4148", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal object <CreateGet>b__0(T o)
			{
				throw null;
			}

			// Token: 0x04000387 RID: 903
			[global::Cpp2ILInjected.Token(Token = "0x4000185")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public PropertyInfo propertyInfo;
		}

		// Token: 0x020000FA RID: 250
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200004A")]
		private sealed class <>c__DisplayClass7_0<T>
		{
			// Token: 0x06000A94 RID: 2708 RVA: 0x00003F38 File Offset: 0x00002138
			[global::Cpp2ILInjected.Token(Token = "0x60002E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B41E4", Offset = "0x15B41E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass7_0()
			{
				throw null;
			}

			// Token: 0x06000A95 RID: 2709 RVA: 0x00003F3B File Offset: 0x0000213B
			[global::Cpp2ILInjected.Token(Token = "0x60002E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B41EC", Offset = "0x15B41EC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal object <CreateGet>b__0(T o)
			{
				throw null;
			}

			// Token: 0x04000388 RID: 904
			[global::Cpp2ILInjected.Token(Token = "0x4000186")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public FieldInfo fieldInfo;
		}

		// Token: 0x020000FB RID: 251
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200004B")]
		private sealed class <>c__DisplayClass8_0<T>
		{
			// Token: 0x06000A96 RID: 2710 RVA: 0x00003F3E File Offset: 0x0000213E
			[global::Cpp2ILInjected.Token(Token = "0x60002E8")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B4588", Offset = "0x15B4588", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass8_0()
			{
				throw null;
			}

			// Token: 0x06000A97 RID: 2711 RVA: 0x00003F41 File Offset: 0x00002141
			[global::Cpp2ILInjected.Token(Token = "0x60002E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B4590", Offset = "0x15B4590", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FieldInfo), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			internal void <CreateSet>b__0(T o, object v)
			{
				throw null;
			}

			// Token: 0x04000389 RID: 905
			[global::Cpp2ILInjected.Token(Token = "0x4000187")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public FieldInfo fieldInfo;
		}

		// Token: 0x020000FC RID: 252
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200004C")]
		private sealed class <>c__DisplayClass9_0<T>
		{
			// Token: 0x06000A98 RID: 2712 RVA: 0x00003F44 File Offset: 0x00002144
			[global::Cpp2ILInjected.Token(Token = "0x60002EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B45D0", Offset = "0x15B45D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass9_0()
			{
				throw null;
			}

			// Token: 0x06000A99 RID: 2713 RVA: 0x00003F47 File Offset: 0x00002147
			[global::Cpp2ILInjected.Token(Token = "0x60002EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B45D8", Offset = "0x15B45D8", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void <CreateSet>b__0(T o, object v)
			{
				throw null;
			}

			// Token: 0x0400038A RID: 906
			[global::Cpp2ILInjected.Token(Token = "0x4000188")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public PropertyInfo propertyInfo;
		}
	}
}
