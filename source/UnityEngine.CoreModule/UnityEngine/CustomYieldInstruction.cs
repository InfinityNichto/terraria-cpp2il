using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x20000C8")]
	public abstract class CustomYieldInstruction : IEnumerator
	{
		[global::Cpp2ILInjected.Token(Token = "0x170000B6")]
		public abstract bool keepWaiting
		{
			[global::Cpp2ILInjected.Token(Token = "0x600037D")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000B7")]
		public object Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x600037E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7ED24", Offset = "0x1F7ED24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600037F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7ED2C", Offset = "0x1F7ED2C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool MoveNext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000380")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7ED38", Offset = "0x1F7ED38", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000381")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7DB18", Offset = "0x1F7DB18", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected CustomYieldInstruction()
		{
			throw null;
		}
	}
}
