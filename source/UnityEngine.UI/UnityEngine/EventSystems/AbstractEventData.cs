using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.EventSystems
{
	[global::Cpp2ILInjected.Token(Token = "0x2000091")]
	public abstract class AbstractEventData
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000585")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE3944", Offset = "0x1FE3944", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000586")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE394C", Offset = "0x1FE394C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void Use()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700016B")]
		public virtual bool used
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000587")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE3958", Offset = "0x1FE3958", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000588")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE3960", Offset = "0x1FE3960", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected AbstractEventData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000289")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected bool m_Used;
	}
}
