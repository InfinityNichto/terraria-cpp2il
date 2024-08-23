using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200004E RID: 78
	[global::Cpp2ILInjected.Token(Token = "0x2000058")]
	[Serializable]
	public class TouchSprite
	{
		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00002C3C File Offset: 0x00000E3C
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00002C3F File Offset: 0x00000E3F
		[global::Cpp2ILInjected.Token(Token = "0x17000137")]
		public bool Dirty
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000413")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4634", Offset = "0x19A4634", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000414")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A463C", Offset = "0x19A463C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00002C42 File Offset: 0x00000E42
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00002C45 File Offset: 0x00000E45
		[global::Cpp2ILInjected.Token(Token = "0x17000138")]
		public bool Ready
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000415")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4648", Offset = "0x19A4648", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000416")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4650", Offset = "0x19A4650", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002C48 File Offset: 0x00000E48
		[global::Cpp2ILInjected.Token(Token = "0x6000417")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A465C", Offset = "0x19A465C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public TouchSprite()
		{
			throw null;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002C4B File Offset: 0x00000E4B
		[global::Cpp2ILInjected.Token(Token = "0x6000418")]
		[global::Cpp2ILInjected.Address(RVA = "0x199EA38", Offset = "0x199EA38", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public TouchSprite(float size)
		{
			throw null;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00002C4E File Offset: 0x00000E4E
		[global::Cpp2ILInjected.Token(Token = "0x6000419")]
		[global::Cpp2ILInjected.Address(RVA = "0x199DAB8", Offset = "0x199DAB8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "CreateControl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "CreateSpriteGameObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Transform)
		}, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "CreateSpriteRenderer", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(Sprite),
			typeof(int)
		}, ReturnType = typeof(SpriteRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteRenderer), Member = "set_color", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		public void Create(string gameObjectName, Transform parentTransform, int sortingOrder)
		{
			throw null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002C51 File Offset: 0x00000E51
		[global::Cpp2ILInjected.Token(Token = "0x600041A")]
		[global::Cpp2ILInjected.Address(RVA = "0x199DB3C", Offset = "0x199DB3C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = "DestroyControl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "DestroyControl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "Destroy", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Delete()
		{
			throw null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002C54 File Offset: 0x00000E54
		[global::Cpp2ILInjected.Token(Token = "0x600041B")]
		[global::Cpp2ILInjected.Address(RVA = "0x199E084", Offset = "0x199E084", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		public void Update()
		{
			throw null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002C57 File Offset: 0x00000E57
		[global::Cpp2ILInjected.Token(Token = "0x600041C")]
		[global::Cpp2ILInjected.Address(RVA = "0x199DC84", Offset = "0x199DC84", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = "ConfigureControl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "ConfigureControl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteRenderer), Member = "set_sprite", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchUtility), Member = "RoundVector", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "ScaleSpriteInPixels", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(SpriteRenderer),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_PixelToWorld", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "ScaleSpriteInPercent", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(SpriteRenderer),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_PercentToWorld", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_ViewSize", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteRenderer), Member = "get_color", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_unscaledDeltaTime", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "MoveColorTowards", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteRenderer), Member = "set_color", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void Update(bool forceUpdate)
		{
			throw null;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002C5A File Offset: 0x00000E5A
		[global::Cpp2ILInjected.Token(Token = "0x600041D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A4684", Offset = "0x19A4684", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Transform),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_parent", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_localPosition", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_layer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "set_layer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private GameObject CreateSpriteGameObject(string name, Transform parentTransform)
		{
			throw null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002C5D File Offset: 0x00000E5D
		[global::Cpp2ILInjected.Token(Token = "0x600041E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A47C8", Offset = "0x19A47C8", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Transform),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteRenderer), Member = "set_sprite", MemberParameters = new object[] { typeof(Sprite) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Renderer), Member = "set_sortingOrder", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Shader))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new object[] { typeof(Shader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Renderer), Member = "set_sharedMaterial", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Renderer), Member = "get_sharedMaterial", ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private SpriteRenderer CreateSpriteRenderer(GameObject spriteGameObject, Sprite sprite, int sortingOrder)
		{
			throw null;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002C60 File Offset: 0x00000E60
		[global::Cpp2ILInjected.Token(Token = "0x600041F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A48EC", Offset = "0x19A48EC", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteRenderer), Member = "get_sprite", ReturnType = typeof(Sprite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_bounds", ReturnType = typeof(Bounds))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_size", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_PixelToWorld", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rect), Member = "get_height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ScaleSpriteInPixels(GameObject spriteGameObject, SpriteRenderer spriteRenderer, Vector2 size)
		{
			throw null;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002C63 File Offset: 0x00000E63
		[global::Cpp2ILInjected.Token(Token = "0x6000420")]
		[global::Cpp2ILInjected.Address(RVA = "0x19A4AD0", Offset = "0x19A4AD0", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "Update", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteRenderer), Member = "get_sprite", ReturnType = typeof(Sprite))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "get_ViewSize", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Sprite), Member = "get_bounds", ReturnType = typeof(Bounds))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Bounds), Member = "get_size", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_localScale", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ScaleSpriteInPercent(GameObject spriteGameObject, SpriteRenderer spriteRenderer, Vector2 size)
		{
			throw null;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002C66 File Offset: 0x00000E66
		[global::Cpp2ILInjected.Token(Token = "0x6000421")]
		[global::Cpp2ILInjected.Address(RVA = "0x199F510", Offset = "0x199F510", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "TouchBegan", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "Contains", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "get_Position", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "Abs", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Contains(Vector2 testWorldPoint)
		{
			throw null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002C69 File Offset: 0x00000E69
		[global::Cpp2ILInjected.Token(Token = "0x6000422")]
		[global::Cpp2ILInjected.Address(RVA = "0x199E3F4", Offset = "0x199E3F4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = "SubmitControlState", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = "TouchBegan", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = "TouchMoved", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchManager), Member = "ScreenToWorldPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TouchSprite), Member = "Contains", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		public bool Contains(Touch touch)
		{
			throw null;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002C6C File Offset: 0x00000E6C
		[global::Cpp2ILInjected.Token(Token = "0x6000423")]
		[global::Cpp2ILInjected.Address(RVA = "0x199DF74", Offset = "0x199DF74", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = "DrawGizmos", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "DrawGizmos", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "DrawRectGizmo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "DrawOvalGizmo", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void DrawGizmos(Vector3 position, Color color)
		{
			throw null;
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00002C6F File Offset: 0x00000E6F
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00002C72 File Offset: 0x00000E72
		[global::Cpp2ILInjected.Token(Token = "0x17000139")]
		public bool State
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000424")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4CC4", Offset = "0x19A4CC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000425")]
			[global::Cpp2ILInjected.Address(RVA = "0x199E790", Offset = "0x199E790", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00002C75 File Offset: 0x00000E75
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x00002C78 File Offset: 0x00000E78
		[global::Cpp2ILInjected.Token(Token = "0x1700013A")]
		public Sprite BusySprite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000426")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4CCC", Offset = "0x19A4CCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000427")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4CD4", Offset = "0x19A4CD4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::UnityEngine.Object),
				typeof(global::UnityEngine.Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00002C7B File Offset: 0x00000E7B
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00002C7E File Offset: 0x00000E7E
		[global::Cpp2ILInjected.Token(Token = "0x1700013B")]
		public Sprite IdleSprite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000428")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4D54", Offset = "0x19A4D54", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000429")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4D5C", Offset = "0x19A4D5C", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::UnityEngine.Object),
				typeof(global::UnityEngine.Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700013A RID: 314
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00002C81 File Offset: 0x00000E81
		[global::Cpp2ILInjected.Token(Token = "0x1700013C")]
		public Sprite Sprite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600042A")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4DDC", Offset = "0x19A4DDC", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::UnityEngine.Object),
				typeof(global::UnityEngine.Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x00002C84 File Offset: 0x00000E84
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00002C87 File Offset: 0x00000E87
		[global::Cpp2ILInjected.Token(Token = "0x1700013D")]
		public Color BusyColor
		{
			[global::Cpp2ILInjected.Token(Token = "0x600042B")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4E90", Offset = "0x19A4E90", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600042C")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4E9C", Offset = "0x19A4E9C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00002C8A File Offset: 0x00000E8A
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00002C8D File Offset: 0x00000E8D
		[global::Cpp2ILInjected.Token(Token = "0x1700013E")]
		public Color IdleColor
		{
			[global::Cpp2ILInjected.Token(Token = "0x600042D")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4EF4", Offset = "0x19A4EF4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600042E")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4F00", Offset = "0x19A4F00", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00002C90 File Offset: 0x00000E90
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00002C93 File Offset: 0x00000E93
		[global::Cpp2ILInjected.Token(Token = "0x1700013F")]
		public TouchSpriteShape Shape
		{
			[global::Cpp2ILInjected.Token(Token = "0x600042F")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4F58", Offset = "0x19A4F58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000430")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4F60", Offset = "0x19A4F60", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00002C96 File Offset: 0x00000E96
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00002C99 File Offset: 0x00000E99
		[global::Cpp2ILInjected.Token(Token = "0x17000140")]
		public TouchUnitType SizeUnitType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000431")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4F7C", Offset = "0x19A4F7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000432")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4F84", Offset = "0x19A4F84", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00002C9C File Offset: 0x00000E9C
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00002C9F File Offset: 0x00000E9F
		[global::Cpp2ILInjected.Token(Token = "0x17000141")]
		public Vector2 Size
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000433")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4FA0", Offset = "0x19A4FA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000434")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4FA8", Offset = "0x19A4FA8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00002CA2 File Offset: 0x00000EA2
		[global::Cpp2ILInjected.Token(Token = "0x17000142")]
		public Vector2 WorldSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000435")]
			[global::Cpp2ILInjected.Address(RVA = "0x19A4FE0", Offset = "0x19A4FE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00002CA5 File Offset: 0x00000EA5
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x00002CA8 File Offset: 0x00000EA8
		[global::Cpp2ILInjected.Token(Token = "0x17000143")]
		public Vector3 Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000436")]
			[global::Cpp2ILInjected.Address(RVA = "0x199E7B0", Offset = "0x199E7B0", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchButtonControl), Member = "get_ButtonPosition", ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "get_RingPosition", ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "get_KnobPosition", ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchSprite), Member = "Contains", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000437")]
			[global::Cpp2ILInjected.Address(RVA = "0x199E878", Offset = "0x199E878", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "TouchBegan", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "TouchMoved", MemberParameters = new object[] { typeof(Touch) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "set_RingPosition", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchStickControl), Member = "set_KnobPosition", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "get_transform", ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0400036B RID: 875
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Sprite idleSprite;

		// Token: 0x0400036C RID: 876
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Sprite busySprite;

		// Token: 0x0400036D RID: 877
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Color idleColor;

		// Token: 0x0400036E RID: 878
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Color busyColor;

		// Token: 0x0400036F RID: 879
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private TouchSpriteShape shape;

		// Token: 0x04000370 RID: 880
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private TouchUnitType sizeUnitType;

		// Token: 0x04000371 RID: 881
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Vector2 size;

		// Token: 0x04000372 RID: 882
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool lockAspectRatio;

		// Token: 0x04000373 RID: 883
		[SerializeField]
		[HideInInspector]
		[global::Cpp2ILInjected.Token(Token = "0x40003BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private Vector2 worldSize;

		// Token: 0x04000374 RID: 884
		[global::Cpp2ILInjected.Token(Token = "0x40003C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private GameObject spriteGameObject;

		// Token: 0x04000375 RID: 885
		[global::Cpp2ILInjected.Token(Token = "0x40003C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private SpriteRenderer spriteRenderer;

		// Token: 0x04000376 RID: 886
		[global::Cpp2ILInjected.Token(Token = "0x40003C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool state;

		// Token: 0x04000377 RID: 887
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x71")]
		private bool <Dirty>k__BackingField;

		// Token: 0x04000378 RID: 888
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40003C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x72")]
		private bool <Ready>k__BackingField;
	}
}
