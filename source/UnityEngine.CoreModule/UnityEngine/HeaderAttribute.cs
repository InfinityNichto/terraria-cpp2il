using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200008D")]
	public class HeaderAttribute : PropertyAttribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000282")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78AB0", Offset = "0x1F78AB0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public HeaderAttribute(string header)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000324")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string header;
	}
}
