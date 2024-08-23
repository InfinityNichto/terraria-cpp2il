using System;
using System.Collections;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020003E9 RID: 1001
	[global::Cpp2ILInjected.Token(Token = "0x20004A3")]
	public static class RuntimeHelpers
	{
		// Token: 0x0600202C RID: 8236
		[global::Cpp2ILInjected.Token(Token = "0x60022A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B759BC", Offset = "0x1B759BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void InitializeArray(global::System.Array array, global::System.IntPtr fldHandle);

		// Token: 0x0600202D RID: 8237 RVA: 0x00019F25 File Offset: 0x00018125
		[global::Cpp2ILInjected.Token(Token = "0x60022A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B759C0", Offset = "0x1B759C0", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1437)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void InitializeArray(global::System.Array array, global::System.RuntimeFieldHandle fldHandle)
		{
			throw null;
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600202E RID: 8238
		[global::Cpp2ILInjected.Token(Token = "0x1700047E")]
		public static extern int OffsetToStringData
		{
			[global::Cpp2ILInjected.Token(Token = "0x60022A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B71BC0", Offset = "0x1B71BC0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 124)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00019F28 File Offset: 0x00018128
		[global::Cpp2ILInjected.Token(Token = "0x60022A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75A60", Offset = "0x1B75A60", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Delegate), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ObjectIDGenerator), Member = "FindElement", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConditionalWeakTable<, >), Member = "RehashWithoutResize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConditionalWeakTable<, >), Member = "Rehash", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConditionalWeakTable<, >), Member = "Add", MemberParameters = new object[] { "TKey", "TValue" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConditionalWeakTable<, >), Member = "Remove", MemberParameters = new object[] { "TKey" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ConditionalWeakTable<, >), Member = "TryGetValue", MemberParameters = new object[] { "TKey", "TValue&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalBase.ReferenceEqualsEqualityComparer", Member = "System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "InternalGetHashCode", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		public static int GetHashCode(object o)
		{
			throw null;
		}

		// Token: 0x06002030 RID: 8240
		[global::Cpp2ILInjected.Token(Token = "0x60022A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75A68", Offset = "0x1B75A68", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void RunClassConstructor(global::System.IntPtr type);

		// Token: 0x06002031 RID: 8241 RVA: 0x00019F2B File Offset: 0x0001812B
		[global::Cpp2ILInjected.Token(Token = "0x60022AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75A6C", Offset = "0x1B75A6C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "ForceStaticInitializers", MemberParameters = new object[] { typeof(global::System.Reflection.Assembly) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "GetEditorTable", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Collections.Hashtable))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.IntPtr),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void RunClassConstructor(global::System.RuntimeTypeHandle type)
		{
			throw null;
		}

		// Token: 0x06002032 RID: 8242
		[global::Cpp2ILInjected.Token(Token = "0x60022AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75B28", Offset = "0x1B75B28", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern bool SufficientExecutionStack();

		// Token: 0x06002033 RID: 8243 RVA: 0x00019F2E File Offset: 0x0001812E
		[global::Cpp2ILInjected.Token(Token = "0x60022AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75B2C", Offset = "0x1B75B2C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.StackGuard), Member = "TryBeginInliningScope", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.TaskScheduler), Member = "TryRunInline", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static bool TryEnsureSufficientExecutionStack()
		{
			throw null;
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x00019F31 File Offset: 0x00018131
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x60022AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75B30", Offset = "0x1B75B30", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		public static void PrepareConstrainedRegions()
		{
			throw null;
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x00019F34 File Offset: 0x00018134
		[global::Cpp2ILInjected.Token(Token = "0x60022AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75B34", Offset = "0x1B75B34", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Program", Member = "ForceJITOnAssembly", MemberParameters = new object[] { typeof(global::System.Reflection.Assembly) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void PrepareMethod(global::System.RuntimeMethodHandle method)
		{
			throw null;
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x00019F37 File Offset: 0x00018137
		[global::Cpp2ILInjected.Token(Token = "0x60022AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1595DF8", Offset = "0x1595DF8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeTypeHandle), Member = "HasReferences", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool IsReferenceOrContainsReferences<T>()
		{
			throw null;
		}
	}
}
