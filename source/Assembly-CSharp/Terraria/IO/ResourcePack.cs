using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Zip;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json.Linq;
using ReLogic.Content;
using ReLogic.Content.Sources;
using ReLogic.Utilities;

namespace Terraria.IO
{
	// Token: 0x020003C0 RID: 960
	[global::Cpp2ILInjected.Token(Token = "0x2000566")]
	public class ResourcePack
	{
		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06002F38 RID: 12088 RVA: 0x0002A6F2 File Offset: 0x000288F2
		[global::Cpp2ILInjected.Token(Token = "0x17000670")]
		public Texture2D Icon
		{
			[global::Cpp2ILInjected.Token(Token = "0x60033A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x133F8CC", Offset = "0x133F8CC", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourcePack), Member = "CreateIcon", ReturnType = typeof(Texture2D))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06002F39 RID: 12089 RVA: 0x0002A6F5 File Offset: 0x000288F5
		// (set) Token: 0x06002F3A RID: 12090 RVA: 0x0002A6F8 File Offset: 0x000288F8
		[global::Cpp2ILInjected.Token(Token = "0x17000671")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x133FBD0", Offset = "0x133FBD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x133FBD8", Offset = "0x133FBD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06002F3B RID: 12091 RVA: 0x0002A6FB File Offset: 0x000288FB
		// (set) Token: 0x06002F3C RID: 12092 RVA: 0x0002A6FE File Offset: 0x000288FE
		[global::Cpp2ILInjected.Token(Token = "0x17000672")]
		public string Description
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x133FBE0", Offset = "0x133FBE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x133FBE8", Offset = "0x133FBE8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06002F3D RID: 12093 RVA: 0x0002A701 File Offset: 0x00028901
		// (set) Token: 0x06002F3E RID: 12094 RVA: 0x0002A704 File Offset: 0x00028904
		[global::Cpp2ILInjected.Token(Token = "0x17000673")]
		public string Author
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x133FBF0", Offset = "0x133FBF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x133FBF8", Offset = "0x133FBF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06002F3F RID: 12095 RVA: 0x0002A707 File Offset: 0x00028907
		// (set) Token: 0x06002F40 RID: 12096 RVA: 0x0002A70A File Offset: 0x0002890A
		[global::Cpp2ILInjected.Token(Token = "0x17000674")]
		public ResourcePackVersion Version
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x133FC00", Offset = "0x133FC00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x133FC08", Offset = "0x133FC08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002F41 RID: 12097 RVA: 0x0002A70D File Offset: 0x0002890D
		// (set) Token: 0x06002F42 RID: 12098 RVA: 0x0002A710 File Offset: 0x00028910
		[global::Cpp2ILInjected.Token(Token = "0x17000675")]
		public bool IsEnabled
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x133FC10", Offset = "0x133FC10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x133FC18", Offset = "0x133FC18", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002F43 RID: 12099 RVA: 0x0002A713 File Offset: 0x00028913
		// (set) Token: 0x06002F44 RID: 12100 RVA: 0x0002A716 File Offset: 0x00028916
		[global::Cpp2ILInjected.Token(Token = "0x17000676")]
		public int SortingOrder
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x133FC24", Offset = "0x133FC24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60033AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x133FC2C", Offset = "0x133FC2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x0002A719 File Offset: 0x00028919
		[global::Cpp2ILInjected.Token(Token = "0x60033B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x133FC34", Offset = "0x133FC34", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public ResourcePack(IServiceProvider services, string path)
		{
			throw null;
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x0002A71C File Offset: 0x0002891C
		[global::Cpp2ILInjected.Token(Token = "0x60033B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1340200", Offset = "0x1340200", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Refresh()
		{
			throw null;
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x0002A71F File Offset: 0x0002891F
		[global::Cpp2ILInjected.Token(Token = "0x60033B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x134020C", Offset = "0x134020C", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContentSource), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileSystemContentSource), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public IContentSource GetContentSource()
		{
			throw null;
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x0002A722 File Offset: 0x00028922
		[global::Cpp2ILInjected.Token(Token = "0x60033B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x133F8F0", Offset = "0x133F8F0", Length = "0x2E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourcePack), Member = "get_Icon", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourcePack), Member = "HasFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourcePack), Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XnaExtensions), Member = "Get", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(IServiceProvider) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetReaderCollection), Member = "Read", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(string)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private Texture2D CreateIcon()
		{
			throw null;
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x0002A725 File Offset: 0x00028925
		[global::Cpp2ILInjected.Token(Token = "0x60033B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x133FD78", Offset = "0x133FD78", Length = "0x488")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourcePack), Member = "HasFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResourcePack), Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Extensions), Member = "Value", MemberTypeParameters = new object[] { "U" }, MemberParameters = new object[] { typeof(IEnumerable<JToken>) }, ReturnType = "U")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JToken[]), Member = "ToObject", MemberTypeParameters = new object[] { typeof(ResourcePackVersion) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		private void LoadManifest()
		{
			throw null;
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x0002A728 File Offset: 0x00028928
		[global::Cpp2ILInjected.Token(Token = "0x60033B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1340438", Offset = "0x1340438", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourcePack), Member = "CreateIcon", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourcePack), Member = "LoadManifest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "Extract", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "OpenRead", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private Stream OpenStream(string fileName)
		{
			throw null;
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x0002A72B File Offset: 0x0002892B
		[global::Cpp2ILInjected.Token(Token = "0x60033B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x13403AC", Offset = "0x13403AC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourcePack), Member = "CreateIcon", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResourcePack), Member = "LoadManifest", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "ContainsEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool HasFile(string fileName)
		{
			throw null;
		}

		// Token: 0x0400329F RID: 12959
		[global::Cpp2ILInjected.Token(Token = "0x4003C55")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly string FullPath;

		// Token: 0x040032A0 RID: 12960
		[global::Cpp2ILInjected.Token(Token = "0x4003C56")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly string FileName;

		// Token: 0x040032A1 RID: 12961
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C57")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string <Name>k__BackingField;

		// Token: 0x040032A2 RID: 12962
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C58")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string <Description>k__BackingField;

		// Token: 0x040032A3 RID: 12963
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C59")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private string <Author>k__BackingField;

		// Token: 0x040032A4 RID: 12964
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C5A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ResourcePackVersion <Version>k__BackingField;

		// Token: 0x040032A5 RID: 12965
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C5B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool <IsEnabled>k__BackingField;

		// Token: 0x040032A6 RID: 12966
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4003C5C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private int <SortingOrder>k__BackingField;

		// Token: 0x040032A7 RID: 12967
		[global::Cpp2ILInjected.Token(Token = "0x4003C5D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly IServiceProvider _services;

		// Token: 0x040032A8 RID: 12968
		[global::Cpp2ILInjected.Token(Token = "0x4003C5E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly bool _isCompressed;

		// Token: 0x040032A9 RID: 12969
		[global::Cpp2ILInjected.Token(Token = "0x4003C5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private readonly ZipFile _zipFile;

		// Token: 0x040032AA RID: 12970
		[global::Cpp2ILInjected.Token(Token = "0x4003C60")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Texture2D _icon;

		// Token: 0x040032AB RID: 12971
		[global::Cpp2ILInjected.Token(Token = "0x4003C61")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private IContentSource _contentSource;

		// Token: 0x040032AC RID: 12972
		[global::Cpp2ILInjected.Token(Token = "0x4003C62")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool _needsReload;

		// Token: 0x040032AD RID: 12973
		[global::Cpp2ILInjected.Token(Token = "0x4003C63")]
		private const string ICON_FILE_NAME = "icon.png";

		// Token: 0x040032AE RID: 12974
		[global::Cpp2ILInjected.Token(Token = "0x4003C64")]
		private const string PACK_FILE_NAME = "pack.json";
	}
}
