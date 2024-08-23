using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	internal class GlobalJavaObjectRef
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00002179 File Offset: 0x00000379
		[global::Cpp2ILInjected.Token(Token = "0x6000066")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D468", Offset = "0x1F5D468", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaProxy), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "CloneReference", ReturnType = typeof(AndroidJavaObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "_AndroidJavaObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = ".ctor", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaClass), Member = "_AndroidJavaClass", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidReflection), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public GlobalJavaObjectRef(IntPtr jobject)
		{
			throw null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000217C File Offset: 0x0000037C
		[global::Cpp2ILInjected.Token(Token = "0x6000067")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D558", Offset = "0x1F5D558", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GlobalJavaObjectRef), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000217F File Offset: 0x0000037F
		[global::Cpp2ILInjected.Token(Token = "0x6000068")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D668", Offset = "0x1F5D668", Length = "0x8")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 86)]
		public static implicit operator IntPtr(GlobalJavaObjectRef obj)
		{
			throw null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002182 File Offset: 0x00000382
		[global::Cpp2ILInjected.Token(Token = "0x6000069")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F5D5EC", Offset = "0x1F5D5EC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GlobalJavaObjectRef), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AndroidJavaObject), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJNISafe), Member = "DeleteGlobalRef", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x04000002 RID: 2
		[global::Cpp2ILInjected.Token(Token = "0x4000002")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool m_disposed;

		// Token: 0x04000003 RID: 3
		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected IntPtr m_jobject;
	}
}
