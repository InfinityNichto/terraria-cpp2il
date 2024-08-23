using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.EventSystems
{
	// Token: 0x02000066 RID: 102
	[global::Cpp2ILInjected.Token(Token = "0x20000B1")]
	public class BaseInput : UIBehaviour
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x000030DF File Offset: 0x000012DF
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

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005BE RID: 1470 RVA: 0x000030E2 File Offset: 0x000012E2
		// (set) Token: 0x060005BF RID: 1471 RVA: 0x000030E5 File Offset: 0x000012E5
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

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x000030E8 File Offset: 0x000012E8
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x000030EB File Offset: 0x000012EB
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

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x000030EE File Offset: 0x000012EE
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

		// Token: 0x060005C3 RID: 1475 RVA: 0x000030F1 File Offset: 0x000012F1
		[global::Cpp2ILInjected.Token(Token = "0x6000652")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE8020", Offset = "0x1FE8020", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButtonDown", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		public virtual bool GetMouseButtonDown(int button)
		{
			throw null;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x000030F4 File Offset: 0x000012F4
		[global::Cpp2ILInjected.Token(Token = "0x6000653")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE802C", Offset = "0x1FE802C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButtonUp", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		public virtual bool GetMouseButtonUp(int button)
		{
			throw null;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000030F7 File Offset: 0x000012F7
		[global::Cpp2ILInjected.Token(Token = "0x6000654")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE8038", Offset = "0x1FE8038", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetMouseButton", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		public virtual bool GetMouseButton(int button)
		{
			throw null;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x000030FA File Offset: 0x000012FA
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

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x000030FD File Offset: 0x000012FD
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

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00003100 File Offset: 0x00001300
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

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00003103 File Offset: 0x00001303
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

		// Token: 0x060005CA RID: 1482 RVA: 0x00003106 File Offset: 0x00001306
		[global::Cpp2ILInjected.Token(Token = "0x6000659")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE8064", Offset = "0x1FE8064", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetTouch", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Touch))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual Touch GetTouch(int index)
		{
			throw null;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00003109 File Offset: 0x00001309
		[global::Cpp2ILInjected.Token(Token = "0x600065A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE809C", Offset = "0x1FE809C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetAxisRaw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(float))]
		public virtual float GetAxisRaw(string axisName)
		{
			throw null;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0000310C File Offset: 0x0000130C
		[global::Cpp2ILInjected.Token(Token = "0x600065B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FE80A8", Offset = "0x1FE80A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetButtonDown", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		public virtual bool GetButtonDown(string buttonName)
		{
			throw null;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0000310F File Offset: 0x0000130F
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
