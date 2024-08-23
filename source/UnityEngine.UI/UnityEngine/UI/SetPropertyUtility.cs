using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.UI
{
	// Token: 0x02000035 RID: 53
	[global::Cpp2ILInjected.Token(Token = "0x200006A")]
	internal static class SetPropertyUtility
	{
		// Token: 0x060003F5 RID: 1013 RVA: 0x00002BD8 File Offset: 0x00000DD8
		[global::Cpp2ILInjected.Token(Token = "0x6000457")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD9E90", Offset = "0x1FD9E90", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "set_color", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_caretColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_selectionColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public static bool SetColor(ref Color currentValue, Color newValue)
		{
			throw null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002BDB File Offset: 0x00000DDB
		[global::Cpp2ILInjected.Token(Token = "0x6000458")]
		[global::Cpp2ILInjected.Address(RVA = "0x159D208", Offset = "0x159D208", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "set_preserveAspect", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "set_fillCenter", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "set_fillClockwise", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "set_useSpriteMesh", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_shouldHideMobileInput", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LayoutElement), Member = "set_ignoreLayout", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "set_interactable", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "set_wholeNumbers", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public static bool SetStruct<T>(ref T currentValue, T newValue) where T : struct
		{
			throw null;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002BDE File Offset: 0x00000DDE
		[global::Cpp2ILInjected.Token(Token = "0x6000459")]
		[global::Cpp2ILInjected.Address(RVA = "0x159D1B8", Offset = "0x159D1B8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "set_overrideSprite", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_textComponent", MemberParameters = new object[] { typeof(Text) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_placeholder", MemberParameters = new object[] { typeof(Graphic) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_onEndEdit", MemberParameters = new object[] { typeof(InputField.EndEditEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_onSubmit", MemberParameters = new object[] { typeof(InputField.SubmitEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_onValueChanged", MemberParameters = new object[] { typeof(InputField.OnChangeEvent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputField), Member = "set_onValidateInput", MemberParameters = new object[] { typeof(InputField.OnValidateInput) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Scrollbar), Member = "set_handleRect", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "set_animationTriggers", MemberParameters = new object[] { typeof(AnimationTriggers) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "set_targetGraphic", MemberParameters = new object[] { typeof(Graphic) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "set_fillRect", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "set_handleRect", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		public static bool SetClass<T>(ref T currentValue, T newValue) where T : class
		{
			throw null;
		}
	}
}
