using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.EventSystems
{
	[global::Cpp2ILInjected.Token(Token = "0x20000B1")]
	public class BaseInput : UIBehaviour
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001AC")]
		public virtual string compositionString
		{
			[global::Cpp2ILInjected.Token(Token = "0x600064C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE7FEC", Offset = "0x1FE7FEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_compositionString", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001AD")]
		public virtual IMECompositionMode imeCompositionMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600064D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE7FF4", Offset = "0x1FE7FF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_imeCompositionMode", ReturnType = typeof(IMECompositionMode))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600064E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE7FFC", Offset = "0x1FE7FFC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "set_imeCompositionMode", MemberParameters = new object[] { typeof(IMECompositionMode) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001AE")]
		public virtual Vector2 compositionCursorPos
		{
			[global::Cpp2ILInjected.Token(Token = "0x600064F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE8008", Offset = "0x1FE8008", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_compositionCursorPos", ReturnType = typeof(Vector2))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000650")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE8010", Offset = "0x1FE8010", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "set_compositionCursorPos", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001AF")]
		public virtual bool mousePresent
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000651")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE8018", Offset = "0x1FE8018", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_mousePresent", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000652")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE8020", Offset = "0x1FE8020", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		public virtual bool GetMouseButtonDown(int button)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000653")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE802C", Offset = "0x1FE802C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		public virtual bool GetMouseButtonUp(int button)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000654")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE8038", Offset = "0x1FE8038", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		public virtual bool GetMouseButton(int button)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001B0")]
		public virtual Vector2 mousePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000655")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE8044", Offset = "0x1FE8044", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_mousePosition", ReturnType = typeof(Vector3))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001B1")]
		public virtual Vector2 mouseScrollDelta
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000656")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE804C", Offset = "0x1FE804C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_mouseScrollDelta", ReturnType = typeof(Vector2))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001B2")]
		public virtual bool touchSupported
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000657")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE8054", Offset = "0x1FE8054", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_touchSupported", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001B3")]
		public virtual int touchCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000658")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FE805C", Offset = "0x1FE805C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "get_touchCount", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000659")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE8064", Offset = "0x1FE8064", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Touch))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual Touch GetTouch(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600065A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE809C", Offset = "0x1FE809C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetAxisRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(float))]
		public virtual float GetAxisRaw(string axisName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600065B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE80A8", Offset = "0x1FE80A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetButtonDown", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		public virtual bool GetButtonDown(string buttonName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600065C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE80B4", Offset = "0x1FE80B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		public BaseInput()
		{
			throw null;
		}
	}
}
