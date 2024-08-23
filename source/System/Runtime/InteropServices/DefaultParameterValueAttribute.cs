using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000051 RID: 81
	[AttributeUsage(AttributeTargets.Parameter)]
	[global::Cpp2ILInjected.Token(Token = "0x20000A2")]
	public sealed class DefaultParameterValueAttribute : Attribute
	{
		// Token: 0x0600024F RID: 591 RVA: 0x000034A3 File Offset: 0x000016A3
		[global::Cpp2ILInjected.Token(Token = "0x60002D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EA814C", Offset = "0x1EA814C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public DefaultParameterValueAttribute(object value)
		{
			throw null;
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000250 RID: 592 RVA: 0x000034A6 File Offset: 0x000016A6
		[global::Cpp2ILInjected.Token(Token = "0x17000098")]
		public object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EA8174", Offset = "0x1EA8174", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400014E RID: 334
		[global::Cpp2ILInjected.Token(Token = "0x4000277")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object value;
	}
}
