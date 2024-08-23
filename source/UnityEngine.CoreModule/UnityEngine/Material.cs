using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200005A RID: 90
	[NativeHeader("Runtime/Shaders/Material.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200005E")]
	public class Material : Object
	{
		// Token: 0x0600018E RID: 398
		[FreeFunction("MaterialScripting::CreateWithShader")]
		[global::Cpp2ILInjected.Token(Token = "0x6000196")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74064", Offset = "0x1F74064", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void CreateWithShader([Writable] Material self, [NotNull("ArgumentNullException")] Shader shader);

		// Token: 0x0600018F RID: 399
		[FreeFunction("MaterialScripting::CreateWithMaterial")]
		[global::Cpp2ILInjected.Token(Token = "0x6000197")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F740A8", Offset = "0x1F740A8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void CreateWithMaterial([Writable] Material self, [NotNull("ArgumentNullException")] Material source);

		// Token: 0x06000190 RID: 400
		[FreeFunction("MaterialScripting::CreateWithString")]
		[global::Cpp2ILInjected.Token(Token = "0x6000198")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F740EC", Offset = "0x1F740EC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void CreateWithString([Writable] Material self);

		// Token: 0x06000191 RID: 401 RVA: 0x00002380 File Offset: 0x00000580
		[global::Cpp2ILInjected.Token(Token = "0x6000199")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74128", Offset = "0x1F74128", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PixelShader", Member = "LoadPass", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<EffectPass>",
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.ScreenShader", Member = "LoadPass", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<EffectPass>",
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.TileShader", Member = "LoadPass", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<EffectPass>",
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.MaterialBuffer.MaterialEntry", Member = ".ctor", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.MaterialBuffer.MaterialPartition", "System.Collections.Generic.List`1<MaterialEntry>", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.Texture2D" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "CreateSpriteRenderer", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(Sprite),
			typeof(int)
		}, ReturnType = typeof(SpriteRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Material(Shader shader)
		{
			throw null;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002383 File Offset: 0x00000583
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600019A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F741B8", Offset = "0x1F741B8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MaterialExtensions", Member = "CloneMaterial", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.EffectPass", Member = ".ctor", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.Effect", "Microsoft.Xna.Framework.Graphics.EffectPass" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.EffectPass", Member = ".ctor", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.EffectPass", "Terraria.Graphics.Shaders.ShaderData" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "Add", MemberParameters = new object[]
		{
			typeof(Material),
			typeof(int),
			typeof(StencilOp),
			typeof(CompareFunction),
			typeof(ColorWriteMask),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Material(Material source)
		{
			throw null;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002386 File Offset: 0x00000586
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", false)]
		[global::Cpp2ILInjected.Token(Token = "0x600019B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74248", Offset = "0x1F74248", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public Material(string contents)
		{
			throw null;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000194 RID: 404
		[global::Cpp2ILInjected.Token(Token = "0x17000053")]
		public extern Shader shader
		{
			[global::Cpp2ILInjected.Token(Token = "0x600019C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F742C8", Offset = "0x1F742C8", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.MaterialBuffer.MaterialEntry", Member = ".ctor", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.MaterialBuffer.MaterialPartition", "System.Collections.Generic.List`1<MaterialEntry>", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.Texture2D" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00002389 File Offset: 0x00000589
		// (set) Token: 0x06000196 RID: 406 RVA: 0x0000238C File Offset: 0x0000058C
		[global::Cpp2ILInjected.Token(Token = "0x17000054")]
		public Color color
		{
			[global::Cpp2ILInjected.Token(Token = "0x600019D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F74304", Offset = "0x1F74304", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceMovement.Button", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "GetColorImpl", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "GetColor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600019E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F74424", Offset = "0x1F74424", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualDeviceExample.VirtualDeviceExample", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TouchExample.CubeController", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.Player", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerBasicExample.Player", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceMovement.Button", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BasicExample.BasicExample", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetColorImpl", MemberParameters = new object[]
			{
				typeof(int),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000238F File Offset: 0x0000058F
		[global::Cpp2ILInjected.Token(Token = "0x17000055")]
		public Texture mainTexture
		{
			[global::Cpp2ILInjected.Token(Token = "0x600019F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F74578", Offset = "0x1F74578", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "get_mainTexture", ReturnType = typeof(Texture))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RawImage", Member = "get_mainTexture", ReturnType = typeof(Texture))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Text", Member = "get_mainTexture", ReturnType = typeof(Texture))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "GetTexture", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Texture))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000198 RID: 408
		[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
		[global::Cpp2ILInjected.Token(Token = "0x60001A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74390", Offset = "0x1F74390", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag);

		// Token: 0x06000199 RID: 409
		[NativeName("HasPropertyFromScript")]
		[global::Cpp2ILInjected.Token(Token = "0x60001A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F746DC", Offset = "0x1F746DC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.MaterialBuffer.MaterialPartition", Member = ".ctor", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern bool HasProperty(int nameID);

		// Token: 0x0600019A RID: 410 RVA: 0x00002392 File Offset: 0x00000592
		[global::Cpp2ILInjected.Token(Token = "0x60001A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74720", Offset = "0x1F74720", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "Add", MemberParameters = new object[]
		{
			typeof(Material),
			typeof(int),
			typeof(StencilOp),
			typeof(CompareFunction),
			typeof(ColorWriteMask),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool HasProperty(string name)
		{
			throw null;
		}

		// Token: 0x17000054 RID: 84
		// (set) Token: 0x0600019B RID: 411
		[global::Cpp2ILInjected.Token(Token = "0x17000056")]
		public extern int renderQueue
		{
			[NativeName("SetCustomRenderQueue")]
			[global::Cpp2ILInjected.Token(Token = "0x60001A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F74790", Offset = "0x1F74790", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBuffer", Member = "RenderAndFlush", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "GetMaterial", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Material))]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x0600019C RID: 412
		[global::Cpp2ILInjected.Token(Token = "0x60001A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F747D4", Offset = "0x1F747D4", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.MaterialBuffer.MaterialEntry", Member = ".ctor", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.MaterialBuffer.MaterialPartition", "System.Collections.Generic.List`1<MaterialEntry>", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.Texture2D" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.MaterialBuffer.MaterialEntry", Member = "SetupTrimming", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "Add", MemberParameters = new object[]
		{
			typeof(Material),
			typeof(int),
			typeof(StencilOp),
			typeof(CompareFunction),
			typeof(ColorWriteMask),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern void EnableKeyword(string keyword);

		// Token: 0x0600019D RID: 413
		[global::Cpp2ILInjected.Token(Token = "0x60001A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74818", Offset = "0x1F74818", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.MaterialBuffer.MaterialEntry", Member = "ClearTrimming", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "Add", MemberParameters = new object[]
		{
			typeof(Material),
			typeof(int),
			typeof(StencilOp),
			typeof(CompareFunction),
			typeof(ColorWriteMask),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern void DisableKeyword(string keyword);

		// Token: 0x0600019E RID: 414
		[NativeName("SetFloatFromScript")]
		[global::Cpp2ILInjected.Token(Token = "0x60001A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7485C", Offset = "0x1F7485C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void SetFloatImpl(int name, float value);

		// Token: 0x0600019F RID: 415 RVA: 0x00002395 File Offset: 0x00000595
		[NativeName("SetColorFromScript")]
		[global::Cpp2ILInjected.Token(Token = "0x60001A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F748B0", Offset = "0x1F748B0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Material), Member = "set_color", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Material), Member = "SetColor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Material), Member = "SetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Material), Member = "SetVector", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void SetColorImpl(int name, Color value)
		{
			throw null;
		}

		// Token: 0x060001A0 RID: 416
		[NativeName("SetTextureFromScript")]
		[global::Cpp2ILInjected.Token(Token = "0x60001A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74960", Offset = "0x1F74960", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void SetTextureImpl(int name, Texture value);

		// Token: 0x060001A1 RID: 417 RVA: 0x00002398 File Offset: 0x00000598
		[NativeName("GetColorFromScript")]
		[global::Cpp2ILInjected.Token(Token = "0x60001A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F749B4", Offset = "0x1F749B4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Material), Member = "get_color", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Material), Member = "GetColor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Material), Member = "GetColor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private Color GetColorImpl(int name)
		{
			throw null;
		}

		// Token: 0x060001A2 RID: 418
		[NativeName("GetTextureFromScript")]
		[global::Cpp2ILInjected.Token(Token = "0x60001AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74A68", Offset = "0x1F74A68", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern Texture GetTextureImpl(int name);

		// Token: 0x060001A3 RID: 419 RVA: 0x0000239B File Offset: 0x0000059B
		[global::Cpp2ILInjected.Token(Token = "0x60001AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74AAC", Offset = "0x1F74AAC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "CreateSpriteRenderer", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(Sprite),
			typeof(int)
		}, ReturnType = typeof(SpriteRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "Add", MemberParameters = new object[]
		{
			typeof(Material),
			typeof(int),
			typeof(StencilOp),
			typeof(CompareFunction),
			typeof(ColorWriteMask),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SetFloat(string name, float value)
		{
			throw null;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000239E File Offset: 0x0000059E
		[global::Cpp2ILInjected.Token(Token = "0x60001AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74B2C", Offset = "0x1F74B2C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PixelShader", Member = "ApplyValuesToMaterial", MemberParameters = new object[]
		{
			"Microsoft.Xna.Framework.Graphics.EffectPass",
			typeof(Material)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.ScreenShader", Member = "ApplyValuesToMaterial", MemberParameters = new object[]
		{
			"Microsoft.Xna.Framework.Graphics.EffectPass",
			typeof(Material)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.TileShader", Member = "ApplyValuesToMaterial", MemberParameters = new object[]
		{
			"Microsoft.Xna.Framework.Graphics.EffectPass",
			typeof(Material)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.MaterialBuffer.MaterialEntry", Member = ".ctor", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.MaterialBuffer.MaterialPartition", "System.Collections.Generic.List`1<MaterialEntry>", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.Texture2D" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetFloat(int nameID, float value)
		{
			throw null;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000023A1 File Offset: 0x000005A1
		[global::Cpp2ILInjected.Token(Token = "0x60001AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F744FC", Offset = "0x1F744FC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Material), Member = "set_color", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetColorImpl", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetColor(string name, Color value)
		{
			throw null;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000023A4 File Offset: 0x000005A4
		[global::Cpp2ILInjected.Token(Token = "0x60001AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F744F8", Offset = "0x1F744F8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PixelShader", Member = "ApplyValuesToMaterial", MemberParameters = new object[]
		{
			"Microsoft.Xna.Framework.Graphics.EffectPass",
			typeof(Material)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.ScreenShader", Member = "ApplyValuesToMaterial", MemberParameters = new object[]
		{
			"Microsoft.Xna.Framework.Graphics.EffectPass",
			typeof(Material)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetColorImpl", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(void))]
		public void SetColor(int nameID, Color value)
		{
			throw null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000023A7 File Offset: 0x000005A7
		[global::Cpp2ILInjected.Token(Token = "0x60001AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74B80", Offset = "0x1F74B80", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ScreenPostProcessor", Member = "OnRenderImage", MemberParameters = new object[]
		{
			typeof(RenderTexture),
			typeof(RenderTexture)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PixelShader", Member = "ApplyValuesToMaterial", MemberParameters = new object[]
		{
			"Microsoft.Xna.Framework.Graphics.EffectPass",
			typeof(Material)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.ScreenShader", Member = "ApplyValuesToMaterial", MemberParameters = new object[]
		{
			"Microsoft.Xna.Framework.Graphics.EffectPass",
			typeof(Material)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.MaterialBuffer.MaterialEntry", Member = "SetupTrimming", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 41)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetColorImpl", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(void))]
		public void SetVector(int nameID, Vector4 value)
		{
			throw null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000023AA File Offset: 0x000005AA
		[global::Cpp2ILInjected.Token(Token = "0x60001B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74B84", Offset = "0x1F74B84", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ScreenPostProcessor", Member = "OnRenderImage", MemberParameters = new object[]
		{
			typeof(RenderTexture),
			typeof(RenderTexture)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.MaterialBuffer.MaterialEntry", Member = ".ctor", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.MaterialBuffer.MaterialPartition", "System.Collections.Generic.List`1<MaterialEntry>", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.Texture2D", "Microsoft.Xna.Framework.Graphics.Texture2D" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GraphicsDevice", Member = "GetMaterial", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetTexture(int nameID, Texture value)
		{
			throw null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000023AD File Offset: 0x000005AD
		[global::Cpp2ILInjected.Token(Token = "0x60001B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F743D8", Offset = "0x1F743D8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Material), Member = "get_color", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "GetColorImpl", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public Color GetColor(string name)
		{
			throw null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000023B0 File Offset: 0x000005B0
		[global::Cpp2ILInjected.Token(Token = "0x60001B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F743D4", Offset = "0x1F743D4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "GetColorImpl", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Color))]
		public Color GetColor(int nameID)
		{
			throw null;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000023B3 File Offset: 0x000005B3
		[global::Cpp2ILInjected.Token(Token = "0x60001B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7466C", Offset = "0x1F7466C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Texture GetTexture(string name)
		{
			throw null;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000023B6 File Offset: 0x000005B6
		[global::Cpp2ILInjected.Token(Token = "0x60001B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74628", Offset = "0x1F74628", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Texture GetTexture(int nameID)
		{
			throw null;
		}

		// Token: 0x060001AD RID: 429
		[global::Cpp2ILInjected.Token(Token = "0x60001B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7490C", Offset = "0x1F7490C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void SetColorImpl_Injected(int name, ref Color value);

		// Token: 0x060001AE RID: 430
		[global::Cpp2ILInjected.Token(Token = "0x60001B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74A14", Offset = "0x1F74A14", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void GetColorImpl_Injected(int name, out Color ret);
	}
}
