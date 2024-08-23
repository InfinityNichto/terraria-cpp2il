using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000143 RID: 323
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200018A")]
	[global::System.Serializable]
	public struct RuntimeFieldHandle : global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000E53 RID: 3667 RVA: 0x00016DCF File Offset: 0x00014FCF
		[global::Cpp2ILInjected.Token(Token = "0x6000F3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82288", Offset = "0x1C82288", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal RuntimeFieldHandle(global::System.IntPtr v)
		{
			throw null;
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00016DD2 File Offset: 0x00014FD2
		[global::Cpp2ILInjected.Token(Token = "0x6000F3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82290", Offset = "0x1C82290", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private RuntimeFieldHandle(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00016DD5 File Offset: 0x00014FD5
		[global::Cpp2ILInjected.Token(Token = "0x1700015F")]
		public global::System.IntPtr Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F40")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C82434", Offset = "0x1C82434", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00016DD8 File Offset: 0x00014FD8
		[global::Cpp2ILInjected.Token(Token = "0x6000F41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8243C", Offset = "0x1C8243C", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "GetFieldFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeFieldHandle) }, ReturnType = typeof(global::System.Reflection.FieldInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00016DDB File Offset: 0x00014FDB
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000F42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C825F0", Offset = "0x1C825F0", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00016DDE File Offset: 0x00014FDE
		[global::Cpp2ILInjected.Token(Token = "0x6000F43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C826EC", Offset = "0x1C826EC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000E59 RID: 3673
		[global::Cpp2ILInjected.Token(Token = "0x6000F44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C826F4", Offset = "0x1C826F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void SetValueInternal(global::System.Reflection.FieldInfo fi, object obj, object value);

		// Token: 0x06000E5A RID: 3674 RVA: 0x00016DE1 File Offset: 0x00014FE1
		[global::Cpp2ILInjected.Token(Token = "0x6000F45")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C826F8", Offset = "0x1C826F8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "UnsafeSetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static void SetValue(global::System.Reflection.RuntimeFieldInfo field, object obj, object value, global::System.RuntimeType fieldType, global::System.Reflection.FieldAttributes fieldAttr, global::System.RuntimeType declaringType, ref bool domainInitialized)
		{
			throw null;
		}

		// Token: 0x06000E5B RID: 3675
		[global::Cpp2ILInjected.Token(Token = "0x6000F46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C826FC", Offset = "0x1C826FC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "SetValueDirect", MemberParameters = new object[]
		{
			typeof(global::System.TypedReference),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal unsafe static extern void SetValueDirect(global::System.Reflection.RuntimeFieldInfo field, global::System.RuntimeType fieldType, void* pTypedRef, object value, global::System.RuntimeType contextType);

		// Token: 0x040004C4 RID: 1220
		[global::Cpp2ILInjected.Token(Token = "0x4000695")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.IntPtr value;
	}
}
