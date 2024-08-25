using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine.Playables
{
	[global::Cpp2ILInjected.Token(Token = "0x200014F")]
	public struct PlayableBinding
	{
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600064C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F90024", Offset = "0x1F90024", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static PlayableBinding()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000629")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private string m_StreamName;

		[global::Cpp2ILInjected.Token(Token = "0x400062A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private Object m_SourceObject;

		[global::Cpp2ILInjected.Token(Token = "0x400062B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Type m_SourceBindingType;

		[global::Cpp2ILInjected.Token(Token = "0x400062C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private PlayableBinding.CreateOutputMethod m_CreateOutputMethod;

		[global::Cpp2ILInjected.Token(Token = "0x400062D")]
		public static readonly PlayableBinding[] None;

		[global::Cpp2ILInjected.Token(Token = "0x400062E")]
		public static readonly double DefaultDuration;

		[VisibleToOtherModules]
		[global::Cpp2ILInjected.Token(Token = "0x2000150")]
		internal delegate PlayableOutput CreateOutputMethod(PlayableGraph graph, string name);
	}
}
