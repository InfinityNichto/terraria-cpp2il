using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Serialization
{
	[RequiredByNativeCode]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
	[global::Cpp2ILInjected.Token(Token = "0x2000127")]
	public class FormerlySerializedAsAttribute : Attribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8D1DC", Offset = "0x1F8D1DC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public FormerlySerializedAsAttribute(string oldName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40004E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string m_oldName;
	}
}
