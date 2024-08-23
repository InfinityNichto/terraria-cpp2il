using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000CC RID: 204
	[RequiredByNativeCode]
	[NativeHeader("Configuration/UnityConfigure.h")]
	[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
	[NativeHeader("Runtime/Transform/Transform.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000E0")]
	public class Transform : Component, IEnumerable
	{
		// Token: 0x0600047E RID: 1150 RVA: 0x00002A0A File Offset: 0x00000C0A
		[global::Cpp2ILInjected.Token(Token = "0x6000496")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F84D4C", Offset = "0x1F84D4C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = ".ctor", ReturnType = typeof(void))]
		protected Transform()
		{
			throw null;
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00002A0D File Offset: 0x00000C0D
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00002A10 File Offset: 0x00000C10
		[global::Cpp2ILInjected.Token(Token = "0x170000EC")]
		public Vector3 position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000497")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F84D54", Offset = "0x1F84D54", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000498")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F84DF4", Offset = "0x1F84DF4", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DistortionRenderTargetManager", Member = "InitialiseCamera", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WaterRenderTargetManager", Member = "InitialiseCamera", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAUICameraSettings", Member = "ApplyCamera", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAWorldCameraSettings", Member = "ApplyCamera", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "SetOffset", MemberParameters = new object[] { "Microsoft.Xna.Framework.Vector2" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchButtonControl", Member = "ConfigureControl", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchStickControl", Member = "ConfigureControl", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "set_Position", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceMovement.ButtonFocus", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00002A13 File Offset: 0x00000C13
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00002A16 File Offset: 0x00000C16
		[global::Cpp2ILInjected.Token(Token = "0x170000ED")]
		public Vector3 localPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000499")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F84E8C", Offset = "0x1F84E8C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600049A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F84F2C", Offset = "0x1F84F2C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GameObjectExtensions", Member = "InstantiatePrefabAsChild", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(GameObject)
			}, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance", Member = "SetPosition", MemberParameters = new object[] { "Microsoft.Xna.Framework.Vector3", "Microsoft.Xna.Framework.Vector3" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance", Member = "SetTransformFromMatrix", MemberParameters = new object[]
			{
				typeof(Transform),
				"Microsoft.Xna.Framework.Matrix&"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "CreateSpriteGameObject", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Transform)
			}, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00002A19 File Offset: 0x00000C19
		[global::Cpp2ILInjected.Token(Token = "0x170000EE")]
		public Vector3 forward
		{
			[global::Cpp2ILInjected.Token(Token = "0x600049B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F84FC4", Offset = "0x1F84FC4", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "get_rotation", ReturnType = typeof(Quaternion))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Quaternion), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Quaternion),
				typeof(Vector3)
			}, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00002A1C File Offset: 0x00000C1C
		[global::Cpp2ILInjected.Token(Token = "0x170000EF")]
		public Quaternion rotation
		{
			[global::Cpp2ILInjected.Token(Token = "0x600049C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8503C", Offset = "0x1F8503C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
			{
				typeof(Light),
				typeof(ref DirectionalLight)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
			{
				typeof(Light),
				typeof(ref PointLight)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
			{
				typeof(Light),
				typeof(ref SpotLight)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
			{
				typeof(Light),
				typeof(ref RectangleLight)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
			{
				typeof(Light),
				typeof(ref DiscLight)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectable", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = "UnityEngine.UI.Selectable")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectableOnLeft", ReturnType = "UnityEngine.UI.Selectable")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectableOnRight", ReturnType = "UnityEngine.UI.Selectable")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectableOnUp", ReturnType = "UnityEngine.UI.Selectable")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectableOnDown", ReturnType = "UnityEngine.UI.Selectable")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToWorldPointInRectangle", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(Vector2),
				typeof(Camera),
				typeof(ref Vector3)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00002A1F File Offset: 0x00000C1F
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00002A22 File Offset: 0x00000C22
		[global::Cpp2ILInjected.Token(Token = "0x170000F0")]
		public Quaternion localRotation
		{
			[global::Cpp2ILInjected.Token(Token = "0x600049D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F850D8", Offset = "0x1F850D8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600049E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F85174", Offset = "0x1F85174", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GameObjectExtensions", Member = "InstantiatePrefabAsChild", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(GameObject)
			}, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance", Member = "SetTransformFromMatrix", MemberParameters = new object[]
			{
				typeof(Transform),
				"Microsoft.Xna.Framework.Matrix&"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00002A25 File Offset: 0x00000C25
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00002A28 File Offset: 0x00000C28
		[global::Cpp2ILInjected.Token(Token = "0x170000F1")]
		public Vector3 localScale
		{
			[global::Cpp2ILInjected.Token(Token = "0x600049F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8520C", Offset = "0x1F8520C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "CalcAlongAxis", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.HorizontalOrVerticalLayoutGroup", Member = "SetChildrenAlongAxis", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F852AC", Offset = "0x1F852AC", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GameObjectExtensions", Member = "InstantiatePrefabAsChild", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(GameObject)
			}, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance", Member = "SetPosition", MemberParameters = new object[] { "Microsoft.Xna.Framework.Vector3", "Microsoft.Xna.Framework.Vector3" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance", Member = "SetTransformFromMatrix", MemberParameters = new object[]
			{
				typeof(Transform),
				"Microsoft.Xna.Framework.Matrix&"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "CreateSpriteGameObject", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Transform)
			}, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "ScaleSpriteInPixels", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(SpriteRenderer),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "ScaleSpriteInPercent", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(SpriteRenderer),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "AssignPositioningIfNeeded", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00002A2B File Offset: 0x00000C2B
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00002A2E File Offset: 0x00000C2E
		[global::Cpp2ILInjected.Token(Token = "0x170000F2")]
		public Transform parent
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F85344", Offset = "0x1F85344", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 48)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F853BC", Offset = "0x1F853BC", Length = "0xCC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GameObjectExtensions", Member = "InstantiatePrefabAsChild", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(GameObject)
			}, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance", Member = ".ctor", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "SetupParent", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "CreateSpriteGameObject", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Transform)
			}, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Misc", Member = "Destroy", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[]
			{
				typeof(object),
				typeof(Object)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00002A31 File Offset: 0x00000C31
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00002A34 File Offset: 0x00000C34
		[global::Cpp2ILInjected.Token(Token = "0x170000F3")]
		internal Transform parentInternal
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F85380", Offset = "0x1F85380", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F85488", Offset = "0x1F85488", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600048D RID: 1165
		[global::Cpp2ILInjected.Token(Token = "0x60004A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F854D0", Offset = "0x1F854D0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern Transform GetParent();

		// Token: 0x0600048E RID: 1166 RVA: 0x00002A37 File Offset: 0x00000C37
		[global::Cpp2ILInjected.Token(Token = "0x60004A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8550C", Offset = "0x1F8550C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetParent(Transform p)
		{
			throw null;
		}

		// Token: 0x0600048F RID: 1167
		[FreeFunction("SetParent", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60004A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85554", Offset = "0x1F85554", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "SetParentAndAlign", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "AddItem", MemberParameters = new object[]
		{
			"UnityEngine.UI.Dropdown.OptionData",
			typeof(bool),
			"UnityEngine.UI.Dropdown.DropdownItem",
			"System.Collections.Generic.List`1<DropdownItem>"
		}, ReturnType = "UnityEngine.UI.Dropdown.DropdownItem")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern void SetParent(Transform parent, bool worldPositionStays);

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00002A3A File Offset: 0x00000C3A
		[global::Cpp2ILInjected.Token(Token = "0x170000F4")]
		public Matrix4x4 worldToLocalMatrix
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F855A8", Offset = "0x1F855A8", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskableGraphic", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "GetBounds", ReturnType = typeof(Bounds))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00002A3D File Offset: 0x00000C3D
		[global::Cpp2ILInjected.Token(Token = "0x170000F5")]
		public Matrix4x4 localToWorldMatrix
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F85658", Offset = "0x1F85658", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002A40 File Offset: 0x00000C40
		[NativeMethod("RotateAround")]
		[global::Cpp2ILInjected.Token(Token = "0x60004AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85708", Offset = "0x1F85708", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Transform), Member = "Rotate", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float),
			typeof(Space)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void RotateAroundInternal(Vector3 axis, float angle)
		{
			throw null;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002A43 File Offset: 0x00000C43
		[global::Cpp2ILInjected.Token(Token = "0x60004AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F857C0", Offset = "0x1F857C0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualDeviceExample.VirtualDeviceExample", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TouchExample.CubeController", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.Player", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerBasicExample.Player", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BasicExample.BasicExample", Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "TransformDirection", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "RotateAroundInternal", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(void))]
		public void Rotate(Vector3 axis, float angle, [DefaultValue("Space.Self")] Space relativeTo)
		{
			throw null;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002A46 File Offset: 0x00000C46
		[global::Cpp2ILInjected.Token(Token = "0x60004AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85844", Offset = "0x1F85844", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Transform), Member = "Rotate", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float),
			typeof(Space)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Vector3 TransformDirection(Vector3 direction)
		{
			throw null;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002A49 File Offset: 0x00000C49
		[global::Cpp2ILInjected.Token(Token = "0x60004AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85900", Offset = "0x1F85900", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "GenerateCaret", MemberParameters = new object[]
		{
			"UnityEngine.UI.VertexHelper",
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "FindSelectable", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = "UnityEngine.UI.Selectable")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Vector3 TransformPoint(Vector3 position)
		{
			throw null;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00002A4C File Offset: 0x00000C4C
		[global::Cpp2ILInjected.Token(Token = "0x60004AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F859BC", Offset = "0x1F859BC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RectangularVertexClipper", Member = "GetCanvasRect", MemberParameters = new object[]
		{
			typeof(RectTransform),
			"UnityEngine.Canvas"
		}, ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "get_rootCanvasRect", ReturnType = typeof(Rect))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToLocalPointInRectangle", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(ref Vector2)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Vector3 InverseTransformPoint(Vector3 position)
		{
			throw null;
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000497 RID: 1175
		[global::Cpp2ILInjected.Token(Token = "0x170000F6")]
		public extern int childCount
		{
			[NativeMethod("GetChildrenCount")]
			[global::Cpp2ILInjected.Token(Token = "0x60004AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F85A78", Offset = "0x1F85A78", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "SerialiseAtPath", MemberParameters = new object[]
			{
				typeof(BinaryWriter),
				typeof(Transform)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "FindAllInChildren", MemberParameters = new object[]
			{
				typeof(Transform),
				typeof(string),
				"System.Collections.Generic.List`1<Transform>"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "GetChildByName", MemberParameters = new object[]
			{
				typeof(Transform),
				typeof(string)
			}, ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "FindInChildren", MemberParameters = new object[]
			{
				typeof(Transform),
				typeof(string)
			}, ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "FindInObjectOrChildren", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(Transform) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "FindInChildren", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(Transform) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "SetLayer", MemberParameters = new object[]
			{
				typeof(Transform),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "SetLayerRecursively", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "OnSelectItem", MemberParameters = new object[] { "UnityEngine.UI.Toggle" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = "PerformLayoutControl", MemberParameters = new object[]
			{
				typeof(RectTransform),
				"UnityEngine.Events.UnityAction`1<Component>"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = "PerformLayoutCalculation", MemberParameters = new object[]
			{
				typeof(RectTransform),
				"UnityEngine.Events.UnityAction`1<Component>"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutOnAxis", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(int),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutAxes", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x06000498 RID: 1176
		[global::Cpp2ILInjected.Token(Token = "0x60004B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85AB4", Offset = "0x1F85AB4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern void SetAsFirstSibling();

		// Token: 0x06000499 RID: 1177
		[global::Cpp2ILInjected.Token(Token = "0x60004B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85AF0", Offset = "0x1F85AF0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.SingletonMonoBehavior`1.<>c", Member = "<FindInstances>b__12_0", MemberParameters = new object[] { "TComponent", "TComponent" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern int GetSiblingIndex();

		// Token: 0x0600049A RID: 1178
		[FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60004B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85B2C", Offset = "0x1F85B2C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern bool IsChildOf([NotNull("ArgumentNullException")] Transform parent);

		// Token: 0x0600049B RID: 1179 RVA: 0x00002A4F File Offset: 0x00000C4F
		[global::Cpp2ILInjected.Token(Token = "0x60004B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85B70", Offset = "0x1F85B70", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x0600049C RID: 1180
		[NativeThrows]
		[FreeFunction("GetChild", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60004B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85C04", Offset = "0x1F85C04", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "SerialiseAtPath", MemberParameters = new object[]
		{
			typeof(BinaryWriter),
			typeof(Transform)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "FindAllInChildren", MemberParameters = new object[]
		{
			typeof(Transform),
			typeof(string),
			"System.Collections.Generic.List`1<Transform>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "GetChildByName", MemberParameters = new object[]
		{
			typeof(Transform),
			typeof(string)
		}, ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "FindInChildren", MemberParameters = new object[]
		{
			typeof(Transform),
			typeof(string)
		}, ReturnType = typeof(Transform))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "FindInObjectOrChildren", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(Transform) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "FindInChildren", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(Transform) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "SetLayer", MemberParameters = new object[]
		{
			typeof(Transform),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "SetLayerRecursively", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "OnSelectItem", MemberParameters = new object[] { "UnityEngine.UI.Toggle" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = "PerformLayoutControl", MemberParameters = new object[]
		{
			typeof(RectTransform),
			"UnityEngine.Events.UnityAction`1<Component>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutRebuilder", Member = "PerformLayoutCalculation", MemberParameters = new object[]
		{
			typeof(RectTransform),
			"UnityEngine.Events.UnityAction`1<Component>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutOnAxis", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "FlipLayoutAxes", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern Transform GetChild(int index);

		// Token: 0x0600049D RID: 1181
		[global::Cpp2ILInjected.Token(Token = "0x60004B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F84DB0", Offset = "0x1F84DB0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_position_Injected(out Vector3 ret);

		// Token: 0x0600049E RID: 1182
		[global::Cpp2ILInjected.Token(Token = "0x60004B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F84E48", Offset = "0x1F84E48", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void set_position_Injected(ref Vector3 value);

		// Token: 0x0600049F RID: 1183
		[global::Cpp2ILInjected.Token(Token = "0x60004B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F84EE8", Offset = "0x1F84EE8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_localPosition_Injected(out Vector3 ret);

		// Token: 0x060004A0 RID: 1184
		[global::Cpp2ILInjected.Token(Token = "0x60004B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F84F80", Offset = "0x1F84F80", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void set_localPosition_Injected(ref Vector3 value);

		// Token: 0x060004A1 RID: 1185
		[global::Cpp2ILInjected.Token(Token = "0x60004B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85094", Offset = "0x1F85094", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_rotation_Injected(out Quaternion ret);

		// Token: 0x060004A2 RID: 1186
		[global::Cpp2ILInjected.Token(Token = "0x60004BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85130", Offset = "0x1F85130", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_localRotation_Injected(out Quaternion ret);

		// Token: 0x060004A3 RID: 1187
		[global::Cpp2ILInjected.Token(Token = "0x60004BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F851C8", Offset = "0x1F851C8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void set_localRotation_Injected(ref Quaternion value);

		// Token: 0x060004A4 RID: 1188
		[global::Cpp2ILInjected.Token(Token = "0x60004BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85268", Offset = "0x1F85268", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_localScale_Injected(out Vector3 ret);

		// Token: 0x060004A5 RID: 1189
		[global::Cpp2ILInjected.Token(Token = "0x60004BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85300", Offset = "0x1F85300", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void set_localScale_Injected(ref Vector3 value);

		// Token: 0x060004A6 RID: 1190
		[global::Cpp2ILInjected.Token(Token = "0x60004BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85614", Offset = "0x1F85614", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_worldToLocalMatrix_Injected(out Matrix4x4 ret);

		// Token: 0x060004A7 RID: 1191
		[global::Cpp2ILInjected.Token(Token = "0x60004BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F856C4", Offset = "0x1F856C4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void get_localToWorldMatrix_Injected(out Matrix4x4 ret);

		// Token: 0x060004A8 RID: 1192
		[global::Cpp2ILInjected.Token(Token = "0x60004C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8576C", Offset = "0x1F8576C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void RotateAroundInternal_Injected(ref Vector3 axis, float angle);

		// Token: 0x060004A9 RID: 1193
		[global::Cpp2ILInjected.Token(Token = "0x60004C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F858AC", Offset = "0x1F858AC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void TransformDirection_Injected(ref Vector3 direction, out Vector3 ret);

		// Token: 0x060004AA RID: 1194
		[global::Cpp2ILInjected.Token(Token = "0x60004C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85968", Offset = "0x1F85968", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void TransformPoint_Injected(ref Vector3 position, out Vector3 ret);

		// Token: 0x060004AB RID: 1195
		[global::Cpp2ILInjected.Token(Token = "0x60004C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F85A24", Offset = "0x1F85A24", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void InverseTransformPoint_Injected(ref Vector3 position, out Vector3 ret);

		// Token: 0x02000174 RID: 372
		[global::Cpp2ILInjected.Token(Token = "0x20000E1")]
		private class Enumerator : IEnumerator
		{
			// Token: 0x060006CC RID: 1740 RVA: 0x00002FA4 File Offset: 0x000011A4
			[global::Cpp2ILInjected.Token(Token = "0x60004C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F85BD4", Offset = "0x1F85BD4", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal Enumerator(Transform outer)
			{
				throw null;
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x060006CD RID: 1741 RVA: 0x00002FA7 File Offset: 0x000011A7
			[global::Cpp2ILInjected.Token(Token = "0x170000F7")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x60004C5")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F85C48", Offset = "0x1F85C48", Length = "0x44")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x060006CE RID: 1742 RVA: 0x00002FAA File Offset: 0x000011AA
			[global::Cpp2ILInjected.Token(Token = "0x60004C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F85C8C", Offset = "0x1F85C8C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x060006CF RID: 1743 RVA: 0x00002FAD File Offset: 0x000011AD
			[global::Cpp2ILInjected.Token(Token = "0x60004C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F85CE4", Offset = "0x1F85CE4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x04000668 RID: 1640
			[global::Cpp2ILInjected.Token(Token = "0x40003DC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private Transform outer;

			// Token: 0x04000669 RID: 1641
			[global::Cpp2ILInjected.Token(Token = "0x40003DD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int currentIndex;
		}
	}
}
