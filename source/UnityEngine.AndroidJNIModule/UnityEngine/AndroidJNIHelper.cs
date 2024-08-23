using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	[StaticAccessor("AndroidJNIBindingsHelpers", StaticAccessorType.DoubleColon)]
	[UsedByNativeCode]
	[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
	[NativeConditional("PLATFORM_ANDROID")]
	[global::Cpp2ILInjected.Token(Token = "0x200000D")]
	public static class AndroidJNIHelper
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000C6 RID: 198
		// (set) Token: 0x060000C7 RID: 199
		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		public static extern bool debug
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F647F8", Offset = "0x1F647F8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x60000C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F64820", Offset = "0x1F64820", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002299 File Offset: 0x00000499
		[global::Cpp2ILInjected.Token(Token = "0x60000C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6485C", Offset = "0x1F6485C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "GetConstructorID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static IntPtr GetConstructorID(IntPtr javaClass)
		{
			throw null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000229C File Offset: 0x0000049C
		[global::Cpp2ILInjected.Token(Token = "0x60000C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F63164", Offset = "0x1F63164", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "GetConstructorID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		public static IntPtr GetConstructorID(IntPtr javaClass, [DefaultValue(null)] string signature)
		{
			throw null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000229F File Offset: 0x0000049F
		[global::Cpp2ILInjected.Token(Token = "0x60000CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F648A4", Offset = "0x1F648A4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName)
		{
			throw null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000022A2 File Offset: 0x000004A2
		[global::Cpp2ILInjected.Token(Token = "0x60000CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64900", Offset = "0x1F64900", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, [DefaultValue(null)] string signature)
		{
			throw null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000022A5 File Offset: 0x000004A5
		[global::Cpp2ILInjected.Token(Token = "0x60000CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5F924", Offset = "0x1F5F924", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(object[]),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, [DefaultValue(null)] string signature, [DefaultValue("false")] bool isStatic)
		{
			throw null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000022A8 File Offset: 0x000004A8
		[global::Cpp2ILInjected.Token(Token = "0x60000CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64908", Offset = "0x1F64908", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName)
		{
			throw null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000022AB File Offset: 0x000004AB
		[global::Cpp2ILInjected.Token(Token = "0x60000CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6496C", Offset = "0x1F6496C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, [DefaultValue(null)] string signature)
		{
			throw null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000022AE File Offset: 0x000004AE
		[global::Cpp2ILInjected.Token(Token = "0x60000CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64964", Offset = "0x1F64964", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, [DefaultValue(null)] string signature, [DefaultValue("false")] bool isStatic)
		{
			throw null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000022B1 File Offset: 0x000004B1
		[global::Cpp2ILInjected.Token(Token = "0x60000D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F62834", Offset = "0x1F62834", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "CreateJavaRunnable", MemberParameters = new object[] { typeof(AndroidJavaRunnable) }, ReturnType = typeof(IntPtr))]
		public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
		{
			throw null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000022B4 File Offset: 0x000004B4
		[global::Cpp2ILInjected.Token(Token = "0x60000D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5F734", Offset = "0x1F5F734", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaProxy), Member = "GetRawProxy", ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "CreateJavaRunnable", MemberParameters = new object[] { typeof(AndroidJavaRunnable) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "ToIntPtr", MemberParameters = new object[] { typeof(GCHandle) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "CreateJavaProxy", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(AndroidJavaProxy)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy)
		{
			throw null;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000022B7 File Offset: 0x000004B7
		[global::Cpp2ILInjected.Token(Token = "0x60000D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64974", Offset = "0x1F64974", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Set", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_SetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(IntPtr))]
		public static IntPtr ConvertToJNIArray(Array array)
		{
			throw null;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000022BA File Offset: 0x000004BA
		[global::Cpp2ILInjected.Token(Token = "0x60000D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F606C4", Offset = "0x1F606C4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "CreateJNIArgArray", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(jvalue[]))]
		public static jvalue[] CreateJNIArgArray(object[] args)
		{
			throw null;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000022BD File Offset: 0x000004BD
		[global::Cpp2ILInjected.Token(Token = "0x60000D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64978", Offset = "0x1F64978", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "DeleteJNIArgArray", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(jvalue[])
		}, ReturnType = typeof(void))]
		public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs)
		{
			throw null;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000022C0 File Offset: 0x000004C0
		[global::Cpp2ILInjected.Token(Token = "0x60000D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F606C8", Offset = "0x1F606C8", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "GetSignature", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "GetConstructorID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		public static IntPtr GetConstructorID(IntPtr jclass, object[] args)
		{
			throw null;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000022C3 File Offset: 0x000004C3
		[global::Cpp2ILInjected.Token(Token = "0x60000D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F608CC", Offset = "0x1F608CC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "GetSignature", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			throw null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000022C6 File Offset: 0x000004C6
		[global::Cpp2ILInjected.Token(Token = "0x60000D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6497C", Offset = "0x1F6497C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "GetSignature", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		public static string GetSignature(object obj)
		{
			throw null;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000022C9 File Offset: 0x000004C9
		[global::Cpp2ILInjected.Token(Token = "0x60000D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F64980", Offset = "0x1F64980", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(_AndroidJNIHelper), Member = "GetSignature", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(string))]
		public static string GetSignature(object[] args)
		{
			throw null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000022CC File Offset: 0x000004CC
		[global::Cpp2ILInjected.Token(Token = "0x60000D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C7C10", Offset = "0x14C7C10", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
		{
			throw null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000022CF File Offset: 0x000004CF
		[global::Cpp2ILInjected.Token(Token = "0x60000DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C7CC8", Offset = "0x14C7CC8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic)
		{
			throw null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000022D2 File Offset: 0x000004D2
		[global::Cpp2ILInjected.Token(Token = "0x60000DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C7CA0", Offset = "0x14C7CA0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic)
		{
			throw null;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000022D5 File Offset: 0x000004D5
		[global::Cpp2ILInjected.Token(Token = "0x60000DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x14C7D7C", Offset = "0x14C7D7C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static string GetSignature<ReturnType>(object[] args)
		{
			throw null;
		}
	}
}
