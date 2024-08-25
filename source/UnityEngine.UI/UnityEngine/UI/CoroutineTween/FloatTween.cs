using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;

namespace UnityEngine.UI.CoroutineTween
{
	[global::Cpp2ILInjected.Token(Token = "0x200008C")]
	internal struct FloatTween : ITweenValue
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000163")]
		public float startValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000567")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE36D4", Offset = "0x1FE36D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000568")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE36DC", Offset = "0x1FE36DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000164")]
		public float targetValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000569")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE36E4", Offset = "0x1FE36E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600056A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE36EC", Offset = "0x1FE36EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000165")]
		public float duration
		{
			[global::Cpp2ILInjected.Token(Token = "0x600056B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE36F4", Offset = "0x1FE36F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600056C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE36FC", Offset = "0x1FE36FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000166")]
		public bool ignoreTimeScale
		{
			[global::Cpp2ILInjected.Token(Token = "0x600056D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE3704", Offset = "0x1FE3704", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600056E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE370C", Offset = "0x1FE370C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600056F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE3718", Offset = "0x1FE3718", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<float>), Member = "Invoke", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void TweenValue(float floatPercentage)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000570")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE37B4", Offset = "0x1FE37B4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "AlphaFadeList", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatTween.FloatTweenCallback), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<float>), Member = "AddListener", MemberParameters = new object[] { typeof(UnityAction<float>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void AddOnChangedCallback(UnityAction<float> callback)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000571")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE3884", Offset = "0x1FE3884", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool GetIgnoreTimescale()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000572")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE388C", Offset = "0x1FE388C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float GetDuration()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000573")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE37A4", Offset = "0x1FE37A4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool ValidTarget()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400027C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private FloatTween.FloatTweenCallback m_Target;

		[global::Cpp2ILInjected.Token(Token = "0x400027D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private float m_StartValue;

		[global::Cpp2ILInjected.Token(Token = "0x400027E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private float m_TargetValue;

		[global::Cpp2ILInjected.Token(Token = "0x400027F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float m_Duration;

		[global::Cpp2ILInjected.Token(Token = "0x4000280")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private bool m_IgnoreTimeScale;

		[global::Cpp2ILInjected.Token(Token = "0x200008D")]
		public class FloatTweenCallback : UnityEvent<float>
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000574")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE383C", Offset = "0x1FE383C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FloatTween), Member = "AddOnChangedCallback", MemberParameters = new object[] { typeof(UnityAction<float>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<float>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public FloatTweenCallback()
			{
				throw null;
			}
		}
	}
}
