using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Ionic.Zip;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content.Sources;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003CC")]
public class ResourcePack
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40032A1")]
	public readonly string FullPath;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40032A2")]
	public readonly string FileName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40032A9")]
	private readonly IServiceProvider _services;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40032AA")]
	private readonly bool _isCompressed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40032AB")]
	private readonly ZipFile _zipFile;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40032AC")]
	private Texture2D _icon;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40032AD")]
	private IContentSource _contentSource;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40032AE")]
	private bool _needsReload;

	[Cpp2IlInjected.Token(Token = "0x40032AF")]
	private const string ICON_FILE_NAME = "icon.png";

	[Cpp2IlInjected.Token(Token = "0x40032B0")]
	private const string PACK_FILE_NAME = "pack.json";

	[Cpp2IlInjected.Token(Token = "0x170005F7")]
	public Texture2D Icon
	{
		[Cpp2IlInjected.Token(Token = "0x6002FAC")]
		[Cpp2IlInjected.Address(RVA = "0xE47508", Offset = "0xE47508", VA = "0xE47508")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005F8")]
	public string Name
	{
		[Cpp2IlInjected.Token(Token = "0x6002FAD")]
		[Cpp2IlInjected.Address(RVA = "0xE47770", Offset = "0xE47770", VA = "0xE47770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002FAE")]
		[Cpp2IlInjected.Address(RVA = "0xE47778", Offset = "0xE47778", VA = "0xE47778")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005F9")]
	public string Description
	{
		[Cpp2IlInjected.Token(Token = "0x6002FAF")]
		[Cpp2IlInjected.Address(RVA = "0xE47780", Offset = "0xE47780", VA = "0xE47780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002FB0")]
		[Cpp2IlInjected.Address(RVA = "0xE47788", Offset = "0xE47788", VA = "0xE47788")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005FA")]
	public string Author
	{
		[Cpp2IlInjected.Token(Token = "0x6002FB1")]
		[Cpp2IlInjected.Address(RVA = "0xE47790", Offset = "0xE47790", VA = "0xE47790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6002FB2")]
		[Cpp2IlInjected.Address(RVA = "0xE47798", Offset = "0xE47798", VA = "0xE47798")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005FB")]
	public ResourcePackVersion Version
	{
		[Cpp2IlInjected.Token(Token = "0x6002FB3")]
		[Cpp2IlInjected.Address(RVA = "0xE477A0", Offset = "0xE477A0", VA = "0xE477A0")]
		[CompilerGenerated]
		get
		{
			return default(ResourcePackVersion);
		}
		[Cpp2IlInjected.Token(Token = "0x6002FB4")]
		[Cpp2IlInjected.Address(RVA = "0xE477B4", Offset = "0xE477B4", VA = "0xE477B4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005FC")]
	public bool IsEnabled
	{
		[Cpp2IlInjected.Token(Token = "0x6002FB5")]
		[Cpp2IlInjected.Address(RVA = "0xE477C0", Offset = "0xE477C0", VA = "0xE477C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6002FB6")]
		[Cpp2IlInjected.Address(RVA = "0xE477C8", Offset = "0xE477C8", VA = "0xE477C8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005FD")]
	public int SortingOrder
	{
		[Cpp2IlInjected.Token(Token = "0x6002FB7")]
		[Cpp2IlInjected.Address(RVA = "0xE477D0", Offset = "0xE477D0", VA = "0xE477D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6002FB8")]
		[Cpp2IlInjected.Address(RVA = "0xE477D8", Offset = "0xE477D8", VA = "0xE477D8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002FB9")]
	[Cpp2IlInjected.Address(RVA = "0xE477E0", Offset = "0xE477E0", VA = "0xE477E0")]
	public ResourcePack(IServiceProvider services, string path)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FBA")]
	[Cpp2IlInjected.Address(RVA = "0xE47CDC", Offset = "0xE47CDC", VA = "0xE47CDC")]
	public void Refresh()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FBB")]
	[Cpp2IlInjected.Address(RVA = "0xE47CE8", Offset = "0xE47CE8", VA = "0xE47CE8")]
	public IContentSource GetContentSource()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002FBC")]
	[Cpp2IlInjected.Address(RVA = "0xE47530", Offset = "0xE47530", VA = "0xE47530")]
	private Texture2D CreateIcon()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002FBD")]
	[Cpp2IlInjected.Address(RVA = "0xE47964", Offset = "0xE47964", VA = "0xE47964")]
	private void LoadManifest()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FBE")]
	[Cpp2IlInjected.Address(RVA = "0xE47F5C", Offset = "0xE47F5C", VA = "0xE47F5C")]
	private Stream OpenStream(string fileName)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002FBF")]
	[Cpp2IlInjected.Address(RVA = "0xE47EAC", Offset = "0xE47EAC", VA = "0xE47EAC")]
	private bool HasFile(string fileName)
	{
		return default(bool);
	}
}
