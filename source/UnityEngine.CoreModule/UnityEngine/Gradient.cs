using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000C0 RID: 192
	[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000D2")]
	[StructLayout(0)]
	public class Gradient : IEquatable<Gradient>
	{
		// Token: 0x06000439 RID: 1081
		[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600044D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F836B8", Offset = "0x1F836B8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern IntPtr Init();

		// Token: 0x0600043A RID: 1082
		[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = true, HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600044E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F836E0", Offset = "0x1F836E0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void Cleanup();

		// Token: 0x0600043B RID: 1083
		[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = true, HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600044F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8371C", Offset = "0x1F8371C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern bool Internal_Equals(IntPtr other);

		// Token: 0x0600043C RID: 1084 RVA: 0x00002986 File Offset: 0x00000B86
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000450")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83760", Offset = "0x1F83760", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Gradient()
		{
			throw null;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002989 File Offset: 0x00000B89
		[global::Cpp2ILInjected.Token(Token = "0x6000451")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F837A8", Offset = "0x1F837A8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000298C File Offset: 0x00000B8C
		[global::Cpp2ILInjected.Token(Token = "0x6000452")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83860", Offset = "0x1F83860", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object o)
		{
			throw null;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000298F File Offset: 0x00000B8F
		[global::Cpp2ILInjected.Token(Token = "0x6000453")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83928", Offset = "0x1F83928", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Equals(Gradient other)
		{
			throw null;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00002992 File Offset: 0x00000B92
		[global::Cpp2ILInjected.Token(Token = "0x6000454")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F839F0", Offset = "0x1F839F0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x04000392 RID: 914
		[global::Cpp2ILInjected.Token(Token = "0x40003CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;
	}
}
