using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x0200006E RID: 110
	[NativeHeader("Runtime/Misc/SystemInfo.h")]
	[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
	[NativeHeader("Runtime/Input/GetInput.h")]
	[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000074")]
	public sealed class SystemInfo
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001BF RID: 447 RVA: 0x000023E0 File Offset: 0x000005E0
		[global::Cpp2ILInjected.Token(Token = "0x1700005C")]
		public static string operatingSystem
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7562C", Offset = "0x1F7562C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "GetPlatformName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x000023E3 File Offset: 0x000005E3
		[global::Cpp2ILInjected.Token(Token = "0x1700005D")]
		public static OperatingSystemFamily operatingSystemFamily
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7567C", Offset = "0x1F7567C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "KeyPressed", MemberParameters = new object[] { "UnityEngine.Event" }, ReturnType = "UnityEngine.UI.InputField.EditState")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x000023E6 File Offset: 0x000005E6
		[global::Cpp2ILInjected.Token(Token = "0x1700005E")]
		public static int systemMemorySize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F756CC", Offset = "0x1F756CC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUILowMemoryPopup", Member = "CheckMemoryAction", MemberParameters = new object[]
			{
				"GUILowMemoryPopup.MemoryAction",
				typeof(Action)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUILowMemoryPopup", Member = "get_DeviceMemory", ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUILowMemorySetttings", Member = "CheckMemorySettings", MemberParameters = new object[] { typeof(Action) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x000023E9 File Offset: 0x000005E9
		[global::Cpp2ILInjected.Token(Token = "0x1700005F")]
		public static string deviceModel
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7571C", Offset = "0x1F7571C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrPlatform", Member = "Setup", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DrPlatform", Member = "Start", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "GetPlatformName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "Awake", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000023EC File Offset: 0x000005EC
		[global::Cpp2ILInjected.Token(Token = "0x60001CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7576C", Offset = "0x1F7576C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SystemInfo), Member = "SupportsTextureFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static bool IsValidEnumValue(Enum value)
		{
			throw null;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000023EF File Offset: 0x000005EF
		[global::Cpp2ILInjected.Token(Token = "0x60001CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6F74C", Offset = "0x1F6F74C", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMap", Member = "InitialiseTargets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TextureAtlasDB", Member = "get_DefaultTexturesHigh", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture), Member = "ValidateFormat", MemberParameters = new object[] { typeof(TextureFormat) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SystemInfo), Member = "IsValidEnumValue", MemberParameters = new object[] { typeof(Enum) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static bool SupportsTextureFormat(TextureFormat format)
		{
			throw null;
		}

		// Token: 0x060001C5 RID: 453
		[FreeFunction("systeminfo::GetOperatingSystem")]
		[global::Cpp2ILInjected.Token(Token = "0x60001CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75654", Offset = "0x1F75654", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern string GetOperatingSystem();

		// Token: 0x060001C6 RID: 454
		[FreeFunction("systeminfo::GetOperatingSystemFamily")]
		[global::Cpp2ILInjected.Token(Token = "0x60001D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F756A4", Offset = "0x1F756A4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern OperatingSystemFamily GetOperatingSystemFamily();

		// Token: 0x060001C7 RID: 455
		[FreeFunction("systeminfo::GetPhysicalMemoryMB")]
		[global::Cpp2ILInjected.Token(Token = "0x60001D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F756F4", Offset = "0x1F756F4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern int GetPhysicalMemoryMB();

		// Token: 0x060001C8 RID: 456
		[FreeFunction("systeminfo::GetDeviceModel")]
		[global::Cpp2ILInjected.Token(Token = "0x60001D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75744", Offset = "0x1F75744", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern string GetDeviceModel();

		// Token: 0x060001C9 RID: 457
		[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
		[global::Cpp2ILInjected.Token(Token = "0x60001D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F757DC", Offset = "0x1F757DC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern bool SupportsTextureFormatNative(TextureFormat format);

		// Token: 0x060001CA RID: 458
		[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
		[global::Cpp2ILInjected.Token(Token = "0x60001D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6F9EC", Offset = "0x1F6F9EC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(GraphicsFormat))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern bool IsFormatSupported(GraphicsFormat format, FormatUsage usage);

		// Token: 0x060001CB RID: 459
		[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat", ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60001D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F73790", Offset = "0x1F73790", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage);

		// Token: 0x060001CC RID: 460
		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
		[global::Cpp2ILInjected.Token(Token = "0x60001D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F70948", Offset = "0x1F70948", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern GraphicsFormat GetGraphicsFormat(DefaultFormat format);
	}
}
