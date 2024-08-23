using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	[global::Cpp2ILInjected.Token(Token = "0x200000A")]
	internal class AndroidReflection
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00002233 File Offset: 0x00000433
		[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F60A74", Offset = "0x1F60A74", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Get", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Set", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_SetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new object[] { "ArrayType" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "ArrayType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		public static bool IsPrimitive(Type t)
		{
			throw null;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002236 File Offset: 0x00000436
		[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F60A7C", Offset = "0x1F60A7C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Get", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Set", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_SetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool IsAssignableFrom(Type t, Type from)
		{
			throw null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002239 File Offset: 0x00000439
		[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F60A8C", Offset = "0x1F60A8C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "GetStaticMethodID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "DeleteLocalRef", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature)
		{
			throw null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000223C File Offset: 0x0000043C
		[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F60B28", Offset = "0x1F60B28", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "GetMethodID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "DeleteLocalRef", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static IntPtr GetMethodID(string clazz, string methodName, string signature)
		{
			throw null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000223F File Offset: 0x0000043F
		[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F60BC4", Offset = "0x1F60BC4", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetConstructorID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "NewString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticObjectMethod", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(jvalue[])
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "DeleteLocalRef", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static IntPtr GetConstructorMember(IntPtr jclass, string signature)
		{
			throw null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002242 File Offset: 0x00000442
		[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F60CE0", Offset = "0x1F60CE0", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "NewString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticObjectMethod", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(jvalue[])
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "DeleteLocalRef", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic)
		{
			throw null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002245 File Offset: 0x00000445
		[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F60E3C", Offset = "0x1F60E3C", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "NewString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticObjectMethod", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(jvalue[])
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "DeleteLocalRef", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic)
		{
			throw null;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002248 File Offset: 0x00000448
		[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F60F98", Offset = "0x1F60F98", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CallObjectMethod", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(jvalue[])
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IntPtr GetFieldClass(IntPtr field)
		{
			throw null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000224B File Offset: 0x0000044B
		[global::Cpp2ILInjected.Token(Token = "0x60000AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F60FFC", Offset = "0x1F60FFC", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticStringMethod", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(jvalue[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string GetFieldSignature(IntPtr field)
		{
			throw null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000224E File Offset: 0x0000044E
		[global::Cpp2ILInjected.Token(Token = "0x60000AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F61094", Offset = "0x1F61094", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "CreateJavaProxy", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(AndroidJavaProxy)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "ToInt64", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticObjectMethod", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(jvalue[])
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static IntPtr NewProxyInstance(IntPtr delegateHandle, IntPtr interfaze)
		{
			throw null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002251 File Offset: 0x00000451
		[global::Cpp2ILInjected.Token(Token = "0x60000AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5E870", Offset = "0x1F5E870", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaProxy), Member = "Invoke", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(AndroidJavaObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "InvokeJavaProxyMethod", MemberParameters = new object[]
		{
			typeof(AndroidJavaProxy),
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "ToIntPtr", MemberParameters = new object[] { typeof(GCHandle) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "ToInt64", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CallStaticVoidMethod", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr),
			typeof(jvalue[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound)
		{
			throw null;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002254 File Offset: 0x00000454
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60000AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F61140", Offset = "0x1F61140", Length = "0x2A4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "FindClass", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GlobalJavaObjectRef), Member = ".ctor", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidReflection), Member = "GetStaticMethodID", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidReflection), Member = "GetMethodID", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		static AndroidReflection()
		{
			throw null;
		}

		// Token: 0x0400000C RID: 12
		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		private static readonly GlobalJavaObjectRef s_ReflectionHelperClass;

		// Token: 0x0400000D RID: 13
		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		private static readonly IntPtr s_ReflectionHelperGetConstructorID;

		// Token: 0x0400000E RID: 14
		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		private static readonly IntPtr s_ReflectionHelperGetMethodID;

		// Token: 0x0400000F RID: 15
		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		private static readonly IntPtr s_ReflectionHelperGetFieldID;

		// Token: 0x04000010 RID: 16
		[global::Cpp2ILInjected.Token(Token = "0x4000010")]
		private static readonly IntPtr s_ReflectionHelperGetFieldSignature;

		// Token: 0x04000011 RID: 17
		[global::Cpp2ILInjected.Token(Token = "0x4000011")]
		private static readonly IntPtr s_ReflectionHelperNewProxyInstance;

		// Token: 0x04000012 RID: 18
		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		private static readonly IntPtr s_ReflectionHelperSetNativeExceptionOnProxy;

		// Token: 0x04000013 RID: 19
		[global::Cpp2ILInjected.Token(Token = "0x4000013")]
		private static readonly IntPtr s_FieldGetDeclaringClass;
	}
}
