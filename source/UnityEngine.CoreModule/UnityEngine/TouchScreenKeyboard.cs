﻿using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Runtime/Input/KeyboardOnScreen.h")]
	[NativeConditional("ENABLE_ONSCREEN_KEYBOARD")]
	[NativeHeader("Runtime/Export/TouchScreenKeyboard/TouchScreenKeyboard.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000093")]
	public class TouchScreenKeyboard
	{
		[FreeFunction("TouchScreenKeyboard_Destroy", IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600028F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78CC0", Offset = "0x1F78CC0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_Destroy(IntPtr ptr);

		[global::Cpp2ILInjected.Token(Token = "0x6000290")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78CFC", Offset = "0x1F78CFC", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchScreenKeyboard), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void Destroy()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000291")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78DC8", Offset = "0x1F78DC8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = "Destroy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000292")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78E5C", Offset = "0x1F78E5C", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchScreenKeyboard), Member = "Open", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TouchScreenKeyboardType),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(TouchScreenKeyboard))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public TouchScreenKeyboard(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit)
		{
			throw null;
		}

		[FreeFunction("TouchScreenKeyboard_InternalConstructorHelper")]
		[global::Cpp2ILInjected.Token(Token = "0x6000293")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78FB8", Offset = "0x1F78FB8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder);

		[global::Cpp2ILInjected.Token(Token = "0x17000097")]
		public static bool isSupported
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000294")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7900C", Offset = "0x1F7900C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrKeyboard_Base", Member = "get_isSupported", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "InPlaceEditing", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "MayDrag", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnPointerDown", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000098")]
		internal static bool disableInPlaceEditing
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000295")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F79064", Offset = "0x1F79064", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000099")]
		public static bool isInPlaceEditingAllowed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000296")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F790AC", Offset = "0x1F790AC", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "TouchScreenKeyboardShouldBeUsed", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "InPlaceEditingChanged", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[FreeFunction("TouchScreenKeyboard_IsInplaceEditingAllowed")]
		[global::Cpp2ILInjected.Token(Token = "0x6000297")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F79118", Offset = "0x1F79118", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern bool IsInPlaceEditingAllowed();

		[global::Cpp2ILInjected.Token(Token = "0x6000298")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F79140", Offset = "0x1F79140", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrKeyboard_Touch", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TouchScreenKeyboardType),
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchScreenKeyboard), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TouchScreenKeyboardType),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static TouchScreenKeyboard Open(string text, [DefaultValue("TouchScreenKeyboardType.Default")] TouchScreenKeyboardType keyboardType, [DefaultValue("true")] bool autocorrection, [DefaultValue("false")] bool multiline, [DefaultValue("false")] bool secure, [DefaultValue("false")] bool alert, [DefaultValue("\"\"")] string textPlaceholder, [DefaultValue("0")] int characterLimit)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700009A")]
		public extern string text
		{
			[NativeName("GetText")]
			[global::Cpp2ILInjected.Token(Token = "0x6000299")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F791F8", Offset = "0x1F791F8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrKeyboard_Touch", Member = "get_text", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[NativeName("SetText")]
			[global::Cpp2ILInjected.Token(Token = "0x600029A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F79234", Offset = "0x1F79234", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrKeyboard_Touch", Member = "set_text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "SetText", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateTouchKeyboardFromEditChanges", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700009B")]
		public static extern bool hideInput
		{
			[NativeName("SetInputHidden")]
			[global::Cpp2ILInjected.Token(Token = "0x600029B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F79278", Offset = "0x1F79278", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputFieldInternal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700009C")]
		public extern bool active
		{
			[NativeName("IsActive")]
			[global::Cpp2ILInjected.Token(Token = "0x600029C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F792B4", Offset = "0x1F792B4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnPointerDown", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[NativeName("SetActive")]
			[global::Cpp2ILInjected.Token(Token = "0x600029D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F792F0", Offset = "0x1F792F0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrKeyboard_Touch", Member = "set_active", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrKeyboard_Touch", Member = "get_wasCanceled", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ActivateInputField", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "DeactivateInputField", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700009D")]
		public extern TouchScreenKeyboard.Status status
		{
			[NativeName("GetKeyboardStatus")]
			[global::Cpp2ILInjected.Token(Token = "0x600029E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F79334", Offset = "0x1F79334", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrKeyboard_Touch", Member = "get_active", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrKeyboard_Touch", Member = "get_done", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrKeyboard_Touch", Member = "get_wasCanceled", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700009E")]
		public extern int characterLimit
		{
			[NativeName("SetCharacterLimit")]
			[global::Cpp2ILInjected.Token(Token = "0x600029F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F79370", Offset = "0x1F79370", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "set_characterLimit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700009F")]
		public extern bool canGetSelection
		{
			[NativeName("CanGetSelection")]
			[global::Cpp2ILInjected.Token(Token = "0x60002A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F793B4", Offset = "0x1F793B4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000A0")]
		public extern bool canSetSelection
		{
			[NativeName("CanSetSelection")]
			[global::Cpp2ILInjected.Token(Token = "0x60002A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F793F0", Offset = "0x1F793F0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000A1")]
		public RangeInt selection
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7942C", Offset = "0x1F7942C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateCaretFromKeyboard", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F794C0", Offset = "0x1F794C0", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "LateUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7947C", Offset = "0x1F7947C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void GetSelection(out int start, out int length);

		[global::Cpp2ILInjected.Token(Token = "0x60002A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F795AC", Offset = "0x1F795AC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void SetSelection(int start, int length);

		[global::Cpp2ILInjected.Token(Token = "0x4000330")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		internal IntPtr m_Ptr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000331")]
		private static bool <disableInPlaceEditing>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x2000094")]
		public enum Status
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000333")]
			Visible,
			[global::Cpp2ILInjected.Token(Token = "0x4000334")]
			Done,
			[global::Cpp2ILInjected.Token(Token = "0x4000335")]
			Canceled,
			[global::Cpp2ILInjected.Token(Token = "0x4000336")]
			LostFocus
		}
	}
}
