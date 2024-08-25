using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	[global::Cpp2ILInjected.Token(Token = "0x200009F")]
	public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60002B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A044", Offset = "0x1F7A044", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PreserveAttribute), Member = ".ctor", ReturnType = typeof(void))]
		public RuntimeInitializeOnLoadMethodAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A068", Offset = "0x1F7A068", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PreserveAttribute), Member = ".ctor", ReturnType = typeof(void))]
		public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000A4")]
		private RuntimeInitializeLoadType loadType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7A060", Offset = "0x1F7A060", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000350")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RuntimeInitializeLoadType m_LoadType;
	}
}
