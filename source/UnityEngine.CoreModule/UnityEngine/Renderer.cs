using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000042 RID: 66
	[RequireComponent(typeof(Transform))]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/Renderer.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000045")]
	public class Renderer : Component
	{
		// Token: 0x06000098 RID: 152
		[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D1C0", Offset = "0x1F6D1C0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern Material GetMaterial();

		// Token: 0x06000099 RID: 153
		[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D1FC", Offset = "0x1F6D1FC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern Material GetSharedMaterial();

		// Token: 0x0600009A RID: 154
		[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D238", Offset = "0x1F6D238", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void SetMaterial(Material m);

		// Token: 0x0600009B RID: 155
		[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D27C", Offset = "0x1F6D27C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void SetMaterialArray([NotNull("ArgumentNullException")] Material[] m);

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009C RID: 156
		[global::Cpp2ILInjected.Token(Token = "0x17000021")]
		public extern int sortingLayerID
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6D2C0", Offset = "0x1F6D2C0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009D RID: 157
		// (set) Token: 0x0600009E RID: 158
		[global::Cpp2ILInjected.Token(Token = "0x17000022")]
		public extern int sortingOrder
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6D2FC", Offset = "0x1F6D2FC", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.Physics2DRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6D338", Offset = "0x1F6D338", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "CreateSpriteRenderer", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(Sprite),
				typeof(int)
			}, ReturnType = typeof(SpriteRenderer))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x17000021 RID: 33
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002185 File Offset: 0x00000385
		[global::Cpp2ILInjected.Token(Token = "0x17000023")]
		public Material[] materials
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6D37C", Offset = "0x1F6D37C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "DrawGeometryWithSubMeshes", MemberParameters = new object[]
			{
				"VertexData[]",
				"System.Int16[]",
				typeof(int),
				typeof(int),
				"Microsoft.Xna.Framework.Vector3",
				"Microsoft.Xna.Framework.Vector3",
				"System.Collections.Generic.List`1<Material>",
				"System.Collections.Generic.List`1<SubMeshDescriptor>"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002188 File Offset: 0x00000388
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000218B File Offset: 0x0000038B
		[global::Cpp2ILInjected.Token(Token = "0x17000024")]
		public Material material
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6D3C0", Offset = "0x1F6D3C0", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualDeviceExample.VirtualDeviceExample", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TouchExample.CubeController", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.Player", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerBasicExample.Player", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceMovement.Button", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BasicExample.BasicExample", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6D3FC", Offset = "0x1F6D3FC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBuffer", Member = "RenderAndFlush", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "DrawGeometry", MemberParameters = new object[]
			{
				"VertexData[]",
				"System.Int16[]",
				typeof(int),
				typeof(int),
				"Microsoft.Xna.Framework.Vector3",
				"Microsoft.Xna.Framework.Vector3"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "DrawGeometry", MemberParameters = new object[] { "System.Collections.Generic.List`1<Vector3>", "System.Collections.Generic.List`1<Vector2>", "System.Collections.Generic.List`1<Vector4>", "System.Collections.Generic.List`1<Color32>", "System.Collections.Generic.List`1<Int32>", "Microsoft.Xna.Framework.Vector3", "Microsoft.Xna.Framework.Vector3" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000218E File Offset: 0x0000038E
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002191 File Offset: 0x00000391
		[global::Cpp2ILInjected.Token(Token = "0x17000025")]
		public Material sharedMaterial
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6D440", Offset = "0x1F6D440", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "CreateSpriteRenderer", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(Sprite),
				typeof(int)
			}, ReturnType = typeof(SpriteRenderer))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6D47C", Offset = "0x1F6D47C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "CreateSpriteRenderer", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(Sprite),
				typeof(int)
			}, ReturnType = typeof(SpriteRenderer))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}
	}
}
