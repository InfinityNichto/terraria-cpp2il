using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200001A RID: 26
	[DisallowMultipleComponent]
	[AddComponentMenu("Layout/Canvas Scaler", 101)]
	[RequireComponent(typeof(Canvas))]
	[ExecuteAlways]
	[global::Cpp2ILInjected.Token(Token = "0x200003A")]
	public class CanvasScaler : UIBehaviour
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00002662 File Offset: 0x00000862
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00002665 File Offset: 0x00000865
		[global::Cpp2ILInjected.Token(Token = "0x1700009B")]
		public CanvasScaler.ScaleMode uiScaleMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000253")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC7504", Offset = "0x1FC7504", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000254")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC750C", Offset = "0x1FC750C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00002668 File Offset: 0x00000868
		// (set) Token: 0x06000216 RID: 534 RVA: 0x0000266B File Offset: 0x0000086B
		[global::Cpp2ILInjected.Token(Token = "0x1700009C")]
		public float referencePixelsPerUnit
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000255")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC7514", Offset = "0x1FC7514", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000256")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC751C", Offset = "0x1FC751C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000266E File Offset: 0x0000086E
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00002671 File Offset: 0x00000871
		[global::Cpp2ILInjected.Token(Token = "0x1700009D")]
		public float scaleFactor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000257")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC7524", Offset = "0x1FC7524", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000258")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC752C", Offset = "0x1FC752C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00002674 File Offset: 0x00000874
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00002677 File Offset: 0x00000877
		[global::Cpp2ILInjected.Token(Token = "0x1700009E")]
		public Vector2 referenceResolution
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000259")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC7540", Offset = "0x1FC7540", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600025A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC7548", Offset = "0x1FC7548", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000267A File Offset: 0x0000087A
		// (set) Token: 0x0600021C RID: 540 RVA: 0x0000267D File Offset: 0x0000087D
		[global::Cpp2ILInjected.Token(Token = "0x1700009F")]
		public CanvasScaler.ScreenMatchMode screenMatchMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC75AC", Offset = "0x1FC75AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600025C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC75B4", Offset = "0x1FC75B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00002680 File Offset: 0x00000880
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002683 File Offset: 0x00000883
		[global::Cpp2ILInjected.Token(Token = "0x170000A0")]
		public float matchWidthOrHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC75BC", Offset = "0x1FC75BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600025E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC75C4", Offset = "0x1FC75C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00002686 File Offset: 0x00000886
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00002689 File Offset: 0x00000889
		[global::Cpp2ILInjected.Token(Token = "0x170000A1")]
		public CanvasScaler.Unit physicalUnit
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC75CC", Offset = "0x1FC75CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000260")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC75D4", Offset = "0x1FC75D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0000268C File Offset: 0x0000088C
		// (set) Token: 0x06000222 RID: 546 RVA: 0x0000268F File Offset: 0x0000088F
		[global::Cpp2ILInjected.Token(Token = "0x170000A2")]
		public float fallbackScreenDPI
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000261")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC75DC", Offset = "0x1FC75DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000262")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC75E4", Offset = "0x1FC75E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00002692 File Offset: 0x00000892
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00002695 File Offset: 0x00000895
		[global::Cpp2ILInjected.Token(Token = "0x170000A3")]
		public float defaultSpriteDPI
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000263")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC75EC", Offset = "0x1FC75EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000264")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC75F4", Offset = "0x1FC75F4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00002698 File Offset: 0x00000898
		// (set) Token: 0x06000226 RID: 550 RVA: 0x0000269B File Offset: 0x0000089B
		[global::Cpp2ILInjected.Token(Token = "0x170000A4")]
		public float dynamicPixelsPerUnit
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000265")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC7604", Offset = "0x1FC7604", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000266")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FC760C", Offset = "0x1FC760C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000269E File Offset: 0x0000089E
		[global::Cpp2ILInjected.Token(Token = "0x6000267")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7614", Offset = "0x1FC7614", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		protected CanvasScaler()
		{
			throw null;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000026A1 File Offset: 0x000008A1
		[global::Cpp2ILInjected.Token(Token = "0x6000268")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC765C", Offset = "0x1FC765C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas.WillRenderCanvases), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "add_preWillRenderCanvases", MemberParameters = new object[] { typeof(Canvas.WillRenderCanvases) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000026A4 File Offset: 0x000008A4
		[global::Cpp2ILInjected.Token(Token = "0x6000269")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7720", Offset = "0x1FC7720", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Canvas_preWillRenderCanvases()
		{
			throw null;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000026A7 File Offset: 0x000008A7
		[global::Cpp2ILInjected.Token(Token = "0x600026A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7730", Offset = "0x1FC7730", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas.WillRenderCanvases), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "remove_preWillRenderCanvases", MemberParameters = new object[] { typeof(Canvas.WillRenderCanvases) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000026AA File Offset: 0x000008AA
		[global::Cpp2ILInjected.Token(Token = "0x600026B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC787C", Offset = "0x1FC787C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_isRootCanvas", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_renderMode", ReturnType = typeof(RenderMode))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected virtual void Handle()
		{
			throw null;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000026AD File Offset: 0x000008AD
		[global::Cpp2ILInjected.Token(Token = "0x600026C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC796C", Offset = "0x1FC796C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		protected virtual void HandleWorldCanvas()
		{
			throw null;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000026B0 File Offset: 0x000008B0
		[global::Cpp2ILInjected.Token(Token = "0x600026D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC79CC", Offset = "0x1FC79CC", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		protected virtual void HandleConstantPixelSize()
		{
			throw null;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000026B3 File Offset: 0x000008B3
		[global::Cpp2ILInjected.Token(Token = "0x600026E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7A2C", Offset = "0x1FC7A2C", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_renderingDisplaySize", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_targetDisplay", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Display), Member = "get_renderingWidth", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Display), Member = "get_renderingHeight", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Log", MemberParameters = new object[]
		{
			typeof(double),
			typeof(double)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected virtual void HandleScaleWithScreenSize()
		{
			throw null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000026B6 File Offset: 0x000008B6
		[global::Cpp2ILInjected.Token(Token = "0x600026F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7C70", Offset = "0x1FC7C70", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Screen), Member = "get_dpi", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		protected virtual void HandleConstantPhysicalSize()
		{
			throw null;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000026B9 File Offset: 0x000008B9
		[global::Cpp2ILInjected.Token(Token = "0x6000270")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC780C", Offset = "0x1FC780C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_scaleFactor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		protected void SetScaleFactor(float scaleFactor)
		{
			throw null;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x000026BC File Offset: 0x000008BC
		[global::Cpp2ILInjected.Token(Token = "0x6000271")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FC7844", Offset = "0x1FC7844", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "set_referencePixelsPerUnit", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit)
		{
			throw null;
		}

		// Token: 0x040000C3 RID: 195
		[SerializeField]
		[Tooltip("Determines how UI elements in the Canvas are scaled.")]
		[global::Cpp2ILInjected.Token(Token = "0x400012E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private CanvasScaler.ScaleMode m_UiScaleMode;

		// Token: 0x040000C4 RID: 196
		[SerializeField]
		[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
		[global::Cpp2ILInjected.Token(Token = "0x400012F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		protected float m_ReferencePixelsPerUnit;

		// Token: 0x040000C5 RID: 197
		[SerializeField]
		[Tooltip("Scales all UI elements in the Canvas by this factor.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000130")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected float m_ScaleFactor;

		// Token: 0x040000C6 RID: 198
		[SerializeField]
		[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000131")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		protected Vector2 m_ReferenceResolution;

		// Token: 0x040000C7 RID: 199
		[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000132")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode;

		// Token: 0x040000C8 RID: 200
		[Range(0f, 1f)]
		[SerializeField]
		[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000133")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected float m_MatchWidthOrHeight;

		// Token: 0x040000C9 RID: 201
		[global::Cpp2ILInjected.Token(Token = "0x4000134")]
		private const float kLogBase = 2f;

		// Token: 0x040000CA RID: 202
		[SerializeField]
		[Tooltip("The physical unit to specify positions and sizes in.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000135")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		protected CanvasScaler.Unit m_PhysicalUnit;

		// Token: 0x040000CB RID: 203
		[SerializeField]
		[Tooltip("The DPI to assume if the screen DPI is not known.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000136")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		protected float m_FallbackScreenDPI;

		// Token: 0x040000CC RID: 204
		[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000137")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		protected float m_DefaultSpriteDPI;

		// Token: 0x040000CD RID: 205
		[SerializeField]
		[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000138")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		protected float m_DynamicPixelsPerUnit;

		// Token: 0x040000CE RID: 206
		[global::Cpp2ILInjected.Token(Token = "0x4000139")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Canvas m_Canvas;

		// Token: 0x040000CF RID: 207
		[global::Cpp2ILInjected.Token(Token = "0x400013A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		[NonSerialized]
		private float m_PrevScaleFactor;

		// Token: 0x040000D0 RID: 208
		[global::Cpp2ILInjected.Token(Token = "0x400013B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		[NonSerialized]
		private float m_PrevReferencePixelsPerUnit;

		// Token: 0x040000D1 RID: 209
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400013C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		protected bool m_PresetInfoIsWorld;

		// Token: 0x0200009F RID: 159
		[global::Cpp2ILInjected.Token(Token = "0x200003B")]
		public enum ScaleMode
		{
			// Token: 0x040002B5 RID: 693
			[global::Cpp2ILInjected.Token(Token = "0x400013E")]
			ConstantPixelSize,
			// Token: 0x040002B6 RID: 694
			[global::Cpp2ILInjected.Token(Token = "0x400013F")]
			ScaleWithScreenSize,
			// Token: 0x040002B7 RID: 695
			[global::Cpp2ILInjected.Token(Token = "0x4000140")]
			ConstantPhysicalSize
		}

		// Token: 0x020000A0 RID: 160
		[global::Cpp2ILInjected.Token(Token = "0x200003C")]
		public enum ScreenMatchMode
		{
			// Token: 0x040002B9 RID: 697
			[global::Cpp2ILInjected.Token(Token = "0x4000142")]
			MatchWidthOrHeight,
			// Token: 0x040002BA RID: 698
			[global::Cpp2ILInjected.Token(Token = "0x4000143")]
			Expand,
			// Token: 0x040002BB RID: 699
			[global::Cpp2ILInjected.Token(Token = "0x4000144")]
			Shrink
		}

		// Token: 0x020000A1 RID: 161
		[global::Cpp2ILInjected.Token(Token = "0x200003D")]
		public enum Unit
		{
			// Token: 0x040002BD RID: 701
			[global::Cpp2ILInjected.Token(Token = "0x4000146")]
			Centimeters,
			// Token: 0x040002BE RID: 702
			[global::Cpp2ILInjected.Token(Token = "0x4000147")]
			Millimeters,
			// Token: 0x040002BF RID: 703
			[global::Cpp2ILInjected.Token(Token = "0x4000148")]
			Inches,
			// Token: 0x040002C0 RID: 704
			[global::Cpp2ILInjected.Token(Token = "0x4000149")]
			Points,
			// Token: 0x040002C1 RID: 705
			[global::Cpp2ILInjected.Token(Token = "0x400014A")]
			Picas
		}
	}
}
