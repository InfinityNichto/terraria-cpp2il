using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200006C RID: 108
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/DisplayManager.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000071")]
	public class Display
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x000023BF File Offset: 0x000005BF
		[global::Cpp2ILInjected.Token(Token = "0x60001B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74DE8", Offset = "0x1F74DE8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		internal Display()
		{
			throw null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000023C2 File Offset: 0x000005C2
		[global::Cpp2ILInjected.Token(Token = "0x60001BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74E24", Offset = "0x1F74E24", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal Display(IntPtr nativeDisplay)
		{
			throw null;
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x000023C5 File Offset: 0x000005C5
		[global::Cpp2ILInjected.Token(Token = "0x17000057")]
		public int renderingWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F74E4C", Offset = "0x1F74E4C", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000023C8 File Offset: 0x000005C8
		[global::Cpp2ILInjected.Token(Token = "0x17000058")]
		public int renderingHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F74F34", Offset = "0x1F74F34", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new object[]
			{
				"UnityEngine.UI.VertexHelper",
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasScaler", Member = "HandleScaleWithScreenSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x000023CB File Offset: 0x000005CB
		[global::Cpp2ILInjected.Token(Token = "0x17000059")]
		public int systemWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F74FC8", Offset = "0x1F74FC8", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x000023CE File Offset: 0x000005CE
		[global::Cpp2ILInjected.Token(Token = "0x1700005A")]
		public int systemHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F750B0", Offset = "0x1F750B0", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000023D1 File Offset: 0x000005D1
		[global::Cpp2ILInjected.Token(Token = "0x60001BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75144", Offset = "0x1F75144", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
		{
			throw null;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x000023D4 File Offset: 0x000005D4
		[global::Cpp2ILInjected.Token(Token = "0x1700005B")]
		public static Display main
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F75270", Offset = "0x1F75270", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MultipleDisplayUtilities", Member = "RelativeMouseAtScaled", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000023D7 File Offset: 0x000005D7
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60001C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F752C8", Offset = "0x1F752C8", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void RecreateDisplayList(IntPtr[] nativeDisplay)
		{
			throw null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000023DA File Offset: 0x000005DA
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x60001C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F753E0", Offset = "0x1F753E0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void FireDisplaysUpdated()
		{
			throw null;
		}

		// Token: 0x060001BB RID: 443
		[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
		[global::Cpp2ILInjected.Token(Token = "0x60001C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7505C", Offset = "0x1F7505C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h);

		// Token: 0x060001BC RID: 444
		[FreeFunction("UnityDisplayManager_DisplayRenderingResolution")]
		[global::Cpp2ILInjected.Token(Token = "0x60001C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74EE0", Offset = "0x1F74EE0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h);

		// Token: 0x060001BD RID: 445
		[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
		[global::Cpp2ILInjected.Token(Token = "0x60001C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75214", Offset = "0x1F75214", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern int RelativeMouseAtImpl(int x, int y, out int rx, out int ry);

		// Token: 0x060001BE RID: 446 RVA: 0x000023DD File Offset: 0x000005DD
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60001C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7546C", Offset = "0x1F7546C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static Display()
		{
			throw null;
		}

		// Token: 0x040002D6 RID: 726
		[global::Cpp2ILInjected.Token(Token = "0x40002DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal IntPtr nativeDisplay;

		// Token: 0x040002D7 RID: 727
		[global::Cpp2ILInjected.Token(Token = "0x40002DE")]
		public static Display[] displays;

		// Token: 0x040002D8 RID: 728
		[global::Cpp2ILInjected.Token(Token = "0x40002DF")]
		private static Display _mainDisplay;

		// Token: 0x040002D9 RID: 729
		[global::Cpp2ILInjected.Token(Token = "0x40002E0")]
		private static int m_ActiveEditorGameViewTarget;

		// Token: 0x040002DA RID: 730
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x40002E1")]
		private static Display.DisplaysUpdatedDelegate onDisplaysUpdated;

		// Token: 0x02000165 RID: 357
		// (Invoke) Token: 0x060006BD RID: 1725
		[global::Cpp2ILInjected.Token(Token = "0x2000072")]
		public delegate void DisplaysUpdatedDelegate();
	}
}
