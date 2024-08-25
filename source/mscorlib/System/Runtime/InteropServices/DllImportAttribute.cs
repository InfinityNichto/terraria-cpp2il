using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	[ComVisible(true)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000449")]
	public sealed class DllImportAttribute : global::System.Attribute
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6002174")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B703EC", Offset = "0x1B703EC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool IsDefined(global::System.Reflection.RuntimeMethodInfo method)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002175")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B70360", Offset = "0x1B70360", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		internal DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002176")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B7040C", Offset = "0x1B7040C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DllImportAttribute(string dllName)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4001267")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string _val;

		[global::Cpp2ILInjected.Token(Token = "0x4001268")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public string EntryPoint;

		[global::Cpp2ILInjected.Token(Token = "0x4001269")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public CharSet CharSet;

		[global::Cpp2ILInjected.Token(Token = "0x400126A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public bool SetLastError;

		[global::Cpp2ILInjected.Token(Token = "0x400126B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x25")]
		public bool ExactSpelling;

		[global::Cpp2ILInjected.Token(Token = "0x400126C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x26")]
		public bool PreserveSig;

		[global::Cpp2ILInjected.Token(Token = "0x400126D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public CallingConvention CallingConvention;

		[global::Cpp2ILInjected.Token(Token = "0x400126E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		public bool BestFitMapping;

		[global::Cpp2ILInjected.Token(Token = "0x400126F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D")]
		public bool ThrowOnUnmappableChar;
	}
}
