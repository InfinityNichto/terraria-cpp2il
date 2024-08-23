using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000128 RID: 296
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x200014E")]
	public struct Playable : IEquatable<Playable>
	{
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x00002DE2 File Offset: 0x00000FE2
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

		// Token: 0x06000612 RID: 1554 RVA: 0x00002DE5 File Offset: 0x00000FE5
		[VisibleToOtherModules]
		[global::Cpp2ILInjected.Token(Token = "0x6000648")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FED4", Offset = "0x1F8FED4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal Playable(PlayableHandle handle)
		{
			throw null;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002DE8 File Offset: 0x00000FE8
		[global::Cpp2ILInjected.Token(Token = "0x6000649")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8FEDC", Offset = "0x1F8FEDC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public PlayableHandle GetHandle()
		{
			throw null;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002DEB File Offset: 0x00000FEB
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

		// Token: 0x06000615 RID: 1557 RVA: 0x00002DEE File Offset: 0x00000FEE
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

		// Token: 0x040005D1 RID: 1489
		[global::Cpp2ILInjected.Token(Token = "0x4000627")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private PlayableHandle m_Handle;

		// Token: 0x040005D2 RID: 1490
		[global::Cpp2ILInjected.Token(Token = "0x4000628")]
		private static readonly Playable m_NullPlayable;
	}
}
