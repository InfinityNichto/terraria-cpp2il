using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Math;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000086")]
	[global::System.Serializable]
	public class ArithmeticException : global::System.SystemException
	{
		[global::Cpp2ILInjected.Token(Token = "0x60003D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB61A8", Offset = "0x1BB61A8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public ArithmeticException()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6204", Offset = "0x1BB6204", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Math.BigInteger.Kernel", Member = "modInverse", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.BigInteger), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(Mono.Math.BigInteger)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Math.BigInteger), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Mono.Math.BigInteger),
			typeof(int)
		}, ReturnType = typeof(Mono.Math.BigInteger))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DivideByZeroException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Math), Member = "Sign", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Math), Member = "Sign", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OverflowException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Math.BigInteger.Kernel", Member = "modInverse", MemberParameters = new object[] { "Mono.Math.BigInteger", "Mono.Math.BigInteger" }, ReturnType = "Mono.Math.BigInteger")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Math.BigInteger", Member = "op_Subtraction", MemberParameters = new object[] { "Mono.Math.BigInteger", "Mono.Math.BigInteger" }, ReturnType = "Mono.Math.BigInteger")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public ArithmeticException(string message)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6228", Offset = "0x1BB6228", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public ArithmeticException(string message, global::System.Exception innerException)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60003DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB624C", Offset = "0x1BB624C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DivideByZeroException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.OverflowException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected ArithmeticException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
