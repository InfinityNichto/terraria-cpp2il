using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003C6")]
public abstract class FileData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003282")]
	protected string _path;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4003283")]
	protected bool _isCloudSave;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4003284")]
	public FileMetadata Metadata;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4003285")]
	public string Name;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4003286")]
	public readonly string Type;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4003287")]
	protected bool _isFavorite;

	[Cpp2IlInjected.Token(Token = "0x170005F3")]
	public string Path
	{
		[Cpp2IlInjected.Token(Token = "0x6002F75")]
		[Cpp2IlInjected.Address(RVA = "0xE3D178", Offset = "0xE3D178", VA = "0xE3D178")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005F4")]
	public bool IsCloudSave
	{
		[Cpp2IlInjected.Token(Token = "0x6002F76")]
		[Cpp2IlInjected.Address(RVA = "0xE3D180", Offset = "0xE3D180", VA = "0xE3D180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170005F5")]
	public bool IsFavorite
	{
		[Cpp2IlInjected.Token(Token = "0x6002F77")]
		[Cpp2IlInjected.Address(RVA = "0xE3D188", Offset = "0xE3D188", VA = "0xE3D188")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002F78")]
	[Cpp2IlInjected.Address(RVA = "0xE3D190", Offset = "0xE3D190", VA = "0xE3D190")]
	protected FileData(string type)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F79")]
	[Cpp2IlInjected.Address(RVA = "0xE3D1B0", Offset = "0xE3D1B0", VA = "0xE3D1B0")]
	protected FileData(string type, string path, bool isCloud)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F7A")]
	[Cpp2IlInjected.Address(RVA = "0xE3D28C", Offset = "0xE3D28C", VA = "0xE3D28C")]
	public void UpdatePath(string newPath)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F7B")]
	[Cpp2IlInjected.Address(RVA = "0xE3D294", Offset = "0xE3D294", VA = "0xE3D294")]
	public void ToggleFavorite()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F7C")]
	[Cpp2IlInjected.Address(RVA = "0xE3CB0C", Offset = "0xE3CB0C", VA = "0xE3CB0C")]
	public string GetFileName(bool includeExtension = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F7D")]
	[Cpp2IlInjected.Address(RVA = "0xE3D2A8", Offset = "0xE3D2A8", VA = "0xE3D2A8")]
	public void SetFavorite(bool favorite, bool saveChanges = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F7E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void SetAsActive();

	[Cpp2IlInjected.Token(Token = "0x6002F7F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract void MoveToCloud();

	[Cpp2IlInjected.Token(Token = "0x6002F80")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void MoveToLocal();
}
