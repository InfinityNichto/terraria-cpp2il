using System;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl.UnityDeviceProfiles;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000065 RID: 101
	[global::Cpp2ILInjected.Token(Token = "0x2000071")]
	[Serializable]
	public struct VersionInfo : IComparable<VersionInfo>
	{
		// Token: 0x0600052C RID: 1324 RVA: 0x00002FB1 File Offset: 0x000011B1
		[global::Cpp2ILInjected.Token(Token = "0x6000544")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B2D34", Offset = "0x19B2D34", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameStickLinuxUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GenericLinuxUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogitechF310LinuxUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LogitechF510LinuxUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MogaProLinuxUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OuyaLinuxUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayStation3LinuxUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Xbox360LinuxUnityProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		public VersionInfo(int major, int minor, int patch, int build)
		{
			throw null;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00002FB4 File Offset: 0x000011B4
		[global::Cpp2ILInjected.Token(Token = "0x6000545")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B873C", Offset = "0x19B873C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static VersionInfo InControlVersion()
		{
			throw null;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00002FB7 File Offset: 0x000011B7
		[global::Cpp2ILInjected.Token(Token = "0x6000546")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B874C", Offset = "0x19B874C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDeviceProfile), Member = "get_IsSupportedOnThisPlatform", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "get_UnityVersion", ReturnType = typeof(VersionInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_unityVersion", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Capture), Member = "get_Value", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static VersionInfo UnityVersion()
		{
			throw null;
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00002FBA File Offset: 0x000011BA
		[global::Cpp2ILInjected.Token(Token = "0x17000169")]
		public static VersionInfo Min
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000547")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B88D0", Offset = "0x19B88D0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00002FBD File Offset: 0x000011BD
		[global::Cpp2ILInjected.Token(Token = "0x1700016A")]
		public static VersionInfo Max
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000548")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B88DC", Offset = "0x19B88DC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDeviceProfile), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00002FC0 File Offset: 0x000011C0
		[global::Cpp2ILInjected.Token(Token = "0x1700016B")]
		public VersionInfo Next
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000549")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B88E8", Offset = "0x19B88E8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00002FC3 File Offset: 0x000011C3
		[global::Cpp2ILInjected.Token(Token = "0x1700016C")]
		public int Build
		{
			[global::Cpp2ILInjected.Token(Token = "0x600054A")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B88FC", Offset = "0x19B88FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00002FC6 File Offset: 0x000011C6
		[global::Cpp2ILInjected.Token(Token = "0x600054B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8904", Offset = "0x19B8904", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "DetectJoystickDevice", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VersionInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(VersionInfo),
			typeof(VersionInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VersionInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(VersionInfo),
			typeof(VersionInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VersionInfo), Member = "op_LessThanOrEqual", MemberParameters = new object[]
		{
			typeof(VersionInfo),
			typeof(VersionInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VersionInfo), Member = "op_GreaterThanOrEqual", MemberParameters = new object[]
		{
			typeof(VersionInfo),
			typeof(VersionInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VersionInfo), Member = "op_LessThan", MemberParameters = new object[]
		{
			typeof(VersionInfo),
			typeof(VersionInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VersionInfo), Member = "op_GreaterThan", MemberParameters = new object[]
		{
			typeof(VersionInfo),
			typeof(VersionInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VersionInfo), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		public int CompareTo(VersionInfo other)
		{
			throw null;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00002FC9 File Offset: 0x000011C9
		[global::Cpp2ILInjected.Token(Token = "0x600054C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8960", Offset = "0x19B8960", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "CompareTo", MemberParameters = new object[] { typeof(VersionInfo) }, ReturnType = typeof(int))]
		public static bool operator ==(VersionInfo a, VersionInfo b)
		{
			throw null;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00002FCC File Offset: 0x000011CC
		[global::Cpp2ILInjected.Token(Token = "0x600054D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8990", Offset = "0x19B8990", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "CompareTo", MemberParameters = new object[] { typeof(VersionInfo) }, ReturnType = typeof(int))]
		public static bool operator !=(VersionInfo a, VersionInfo b)
		{
			throw null;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00002FCF File Offset: 0x000011CF
		[global::Cpp2ILInjected.Token(Token = "0x600054E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B89C0", Offset = "0x19B89C0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "CompareTo", MemberParameters = new object[] { typeof(VersionInfo) }, ReturnType = typeof(int))]
		public static bool operator <=(VersionInfo a, VersionInfo b)
		{
			throw null;
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00002FD2 File Offset: 0x000011D2
		[global::Cpp2ILInjected.Token(Token = "0x600054F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B2D6C", Offset = "0x19B2D6C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "CompareTo", MemberParameters = new object[] { typeof(VersionInfo) }, ReturnType = typeof(int))]
		public static bool operator >=(VersionInfo a, VersionInfo b)
		{
			throw null;
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00002FD5 File Offset: 0x000011D5
		[global::Cpp2ILInjected.Token(Token = "0x6000550")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B2D40", Offset = "0x19B2D40", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDeviceProfile), Member = "get_IsSupportedOnThisPlatform", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "CompareTo", MemberParameters = new object[] { typeof(VersionInfo) }, ReturnType = typeof(int))]
		public static bool operator <(VersionInfo a, VersionInfo b)
		{
			throw null;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002FD8 File Offset: 0x000011D8
		[global::Cpp2ILInjected.Token(Token = "0x6000551")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B89F0", Offset = "0x19B89F0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDeviceProfile), Member = "get_IsSupportedOnThisPlatform", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "CompareTo", MemberParameters = new object[] { typeof(VersionInfo) }, ReturnType = typeof(int))]
		public static bool operator >(VersionInfo a, VersionInfo b)
		{
			throw null;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00002FDB File Offset: 0x000011DB
		[global::Cpp2ILInjected.Token(Token = "0x6000552")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8A20", Offset = "0x19B8A20", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "CompareTo", MemberParameters = new object[] { typeof(VersionInfo) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00002FDE File Offset: 0x000011DE
		[global::Cpp2ILInjected.Token(Token = "0x6000553")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8AAC", Offset = "0x19B8AAC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00002FE1 File Offset: 0x000011E1
		[global::Cpp2ILInjected.Token(Token = "0x6000554")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8B10", Offset = "0x19B8B10", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002FE4 File Offset: 0x000011E4
		[global::Cpp2ILInjected.Token(Token = "0x6000555")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B8D04", Offset = "0x19B8D04", Length = "0x1F4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public string ToShortString()
		{
			throw null;
		}

		// Token: 0x040003AD RID: 941
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int major;

		// Token: 0x040003AE RID: 942
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int minor;

		// Token: 0x040003AF RID: 943
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int patch;

		// Token: 0x040003B0 RID: 944
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000400")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private int build;
	}
}
