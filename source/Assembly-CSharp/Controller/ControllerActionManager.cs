using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl;
using Terraria.IO;

namespace Controller
{
	// Token: 0x02000758 RID: 1880
	[global::Cpp2ILInjected.Token(Token = "0x2000B5F")]
	public class ControllerActionManager
	{
		// Token: 0x060047C1 RID: 18369 RVA: 0x0002ECDC File Offset: 0x0002CEDC
		[global::Cpp2ILInjected.Token(Token = "0x6005487")]
		[global::Cpp2ILInjected.Address(RVA = "0x94BDA4", Offset = "0x94BDA4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(PlatformUser)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ControllerActionManager Create()
		{
			throw null;
		}

		// Token: 0x060047C2 RID: 18370 RVA: 0x0002ECDF File Offset: 0x0002CEDF
		[global::Cpp2ILInjected.Token(Token = "0x6005488")]
		[global::Cpp2ILInjected.Address(RVA = "0x94BF4C", Offset = "0x94BF4C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "DisableConflictingActions", MemberParameters = new object[] { typeof(GUIControllerMappingState) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "ClearLinkedAxisBindings", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Axis),
			typeof(Axis),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingStateTable), Member = "ClearLinkedButtonBindings", MemberParameters = new object[]
		{
			typeof(int),
			typeof(AxisButtons),
			typeof(List<ControllerActionButton>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "MapAxisButton", MemberParameters = new object[]
		{
			typeof(AxisButtons),
			typeof(ControllerActionButton.RequiredButtonState),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		public static Axis GetAxisThreshold(AxisButtons button, out float threshold)
		{
			throw null;
		}

		// Token: 0x060047C3 RID: 18371 RVA: 0x0002ECE2 File Offset: 0x0002CEE2
		[global::Cpp2ILInjected.Token(Token = "0x6005489")]
		[global::Cpp2ILInjected.Address(RVA = "0x94BE00", Offset = "0x94BE00", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionManager), Member = "Create", ReturnType = typeof(ControllerActionManager))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SingletonMonoBehavior<>), Member = "get_Instance", ReturnType = "TComponent")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public ControllerActionManager()
		{
			throw null;
		}

		// Token: 0x060047C4 RID: 18372 RVA: 0x0002ECE5 File Offset: 0x0002CEE5
		[global::Cpp2ILInjected.Token(Token = "0x600548A")]
		[global::Cpp2ILInjected.Address(RVA = "0x94BF80", Offset = "0x94BF80", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetupMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "SetupMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "CreateButtonMapping", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ControllerActionButton))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 106)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionButton), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsBanner_Layout), Member = "GetMappingPriority", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ControllerActionButton CreateButtonMapping(string id)
		{
			throw null;
		}

		// Token: 0x060047C5 RID: 18373 RVA: 0x0002ECE8 File Offset: 0x0002CEE8
		[global::Cpp2ILInjected.Token(Token = "0x600548B")]
		[global::Cpp2ILInjected.Address(RVA = "0x94C088", Offset = "0x94C088", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetupMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "SetupMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "SetupMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 24)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionAxis), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ControllerActionAxis CreateAxisMapping(string id, bool timeBased, float axisScale)
		{
			throw null;
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x0002ECEB File Offset: 0x0002CEEB
		[global::Cpp2ILInjected.Token(Token = "0x600548C")]
		[global::Cpp2ILInjected.Address(RVA = "0x94C178", Offset = "0x94C178", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SetupMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerNavigationController), Member = "SetupMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "SetupMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerActionVector), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControlsBanner_Layout), Member = "GetMappingPriority", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ControllerActionVector CreateVectorMapping(string id, ControllerActionAxis axisX, ControllerActionAxis axisY)
		{
			throw null;
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x0002ECEE File Offset: 0x0002CEEE
		[global::Cpp2ILInjected.Token(Token = "0x600548D")]
		[global::Cpp2ILInjected.Address(RVA = "0x94C294", Offset = "0x94C294", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "LoadConfiguration", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Preferences),
			typeof(ref bool),
			typeof(List<ControllerActionButton>),
			typeof(List<ControllerActionAxis>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ControllerActionAxis GetAxisMapping(string id)
		{
			throw null;
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x0002ECF1 File Offset: 0x0002CEF1
		[global::Cpp2ILInjected.Token(Token = "0x600548E")]
		[global::Cpp2ILInjected.Address(RVA = "0x94C354", Offset = "0x94C354", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingState), Member = "LoadConfiguration", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Preferences),
			typeof(ref bool),
			typeof(List<ControllerActionButton>),
			typeof(List<ControllerActionAxis>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "CreateButtonMapping", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ControllerActionButton))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ControllerActionButton GetButtonMapping(string id)
		{
			throw null;
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x0002ECF4 File Offset: 0x0002CEF4
		[global::Cpp2ILInjected.Token(Token = "0x600548F")]
		[global::Cpp2ILInjected.Address(RVA = "0x94C414", Offset = "0x94C414", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIKeyboardMappings), Member = "SetupMappings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ControllerActionVector GetVectorMapping(string id)
		{
			throw null;
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x060047CA RID: 18378 RVA: 0x0002ECF7 File Offset: 0x0002CEF7
		[global::Cpp2ILInjected.Token(Token = "0x17000938")]
		public bool HasController
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005490")]
			[global::Cpp2ILInjected.Address(RVA = "0x94C4D4", Offset = "0x94C4D4", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060047CB RID: 18379 RVA: 0x0002ECFA File Offset: 0x0002CEFA
		[global::Cpp2ILInjected.Token(Token = "0x17000939")]
		public bool IsControllerActive
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005491")]
			[global::Cpp2ILInjected.Address(RVA = "0x94C574", Offset = "0x94C574", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060047CC RID: 18380 RVA: 0x0002ECFD File Offset: 0x0002CEFD
		[global::Cpp2ILInjected.Token(Token = "0x6005492")]
		[global::Cpp2ILInjected.Address(RVA = "0x94C57C", Offset = "0x94C57C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = "LoadState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void ForceActiveController(ControllerDevice controller)
		{
			throw null;
		}

		// Token: 0x060047CD RID: 18381 RVA: 0x0002ED00 File Offset: 0x0002CF00
		[global::Cpp2ILInjected.Token(Token = "0x6005493")]
		[global::Cpp2ILInjected.Address(RVA = "0x94C588", Offset = "0x94C588", Length = "0x400")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "ExecuteFrame", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UserManagement), Member = "CanControllerBeUsedForPlayer", MemberParameters = new object[]
		{
			typeof(ControllerDevice),
			typeof(LocalUser)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public void OnUpdate(float elapsedTime)
		{
			throw null;
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060047CE RID: 18382 RVA: 0x0002ED03 File Offset: 0x0002CF03
		[global::Cpp2ILInjected.Token(Token = "0x1700093A")]
		public ControllerDevice ActiveController
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005494")]
			[global::Cpp2ILInjected.Address(RVA = "0x94C988", Offset = "0x94C988", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 77)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060047CF RID: 18383 RVA: 0x0002ED06 File Offset: 0x0002CF06
		[global::Cpp2ILInjected.Token(Token = "0x1700093B")]
		public static bool AnyControllerConnected
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005495")]
			[global::Cpp2ILInjected.Address(RVA = "0x94C9EC", Offset = "0x94C9EC", Length = "0x1BC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 170)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040073BE RID: 29630
		[global::Cpp2ILInjected.Token(Token = "0x4008D7D")]
		public static ControllerActionManager Instance;

		// Token: 0x040073BF RID: 29631
		[global::Cpp2ILInjected.Token(Token = "0x4008D7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<ControllerActionAxis> _axisMappings;

		// Token: 0x040073C0 RID: 29632
		[global::Cpp2ILInjected.Token(Token = "0x4008D7F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<ControllerActionButton> _buttonMappings;

		// Token: 0x040073C1 RID: 29633
		[global::Cpp2ILInjected.Token(Token = "0x4008D80")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<ControllerActionVector> _vectorMappings;

		// Token: 0x040073C2 RID: 29634
		[global::Cpp2ILInjected.Token(Token = "0x4008D81")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ControllerDevice _controller;

		// Token: 0x040073C3 RID: 29635
		[global::Cpp2ILInjected.Token(Token = "0x4008D82")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _controllerActive;

		// Token: 0x040073C4 RID: 29636
		[global::Cpp2ILInjected.Token(Token = "0x4008D83")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ControllerDevice _forcedActiveController;

		// Token: 0x040073C5 RID: 29637
		[global::Cpp2ILInjected.Token(Token = "0x4008D84")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool _pendingDisableActions;

		// Token: 0x040073C6 RID: 29638
		[global::Cpp2ILInjected.Token(Token = "0x4008D85")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string[] _pendingDisableActionsList;

		// Token: 0x040073C7 RID: 29639
		[global::Cpp2ILInjected.Token(Token = "0x4008D86")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool _pendingEnableActions;
	}
}
