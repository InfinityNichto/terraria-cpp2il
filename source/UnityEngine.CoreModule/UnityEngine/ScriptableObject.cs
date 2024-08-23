using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200009C RID: 156
	[NativeClass(null)]
	[RequiredByNativeCode]
	[ExtensionOfNativeClass]
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000AB")]
	[StructLayout(0)]
	public class ScriptableObject : Object
	{
		// Token: 0x06000301 RID: 769 RVA: 0x00002641 File Offset: 0x00000841
		[global::Cpp2ILInjected.Token(Token = "0x6000310")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7BD8C", Offset = "0x1F7BD8C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Singleton`1", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.NativeInputDeviceProfileList", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityInputDeviceProfileList", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RenderPipelineAsset), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayableAsset), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUISkin", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.StateMachineBehaviour", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ScriptableObject()
		{
			throw null;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002644 File Offset: 0x00000844
		[global::Cpp2ILInjected.Token(Token = "0x6000311")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7BE48", Offset = "0x1F7BE48", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ScriptableObject CreateInstance(Type type)
		{
			throw null;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002647 File Offset: 0x00000847
		[global::Cpp2ILInjected.Token(Token = "0x6000312")]
		[global::Cpp2ILInjected.Address(RVA = "0x159B188", Offset = "0x159B188", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "CreateInstance", ReturnType = typeof(PlayerConnection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(ScriptableObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static T CreateInstance<T>() where T : ScriptableObject
		{
			throw null;
		}

		// Token: 0x06000304 RID: 772
		[NativeMethod(IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x6000313")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7BE0C", Offset = "0x1F7BE0C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void CreateScriptableObject([Writable] ScriptableObject self);

		// Token: 0x06000305 RID: 773
		[FreeFunction("Scripting::CreateScriptableObjectWithType")]
		[global::Cpp2ILInjected.Token(Token = "0x6000314")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7BE88", Offset = "0x1F7BE88", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset);
	}
}
