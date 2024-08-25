using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/UI/CanvasGroup.h")]
	[NativeClass("UI::CanvasGroup")]
	[global::Cpp2ILInjected.Token(Token = "0x200000A")]
	public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
	{
		[NativeProperty("Alpha", false, TargetType.Function)]
		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		public extern float alpha
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000058")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF1FF8", Offset = "0x1FF1FF8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "AlphaFadeList", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000059")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF2034", Offset = "0x1FF2034", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetAlpha", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		[NativeProperty("Interactable", false, TargetType.Function)]
		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		public extern bool interactable
		{
			[global::Cpp2ILInjected.Token(Token = "0x600005A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF2080", Offset = "0x1FF2080", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "OnCanvasGroupChanged", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		[NativeProperty("BlocksRaycasts", false, TargetType.Function)]
		[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
		public extern bool blocksRaycasts
		{
			[global::Cpp2ILInjected.Token(Token = "0x600005B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF20BC", Offset = "0x1FF20BC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		[NativeProperty("IgnoreParentGroups", false, TargetType.Function)]
		[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
		public extern bool ignoreParentGroups
		{
			[global::Cpp2ILInjected.Token(Token = "0x600005C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FF20F8", Offset = "0x1FF20F8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "Raycast", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Camera)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "OnCanvasGroupChanged", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600005D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FF2134", Offset = "0x1FF2134", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			throw null;
		}
	}
}
