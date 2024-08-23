using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200011E RID: 286
	[global::System.Runtime.Versioning.NonVersionable]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.CLSCompliant(false)]
	[global::Cpp2ILInjected.Token(Token = "0x200015F")]
	public ref struct TypedReference
	{
		// Token: 0x06000D4A RID: 3402 RVA: 0x00016B41 File Offset: 0x00014D41
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000E28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C754B8", Offset = "0x1C754B8", Length = "0x400")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Runtime.Serialization.ObjectHolder),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Reflection.FieldInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(global::System.RuntimeType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.RuntimeType),
			typeof(global::System.RuntimeType)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MissingMemberException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public static global::System.TypedReference MakeTypedReference(object target, global::System.Reflection.FieldInfo[] flds)
		{
			throw null;
		}

		// Token: 0x06000D4B RID: 3403
		[global::Cpp2ILInjected.Token(Token = "0x6000E29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C758BC", Offset = "0x1C758BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private unsafe static extern void InternalMakeTypedReference(void* result, object target, global::System.IntPtr[] flds, global::System.RuntimeType lastFieldType);

		// Token: 0x06000D4C RID: 3404 RVA: 0x00016B44 File Offset: 0x00014D44
		[global::Cpp2ILInjected.Token(Token = "0x6000E2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C758C0", Offset = "0x1C758C0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00016B47 File Offset: 0x00014D47
		[global::Cpp2ILInjected.Token(Token = "0x6000E2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C75970", Offset = "0x1C75970", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool Equals(object o)
		{
			throw null;
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000D4E RID: 3406 RVA: 0x00016B4A File Offset: 0x00014D4A
		[global::Cpp2ILInjected.Token(Token = "0x17000140")]
		internal bool IsNull
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E2C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C759C0", Offset = "0x1C759C0", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "SetValueDirect", MemberParameters = new object[]
			{
				typeof(global::System.TypedReference),
				typeof(object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00016B4D File Offset: 0x00014D4D
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000E2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C75A2C", Offset = "0x1C75A2C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Runtime.Serialization.ObjectHolder),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotImplementedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void SetTypedReference(global::System.TypedReference target, object value)
		{
			throw null;
		}

		// Token: 0x04000440 RID: 1088
		[global::Cpp2ILInjected.Token(Token = "0x40005D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.RuntimeTypeHandle type;

		// Token: 0x04000441 RID: 1089
		[global::Cpp2ILInjected.Token(Token = "0x40005D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private global::System.IntPtr Value;

		// Token: 0x04000442 RID: 1090
		[global::Cpp2ILInjected.Token(Token = "0x40005D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.IntPtr Type;
	}
}
