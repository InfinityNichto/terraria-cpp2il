using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x2000002")]
	[Serializable]
	public class AnimationTriggers
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000001")]
		public string normalTrigger
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000001")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5E94", Offset = "0x1FA5E94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000002")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5E9C", Offset = "0x1FA5E9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000002")]
		public string highlightedTrigger
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000003")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5EA4", Offset = "0x1FA5EA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000004")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5EAC", Offset = "0x1FA5EAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000003")]
		public string pressedTrigger
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000005")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5EB4", Offset = "0x1FA5EB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000006")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5EBC", Offset = "0x1FA5EBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		public string selectedTrigger
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000007")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5EC4", Offset = "0x1FA5EC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000008")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5ECC", Offset = "0x1FA5ECC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		public string disabledTrigger
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000009")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5ED4", Offset = "0x1FA5ED4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600000A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA5EDC", Offset = "0x1FA5EDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600000B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA5EE4", Offset = "0x1FA5EE4", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public AnimationTriggers()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000001")]
		private const string kDefaultNormalAnimName = "Normal";

		[global::Cpp2ILInjected.Token(Token = "0x4000002")]
		private const string kDefaultHighlightedAnimName = "Highlighted";

		[global::Cpp2ILInjected.Token(Token = "0x4000003")]
		private const string kDefaultPressedAnimName = "Pressed";

		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		private const string kDefaultSelectedAnimName = "Selected";

		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		private const string kDefaultDisabledAnimName = "Disabled";

		[FormerlySerializedAs("normalTrigger")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string m_NormalTrigger;

		[FormerlySerializedAs("highlightedTrigger")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string m_HighlightedTrigger;

		[FormerlySerializedAs("pressedTrigger")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string m_PressedTrigger;

		[FormerlySerializedAs("m_HighlightedTrigger")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string m_SelectedTrigger;

		[FormerlySerializedAs("disabledTrigger")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400000A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string m_DisabledTrigger;
	}
}
