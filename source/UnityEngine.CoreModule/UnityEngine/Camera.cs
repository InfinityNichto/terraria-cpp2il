using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000075 RID: 117
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[NativeHeader("Runtime/Shaders/Shader.h")]
	[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Camera/RenderManager.h")]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200007D")]
	public sealed class Camera : Behaviour
	{
		// Token: 0x060001EB RID: 491 RVA: 0x00002419 File Offset: 0x00000619
		[global::Cpp2ILInjected.Token(Token = "0x60001F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F760A0", Offset = "0x1F760A0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = ".ctor", ReturnType = typeof(void))]
		public Camera()
		{
			throw null;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001EC RID: 492
		[NativeProperty("Near")]
		[global::Cpp2ILInjected.Token(Token = "0x17000060")]
		public extern float nearClipPlane
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F760A8", Offset = "0x1F760A8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new object[]
			{
				"UnityEngine.EventSystems.PointerEventData",
				typeof(ref Ray),
				typeof(ref int),
				typeof(ref float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001ED RID: 493
		[NativeProperty("Far")]
		[global::Cpp2ILInjected.Token(Token = "0x17000061")]
		public extern float farClipPlane
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F760E4", Offset = "0x1F760E4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[]
			{
				"UnityEngine.Canvas",
				typeof(Camera),
				typeof(Vector2),
				"System.Collections.Generic.IList`1<Graphic>",
				"System.Collections.Generic.List`1<Graphic>"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new object[]
			{
				"UnityEngine.EventSystems.PointerEventData",
				typeof(ref Ray),
				typeof(ref int),
				typeof(ref float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001EE RID: 494
		[NativeProperty("VerticalFieldOfView")]
		[global::Cpp2ILInjected.Token(Token = "0x17000062")]
		public extern float fieldOfView
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F76120", Offset = "0x1F76120", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CameraExtensions", Member = "GetHFOV", MemberParameters = new object[] { typeof(Camera) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001EF RID: 495
		[global::Cpp2ILInjected.Token(Token = "0x17000063")]
		public extern float orthographicSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7615C", Offset = "0x1F7615C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "UpdateScreenSize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "TouchCameraIsValid", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001F0 RID: 496
		[global::Cpp2ILInjected.Token(Token = "0x17000064")]
		public extern float depth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F76198", Offset = "0x1F76198", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "RaycastComparer", MemberParameters = new object[] { "UnityEngine.EventSystems.RaycastResult", "UnityEngine.EventSystems.RaycastResult" }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "get_depth", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001F1 RID: 497
		[global::Cpp2ILInjected.Token(Token = "0x17000065")]
		public extern float aspect
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F761D4", Offset = "0x1F761D4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CameraExtensions", Member = "GetHFOV", MemberParameters = new object[] { typeof(Camera) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001F2 RID: 498
		[global::Cpp2ILInjected.Token(Token = "0x17000066")]
		public extern int cullingMask
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F76210", Offset = "0x1F76210", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "GameObjectIsCulledOnCurrentCamera", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "get_finalEventMask", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001F3 RID: 499
		[global::Cpp2ILInjected.Token(Token = "0x17000067")]
		public extern int eventMask
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7624C", Offset = "0x1F7624C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000066 RID: 102
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x0000241C File Offset: 0x0000061C
		[global::Cpp2ILInjected.Token(Token = "0x17000068")]
		public Color backgroundColor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000200")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F76288", Offset = "0x1F76288", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DistortionRenderTargetManager", Member = "BeginRenderTarget", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001F5 RID: 501
		// (set) Token: 0x060001F6 RID: 502
		[global::Cpp2ILInjected.Token(Token = "0x17000069")]
		public extern CameraClearFlags clearFlags
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000201")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F76320", Offset = "0x1F76320", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000202")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7635C", Offset = "0x1F7635C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DistortionRenderTargetManager", Member = "BeginRenderTarget", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000241F File Offset: 0x0000061F
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002422 File Offset: 0x00000622
		[NativeProperty("NormalizedViewportRect")]
		[global::Cpp2ILInjected.Token(Token = "0x1700006A")]
		public Rect rect
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000203")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F763A0", Offset = "0x1F763A0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "get_ViewportRegion", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "TouchCameraIsValid", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000204")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7643C", Offset = "0x1F7643C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "UpdateViewport", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAWorldCameraSettings", Member = "UpdateViewport", MemberParameters = new object[] { typeof(Rect) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAWorldCameraSettings", Member = "ApplyCamera", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "UpdateScreenSize", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00002425 File Offset: 0x00000625
		[NativeProperty("ScreenViewportRect")]
		[global::Cpp2ILInjected.Token(Token = "0x1700006B")]
		public Rect pixelRect
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000205")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F764D4", Offset = "0x1F764D4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "TouchCameraIsValid", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new object[]
			{
				"UnityEngine.EventSystems.PointerEventData",
				typeof(ref Ray),
				typeof(ref int),
				typeof(ref float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001FA RID: 506
		[global::Cpp2ILInjected.Token(Token = "0x1700006C")]
		public extern int pixelWidth
		{
			[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = true)]
			[global::Cpp2ILInjected.Token(Token = "0x6000206")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F76570", Offset = "0x1F76570", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "GetCurrentScreenSize", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001FB RID: 507
		[global::Cpp2ILInjected.Token(Token = "0x1700006D")]
		public extern int pixelHeight
		{
			[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = true)]
			[global::Cpp2ILInjected.Token(Token = "0x6000207")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F765AC", Offset = "0x1F765AC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "GetCurrentScreenSize", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001FC RID: 508
		// (set) Token: 0x060001FD RID: 509
		[global::Cpp2ILInjected.Token(Token = "0x1700006E")]
		public extern RenderTexture targetTexture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000208")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F765E8", Offset = "0x1F765E8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x6000209")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F76624", Offset = "0x1F76624", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DistortionRenderTargetManager", Member = "InitialiseCamera", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DistortionRenderTargetManager", Member = "SwapTargets", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WaterRenderTargetManager", Member = "InitialiseCamera", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001FE RID: 510
		[global::Cpp2ILInjected.Token(Token = "0x1700006F")]
		public extern int targetDisplay
		{
			[global::Cpp2ILInjected.Token(Token = "0x600020A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F76668", Offset = "0x1F76668", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new object[]
			{
				"UnityEngine.EventSystems.PointerEventData",
				typeof(ref Ray),
				typeof(ref int),
				typeof(ref float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x1700006E RID: 110
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002428 File Offset: 0x00000628
		[global::Cpp2ILInjected.Token(Token = "0x17000070")]
		public Matrix4x4 projectionMatrix
		{
			[global::Cpp2ILInjected.Token(Token = "0x600020B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F766A4", Offset = "0x1F766A4", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DistortionRenderTargetManager", Member = "InitialiseCamera", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WaterRenderTargetManager", Member = "InitialiseCamera", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "ApplyCamera", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAWorldCameraSettings", Member = "ApplyCamera", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000242B File Offset: 0x0000062B
		[global::Cpp2ILInjected.Token(Token = "0x600020C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7672C", Offset = "0x1F7672C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			throw null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000242E File Offset: 0x0000062E
		[global::Cpp2ILInjected.Token(Token = "0x600020D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F767F8", Offset = "0x1F767F8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Camera), Member = "ViewportToWorldPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Vector3 ViewportToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			throw null;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002431 File Offset: 0x00000631
		[global::Cpp2ILInjected.Token(Token = "0x600020E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F768C4", Offset = "0x1F768C4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Camera), Member = "ScreenToWorldPoint", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Vector3 ScreenToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye)
		{
			throw null;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002434 File Offset: 0x00000634
		[global::Cpp2ILInjected.Token(Token = "0x600020F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76990", Offset = "0x1F76990", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[]
		{
			"UnityEngine.Canvas",
			typeof(Camera),
			typeof(Vector2),
			"System.Collections.Generic.IList`1<Graphic>",
			"System.Collections.Generic.List`1<Graphic>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "WorldToScreenPoint", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Vector3)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "WorldToScreenPoint", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Camera.MonoOrStereoscopicEye)
		}, ReturnType = typeof(Vector3))]
		public Vector3 WorldToScreenPoint(Vector3 position)
		{
			throw null;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002437 File Offset: 0x00000637
		[global::Cpp2ILInjected.Token(Token = "0x6000210")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76998", Offset = "0x1F76998", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "ConvertViewToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "ViewportToWorldPoint", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Camera.MonoOrStereoscopicEye)
		}, ReturnType = typeof(Vector3))]
		public Vector3 ViewportToWorldPoint(Vector3 position)
		{
			throw null;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000243A File Offset: 0x0000063A
		[global::Cpp2ILInjected.Token(Token = "0x6000211")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F769A0", Offset = "0x1F769A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "ConvertScreenToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "ScreenToWorldPoint", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Camera.MonoOrStereoscopicEye)
		}, ReturnType = typeof(Vector3))]
		public Vector3 ScreenToWorldPoint(Vector3 position)
		{
			throw null;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000243D File Offset: 0x0000063D
		[global::Cpp2ILInjected.Token(Token = "0x6000212")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F769A8", Offset = "0x1F769A8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "ConvertScreenToViewPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Vector3 ScreenToViewportPoint(Vector3 position)
		{
			throw null;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002440 File Offset: 0x00000640
		[global::Cpp2ILInjected.Token(Token = "0x6000213")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76A64", Offset = "0x1F76A64", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Camera.MonoOrStereoscopicEye)
		}, ReturnType = typeof(Ray))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Ray))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye)
		{
			throw null;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002443 File Offset: 0x00000643
		[global::Cpp2ILInjected.Token(Token = "0x6000214")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76B38", Offset = "0x1F76B38", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Camera.MonoOrStereoscopicEye)
		}, ReturnType = typeof(Ray))]
		public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye)
		{
			throw null;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002446 File Offset: 0x00000646
		[global::Cpp2ILInjected.Token(Token = "0x6000215")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76B70", Offset = "0x1F76B70", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new object[]
		{
			"UnityEngine.EventSystems.PointerEventData",
			typeof(ref Ray),
			typeof(ref int),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToRay", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Vector2)
		}, ReturnType = typeof(Ray))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Camera.MonoOrStereoscopicEye)
		}, ReturnType = typeof(Ray))]
		public Ray ScreenPointToRay(Vector3 pos)
		{
			throw null;
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600020A RID: 522
		[global::Cpp2ILInjected.Token(Token = "0x17000071")]
		public static extern Camera main
		{
			[FreeFunction("FindMainCamera")]
			[global::Cpp2ILInjected.Token(Token = "0x6000216")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F76BBC", Offset = "0x1F76BBC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_eventCamera", ReturnType = typeof(Camera))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "get_eventCamera", ReturnType = typeof(Camera))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600020B RID: 523
		[global::Cpp2ILInjected.Token(Token = "0x17000072")]
		public static extern Camera current
		{
			[FreeFunction("GetCurrentCameraPPtr")]
			[global::Cpp2ILInjected.Token(Token = "0x6000217")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F76BE4", Offset = "0x1F76BE4", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "GameObjectIsCulledOnCurrentCamera", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x0600020C RID: 524
		[FreeFunction("CameraScripting::GetAllCamerasCount")]
		[global::Cpp2ILInjected.Token(Token = "0x6000218")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76C0C", Offset = "0x1F76C0C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern int GetAllCamerasCount();

		// Token: 0x0600020D RID: 525
		[FreeFunction("CameraScripting::GetAllCameras")]
		[global::Cpp2ILInjected.Token(Token = "0x6000219")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76C34", Offset = "0x1F76C34", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern int GetAllCamerasImpl([NotNull("ArgumentNullException")] [Out] Camera[] cam);

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00002449 File Offset: 0x00000649
		[global::Cpp2ILInjected.Token(Token = "0x17000073")]
		public static int allCamerasCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x600021A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F76C70", Offset = "0x1F76C70", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000244C File Offset: 0x0000064C
		[global::Cpp2ILInjected.Token(Token = "0x600021B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76C98", Offset = "0x1F76C98", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static int GetAllCameras(Camera[] cameras)
		{
			throw null;
		}

		// Token: 0x06000210 RID: 528
		[FreeFunction("CameraScripting::Render", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x600021C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76D70", Offset = "0x1F76D70", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DistortionRenderTargetManager", Member = "EndRenderTarget", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WaterRenderTargetManager", Member = "UpdateRenderTarget", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern void Render();

		// Token: 0x06000211 RID: 529 RVA: 0x0000244F File Offset: 0x0000064F
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600021D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76DAC", Offset = "0x1F76DAC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void FireOnPreCull(Camera cam)
		{
			throw null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00002452 File Offset: 0x00000652
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600021E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76E18", Offset = "0x1F76E18", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void FireOnPreRender(Camera cam)
		{
			throw null;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002455 File Offset: 0x00000655
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600021F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76E84", Offset = "0x1F76E84", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void FireOnPostRender(Camera cam)
		{
			throw null;
		}

		// Token: 0x06000214 RID: 532
		[global::Cpp2ILInjected.Token(Token = "0x6000220")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F762DC", Offset = "0x1F762DC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void set_backgroundColor_Injected(ref Color value);

		// Token: 0x06000215 RID: 533
		[global::Cpp2ILInjected.Token(Token = "0x6000221")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F763F8", Offset = "0x1F763F8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_rect_Injected(out Rect ret);

		// Token: 0x06000216 RID: 534
		[global::Cpp2ILInjected.Token(Token = "0x6000222")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76490", Offset = "0x1F76490", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void set_rect_Injected(ref Rect value);

		// Token: 0x06000217 RID: 535
		[global::Cpp2ILInjected.Token(Token = "0x6000223")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7652C", Offset = "0x1F7652C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_pixelRect_Injected(out Rect ret);

		// Token: 0x06000218 RID: 536
		[global::Cpp2ILInjected.Token(Token = "0x6000224")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F766E8", Offset = "0x1F766E8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void set_projectionMatrix_Injected(ref Matrix4x4 value);

		// Token: 0x06000219 RID: 537
		[global::Cpp2ILInjected.Token(Token = "0x6000225")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7679C", Offset = "0x1F7679C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void WorldToScreenPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret);

		// Token: 0x0600021A RID: 538
		[global::Cpp2ILInjected.Token(Token = "0x6000226")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76868", Offset = "0x1F76868", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void ViewportToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret);

		// Token: 0x0600021B RID: 539
		[global::Cpp2ILInjected.Token(Token = "0x6000227")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76934", Offset = "0x1F76934", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void ScreenToWorldPoint_Injected(ref Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret);

		// Token: 0x0600021C RID: 540
		[global::Cpp2ILInjected.Token(Token = "0x6000228")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76A10", Offset = "0x1F76A10", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret);

		// Token: 0x0600021D RID: 541
		[global::Cpp2ILInjected.Token(Token = "0x6000229")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F76ADC", Offset = "0x1F76ADC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void ScreenPointToRay_Injected(ref Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret);

		// Token: 0x040002E7 RID: 743
		[global::Cpp2ILInjected.Token(Token = "0x40002F1")]
		public static Camera.CameraCallback onPreCull;

		// Token: 0x040002E8 RID: 744
		[global::Cpp2ILInjected.Token(Token = "0x40002F2")]
		public static Camera.CameraCallback onPreRender;

		// Token: 0x040002E9 RID: 745
		[global::Cpp2ILInjected.Token(Token = "0x40002F3")]
		public static Camera.CameraCallback onPostRender;

		// Token: 0x02000168 RID: 360
		[global::Cpp2ILInjected.Token(Token = "0x200007E")]
		public enum MonoOrStereoscopicEye
		{
			// Token: 0x0400063B RID: 1595
			[global::Cpp2ILInjected.Token(Token = "0x40002F5")]
			Left,
			// Token: 0x0400063C RID: 1596
			[global::Cpp2ILInjected.Token(Token = "0x40002F6")]
			Right,
			// Token: 0x0400063D RID: 1597
			[global::Cpp2ILInjected.Token(Token = "0x40002F7")]
			Mono
		}

		// Token: 0x02000169 RID: 361
		[global::Cpp2ILInjected.Token(Token = "0x200007F")]
		public enum RenderRequestMode
		{
			// Token: 0x0400063F RID: 1599
			[global::Cpp2ILInjected.Token(Token = "0x40002F9")]
			None,
			// Token: 0x04000640 RID: 1600
			[global::Cpp2ILInjected.Token(Token = "0x40002FA")]
			ObjectId,
			// Token: 0x04000641 RID: 1601
			[global::Cpp2ILInjected.Token(Token = "0x40002FB")]
			Depth,
			// Token: 0x04000642 RID: 1602
			[global::Cpp2ILInjected.Token(Token = "0x40002FC")]
			VertexNormal,
			// Token: 0x04000643 RID: 1603
			[global::Cpp2ILInjected.Token(Token = "0x40002FD")]
			WorldPosition,
			// Token: 0x04000644 RID: 1604
			[global::Cpp2ILInjected.Token(Token = "0x40002FE")]
			EntityId,
			// Token: 0x04000645 RID: 1605
			[global::Cpp2ILInjected.Token(Token = "0x40002FF")]
			BaseColor,
			// Token: 0x04000646 RID: 1606
			[global::Cpp2ILInjected.Token(Token = "0x4000300")]
			SpecularColor,
			// Token: 0x04000647 RID: 1607
			[global::Cpp2ILInjected.Token(Token = "0x4000301")]
			Metallic,
			// Token: 0x04000648 RID: 1608
			[global::Cpp2ILInjected.Token(Token = "0x4000302")]
			Emission,
			// Token: 0x04000649 RID: 1609
			[global::Cpp2ILInjected.Token(Token = "0x4000303")]
			Normal,
			// Token: 0x0400064A RID: 1610
			[global::Cpp2ILInjected.Token(Token = "0x4000304")]
			Smoothness,
			// Token: 0x0400064B RID: 1611
			[global::Cpp2ILInjected.Token(Token = "0x4000305")]
			Occlusion,
			// Token: 0x0400064C RID: 1612
			[global::Cpp2ILInjected.Token(Token = "0x4000306")]
			DiffuseColor
		}

		// Token: 0x0200016A RID: 362
		[global::Cpp2ILInjected.Token(Token = "0x2000080")]
		public enum RenderRequestOutputSpace
		{
			// Token: 0x0400064E RID: 1614
			[global::Cpp2ILInjected.Token(Token = "0x4000308")]
			ScreenSpace = -1,
			// Token: 0x0400064F RID: 1615
			[global::Cpp2ILInjected.Token(Token = "0x4000309")]
			UV0,
			// Token: 0x04000650 RID: 1616
			[global::Cpp2ILInjected.Token(Token = "0x400030A")]
			UV1,
			// Token: 0x04000651 RID: 1617
			[global::Cpp2ILInjected.Token(Token = "0x400030B")]
			UV2,
			// Token: 0x04000652 RID: 1618
			[global::Cpp2ILInjected.Token(Token = "0x400030C")]
			UV3,
			// Token: 0x04000653 RID: 1619
			[global::Cpp2ILInjected.Token(Token = "0x400030D")]
			UV4,
			// Token: 0x04000654 RID: 1620
			[global::Cpp2ILInjected.Token(Token = "0x400030E")]
			UV5,
			// Token: 0x04000655 RID: 1621
			[global::Cpp2ILInjected.Token(Token = "0x400030F")]
			UV6,
			// Token: 0x04000656 RID: 1622
			[global::Cpp2ILInjected.Token(Token = "0x4000310")]
			UV7,
			// Token: 0x04000657 RID: 1623
			[global::Cpp2ILInjected.Token(Token = "0x4000311")]
			UV8
		}

		// Token: 0x0200016B RID: 363
		[global::Cpp2ILInjected.Token(Token = "0x2000081")]
		public struct RenderRequest
		{
			// Token: 0x04000658 RID: 1624
			[global::Cpp2ILInjected.Token(Token = "0x4000312")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly Camera.RenderRequestMode m_CameraRenderMode;

			// Token: 0x04000659 RID: 1625
			[global::Cpp2ILInjected.Token(Token = "0x4000313")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private readonly RenderTexture m_ResultRT;

			// Token: 0x0400065A RID: 1626
			[global::Cpp2ILInjected.Token(Token = "0x4000314")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private readonly Camera.RenderRequestOutputSpace m_OutputSpace;
		}

		// Token: 0x0200016C RID: 364
		// (Invoke) Token: 0x060006C1 RID: 1729
		[global::Cpp2ILInjected.Token(Token = "0x2000082")]
		public delegate void CameraCallback(Camera cam);
	}
}
