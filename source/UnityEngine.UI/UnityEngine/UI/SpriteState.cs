using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x02000037 RID: 55
	[global::Cpp2ILInjected.Token(Token = "0x200006F")]
	[Serializable]
	public struct SpriteState : IEquatable<SpriteState>
	{
		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00002C6E File Offset: 0x00000E6E
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00002C71 File Offset: 0x00000E71
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

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00002C74 File Offset: 0x00000E74
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00002C77 File Offset: 0x00000E77
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00002C7A File Offset: 0x00000E7A
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00002C7D File Offset: 0x00000E7D
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

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00002C80 File Offset: 0x00000E80
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x00002C83 File Offset: 0x00000E83
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

		// Token: 0x0600042F RID: 1071 RVA: 0x00002C86 File Offset: 0x00000E86
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

		// Token: 0x0400016B RID: 363
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000234")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Sprite m_HighlightedSprite;

		// Token: 0x0400016C RID: 364
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000235")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private Sprite m_PressedSprite;

		// Token: 0x0400016D RID: 365
		[SerializeField]
		[FormerlySerializedAs("m_HighlightedSprite")]
		[global::Cpp2ILInjected.Token(Token = "0x4000236")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Sprite m_SelectedSprite;

		// Token: 0x0400016E RID: 366
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000237")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Sprite m_DisabledSprite;
	}
}
