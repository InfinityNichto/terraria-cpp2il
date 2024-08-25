using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	[ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Field | global::System.AttributeTargets.Parameter | global::System.AttributeTargets.ReturnValue, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000454")]
	[StructLayout(0)]
	public sealed class MarshalAsAttribute : global::System.Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60021E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B72CA4", Offset = "0x1B72CA4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public MarshalAsAttribute(UnmanagedType unmanagedType)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x400128A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string MarshalCookie;

		[ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x400128B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string MarshalType;

		[ComVisible(true)]
		[global::Cpp2ILInjected.Token(Token = "0x400128C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public global::System.Type MarshalTypeRef;

		[global::Cpp2ILInjected.Token(Token = "0x400128D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public global::System.Type SafeArrayUserDefinedSubType;

		[global::Cpp2ILInjected.Token(Token = "0x400128E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private UnmanagedType utype;

		[global::Cpp2ILInjected.Token(Token = "0x400128F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public UnmanagedType ArraySubType;

		[global::Cpp2ILInjected.Token(Token = "0x4001290")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public VarEnum SafeArraySubType;

		[global::Cpp2ILInjected.Token(Token = "0x4001291")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public int SizeConst;

		[global::Cpp2ILInjected.Token(Token = "0x4001292")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public int IidParameterIndex;

		[global::Cpp2ILInjected.Token(Token = "0x4001293")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public short SizeParamIndex;
	}
}
