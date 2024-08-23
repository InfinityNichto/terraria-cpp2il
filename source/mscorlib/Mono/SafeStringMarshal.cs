using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono
{
	// Token: 0x0200001B RID: 27
	[global::Cpp2ILInjected.Token(Token = "0x2000028")]
	internal struct SafeStringMarshal : global::System.IDisposable
	{
		// Token: 0x06000040 RID: 64
		[global::Cpp2ILInjected.Token(Token = "0x6000066")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB758", Offset = "0x1AAB758", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.IntPtr StringToUtf8_icall(ref string str);

		// Token: 0x06000041 RID: 65 RVA: 0x0001468D File Offset: 0x0001288D
		[global::Cpp2ILInjected.Token(Token = "0x6000067")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB75C", Offset = "0x1AAB75C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static global::System.IntPtr StringToUtf8(string str)
		{
			throw null;
		}

		// Token: 0x06000042 RID: 66
		[global::Cpp2ILInjected.Token(Token = "0x6000068")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB774", Offset = "0x1AAB774", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public static extern void GFree(global::System.IntPtr ptr);

		// Token: 0x06000043 RID: 67 RVA: 0x00014690 File Offset: 0x00012890
		[global::Cpp2ILInjected.Token(Token = "0x6000069")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB540", Offset = "0x1AAB540", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodsByName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeMethodInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertiesByName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimePropertyInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetFields_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeFieldInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEvents_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeEventInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetNestedTypes_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(global::System.RuntimeType[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public SafeStringMarshal(string str)
		{
			throw null;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00014693 File Offset: 0x00012893
		[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
		public global::System.IntPtr Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600006A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AAB778", Offset = "0x1AAB778", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodsByName", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.RuntimeType.MemberListType),
				typeof(global::System.RuntimeType)
			}, ReturnType = typeof(global::System.Reflection.RuntimeMethodInfo[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertiesByName", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.RuntimeType.MemberListType),
				typeof(global::System.RuntimeType)
			}, ReturnType = typeof(global::System.Reflection.RuntimePropertyInfo[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetFields_internal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.RuntimeType.MemberListType),
				typeof(global::System.RuntimeType)
			}, ReturnType = typeof(global::System.Reflection.RuntimeFieldInfo[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEvents_internal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.RuntimeType.MemberListType),
				typeof(global::System.RuntimeType)
			}, ReturnType = typeof(global::System.Reflection.RuntimeEventInfo[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetNestedTypes_internal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Reflection.BindingFlags),
				typeof(global::System.RuntimeType.MemberListType)
			}, ReturnType = typeof(global::System.RuntimeType[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.AssemblyName), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.IntPtr),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00014696 File Offset: 0x00012896
		[global::Cpp2ILInjected.Token(Token = "0x600006B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AAB7F8", Offset = "0x1AAB7F8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetMethodsByName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeMethodInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetPropertiesByName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimePropertyInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetFields_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeFieldInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEvents_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(global::System.Reflection.RuntimeEventInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetNestedTypes_internal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.RuntimeType.MemberListType)
		}, ReturnType = typeof(global::System.RuntimeType[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Environment), Member = "internalGetEnvironmentVariable", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.AssemblyName), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x0400002B RID: 43
		[global::Cpp2ILInjected.Token(Token = "0x40000BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string str;

		// Token: 0x0400002C RID: 44
		[global::Cpp2ILInjected.Token(Token = "0x40000BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private global::System.IntPtr marshaled_string;
	}
}
