using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200014E")]
	public struct Playable : IEquatable<Playable>
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000151")]
		public static Playable Null
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000647")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8FE20", Offset = "0x1F8FE20", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayableAsset), Member = "Internal_CreatePlayable", MemberParameters = new object[]
			{
				typeof(PlayableAsset),
				typeof(PlayableGraph),
				typeof(GameObject),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[VisibleToOtherModules]
		[global::Cpp2ILInjected.Token(Token = "0x6000648")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FED4", Offset = "0x1F8FED4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal Playable(PlayableHandle handle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000649")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FEDC", Offset = "0x1F8FEDC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableHandle GetHandle()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600064A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FEE8", Offset = "0x1F8FEE8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(PlayableHandle),
			typeof(PlayableHandle)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(Playable other)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600064B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FF5C", Offset = "0x1F8FF5C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayableHandle), Member = "get_Null", ReturnType = typeof(PlayableHandle))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static Playable()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000627")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		[global::Cpp2ILInjected.Token(Token = "0x4000628")]
		private static readonly Playable m_NullPlayable;
	}
}
