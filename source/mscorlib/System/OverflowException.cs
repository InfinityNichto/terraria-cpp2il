using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System
{
	// Token: 0x020000B9 RID: 185
	[global::Cpp2ILInjected.Token(Token = "0x20000EB")]
	[global::System.Serializable]
	public class OverflowException : global::System.ArithmeticException
	{
		// Token: 0x06000821 RID: 2081 RVA: 0x00015CDA File Offset: 0x00013EDA
		[global::Cpp2ILInjected.Token(Token = "0x60008C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4423C", Offset = "0x1C4423C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.PKCS1), Member = "MGF1", MemberParameters = new object[]
		{
			typeof(global::System.Security.Cryptography.HashAlgorithm),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Linq.XHashtable`1.XHashtableState", Member = "Resize", ReturnType = "XHashtableState<TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArithmeticException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public OverflowException()
		{
			throw null;
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00015CDD File Offset: 0x00013EDD
		[global::Cpp2ILInjected.Token(Token = "0x60008CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C44298", Offset = "0x1C44298", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 63)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArithmeticException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public OverflowException(string message)
		{
			throw null;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00015CE0 File Offset: 0x00013EE0
		[global::Cpp2ILInjected.Token(Token = "0x60008CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C442BC", Offset = "0x1C442BC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(byte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(short), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(sbyte), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ushort), Member = "Parse", MemberParameters = new object[]
		{
			typeof(global::System.ReadOnlySpan<char>),
			typeof(global::System.Globalization.NumberStyles),
			typeof(global::System.Globalization.NumberFormatInfo)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToByte", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToSByte", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(sbyte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToInt16", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(decimal), Member = "ToUInt16", MemberParameters = new object[] { typeof(decimal) }, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArithmeticException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		public OverflowException(string message, global::System.Exception innerException)
		{
			throw null;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00015CE3 File Offset: 0x00013EE3
		[global::Cpp2ILInjected.Token(Token = "0x60008CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C442E0", Offset = "0x1C442E0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArithmeticException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected OverflowException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
