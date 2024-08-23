using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl.NativeDeviceProfiles;
using InControl.UnityDeviceProfiles;
using Newtonsoft.Json;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000032 RID: 50
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000034")]
	[Serializable]
	public class InputDeviceProfile
	{
		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000276B File Offset: 0x0000096B
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0000276E File Offset: 0x0000096E
		[global::Cpp2ILInjected.Token(Token = "0x170000D0")]
		public InputDeviceProfileType ProfileType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000261")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990EA4", Offset = "0x1990EA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000262")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990EAC", Offset = "0x1990EAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00002771 File Offset: 0x00000971
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00002774 File Offset: 0x00000974
		[global::Cpp2ILInjected.Token(Token = "0x170000D1")]
		public string DeviceName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000263")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990EB4", Offset = "0x1990EB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000264")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990EBC", Offset = "0x1990EBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00002777 File Offset: 0x00000977
		// (set) Token: 0x06000265 RID: 613 RVA: 0x0000277A File Offset: 0x0000097A
		[global::Cpp2ILInjected.Token(Token = "0x170000D2")]
		public string DeviceNotes
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000265")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990EC4", Offset = "0x1990EC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000266")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990ECC", Offset = "0x1990ECC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0000277D File Offset: 0x0000097D
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002780 File Offset: 0x00000980
		[global::Cpp2ILInjected.Token(Token = "0x170000D3")]
		public InputDeviceClass DeviceClass
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000267")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990ED4", Offset = "0x1990ED4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000268")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990EDC", Offset = "0x1990EDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00002783 File Offset: 0x00000983
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00002786 File Offset: 0x00000986
		[global::Cpp2ILInjected.Token(Token = "0x170000D4")]
		public InputDeviceStyle DeviceStyle
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000269")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990EE4", Offset = "0x1990EE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600026A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990EEC", Offset = "0x1990EEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00002789 File Offset: 0x00000989
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0000278C File Offset: 0x0000098C
		[global::Cpp2ILInjected.Token(Token = "0x170000D5")]
		public float Sensitivity
		{
			[global::Cpp2ILInjected.Token(Token = "0x600026B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990EF4", Offset = "0x1990EF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600026C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990EFC", Offset = "0x1990EFC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0000278F File Offset: 0x0000098F
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00002792 File Offset: 0x00000992
		[global::Cpp2ILInjected.Token(Token = "0x170000D6")]
		public float LowerDeadZone
		{
			[global::Cpp2ILInjected.Token(Token = "0x600026D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990F18", Offset = "0x1990F18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600026E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990F20", Offset = "0x1990F20", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OuyaAmazonUnityProfile), Member = "Define", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AppleTVRemoteUnityProfile), Member = "Define", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AppleTVWirelessControllerUnityProfile), Member = "Define", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OuyaLinuxUnityProfile), Member = "Define", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AppleMFiUnityProfile), Member = "Define", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OuyaWindowsUnityProfile), Member = "Define", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00002795 File Offset: 0x00000995
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00002798 File Offset: 0x00000998
		[global::Cpp2ILInjected.Token(Token = "0x170000D7")]
		public float UpperDeadZone
		{
			[global::Cpp2ILInjected.Token(Token = "0x600026F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990F3C", Offset = "0x1990F3C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000270")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990F44", Offset = "0x1990F44", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AppleTVRemoteUnityProfile), Member = "Define", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AppleTVWirelessControllerUnityProfile), Member = "Define", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AppleMFiUnityProfile), Member = "Define", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameCubeMayflashWindowsUnityProfile), Member = "Define", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NintendoSwitchProMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameCubeMayflashWindowsNativeProfile), Member = "Define", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NintendoSwitchProWindowsNativeProfile), Member = "Define", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000279B File Offset: 0x0000099B
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0000279E File Offset: 0x0000099E
		[global::Cpp2ILInjected.Token(Token = "0x170000D8")]
		public InputControlMapping[] AnalogMappings
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000271")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990F60", Offset = "0x1990F60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000272")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990F68", Offset = "0x1990F68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000272 RID: 626 RVA: 0x000027A1 File Offset: 0x000009A1
		// (set) Token: 0x06000273 RID: 627 RVA: 0x000027A4 File Offset: 0x000009A4
		[global::Cpp2ILInjected.Token(Token = "0x170000D9")]
		public InputControlMapping[] ButtonMappings
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000273")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990F70", Offset = "0x1990F70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000274")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990F78", Offset = "0x1990F78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000274 RID: 628 RVA: 0x000027A7 File Offset: 0x000009A7
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000027AA File Offset: 0x000009AA
		[global::Cpp2ILInjected.Token(Token = "0x170000DA")]
		public string[] IncludePlatforms
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000275")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990F80", Offset = "0x1990F80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000276")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990F88", Offset = "0x1990F88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000276 RID: 630 RVA: 0x000027AD File Offset: 0x000009AD
		// (set) Token: 0x06000277 RID: 631 RVA: 0x000027B0 File Offset: 0x000009B0
		[global::Cpp2ILInjected.Token(Token = "0x170000DB")]
		public string[] ExcludePlatforms
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000277")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990F90", Offset = "0x1990F90", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000278")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990F98", Offset = "0x1990F98", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000278 RID: 632 RVA: 0x000027B3 File Offset: 0x000009B3
		// (set) Token: 0x06000279 RID: 633 RVA: 0x000027B6 File Offset: 0x000009B6
		[global::Cpp2ILInjected.Token(Token = "0x170000DC")]
		public int MinSystemBuildNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000279")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990FA0", Offset = "0x1990FA0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600027A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990FA8", Offset = "0x1990FA8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600027A RID: 634 RVA: 0x000027B9 File Offset: 0x000009B9
		// (set) Token: 0x0600027B RID: 635 RVA: 0x000027BC File Offset: 0x000009BC
		[global::Cpp2ILInjected.Token(Token = "0x170000DD")]
		public int MaxSystemBuildNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x600027B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990FB0", Offset = "0x1990FB0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600027C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990FB8", Offset = "0x1990FB8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600027C RID: 636 RVA: 0x000027BF File Offset: 0x000009BF
		// (set) Token: 0x0600027D RID: 637 RVA: 0x000027C2 File Offset: 0x000009C2
		[global::Cpp2ILInjected.Token(Token = "0x170000DE")]
		public VersionInfo MinUnityVersion
		{
			[global::Cpp2ILInjected.Token(Token = "0x600027D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990FC0", Offset = "0x1990FC0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600027E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990FCC", Offset = "0x1990FCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600027E RID: 638 RVA: 0x000027C5 File Offset: 0x000009C5
		// (set) Token: 0x0600027F RID: 639 RVA: 0x000027C8 File Offset: 0x000009C8
		[global::Cpp2ILInjected.Token(Token = "0x170000DF")]
		public VersionInfo MaxUnityVersion
		{
			[global::Cpp2ILInjected.Token(Token = "0x600027F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990FD4", Offset = "0x1990FD4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000280")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990FE0", Offset = "0x1990FE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000280 RID: 640 RVA: 0x000027CB File Offset: 0x000009CB
		// (set) Token: 0x06000281 RID: 641 RVA: 0x000027CE File Offset: 0x000009CE
		[global::Cpp2ILInjected.Token(Token = "0x170000E0")]
		public InputDeviceMatcher[] Matchers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000281")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990FE8", Offset = "0x1990FE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000282")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990FF0", Offset = "0x1990FF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000282 RID: 642 RVA: 0x000027D1 File Offset: 0x000009D1
		// (set) Token: 0x06000283 RID: 643 RVA: 0x000027D4 File Offset: 0x000009D4
		[global::Cpp2ILInjected.Token(Token = "0x170000E1")]
		public InputDeviceMatcher[] LastResortMatchers
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000283")]
			[global::Cpp2ILInjected.Address(RVA = "0x1990FF8", Offset = "0x1990FF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000284")]
			[global::Cpp2ILInjected.Address(RVA = "0x1991000", Offset = "0x1991000", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000027D7 File Offset: 0x000009D7
		[global::Cpp2ILInjected.Token(Token = "0x6000285")]
		[global::Cpp2ILInjected.Address(RVA = "0x1991008", Offset = "0x1991008", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDeviceProfile), Member = "CreateInstanceOfType", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(InputDeviceProfile))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static InputDeviceProfile CreateInstanceOfType(Type type)
		{
			throw null;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000027DA File Offset: 0x000009DA
		[global::Cpp2ILInjected.Token(Token = "0x6000286")]
		[global::Cpp2ILInjected.Address(RVA = "0x199109C", Offset = "0x199109C", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "AddSystemDeviceProfiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "AddSystemDeviceProfiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "Log", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "CreateInstanceOfType", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(InputDeviceProfile))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static InputDeviceProfile CreateInstanceOfType(string typeName)
		{
			throw null;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000027DD File Offset: 0x000009DD
		[global::Cpp2ILInjected.Token(Token = "0x6000287")]
		[global::Cpp2ILInjected.Address(RVA = "0x19911E4", Offset = "0x19911E4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 229)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public virtual void Define()
		{
			throw null;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000027E0 File Offset: 0x000009E0
		[global::Cpp2ILInjected.Token(Token = "0x6000288")]
		[global::Cpp2ILInjected.Address(RVA = "0x19912A0", Offset = "0x19912A0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityInputDeviceManager.<>c__DisplayClass20_0", Member = "<DetectDevice>b__0", MemberParameters = new object[] { typeof(InputDeviceProfile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityInputDeviceManager.<>c__DisplayClass20_0", Member = "<DetectDevice>b__1", MemberParameters = new object[] { typeof(InputDeviceProfile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Matches", MemberParameters = new object[]
		{
			typeof(InputDeviceInfo),
			typeof(InputDeviceMatcher[])
		}, ReturnType = typeof(bool))]
		public bool Matches(InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000027E3 File Offset: 0x000009E3
		[global::Cpp2ILInjected.Token(Token = "0x6000289")]
		[global::Cpp2ILInjected.Address(RVA = "0x1991348", Offset = "0x1991348", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityInputDeviceManager.<>c__DisplayClass20_0", Member = "<DetectDevice>b__2", MemberParameters = new object[] { typeof(InputDeviceProfile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityInputDeviceManager.<>c__DisplayClass20_0", Member = "<DetectDevice>b__3", MemberParameters = new object[] { typeof(InputDeviceProfile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Matches", MemberParameters = new object[]
		{
			typeof(InputDeviceInfo),
			typeof(InputDeviceMatcher[])
		}, ReturnType = typeof(bool))]
		public bool LastResortMatches(InputDeviceInfo deviceInfo)
		{
			throw null;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000027E6 File Offset: 0x000009E6
		[global::Cpp2ILInjected.Token(Token = "0x600028A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19912D4", Offset = "0x19912D4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDeviceProfile), Member = "Matches", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDeviceProfile), Member = "LastResortMatches", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.NativeInputDeviceManager.<>c__DisplayClass9_0", Member = "<DetectDevice>b__0", MemberParameters = new object[] { typeof(InputDeviceProfile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.NativeInputDeviceManager.<>c__DisplayClass9_0", Member = "<DetectDevice>b__1", MemberParameters = new object[] { typeof(InputDeviceProfile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.NativeInputDeviceManager.<>c__DisplayClass9_0", Member = "<DetectDevice>b__2", MemberParameters = new object[] { typeof(InputDeviceProfile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.NativeInputDeviceManager.<>c__DisplayClass9_0", Member = "<DetectDevice>b__3", MemberParameters = new object[] { typeof(InputDeviceProfile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceMatcher), Member = "Matches", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
		public bool Matches(InputDeviceInfo deviceInfo, InputDeviceMatcher[] matchers)
		{
			throw null;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600028A RID: 650 RVA: 0x000027E9 File Offset: 0x000009E9
		[global::Cpp2ILInjected.Token(Token = "0x170000E2")]
		public bool IsSupportedOnThisPlatform
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028B")]
			[global::Cpp2ILInjected.Address(RVA = "0x199137C", Offset = "0x199137C", Length = "0x220")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDevice), Member = "get_IsSupportedOnThisPlatform", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "AddSystemDeviceProfile", MemberParameters = new object[] { typeof(InputDeviceProfile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDevice), Member = "get_IsSupportedOnThisPlatform", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "AddSystemDeviceProfile", MemberParameters = new object[] { typeof(InputDeviceProfile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "AddDeviceProfile", MemberParameters = new object[] { typeof(CustomInputDeviceProfile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "UnityVersion", ReturnType = typeof(VersionInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "op_LessThan", MemberParameters = new object[]
			{
				typeof(VersionInfo),
				typeof(VersionInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "op_GreaterThan", MemberParameters = new object[]
			{
				typeof(VersionInfo),
				typeof(VersionInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "GetSystemBuildNumber", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpper", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000027EC File Offset: 0x000009EC
		[global::Cpp2ILInjected.Token(Token = "0x600028C")]
		[global::Cpp2ILInjected.Address(RVA = "0x199159C", Offset = "0x199159C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "HideDevicesWithProfile", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Add", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void Hide(Type type)
		{
			throw null;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600028C RID: 652 RVA: 0x000027EF File Offset: 0x000009EF
		[global::Cpp2ILInjected.Token(Token = "0x170000E3")]
		public bool IsHidden
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1991614", Offset = "0x1991614", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "DetectDevice", MemberParameters = new object[]
			{
				typeof(uint),
				typeof(InputDeviceInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "DetectJoystickDevice", MemberParameters = new object[]
			{
				typeof(int),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600028D RID: 653 RVA: 0x000027F2 File Offset: 0x000009F2
		[global::Cpp2ILInjected.Token(Token = "0x170000E4")]
		public int AnalogCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028E")]
			[global::Cpp2ILInjected.Address(RVA = "0x199169C", Offset = "0x199169C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600028E RID: 654 RVA: 0x000027F5 File Offset: 0x000009F5
		[global::Cpp2ILInjected.Token(Token = "0x170000E5")]
		public int ButtonCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028F")]
			[global::Cpp2ILInjected.Address(RVA = "0x19916A8", Offset = "0x19916A8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000027F8 File Offset: 0x000009F8
		[global::Cpp2ILInjected.Token(Token = "0x6000290")]
		[global::Cpp2ILInjected.Address(RVA = "0x19916B4", Offset = "0x19916B4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2506)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		protected static InputControlSource Button(int index)
		{
			throw null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000027FB File Offset: 0x000009FB
		[global::Cpp2ILInjected.Token(Token = "0x6000291")]
		[global::Cpp2ILInjected.Address(RVA = "0x19916DC", Offset = "0x19916DC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 905)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		protected static InputControlSource Analog(int index)
		{
			throw null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000027FE File Offset: 0x000009FE
		[global::Cpp2ILInjected.Token(Token = "0x6000292")]
		[global::Cpp2ILInjected.Address(RVA = "0x1991704", Offset = "0x1991704", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 145)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping LeftStickLeftMapping(int analog)
		{
			throw null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002801 File Offset: 0x00000A01
		[global::Cpp2ILInjected.Token(Token = "0x6000293")]
		[global::Cpp2ILInjected.Address(RVA = "0x19917E0", Offset = "0x19917E0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 145)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping LeftStickRightMapping(int analog)
		{
			throw null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002804 File Offset: 0x00000A04
		[global::Cpp2ILInjected.Token(Token = "0x6000294")]
		[global::Cpp2ILInjected.Address(RVA = "0x19918B8", Offset = "0x19918B8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 141)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping LeftStickUpMapping(int analog)
		{
			throw null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002807 File Offset: 0x00000A07
		[global::Cpp2ILInjected.Token(Token = "0x6000295")]
		[global::Cpp2ILInjected.Address(RVA = "0x1991994", Offset = "0x1991994", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 141)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping LeftStickDownMapping(int analog)
		{
			throw null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000280A File Offset: 0x00000A0A
		[global::Cpp2ILInjected.Token(Token = "0x6000296")]
		[global::Cpp2ILInjected.Address(RVA = "0x1991A6C", Offset = "0x1991A6C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AppleMFiExtendedGamepadNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DualShock4MFiNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XboxOneMFiNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XInputWindowsNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping LeftStickUpMapping2(int analog)
		{
			throw null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000280D File Offset: 0x00000A0D
		[global::Cpp2ILInjected.Token(Token = "0x6000297")]
		[global::Cpp2ILInjected.Address(RVA = "0x1991B44", Offset = "0x1991B44", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AppleMFiExtendedGamepadNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DualShock4MFiNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XboxOneMFiNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XInputWindowsNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping LeftStickDownMapping2(int analog)
		{
			throw null;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002810 File Offset: 0x00000A10
		[global::Cpp2ILInjected.Token(Token = "0x6000298")]
		[global::Cpp2ILInjected.Address(RVA = "0x1991C20", Offset = "0x1991C20", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 144)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping RightStickLeftMapping(int analog)
		{
			throw null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002813 File Offset: 0x00000A13
		[global::Cpp2ILInjected.Token(Token = "0x6000299")]
		[global::Cpp2ILInjected.Address(RVA = "0x1991CFC", Offset = "0x1991CFC", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 144)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping RightStickRightMapping(int analog)
		{
			throw null;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002816 File Offset: 0x00000A16
		[global::Cpp2ILInjected.Token(Token = "0x600029A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1991DD4", Offset = "0x1991DD4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 139)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping RightStickUpMapping(int analog)
		{
			throw null;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002819 File Offset: 0x00000A19
		[global::Cpp2ILInjected.Token(Token = "0x600029B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1991EB0", Offset = "0x1991EB0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 139)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping RightStickDownMapping(int analog)
		{
			throw null;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000281C File Offset: 0x00000A1C
		[global::Cpp2ILInjected.Token(Token = "0x600029C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1991F88", Offset = "0x1991F88", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AppleMFiExtendedGamepadNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DualShock4MFiNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XboxOneMFiNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XInputWindowsNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping RightStickUpMapping2(int analog)
		{
			throw null;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000281F File Offset: 0x00000A1F
		[global::Cpp2ILInjected.Token(Token = "0x600029D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1992060", Offset = "0x1992060", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AppleMFiExtendedGamepadNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DualShock4MFiNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XboxOneMFiNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XInputWindowsNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping RightStickDownMapping2(int analog)
		{
			throw null;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002822 File Offset: 0x00000A22
		[global::Cpp2ILInjected.Token(Token = "0x600029E")]
		[global::Cpp2ILInjected.Address(RVA = "0x199213C", Offset = "0x199213C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MogaHeroPowerAndroidUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MogaProPowerAndroidUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogitechF310ModeXMacUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogitechF510ModeXMacUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayStation4MacBluetoothUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayStation4MacUSBUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayStation4SteamLinkMacUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Xbox360MacUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XboxOneMacUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayStation4MacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XboxOneDriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XboxOneSMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping LeftTriggerMapping(int analog)
		{
			throw null;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002825 File Offset: 0x00000A25
		[global::Cpp2ILInjected.Token(Token = "0x600029F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1992220", Offset = "0x1992220", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MogaHeroPowerAndroidUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MogaProPowerAndroidUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogitechF310ModeXMacUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogitechF510ModeXMacUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayStation4MacBluetoothUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayStation4MacUSBUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayStation4SteamLinkMacUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Xbox360MacUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XboxOneMacUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayStation4MacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Xbox360DriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XboxOneDriverMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XboxOneSMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping RightTriggerMapping(int analog)
		{
			throw null;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002828 File Offset: 0x00000A28
		[global::Cpp2ILInjected.Token(Token = "0x60002A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1992304", Offset = "0x1992304", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 126)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping DPadLeftMapping(int analog)
		{
			throw null;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000282B File Offset: 0x00000A2B
		[global::Cpp2ILInjected.Token(Token = "0x60002A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x19923E0", Offset = "0x19923E0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 126)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping DPadRightMapping(int analog)
		{
			throw null;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000282E File Offset: 0x00000A2E
		[global::Cpp2ILInjected.Token(Token = "0x60002A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x19924B8", Offset = "0x19924B8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 104)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping DPadUpMapping(int analog)
		{
			throw null;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002831 File Offset: 0x00000A31
		[global::Cpp2ILInjected.Token(Token = "0x60002A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1992594", Offset = "0x1992594", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 104)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping DPadDownMapping(int analog)
		{
			throw null;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002834 File Offset: 0x00000A34
		[global::Cpp2ILInjected.Token(Token = "0x60002A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x199266C", Offset = "0x199266C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping DPadUpMapping2(int analog)
		{
			throw null;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002837 File Offset: 0x00000A37
		[global::Cpp2ILInjected.Token(Token = "0x60002A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1992744", Offset = "0x1992744", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 22)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlMapping), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(InputControlSourceType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected static InputControlMapping DPadDownMapping2(int analog)
		{
			throw null;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000283A File Offset: 0x00000A3A
		[global::Cpp2ILInjected.Token(Token = "0x60002A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1992820", Offset = "0x1992820", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 232)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "get_Min", ReturnType = typeof(VersionInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "get_Max", ReturnType = typeof(VersionInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public InputDeviceProfile()
		{
			throw null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000283D File Offset: 0x00000A3D
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60002A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x199294C", Offset = "0x199294C", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControlSource), Member = ".ctor", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static InputDeviceProfile()
		{
			throw null;
		}

		// Token: 0x0400024E RID: 590
		[global::Cpp2ILInjected.Token(Token = "0x4000255")]
		private static readonly HashSet<Type> hiddenProfiles;

		// Token: 0x0400024F RID: 591
		[JsonProperty]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000256")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private InputDeviceProfileType profileType;

		// Token: 0x04000250 RID: 592
		[JsonProperty]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000257")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string deviceName;

		// Token: 0x04000251 RID: 593
		[SerializeField]
		[JsonProperty]
		[TextArea]
		[global::Cpp2ILInjected.Token(Token = "0x4000258")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string deviceNotes;

		// Token: 0x04000252 RID: 594
		[SerializeField]
		[JsonProperty]
		[global::Cpp2ILInjected.Token(Token = "0x4000259")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private InputDeviceClass deviceClass;

		// Token: 0x04000253 RID: 595
		[SerializeField]
		[JsonProperty]
		[global::Cpp2ILInjected.Token(Token = "0x400025A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private InputDeviceStyle deviceStyle;

		// Token: 0x04000254 RID: 596
		[SerializeField]
		[JsonProperty]
		[global::Cpp2ILInjected.Token(Token = "0x400025B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private float sensitivity;

		// Token: 0x04000255 RID: 597
		[JsonProperty]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400025C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private float lowerDeadZone;

		// Token: 0x04000256 RID: 598
		[JsonProperty]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400025D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private float upperDeadZone;

		// Token: 0x04000257 RID: 599
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400025E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string[] includePlatforms;

		// Token: 0x04000258 RID: 600
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400025F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private string[] excludePlatforms;

		// Token: 0x04000259 RID: 601
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000260")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private int minSystemBuildNumber;

		// Token: 0x0400025A RID: 602
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000261")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private int maxSystemBuildNumber;

		// Token: 0x0400025B RID: 603
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000262")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private VersionInfo minUnityVersion;

		// Token: 0x0400025C RID: 604
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000263")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private VersionInfo maxUnityVersion;

		// Token: 0x0400025D RID: 605
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000264")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private InputDeviceMatcher[] matchers;

		// Token: 0x0400025E RID: 606
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000265")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private InputDeviceMatcher[] lastResortMatchers;

		// Token: 0x0400025F RID: 607
		[JsonProperty]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000266")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private InputControlMapping[] analogMappings;

		// Token: 0x04000260 RID: 608
		[JsonProperty]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000267")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private InputControlMapping[] buttonMappings;

		// Token: 0x04000261 RID: 609
		[global::Cpp2ILInjected.Token(Token = "0x4000268")]
		protected static readonly InputControlSource MenuKey;

		// Token: 0x04000262 RID: 610
		[global::Cpp2ILInjected.Token(Token = "0x4000269")]
		protected static readonly InputControlSource EscapeKey;
	}
}
