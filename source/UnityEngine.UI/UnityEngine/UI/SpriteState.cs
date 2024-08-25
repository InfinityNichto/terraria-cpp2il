using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x200006F")]
	[Serializable]
	public struct SpriteState : IEquatable<SpriteState>
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000132")]
		public Sprite highlightedSprite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600048A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDB808", Offset = "0x1FDB808", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600048B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDB810", Offset = "0x1FDB810", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000133")]
		public Sprite pressedSprite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600048C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDB818", Offset = "0x1FDB818", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600048D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDB820", Offset = "0x1FDB820", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000134")]
		public Sprite selectedSprite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600048E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDB828", Offset = "0x1FDB828", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600048F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDB830", Offset = "0x1FDB830", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000135")]
		public Sprite disabledSprite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000490")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDB838", Offset = "0x1FDB838", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000491")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDB840", Offset = "0x1FDB840", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000492")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDB848", Offset = "0x1FDB848", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool Equals(SpriteState other)
		{
			throw null;
		}

		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000234")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Sprite m_HighlightedSprite;

		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000235")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private Sprite m_PressedSprite;

		[SerializeField]
		[FormerlySerializedAs("m_HighlightedSprite")]
		[global::Cpp2ILInjected.Token(Token = "0x4000236")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Sprite m_SelectedSprite;

		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000237")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Sprite m_DisabledSprite;
	}
}
