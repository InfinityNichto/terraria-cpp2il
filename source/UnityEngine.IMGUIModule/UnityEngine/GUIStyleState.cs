using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000017 RID: 23
	[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x200001B")]
	[Serializable]
	[StructLayout(0)]
	public sealed class GUIStyleState
	{
		// Token: 0x17000047 RID: 71
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000022B4 File Offset: 0x000004B4
		[NativeProperty("textColor", false, TargetType.Field)]
		[global::Cpp2ILInjected.Token(Token = "0x17000048")]
		public Color textColor
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F9D708", Offset = "0x1F9D708", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "SetColor", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "OnGUI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TestInputManager", Member = "DrawUnityInputDebugger", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISkin), Member = "BuildStyleCache", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060000EF RID: 239
		[FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0274", Offset = "0x1FA0274", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern IntPtr Init();

		// Token: 0x060000F0 RID: 240
		[FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = true, HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60000F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA029C", Offset = "0x1FA029C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void Cleanup();

		// Token: 0x060000F1 RID: 241 RVA: 0x000022B7 File Offset: 0x000004B7
		[global::Cpp2ILInjected.Token(Token = "0x60000F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA02D8", Offset = "0x1FA02D8", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public GUIStyleState()
		{
			throw null;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000022BA File Offset: 0x000004BA
		[global::Cpp2ILInjected.Token(Token = "0x60000F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0320", Offset = "0x1FA0320", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private GUIStyleState(GUIStyle sourceStyle, IntPtr source)
		{
			throw null;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000022BD File Offset: 0x000004BD
		[global::Cpp2ILInjected.Token(Token = "0x60000F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA034C", Offset = "0x1FA034C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIStyle), Member = "get_normal", ReturnType = typeof(GUIStyleState))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source)
		{
			throw null;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000022C0 File Offset: 0x000004C0
		[global::Cpp2ILInjected.Token(Token = "0x60000FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA03B4", Offset = "0x1FA03B4", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected override void Finalize()
		{
			throw null;
		}

		// Token: 0x060000F5 RID: 245
		[global::Cpp2ILInjected.Token(Token = "0x60000FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FA0230", Offset = "0x1FA0230", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern void set_textColor_Injected(ref Color value);

		// Token: 0x040000C1 RID: 193
		[global::Cpp2ILInjected.Token(Token = "0x40000C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x040000C2 RID: 194
		[global::Cpp2ILInjected.Token(Token = "0x40000C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly GUIStyle m_SourceStyle;
	}
}
