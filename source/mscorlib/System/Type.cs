using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono;

namespace System
{
	// Token: 0x020000DE RID: 222
	[global::Cpp2ILInjected.Token(Token = "0x2000110")]
	[global::System.Serializable]
	public abstract class Type : global::System.Reflection.MemberInfo
	{
		// Token: 0x06000961 RID: 2401 RVA: 0x00016082 File Offset: 0x00014282
		[global::Cpp2ILInjected.Token(Token = "0x6000A09")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4C9AC", Offset = "0x1C4C9AC", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "IsIntegerType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetEnumData", MemberParameters = new object[]
		{
			typeof(ref string[]),
			typeof(ref global::System.Array)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "BinarySearch", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public virtual bool IsEnumDefined(object value)
		{
			throw null;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00016085 File Offset: 0x00014285
		[global::Cpp2ILInjected.Token(Token = "0x6000A0A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4D0D4", Offset = "0x1C4D0D4", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "IsIntegerType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetEnumData", MemberParameters = new object[]
		{
			typeof(ref string[]),
			typeof(ref global::System.Array)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "BinarySearch", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public virtual string GetEnumName(object value)
		{
			throw null;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00016088 File Offset: 0x00014288
		[global::Cpp2ILInjected.Token(Token = "0x6000A0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4D2A8", Offset = "0x1C4D2A8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetEnumData", MemberParameters = new object[]
		{
			typeof(ref string[]),
			typeof(ref global::System.Array)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual string[] GetEnumNames()
		{
			throw null;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x0001608B File Offset: 0x0001428B
		[global::Cpp2ILInjected.Token(Token = "0x6000A0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4CF90", Offset = "0x1C4CF90", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetEnumData", MemberParameters = new object[]
		{
			typeof(ref string[]),
			typeof(ref global::System.Array)
		}, ReturnType = typeof(void))]
		private global::System.Array GetEnumRawConstantValues()
		{
			throw null;
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0001608E File Offset: 0x0001428E
		[global::Cpp2ILInjected.Token(Token = "0x6000A0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4D34C", Offset = "0x1C4D34C", Length = "0x304")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "IsEnumDefined", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "GetEnumName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "GetEnumNames", ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "GetEnumRawConstantValues", ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.Comparer<object>), Member = "get_Default", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void GetEnumData(out string[] enumNames, out global::System.Array enumValues)
		{
			throw null;
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00016091 File Offset: 0x00014291
		[global::Cpp2ILInjected.Token(Token = "0x6000A0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4CFB4", Offset = "0x1C4CFB4", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "IsEnumDefined", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "GetEnumName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Enum), Member = "ToUInt64", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array[]), Member = "BinarySearch", MemberTypeParameters = new object[] { typeof(ulong) }, MemberParameters = new object[]
		{
			typeof(ulong[]),
			typeof(ulong)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static int BinarySearch(global::System.Array array, object value)
		{
			throw null;
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00016094 File Offset: 0x00014294
		[global::Cpp2ILInjected.Token(Token = "0x6000A0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4CD10", Offset = "0x1C4CD10", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "IsEnumDefined", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "GetEnumName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsEnumDefined", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEnumName", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal static bool IsIntegerType(global::System.Type t)
		{
			throw null;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00016097 File Offset: 0x00014297
		[global::Cpp2ILInjected.Token(Token = "0x170000BD")]
		public virtual bool IsSerializable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A10")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4D80C", Offset = "0x1C4D80C", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "IsRuntimeImplemented", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x0001609A File Offset: 0x0001429A
		[global::Cpp2ILInjected.Token(Token = "0x170000BE")]
		public virtual bool ContainsGenericParameters
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A11")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4D9D8", Offset = "0x1C4D9D8", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetRootElementType", ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0001609D File Offset: 0x0001429D
		[global::Cpp2ILInjected.Token(Token = "0x6000A12")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4DAC4", Offset = "0x1C4DAC4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "get_ContainsGenericParameters", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FormatTypeName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceCheckThis", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceMono", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "get_FullName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UnitySerializationHolder), Member = "GetUnitySerializationInfo", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		internal global::System.Type GetRootElementType()
		{
			throw null;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x000160A0 File Offset: 0x000142A0
		[global::Cpp2ILInjected.Token(Token = "0x170000BF")]
		public bool IsVisible
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A13")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4DB04", Offset = "0x1C4DB04", Length = "0x15C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.CryptoConfig), Member = "AddAlgorithm", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(string[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.SecurityUtils", Member = "SecureCreateInstance", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				"System.Object[]",
				typeof(bool)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				"System.Type[]",
				"System.Object[]",
				typeof(bool),
				typeof(global::System.Reflection.BindingFlags)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.SecurityUtils", Member = "GenericArgumentsAreVisible", MemberParameters = new object[] { typeof(global::System.Reflection.MethodInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.SecurityUtils", Member = "MethodInfoInvoke", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.MethodInfo),
				typeof(object),
				"System.Object[]"
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.TypeExtensions", Member = "IsVisible", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsNested", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000160A3 File Offset: 0x000142A3
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000A14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4DD20", Offset = "0x1C4DD20", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool IsSubclassOf(global::System.Type c)
		{
			throw null;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000160A6 File Offset: 0x000142A6
		[global::Cpp2ILInjected.Token(Token = "0x6000A15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4DDD8", Offset = "0x1C4DDD8", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "IsRuntimeImplemented", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "ImplementInterface", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual bool IsAssignableFrom(global::System.Type c)
		{
			throw null;
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000160A9 File Offset: 0x000142A9
		[global::Cpp2ILInjected.Token(Token = "0x6000A16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4E024", Offset = "0x1C4E024", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "IsAssignableFrom", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "ImplementInterface", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "ImplementInterface", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal bool ImplementInterface(global::System.Type ifaceType)
		{
			throw null;
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x000160AC File Offset: 0x000142AC
		[global::Cpp2ILInjected.Token(Token = "0x6000A17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4E140", Offset = "0x1C4E140", Length = "0x34C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.InvalidFilterCriteriaException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private static bool FilterAttributeImpl(global::System.Reflection.MemberInfo m, object filterCriteria)
		{
			throw null;
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x000160AF File Offset: 0x000142AF
		[global::Cpp2ILInjected.Token(Token = "0x6000A18")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4E48C", Offset = "0x1C4E48C", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.InvalidFilterCriteriaException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool FilterNameImpl(global::System.Reflection.MemberInfo m, object filterCriteria)
		{
			throw null;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000160B2 File Offset: 0x000142B2
		[global::Cpp2ILInjected.Token(Token = "0x6000A19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4E5F0", Offset = "0x1C4E5F0", Length = "0x17C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.InvalidFilterCriteriaException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static bool FilterNameIgnoreCaseImpl(global::System.Reflection.MemberInfo m, object filterCriteria)
		{
			throw null;
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000160B5 File Offset: 0x000142B5
		[global::Cpp2ILInjected.Token(Token = "0x6000A1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4E76C", Offset = "0x1C4E76C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.SignatureType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.TypeInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MemberInfo), Member = ".ctor", ReturnType = typeof(void))]
		protected Type()
		{
			throw null;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x000160B8 File Offset: 0x000142B8
		[global::Cpp2ILInjected.Token(Token = "0x170000C0")]
		public override global::System.Reflection.MemberTypes MemberType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A1B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4E774", Offset = "0x1C4E774", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x000160BB File Offset: 0x000142BB
		[global::Cpp2ILInjected.Token(Token = "0x6000A1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4E77C", Offset = "0x1C4E77C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceDefaultCtor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "MakePointerType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "GetParentTypes", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(ref global::System.RuntimeType[]),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptionProvider", Member = "GetRuntimeType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		public new global::System.Type GetType()
		{
			throw null;
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000975 RID: 2421
		[global::Cpp2ILInjected.Token(Token = "0x170000C1")]
		public abstract string Namespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A1D")]
			get;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000976 RID: 2422
		[global::Cpp2ILInjected.Token(Token = "0x170000C2")]
		public abstract string AssemblyQualifiedName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A1E")]
			get;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000977 RID: 2423
		[global::Cpp2ILInjected.Token(Token = "0x170000C3")]
		public abstract string FullName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A1F")]
			get;
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000978 RID: 2424
		[global::Cpp2ILInjected.Token(Token = "0x170000C4")]
		public abstract global::System.Reflection.Assembly Assembly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A20")]
			get;
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000979 RID: 2425
		[global::Cpp2ILInjected.Token(Token = "0x170000C5")]
		public new abstract global::System.Reflection.Module Module
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A21")]
			get;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x000160BE File Offset: 0x000142BE
		[global::Cpp2ILInjected.Token(Token = "0x170000C6")]
		public bool IsNested
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A22")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4DC88", Offset = "0x1C4DC88", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "get_IsVisible", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FormatTypeName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x000160C1 File Offset: 0x000142C1
		[global::Cpp2ILInjected.Token(Token = "0x170000C7")]
		public override global::System.Type DeclaringType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A23")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4E784", Offset = "0x1C4E784", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x000160C4 File Offset: 0x000142C4
		[global::Cpp2ILInjected.Token(Token = "0x170000C8")]
		public virtual global::System.Reflection.MethodBase DeclaringMethod
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A24")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4E78C", Offset = "0x1C4E78C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x000160C7 File Offset: 0x000142C7
		[global::Cpp2ILInjected.Token(Token = "0x170000C9")]
		public override global::System.Type ReflectedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A25")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4E794", Offset = "0x1C4E794", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600097E RID: 2430
		[global::Cpp2ILInjected.Token(Token = "0x170000CA")]
		public abstract global::System.Type UnderlyingSystemType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A26")]
			get;
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x000160CA File Offset: 0x000142CA
		[global::Cpp2ILInjected.Token(Token = "0x170000CB")]
		public bool IsArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A27")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4E79C", Offset = "0x1C4E79C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000980 RID: 2432
		[global::Cpp2ILInjected.Token(Token = "0x6000A28")]
		protected abstract bool IsArrayImpl();

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x000160CD File Offset: 0x000142CD
		[global::Cpp2ILInjected.Token(Token = "0x170000CC")]
		public bool IsByRef
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A29")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4E7AC", Offset = "0x1C4E7AC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "BindToMethod", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.MethodBase[]),
				typeof(ref object[]),
				typeof(global::System.Reflection.ParameterModifier[]),
				typeof(global::System.Globalization.CultureInfo),
				typeof(string[]),
				typeof(ref object)
			}, ReturnType = typeof(global::System.Reflection.MethodBase))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "FindMostSpecificType", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "ThrowIfTypeNeverValidGenericArgument", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "TryConvertToType", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "MakeByRefType", ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "MakePointerType", ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UnitySerializationHolder), Member = "AddElementTypes", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Serialization.SerializationInfo),
				typeof(global::System.RuntimeType)
			}, ReturnType = typeof(global::System.RuntimeType))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "arg_type_match_this", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(object),
				typeof(global::System.Reflection.MethodInfo),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(global::System.Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "InternalExecuteMessage", MemberParameters = new object[]
			{
				typeof(global::System.MarshalByRefObject),
				typeof(global::System.Runtime.Remoting.Messaging.IMethodCallMessage)
			}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMethodReturnMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "ProcessResponse", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Remoting.Messaging.IMethodReturnMessage),
				typeof(global::System.Runtime.Remoting.Messaging.MonoMethodMessage)
			}, ReturnType = typeof(object[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.ArgInfo), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.MethodBase),
				typeof(global::System.Runtime.Remoting.Messaging.ArgInfoType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MonoMethodMessage), Member = "InitMessage", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.RuntimeMethodInfo),
				typeof(object[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.StackBuilderSink), Member = "CheckParameters", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Messaging.IMessage) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MethodBase), Member = "ConstructParameters", MemberParameters = new object[]
			{
				typeof(global::System.Type[]),
				typeof(global::System.Reflection.CallingConventions),
				typeof(bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.SignatureTypeExtensions), Member = "MatchesExactly", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.SignatureType),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.SignatureType),
				typeof(global::System.Type[])
			}, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeParameterInfo), Member = "FormatParameters", MemberParameters = new object[]
			{
				typeof(global::System.Text.StringBuilder),
				typeof(global::System.Reflection.ParameterInfo[]),
				typeof(global::System.Reflection.CallingConventions),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000982 RID: 2434
		[global::Cpp2ILInjected.Token(Token = "0x6000A2A")]
		protected abstract bool IsByRefImpl();

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x000160D0 File Offset: 0x000142D0
		[global::Cpp2ILInjected.Token(Token = "0x170000CD")]
		public unsafe bool IsPointer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4E7BC", Offset = "0x1C4E7BC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "ThrowIfTypeNeverValidGenericArgument", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "TryConvertToType", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UnitySerializationHolder), Member = "AddElementTypes", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Serialization.SerializationInfo),
				typeof(global::System.RuntimeType)
			}, ReturnType = typeof(global::System.RuntimeType))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Pointer), Member = "Box", MemberParameters = new object[]
			{
				typeof(void*),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.SignatureTypeExtensions), Member = "MatchesExactly", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.SignatureType),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.SignatureTypeExtensions), Member = "TryResolve", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.SignatureType),
				typeof(global::System.Type[])
			}, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000984 RID: 2436
		[global::Cpp2ILInjected.Token(Token = "0x6000A2C")]
		protected abstract bool IsPointerImpl();

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x000160D3 File Offset: 0x000142D3
		[global::Cpp2ILInjected.Token(Token = "0x170000CE")]
		public virtual bool IsConstructedGenericType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4E7CC", Offset = "0x1C4E7CC", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x000160D6 File Offset: 0x000142D6
		[global::Cpp2ILInjected.Token(Token = "0x170000CF")]
		public virtual bool IsGenericParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A2E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4E844", Offset = "0x1C4E844", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x000160D9 File Offset: 0x000142D9
		[global::Cpp2ILInjected.Token(Token = "0x170000D0")]
		public virtual bool IsGenericMethodParameter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A2F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4E84C", Offset = "0x1C4E84C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.MethodBase),
				typeof(global::System.Reflection.MethodBase)
			}, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x000160DC File Offset: 0x000142DC
		[global::Cpp2ILInjected.Token(Token = "0x170000D1")]
		public virtual bool IsGenericType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A30")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4E898", Offset = "0x1C4E898", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x000160DF File Offset: 0x000142DF
		[global::Cpp2ILInjected.Token(Token = "0x170000D2")]
		public virtual bool IsGenericTypeDefinition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A31")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4E8A0", Offset = "0x1C4E8A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x000160E2 File Offset: 0x000142E2
		[global::Cpp2ILInjected.Token(Token = "0x170000D3")]
		public virtual bool IsSZArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A32")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4E8A8", Offset = "0x1C4E8A8", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x000160E5 File Offset: 0x000142E5
		[global::Cpp2ILInjected.Token(Token = "0x170000D4")]
		public virtual bool IsVariableBoundArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A33")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4E8CC", Offset = "0x1C4E8CC", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x000160E8 File Offset: 0x000142E8
		[global::Cpp2ILInjected.Token(Token = "0x170000D5")]
		public bool HasElementType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A34")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4DAB4", Offset = "0x1C4DAB4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Activator), Member = "CreateInstance", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "get_ContainsGenericParameters", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.UnitySerializationHolder), Member = "AddElementTypes", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Serialization.SerializationInfo),
				typeof(global::System.RuntimeType)
			}, ReturnType = typeof(global::System.RuntimeType))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600098D RID: 2445
		[global::Cpp2ILInjected.Token(Token = "0x6000A35")]
		protected abstract bool HasElementTypeImpl();

		// Token: 0x0600098E RID: 2446
		[global::Cpp2ILInjected.Token(Token = "0x6000A36")]
		public abstract global::System.Type GetElementType();

		// Token: 0x0600098F RID: 2447 RVA: 0x000160EB File Offset: 0x000142EB
		[global::Cpp2ILInjected.Token(Token = "0x6000A37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4E914", Offset = "0x1C4E914", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual int GetArrayRank()
		{
			throw null;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x000160EE File Offset: 0x000142EE
		[global::Cpp2ILInjected.Token(Token = "0x6000A38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4E960", Offset = "0x1C4E960", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual global::System.Type GetGenericTypeDefinition()
		{
			throw null;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x000160F1 File Offset: 0x000142F1
		[global::Cpp2ILInjected.Token(Token = "0x170000D6")]
		public virtual global::System.Type[] GenericTypeArguments
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A39")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4E9AC", Offset = "0x1C4E9AC", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x000160F4 File Offset: 0x000142F4
		[global::Cpp2ILInjected.Token(Token = "0x6000A3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4EA78", Offset = "0x1C4EA78", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual global::System.Type[] GetGenericArguments()
		{
			throw null;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x000160F7 File Offset: 0x000142F7
		[global::Cpp2ILInjected.Token(Token = "0x170000D7")]
		public virtual int GenericParameterPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A3B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4EAC4", Offset = "0x1C4EAC4", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x000160FA File Offset: 0x000142FA
		[global::Cpp2ILInjected.Token(Token = "0x170000D8")]
		public virtual global::System.Reflection.GenericParameterAttributes GenericParameterAttributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A3C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4EB10", Offset = "0x1C4EB10", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x000160FD File Offset: 0x000142FD
		[global::Cpp2ILInjected.Token(Token = "0x6000A3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4EB48", Offset = "0x1C4EB48", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual global::System.Type[] GetGenericParameterConstraints()
		{
			throw null;
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00016100 File Offset: 0x00014300
		[global::Cpp2ILInjected.Token(Token = "0x170000D9")]
		public global::System.Reflection.TypeAttributes Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A3E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4EBC0", Offset = "0x1C4EBC0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributes", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Reflection.CustomAttributeData[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeTypeHandle), Member = "IsInterface", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetAttributes", ReturnType = "System.ComponentModel.AttributeCollection")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000997 RID: 2455
		[global::Cpp2ILInjected.Token(Token = "0x6000A3F")]
		protected abstract global::System.Reflection.TypeAttributes GetAttributeFlagsImpl();

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x00016103 File Offset: 0x00014303
		[global::Cpp2ILInjected.Token(Token = "0x170000DA")]
		public bool IsAbstract
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A40")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4EBD0", Offset = "0x1C4EBD0", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceMono", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.Binder),
				typeof(object[]),
				typeof(global::System.Globalization.CultureInfo)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Globalization.CultureInfo),
				typeof(global::System.Type),
				typeof(ref object)
			}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.TypeExtensions", Member = "IsAbstract", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x00016106 File Offset: 0x00014306
		[global::Cpp2ILInjected.Token(Token = "0x170000DB")]
		public bool IsSealed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A41")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4EBF0", Offset = "0x1C4EBF0", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.ICustomAttributeProvider),
				typeof(global::System.Type),
				typeof(bool)
			}, ReturnType = typeof(object[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.ICustomAttributeProvider),
				typeof(global::System.Type),
				typeof(bool)
			}, ReturnType = typeof(global::System.Collections.Generic.IList<global::System.Reflection.CustomAttributeData>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectWriter), Member = "WriteArrayMember", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo),
				typeof(global::System.Runtime.Serialization.Formatters.Binary.NameInfo),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.NameInfo), Member = "get_IsSealed", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.TypeExtensions", Member = "IsSealed", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonContainerContract", Member = "set_ItemContract", MemberParameters = new object[] { "Newtonsoft.Json.Serialization.JsonContract" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x00016109 File Offset: 0x00014309
		[global::Cpp2ILInjected.Token(Token = "0x170000DC")]
		public bool IsClass
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A42")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4EC10", Offset = "0x1C4EC10", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "SaveFields", MemberParameters = new object[]
			{
				typeof(global::System.IO.BinaryWriter),
				typeof(global::System.Type),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "LoadFields", MemberParameters = new object[]
			{
				typeof(global::System.IO.BinaryReader),
				typeof(global::System.Type),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "RefreshFields", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(object),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.ID.SetFactory", Member = "CreateCustomSet", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T", "System.Object[]" }, ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "BindToField", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.FieldInfo[]),
				typeof(object),
				typeof(global::System.Globalization.CultureInfo)
			}, ReturnType = typeof(global::System.Reflection.FieldInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "InheritsGenericDefinition", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type),
				typeof(ref global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.TypeExtensions", Member = "IsClass", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x0001610C File Offset: 0x0001430C
		[global::Cpp2ILInjected.Token(Token = "0x170000DD")]
		public bool IsNestedAssembly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A43")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4EC68", Offset = "0x1C4EC68", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FilterApplyType", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Reflection.BindingFlags),
				typeof(string),
				typeof(bool),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0001610F File Offset: 0x0001430F
		[global::Cpp2ILInjected.Token(Token = "0x170000DE")]
		public bool IsNestedPublic
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A44")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4DC60", Offset = "0x1C4DC60", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FilterApplyType", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Reflection.BindingFlags),
				typeof(string),
				typeof(bool),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetEvents", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = "System.ComponentModel.EventDescriptor[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00016112 File Offset: 0x00014312
		[global::Cpp2ILInjected.Token(Token = "0x170000DF")]
		public bool IsNotPublic
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A45")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4EC90", Offset = "0x1C4EC90", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "get_MemberType", ReturnType = typeof(global::System.Reflection.MemberTypes))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00016115 File Offset: 0x00014315
		[global::Cpp2ILInjected.Token(Token = "0x170000E0")]
		public bool IsPublic
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A46")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4DCF8", Offset = "0x1C4DCF8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "FilterApplyType", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Reflection.BindingFlags),
				typeof(string),
				typeof(bool),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "get_MemberType", ReturnType = typeof(global::System.Reflection.MemberTypes))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetEvents", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = "System.ComponentModel.EventDescriptor[]")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x00016118 File Offset: 0x00014318
		[global::Cpp2ILInjected.Token(Token = "0x170000E1")]
		public bool IsExplicitLayout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A47")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4ECB4", Offset = "0x1C4ECB4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.FieldInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.FieldInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(global::System.Reflection.CustomAttributeData[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0001611B File Offset: 0x0001431B
		[global::Cpp2ILInjected.Token(Token = "0x170000E2")]
		public bool IsCOMObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A48")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4ECDC", Offset = "0x1C4ECDC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "BindToMethod", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.MethodBase[]),
				typeof(ref object[]),
				typeof(global::System.Reflection.ParameterModifier[]),
				typeof(global::System.Globalization.CultureInfo),
				typeof(string[]),
				typeof(ref object)
			}, ReturnType = typeof(global::System.Reflection.MethodBase))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "NodeFor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(bool)
			}, ReturnType = "System.ComponentModel.TypeDescriptor.TypeDescriptionNode")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009A1 RID: 2465
		[global::Cpp2ILInjected.Token(Token = "0x6000A49")]
		protected abstract bool IsCOMObjectImpl();

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x0001611E File Offset: 0x0001431E
		[global::Cpp2ILInjected.Token(Token = "0x170000E3")]
		public bool IsContextful
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4ECEC", Offset = "0x1C4ECEC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "Unmarshal", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Remoting.ObjRef),
				typeof(bool)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "CreateClientProxyForContextBound", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(object[])
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "get_IsContextBoundObject", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "InCurrentContext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateConstructionCall", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(string),
				typeof(object[])
			}, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.ConstructionCall))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateInstanceFromMessage", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Messaging.IMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.ActivationServices), Member = "CreateProxyForType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Activation.RemoteActivator), Member = "Activate", MemberParameters = new object[] { typeof(global::System.Runtime.Remoting.Activation.IConstructionCallMessage) }, ReturnType = typeof(global::System.Runtime.Remoting.Activation.IConstructionReturnMessage))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00016121 File Offset: 0x00014321
		[global::Cpp2ILInjected.Token(Token = "0x6000A4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4ECFC", Offset = "0x1C4ECFC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual bool IsContextfulImpl()
		{
			throw null;
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x00016124 File Offset: 0x00014324
		[global::Cpp2ILInjected.Token(Token = "0x170000E4")]
		public virtual bool IsEnum
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A4C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4ED84", Offset = "0x1C4ED84", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00016127 File Offset: 0x00014327
		[global::Cpp2ILInjected.Token(Token = "0x170000E5")]
		public bool IsMarshalByRef
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A4D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4EE10", Offset = "0x1C4EE10", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.IntPtr),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.RemotingSurrogateSelector), Member = "GetSurrogate", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Runtime.Serialization.StreamingContext),
				typeof(ref global::System.Runtime.Serialization.ISurrogateSelector)
			}, ReturnType = typeof(global::System.Runtime.Serialization.ISerializationSurrogate))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0001612A File Offset: 0x0001432A
		[global::Cpp2ILInjected.Token(Token = "0x6000A4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4EE20", Offset = "0x1C4EE20", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual bool IsMarshalByRefImpl()
		{
			throw null;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0001612D File Offset: 0x0001432D
		[global::Cpp2ILInjected.Token(Token = "0x170000E6")]
		public bool IsPrimitive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4EEA8", Offset = "0x1C4EEA8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009A8 RID: 2472
		[global::Cpp2ILInjected.Token(Token = "0x6000A50")]
		protected abstract bool IsPrimitiveImpl();

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00016130 File Offset: 0x00014330
		[global::Cpp2ILInjected.Token(Token = "0x170000E7")]
		public bool IsValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A51")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4EC58", Offset = "0x1C4EC58", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 29)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00016133 File Offset: 0x00014333
		[global::Cpp2ILInjected.Token(Token = "0x6000A52")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4EEB8", Offset = "0x1C4EEB8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual bool IsValueTypeImpl()
		{
			throw null;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x00016136 File Offset: 0x00014336
		[global::Cpp2ILInjected.Token(Token = "0x170000E8")]
		public virtual bool IsSignatureType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A53")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4EF44", Offset = "0x1C4EF44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00016139 File Offset: 0x00014339
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000A54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4EF4C", Offset = "0x1C4EF4C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetConstructor", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.ConstructorInfo))]
		public global::System.Reflection.ConstructorInfo GetConstructor(global::System.Type[] types)
		{
			throw null;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0001613C File Offset: 0x0001433C
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000A55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4EF64", Offset = "0x1C4EF64", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "GetMethodBaseFromName", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMethodRef), Member = "Resolve", ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.SecurityUtils", Member = "SecureConstructorInvoke", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			"System.Type[]",
			"System.Object[]",
			typeof(bool),
			typeof(global::System.Reflection.BindingFlags)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.BindingList`1", Member = "get_ItemTypeHasDefaultConstructor", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "CreateISerializableContract", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = "Newtonsoft.Json.Serialization.JsonISerializableContract")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public global::System.Reflection.ConstructorInfo GetConstructor(global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.Binder binder, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
		{
			throw null;
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0001613F File Offset: 0x0001433F
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000A56")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4EF74", Offset = "0x1C4EF74", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(global::System.Type[]) }, ReturnType = typeof(global::System.Reflection.ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetSerializationCtor", ReturnType = typeof(global::System.Reflection.RuntimeConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public global::System.Reflection.ConstructorInfo GetConstructor(global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.Binder binder, global::System.Reflection.CallingConventions callConvention, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
		{
			throw null;
		}

		// Token: 0x060009AF RID: 2479
		[global::Cpp2ILInjected.Token(Token = "0x6000A57")]
		protected abstract global::System.Reflection.ConstructorInfo GetConstructorImpl(global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.Binder binder, global::System.Reflection.CallingConventions callConvention, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers);

		// Token: 0x060009B0 RID: 2480 RVA: 0x00016142 File Offset: 0x00014342
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000A58")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F094", Offset = "0x1C4F094", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "SetExtensionDataDelegates", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Serialization.JsonObjectContract",
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public global::System.Reflection.ConstructorInfo[] GetConstructors()
		{
			throw null;
		}

		// Token: 0x060009B1 RID: 2481
		[global::System.Runtime.InteropServices.ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000A59")]
		public abstract global::System.Reflection.ConstructorInfo[] GetConstructors(global::System.Reflection.BindingFlags bindingAttr);

		// Token: 0x060009B2 RID: 2482 RVA: 0x00016145 File Offset: 0x00014345
		[global::Cpp2ILInjected.Token(Token = "0x6000A5A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F0A8", Offset = "0x1C4F0A8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "FillMethods", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public global::System.Reflection.EventInfo GetEvent(string name)
		{
			throw null;
		}

		// Token: 0x060009B3 RID: 2483
		[global::Cpp2ILInjected.Token(Token = "0x6000A5B")]
		public abstract global::System.Reflection.EventInfo GetEvent(string name, global::System.Reflection.BindingFlags bindingAttr);

		// Token: 0x060009B4 RID: 2484
		[global::Cpp2ILInjected.Token(Token = "0x6000A5C")]
		public abstract global::System.Reflection.EventInfo[] GetEvents(global::System.Reflection.BindingFlags bindingAttr);

		// Token: 0x060009B5 RID: 2485 RVA: 0x00016148 File Offset: 0x00014348
		[global::Cpp2ILInjected.Token(Token = "0x6000A5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F0BC", Offset = "0x1C4F0BC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Utilities.AttributeUtilities", Member = "GetAttribute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(global::System.Enum) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetDllImportAttributeData", ReturnType = typeof(global::System.Reflection.CustomAttributeData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "SetIsSpecifiedActions", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Serialization.JsonProperty",
			typeof(global::System.Reflection.MemberInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public global::System.Reflection.FieldInfo GetField(string name)
		{
			throw null;
		}

		// Token: 0x060009B6 RID: 2486
		[global::Cpp2ILInjected.Token(Token = "0x6000A5E")]
		public abstract global::System.Reflection.FieldInfo GetField(string name, global::System.Reflection.BindingFlags bindingAttr);

		// Token: 0x060009B7 RID: 2487 RVA: 0x0001614B File Offset: 0x0001434B
		[global::Cpp2ILInjected.Token(Token = "0x6000A5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F0D0", Offset = "0x1C4F0D0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Reflection.IdDictionary", Member = "Create", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = "ReLogic.Reflection.IdDictionary")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "InitializeEnumType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = "Newtonsoft.Json.Utilities.BidirectionalDictionary`2<String, String>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "GetValues", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = "System.Collections.Generic.IList`1<Object>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.EnumUtils", Member = "GetNames", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = "System.Collections.Generic.IList`1<String>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public global::System.Reflection.FieldInfo[] GetFields()
		{
			throw null;
		}

		// Token: 0x060009B8 RID: 2488
		[global::Cpp2ILInjected.Token(Token = "0x6000A60")]
		public abstract global::System.Reflection.FieldInfo[] GetFields(global::System.Reflection.BindingFlags bindingAttr);

		// Token: 0x060009B9 RID: 2489 RVA: 0x0001614E File Offset: 0x0001434E
		[global::Cpp2ILInjected.Token(Token = "0x6000A61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F0E4", Offset = "0x1C4F0E4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ValueFixup), Member = "Fixup", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "FillAttributes", MemberParameters = new object[] { typeof(global::System.Collections.IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public global::System.Reflection.MemberInfo[] GetMember(string name)
		{
			throw null;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00016151 File Offset: 0x00014351
		[global::Cpp2ILInjected.Token(Token = "0x6000A62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F0F8", Offset = "0x1C4F0F8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual global::System.Reflection.MemberInfo[] GetMember(string name, global::System.Reflection.BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00016154 File Offset: 0x00014354
		[global::Cpp2ILInjected.Token(Token = "0x6000A63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F110", Offset = "0x1C4F110", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual global::System.Reflection.MemberInfo[] GetMember(string name, global::System.Reflection.MemberTypes type, global::System.Reflection.BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00016157 File Offset: 0x00014357
		[global::Cpp2ILInjected.Token(Token = "0x6000A64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F15C", Offset = "0x1C4F15C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(global::System.Reflection.MethodInfo),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "GetCandidateMethod", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MonoMethodMessage), Member = "GetMethodInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.HashSetConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(global::System.Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public global::System.Reflection.MethodInfo GetMethod(string name)
		{
			throw null;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0001615A File Offset: 0x0001435A
		[global::Cpp2ILInjected.Token(Token = "0x6000A65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F164", Offset = "0x1C4F164", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "LoadReleaseLayout", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "GetMethodBaseFromName", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "FindInterfaceMethod", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "LoadRemoteFieldNew", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.TransparentProxy), Member = "StoreRemoteField", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Channels.CrossAppDomainSink), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectEventDescriptor", Member = "FillSingleMethodAttribute", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MethodInfo),
			typeof(global::System.Collections.IList)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.SecureStringHasher", Member = "GetHashCodeDelegate", ReturnType = "System.Xml.SecureStringHasher.HashCodeOfStringDelegate")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlQualifiedName", Member = "GetHashCodeDelegate", ReturnType = "System.Xml.XmlQualifiedName.HashCodeOfStringDelegate")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUITargetAttribute", Member = "GetGUITargetAttrValue", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public global::System.Reflection.MethodInfo GetMethod(string name, global::System.Reflection.BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0001615D File Offset: 0x0001435D
		[global::Cpp2ILInjected.Token(Token = "0x6000A66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F1D8", Offset = "0x1C4F1D8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TimeSpanConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EnumConverter", Member = "ConvertTo", MemberParameters = new object[]
		{
			"System.ComponentModel.ITypeDescriptorContext",
			typeof(global::System.Globalization.CultureInfo),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MemberDescriptor", Member = "FindMethod", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			"System.Type[]",
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetExtendedProperties", MemberParameters = new object[] { "System.ComponentModel.IExtenderProvider" }, ReturnType = "System.ComponentModel.PropertyDescriptor[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "CreateCastConverter", MemberParameters = new object[] { "Newtonsoft.Json.Utilities.ConvertUtils.TypeConvertKey" }, ReturnType = "System.Func`2<Object, Object>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "SetExtensionDataDelegates", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Serialization.JsonObjectContract",
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "CreateShouldSerializeTest", MemberParameters = new object[] { typeof(global::System.Reflection.MemberInfo) }, ReturnType = "System.Predicate`1<Object>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ReflectionMethodsCache", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		public global::System.Reflection.MethodInfo GetMethod(string name, global::System.Type[] types)
		{
			throw null;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00016160 File Offset: 0x00014360
		[global::Cpp2ILInjected.Token(Token = "0x6000A67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F1F0", Offset = "0x1C4F1F0", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Reflection.CallingConventions),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		public global::System.Reflection.MethodInfo GetMethod(string name, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
		{
			throw null;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00016163 File Offset: 0x00014363
		[global::Cpp2ILInjected.Token(Token = "0x6000A68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F208", Offset = "0x1C4F208", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "GetCandidateMethod", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.Utils), Member = "DoesRsaKeyOverrideSlowPath", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Type[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "GetMethodBaseFromName", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "FindInterfaceMethod", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMethodRef), Member = "Resolve", ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.InteropServices.Marshal), Member = "GetCustomMarshalerInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string)
		}, ReturnType = typeof(global::System.Runtime.InteropServices.ICustomMarshaler))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.MemberDescriptor", Member = "FindMethod", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			"System.Type[]",
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "FillAttributes", MemberParameters = new object[] { typeof(global::System.Collections.IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Events.UnityEventBase", Member = "GetValidMethodInfo", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			"System.Type[]"
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.AndroidJavaProxy", Member = "Invoke", MemberParameters = new object[]
		{
			typeof(string),
			"System.Object[]"
		}, ReturnType = "UnityEngine.AndroidJavaObject")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		public global::System.Reflection.MethodInfo GetMethod(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.Binder binder, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
		{
			throw null;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00016166 File Offset: 0x00014366
		[global::Cpp2ILInjected.Token(Token = "0x6000A69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F218", Offset = "0x1C4F218", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public global::System.Reflection.MethodInfo GetMethod(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.Binder binder, global::System.Reflection.CallingConventions callConvention, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
		{
			throw null;
		}

		// Token: 0x060009C2 RID: 2498
		[global::Cpp2ILInjected.Token(Token = "0x6000A6A")]
		protected abstract global::System.Reflection.MethodInfo GetMethodImpl(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.Binder binder, global::System.Reflection.CallingConventions callConvention, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers);

		// Token: 0x060009C3 RID: 2499 RVA: 0x00016169 File Offset: 0x00014369
		[global::Cpp2ILInjected.Token(Token = "0x6000A6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F364", Offset = "0x1C4F364", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "ForceJITOnAssembly", MemberParameters = new object[] { typeof(global::System.Reflection.Assembly) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMethodRef), Member = "Resolve", ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public global::System.Reflection.MethodInfo[] GetMethods()
		{
			throw null;
		}

		// Token: 0x060009C4 RID: 2500
		[global::Cpp2ILInjected.Token(Token = "0x6000A6C")]
		public abstract global::System.Reflection.MethodInfo[] GetMethods(global::System.Reflection.BindingFlags bindingAttr);

		// Token: 0x060009C5 RID: 2501
		[global::Cpp2ILInjected.Token(Token = "0x6000A6D")]
		public abstract global::System.Type GetNestedType(string name, global::System.Reflection.BindingFlags bindingAttr);

		// Token: 0x060009C6 RID: 2502 RVA: 0x0001616C File Offset: 0x0001436C
		[global::Cpp2ILInjected.Token(Token = "0x6000A6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F378", Offset = "0x1C4F378", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultContractResolver", Member = "SetIsSpecifiedActions", MemberParameters = new object[]
		{
			"Newtonsoft.Json.Serialization.JsonProperty",
			typeof(global::System.Reflection.MemberInfo),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public global::System.Reflection.PropertyInfo GetProperty(string name)
		{
			throw null;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0001616F File Offset: 0x0001436F
		[global::Cpp2ILInjected.Token(Token = "0x6000A6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F380", Offset = "0x1C4F380", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Utilities.CrashWatcher", Member = "PrintException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.DependencyInjector), Member = "ReflectionLoad", ReturnType = typeof(global::Mono.ISystemDependencyProvider))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.CustomAttributeNamedArgument), Member = "get_MemberInfo", ReturnType = typeof(global::System.Reflection.MemberInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ComponentResourceManager", Member = "ApplyResources", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public global::System.Reflection.PropertyInfo GetProperty(string name, global::System.Reflection.BindingFlags bindingAttr)
		{
			throw null;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00016172 File Offset: 0x00014372
		[global::Cpp2ILInjected.Token(Token = "0x6000A70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F3F4", Offset = "0x1C4F3F4", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBasePropertyDefinition", MemberParameters = new object[] { typeof(global::System.Reflection.RuntimePropertyInfo) }, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public global::System.Reflection.PropertyInfo GetProperty(string name, global::System.Type returnType)
		{
			throw null;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00016175 File Offset: 0x00014375
		[global::Cpp2ILInjected.Token(Token = "0x6000A71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F4EC", Offset = "0x1C4F4EC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetBasePropertyDefinition", MemberParameters = new object[] { typeof(global::System.Reflection.RuntimePropertyInfo) }, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetProperty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Type),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		public global::System.Reflection.PropertyInfo GetProperty(string name, global::System.Type returnType, global::System.Type[] types)
		{
			throw null;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00016178 File Offset: 0x00014378
		[global::Cpp2ILInjected.Token(Token = "0x6000A72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F504", Offset = "0x1C4F504", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public global::System.Reflection.PropertyInfo GetProperty(string name, global::System.Type returnType, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
		{
			throw null;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0001617B File Offset: 0x0001437B
		[global::Cpp2ILInjected.Token(Token = "0x6000A73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F51C", Offset = "0x1C4F51C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "GetProperty", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type),
			typeof(global::System.Type[])
		}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "get_GetMethodValue", ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "get_SetMethodValue", ReturnType = typeof(global::System.Reflection.MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectPropertyDescriptor", Member = "FillAttributes", MemberParameters = new object[] { typeof(global::System.Collections.IList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetMemberInfoFromType", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(global::System.Reflection.MemberInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public global::System.Reflection.PropertyInfo GetProperty(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.Binder binder, global::System.Type returnType, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers)
		{
			throw null;
		}

		// Token: 0x060009CC RID: 2508
		[global::Cpp2ILInjected.Token(Token = "0x6000A74")]
		protected abstract global::System.Reflection.PropertyInfo GetPropertyImpl(string name, global::System.Reflection.BindingFlags bindingAttr, global::System.Reflection.Binder binder, global::System.Type returnType, global::System.Type[] types, global::System.Reflection.ParameterModifier[] modifiers);

		// Token: 0x060009CD RID: 2509
		[global::Cpp2ILInjected.Token(Token = "0x6000A75")]
		public abstract global::System.Reflection.PropertyInfo[] GetProperties(global::System.Reflection.BindingFlags bindingAttr);

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0001617E File Offset: 0x0001437E
		[global::Cpp2ILInjected.Token(Token = "0x170000E9")]
		public virtual global::System.RuntimeTypeHandle TypeHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A76")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4F5A4", Offset = "0x1C4F5A4", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00016181 File Offset: 0x00014381
		[global::Cpp2ILInjected.Token(Token = "0x6000A77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F5DC", Offset = "0x1C4F5DC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeTypeHandle), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static global::System.RuntimeTypeHandle GetTypeHandle(object o)
		{
			throw null;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00016184 File Offset: 0x00014384
		[global::Cpp2ILInjected.Token(Token = "0x6000A78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F64C", Offset = "0x1C4F64C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "GetTypeCodeImpl", ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "CanConvertPrimitive", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "CanPrimitiveWiden", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "IsConvertibleToPrimitiveType", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMessageBase), Member = "UnmarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.Converter), Member = "ToCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Runtime.Serialization.Formatters.Binary.InternalPrimitiveTypeE))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<, >), Member = "IsValueWriteAtomic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.EqualityComparer<>), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.EnumEqualityComparer<>), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static global::System.TypeCode GetTypeCode(global::System.Type type)
		{
			throw null;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00016187 File Offset: 0x00014387
		[global::Cpp2ILInjected.Token(Token = "0x6000A79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F6C4", Offset = "0x1C4F6C4", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeCode", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.TypeCode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual global::System.TypeCode GetTypeCodeImpl()
		{
			throw null;
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060009D2 RID: 2514
		[global::Cpp2ILInjected.Token(Token = "0x170000EA")]
		public abstract global::System.Type BaseType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A7A")]
			get;
		}

		// Token: 0x060009D3 RID: 2515
		[global::Cpp2ILInjected.Token(Token = "0x6000A7B")]
		public abstract object InvokeMember(string name, global::System.Reflection.BindingFlags invokeAttr, global::System.Reflection.Binder binder, object target, object[] args, global::System.Reflection.ParameterModifier[] modifiers, global::System.Globalization.CultureInfo culture, string[] namedParameters);

		// Token: 0x060009D4 RID: 2516
		[global::Cpp2ILInjected.Token(Token = "0x6000A7C")]
		public abstract global::System.Type[] GetInterfaces();

		// Token: 0x060009D5 RID: 2517 RVA: 0x0001618A File Offset: 0x0001438A
		[global::Cpp2ILInjected.Token(Token = "0x6000A7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F7AC", Offset = "0x1C4F7AC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual bool IsInstanceOfType(object o)
		{
			throw null;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0001618D File Offset: 0x0001438D
		[global::Cpp2ILInjected.Token(Token = "0x6000A7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F7E8", Offset = "0x1C4F7E8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual bool IsEquivalentTo(global::System.Type other)
		{
			throw null;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00016190 File Offset: 0x00014390
		[global::Cpp2ILInjected.Token(Token = "0x6000A7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F84C", Offset = "0x1C4F84C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public virtual global::System.Type GetEnumUnderlyingType()
		{
			throw null;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00016193 File Offset: 0x00014393
		[global::Cpp2ILInjected.Token(Token = "0x6000A80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F92C", Offset = "0x1C4F92C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplemented), Member = "get_ByDesign", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual global::System.Array GetEnumValues()
		{
			throw null;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00016196 File Offset: 0x00014396
		[global::Cpp2ILInjected.Token(Token = "0x6000A81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F9B0", Offset = "0x1C4F9B0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual global::System.Type MakeArrayType()
		{
			throw null;
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00016199 File Offset: 0x00014399
		[global::Cpp2ILInjected.Token(Token = "0x6000A82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4F9E8", Offset = "0x1C4F9E8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual global::System.Type MakeArrayType(int rank)
		{
			throw null;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x0001619C File Offset: 0x0001439C
		[global::Cpp2ILInjected.Token(Token = "0x6000A83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4FA20", Offset = "0x1C4FA20", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual global::System.Type MakeByRefType()
		{
			throw null;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x0001619F File Offset: 0x0001439F
		[global::Cpp2ILInjected.Token(Token = "0x6000A84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4FA58", Offset = "0x1C4FA58", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual global::System.Type MakeGenericType(params global::System.Type[] typeArguments)
		{
			throw null;
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x000161A2 File Offset: 0x000143A2
		[global::Cpp2ILInjected.Token(Token = "0x6000A85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4FAA4", Offset = "0x1C4FAA4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual global::System.Type MakePointerType()
		{
			throw null;
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x000161A5 File Offset: 0x000143A5
		[global::Cpp2ILInjected.Token(Token = "0x6000A86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4FADC", Offset = "0x1C4FADC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "MakeGenericType", MemberParameters = new object[] { typeof(global::System.Type[]) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.SignatureConstructedGenericType), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.Type MakeGenericSignatureType(global::System.Type genericTypeDefinition, params global::System.Type[] typeArguments)
		{
			throw null;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x000161A8 File Offset: 0x000143A8
		[global::Cpp2ILInjected.Token(Token = "0x6000A87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4FB48", Offset = "0x1C4FB48", Length = "0x60")]
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

		// Token: 0x060009E0 RID: 2528 RVA: 0x000161AB File Offset: 0x000143AB
		[global::Cpp2ILInjected.Token(Token = "0x6000A88")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4FBA8", Offset = "0x1C4FBA8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object o)
		{
			throw null;
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x000161AE File Offset: 0x000143AE
		[global::Cpp2ILInjected.Token(Token = "0x6000A89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4FC44", Offset = "0x1C4FC44", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MemberInfo), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x000161B1 File Offset: 0x000143B1
		[global::Cpp2ILInjected.Token(Token = "0x6000A8A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4FC84", Offset = "0x1C4FC84", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual bool Equals(global::System.Type o)
		{
			throw null;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060009E3 RID: 2531 RVA: 0x000161B4 File Offset: 0x000143B4
		[global::Cpp2ILInjected.Token(Token = "0x170000EB")]
		public static global::System.Reflection.Binder DefaultBinder
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A8B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4FD24", Offset = "0x1C4FD24", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetConstructorImpl", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.Binder),
				typeof(global::System.Reflection.CallingConventions),
				typeof(global::System.Type[]),
				typeof(global::System.Reflection.ParameterModifier[])
			}, ReturnType = typeof(global::System.Reflection.ConstructorInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertyImpl", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.Binder),
				typeof(global::System.Type),
				typeof(global::System.Type[]),
				typeof(global::System.Reflection.ParameterModifier[])
			}, ReturnType = typeof(global::System.Reflection.PropertyInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "InvokeMember", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.Binder),
				typeof(object),
				typeof(object[]),
				typeof(global::System.Reflection.ParameterModifier[]),
				typeof(global::System.Globalization.CultureInfo),
				typeof(string[])
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.Binder),
				typeof(object[]),
				typeof(global::System.Globalization.CultureInfo),
				typeof(object[]),
				typeof(ref global::System.Threading.StackCrawlMark)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "CheckValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Reflection.Binder),
				typeof(global::System.Globalization.CultureInfo),
				typeof(global::System.Reflection.BindingFlags)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.Binder),
				typeof(global::System.Reflection.CallingConventions),
				typeof(global::System.Type[]),
				typeof(global::System.Reflection.ParameterModifier[])
			}, ReturnType = typeof(global::System.Reflection.MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = ".cctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.FieldInfo), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(object),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.Binder),
				typeof(global::System.Globalization.CultureInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "Invoke", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.Binder),
				typeof(object[]),
				typeof(global::System.Globalization.CultureInfo)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeConstructorInfo), Member = "DoInvoke", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.Reflection.Binder),
				typeof(object[]),
				typeof(global::System.Globalization.CultureInfo)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DefaultBinder), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x000161B7 File Offset: 0x000143B7
		[global::Cpp2ILInjected.Token(Token = "0x6000A8C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C43E9C", Offset = "0x1C43E9C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1999)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static global::System.Type GetTypeFromHandle(global::System.RuntimeTypeHandle handle)
		{
			throw null;
		}

		// Token: 0x060009E5 RID: 2533
		[global::Cpp2ILInjected.Token(Token = "0x6000A8D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4FDF4", Offset = "0x1C4FDF4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.Type internal_from_handle(global::System.IntPtr handle);

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x000161BA File Offset: 0x000143BA
		[global::Cpp2ILInjected.Token(Token = "0x170000EC")]
		internal virtual bool IsSzArray
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A8E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4FDF8", Offset = "0x1C4FDF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x000161BD File Offset: 0x000143BD
		[global::Cpp2ILInjected.Token(Token = "0x6000A8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4FE00", Offset = "0x1C4FE00", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.ParameterInfo), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal string FormatTypeName()
		{
			throw null;
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x000161C0 File Offset: 0x000143C0
		[global::Cpp2ILInjected.Token(Token = "0x6000A90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4FE14", Offset = "0x1C4FE14", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal virtual string FormatTypeName(bool serialization)
		{
			throw null;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x000161C3 File Offset: 0x000143C3
		[global::Cpp2ILInjected.Token(Token = "0x170000ED")]
		public bool IsInterface
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A91")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4DF60", Offset = "0x1C4DF60", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "IsAssignableFrom", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "CanAssignArrayElement", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetField", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags)
			}, ReturnType = typeof(global::System.Reflection.FieldInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetBaseType", ReturnType = typeof(global::System.RuntimeType))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.RemotingServices), Member = "GetMethodBaseFromName", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(string),
				typeof(global::System.Type[])
			}, ReturnType = typeof(global::System.Reflection.MethodBase))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.TypeInfo), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.IntPtr),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RealProxy), Member = "GetProxiedType", ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Proxies.RemotingProxy), Member = "CanCastTo", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.MethodCall), Member = "ResolveMethod", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "InternalGetSerializableMembers", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Reflection.MemberInfo[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.FormatterServices), Member = "GetParentTypes", MemberParameters = new object[]
			{
				typeof(global::System.RuntimeType),
				typeof(ref global::System.RuntimeType[]),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "SearchIntrinsicTable", MemberParameters = new object[]
			{
				typeof(global::System.Collections.Hashtable),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.TypeDescriptor", Member = "GetNodeForBaseType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.Globalization.CultureInfo),
				typeof(global::System.Type),
				typeof(ref object)
			}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "ImplementsGenericDefinition", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type),
				typeof(ref global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.ReflectionUtils", Member = "GetProperties", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Reflection.BindingFlags)
			}, ReturnType = "System.Collections.Generic.IEnumerable`1<PropertyInfo>")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.TypeExtensions", Member = "IsInterface", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 26)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.RuntimeType),
				typeof(global::System.RuntimeType)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "IsInterface", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x000161C6 File Offset: 0x000143C6
		[global::Cpp2ILInjected.Token(Token = "0x6000A92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4FE4C", Offset = "0x1C4FE4C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(8)]
		public static global::System.Type GetType(string typeName, bool throwOnError, bool ignoreCase)
		{
			throw null;
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x000161C9 File Offset: 0x000143C9
		[global::Cpp2ILInjected.Token(Token = "0x6000A93")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4FED8", Offset = "0x1C4FED8", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(8)]
		public static global::System.Type GetType(string typeName, bool throwOnError)
		{
			throw null;
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x000161CC File Offset: 0x000143CC
		[global::Cpp2ILInjected.Token(Token = "0x6000A94")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4FF58", Offset = "0x1C4FF58", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(8)]
		public static global::System.Type GetType(string typeName)
		{
			throw null;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x000161CF File Offset: 0x000143CF
		[global::Cpp2ILInjected.Token(Token = "0x6000A95")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4FFD4", Offset = "0x1C4FFD4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "GetSimplyNamedTypeFromAssembly", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.Assembly),
			typeof(string),
			typeof(ref global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeNameParser), Member = "GetType", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Func<global::System.Reflection.AssemblyName, global::System.Reflection.Assembly>),
			typeof(global::System.Func<global::System.Reflection.Assembly, string, bool, global::System.Type>),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(global::System.Type))]
		[MethodImpl(8)]
		public static global::System.Type GetType(string typeName, global::System.Func<global::System.Reflection.AssemblyName, global::System.Reflection.Assembly> assemblyResolver, global::System.Func<global::System.Reflection.Assembly, string, bool, global::System.Type> typeResolver, bool throwOnError)
		{
			throw null;
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x000161D2 File Offset: 0x000143D2
		[global::Cpp2ILInjected.Token(Token = "0x6000A96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4CD04", Offset = "0x1C4CD04", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1050)]
		public static bool operator ==(global::System.Type left, global::System.Type right)
		{
			throw null;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x000161D5 File Offset: 0x000143D5
		[global::Cpp2ILInjected.Token(Token = "0x6000A97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4D9CC", Offset = "0x1C4D9CC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 161)]
		public static bool operator !=(global::System.Type left, global::System.Type right)
		{
			throw null;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x000161D8 File Offset: 0x000143D8
		[global::Cpp2ILInjected.Token(Token = "0x170000EE")]
		internal string FullNameOrDefault
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A98")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4FFFC", Offset = "0x1C4FFFC", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x000161DB File Offset: 0x000143DB
		[global::Cpp2ILInjected.Token(Token = "0x6000A99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4D940", Offset = "0x1C4D940", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "get_IsSerializable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Type), Member = "IsAssignableFrom", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "SelectMethod", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.MethodBase[]),
			typeof(global::System.Type[]),
			typeof(global::System.Reflection.ParameterModifier[])
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.Pointer), Member = "Box", MemberParameters = new object[]
		{
			typeof(void*),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal unsafe bool IsRuntimeImplemented()
		{
			throw null;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x000161DE File Offset: 0x000143DE
		[global::Cpp2ILInjected.Token(Token = "0x6000A9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50118", Offset = "0x1C50118", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal virtual string InternalGetNameIfAvailable(ref global::System.Type rootCauseForFailure)
		{
			throw null;
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x000161E1 File Offset: 0x000143E1
		[global::Cpp2ILInjected.Token(Token = "0x170000EF")]
		internal string InternalNameIfAvailable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C500F4", Offset = "0x1C500F4", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x000161E4 File Offset: 0x000143E4
		[global::Cpp2ILInjected.Token(Token = "0x170000F0")]
		internal string NameOrDefault
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000A9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C50124", Offset = "0x1C50124", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x000161E7 File Offset: 0x000143E7
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000A9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50194", Offset = "0x1C50194", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MemberFilter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		static Type()
		{
			throw null;
		}

		// Token: 0x04000286 RID: 646
		[global::Cpp2ILInjected.Token(Token = "0x40003D8")]
		private static global::System.Reflection.Binder s_defaultBinder;

		// Token: 0x04000287 RID: 647
		[global::Cpp2ILInjected.Token(Token = "0x40003D9")]
		public static readonly char Delimiter;

		// Token: 0x04000288 RID: 648
		[global::Cpp2ILInjected.Token(Token = "0x40003DA")]
		public static readonly global::System.Type[] EmptyTypes;

		// Token: 0x04000289 RID: 649
		[global::Cpp2ILInjected.Token(Token = "0x40003DB")]
		public static readonly object Missing;

		// Token: 0x0400028A RID: 650
		[global::Cpp2ILInjected.Token(Token = "0x40003DC")]
		public static readonly global::System.Reflection.MemberFilter FilterAttribute;

		// Token: 0x0400028B RID: 651
		[global::Cpp2ILInjected.Token(Token = "0x40003DD")]
		public static readonly global::System.Reflection.MemberFilter FilterName;

		// Token: 0x0400028C RID: 652
		[global::Cpp2ILInjected.Token(Token = "0x40003DE")]
		public static readonly global::System.Reflection.MemberFilter FilterNameIgnoreCase;

		// Token: 0x0400028D RID: 653
		[global::Cpp2ILInjected.Token(Token = "0x40003DF")]
		private const global::System.Reflection.BindingFlags DefaultLookup = global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public;

		// Token: 0x0400028E RID: 654
		[global::Cpp2ILInjected.Token(Token = "0x40003E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.RuntimeTypeHandle _impl;

		// Token: 0x0400028F RID: 655
		[global::Cpp2ILInjected.Token(Token = "0x40003E1")]
		internal const string DefaultTypeNameWhenMissingMetadata = "UnknownType";
	}
}
