using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000084 RID: 132
	[NativeHeader("Runtime/Input/TimeManager.h")]
	[StaticAccessor("GetTimeManager()", StaticAccessorType.Dot)]
	[global::Cpp2ILInjected.Token(Token = "0x2000091")]
	public class Time
	{
		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000279 RID: 633
		[global::Cpp2ILInjected.Token(Token = "0x17000090")]
		public static extern float deltaTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000287")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F78B70", Offset = "0x1F78B70", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 61)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600027A RID: 634
		[global::Cpp2ILInjected.Token(Token = "0x17000091")]
		public static extern float unscaledTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000288")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F78B98", Offset = "0x1F78B98", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessMousePress", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ProcessTouchPress", MemberParameters = new object[]
			{
				"UnityEngine.EventSystems.PointerEventData",
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField.<CaretBlink>d__172", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetCaretVisible", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateCaretFromKeyboard", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.StandaloneInputModule", Member = "ProcessTouchPress", MemberParameters = new object[]
			{
				"UnityEngine.EventSystems.PointerEventData",
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.StandaloneInputModule", Member = "SendMoveEventToSelectedObject", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.StandaloneInputModule", Member = "ProcessMousePress", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerInputModule.MouseButtonEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.TouchInputModule", Member = "ProcessTouchPress", MemberParameters = new object[]
			{
				"UnityEngine.EventSystems.PointerEventData",
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600027B RID: 635
		[global::Cpp2ILInjected.Token(Token = "0x17000092")]
		public static extern float unscaledDeltaTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000289")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F78BC0", Offset = "0x1F78BC0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchStickControl", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Button.<OnFinishSubmit>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CoroutineTween.TweenRunner`1.<Start>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600027C RID: 636
		[global::Cpp2ILInjected.Token(Token = "0x17000093")]
		public static extern float fixedDeltaTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F78BE8", Offset = "0x1F78BE8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.NativeInputDeviceManager", Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600027D RID: 637
		// (set) Token: 0x0600027E RID: 638
		[global::Cpp2ILInjected.Token(Token = "0x17000094")]
		public static extern float timeScale
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F78C10", Offset = "0x1F78C10", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlManager", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x600028C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F78C38", Offset = "0x1F78C38", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "CheckForPauseButton", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600027F RID: 639
		[global::Cpp2ILInjected.Token(Token = "0x17000095")]
		public static extern int frameCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F78C70", Offset = "0x1F78C70", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrKeyboard_IME", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000280 RID: 640
		[NativeProperty("Realtime")]
		[global::Cpp2ILInjected.Token(Token = "0x17000096")]
		public static extern float realtimeSinceStartup
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F78C98", Offset = "0x1F78C98", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.OneAxisInputControl", Member = "Commit", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "SendVectorEventToSelectedObject", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "UpdateInputState", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "SetVectorRepeatTimer", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InputManager", Member = "UpdateCurrentTime", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchTrackControl", Member = "TouchBegan", MemberParameters = new object[] { "InControl.Touch" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchTrackControl", Member = "TouchEnded", MemberParameters = new object[] { "InControl.Touch" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}
	}
}
