using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.UI;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200006F RID: 111
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Event/Physics Raycaster")]
	[global::Cpp2ILInjected.Token(Token = "0x20000BE")]
	public class PhysicsRaycaster : BaseRaycaster
	{
		// Token: 0x0600063B RID: 1595 RVA: 0x00003250 File Offset: 0x00001450
		[global::Cpp2ILInjected.Token(Token = "0x60006D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FED8C4", Offset = "0x1FED8C4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayerMask), Member = "op_Implicit", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(LayerMask))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		protected PhysicsRaycaster()
		{
			throw null;
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00003253 File Offset: 0x00001453
		[global::Cpp2ILInjected.Token(Token = "0x170001CA")]
		public override Camera eventCamera
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEE19C", Offset = "0x1FEE19C", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_main", ReturnType = typeof(Camera))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00003256 File Offset: 0x00001456
		[global::Cpp2ILInjected.Token(Token = "0x170001CB")]
		public virtual int depth
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEE240", Offset = "0x1FEE240", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_depth", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x00003259 File Offset: 0x00001459
		[global::Cpp2ILInjected.Token(Token = "0x170001CC")]
		public int finalEventMask
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEE0E0", Offset = "0x1FEE0E0", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Physics2DRaycaster), Member = "Raycast", MemberParameters = new object[]
			{
				typeof(PointerEventData),
				typeof(List<RaycastResult>)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PhysicsRaycaster), Member = "Raycast", MemberParameters = new object[]
			{
				typeof(PointerEventData),
				typeof(List<RaycastResult>)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_cullingMask", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayerMask), Member = "op_Implicit", MemberParameters = new object[] { typeof(LayerMask) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x0000325C File Offset: 0x0000145C
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x0000325F File Offset: 0x0000145F
		[global::Cpp2ILInjected.Token(Token = "0x170001CD")]
		public LayerMask eventMask
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEE2FC", Offset = "0x1FEE2FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60006DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEE304", Offset = "0x1FEE304", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x00003262 File Offset: 0x00001462
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x00003265 File Offset: 0x00001465
		[global::Cpp2ILInjected.Token(Token = "0x170001CE")]
		public int maxRayIntersections
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEE30C", Offset = "0x1FEE30C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60006DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEE314", Offset = "0x1FEE314", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00003268 File Offset: 0x00001468
		[global::Cpp2ILInjected.Token(Token = "0x60006DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEDE04", Offset = "0x1FEDE04", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Physics2DRaycaster), Member = "Raycast", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(List<RaycastResult>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PhysicsRaycaster), Member = "Raycast", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(List<RaycastResult>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MultipleDisplayUtilities), Member = "RelativeMouseAtScaled", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_targetDisplay", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_pixelRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "Contains", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "ScreenPointToRay", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Ray))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ray), Member = "get_direction", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_farClipPlane", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "get_nearClipPlane", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane)
		{
			throw null;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0000326B File Offset: 0x0000146B
		[global::Cpp2ILInjected.Token(Token = "0x60006E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FEE31C", Offset = "0x1FEE31C", Length = "0x364")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PhysicsRaycaster), Member = "ComputeRayAndDistance", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(ref Ray),
			typeof(ref int),
			typeof(ref float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReflectionMethodsCache), Member = "get_Singleton", ReturnType = typeof(ReflectionMethodsCache))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PhysicsRaycaster), Member = "get_finalEventMask", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Sort", MemberTypeParameters = new object[] { typeof(RaycastHit) }, MemberParameters = new object[]
		{
			typeof(RaycastHit[]),
			typeof(int),
			typeof(int),
			typeof(IComparer<RaycastHit>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RaycastHit), Member = "get_collider", ReturnType = typeof(Collider))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RaycastHit), Member = "get_distance", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RaycastHit), Member = "get_point", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RaycastHit), Member = "get_normal", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
			throw null;
		}

		// Token: 0x04000225 RID: 549
		[global::Cpp2ILInjected.Token(Token = "0x4000319")]
		protected const int kNoEventMaskSet = -1;

		// Token: 0x04000226 RID: 550
		[global::Cpp2ILInjected.Token(Token = "0x400031A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected Camera m_EventCamera;

		// Token: 0x04000227 RID: 551
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400031B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected LayerMask m_EventMask;

		// Token: 0x04000228 RID: 552
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400031C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		protected int m_MaxRayIntersections;

		// Token: 0x04000229 RID: 553
		[global::Cpp2ILInjected.Token(Token = "0x400031D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected int m_LastMaxRayIntersections;

		// Token: 0x0400022A RID: 554
		[global::Cpp2ILInjected.Token(Token = "0x400031E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private RaycastHit[] m_Hits;

		// Token: 0x020000CE RID: 206
		[global::Cpp2ILInjected.Token(Token = "0x20000BF")]
		private class RaycastHitComparer : IComparer<RaycastHit>
		{
			// Token: 0x06000700 RID: 1792 RVA: 0x0000343C File Offset: 0x0000163C
			[global::Cpp2ILInjected.Token(Token = "0x60006E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEE680", Offset = "0x1FEE680", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RaycastHit), Member = "get_distance", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
			public int Compare(RaycastHit x, RaycastHit y)
			{
				throw null;
			}

			// Token: 0x06000701 RID: 1793 RVA: 0x0000343F File Offset: 0x0000163F
			[global::Cpp2ILInjected.Token(Token = "0x60006E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEE6C0", Offset = "0x1FEE6C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public RaycastHitComparer()
			{
				throw null;
			}

			// Token: 0x06000702 RID: 1794 RVA: 0x00003442 File Offset: 0x00001642
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60006E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FEE6C8", Offset = "0x1FEE6C8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static RaycastHitComparer()
			{
				throw null;
			}

			// Token: 0x0400033D RID: 829
			[global::Cpp2ILInjected.Token(Token = "0x400031F")]
			public static PhysicsRaycaster.RaycastHitComparer instance;
		}
	}
}
