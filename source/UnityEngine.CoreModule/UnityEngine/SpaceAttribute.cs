using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	[global::Cpp2ILInjected.Token(Token = "0x200008C")]
	public class SpaceAttribute : PropertyAttribute
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000280")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78A68", Offset = "0x1F78A68", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SpaceAttribute()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000281")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78A88", Offset = "0x1F78A88", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Attribute), Member = ".ctor", ReturnType = typeof(void))]
		public SpaceAttribute(float height)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000323")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly float height;
	}
}
