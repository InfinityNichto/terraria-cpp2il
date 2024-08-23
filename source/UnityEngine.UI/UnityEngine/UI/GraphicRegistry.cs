using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.EventSystems;
using UnityEngine.UI.Collections;

namespace UnityEngine.UI
{
	// Token: 0x02000013 RID: 19
	[global::Cpp2ILInjected.Token(Token = "0x2000020")]
	public class GraphicRegistry
	{
		// Token: 0x06000102 RID: 258 RVA: 0x0000233B File Offset: 0x0000053B
		[global::Cpp2ILInjected.Token(Token = "0x600012F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB4CE4", Offset = "0x1FB4CE4", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "KeepAlive", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		protected GraphicRegistry()
		{
			throw null;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000233E File Offset: 0x0000053E
		[global::Cpp2ILInjected.Token(Token = "0x1700004A")]
		public static GraphicRegistry instance
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000130")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB4E8C", Offset = "0x1FB4E8C", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new object[]
			{
				typeof(Canvas),
				typeof(Graphic)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new object[]
			{
				typeof(Canvas),
				typeof(Graphic)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "UnregisterGraphicForCanvas", MemberParameters = new object[]
			{
				typeof(Canvas),
				typeof(Graphic)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "UnregisterRaycastGraphicForCanvas", MemberParameters = new object[]
			{
				typeof(Canvas),
				typeof(Graphic)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "DisableGraphicForCanvas", MemberParameters = new object[]
			{
				typeof(Canvas),
				typeof(Graphic)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "DisableRaycastGraphicForCanvas", MemberParameters = new object[]
			{
				typeof(Canvas),
				typeof(Graphic)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "GetGraphicsForCanvas", MemberParameters = new object[] { typeof(Canvas) }, ReturnType = typeof(IList<Graphic>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "GetRaycastableGraphicsForCanvas", MemberParameters = new object[] { typeof(Canvas) }, ReturnType = typeof(IList<Graphic>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002341 File Offset: 0x00000541
		[global::Cpp2ILInjected.Token(Token = "0x6000131")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB0DA8", Offset = "0x1FB0DA8", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnTransformParentChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = "AddUnique", MemberParameters = new object[]
		{
			"T",
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "RegisterRaycastGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
			throw null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002344 File Offset: 0x00000544
		[global::Cpp2ILInjected.Token(Token = "0x6000132")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB02D8", Offset = "0x1FB02D8", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "set_raycastTarget", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "SetRaycastDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "RegisterGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = "AddUnique", MemberParameters = new object[]
		{
			"T",
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = "Add", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
			throw null;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002347 File Offset: 0x00000547
		[global::Cpp2ILInjected.Token(Token = "0x6000133")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB1770", Offset = "0x1FB1770", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnDestroy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = "Remove", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = "get_Capacity", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "UnregisterRaycastGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic)
		{
			throw null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000234A File Offset: 0x0000054A
		[global::Cpp2ILInjected.Token(Token = "0x6000134")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB0178", Offset = "0x1FB0178", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "set_raycastTarget", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "SetRaycastDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "UnregisterGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = "Remove", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
			throw null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000234D File Offset: 0x0000054D
		[global::Cpp2ILInjected.Token(Token = "0x6000135")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB0A30", Offset = "0x1FB0A30", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnBeforeTransformParentChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Graphic), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = "DisableItem", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = "get_Capacity", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "DisableRaycastGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void DisableGraphicForCanvas(Canvas c, Graphic graphic)
		{
			throw null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002350 File Offset: 0x00000550
		[global::Cpp2ILInjected.Token(Token = "0x6000136")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB4F2C", Offset = "0x1FB4F2C", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRegistry), Member = "DisableGraphicForCanvas", MemberParameters = new object[]
		{
			typeof(Canvas),
			typeof(Graphic)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = "DisableItem", MemberParameters = new object[] { "T" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexedSet<>), Member = "get_Capacity", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic)
		{
			throw null;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002353 File Offset: 0x00000553
		[global::Cpp2ILInjected.Token(Token = "0x6000137")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB508C", Offset = "0x1FB508C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas)
		{
			throw null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002356 File Offset: 0x00000556
		[global::Cpp2ILInjected.Token(Token = "0x6000138")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB44F8", Offset = "0x1FB44F8", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicRaycaster), Member = "Raycast", MemberParameters = new object[]
		{
			typeof(PointerEventData),
			typeof(List<RaycastResult>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicRegistry), Member = "get_instance", ReturnType = typeof(GraphicRegistry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas)
		{
			throw null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002359 File Offset: 0x00000559
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000139")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB513C", Offset = "0x1FB513C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static GraphicRegistry()
		{
			throw null;
		}

		// Token: 0x0400006C RID: 108
		[global::Cpp2ILInjected.Token(Token = "0x400008D")]
		private static GraphicRegistry s_Instance;

		// Token: 0x0400006D RID: 109
		[global::Cpp2ILInjected.Token(Token = "0x400008E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics;

		// Token: 0x0400006E RID: 110
		[global::Cpp2ILInjected.Token(Token = "0x400008F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics;

		// Token: 0x0400006F RID: 111
		[global::Cpp2ILInjected.Token(Token = "0x4000090")]
		private static readonly List<Graphic> s_EmptyList;
	}
}
