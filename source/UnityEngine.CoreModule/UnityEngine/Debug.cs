using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000035 RID: 53
	[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000038")]
	public class Debug
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002113 File Offset: 0x00000313
		[global::Cpp2ILInjected.Token(Token = "0x1700000D")]
		public static ILogger unityLogger
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000062")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6B1E0", Offset = "0x1F6B1E0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600005B RID: 91
		[ThreadSafe]
		[global::Cpp2ILInjected.Token(Token = "0x6000063")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6B238", Offset = "0x1F6B238", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public unsafe static extern int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder);

		// Token: 0x0600005C RID: 92 RVA: 0x00002116 File Offset: 0x00000316
		[global::Cpp2ILInjected.Token(Token = "0x6000064")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6B28C", Offset = "0x1F6B28C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 119)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void Log(object message)
		{
			throw null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002119 File Offset: 0x00000319
		[global::Cpp2ILInjected.Token(Token = "0x6000065")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6B38C", Offset = "0x1F6B38C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 121)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void LogError(object message)
		{
			throw null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000211C File Offset: 0x0000031C
		[global::Cpp2ILInjected.Token(Token = "0x6000066")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6B48C", Offset = "0x1F6B48C", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "CheckCanAccessSubmesh", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(FormatUsage)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "IsRaycastLocationValid", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Camera)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void LogError(object message, Object context)
		{
			throw null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000211F File Offset: 0x0000031F
		[global::Cpp2ILInjected.Token(Token = "0x6000067")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6B59C", Offset = "0x1F6B59C", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.TextGenerator", Member = "PopulateWithErrors", MemberParameters = new object[]
		{
			typeof(string),
			"UnityEngine.TextGenerationSettings",
			typeof(GameObject)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void LogErrorFormat(Object context, string format, params object[] args)
		{
			throw null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002122 File Offset: 0x00000322
		[global::Cpp2ILInjected.Token(Token = "0x6000068")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6B6B0", Offset = "0x1F6B6B0", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UnhandledExceptionHandler.<>c", Member = "<RegisterUECatcher>b__0_0", MemberParameters = new object[]
		{
			typeof(object),
			typeof(UnhandledExceptionEventArgs)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Application), Member = "Internal_ApplicationWantsToQuit", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineAsset), Member = "InternalCreatePipeline", ReturnType = typeof(RenderPipeline))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.ExecuteEvents", Member = "Execute", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			"UnityEngine.EventSystems.BaseEventData",
			"EventFunction`1<T>"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void LogException(Exception exception)
		{
			throw null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002125 File Offset: 0x00000325
		[global::Cpp2ILInjected.Token(Token = "0x6000069")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6B7B0", Offset = "0x1F6B7B0", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteRenderer), Member = "InvokeSpriteChanged", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CanvasUpdateRegistry", Member = "PerformUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void LogException(Exception exception, Object context)
		{
			throw null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002128 File Offset: 0x00000328
		[global::Cpp2ILInjected.Token(Token = "0x600006A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6B8BC", Offset = "0x1F6B8BC", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 43)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void LogWarning(object message)
		{
			throw null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000212B File Offset: 0x0000032B
		[global::Cpp2ILInjected.Token(Token = "0x600006B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6B9BC", Offset = "0x1F6B9BC", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[]
		{
			typeof(GraphicsFormat),
			typeof(FormatUsage)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Transform), Member = "set_parent", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Mask", Member = "GetModifiedMaterial", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "LogWarningWhenNotInBatchmode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void LogWarning(object message, Object context)
		{
			throw null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000212E File Offset: 0x0000032E
		[global::Cpp2ILInjected.Token(Token = "0x600006C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6BACC", Offset = "0x1F6BACC", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.TextGenerator", Member = "ValidatedSettings", MemberParameters = new object[] { "UnityEngine.TextGenerationSettings" }, ReturnType = "UnityEngine.TextGenerationSettings")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void LogWarningFormat(Object context, string format, params object[] args)
		{
			throw null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002131 File Offset: 0x00000331
		[Conditional("UNITY_ASSERTIONS")]
		[global::Cpp2ILInjected.Token(Token = "0x600006D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6BBE0", Offset = "0x1F6BBE0", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void Assert(bool condition)
		{
			throw null;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002134 File Offset: 0x00000334
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600006E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6BD08", Offset = "0x1F6BD08", Length = "0x3E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		internal static bool CallOverridenDebugHandler(Exception exception, Object obj)
		{
			throw null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002137 File Offset: 0x00000337
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x600006F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6C0EC", Offset = "0x1F6C0EC", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static bool IsLoggingEnabled()
		{
			throw null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000213A File Offset: 0x0000033A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000070")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6C300", Offset = "0x1F6C300", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static Debug()
		{
			throw null;
		}

		// Token: 0x040000B9 RID: 185
		[global::Cpp2ILInjected.Token(Token = "0x40000BD")]
		internal static readonly ILogger s_DefaultLogger;

		// Token: 0x040000BA RID: 186
		[global::Cpp2ILInjected.Token(Token = "0x40000BE")]
		internal static ILogger s_Logger;
	}
}
