using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Serialization;
using UnityEngine.Sprites;
using UnityEngine.U2D;

namespace UnityEngine.UI
{
	// Token: 0x02000015 RID: 21
	[AddComponentMenu("UI/Image", 11)]
	[RequireComponent(typeof(CanvasRenderer))]
	[global::Cpp2ILInjected.Token(Token = "0x2000022")]
	public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0000235C File Offset: 0x0000055C
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0000235F File Offset: 0x0000055F
		[global::Cpp2ILInjected.Token(Token = "0x1700004B")]
		public Sprite sprite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600013B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB51C8", Offset = "0x1FB51C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600013C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA8DB4", Offset = "0x1FA8DB4", Length = "0x2D0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreatePanel", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateButton", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollbar", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateToggle", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "RefreshShownValue", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dropdown), Member = "AddItem", MemberParameters = new object[]
			{
				typeof(Dropdown.OptionData),
				typeof(bool),
				typeof(Dropdown.DropdownItem),
				typeof(List<Dropdown.DropdownItem>)
			}, ReturnType = typeof(Dropdown.DropdownItem))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "TrackSprite", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002362 File Offset: 0x00000562
		[global::Cpp2ILInjected.Token(Token = "0x600013D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB52B4", Offset = "0x1FB52B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void DisableSpriteOptimizations()
		{
			throw null;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00002365 File Offset: 0x00000565
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00002368 File Offset: 0x00000568
		[global::Cpp2ILInjected.Token(Token = "0x1700004C")]
		public Sprite overrideSprite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600013E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB52BC", Offset = "0x1FB52BC", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600013F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5338", Offset = "0x1FB5338", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Selectable), Member = "DoSpriteSwap", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetClass", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "TrackSprite", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000236B File Offset: 0x0000056B
		[global::Cpp2ILInjected.Token(Token = "0x1700004D")]
		private Sprite activeSprite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000140")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB52C0", Offset = "0x1FB52C0", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "get_mainTexture", ReturnType = typeof(Texture))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "get_hasBorder", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "get_material", ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GetDrawingDimensions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Vector4))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "SetNativeSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "TrackSprite", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "UpdateMaterial", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new object[]
			{
				typeof(VertexHelper),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new object[]
			{
				typeof(VertexHelper),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new object[]
			{
				typeof(VertexHelper),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "get_preferredWidth", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "get_preferredHeight", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "IsRaycastLocationValid", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Camera)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "MapCoordinate", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Rect)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "RebuildImage", MemberParameters = new object[] { typeof(SpriteAtlas) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 59)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000236E File Offset: 0x0000056E
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00002371 File Offset: 0x00000571
		[global::Cpp2ILInjected.Token(Token = "0x1700004E")]
		public Image.Type type
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000141")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB53C0", Offset = "0x1FB53C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000142")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FA9084", Offset = "0x1FA9084", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreatePanel", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateButton", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateSlider", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollbar", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateToggle", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateInputField", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateDropdown", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DefaultControls), Member = "CreateScrollView", MemberParameters = new object[] { typeof(DefaultControls.Resources) }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
			{
				typeof(ref Int32Enum),
				"System.Int32Enum"
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00002374 File Offset: 0x00000574
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00002377 File Offset: 0x00000577
		[global::Cpp2ILInjected.Token(Token = "0x1700004F")]
		public bool preserveAspect
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000143")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB53C8", Offset = "0x1FB53C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000144")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB53D0", Offset = "0x1FB53D0", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000237A File Offset: 0x0000057A
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0000237D File Offset: 0x0000057D
		[global::Cpp2ILInjected.Token(Token = "0x17000050")]
		public bool fillCenter
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000145")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5450", Offset = "0x1FB5450", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000146")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5458", Offset = "0x1FB5458", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00002380 File Offset: 0x00000580
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00002383 File Offset: 0x00000583
		[global::Cpp2ILInjected.Token(Token = "0x17000051")]
		public Image.FillMethod fillMethod
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000147")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB54D8", Offset = "0x1FB54D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000148")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB54E0", Offset = "0x1FB54E0", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { "System.Int32Enum" }, MemberParameters = new object[]
			{
				typeof(ref Int32Enum),
				"System.Int32Enum"
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00002386 File Offset: 0x00000586
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002389 File Offset: 0x00000589
		[global::Cpp2ILInjected.Token(Token = "0x17000052")]
		public float fillAmount
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000149")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5558", Offset = "0x1FB5558", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600014A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5560", Offset = "0x1FB5560", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Slider), Member = "UpdateVisuals", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(float) }, MemberParameters = new object[]
			{
				typeof(ref float),
				typeof(float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600011E RID: 286 RVA: 0x0000238C File Offset: 0x0000058C
		// (set) Token: 0x0600011F RID: 287 RVA: 0x0000238F File Offset: 0x0000058F
		[global::Cpp2ILInjected.Token(Token = "0x17000053")]
		public bool fillClockwise
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB55F0", Offset = "0x1FB55F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600014C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB55F8", Offset = "0x1FB55F8", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00002392 File Offset: 0x00000592
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002395 File Offset: 0x00000595
		[global::Cpp2ILInjected.Token(Token = "0x17000054")]
		public int fillOrigin
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5678", Offset = "0x1FB5678", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600014E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5680", Offset = "0x1FB5680", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility[]), Member = "SetStruct", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00002398 File Offset: 0x00000598
		// (set) Token: 0x06000123 RID: 291 RVA: 0x0000239B File Offset: 0x0000059B
		[Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
		[global::Cpp2ILInjected.Token(Token = "0x17000055")]
		public float eventAlphaThreshold
		{
			[global::Cpp2ILInjected.Token(Token = "0x600014F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5700", Offset = "0x1FB5700", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000150")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5710", Offset = "0x1FB5710", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000124 RID: 292 RVA: 0x0000239E File Offset: 0x0000059E
		// (set) Token: 0x06000125 RID: 293 RVA: 0x000023A1 File Offset: 0x000005A1
		[global::Cpp2ILInjected.Token(Token = "0x17000056")]
		public float alphaHitTestMinimumThreshold
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000151")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5720", Offset = "0x1FB5720", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000152")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5728", Offset = "0x1FB5728", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000023A4 File Offset: 0x000005A4
		// (set) Token: 0x06000127 RID: 295 RVA: 0x000023A7 File Offset: 0x000005A7
		[global::Cpp2ILInjected.Token(Token = "0x17000057")]
		public bool useSpriteMesh
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000153")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5730", Offset = "0x1FB5730", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000154")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5738", Offset = "0x1FB5738", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SetPropertyUtility), Member = "SetStruct", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&", "T" }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000023AA File Offset: 0x000005AA
		[global::Cpp2ILInjected.Token(Token = "0x6000155")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB57B8", Offset = "0x1FB57B8", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = ".ctor", ReturnType = typeof(void))]
		protected Image()
		{
			throw null;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000129 RID: 297 RVA: 0x000023AD File Offset: 0x000005AD
		[global::Cpp2ILInjected.Token(Token = "0x17000058")]
		public static Material defaultETC1GraphicMaterial
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000156")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB57F8", Offset = "0x1FB57F8", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "get_material", ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "GetETC1SupportedCanvasMaterial", ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000023B0 File Offset: 0x000005B0
		[global::Cpp2ILInjected.Token(Token = "0x17000059")]
		public override Texture mainTexture
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000157")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB58D4", Offset = "0x1FB58D4", Length = "0x168")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000023B3 File Offset: 0x000005B3
		[global::Cpp2ILInjected.Token(Token = "0x1700005A")]
		public bool hasBorder
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000158")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5A3C", Offset = "0x1FB5A3C", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000023B6 File Offset: 0x000005B6
		// (set) Token: 0x0600012D RID: 301 RVA: 0x000023B9 File Offset: 0x000005B9
		[global::Cpp2ILInjected.Token(Token = "0x1700005B")]
		public float pixelsPerUnitMultiplier
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000159")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5AEC", Offset = "0x1FB5AEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600015A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5AF4", Offset = "0x1FB5AF4", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000023BC File Offset: 0x000005BC
		[global::Cpp2ILInjected.Token(Token = "0x1700005C")]
		public float pixelsPerUnit
		{
			[global::Cpp2ILInjected.Token(Token = "0x600015B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5B14", Offset = "0x1FB5B14", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "get_multipliedPixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "SetNativeSize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "get_preferredWidth", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "get_preferredHeight", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "MapCoordinate", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Rect)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_referencePixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000023BF File Offset: 0x000005BF
		[global::Cpp2ILInjected.Token(Token = "0x1700005D")]
		protected float multipliedPixelsPerUnit
		{
			[global::Cpp2ILInjected.Token(Token = "0x600015C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5BFC", Offset = "0x1FB5BFC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000130 RID: 304 RVA: 0x000023C2 File Offset: 0x000005C2
		// (set) Token: 0x06000131 RID: 305 RVA: 0x000023C5 File Offset: 0x000005C5
		[global::Cpp2ILInjected.Token(Token = "0x1700005E")]
		public override Material material
		{
			[global::Cpp2ILInjected.Token(Token = "0x600015D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5C18", Offset = "0x1FB5C18", Length = "0x124")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_associatedAlphaSplitTexture", ReturnType = typeof(Texture2D))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_defaultETC1GraphicMaterial", ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600015E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FB5D3C", Offset = "0x1FB5D3C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "set_material", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000023C8 File Offset: 0x000005C8
		[global::Cpp2ILInjected.Token(Token = "0x600015F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB5D40", Offset = "0x1FB5D40", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnBeforeSerialize()
		{
			throw null;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000023CB File Offset: 0x000005CB
		[global::Cpp2ILInjected.Token(Token = "0x6000160")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB5D44", Offset = "0x1FB5D44", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void OnAfterDeserialize()
		{
			throw null;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000023CE File Offset: 0x000005CE
		[global::Cpp2ILInjected.Token(Token = "0x6000161")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB5D94", Offset = "0x1FB5D94", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GetDrawingDimensions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_height", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_y", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_y", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_width", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_x", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "set_x", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize)
		{
			throw null;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000023D1 File Offset: 0x000005D1
		[global::Cpp2ILInjected.Token(Token = "0x6000162")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB5EE0", Offset = "0x1FB5EE0", Length = "0x458")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DataUtility), Member = "GetPadding", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "PreserveSpriteAspectRatio", MemberParameters = new object[]
		{
			typeof(ref Rect),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_x", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_y", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
		{
			throw null;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000023D4 File Offset: 0x000005D4
		[global::Cpp2ILInjected.Token(Token = "0x6000163")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB6338", Offset = "0x1FB6338", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_anchorMin", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void SetNativeSize()
		{
			throw null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000023D7 File Offset: 0x000005D7
		[global::Cpp2ILInjected.Token(Token = "0x6000164")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB647C", Offset = "0x1FB647C", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
			throw null;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000023DA File Offset: 0x000005DA
		[global::Cpp2ILInjected.Token(Token = "0x6000165")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB51D0", Offset = "0x1FB51D0", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "set_sprite", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "set_overrideSprite", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "TrackImage", MemberParameters = new object[] { typeof(Image) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void TrackSprite()
		{
			throw null;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000023DD File Offset: 0x000005DD
		[global::Cpp2ILInjected.Token(Token = "0x6000166")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBBA20", Offset = "0x1FBBA20", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "TrackSprite", ReturnType = typeof(void))]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000023E0 File Offset: 0x000005E0
		[global::Cpp2ILInjected.Token(Token = "0x6000167")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBBA3C", Offset = "0x1FBBA3C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected override void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000023E3 File Offset: 0x000005E3
		[global::Cpp2ILInjected.Token(Token = "0x6000168")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBBB28", Offset = "0x1FBBB28", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "UpdateMaterial", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvasRenderer", ReturnType = typeof(CanvasRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_associatedAlphaSplitTexture", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CanvasRenderer), Member = "SetAlphaTexture", MemberParameters = new object[] { typeof(Texture) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void UpdateMaterial()
		{
			throw null;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000023E6 File Offset: 0x000005E6
		[global::Cpp2ILInjected.Token(Token = "0x6000169")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBBC0C", Offset = "0x1FBBC0C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MaskableGraphic), Member = "OnCanvasHierarchyChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_canvas", ReturnType = typeof(Canvas))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Canvas), Member = "get_referencePixelsPerUnit", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected override void OnCanvasHierarchyChanged()
		{
			throw null;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000023E9 File Offset: 0x000005E9
		[global::Cpp2ILInjected.Token(Token = "0x600016A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB65C0", Offset = "0x1FB65C0", Length = "0xB1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "GetDrawingDimensions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color32),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect)
		{
			throw null;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000023EC File Offset: 0x000005EC
		[global::Cpp2ILInjected.Token(Token = "0x600016B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB70DC", Offset = "0x1FB70DC", Length = "0x568")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_pivot", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "PreserveSpriteAspectRatio", MemberParameters = new object[]
		{
			typeof(ref Rect),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_bounds", ReturnType = typeof(Bounds))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_size", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_vertices", ReturnType = typeof(Vector2[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_uv", ReturnType = typeof(Vector2[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color32),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_triangles", ReturnType = typeof(ushort[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void GenerateSprite(VertexHelper vh, bool lPreserveAspect)
		{
			throw null;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x000023EF File Offset: 0x000005EF
		[global::Cpp2ILInjected.Token(Token = "0x600016C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB7644", Offset = "0x1FB7644", Length = "0x744")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_hasBorder", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DataUtility), Member = "GetInnerUV", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DataUtility), Member = "GetPadding", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "GetAdjustedBorders", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Rect)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_x", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_y", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "AddQuad", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color32),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void GenerateSlicedSprite(VertexHelper toFill)
		{
			throw null;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000023F2 File Offset: 0x000005F2
		[global::Cpp2ILInjected.Token(Token = "0x600016D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FB7D88", Offset = "0x1FB7D88", Length = "0x2928")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DataUtility), Member = "GetInnerUV", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "GetAdjustedBorders", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Rect)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_hasBorder", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_packed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture), Member = "get_wrapMode", ReturnType = typeof(TextureWrapMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_position", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "AddQuad", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color32),
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 62)]
		private void GenerateTiledSprite(VertexHelper toFill)
		{
			throw null;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000023F5 File Offset: 0x000005F5
		[global::Cpp2ILInjected.Token(Token = "0x600016E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBBFA8", Offset = "0x1FBBFA8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "get_currentVertCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color32),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs)
		{
			throw null;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000023F8 File Offset: 0x000005F8
		[global::Cpp2ILInjected.Token(Token = "0x600016F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBBE5C", Offset = "0x1FBBE5C", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "get_currentVertCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Color32),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax)
		{
			throw null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000023FB File Offset: 0x000005FB
		[global::Cpp2ILInjected.Token(Token = "0x6000170")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBBD08", Offset = "0x1FBBD08", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "MapCoordinate", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Rect)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect)
		{
			throw null;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000023FE File Offset: 0x000005FE
		[global::Cpp2ILInjected.Token(Token = "0x6000171")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBA6B0", Offset = "0x1FBA6B0", Length = "0x1220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "OnPopulateMesh", MemberParameters = new object[] { typeof(VertexHelper) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "GetDrawingDimensions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "AddQuad", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(Vector3[]),
			typeof(Color32),
			typeof(Vector3[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "RadialCut", MemberParameters = new object[]
		{
			typeof(Vector3[]),
			typeof(Vector3[]),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect)
		{
			throw null;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002401 File Offset: 0x00000601
		[global::Cpp2ILInjected.Token(Token = "0x6000172")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBC060", Offset = "0x1FBC060", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new object[]
		{
			typeof(VertexHelper),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "RadialCut", MemberParameters = new object[]
		{
			typeof(Vector3[]),
			typeof(float),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner)
		{
			throw null;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002404 File Offset: 0x00000604
		[global::Cpp2ILInjected.Token(Token = "0x6000173")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBC180", Offset = "0x1FBC180", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "RadialCut", MemberParameters = new object[]
		{
			typeof(Vector3[]),
			typeof(Vector3[]),
			typeof(float),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner)
		{
			throw null;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002407 File Offset: 0x00000607
		[global::Cpp2ILInjected.Token(Token = "0x6000174")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBC46C", Offset = "0x1FBC46C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void CalculateLayoutInputHorizontal()
		{
			throw null;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000240A File Offset: 0x0000060A
		[global::Cpp2ILInjected.Token(Token = "0x6000175")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBC470", Offset = "0x1FBC470", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void CalculateLayoutInputVertical()
		{
			throw null;
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000240D File Offset: 0x0000060D
		[global::Cpp2ILInjected.Token(Token = "0x1700005F")]
		public virtual float minWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000176")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBC474", Offset = "0x1FBC474", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00002410 File Offset: 0x00000610
		[global::Cpp2ILInjected.Token(Token = "0x17000060")]
		public virtual float preferredWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000177")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBC47C", Offset = "0x1FBC47C", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DataUtility), Member = "GetMinSize", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00002413 File Offset: 0x00000613
		[global::Cpp2ILInjected.Token(Token = "0x17000061")]
		public virtual float flexibleWidth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000178")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBC558", Offset = "0x1FBC558", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00002416 File Offset: 0x00000616
		[global::Cpp2ILInjected.Token(Token = "0x17000062")]
		public virtual float minHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000179")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBC560", Offset = "0x1FBC560", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00002419 File Offset: 0x00000619
		[global::Cpp2ILInjected.Token(Token = "0x17000063")]
		public virtual float preferredHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x600017A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBC568", Offset = "0x1FBC568", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DataUtility), Member = "GetMinSize", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600014E RID: 334 RVA: 0x0000241C File Offset: 0x0000061C
		[global::Cpp2ILInjected.Token(Token = "0x17000064")]
		public virtual float flexibleHeight
		{
			[global::Cpp2ILInjected.Token(Token = "0x600017B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBC644", Offset = "0x1FBC644", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000241F File Offset: 0x0000061F
		[global::Cpp2ILInjected.Token(Token = "0x17000065")]
		public virtual int layoutPriority
		{
			[global::Cpp2ILInjected.Token(Token = "0x600017C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FBC64C", Offset = "0x1FBC64C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002422 File Offset: 0x00000622
		[global::Cpp2ILInjected.Token(Token = "0x600017D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBC654", Offset = "0x1FBC654", Length = "0x354")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransformUtility), Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "GetPixelAdjustedRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RectTransform), Member = "get_pivot", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "MapCoordinate", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Rect)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_textureRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_x", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_y", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = "GetPixelBilinear", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{
			throw null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002425 File Offset: 0x00000625
		[global::Cpp2ILInjected.Token(Token = "0x600017E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBC9A8", Offset = "0x1FBC9A8", Length = "0x330")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "IsRaycastLocationValid", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Camera)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "GetAdjustedBorders", MemberParameters = new object[]
		{
			typeof(Vector4),
			typeof(Rect)
		}, ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_size", ReturnType = typeof(Vector2))]
		private Vector2 MapCoordinate(Vector2 local, Rect rect)
		{
			throw null;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002428 File Offset: 0x00000628
		[global::Cpp2ILInjected.Token(Token = "0x600017F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBCCD8", Offset = "0x1FBCCD8", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Image), Member = "get_activeSprite", ReturnType = typeof(Sprite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteAtlas), Member = "CanBindTo", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void RebuildImage(SpriteAtlas spriteAtlas)
		{
			throw null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000242B File Offset: 0x0000062B
		[global::Cpp2ILInjected.Token(Token = "0x6000180")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBB8D0", Offset = "0x1FBB8D0", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Image), Member = "TrackSprite", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Action<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteAtlasManager), Member = "add_atlasRegistered", MemberParameters = new object[] { typeof(Action<SpriteAtlas>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void TrackImage(Image g)
		{
			throw null;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000242E File Offset: 0x0000062E
		[global::Cpp2ILInjected.Token(Token = "0x6000181")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBBAB0", Offset = "0x1FBBAB0", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void UnTrackImage(Image g)
		{
			throw null;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002431 File Offset: 0x00000631
		[global::Cpp2ILInjected.Token(Token = "0x6000182")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBCE68", Offset = "0x1FBCE68", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Graphic), Member = "SetRaycastDirty", ReturnType = typeof(void))]
		protected override void OnDidApplyAnimationProperties()
		{
			throw null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002434 File Offset: 0x00000634
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000183")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FBCEA0", Offset = "0x1FBCEA0", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		static Image()
		{
			throw null;
		}

		// Token: 0x04000070 RID: 112
		[global::Cpp2ILInjected.Token(Token = "0x4000091")]
		protected static Material s_ETC1DefaultUI;

		// Token: 0x04000071 RID: 113
		[FormerlySerializedAs("m_Frame")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000092")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private Sprite m_Sprite;

		// Token: 0x04000072 RID: 114
		[global::Cpp2ILInjected.Token(Token = "0x4000093")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		[NonSerialized]
		private Sprite m_OverrideSprite;

		// Token: 0x04000073 RID: 115
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000094")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private Image.Type m_Type;

		// Token: 0x04000074 RID: 116
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000095")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE4")]
		private bool m_PreserveAspect;

		// Token: 0x04000075 RID: 117
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000096")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE5")]
		private bool m_FillCenter;

		// Token: 0x04000076 RID: 118
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000097")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private Image.FillMethod m_FillMethod;

		// Token: 0x04000077 RID: 119
		[Range(0f, 1f)]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000098")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
		private float m_FillAmount;

		// Token: 0x04000078 RID: 120
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000099")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private bool m_FillClockwise;

		// Token: 0x04000079 RID: 121
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400009A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
		private int m_FillOrigin;

		// Token: 0x0400007A RID: 122
		[global::Cpp2ILInjected.Token(Token = "0x400009B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private float m_AlphaHitTestMinimumThreshold;

		// Token: 0x0400007B RID: 123
		[global::Cpp2ILInjected.Token(Token = "0x400009C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
		private bool m_Tracked;

		// Token: 0x0400007C RID: 124
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400009D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xFD")]
		private bool m_UseSpriteMesh;

		// Token: 0x0400007D RID: 125
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400009E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private float m_PixelsPerUnitMultiplier;

		// Token: 0x0400007E RID: 126
		[global::Cpp2ILInjected.Token(Token = "0x400009F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
		private float m_CachedReferencePixelsPerUnit;

		// Token: 0x0400007F RID: 127
		[global::Cpp2ILInjected.Token(Token = "0x40000A0")]
		private static readonly Vector2[] s_VertScratch;

		// Token: 0x04000080 RID: 128
		[global::Cpp2ILInjected.Token(Token = "0x40000A1")]
		private static readonly Vector2[] s_UVScratch;

		// Token: 0x04000081 RID: 129
		[global::Cpp2ILInjected.Token(Token = "0x40000A2")]
		private static readonly Vector3[] s_Xy;

		// Token: 0x04000082 RID: 130
		[global::Cpp2ILInjected.Token(Token = "0x40000A3")]
		private static readonly Vector3[] s_Uv;

		// Token: 0x04000083 RID: 131
		[global::Cpp2ILInjected.Token(Token = "0x40000A4")]
		private static List<Image> m_TrackedTexturelessImages;

		// Token: 0x04000084 RID: 132
		[global::Cpp2ILInjected.Token(Token = "0x40000A5")]
		private static bool s_Initialized;

		// Token: 0x0200008C RID: 140
		[global::Cpp2ILInjected.Token(Token = "0x2000023")]
		public enum Type
		{
			// Token: 0x0400026B RID: 619
			[global::Cpp2ILInjected.Token(Token = "0x40000A7")]
			Simple,
			// Token: 0x0400026C RID: 620
			[global::Cpp2ILInjected.Token(Token = "0x40000A8")]
			Sliced,
			// Token: 0x0400026D RID: 621
			[global::Cpp2ILInjected.Token(Token = "0x40000A9")]
			Tiled,
			// Token: 0x0400026E RID: 622
			[global::Cpp2ILInjected.Token(Token = "0x40000AA")]
			Filled
		}

		// Token: 0x0200008D RID: 141
		[global::Cpp2ILInjected.Token(Token = "0x2000024")]
		public enum FillMethod
		{
			// Token: 0x04000270 RID: 624
			[global::Cpp2ILInjected.Token(Token = "0x40000AC")]
			Horizontal,
			// Token: 0x04000271 RID: 625
			[global::Cpp2ILInjected.Token(Token = "0x40000AD")]
			Vertical,
			// Token: 0x04000272 RID: 626
			[global::Cpp2ILInjected.Token(Token = "0x40000AE")]
			Radial90,
			// Token: 0x04000273 RID: 627
			[global::Cpp2ILInjected.Token(Token = "0x40000AF")]
			Radial180,
			// Token: 0x04000274 RID: 628
			[global::Cpp2ILInjected.Token(Token = "0x40000B0")]
			Radial360
		}

		// Token: 0x0200008E RID: 142
		[global::Cpp2ILInjected.Token(Token = "0x2000025")]
		public enum OriginHorizontal
		{
			// Token: 0x04000276 RID: 630
			[global::Cpp2ILInjected.Token(Token = "0x40000B2")]
			Left,
			// Token: 0x04000277 RID: 631
			[global::Cpp2ILInjected.Token(Token = "0x40000B3")]
			Right
		}

		// Token: 0x0200008F RID: 143
		[global::Cpp2ILInjected.Token(Token = "0x2000026")]
		public enum OriginVertical
		{
			// Token: 0x04000279 RID: 633
			[global::Cpp2ILInjected.Token(Token = "0x40000B5")]
			Bottom,
			// Token: 0x0400027A RID: 634
			[global::Cpp2ILInjected.Token(Token = "0x40000B6")]
			Top
		}

		// Token: 0x02000090 RID: 144
		[global::Cpp2ILInjected.Token(Token = "0x2000027")]
		public enum Origin90
		{
			// Token: 0x0400027C RID: 636
			[global::Cpp2ILInjected.Token(Token = "0x40000B8")]
			BottomLeft,
			// Token: 0x0400027D RID: 637
			[global::Cpp2ILInjected.Token(Token = "0x40000B9")]
			TopLeft,
			// Token: 0x0400027E RID: 638
			[global::Cpp2ILInjected.Token(Token = "0x40000BA")]
			TopRight,
			// Token: 0x0400027F RID: 639
			[global::Cpp2ILInjected.Token(Token = "0x40000BB")]
			BottomRight
		}

		// Token: 0x02000091 RID: 145
		[global::Cpp2ILInjected.Token(Token = "0x2000028")]
		public enum Origin180
		{
			// Token: 0x04000281 RID: 641
			[global::Cpp2ILInjected.Token(Token = "0x40000BD")]
			Bottom,
			// Token: 0x04000282 RID: 642
			[global::Cpp2ILInjected.Token(Token = "0x40000BE")]
			Left,
			// Token: 0x04000283 RID: 643
			[global::Cpp2ILInjected.Token(Token = "0x40000BF")]
			Top,
			// Token: 0x04000284 RID: 644
			[global::Cpp2ILInjected.Token(Token = "0x40000C0")]
			Right
		}

		// Token: 0x02000092 RID: 146
		[global::Cpp2ILInjected.Token(Token = "0x2000029")]
		public enum Origin360
		{
			// Token: 0x04000286 RID: 646
			[global::Cpp2ILInjected.Token(Token = "0x40000C2")]
			Bottom,
			// Token: 0x04000287 RID: 647
			[global::Cpp2ILInjected.Token(Token = "0x40000C3")]
			Right,
			// Token: 0x04000288 RID: 648
			[global::Cpp2ILInjected.Token(Token = "0x40000C4")]
			Top,
			// Token: 0x04000289 RID: 649
			[global::Cpp2ILInjected.Token(Token = "0x40000C5")]
			Left
		}
	}
}
