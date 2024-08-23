using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000059 RID: 89
	[NativeHeader("Runtime/Misc/ResourceManager.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
	[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/Shader.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200005D")]
	public sealed class Shader : Object
	{
		// Token: 0x0600018A RID: 394 RVA: 0x0000237A File Offset: 0x0000057A
		[global::Cpp2ILInjected.Token(Token = "0x6000192")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F73F30", Offset = "0x1F73F30", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "CreateSpriteRenderer", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(Sprite),
			typeof(int)
		}, ReturnType = typeof(SpriteRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourcesAPI), Member = "get_ActiveAPI", ReturnType = typeof(ResourcesAPI))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Shader Find(string name)
		{
			throw null;
		}

		// Token: 0x0600018B RID: 395
		[FreeFunction("ShaderScripting::TagToID")]
		[global::Cpp2ILInjected.Token(Token = "0x6000193")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F73F94", Offset = "0x1F73F94", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ShaderTagId), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScriptableRenderContext), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern int TagToID(string name);

		// Token: 0x0600018C RID: 396
		[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000194")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F73FD0", Offset = "0x1F73FD0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ScreenPostProcessor", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.PixelShader", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.ScreenShader", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.TileShader", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.MaterialBuffer", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 48)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern int PropertyToID(string name);

		// Token: 0x0600018D RID: 397 RVA: 0x0000237D File Offset: 0x0000057D
		[global::Cpp2ILInjected.Token(Token = "0x6000195")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7400C", Offset = "0x1F7400C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private Shader()
		{
			throw null;
		}
	}
}
