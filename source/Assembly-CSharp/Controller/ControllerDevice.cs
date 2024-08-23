using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.IO;
using UnityEngine;

namespace Controller
{
	// Token: 0x0200075A RID: 1882
	[global::Cpp2ILInjected.Token(Token = "0x2000B61")]
	public class ControllerDevice
	{
		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x060047D3 RID: 18387 RVA: 0x0002ED12 File Offset: 0x0002CF12
		// (set) Token: 0x060047D4 RID: 18388 RVA: 0x0002ED15 File Offset: 0x0002CF15
		[global::Cpp2ILInjected.Token(Token = "0x1700093C")]
		public static bool SwapBumpersTriggers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6005499")]
			[global::Cpp2ILInjected.Address(RVA = "0x94DFB0", Offset = "0x94DFB0", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "SaveConfiguration", MemberParameters = new object[] { typeof(Preferences) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerInputButton), Member = "GetShoulderButtonTexureInformation", MemberParameters = new object[]
			{
				typeof(GUIControllerInputButton.ShoulderButtonControl),
				typeof(ref Rectangle),
				typeof(int)
			}, ReturnType = typeof(Microsoft.Xna.Framework.Graphics.Texture2D))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "GetSelected", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerDevice), Member = "GetKeyRaw", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerDevice), Member = "GetKeyRaw2", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600549A")]
			[global::Cpp2ILInjected.Address(RVA = "0x94DFFC", Offset = "0x94DFFC", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappings), Member = "LoadConfiguration", MemberParameters = new object[]
			{
				typeof(Preferences),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIToggleSetting), Member = "Toggle", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060047D5 RID: 18389 RVA: 0x0002ED18 File Offset: 0x0002CF18
		[global::Cpp2ILInjected.Token(Token = "0x600549B")]
		[global::Cpp2ILInjected.Address(RVA = "0x94D2C4", Offset = "0x94D2C4", Length = "0x58C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerDeviceManager), Member = "UpdateConnectedControllers", MemberParameters = new object[]
		{
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public ControllerDevice(InputDevice device)
		{
			throw null;
		}

		// Token: 0x060047D6 RID: 18390 RVA: 0x0002ED1B File Offset: 0x0002CF1B
		[global::Cpp2ILInjected.Token(Token = "0x600549C")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E04C", Offset = "0x94E04C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public ControllerDevice(InputDevice leftDevice, InputDevice rightDevice)
		{
			throw null;
		}

		// Token: 0x060047D7 RID: 18391 RVA: 0x0002ED1E File Offset: 0x0002CF1E
		[global::Cpp2ILInjected.Token(Token = "0x600549D")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E180", Offset = "0x94E180", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public ControllerDevice()
		{
			throw null;
		}

		// Token: 0x060047D8 RID: 18392 RVA: 0x0002ED21 File Offset: 0x0002CF21
		[global::Cpp2ILInjected.Token(Token = "0x600549E")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E2B8", Offset = "0x94E2B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "RequiredStateValid", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		public bool HasAxis(Axis axis)
		{
			throw null;
		}

		// Token: 0x060047D9 RID: 18393 RVA: 0x0002ED24 File Offset: 0x0002CF24
		[global::Cpp2ILInjected.Token(Token = "0x600549F")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E2C0", Offset = "0x94E2C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "RequiredStateValid", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		public bool HasButton(Buttons button)
		{
			throw null;
		}

		// Token: 0x060047DA RID: 18394 RVA: 0x0002ED27 File Offset: 0x0002CF27
		[global::Cpp2ILInjected.Token(Token = "0x60054A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E2C8", Offset = "0x94E2C8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSunAndMoon", MemberParameters = new object[]
		{
			typeof(Main.SceneArea),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		public float GetAxis(Axis axis)
		{
			throw null;
		}

		// Token: 0x060047DB RID: 18395 RVA: 0x0002ED2A File Offset: 0x0002CF2A
		[global::Cpp2ILInjected.Token(Token = "0x60054A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E2D8", Offset = "0x94E2D8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "RequiredStateValid", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "Active", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "RequiredStateValid", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		public float GetAxisTime(Axis axis)
		{
			throw null;
		}

		// Token: 0x060047DC RID: 18396 RVA: 0x0002ED2D File Offset: 0x0002CF2D
		[global::Cpp2ILInjected.Token(Token = "0x60054A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E2E8", Offset = "0x94E2E8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public float GetAxisScaled(Axis axis)
		{
			throw null;
		}

		// Token: 0x060047DD RID: 18397 RVA: 0x0002ED30 File Offset: 0x0002CF30
		[global::Cpp2ILInjected.Token(Token = "0x60054A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E2F8", Offset = "0x94E2F8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public float GetPreviousAxis(Axis axis)
		{
			throw null;
		}

		// Token: 0x060047DE RID: 18398 RVA: 0x0002ED33 File Offset: 0x0002CF33
		[global::Cpp2ILInjected.Token(Token = "0x60054A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E308", Offset = "0x94E308", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float GetPreviousAxisScaled(Axis axis)
		{
			throw null;
		}

		// Token: 0x060047DF RID: 18399 RVA: 0x0002ED36 File Offset: 0x0002CF36
		[global::Cpp2ILInjected.Token(Token = "0x60054A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E318", Offset = "0x94E318", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "Active", MemberParameters = new object[]
		{
			typeof(ControllerDevice),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "Valid", MemberParameters = new object[]
		{
			typeof(ControllerDevice),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "RequiredStateValid", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		public float ButtonTime(Buttons key)
		{
			throw null;
		}

		// Token: 0x060047E0 RID: 18400 RVA: 0x0002ED39 File Offset: 0x0002CF39
		[global::Cpp2ILInjected.Token(Token = "0x60054A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E328", Offset = "0x94E328", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public bool ButtonConsumed(Buttons key)
		{
			throw null;
		}

		// Token: 0x060047E1 RID: 18401 RVA: 0x0002ED3C File Offset: 0x0002CF3C
		[global::Cpp2ILInjected.Token(Token = "0x60054A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E338", Offset = "0x94E338", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "ConsumeModifiers", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void SetButtonConsumbed(Buttons key)
		{
			throw null;
		}

		// Token: 0x060047E2 RID: 18402 RVA: 0x0002ED3F File Offset: 0x0002CF3F
		[global::Cpp2ILInjected.Token(Token = "0x60054A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E34C", Offset = "0x94E34C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIMainMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawSunAndMoon", MemberParameters = new object[]
		{
			typeof(Main.SceneArea),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(Microsoft.Xna.Framework.Graphics.Color),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawStarsInBackground", MemberParameters = new object[]
		{
			typeof(Main.SceneArea),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionAxis), Member = "GetValue", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "Active", MemberParameters = new object[]
		{
			typeof(ControllerDevice),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton.RequiredButtonState), Member = "Valid", MemberParameters = new object[]
		{
			typeof(ControllerDevice),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		public bool ButtonState(Buttons key)
		{
			throw null;
		}

		// Token: 0x060047E3 RID: 18403 RVA: 0x0002ED42 File Offset: 0x0002CF42
		[global::Cpp2ILInjected.Token(Token = "0x60054A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E35C", Offset = "0x94E35C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonState", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool PreviousButtonState(Buttons key)
		{
			throw null;
		}

		// Token: 0x060047E4 RID: 18404 RVA: 0x0002ED45 File Offset: 0x0002CF45
		[global::Cpp2ILInjected.Token(Token = "0x60054AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E36C", Offset = "0x94E36C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIControllerMappingEntry), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonUp", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		public bool ButtonUp(Buttons key)
		{
			throw null;
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x0002ED48 File Offset: 0x0002CF48
		[global::Cpp2ILInjected.Token(Token = "0x60054AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E37C", Offset = "0x94E37C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UserManagement), Member = "LookForNewUsers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerActionButton), Member = "GetButtonDown", MemberParameters = new object[] { typeof(ControllerDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool ButtonDown(Buttons key)
		{
			throw null;
		}

		// Token: 0x060047E6 RID: 18406 RVA: 0x0002ED4B File Offset: 0x0002CF4B
		[global::Cpp2ILInjected.Token(Token = "0x60054AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E38C", Offset = "0x94E38C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetFakedButton(Buttons key)
		{
			throw null;
		}

		// Token: 0x060047E7 RID: 18407 RVA: 0x0002ED4E File Offset: 0x0002CF4E
		[global::Cpp2ILInjected.Token(Token = "0x60054AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E3A0", Offset = "0x94E3A0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetFakedAxis(Axis axis, float value)
		{
			throw null;
		}

		// Token: 0x060047E8 RID: 18408 RVA: 0x0002ED51 File Offset: 0x0002CF51
		[global::Cpp2ILInjected.Token(Token = "0x60054AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x94D850", Offset = "0x94D850", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerDeviceManager), Member = "UpdateConnectedControllers", MemberParameters = new object[]
		{
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerDeviceManager), Member = "UpdateDevices", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void ResetState()
		{
			throw null;
		}

		// Token: 0x060047E9 RID: 18409 RVA: 0x0002ED54 File Offset: 0x0002CF54
		[global::Cpp2ILInjected.Token(Token = "0x60054AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x94DB18", Offset = "0x94DB18", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerDeviceManager), Member = "UpdateDevices", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetAxisRaw2", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetAxisRaw", MemberParameters = new object[] { typeof(Axis) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetKeyRaw2", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "GetKeyRaw", MemberParameters = new object[] { typeof(Buttons) }, ReturnType = typeof(bool))]
		public bool Update(float elapsedTime)
		{
			throw null;
		}

		// Token: 0x060047EA RID: 18410 RVA: 0x0002ED57 File Offset: 0x0002CF57
		[global::Cpp2ILInjected.Token(Token = "0x60054B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E3B0", Offset = "0x94E3B0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerDevice), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_LeftStickX", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_LeftStickY", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_RightStickX", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_RightStickY", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_DPadX", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_DPadY", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_LeftTrigger", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_RightTrigger", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "op_Implicit", MemberParameters = new object[] { typeof(OneAxisInputControl) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private float GetAxisRaw(Axis axis)
		{
			throw null;
		}

		// Token: 0x060047EB RID: 18411 RVA: 0x0002ED5A File Offset: 0x0002CF5A
		[global::Cpp2ILInjected.Token(Token = "0x60054B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E468", Offset = "0x94E468", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerDevice), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_LeftStickY", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_LeftStickX", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "op_Implicit", MemberParameters = new object[] { typeof(OneAxisInputControl) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action2", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "get_State", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action1", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action3", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action4", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private float GetAxisRaw2(Axis axis)
		{
			throw null;
		}

		// Token: 0x060047EC RID: 18412 RVA: 0x0002ED5D File Offset: 0x0002CF5D
		[global::Cpp2ILInjected.Token(Token = "0x60054B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E580", Offset = "0x94E580", Length = "0x238")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerDevice), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "get_SwapBumpersTriggers", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action1", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action2", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action3", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action4", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_LeftBumper", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_RightBumper", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_LeftTrigger", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_RightTrigger", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "get_State", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_LeftStickButton", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_RightStickButton", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool GetKeyRaw(Buttons key)
		{
			throw null;
		}

		// Token: 0x060047ED RID: 18413 RVA: 0x0002ED60 File Offset: 0x0002CF60
		[global::Cpp2ILInjected.Token(Token = "0x60054B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x94E7B8", Offset = "0x94E7B8", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ControllerDevice), Member = "Update", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ControllerDevice), Member = "get_SwapBumpersTriggers", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action1", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action2", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action3", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_Action4", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_RightTrigger", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "GetControl", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_LeftStickButton", ReturnType = typeof(InputControl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "get_State", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool GetKeyRaw2(Buttons key)
		{
			throw null;
		}

		// Token: 0x040073CF RID: 29647
		[global::Cpp2ILInjected.Token(Token = "0x4008D8E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public ControllerDevice.ControlScheme Controls;

		// Token: 0x040073D0 RID: 29648
		[global::Cpp2ILInjected.Token(Token = "0x4008D8F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public InputDevice Device;

		// Token: 0x040073D1 RID: 29649
		[global::Cpp2ILInjected.Token(Token = "0x4008D90")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public InputDevice Device2;

		// Token: 0x040073D2 RID: 29650
		[global::Cpp2ILInjected.Token(Token = "0x4008D91")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly float[] AxisValue;

		// Token: 0x040073D3 RID: 29651
		[global::Cpp2ILInjected.Token(Token = "0x4008D92")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly float[] AxisValueScaled;

		// Token: 0x040073D4 RID: 29652
		[global::Cpp2ILInjected.Token(Token = "0x4008D93")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly float[] PreviousAxisValue;

		// Token: 0x040073D5 RID: 29653
		[global::Cpp2ILInjected.Token(Token = "0x4008D94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly float[] PreviousAxisValueScaled;

		// Token: 0x040073D6 RID: 29654
		[global::Cpp2ILInjected.Token(Token = "0x4008D95")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly float[] _AxisTime;

		// Token: 0x040073D7 RID: 29655
		[global::Cpp2ILInjected.Token(Token = "0x4008D96")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly float[] _KeyTime;

		// Token: 0x040073D8 RID: 29656
		[global::Cpp2ILInjected.Token(Token = "0x4008D97")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private readonly bool[] _KeyState;

		// Token: 0x040073D9 RID: 29657
		[global::Cpp2ILInjected.Token(Token = "0x4008D98")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private readonly bool[] _KeyConsumed;

		// Token: 0x040073DA RID: 29658
		[global::Cpp2ILInjected.Token(Token = "0x4008D99")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private readonly bool[] _PreviousKeyState;

		// Token: 0x040073DB RID: 29659
		[global::Cpp2ILInjected.Token(Token = "0x4008D9A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private readonly bool[] _KeyStateUp;

		// Token: 0x040073DC RID: 29660
		[global::Cpp2ILInjected.Token(Token = "0x4008D9B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private readonly bool[] _KeyStateDown;

		// Token: 0x040073DD RID: 29661
		[global::Cpp2ILInjected.Token(Token = "0x4008D9C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private readonly float[] _fakedAxisValues;

		// Token: 0x040073DE RID: 29662
		[global::Cpp2ILInjected.Token(Token = "0x4008D9D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private readonly bool[] _fakedDeviceButtons;

		// Token: 0x02000AE1 RID: 2785
		[global::Cpp2ILInjected.Token(Token = "0x2000B62")]
		public enum ControlScheme
		{
			// Token: 0x04008FC3 RID: 36803
			[global::Cpp2ILInjected.Token(Token = "0x4008D9F")]
			CONTROLS_1234,
			// Token: 0x04008FC4 RID: 36804
			[global::Cpp2ILInjected.Token(Token = "0x4008DA0")]
			CONTROLS_ABXY_GREY,
			// Token: 0x04008FC5 RID: 36805
			[global::Cpp2ILInjected.Token(Token = "0x4008DA1")]
			CONTROLS_ABXY_XBOX,
			// Token: 0x04008FC6 RID: 36806
			[global::Cpp2ILInjected.Token(Token = "0x4008DA2")]
			CONTROLS_OUYA,
			// Token: 0x04008FC7 RID: 36807
			[global::Cpp2ILInjected.Token(Token = "0x4008DA3")]
			CONTROLS_PS4,
			// Token: 0x04008FC8 RID: 36808
			[global::Cpp2ILInjected.Token(Token = "0x4008DA4")]
			CONTROLS_ABXY_STEELSERIES,
			// Token: 0x04008FC9 RID: 36809
			[global::Cpp2ILInjected.Token(Token = "0x4008DA5")]
			CONTROLS_SWITCH,
			// Token: 0x04008FCA RID: 36810
			[global::Cpp2ILInjected.Token(Token = "0x4008DA6")]
			CONTROLS_STADIA
		}
	}
}
