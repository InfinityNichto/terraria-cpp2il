using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	[global::Cpp2ILInjected.Token(Token = "0x2000089")]
	internal struct ColorTween : ITweenValue
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700015E")]
		public Color startColor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000557")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE34A4", Offset = "0x1FE34A4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000558")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE34B0", Offset = "0x1FE34B0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700015F")]
		public Color targetColor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000559")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE34BC", Offset = "0x1FE34BC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600055A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE34C8", Offset = "0x1FE34C8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000160")]
		public ColorTween.ColorTweenMode tweenMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600055B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE34D4", Offset = "0x1FE34D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600055C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE34DC", Offset = "0x1FE34DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000161")]
		public float duration
		{
			[global::Cpp2ILInjected.Token(Token = "0x600055D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE34E4", Offset = "0x1FE34E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600055E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE34EC", Offset = "0x1FE34EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000162")]
		public bool ignoreTimeScale
		{
			[global::Cpp2ILInjected.Token(Token = "0x600055F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE34F4", Offset = "0x1FE34F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000560")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE34FC", Offset = "0x1FE34FC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000561")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE3508", Offset = "0x1FE3508", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CoroutineTween.TweenRunner`1.<Start>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TweenRunner<>), Member = "StartTween", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<Color>), Member = "Invoke", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void TweenValue(float floatPercentage)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000562")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE35F4", Offset = "0x1FE35F4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "CrossFadeColor", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ColorTween.ColorTweenCallback), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<Color>), Member = "AddListener", MemberParameters = new object[] { typeof(UnityAction<Color>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void AddOnChangedCallback(UnityAction<Color> callback)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000563")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE36C4", Offset = "0x1FE36C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool GetIgnoreTimescale()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000564")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE36CC", Offset = "0x1FE36CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float GetDuration()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000565")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE35E4", Offset = "0x1FE35E4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CoroutineTween.TweenRunner`1.<Start>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool ValidTarget()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000272")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ColorTween.ColorTweenCallback m_Target;

		[global::Cpp2ILInjected.Token(Token = "0x4000273")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private Color m_StartColor;

		[global::Cpp2ILInjected.Token(Token = "0x4000274")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Color m_TargetColor;

		[global::Cpp2ILInjected.Token(Token = "0x4000275")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ColorTween.ColorTweenMode m_TweenMode;

		[global::Cpp2ILInjected.Token(Token = "0x4000276")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private float m_Duration;

		[global::Cpp2ILInjected.Token(Token = "0x4000277")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool m_IgnoreTimeScale;

		[global::Cpp2ILInjected.Token(Token = "0x200008A")]
		public enum ColorTweenMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000279")]
			All,
			[global::Cpp2ILInjected.Token(Token = "0x400027A")]
			RGB,
			[global::Cpp2ILInjected.Token(Token = "0x400027B")]
			Alpha
		}

		[global::Cpp2ILInjected.Token(Token = "0x200008B")]
		public class ColorTweenCallback : UnityEvent<Color>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000566")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE367C", Offset = "0x1FE367C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ColorTween), Member = "AddOnChangedCallback", MemberParameters = new object[] { typeof(UnityAction<Color>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<Color>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public ColorTweenCallback()
			{
				throw null;
			}
		}
	}
}
