using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000078 RID: 120
	[global::Cpp2ILInjected.Token(Token = "0x200009F")]
	[global::System.Serializable]
	public class DivideByZeroException : global::System.ArithmeticException
	{
		// Token: 0x060005AB RID: 1451 RVA: 0x0001561A File Offset: 0x0001381A
		[global::Cpp2ILInjected.Token(Token = "0x6000645")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1D49C", Offset = "0x1C1D49C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Decimal.DecCalc", Member = "VarDecDiv", MemberParameters = new object[]
		{
			typeof(ref decimal.DecCalc),
			typeof(ref decimal.DecCalc)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArithmeticException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DivideByZeroException()
		{
			throw null;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0001561D File Offset: 0x0001381D
		[global::Cpp2ILInjected.Token(Token = "0x6000646")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1D4F8", Offset = "0x1C1D4F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArithmeticException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected DivideByZeroException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
