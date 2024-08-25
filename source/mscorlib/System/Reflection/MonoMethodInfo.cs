using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x200050D")]
	internal struct MonoMethodInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x60025C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8EC4C", Offset = "0x1B8EC4C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void get_method_info(global::System.IntPtr handle, out MonoMethodInfo info);

		[global::Cpp2ILInjected.Token(Token = "0x60025C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8EC50", Offset = "0x1B8EC50", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern int get_method_attributes(global::System.IntPtr handle);

		[global::Cpp2ILInjected.Token(Token = "0x60025C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8EC54", Offset = "0x1B8EC54", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static MonoMethodInfo GetMethodInfo(global::System.IntPtr handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60025C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8EC84", Offset = "0x1B8EC84", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static global::System.Type GetDeclaringType(global::System.IntPtr handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60025C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8ECAC", Offset = "0x1B8ECAC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static global::System.Type GetReturnType(global::System.IntPtr handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60025C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8ECD4", Offset = "0x1B8ECD4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static MethodAttributes GetAttributes(global::System.IntPtr handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60025C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8ECD8", Offset = "0x1B8ECD8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static CallingConventions GetCallingConvention(global::System.IntPtr handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60025C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8ED00", Offset = "0x1B8ED00", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static MethodImplAttributes GetMethodImplementationFlags(global::System.IntPtr handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60025CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8ED28", Offset = "0x1B8ED28", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern ParameterInfo[] get_parameter_info(global::System.IntPtr handle, MemberInfo member);

		[global::Cpp2ILInjected.Token(Token = "0x60025CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8ED2C", Offset = "0x1B8ED2C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static ParameterInfo[] GetParametersInfo(global::System.IntPtr handle, MemberInfo member)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60025CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8ED30", Offset = "0x1B8ED30", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern global::System.Runtime.InteropServices.MarshalAsAttribute get_retval_marshal(global::System.IntPtr handle);

		[global::Cpp2ILInjected.Token(Token = "0x60025CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8ED34", Offset = "0x1B8ED34", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RuntimeMethodInfo), Member = "get_ReturnParameter", ReturnType = typeof(ParameterInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeParameterInfo), Member = "New", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(MemberInfo),
			typeof(global::System.Runtime.InteropServices.MarshalAsAttribute)
		}, ReturnType = typeof(ParameterInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40014ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.Type parent;

		[global::Cpp2ILInjected.Token(Token = "0x40014EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private global::System.Type ret;

		[global::Cpp2ILInjected.Token(Token = "0x40014EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal MethodAttributes attrs;

		[global::Cpp2ILInjected.Token(Token = "0x40014F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal MethodImplAttributes iattrs;

		[global::Cpp2ILInjected.Token(Token = "0x40014F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private CallingConventions callconv;
	}
}
