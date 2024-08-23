using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x020000C3 RID: 195
	[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
	[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000D5")]
	internal static class ResourcesAPIInternal
	{
		// Token: 0x06000445 RID: 1093
		[FreeFunction("GetShaderNameRegistry().FindShader")]
		[global::Cpp2ILInjected.Token(Token = "0x6000459")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83AD0", Offset = "0x1F83AD0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern Shader FindShaderByName(string name);

		// Token: 0x06000446 RID: 1094
		[NativeThrows]
		[FreeFunction("Resources_Bindings::Load")]
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedBySecondArgument)]
		[global::Cpp2ILInjected.Token(Token = "0x600045A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83B0C", Offset = "0x1F83B0C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern Object Load(string path, [NotNull("ArgumentNullException")] Type systemTypeInstance);

		// Token: 0x06000447 RID: 1095
		[FreeFunction("Resources_Bindings::LoadAll")]
		[NativeThrows]
		[global::Cpp2ILInjected.Token(Token = "0x600045B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83B50", Offset = "0x1F83B50", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern Object[] LoadAll([NotNull("ArgumentNullException")] string path, [NotNull("ArgumentNullException")] Type systemTypeInstance);

		// Token: 0x06000448 RID: 1096
		[FreeFunction("Resources_Bindings::LoadAsyncInternal")]
		[global::Cpp2ILInjected.Token(Token = "0x600045C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83B94", Offset = "0x1F83B94", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern ResourceRequest LoadAsyncInternal(string path, Type type);

		// Token: 0x06000449 RID: 1097
		[FreeFunction("Scripting::UnloadAssetFromScripting")]
		[global::Cpp2ILInjected.Token(Token = "0x600045D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F83BD8", Offset = "0x1F83BD8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void UnloadAsset(Object assetToUnload);
	}
}
