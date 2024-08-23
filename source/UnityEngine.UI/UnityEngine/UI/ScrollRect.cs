using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000033 RID: 51
	[SelectionBase]
	[ExecuteAlways]
	[AddComponentMenu("UI/Scroll Rect", 37)]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	[global::Cpp2ILInjected.Token(Token = "0x2000063")]
	public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
	{
		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00002A0D File Offset: 0x00000C0D
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00002A10 File Offset: 0x00000C10
		[global::Cpp2ILInjected.Token(Token = "0x170000F7")]
		public RectTransform content
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4CD8", Offset = "0x1FD4CD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4CE0", Offset = "0x1FD4CE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00002A13 File Offset: 0x00000C13
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00002A16 File Offset: 0x00000C16
		[global::Cpp2ILInjected.Token(Token = "0x170000F8")]
		public bool horizontal
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4CE8", Offset = "0x1FD4CE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4CF0", Offset = "0x1FD4CF0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00002A19 File Offset: 0x00000C19
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00002A1C File Offset: 0x00000C1C
		[global::Cpp2ILInjected.Token(Token = "0x170000F9")]
		public bool vertical
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4CFC", Offset = "0x1FD4CFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4D04", Offset = "0x1FD4D04", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00002A1F File Offset: 0x00000C1F
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00002A22 File Offset: 0x00000C22
		[global::Cpp2ILInjected.Token(Token = "0x170000FA")]
		public ScrollRect.MovementType movementType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4D10", Offset = "0x1FD4D10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4D18", Offset = "0x1FD4D18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00002A25 File Offset: 0x00000C25
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00002A28 File Offset: 0x00000C28
		[global::Cpp2ILInjected.Token(Token = "0x170000FB")]
		public float elasticity
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4D20", Offset = "0x1FD4D20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4D28", Offset = "0x1FD4D28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00002A2B File Offset: 0x00000C2B
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00002A2E File Offset: 0x00000C2E
		[global::Cpp2ILInjected.Token(Token = "0x170000FC")]
		public bool inertia
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4D30", Offset = "0x1FD4D30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4D38", Offset = "0x1FD4D38", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00002A31 File Offset: 0x00000C31
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00002A34 File Offset: 0x00000C34
		[global::Cpp2ILInjected.Token(Token = "0x170000FD")]
		public float decelerationRate
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4D44", Offset = "0x1FD4D44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4D4C", Offset = "0x1FD4D4C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00002A37 File Offset: 0x00000C37
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00002A3A File Offset: 0x00000C3A
		[global::Cpp2ILInjected.Token(Token = "0x170000FE")]
		public float scrollSensitivity
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4D54", Offset = "0x1FD4D54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4D5C", Offset = "0x1FD4D5C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00002A3D File Offset: 0x00000C3D
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00002A40 File Offset: 0x00000C40
		[global::Cpp2ILInjected.Token(Token = "0x170000FF")]
		public RectTransform viewport
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4D64", Offset = "0x1FD4D64", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4D6C", Offset = "0x1FD4D6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00002A43 File Offset: 0x00000C43
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00002A46 File Offset: 0x00000C46
		[global::Cpp2ILInjected.Token(Token = "0x17000100")]
		public Scrollbar horizontalScrollbar
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4E28", Offset = "0x1FD4E28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4E30", Offset = "0x1FD4E30", Length = "0x160")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityAction<float>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<float>), Member = "RemoveListener", MemberParameters = new object[] { typeof(UnityAction<float>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<float>), Member = "AddListener", MemberParameters = new object[] { typeof(UnityAction<float>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00002A49 File Offset: 0x00000C49
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00002A4C File Offset: 0x00000C4C
		[global::Cpp2ILInjected.Token(Token = "0x17000101")]
		public Scrollbar verticalScrollbar
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4F90", Offset = "0x1FD4F90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD4F98", Offset = "0x1FD4F98", Length = "0x160")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityAction<float>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<float>), Member = "RemoveListener", MemberParameters = new object[] { typeof(UnityAction<float>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<float>), Member = "AddListener", MemberParameters = new object[] { typeof(UnityAction<float>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00002A4F File Offset: 0x00000C4F
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00002A52 File Offset: 0x00000C52
		[global::Cpp2ILInjected.Token(Token = "0x17000102")]
		public ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD50F8", Offset = "0x1FD50F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD5100", Offset = "0x1FD5100", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00002A55 File Offset: 0x00000C55
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00002A58 File Offset: 0x00000C58
		[global::Cpp2ILInjected.Token(Token = "0x17000103")]
		public ScrollRect.ScrollbarVisibility verticalScrollbarVisibility
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD5108", Offset = "0x1FD5108", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD5110", Offset = "0x1FD5110", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00002A5B File Offset: 0x00000C5B
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00002A5E File Offset: 0x00000C5E
		[global::Cpp2ILInjected.Token(Token = "0x17000104")]
		public float horizontalScrollbarSpacing
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD5118", Offset = "0x1FD5118", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD5120", Offset = "0x1FD5120", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00002A61 File Offset: 0x00000C61
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00002A64 File Offset: 0x00000C64
		[global::Cpp2ILInjected.Token(Token = "0x17000105")]
		public float verticalScrollbarSpacing
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD51B0", Offset = "0x1FD51B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD51B8", Offset = "0x1FD51B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00002A67 File Offset: 0x00000C67
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00002A6A File Offset: 0x00000C6A
		[global::Cpp2ILInjected.Token(Token = "0x17000106")]
		public ScrollRect.ScrollRectEvent onValueChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD51C0", Offset = "0x1FD51C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD51C8", Offset = "0x1FD51C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00002A6D File Offset: 0x00000C6D
		[global::Cpp2ILInjected.Token(Token = "0x17000107")]
		protected RectTransform viewRect
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD51D0", Offset = "0x1FD51D0", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "UpdateCachedData", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "OnBeginDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutVertical", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00002A70 File Offset: 0x00000C70
		// (set) Token: 0x0600037E RID: 894 RVA: 0x00002A73 File Offset: 0x00000C73
		[global::Cpp2ILInjected.Token(Token = "0x17000108")]
		public Vector2 velocity
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD52C0", Offset = "0x1FD52C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD52C8", Offset = "0x1FD52C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00002A76 File Offset: 0x00000C76
		[global::Cpp2ILInjected.Token(Token = "0x17000109")]
		private RectTransform rectTransform
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD52D0", Offset = "0x1FD52D0", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetDirtyCaching", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002A79 File Offset: 0x00000C79
		[global::Cpp2ILInjected.Token(Token = "0x60003E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD5364", Offset = "0x1FD5364", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect.ScrollRectEvent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected ScrollRect()
		{
			throw null;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00002A7C File Offset: 0x00000C7C
		[global::Cpp2ILInjected.Token(Token = "0x60003E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD54AC", Offset = "0x1FD54AC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdatePrevData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void Rebuild(CanvasUpdate executing)
		{
			throw null;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002A7F File Offset: 0x00000C7F
		[global::Cpp2ILInjected.Token(Token = "0x60003E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD5FB0", Offset = "0x1FD5FB0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void LayoutComplete()
		{
			throw null;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002A82 File Offset: 0x00000C82
		[global::Cpp2ILInjected.Token(Token = "0x60003E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD5FB4", Offset = "0x1FD5FB4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void GraphicUpdateComplete()
		{
			throw null;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002A85 File Offset: 0x00000C85
		[global::Cpp2ILInjected.Token(Token = "0x60003E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD5534", Offset = "0x1FD5534", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_parent", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void UpdateCachedData()
		{
			throw null;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002A88 File Offset: 0x00000C88
		[global::Cpp2ILInjected.Token(Token = "0x60003E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD5FB8", Offset = "0x1FD5FB8", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityAction<float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<float>), Member = "AddListener", MemberParameters = new object[] { typeof(UnityAction<float>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForLayoutRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002A8B File Offset: 0x00000C8B
		[global::Cpp2ILInjected.Token(Token = "0x60003E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD6148", Offset = "0x1FD6148", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "UnRegisterCanvasElementForRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityAction<float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<float>), Member = "RemoveListener", MemberParameters = new object[] { typeof(UnityAction<float>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002A8E File Offset: 0x00000C8E
		[global::Cpp2ILInjected.Token(Token = "0x60003E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD635C", Offset = "0x1FD635C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "IsActive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool IsActive()
		{
			throw null;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002A91 File Offset: 0x00000C91
		[global::Cpp2ILInjected.Token(Token = "0x60003E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD63DC", Offset = "0x1FD63DC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "OnScroll", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetNormalizedPosition", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "IsRebuildingLayout", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "ForceUpdateCanvases", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnsureLayoutHasRebuilt()
		{
			throw null;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002A94 File Offset: 0x00000C94
		[global::Cpp2ILInjected.Token(Token = "0x60003EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD6450", Offset = "0x1FD6450", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void StopMovement()
		{
			throw null;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002A97 File Offset: 0x00000C97
		[global::Cpp2ILInjected.Token(Token = "0x60003EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD64A0", Offset = "0x1FD64A0", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "EnsureLayoutHasRebuilt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "IsScrolling", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "InternalCalculateOffset", MemberParameters = new object[]
		{
			typeof(ref Bounds),
			typeof(ref Bounds),
			typeof(bool),
			typeof(bool),
			typeof(ScrollRect.MovementType),
			typeof(ref Vector2)
		}, ReturnType = typeof(Vector2))]
		public virtual void OnScroll(PointerEventData data)
		{
			throw null;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002A9A File Offset: 0x00000C9A
		[global::Cpp2ILInjected.Token(Token = "0x60003EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD6638", Offset = "0x1FD6638", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void OnInitializePotentialDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002A9D File Offset: 0x00000C9D
		[global::Cpp2ILInjected.Token(Token = "0x60003ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD6690", Offset = "0x1FD6690", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual void OnBeginDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002AA0 File Offset: 0x00000CA0
		[global::Cpp2ILInjected.Token(Token = "0x60003EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD67AC", Offset = "0x1FD67AC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnEndDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00002AA3 File Offset: 0x00000CA3
		[global::Cpp2ILInjected.Token(Token = "0x60003EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD67C0", Offset = "0x1FD67C0", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PointerEventData), Member = "get_pressEventCamera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "InternalCalculateOffset", MemberParameters = new object[]
		{
			typeof(ref Bounds),
			typeof(ref Bounds),
			typeof(bool),
			typeof(bool),
			typeof(ScrollRect.MovementType),
			typeof(ref Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_size", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual void OnDrag(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00002AA6 File Offset: 0x00000CA6
		[global::Cpp2ILInjected.Token(Token = "0x60003F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD6A10", Offset = "0x1FD6A10", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
		protected virtual void SetContentAnchoredPosition(Vector2 position)
		{
			throw null;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00002AA9 File Offset: 0x00000CA9
		[global::Cpp2ILInjected.Token(Token = "0x60003F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD6AB0", Offset = "0x1FD6AB0", Length = "0x590")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "EnsureLayoutHasRebuilt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "InternalCalculateOffset", MemberParameters = new object[]
		{
			typeof(ref Bounds),
			typeof(ref Bounds),
			typeof(bool),
			typeof(bool),
			typeof(ScrollRect.MovementType),
			typeof(ref Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Mathf), Member = "SmoothDamp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(ref float),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Bounds),
			typeof(Bounds)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UISystemProfilerApi), Member = "AddMarker", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<Vector2>), Member = "Invoke", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdatePrevData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdateScrollbarVisibility", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected virtual void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002AAC File Offset: 0x00000CAC
		[global::Cpp2ILInjected.Token(Token = "0x60003F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD5EDC", Offset = "0x1FD5EDC", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "Rebuild", MemberParameters = new object[] { typeof(CanvasUpdate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected void UpdatePrevData()
		{
			throw null;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002AAF File Offset: 0x00000CAF
		[global::Cpp2ILInjected.Token(Token = "0x60003F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD5D20", Offset = "0x1FD5D20", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "Rebuild", MemberParameters = new object[] { typeof(CanvasUpdate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_size", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "set_size", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Scrollbar), Member = "Set", MemberParameters = new object[]
		{
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void UpdateScrollbars(Vector2 offset)
		{
			throw null;
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00002AB2 File Offset: 0x00000CB2
		// (set) Token: 0x06000394 RID: 916 RVA: 0x00002AB5 File Offset: 0x00000CB5
		[global::Cpp2ILInjected.Token(Token = "0x1700010A")]
		public Vector2 normalizedPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD7040", Offset = "0x1FD7040", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003F5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD7368", Offset = "0x1FD7368", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00002AB8 File Offset: 0x00000CB8
		// (set) Token: 0x06000396 RID: 918 RVA: 0x00002ABB File Offset: 0x00000CBB
		[global::Cpp2ILInjected.Token(Token = "0x1700010B")]
		public float horizontalNormalizedPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003F6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD70B0", Offset = "0x1FD70B0", Length = "0x15C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "get_normalizedPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_size", ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_min", ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD73B0", Offset = "0x1FD73B0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000397 RID: 919 RVA: 0x00002ABE File Offset: 0x00000CBE
		// (set) Token: 0x06000398 RID: 920 RVA: 0x00002AC1 File Offset: 0x00000CC1
		[global::Cpp2ILInjected.Token(Token = "0x1700010C")]
		public float verticalNormalizedPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD720C", Offset = "0x1FD720C", Length = "0x15C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbars", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "get_normalizedPosition", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_size", ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_min", ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD73C4", Offset = "0x1FD73C4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002AC4 File Offset: 0x00000CC4
		[global::Cpp2ILInjected.Token(Token = "0x60003FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD73D8", Offset = "0x1FD73D8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void SetHorizontalNormalizedPosition(float value)
		{
			throw null;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002AC7 File Offset: 0x00000CC7
		[global::Cpp2ILInjected.Token(Token = "0x60003FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD73EC", Offset = "0x1FD73EC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void SetVerticalNormalizedPosition(float value)
		{
			throw null;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002ACA File Offset: 0x00000CCA
		[global::Cpp2ILInjected.Token(Token = "0x60003FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD7400", Offset = "0x1FD7400", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "EnsureLayoutHasRebuilt", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_size", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_min", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		protected virtual void SetNormalizedPosition(float value, int axis)
		{
			throw null;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002ACD File Offset: 0x00000CCD
		[global::Cpp2ILInjected.Token(Token = "0x60003FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD69D4", Offset = "0x1FD69D4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static float RubberDelta(float overStretching, float viewSize)
		{
			throw null;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00002AD0 File Offset: 0x00000CD0
		[global::Cpp2ILInjected.Token(Token = "0x60003FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD7680", Offset = "0x1FD7680", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "SetDirty", ReturnType = typeof(void))]
		protected override void OnRectTransformDimensionsChange()
		{
			throw null;
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00002AD3 File Offset: 0x00000CD3
		[global::Cpp2ILInjected.Token(Token = "0x1700010D")]
		private bool hScrollingNeeded
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD7684", Offset = "0x1FD7684", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarVisibility", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_size", ReturnType = typeof(Vector3))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00002AD6 File Offset: 0x00000CD6
		[global::Cpp2ILInjected.Token(Token = "0x1700010E")]
		private bool vScrollingNeeded
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000400")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD76E0", Offset = "0x1FD76E0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarVisibility", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_size", ReturnType = typeof(Vector3))]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002AD9 File Offset: 0x00000CD9
		[global::Cpp2ILInjected.Token(Token = "0x6000401")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD773C", Offset = "0x1FD773C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void CalculateLayoutInputHorizontal()
		{
			throw null;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002ADC File Offset: 0x00000CDC
		[global::Cpp2ILInjected.Token(Token = "0x6000402")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD7740", Offset = "0x1FD7740", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void CalculateLayoutInputVertical()
		{
			throw null;
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00002ADF File Offset: 0x00000CDF
		[global::Cpp2ILInjected.Token(Token = "0x1700010F")]
		public virtual float minWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000403")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD7744", Offset = "0x1FD7744", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00002AE2 File Offset: 0x00000CE2
		[global::Cpp2ILInjected.Token(Token = "0x17000110")]
		public virtual float preferredWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000404")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD774C", Offset = "0x1FD774C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00002AE5 File Offset: 0x00000CE5
		[global::Cpp2ILInjected.Token(Token = "0x17000111")]
		public virtual float flexibleWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000405")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD7754", Offset = "0x1FD7754", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00002AE8 File Offset: 0x00000CE8
		[global::Cpp2ILInjected.Token(Token = "0x17000112")]
		public virtual float minHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000406")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD775C", Offset = "0x1FD775C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00002AEB File Offset: 0x00000CEB
		[global::Cpp2ILInjected.Token(Token = "0x17000113")]
		public virtual float preferredHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000407")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD7764", Offset = "0x1FD7764", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00002AEE File Offset: 0x00000CEE
		[global::Cpp2ILInjected.Token(Token = "0x17000114")]
		public virtual float flexibleHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000408")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD776C", Offset = "0x1FD776C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00002AF1 File Offset: 0x00000CF1
		[global::Cpp2ILInjected.Token(Token = "0x17000115")]
		public virtual int layoutPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000409")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD7774", Offset = "0x1FD7774", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002AF4 File Offset: 0x00000CF4
		[global::Cpp2ILInjected.Token(Token = "0x600040A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD777C", Offset = "0x1FD777C", Length = "0x50C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdateCachedData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Add", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(RectTransform),
			typeof(DrivenTransformProperties)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "ForceRebuildLayoutImmediate", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_vScrollingNeeded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_hScrollingNeeded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public virtual void SetLayoutHorizontal()
		{
			throw null;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002AF7 File Offset: 0x00000CF7
		[global::Cpp2ILInjected.Token(Token = "0x600040B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD7D78", Offset = "0x1FD7D78", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdateScrollbarLayout", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
		public virtual void SetLayoutVertical()
		{
			throw null;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002AFA File Offset: 0x00000CFA
		[global::Cpp2ILInjected.Token(Token = "0x600040C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD7070", Offset = "0x1FD7070", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_vScrollingNeeded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "UpdateOneScrollbarVisibility", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(ScrollRect.ScrollbarVisibility),
			typeof(Scrollbar)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_hScrollingNeeded", ReturnType = typeof(bool))]
		private void UpdateScrollbarVisibility()
		{
			throw null;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002AFD File Offset: 0x00000CFD
		[global::Cpp2ILInjected.Token(Token = "0x600040D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD8070", Offset = "0x1FD8070", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "UpdateScrollbarVisibility", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_activeSelf", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "SetActive", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar)
		{
			throw null;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002B00 File Offset: 0x00000D00
		[global::Cpp2ILInjected.Token(Token = "0x600040E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD7E44", Offset = "0x1FD7E44", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutVertical", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrivenRectTransformTracker), Member = "Add", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(RectTransform),
			typeof(DrivenTransformProperties)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchorMax", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchoredPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_vScrollingNeeded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_sizeDelta", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_hScrollingNeeded", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void UpdateScrollbarLayout()
		{
			throw null;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002B03 File Offset: 0x00000D03
		[global::Cpp2ILInjected.Token(Token = "0x600040F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD588C", Offset = "0x1FD588C", Length = "0x494")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "Rebuild", MemberParameters = new object[] { typeof(CanvasUpdate) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "OnScroll", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "OnBeginDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetContentAnchoredPosition", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "get_horizontalNormalizedPosition", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "get_verticalNormalizedPosition", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetNormalizedPosition", MemberParameters = new object[]
		{
			typeof(float),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_center", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_size", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_center", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "AdjustBounds", MemberParameters = new object[]
		{
			typeof(ref Bounds),
			typeof(ref Vector2),
			typeof(ref Vector3),
			typeof(ref Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "set_size", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "set_center", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_max", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_min", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchoredPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected void UpdateBounds()
		{
			throw null;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002B06 File Offset: 0x00000D06
		[global::Cpp2ILInjected.Token(Token = "0x6000410")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD8150", Offset = "0x1FD8150", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_size", ReturnType = typeof(Vector3))]
		internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos)
		{
			throw null;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002B09 File Offset: 0x00000D09
		[global::Cpp2ILInjected.Token(Token = "0x6000411")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD7C88", Offset = "0x1FD7C88", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "SetLayoutVertical", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "UpdateBounds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "GetWorldCorners", MemberParameters = new object[] { typeof(Vector3[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_viewRect", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_worldToLocalMatrix", ReturnType = typeof(Matrix4x4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "InternalGetBounds", MemberParameters = new object[]
		{
			typeof(Vector3[]),
			typeof(ref Matrix4x4)
		}, ReturnType = typeof(Bounds))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private Bounds GetBounds()
		{
			throw null;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002B0C File Offset: 0x00000D0C
		[global::Cpp2ILInjected.Token(Token = "0x6000412")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD81FC", Offset = "0x1FD81FC", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "GetBounds", ReturnType = typeof(Bounds))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint3x4", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "Encapsulate", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix)
		{
			throw null;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002B0F File Offset: 0x00000D0F
		[global::Cpp2ILInjected.Token(Token = "0x6000413")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD6608", Offset = "0x1FD6608", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "InternalCalculateOffset", MemberParameters = new object[]
		{
			typeof(ref Bounds),
			typeof(ref Bounds),
			typeof(bool),
			typeof(bool),
			typeof(ScrollRect.MovementType),
			typeof(ref Vector2)
		}, ReturnType = typeof(Vector2))]
		private Vector2 CalculateOffset(Vector2 delta)
		{
			throw null;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002B12 File Offset: 0x00000D12
		[global::Cpp2ILInjected.Token(Token = "0x6000414")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD833C", Offset = "0x1FD833C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "OnScroll", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "OnDrag", MemberParameters = new object[] { typeof(PointerEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "LateUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "CalculateOffset", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_min", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_max", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta)
		{
			throw null;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002B15 File Offset: 0x00000D15
		[global::Cpp2ILInjected.Token(Token = "0x6000415")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD5128", Offset = "0x1FD5128", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "set_verticalScrollbarSpacing", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected void SetDirty()
		{
			throw null;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002B18 File Offset: 0x00000D18
		[global::Cpp2ILInjected.Token(Token = "0x6000416")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD4D74", Offset = "0x1FD4D74", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "set_horizontalScrollbar", MemberParameters = new object[] { typeof(Scrollbar) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "set_verticalScrollbar", MemberParameters = new object[] { typeof(Scrollbar) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "set_horizontalScrollbarVisibility", MemberParameters = new object[] { typeof(ScrollRect.ScrollbarVisibility) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = "set_verticalScrollbarVisibility", MemberParameters = new object[] { typeof(ScrollRect.ScrollbarVisibility) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasUpdateRegistry), Member = "RegisterCanvasElementForLayoutRebuild", MemberParameters = new object[] { typeof(ICanvasElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScrollRect), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutRebuilder), Member = "MarkLayoutForRebuild", MemberParameters = new object[] { typeof(RectTransform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected void SetDirtyCaching()
		{
			throw null;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002B1B File Offset: 0x00000D1B
		[global::Cpp2ILInjected.Token(Token = "0x6000417")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FD84C0", Offset = "0x1FD84C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		private Transform UnityEngine.UI.ICanvasElement.get_transform()
		{
			throw null;
		}

		// Token: 0x04000126 RID: 294
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private RectTransform m_Content;

		// Token: 0x04000127 RID: 295
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool m_Horizontal;

		// Token: 0x04000128 RID: 296
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
		private bool m_Vertical;

		// Token: 0x04000129 RID: 297
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private ScrollRect.MovementType m_MovementType;

		// Token: 0x0400012A RID: 298
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private float m_Elasticity;

		// Token: 0x0400012B RID: 299
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private bool m_Inertia;

		// Token: 0x0400012C RID: 300
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private float m_DecelerationRate;

		// Token: 0x0400012D RID: 301
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private float m_ScrollSensitivity;

		// Token: 0x0400012E RID: 302
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private RectTransform m_Viewport;

		// Token: 0x0400012F RID: 303
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Scrollbar m_HorizontalScrollbar;

		// Token: 0x04000130 RID: 304
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Scrollbar m_VerticalScrollbar;

		// Token: 0x04000131 RID: 305
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility;

		// Token: 0x04000132 RID: 306
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility;

		// Token: 0x04000133 RID: 307
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private float m_HorizontalScrollbarSpacing;

		// Token: 0x04000134 RID: 308
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private float m_VerticalScrollbarSpacing;

		// Token: 0x04000135 RID: 309
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40001E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private ScrollRect.ScrollRectEvent m_OnValueChanged;

		// Token: 0x04000136 RID: 310
		[global::Cpp2ILInjected.Token(Token = "0x40001E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Vector2 m_PointerStartLocalCursor;

		// Token: 0x04000137 RID: 311
		[global::Cpp2ILInjected.Token(Token = "0x40001E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		protected Vector2 m_ContentStartPosition;

		// Token: 0x04000138 RID: 312
		[global::Cpp2ILInjected.Token(Token = "0x40001E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private RectTransform m_ViewRect;

		// Token: 0x04000139 RID: 313
		[global::Cpp2ILInjected.Token(Token = "0x40001E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		protected Bounds m_ContentBounds;

		// Token: 0x0400013A RID: 314
		[global::Cpp2ILInjected.Token(Token = "0x40001E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private Bounds m_ViewBounds;

		// Token: 0x0400013B RID: 315
		[global::Cpp2ILInjected.Token(Token = "0x40001E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private Vector2 m_Velocity;

		// Token: 0x0400013C RID: 316
		[global::Cpp2ILInjected.Token(Token = "0x40001EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private bool m_Dragging;

		// Token: 0x0400013D RID: 317
		[global::Cpp2ILInjected.Token(Token = "0x40001EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB9")]
		private bool m_Scrolling;

		// Token: 0x0400013E RID: 318
		[global::Cpp2ILInjected.Token(Token = "0x40001EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
		private Vector2 m_PrevPosition;

		// Token: 0x0400013F RID: 319
		[global::Cpp2ILInjected.Token(Token = "0x40001ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
		private Bounds m_PrevContentBounds;

		// Token: 0x04000140 RID: 320
		[global::Cpp2ILInjected.Token(Token = "0x40001EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
		private Bounds m_PrevViewBounds;

		// Token: 0x04000141 RID: 321
		[global::Cpp2ILInjected.Token(Token = "0x40001EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
		[NonSerialized]
		private bool m_HasRebuiltLayout;

		// Token: 0x04000142 RID: 322
		[global::Cpp2ILInjected.Token(Token = "0x40001F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF5")]
		private bool m_HSliderExpand;

		// Token: 0x04000143 RID: 323
		[global::Cpp2ILInjected.Token(Token = "0x40001F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF6")]
		private bool m_VSliderExpand;

		// Token: 0x04000144 RID: 324
		[global::Cpp2ILInjected.Token(Token = "0x40001F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private float m_HSliderHeight;

		// Token: 0x04000145 RID: 325
		[global::Cpp2ILInjected.Token(Token = "0x40001F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
		private float m_VSliderWidth;

		// Token: 0x04000146 RID: 326
		[global::Cpp2ILInjected.Token(Token = "0x40001F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		[NonSerialized]
		private RectTransform m_Rect;

		// Token: 0x04000147 RID: 327
		[global::Cpp2ILInjected.Token(Token = "0x40001F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private RectTransform m_HorizontalScrollbarRect;

		// Token: 0x04000148 RID: 328
		[global::Cpp2ILInjected.Token(Token = "0x40001F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private RectTransform m_VerticalScrollbarRect;

		// Token: 0x04000149 RID: 329
		[global::Cpp2ILInjected.Token(Token = "0x40001F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private DrivenRectTransformTracker m_Tracker;

		// Token: 0x0400014A RID: 330
		[global::Cpp2ILInjected.Token(Token = "0x40001F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private readonly Vector3[] m_Corners;

		// Token: 0x020000AF RID: 175
		[global::Cpp2ILInjected.Token(Token = "0x2000064")]
		public enum MovementType
		{
			// Token: 0x040002F8 RID: 760
			[global::Cpp2ILInjected.Token(Token = "0x40001FA")]
			Unrestricted,
			// Token: 0x040002F9 RID: 761
			[global::Cpp2ILInjected.Token(Token = "0x40001FB")]
			Elastic,
			// Token: 0x040002FA RID: 762
			[global::Cpp2ILInjected.Token(Token = "0x40001FC")]
			Clamped
		}

		// Token: 0x020000B0 RID: 176
		[global::Cpp2ILInjected.Token(Token = "0x2000065")]
		public enum ScrollbarVisibility
		{
			// Token: 0x040002FC RID: 764
			[global::Cpp2ILInjected.Token(Token = "0x40001FE")]
			Permanent,
			// Token: 0x040002FD RID: 765
			[global::Cpp2ILInjected.Token(Token = "0x40001FF")]
			AutoHide,
			// Token: 0x040002FE RID: 766
			[global::Cpp2ILInjected.Token(Token = "0x4000200")]
			AutoHideAndExpandViewport
		}

		// Token: 0x020000B1 RID: 177
		[global::Cpp2ILInjected.Token(Token = "0x2000066")]
		[Serializable]
		public class ScrollRectEvent : UnityEvent<Vector2>
		{
			// Token: 0x060006C5 RID: 1733 RVA: 0x000033DF File Offset: 0x000015DF
			[global::Cpp2ILInjected.Token(Token = "0x6000418")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FD5464", Offset = "0x1FD5464", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScrollRect), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<Vector2>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public ScrollRectEvent()
			{
				throw null;
			}
		}
	}
}
