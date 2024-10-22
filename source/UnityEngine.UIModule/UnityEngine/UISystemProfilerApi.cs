﻿using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[StaticAccessor("UI::SystemProfilerApi", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/UI/Canvas.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000007")]
	public static class UISystemProfilerApi
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000054")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FF1F3C", Offset = "0x1FF1F3C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasUpdateRegistry", Member = "PerformUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void BeginSample(UISystemProfilerApi.SampleType type);

		[global::Cpp2ILInjected.Token(Token = "0x6000055")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FF1F78", Offset = "0x1FF1F78", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasUpdateRegistry", Member = "PerformUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void EndSample(UISystemProfilerApi.SampleType type);

		[global::Cpp2ILInjected.Token(Token = "0x6000056")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FF1FB4", Offset = "0x1FF1FB4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Button", Member = "Press", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Set", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "SendOnValueChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "SendOnEndEdit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "SendOnSubmit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "UpdateCull", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Scrollbar", Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Slider", Member = "OnDidApplyAnimationProperties", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Slider", Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Toggle", Member = "Set", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void AddMarker(string name, Object obj);

		[global::Cpp2ILInjected.Token(Token = "0x2000008")]
		public enum SampleType
		{
			[global::Cpp2ILInjected.Token(Token = "0x400000D")]
			Layout,
			[global::Cpp2ILInjected.Token(Token = "0x400000E")]
			Render
		}
	}
}
