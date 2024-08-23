using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000144 RID: 324
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200018B")]
	[global::System.Serializable]
	public struct RuntimeMethodHandle : global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000E5C RID: 3676 RVA: 0x00016DE4 File Offset: 0x00014FE4
		[global::Cpp2ILInjected.Token(Token = "0x6000F47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82700", Offset = "0x1C82700", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal RuntimeMethodHandle(global::System.IntPtr v)
		{
			throw null;
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x00016DE7 File Offset: 0x00014FE7
		[global::Cpp2ILInjected.Token(Token = "0x6000F48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82708", Offset = "0x1C82708", Length = "0x1A4")]
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
		private RuntimeMethodHandle(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00016DEA File Offset: 0x00014FEA
		[global::Cpp2ILInjected.Token(Token = "0x17000160")]
		public global::System.IntPtr Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000F49")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C828AC", Offset = "0x1C828AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00016DED File Offset: 0x00014FED
		[global::Cpp2ILInjected.Token(Token = "0x6000F4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C828B4", Offset = "0x1C828B4", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodBase), Member = "GetMethodFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeMethodHandle) }, ReturnType = typeof(global::System.Reflection.MethodBase))]
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

		// Token: 0x06000E60 RID: 3680
		[global::Cpp2ILInjected.Token(Token = "0x6000F4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82A68", Offset = "0x1C82A68", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.IntPtr GetFunctionPointer(global::System.IntPtr m);

		// Token: 0x06000E61 RID: 3681 RVA: 0x00016DF0 File Offset: 0x00014FF0
		[global::Cpp2ILInjected.Token(Token = "0x6000F4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82A6C", Offset = "0x1C82A6C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "ForceJITOnAssembly", MemberParameters = new object[] { typeof(global::System.Reflection.Assembly) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public global::System.IntPtr GetFunctionPointer()
		{
			throw null;
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00016DF3 File Offset: 0x00014FF3
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000F4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82A74", Offset = "0x1C82A74", Length = "0xFC")]
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

		// Token: 0x06000E63 RID: 3683 RVA: 0x00016DF6 File Offset: 0x00014FF6
		[global::Cpp2ILInjected.Token(Token = "0x6000F4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82B70", Offset = "0x1C82B70", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00016DF9 File Offset: 0x00014FF9
		[global::Cpp2ILInjected.Token(Token = "0x6000F4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82B78", Offset = "0x1C82B78", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "FormatNameAndSig", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static string ConstructInstantiation(global::System.Reflection.RuntimeMethodInfo method, global::System.TypeNameFormatFlags format)
		{
			throw null;
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00016DFC File Offset: 0x00014FFC
		[global::Cpp2ILInjected.Token(Token = "0x6000F50")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C82CB4", Offset = "0x1C82CB4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.MethodBase), Member = "GetMethodFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeMethodHandle) }, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool IsNullHandle()
		{
			throw null;
		}

		// Token: 0x040004C5 RID: 1221
		[global::Cpp2ILInjected.Token(Token = "0x4000696")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.IntPtr value;
	}
}
