using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x020003A7 RID: 935
	[ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Field | global::System.AttributeTargets.Parameter | global::System.AttributeTargets.ReturnValue, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000454")]
	[StructLayout(0)]
	public sealed class MarshalAsAttribute : global::System.Attribute
	{
		// Token: 0x06001F99 RID: 8089 RVA: 0x00019D7B File Offset: 0x00017F7B
		[global::Cpp2ILInjected.Token(Token = "0x60021E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72CA4", Offset = "0x1B72CA4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public MarshalAsAttribute(UnmanagedType unmanagedType)
		{
			throw null;
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001F9A RID: 8090 RVA: 0x00019D7E File Offset: 0x00017F7E
		[global::Cpp2ILInjected.Token(Token = "0x1700045E")]
		public UnmanagedType Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60021E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B72CCC", Offset = "0x1B72CCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x00019D81 File Offset: 0x00017F81
		[global::Cpp2ILInjected.Token(Token = "0x60021E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72CD4", Offset = "0x1B72CD4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeParameterInfo), Member = "GetPseudoCustomAttributes", ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal MarshalAsAttribute Copy()
		{
			throw null;
		}

		// Token: 0x04000F93 RID: 3987
		[global::Cpp2ILInjected.Token(Token = "0x400128A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string MarshalCookie;

		// Token: 0x04000F94 RID: 3988
		[ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x400128B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string MarshalType;

		// Token: 0x04000F95 RID: 3989
		[ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x400128C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public global::System.Type MarshalTypeRef;

		// Token: 0x04000F96 RID: 3990
		[global::Cpp2ILInjected.Token(Token = "0x400128D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public global::System.Type SafeArrayUserDefinedSubType;

		// Token: 0x04000F97 RID: 3991
		[global::Cpp2ILInjected.Token(Token = "0x400128E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private UnmanagedType utype;

		// Token: 0x04000F98 RID: 3992
		[global::Cpp2ILInjected.Token(Token = "0x400128F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public UnmanagedType ArraySubType;

		// Token: 0x04000F99 RID: 3993
		[global::Cpp2ILInjected.Token(Token = "0x4001290")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public VarEnum SafeArraySubType;

		// Token: 0x04000F9A RID: 3994
		[global::Cpp2ILInjected.Token(Token = "0x4001291")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int SizeConst;

		// Token: 0x04000F9B RID: 3995
		[global::Cpp2ILInjected.Token(Token = "0x4001292")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int IidParameterIndex;

		// Token: 0x04000F9C RID: 3996
		[global::Cpp2ILInjected.Token(Token = "0x4001293")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public short SizeParamIndex;
	}
}
