using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x0200039F RID: 927
	[ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000449")]
	public sealed class DllImportAttribute : global::System.Attribute
	{
		// Token: 0x06001F32 RID: 7986 RVA: 0x00019C8E File Offset: 0x00017E8E
		[global::Cpp2ILInjected.Token(Token = "0x6002173")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B701B8", Offset = "0x1B701B8", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetPInvoke", MemberParameters = new object[]
		{
			typeof(ref global::System.Reflection.PInvokeAttributes),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static global::System.Attribute GetCustomAttribute(global::System.Reflection.RuntimeMethodInfo method)
		{
			throw null;
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x00019C91 File Offset: 0x00017E91
		[global::Cpp2ILInjected.Token(Token = "0x6002174")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B703EC", Offset = "0x1B703EC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool IsDefined(global::System.Reflection.RuntimeMethodInfo method)
		{
			throw null;
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00019C94 File Offset: 0x00017E94
		[global::Cpp2ILInjected.Token(Token = "0x6002175")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70360", Offset = "0x1B70360", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		internal DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar)
		{
			throw null;
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x00019C97 File Offset: 0x00017E97
		[global::Cpp2ILInjected.Token(Token = "0x6002176")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7040C", Offset = "0x1B7040C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DllImportAttribute(string dllName)
		{
			throw null;
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001F36 RID: 7990 RVA: 0x00019C9A File Offset: 0x00017E9A
		[global::Cpp2ILInjected.Token(Token = "0x17000457")]
		public string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002177")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B70434", Offset = "0x1B70434", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000F72 RID: 3954
		[global::Cpp2ILInjected.Token(Token = "0x4001267")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string _val;

		// Token: 0x04000F73 RID: 3955
		[global::Cpp2ILInjected.Token(Token = "0x4001268")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string EntryPoint;

		// Token: 0x04000F74 RID: 3956
		[global::Cpp2ILInjected.Token(Token = "0x4001269")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public CharSet CharSet;

		// Token: 0x04000F75 RID: 3957
		[global::Cpp2ILInjected.Token(Token = "0x400126A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public bool SetLastError;

		// Token: 0x04000F76 RID: 3958
		[global::Cpp2ILInjected.Token(Token = "0x400126B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
		public bool ExactSpelling;

		// Token: 0x04000F77 RID: 3959
		[global::Cpp2ILInjected.Token(Token = "0x400126C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x26")]
		public bool PreserveSig;

		// Token: 0x04000F78 RID: 3960
		[global::Cpp2ILInjected.Token(Token = "0x400126D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public CallingConvention CallingConvention;

		// Token: 0x04000F79 RID: 3961
		[global::Cpp2ILInjected.Token(Token = "0x400126E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public bool BestFitMapping;

		// Token: 0x04000F7A RID: 3962
		[global::Cpp2ILInjected.Token(Token = "0x400126F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D")]
		public bool ThrowOnUnmappableChar;
	}
}
