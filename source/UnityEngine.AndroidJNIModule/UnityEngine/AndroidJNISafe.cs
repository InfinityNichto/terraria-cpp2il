using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[global::Cpp2ILInjected.Token(Token = "0x2000002")]
	internal class AndroidJNISafe
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[global::Cpp2ILInjected.Token(Token = "0x6000001")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57254", Offset = "0x1F57254", Length = "0x330")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 279)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "DeleteLocalRef", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		public static void CheckException()
		{
			throw null;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002053 File Offset: 0x00000253
		[global::Cpp2ILInjected.Token(Token = "0x6000002")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F577D4", Offset = "0x1F577D4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GlobalJavaObjectRef), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void DeleteGlobalRef(IntPtr globalref)
		{
			throw null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002056 File Offset: 0x00000256
		[global::Cpp2ILInjected.Token(Token = "0x6000003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5789C", Offset = "0x1F5789C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaProxy), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void DeleteWeakGlobalRef(IntPtr globalref)
		{
			throw null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002059 File Offset: 0x00000259
		[global::Cpp2ILInjected.Token(Token = "0x6000004")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57964", Offset = "0x1F57964", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_AndroidJavaObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = ".ctor", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "AndroidJavaObjectDeleteLocalRef", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(AndroidJavaObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "AndroidJavaClassDeleteLocalRef", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(AndroidJavaClass))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "FromJavaArrayDeleteLocalRef", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaClass), Member = "_AndroidJavaClass", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetStaticMethodID", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetMethodID", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetConstructorMember", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetMethodMember", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetFieldMember", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "DeleteJNIArgArray", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(jvalue[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new object[] { "ArrayType" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "ArrayType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetConstructorID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 47)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void DeleteLocalRef(IntPtr localref)
		{
			throw null;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000205C File Offset: 0x0000025C
		[global::Cpp2ILInjected.Token(Token = "0x6000005")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57A2C", Offset = "0x1F57A2C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetConstructorMember", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetMethodMember", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetFieldMember", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "CreateJNIArgArray", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(jvalue[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr NewString(string chars)
		{
			throw null;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000205F File Offset: 0x0000025F
		[global::Cpp2ILInjected.Token(Token = "0x6000006")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57B08", Offset = "0x1F57B08", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new object[] { "ArrayType" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "ArrayType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static string GetStringChars(IntPtr str)
		{
			throw null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002062 File Offset: 0x00000262
		[global::Cpp2ILInjected.Token(Token = "0x6000007")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57BE4", Offset = "0x1F57BE4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = ".ctor", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr GetObjectClass(IntPtr ptr)
		{
			throw null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002065 File Offset: 0x00000265
		[global::Cpp2ILInjected.Token(Token = "0x6000008")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57CC0", Offset = "0x1F57CC0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetStaticMethodID", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetMethodIDFallback", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
		{
			throw null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002068 File Offset: 0x00000268
		[global::Cpp2ILInjected.Token(Token = "0x6000009")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57D78", Offset = "0x1F57D78", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetMethodID", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetConstructorID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetMethodIDFallback", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr GetMethodID(IntPtr obj, string name, string sig)
		{
			throw null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000206B File Offset: 0x0000026B
		[global::Cpp2ILInjected.Token(Token = "0x600000A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57E30", Offset = "0x1F57E30", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr GetFieldID(IntPtr clazz, string name, string sig)
		{
			throw null;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000206E File Offset: 0x0000026E
		[global::Cpp2ILInjected.Token(Token = "0x600000B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F57F3C", Offset = "0x1F57F3C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetFieldID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig)
		{
			throw null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002071 File Offset: 0x00000271
		[global::Cpp2ILInjected.Token(Token = "0x600000C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58048", Offset = "0x1F58048", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetConstructorID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "GetMethodID", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr FromReflectedMethod(IntPtr refMethod)
		{
			throw null;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002074 File Offset: 0x00000274
		[global::Cpp2ILInjected.Token(Token = "0x600000D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58124", Offset = "0x1F58124", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaProxy), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_AndroidJavaObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaClass), Member = "_AndroidJavaClass", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetStaticMethodID", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetMethodID", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr FindClass(string name)
		{
			throw null;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002077 File Offset: 0x00000277
		[global::Cpp2ILInjected.Token(Token = "0x600000E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F581C4", Offset = "0x1F581C4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_AndroidJavaObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000207A File Offset: 0x0000027A
		[global::Cpp2ILInjected.Token(Token = "0x600000F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F582D0", Offset = "0x1F582D0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_SetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val)
		{
			throw null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000207D File Offset: 0x0000027D
		[global::Cpp2ILInjected.Token(Token = "0x6000010")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F583E0", Offset = "0x1F583E0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_SetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val)
		{
			throw null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002080 File Offset: 0x00000280
		[global::Cpp2ILInjected.Token(Token = "0x6000011")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F584F0", Offset = "0x1F584F0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_SetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val)
		{
			throw null;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002083 File Offset: 0x00000283
		[global::Cpp2ILInjected.Token(Token = "0x6000012")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58600", Offset = "0x1F58600", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_SetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val)
		{
			throw null;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002086 File Offset: 0x00000286
		[global::Cpp2ILInjected.Token(Token = "0x6000013")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58710", Offset = "0x1F58710", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_SetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val)
		{
			throw null;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002089 File Offset: 0x00000289
		[global::Cpp2ILInjected.Token(Token = "0x6000014")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58820", Offset = "0x1F58820", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_SetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val)
		{
			throw null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000208C File Offset: 0x0000028C
		[global::Cpp2ILInjected.Token(Token = "0x6000015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58930", Offset = "0x1F58930", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_SetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val)
		{
			throw null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000208F File Offset: 0x0000028F
		[global::Cpp2ILInjected.Token(Token = "0x6000016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58A40", Offset = "0x1F58A40", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_SetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val)
		{
			throw null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002092 File Offset: 0x00000292
		[global::Cpp2ILInjected.Token(Token = "0x6000017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58B50", Offset = "0x1F58B50", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_SetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val)
		{
			throw null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002095 File Offset: 0x00000295
		[global::Cpp2ILInjected.Token(Token = "0x6000018")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58C60", Offset = "0x1F58C60", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_SetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val)
		{
			throw null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002098 File Offset: 0x00000298
		[global::Cpp2ILInjected.Token(Token = "0x6000019")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58D70", Offset = "0x1F58D70", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000209B File Offset: 0x0000029B
		[global::Cpp2ILInjected.Token(Token = "0x600001A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58E5C", Offset = "0x1F58E5C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000209E File Offset: 0x0000029E
		[global::Cpp2ILInjected.Token(Token = "0x600001B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F58F48", Offset = "0x1F58F48", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020A1 File Offset: 0x000002A1
		[global::Cpp2ILInjected.Token(Token = "0x600001C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59034", Offset = "0x1F59034", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020A4 File Offset: 0x000002A4
		[global::Cpp2ILInjected.Token(Token = "0x600001D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5912C", Offset = "0x1F5912C", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020A7 File Offset: 0x000002A7
		[global::Cpp2ILInjected.Token(Token = "0x600001E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59224", Offset = "0x1F59224", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020AA File Offset: 0x000002AA
		[global::Cpp2ILInjected.Token(Token = "0x600001F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59310", Offset = "0x1F59310", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000020AD File Offset: 0x000002AD
		[global::Cpp2ILInjected.Token(Token = "0x6000020")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F593FC", Offset = "0x1F593FC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020B0 File Offset: 0x000002B0
		[global::Cpp2ILInjected.Token(Token = "0x6000021")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F594E8", Offset = "0x1F594E8", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020B3 File Offset: 0x000002B3
		[global::Cpp2ILInjected.Token(Token = "0x6000022")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F595D4", Offset = "0x1F595D4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_GetStatic", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000020B6 File Offset: 0x000002B6
		[global::Cpp2ILInjected.Token(Token = "0x6000023")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F596C0", Offset = "0x1F596C0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "SetNativeExceptionOnProxy", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(Exception),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020B9 File Offset: 0x000002B9
		[global::Cpp2ILInjected.Token(Token = "0x6000024")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F597D0", Offset = "0x1F597D0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetConstructorMember", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetMethodMember", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetFieldMember", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(string),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "NewProxyInstance", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020BC File Offset: 0x000002BC
		[global::Cpp2ILInjected.Token(Token = "0x6000025")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F598DC", Offset = "0x1F598DC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetFieldSignature", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020BF File Offset: 0x000002BF
		[global::Cpp2ILInjected.Token(Token = "0x6000026")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59994", Offset = "0x1F59994", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020C2 File Offset: 0x000002C2
		[global::Cpp2ILInjected.Token(Token = "0x6000027")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59AA0", Offset = "0x1F59AA0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020C5 File Offset: 0x000002C5
		[global::Cpp2ILInjected.Token(Token = "0x6000028")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59BB8", Offset = "0x1F59BB8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020C8 File Offset: 0x000002C8
		[global::Cpp2ILInjected.Token(Token = "0x6000029")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59CD0", Offset = "0x1F59CD0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000020CB File Offset: 0x000002CB
		[global::Cpp2ILInjected.Token(Token = "0x600002A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59DDC", Offset = "0x1F59DDC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020CE File Offset: 0x000002CE
		[global::Cpp2ILInjected.Token(Token = "0x600002B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59EE8", Offset = "0x1F59EE8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020D1 File Offset: 0x000002D1
		[global::Cpp2ILInjected.Token(Token = "0x600002C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F59FF4", Offset = "0x1F59FF4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000020D4 File Offset: 0x000002D4
		[global::Cpp2ILInjected.Token(Token = "0x600002D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A100", Offset = "0x1F5A100", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaProxy), Member = "hashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_CallStatic", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000020D7 File Offset: 0x000002D7
		[global::Cpp2ILInjected.Token(Token = "0x600002E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A20C", Offset = "0x1F5A20C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Set", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val)
		{
			throw null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000020DA File Offset: 0x000002DA
		[global::Cpp2ILInjected.Token(Token = "0x600002F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A31C", Offset = "0x1F5A31C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Set", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetStringField(IntPtr obj, IntPtr fieldID, string val)
		{
			throw null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000020DD File Offset: 0x000002DD
		[global::Cpp2ILInjected.Token(Token = "0x6000030")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A42C", Offset = "0x1F5A42C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Set", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetCharField(IntPtr obj, IntPtr fieldID, char val)
		{
			throw null;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000020E0 File Offset: 0x000002E0
		[global::Cpp2ILInjected.Token(Token = "0x6000031")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A53C", Offset = "0x1F5A53C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Set", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val)
		{
			throw null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000020E3 File Offset: 0x000002E3
		[global::Cpp2ILInjected.Token(Token = "0x6000032")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A64C", Offset = "0x1F5A64C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Set", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val)
		{
			throw null;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000020E6 File Offset: 0x000002E6
		[global::Cpp2ILInjected.Token(Token = "0x6000033")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A75C", Offset = "0x1F5A75C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Set", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetLongField(IntPtr obj, IntPtr fieldID, long val)
		{
			throw null;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000020E9 File Offset: 0x000002E9
		[global::Cpp2ILInjected.Token(Token = "0x6000034")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A86C", Offset = "0x1F5A86C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Set", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetShortField(IntPtr obj, IntPtr fieldID, short val)
		{
			throw null;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000020EC File Offset: 0x000002EC
		[global::Cpp2ILInjected.Token(Token = "0x6000035")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5A97C", Offset = "0x1F5A97C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Set", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val)
		{
			throw null;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000020EF File Offset: 0x000002EF
		[global::Cpp2ILInjected.Token(Token = "0x6000036")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5AA8C", Offset = "0x1F5AA8C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Set", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val)
		{
			throw null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000020F2 File Offset: 0x000002F2
		[global::Cpp2ILInjected.Token(Token = "0x6000037")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5AB9C", Offset = "0x1F5AB9C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Set", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[]
		{
			typeof(string),
			"FieldType"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void SetIntField(IntPtr obj, IntPtr fieldID, int val)
		{
			throw null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000020F5 File Offset: 0x000002F5
		[global::Cpp2ILInjected.Token(Token = "0x6000038")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5ACAC", Offset = "0x1F5ACAC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Get", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000020F8 File Offset: 0x000002F8
		[global::Cpp2ILInjected.Token(Token = "0x6000039")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5AD98", Offset = "0x1F5AD98", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Get", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static string GetStringField(IntPtr obj, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000020FB File Offset: 0x000002FB
		[global::Cpp2ILInjected.Token(Token = "0x600003A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5AE84", Offset = "0x1F5AE84", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Get", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static char GetCharField(IntPtr obj, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000020FE File Offset: 0x000002FE
		[global::Cpp2ILInjected.Token(Token = "0x600003B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5AF70", Offset = "0x1F5AF70", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Get", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static double GetDoubleField(IntPtr obj, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002101 File Offset: 0x00000301
		[global::Cpp2ILInjected.Token(Token = "0x600003C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B068", Offset = "0x1F5B068", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Get", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static float GetFloatField(IntPtr obj, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002104 File Offset: 0x00000304
		[global::Cpp2ILInjected.Token(Token = "0x600003D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B160", Offset = "0x1F5B160", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Get", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static long GetLongField(IntPtr obj, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002107 File Offset: 0x00000307
		[global::Cpp2ILInjected.Token(Token = "0x600003E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B24C", Offset = "0x1F5B24C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Get", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static short GetShortField(IntPtr obj, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000210A File Offset: 0x0000030A
		[global::Cpp2ILInjected.Token(Token = "0x600003F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B338", Offset = "0x1F5B338", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Get", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000210D File Offset: 0x0000030D
		[global::Cpp2ILInjected.Token(Token = "0x6000040")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B424", Offset = "0x1F5B424", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Get", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool GetBooleanField(IntPtr obj, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002110 File Offset: 0x00000310
		[global::Cpp2ILInjected.Token(Token = "0x6000041")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B510", Offset = "0x1F5B510", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Get", MemberTypeParameters = new object[] { "FieldType" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static int GetIntField(IntPtr obj, IntPtr fieldID)
		{
			throw null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002113 File Offset: 0x00000313
		[global::Cpp2ILInjected.Token(Token = "0x6000042")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B5FC", Offset = "0x1F5B5FC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002116 File Offset: 0x00000316
		[global::Cpp2ILInjected.Token(Token = "0x6000043")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B70C", Offset = "0x1F5B70C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = "GetFieldClass", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002119 File Offset: 0x00000319
		[global::Cpp2ILInjected.Token(Token = "0x6000044")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B818", Offset = "0x1F5B818", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000211C File Offset: 0x0000031C
		[global::Cpp2ILInjected.Token(Token = "0x6000045")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B8D0", Offset = "0x1F5B8D0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000211F File Offset: 0x0000031F
		[global::Cpp2ILInjected.Token(Token = "0x6000046")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5B9DC", Offset = "0x1F5B9DC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002122 File Offset: 0x00000322
		[global::Cpp2ILInjected.Token(Token = "0x6000047")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5BAF4", Offset = "0x1F5BAF4", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002125 File Offset: 0x00000325
		[global::Cpp2ILInjected.Token(Token = "0x6000048")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5BC0C", Offset = "0x1F5BC0C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002128 File Offset: 0x00000328
		[global::Cpp2ILInjected.Token(Token = "0x6000049")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5BD18", Offset = "0x1F5BD18", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000212B File Offset: 0x0000032B
		[global::Cpp2ILInjected.Token(Token = "0x600004A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5BE24", Offset = "0x1F5BE24", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000212E File Offset: 0x0000032E
		[global::Cpp2ILInjected.Token(Token = "0x600004B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5BF30", Offset = "0x1F5BF30", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002131 File Offset: 0x00000331
		[global::Cpp2ILInjected.Token(Token = "0x600004C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C03C", Offset = "0x1F5C03C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_Call", MemberTypeParameters = new object[] { "ReturnType" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = "ReturnType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args)
		{
			throw null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002134 File Offset: 0x00000334
		[global::Cpp2ILInjected.Token(Token = "0x600004D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C148", Offset = "0x1F5C148", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new object[] { "ArrayType" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "ArrayType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static char[] FromCharArray(IntPtr array)
		{
			throw null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002137 File Offset: 0x00000337
		[global::Cpp2ILInjected.Token(Token = "0x600004E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C224", Offset = "0x1F5C224", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new object[] { "ArrayType" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "ArrayType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static double[] FromDoubleArray(IntPtr array)
		{
			throw null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000213A File Offset: 0x0000033A
		[global::Cpp2ILInjected.Token(Token = "0x600004F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C300", Offset = "0x1F5C300", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new object[] { "ArrayType" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "ArrayType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static float[] FromFloatArray(IntPtr array)
		{
			throw null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000213D File Offset: 0x0000033D
		[global::Cpp2ILInjected.Token(Token = "0x6000050")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C3DC", Offset = "0x1F5C3DC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new object[] { "ArrayType" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "ArrayType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static long[] FromLongArray(IntPtr array)
		{
			throw null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002140 File Offset: 0x00000340
		[global::Cpp2ILInjected.Token(Token = "0x6000051")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C4B8", Offset = "0x1F5C4B8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new object[] { "ArrayType" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "ArrayType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static short[] FromShortArray(IntPtr array)
		{
			throw null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002143 File Offset: 0x00000343
		[global::Cpp2ILInjected.Token(Token = "0x6000052")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C594", Offset = "0x1F5C594", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new object[] { "ArrayType" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "ArrayType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static byte[] FromByteArray(IntPtr array)
		{
			throw null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002146 File Offset: 0x00000346
		[global::Cpp2ILInjected.Token(Token = "0x6000053")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C670", Offset = "0x1F5C670", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new object[] { "ArrayType" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "ArrayType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static sbyte[] FromSByteArray(IntPtr array)
		{
			throw null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002149 File Offset: 0x00000349
		[global::Cpp2ILInjected.Token(Token = "0x6000054")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C74C", Offset = "0x1F5C74C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new object[] { "ArrayType" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "ArrayType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool[] FromBooleanArray(IntPtr array)
		{
			throw null;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000214C File Offset: 0x0000034C
		[global::Cpp2ILInjected.Token(Token = "0x6000055")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C828", Offset = "0x1F5C828", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new object[] { "ArrayType" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "ArrayType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static int[] FromIntArray(IntPtr array)
		{
			throw null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000214F File Offset: 0x0000034F
		[global::Cpp2ILInjected.Token(Token = "0x6000056")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C904", Offset = "0x1F5C904", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type)
		{
			throw null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002152 File Offset: 0x00000352
		[global::Cpp2ILInjected.Token(Token = "0x6000057")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5C9F0", Offset = "0x1F5C9F0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr ToCharArray(char[] array)
		{
			throw null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002155 File Offset: 0x00000355
		[global::Cpp2ILInjected.Token(Token = "0x6000058")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5CACC", Offset = "0x1F5CACC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr ToDoubleArray(double[] array)
		{
			throw null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002158 File Offset: 0x00000358
		[global::Cpp2ILInjected.Token(Token = "0x6000059")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5CBA8", Offset = "0x1F5CBA8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr ToFloatArray(float[] array)
		{
			throw null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000215B File Offset: 0x0000035B
		[global::Cpp2ILInjected.Token(Token = "0x600005A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5CC84", Offset = "0x1F5CC84", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr ToLongArray(long[] array)
		{
			throw null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000215E File Offset: 0x0000035E
		[global::Cpp2ILInjected.Token(Token = "0x600005B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5CD60", Offset = "0x1F5CD60", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr ToShortArray(short[] array)
		{
			throw null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002161 File Offset: 0x00000361
		[global::Cpp2ILInjected.Token(Token = "0x600005C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5CE3C", Offset = "0x1F5CE3C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr ToByteArray(byte[] array)
		{
			throw null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002164 File Offset: 0x00000364
		[global::Cpp2ILInjected.Token(Token = "0x600005D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5CF18", Offset = "0x1F5CF18", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr ToSByteArray(sbyte[] array)
		{
			throw null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002167 File Offset: 0x00000367
		[global::Cpp2ILInjected.Token(Token = "0x600005E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5CFF4", Offset = "0x1F5CFF4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr ToBooleanArray(bool[] array)
		{
			throw null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000216A File Offset: 0x0000036A
		[global::Cpp2ILInjected.Token(Token = "0x600005F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D0D0", Offset = "0x1F5D0D0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertToJNIArray", MemberParameters = new object[] { typeof(Array) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr ToIntArray(int[] array)
		{
			throw null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000216D File Offset: 0x0000036D
		[global::Cpp2ILInjected.Token(Token = "0x6000060")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D1AC", Offset = "0x1F5D1AC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "InvokeJavaProxyMethod", MemberParameters = new object[]
		{
			typeof(AndroidJavaProxy),
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static IntPtr GetObjectArrayElement(IntPtr array, int index)
		{
			throw null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002170 File Offset: 0x00000370
		[global::Cpp2ILInjected.Token(Token = "0x6000061")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D298", Offset = "0x1F5D298", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "InvokeJavaProxyMethod", MemberParameters = new object[]
		{
			typeof(AndroidJavaProxy),
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(_AndroidJNIHelper), Member = "ConvertFromJNIArray", MemberTypeParameters = new object[] { "ArrayType" }, MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = "ArrayType")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "CheckException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static int GetArrayLength(IntPtr array)
		{
			throw null;
		}
	}
}
