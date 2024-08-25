using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Class)]
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000B5")]
	public class DefaultExecutionOrder : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x170000B0")]
		public int order
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000324")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F79F74", Offset = "0x1F79F74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x400036F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int m_Order;
	}
}
