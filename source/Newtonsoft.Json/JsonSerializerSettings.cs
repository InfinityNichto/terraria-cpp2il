using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	// Token: 0x02000024 RID: 36
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000024")]
	public class JsonSerializerSettings
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000021F2 File Offset: 0x000003F2
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000021F5 File Offset: 0x000003F5
		[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
		public ReferenceLoopHandling ReferenceLoopHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600006C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7590", Offset = "0x1CB7590", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new object[]
			{
				typeof(JsonSerializer),
				typeof(JsonSerializerSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600006D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB75E0", Offset = "0x1CB75E0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000021F8 File Offset: 0x000003F8
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000021FB File Offset: 0x000003FB
		[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
		public MissingMemberHandling MissingMemberHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600006E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7648", Offset = "0x1CB7648", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new object[]
			{
				typeof(JsonSerializer),
				typeof(JsonSerializerSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600006F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7698", Offset = "0x1CB7698", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000021FE File Offset: 0x000003FE
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002201 File Offset: 0x00000401
		[global::Cpp2ILInjected.Token(Token = "0x1700001C")]
		public ObjectCreationHandling ObjectCreationHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000070")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7700", Offset = "0x1CB7700", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new object[]
			{
				typeof(JsonSerializer),
				typeof(JsonSerializerSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000071")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7750", Offset = "0x1CB7750", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002204 File Offset: 0x00000404
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002207 File Offset: 0x00000407
		[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
		public NullValueHandling NullValueHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000072")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB77B8", Offset = "0x1CB77B8", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new object[]
			{
				typeof(JsonSerializer),
				typeof(JsonSerializerSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000073")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7808", Offset = "0x1CB7808", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000220A File Offset: 0x0000040A
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000220D File Offset: 0x0000040D
		[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
		public DefaultValueHandling DefaultValueHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000074")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7870", Offset = "0x1CB7870", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new object[]
			{
				typeof(JsonSerializer),
				typeof(JsonSerializerSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000075")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB78C0", Offset = "0x1CB78C0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002210 File Offset: 0x00000410
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002213 File Offset: 0x00000413
		[global::Cpp2ILInjected.Token(Token = "0x1700001F")]
		public IList<JsonConverter> Converters
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000076")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7928", Offset = "0x1CB7928", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000077")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7930", Offset = "0x1CB7930", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002216 File Offset: 0x00000416
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002219 File Offset: 0x00000419
		[global::Cpp2ILInjected.Token(Token = "0x17000020")]
		public PreserveReferencesHandling PreserveReferencesHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000078")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7938", Offset = "0x1CB7938", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new object[]
			{
				typeof(JsonSerializer),
				typeof(JsonSerializerSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000079")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7988", Offset = "0x1CB7988", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000221C File Offset: 0x0000041C
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000221F File Offset: 0x0000041F
		[global::Cpp2ILInjected.Token(Token = "0x17000021")]
		public TypeNameHandling TypeNameHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB79F0", Offset = "0x1CB79F0", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new object[]
			{
				typeof(JsonSerializer),
				typeof(JsonSerializerSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600007B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7A40", Offset = "0x1CB7A40", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceStyles_Layout", Member = "SaveConfiguration", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceStyles_Layout", Member = "LoadConfiguration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualControlsStyles_Layout", Member = "SaveConfiguration", MemberParameters = new object[] { "Terraria.IO.Preferences" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualControlsStyles_Layout", Member = "LoadConfiguration", MemberParameters = new object[] { "Terraria.IO.Preferences" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "LoadPersistantData", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "SavePersistantData", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile", Member = "Save", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile", Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002222 File Offset: 0x00000422
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002225 File Offset: 0x00000425
		[global::Cpp2ILInjected.Token(Token = "0x17000022")]
		public MetadataPropertyHandling MetadataPropertyHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7AA8", Offset = "0x1CB7AA8", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new object[]
			{
				typeof(JsonSerializer),
				typeof(JsonSerializerSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600007D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7AF8", Offset = "0x1CB7AF8", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceStyles_Layout", Member = "SaveConfiguration", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceStyles_Layout", Member = "LoadConfiguration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualControlsStyles_Layout", Member = "SaveConfiguration", MemberParameters = new object[] { "Terraria.IO.Preferences" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualControlsStyles_Layout", Member = "LoadConfiguration", MemberParameters = new object[] { "Terraria.IO.Preferences" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "LoadPersistantData", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "SavePersistantData", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile", Member = "Save", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile", Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00002228 File Offset: 0x00000428
		// (set) Token: 0x0600007F RID: 127 RVA: 0x0000222B File Offset: 0x0000042B
		[global::Cpp2ILInjected.Token(Token = "0x17000023")]
		public FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			[global::Cpp2ILInjected.Token(Token = "0x600007E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7B60", Offset = "0x1CB7B60", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new object[]
			{
				typeof(JsonSerializer),
				typeof(JsonSerializerSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600007F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7BB0", Offset = "0x1CB7BB0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000222E File Offset: 0x0000042E
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002231 File Offset: 0x00000431
		[global::Cpp2ILInjected.Token(Token = "0x17000024")]
		public ConstructorHandling ConstructorHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000080")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7C18", Offset = "0x1CB7C18", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new object[]
			{
				typeof(JsonSerializer),
				typeof(JsonSerializerSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000081")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7C68", Offset = "0x1CB7C68", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002234 File Offset: 0x00000434
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002237 File Offset: 0x00000437
		[global::Cpp2ILInjected.Token(Token = "0x17000025")]
		public IContractResolver ContractResolver
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000082")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7CD0", Offset = "0x1CB7CD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000083")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7CD8", Offset = "0x1CB7CD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000223A File Offset: 0x0000043A
		// (set) Token: 0x06000085 RID: 133 RVA: 0x0000223D File Offset: 0x0000043D
		[global::Cpp2ILInjected.Token(Token = "0x17000026")]
		public IEqualityComparer EqualityComparer
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000084")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7CE0", Offset = "0x1CB7CE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000085")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7CE8", Offset = "0x1CB7CE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002240 File Offset: 0x00000440
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00002243 File Offset: 0x00000443
		[Obsolete("ReferenceResolver property is obsolete. Use the ReferenceResolverProvider property to set the IReferenceResolver: settings.ReferenceResolverProvider = () => resolver")]
		[global::Cpp2ILInjected.Token(Token = "0x17000027")]
		public IReferenceResolver ReferenceResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000086")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7CF0", Offset = "0x1CB7CF0", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000087")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7D10", Offset = "0x1CB7D10", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00002246 File Offset: 0x00000446
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002249 File Offset: 0x00000449
		[global::Cpp2ILInjected.Token(Token = "0x17000028")]
		public Func<IReferenceResolver> ReferenceResolverProvider
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000088")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7DC8", Offset = "0x1CB7DC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000089")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7DD0", Offset = "0x1CB7DD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000224C File Offset: 0x0000044C
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000224F File Offset: 0x0000044F
		[global::Cpp2ILInjected.Token(Token = "0x17000029")]
		public ITraceWriter TraceWriter
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600008A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7DD8", Offset = "0x1CB7DD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600008B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7DE0", Offset = "0x1CB7DE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00002252 File Offset: 0x00000452
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002255 File Offset: 0x00000455
		[global::Cpp2ILInjected.Token(Token = "0x1700002A")]
		public SerializationBinder Binder
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600008C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7DE8", Offset = "0x1CB7DE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600008D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7DF0", Offset = "0x1CB7DF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002258 File Offset: 0x00000458
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000225B File Offset: 0x0000045B
		[global::Cpp2ILInjected.Token(Token = "0x1700002B")]
		public EventHandler<ErrorEventArgs> Error
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600008E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7DF8", Offset = "0x1CB7DF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600008F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7E00", Offset = "0x1CB7E00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000225E File Offset: 0x0000045E
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002261 File Offset: 0x00000461
		[global::Cpp2ILInjected.Token(Token = "0x1700002C")]
		public StreamingContext Context
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000090")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7E08", Offset = "0x1CB7E08", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonSerializer), Member = "ApplySerializerSettings", MemberParameters = new object[]
			{
				typeof(JsonSerializer),
				typeof(JsonSerializerSettings)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000091")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7E98", Offset = "0x1CB7E98", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamingContext?), Member = ".ctor", MemberParameters = new object[] { typeof(StreamingContext) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002264 File Offset: 0x00000464
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002267 File Offset: 0x00000467
		[global::Cpp2ILInjected.Token(Token = "0x1700002D")]
		public string DateFormatString
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000092")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7F1C", Offset = "0x1CB7F1C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000093")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7F6C", Offset = "0x1CB7F6C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000226A File Offset: 0x0000046A
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000226D File Offset: 0x0000046D
		[global::Cpp2ILInjected.Token(Token = "0x1700002E")]
		public int? MaxDepth
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000094")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7F7C", Offset = "0x1CB7F7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000095")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7F84", Offset = "0x1CB7F84", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00002270 File Offset: 0x00000470
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002273 File Offset: 0x00000473
		[global::Cpp2ILInjected.Token(Token = "0x1700002F")]
		public Formatting Formatting
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000096")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB8048", Offset = "0x1CB8048", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000097")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB8098", Offset = "0x1CB8098", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002276 File Offset: 0x00000476
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002279 File Offset: 0x00000479
		[global::Cpp2ILInjected.Token(Token = "0x17000030")]
		public DateFormatHandling DateFormatHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000098")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB8100", Offset = "0x1CB8100", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000099")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB8150", Offset = "0x1CB8150", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000227C File Offset: 0x0000047C
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000227F File Offset: 0x0000047F
		[global::Cpp2ILInjected.Token(Token = "0x17000031")]
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB81B8", Offset = "0x1CB81B8", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600009B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB820C", Offset = "0x1CB820C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002282 File Offset: 0x00000482
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002285 File Offset: 0x00000485
		[global::Cpp2ILInjected.Token(Token = "0x17000032")]
		public DateParseHandling DateParseHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB8274", Offset = "0x1CB8274", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600009D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB82C4", Offset = "0x1CB82C4", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00002288 File Offset: 0x00000488
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0000228B File Offset: 0x0000048B
		[global::Cpp2ILInjected.Token(Token = "0x17000033")]
		public FloatFormatHandling FloatFormatHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB832C", Offset = "0x1CB832C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600009F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB837C", Offset = "0x1CB837C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000228E File Offset: 0x0000048E
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002291 File Offset: 0x00000491
		[global::Cpp2ILInjected.Token(Token = "0x17000034")]
		public FloatParseHandling FloatParseHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB83E4", Offset = "0x1CB83E4", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB8434", Offset = "0x1CB8434", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002294 File Offset: 0x00000494
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002297 File Offset: 0x00000497
		[global::Cpp2ILInjected.Token(Token = "0x17000035")]
		public StringEscapeHandling StringEscapeHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB849C", Offset = "0x1CB849C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB84EC", Offset = "0x1CB84EC", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Int32Enum?), Member = ".ctor", MemberParameters = new object[] { "System.Int32Enum" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000229A File Offset: 0x0000049A
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000229D File Offset: 0x0000049D
		[global::Cpp2ILInjected.Token(Token = "0x17000036")]
		public CultureInfo Culture
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB8554", Offset = "0x1CB8554", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB85B8", Offset = "0x1CB85B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000022A0 File Offset: 0x000004A0
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000022A3 File Offset: 0x000004A3
		[global::Cpp2ILInjected.Token(Token = "0x17000037")]
		public bool CheckAdditionalContent
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB85C0", Offset = "0x1CB85C0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB861C", Offset = "0x1CB861C", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000022A6 File Offset: 0x000004A6
		[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB8684", Offset = "0x1CB8684", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static JsonSerializerSettings()
		{
			throw null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000022A9 File Offset: 0x000004A9
		[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB8704", Offset = "0x1CB8704", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceStyles_Layout", Member = "SaveConfiguration", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceStyles_Layout", Member = "LoadConfiguration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualControlsStyles_Layout", Member = "SaveConfiguration", MemberParameters = new object[] { "Terraria.IO.Preferences" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualControlsStyles_Layout", Member = "LoadConfiguration", MemberParameters = new object[] { "Terraria.IO.Preferences" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "LoadPersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "SavePersistantData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.Preferences", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Achievements.AchievementManager", Member = ".ctor", MemberParameters = new object[] { "LocalUser" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile", Member = "Save", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile", Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = "InControl.UnityDeviceProfiles.CustomInputDeviceProfile")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(JsonConverter[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "SerializeObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Formatting),
			typeof(JsonConverter[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonConvert), Member = "DeserializeObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Type),
			typeof(JsonConverter[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VectorConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSetConverter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public JsonSerializerSettings()
		{
			throw null;
		}

		// Token: 0x04000058 RID: 88
		[global::Cpp2ILInjected.Token(Token = "0x4000058")]
		internal const ReferenceLoopHandling DefaultReferenceLoopHandling = ReferenceLoopHandling.Error;

		// Token: 0x04000059 RID: 89
		[global::Cpp2ILInjected.Token(Token = "0x4000059")]
		internal const MissingMemberHandling DefaultMissingMemberHandling = MissingMemberHandling.Ignore;

		// Token: 0x0400005A RID: 90
		[global::Cpp2ILInjected.Token(Token = "0x400005A")]
		internal const NullValueHandling DefaultNullValueHandling = NullValueHandling.Include;

		// Token: 0x0400005B RID: 91
		[global::Cpp2ILInjected.Token(Token = "0x400005B")]
		internal const DefaultValueHandling DefaultDefaultValueHandling = DefaultValueHandling.Include;

		// Token: 0x0400005C RID: 92
		[global::Cpp2ILInjected.Token(Token = "0x400005C")]
		internal const ObjectCreationHandling DefaultObjectCreationHandling = ObjectCreationHandling.Auto;

		// Token: 0x0400005D RID: 93
		[global::Cpp2ILInjected.Token(Token = "0x400005D")]
		internal const PreserveReferencesHandling DefaultPreserveReferencesHandling = PreserveReferencesHandling.None;

		// Token: 0x0400005E RID: 94
		[global::Cpp2ILInjected.Token(Token = "0x400005E")]
		internal const ConstructorHandling DefaultConstructorHandling = ConstructorHandling.Default;

		// Token: 0x0400005F RID: 95
		[global::Cpp2ILInjected.Token(Token = "0x400005F")]
		internal const TypeNameHandling DefaultTypeNameHandling = TypeNameHandling.None;

		// Token: 0x04000060 RID: 96
		[global::Cpp2ILInjected.Token(Token = "0x4000060")]
		internal const MetadataPropertyHandling DefaultMetadataPropertyHandling = MetadataPropertyHandling.Default;

		// Token: 0x04000061 RID: 97
		[global::Cpp2ILInjected.Token(Token = "0x4000061")]
		internal const FormatterAssemblyStyle DefaultTypeNameAssemblyFormat = FormatterAssemblyStyle.Simple;

		// Token: 0x04000062 RID: 98
		[global::Cpp2ILInjected.Token(Token = "0x4000062")]
		internal static readonly StreamingContext DefaultContext;

		// Token: 0x04000063 RID: 99
		[global::Cpp2ILInjected.Token(Token = "0x4000063")]
		internal const Formatting DefaultFormatting = Formatting.None;

		// Token: 0x04000064 RID: 100
		[global::Cpp2ILInjected.Token(Token = "0x4000064")]
		internal const DateFormatHandling DefaultDateFormatHandling = DateFormatHandling.IsoDateFormat;

		// Token: 0x04000065 RID: 101
		[global::Cpp2ILInjected.Token(Token = "0x4000065")]
		internal const DateTimeZoneHandling DefaultDateTimeZoneHandling = DateTimeZoneHandling.RoundtripKind;

		// Token: 0x04000066 RID: 102
		[global::Cpp2ILInjected.Token(Token = "0x4000066")]
		internal const DateParseHandling DefaultDateParseHandling = DateParseHandling.DateTime;

		// Token: 0x04000067 RID: 103
		[global::Cpp2ILInjected.Token(Token = "0x4000067")]
		internal const FloatParseHandling DefaultFloatParseHandling = FloatParseHandling.Double;

		// Token: 0x04000068 RID: 104
		[global::Cpp2ILInjected.Token(Token = "0x4000068")]
		internal const FloatFormatHandling DefaultFloatFormatHandling = FloatFormatHandling.String;

		// Token: 0x04000069 RID: 105
		[global::Cpp2ILInjected.Token(Token = "0x4000069")]
		internal const StringEscapeHandling DefaultStringEscapeHandling = StringEscapeHandling.Default;

		// Token: 0x0400006A RID: 106
		[global::Cpp2ILInjected.Token(Token = "0x400006A")]
		internal const FormatterAssemblyStyle DefaultFormatterAssemblyStyle = FormatterAssemblyStyle.Simple;

		// Token: 0x0400006B RID: 107
		[global::Cpp2ILInjected.Token(Token = "0x400006B")]
		internal static readonly CultureInfo DefaultCulture;

		// Token: 0x0400006C RID: 108
		[global::Cpp2ILInjected.Token(Token = "0x400006C")]
		internal const bool DefaultCheckAdditionalContent = false;

		// Token: 0x0400006D RID: 109
		[global::Cpp2ILInjected.Token(Token = "0x400006D")]
		internal const string DefaultDateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		// Token: 0x0400006E RID: 110
		[global::Cpp2ILInjected.Token(Token = "0x400006E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal Formatting? _formatting;

		// Token: 0x0400006F RID: 111
		[global::Cpp2ILInjected.Token(Token = "0x400006F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal DateFormatHandling? _dateFormatHandling;

		// Token: 0x04000070 RID: 112
		[global::Cpp2ILInjected.Token(Token = "0x4000070")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal DateTimeZoneHandling? _dateTimeZoneHandling;

		// Token: 0x04000071 RID: 113
		[global::Cpp2ILInjected.Token(Token = "0x4000071")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal DateParseHandling? _dateParseHandling;

		// Token: 0x04000072 RID: 114
		[global::Cpp2ILInjected.Token(Token = "0x4000072")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal FloatFormatHandling? _floatFormatHandling;

		// Token: 0x04000073 RID: 115
		[global::Cpp2ILInjected.Token(Token = "0x4000073")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal FloatParseHandling? _floatParseHandling;

		// Token: 0x04000074 RID: 116
		[global::Cpp2ILInjected.Token(Token = "0x4000074")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal StringEscapeHandling? _stringEscapeHandling;

		// Token: 0x04000075 RID: 117
		[global::Cpp2ILInjected.Token(Token = "0x4000075")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal CultureInfo _culture;

		// Token: 0x04000076 RID: 118
		[global::Cpp2ILInjected.Token(Token = "0x4000076")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal bool? _checkAdditionalContent;

		// Token: 0x04000077 RID: 119
		[global::Cpp2ILInjected.Token(Token = "0x4000077")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		internal int? _maxDepth;

		// Token: 0x04000078 RID: 120
		[global::Cpp2ILInjected.Token(Token = "0x4000078")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		internal bool _maxDepthSet;

		// Token: 0x04000079 RID: 121
		[global::Cpp2ILInjected.Token(Token = "0x4000079")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal string _dateFormatString;

		// Token: 0x0400007A RID: 122
		[global::Cpp2ILInjected.Token(Token = "0x400007A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal bool _dateFormatStringSet;

		// Token: 0x0400007B RID: 123
		[global::Cpp2ILInjected.Token(Token = "0x400007B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		internal FormatterAssemblyStyle? _typeNameAssemblyFormat;

		// Token: 0x0400007C RID: 124
		[global::Cpp2ILInjected.Token(Token = "0x400007C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		internal DefaultValueHandling? _defaultValueHandling;

		// Token: 0x0400007D RID: 125
		[global::Cpp2ILInjected.Token(Token = "0x400007D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		internal PreserveReferencesHandling? _preserveReferencesHandling;

		// Token: 0x0400007E RID: 126
		[global::Cpp2ILInjected.Token(Token = "0x400007E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		internal NullValueHandling? _nullValueHandling;

		// Token: 0x0400007F RID: 127
		[global::Cpp2ILInjected.Token(Token = "0x400007F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		internal ObjectCreationHandling? _objectCreationHandling;

		// Token: 0x04000080 RID: 128
		[global::Cpp2ILInjected.Token(Token = "0x4000080")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		internal MissingMemberHandling? _missingMemberHandling;

		// Token: 0x04000081 RID: 129
		[global::Cpp2ILInjected.Token(Token = "0x4000081")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		internal ReferenceLoopHandling? _referenceLoopHandling;

		// Token: 0x04000082 RID: 130
		[global::Cpp2ILInjected.Token(Token = "0x4000082")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		internal StreamingContext? _context;

		// Token: 0x04000083 RID: 131
		[global::Cpp2ILInjected.Token(Token = "0x4000083")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		internal ConstructorHandling? _constructorHandling;

		// Token: 0x04000084 RID: 132
		[global::Cpp2ILInjected.Token(Token = "0x4000084")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		internal TypeNameHandling? _typeNameHandling;

		// Token: 0x04000085 RID: 133
		[global::Cpp2ILInjected.Token(Token = "0x4000085")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		internal MetadataPropertyHandling? _metadataPropertyHandling;

		// Token: 0x04000086 RID: 134
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000086")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private IList<JsonConverter> <Converters>k__BackingField;

		// Token: 0x04000087 RID: 135
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000087")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private IContractResolver <ContractResolver>k__BackingField;

		// Token: 0x04000088 RID: 136
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000088")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private IEqualityComparer <EqualityComparer>k__BackingField;

		// Token: 0x04000089 RID: 137
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000089")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField;

		// Token: 0x0400008A RID: 138
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400008A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private ITraceWriter <TraceWriter>k__BackingField;

		// Token: 0x0400008B RID: 139
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400008B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private SerializationBinder <Binder>k__BackingField;

		// Token: 0x0400008C RID: 140
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400008C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private EventHandler<ErrorEventArgs> <Error>k__BackingField;

		// Token: 0x020000F2 RID: 242
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000025")]
		private sealed class <>c__DisplayClass90_0
		{
			// Token: 0x06000A86 RID: 2694 RVA: 0x00003F0E File Offset: 0x0000210E
			[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB7DC0", Offset = "0x1CB7DC0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass90_0()
			{
				throw null;
			}

			// Token: 0x06000A87 RID: 2695 RVA: 0x00003F11 File Offset: 0x00002111
			[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB88B4", Offset = "0x1CB88B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal IReferenceResolver <set_ReferenceResolver>b__0()
			{
				throw null;
			}

			// Token: 0x04000364 RID: 868
			[global::Cpp2ILInjected.Token(Token = "0x400008D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public IReferenceResolver value;
		}
	}
}
